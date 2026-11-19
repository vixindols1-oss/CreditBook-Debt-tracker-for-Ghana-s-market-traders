Imports Microsoft.Data.Sqlite
Imports System.IO
Imports System.Data
Imports System.Security.Cryptography
Imports System.Text
Module DbHelper
    Public CurrentUserID As Integer

    Public ReadOnly dbPath As String =
        Path.Combine(Application.StartupPath, "CreditBook.db")

    Public ReadOnly connectionString As String =
        "Data Source=" & dbPath

    Public Sub InitializeDatabase()

        Using connection As New SqliteConnection(connectionString)

            connection.Open()

            Dim customerTable As String =
                "CREATE TABLE IF NOT EXISTS Customers (" &
                "CustomerID INTEGER PRIMARY KEY AUTOINCREMENT, " &
                "CustomerName TEXT NOT NULL, " &
                "Phone TEXT NOT NULL UNIQUE, " &
                "Balance NUMERIC NOT NULL DEFAULT 0, " &
                "PromisedDate TEXT, " &
                "CreatedAt TEXT NOT NULL)"

            Using command As New SqliteCommand(customerTable, connection)
                command.ExecuteNonQuery()
            End Using
            Dim hasUserId As Boolean = False

            Using checkCommand As New SqliteCommand(
    "PRAGMA table_info(Customers);", connection)

                Using reader = checkCommand.ExecuteReader()

                    While reader.Read()

                        If reader("name").ToString() = "UserID" Then
                            hasUserId = True
                            Exit While
                        End If

                    End While

                End Using
            End Using

            If Not hasUserId Then

                Using alterCommand As New SqliteCommand(
        "ALTER TABLE Customers ADD COLUMN UserID INTEGER REFERENCES Users(UserID);",
        connection)

                    alterCommand.ExecuteNonQuery()

                End Using

            End If
            Dim transactionTable As String =
                "CREATE TABLE IF NOT EXISTS Transactions (" &
                "TransactionID INTEGER PRIMARY KEY AUTOINCREMENT, " &
                "CustomerID INTEGER NOT NULL, " &
                "TransactionType TEXT NOT NULL, " &
                "Amount NUMERIC NOT NULL, " &
                "TransactionDate TEXT NOT NULL, " &
                "Notes TEXT, " &
                "FOREIGN KEY(CustomerID) REFERENCES Customers(CustomerID))"

            Using command As New SqliteCommand(transactionTable, connection)
                command.ExecuteNonQuery()
                Using usersCommand As New SqliteCommand("
    CREATE TABLE IF NOT EXISTS Users (
        UserID INTEGER PRIMARY KEY AUTOINCREMENT,
        FullName TEXT NOT NULL,
        Phone TEXT NOT NULL,
        Username TEXT NOT NULL UNIQUE,
        PasswordHash TEXT NOT NULL,
        CreatedAt TEXT NOT NULL
    );", connection)

                    usersCommand.ExecuteNonQuery()

                End Using

            End Using

        End Using

    End Sub


    Public Function GetAllCustomers() As DataTable

        Dim customers As New DataTable()

        Using connection As New SqliteConnection(connectionString)

            connection.Open()

            Dim query As String =
            "SELECT CustomerID, " &
            "CustomerName AS 'Customer Name', " &
            "Phone AS 'Phone Number', " &
            "Balance AS 'Total Debt Owed (GH₵)', " &
            "PromisedDate AS 'Promised Date', " &
            "CASE " &
            "WHEN Balance <= 0 THEN 'Paid' " &
            "WHEN date(PromisedDate) < date('now','localtime') THEN 'Overdue' " &
            "ELSE 'Pending' END AS Status " &
           "FROM Customers WHERE UserID = $userId ORDER BY CustomerName"

            Using command As New SqliteCommand(query, connection)
                command.Parameters.AddWithValue("$userId", CurrentUserID)

                Using reader = command.ExecuteReader()

                    customers.Load(reader)

                End Using

            End Using

        End Using

        Return customers

    End Function
    Public Sub SaveTransaction(customerID As Integer,
                           transactionType As String,
                           amount As Decimal,
                           transactionDate As DateTime,
                           notes As String)

        If amount <= 0 Then
            Throw New Exception("Amount must be greater than zero.")
        End If

        If transactionType <> "Credit" AndAlso transactionType <> "Repayment" Then
            Throw New Exception("Invalid transaction type.")
        End If

        Using connection As New SqliteConnection(connectionString)

            connection.Open()

            Using dbTransaction = connection.BeginTransaction()

                Try

                    'Check customer ownership and get current balance
                    Dim currentBalance As Decimal

                    Using checkCommand As New SqliteCommand(
                        "SELECT Balance FROM Customers " &
                        "WHERE CustomerID = $customerID AND UserID = $userID",
                        connection, dbTransaction)

                        checkCommand.Parameters.AddWithValue("$customerID", customerID)
                        checkCommand.Parameters.AddWithValue("$userID", CurrentUserID)

                        Dim result = checkCommand.ExecuteScalar()

                        If result Is Nothing OrElse result Is DBNull.Value Then
                            Throw New Exception("Customer not found.")
                        End If

                        currentBalance = Convert.ToDecimal(result)

                    End Using

                    'Calculate new balance
                    Dim newBalance As Decimal

                    If transactionType = "Credit" Then

                        newBalance = currentBalance + amount

                    Else

                        If amount > currentBalance Then
                            Throw New Exception("Repayment cannot exceed the outstanding debt.")
                        End If

                        newBalance = currentBalance - amount

                    End If

                    'Save transaction record
                    Dim insertQuery As String =
                        "INSERT INTO Transactions " &
                        "(CustomerID, TransactionType, Amount, TransactionDate, Notes) " &
                        "VALUES ($customerID, $type, $amount, $date, $notes)"

                    Using insertCommand As New SqliteCommand(
                        insertQuery, connection, dbTransaction)

                        insertCommand.Parameters.AddWithValue("$customerID", customerID)
                        insertCommand.Parameters.AddWithValue("$type", transactionType)
                        insertCommand.Parameters.AddWithValue("$amount", amount)
                        insertCommand.Parameters.AddWithValue(
                            "$date", transactionDate.ToString("yyyy-MM-dd"))
                        insertCommand.Parameters.AddWithValue("$notes", notes)

                        insertCommand.ExecuteNonQuery()

                    End Using

                    'Update customer balance
                    Using updateCommand As New SqliteCommand(
                        "UPDATE Customers SET Balance = $balance " &
                        "WHERE CustomerID = $customerID AND UserID = $userID",
                        connection, dbTransaction)

                        updateCommand.Parameters.AddWithValue("$balance", newBalance)
                        updateCommand.Parameters.AddWithValue("$customerID", customerID)
                        updateCommand.Parameters.AddWithValue("$userID", CurrentUserID)

                        updateCommand.ExecuteNonQuery()

                    End Using

                    dbTransaction.Commit()

                Catch

                    dbTransaction.Rollback()
                    Throw

                End Try

            End Using

        End Using

    End Sub
    Public Function GetAllTransactions() As DataTable

        Dim transactions As New DataTable()

        Using connection As New SqliteConnection(connectionString)

            connection.Open()

            Dim query As String =
                "SELECT T.TransactionID, " &
                "C.CustomerName AS 'Customer Name', " &
                "T.TransactionType AS 'Transaction Type', " &
                "T.Amount AS 'Amount (GH₵)', " &
                "T.TransactionDate AS 'Transaction Date', " &
                "T.Notes AS 'Notes' " &
                "FROM Transactions T " &
                "INNER JOIN Customers C ON T.CustomerID = C.CustomerID " &
                "WHERE C.UserID = $userId " &
                "ORDER BY T.TransactionID DESC"

            Using command As New SqliteCommand(query, connection)

                command.Parameters.AddWithValue("$userId", CurrentUserID)

                Using reader = command.ExecuteReader()

                    transactions.Load(reader)

                End Using

            End Using

        End Using

        Return transactions

    End Function
    Public Function GetCurrentUserProfile() As DataTable

        Dim profile As New DataTable()

        Using connection As New SqliteConnection(connectionString)

            connection.Open()

            Dim query As String =
                "SELECT FullName, Phone, Username " &
                "FROM Users WHERE UserID = $userID"

            Using command As New SqliteCommand(query, connection)

                command.Parameters.AddWithValue("$userID", CurrentUserID)

                Using reader = command.ExecuteReader()
                    profile.Load(reader)
                End Using

            End Using

        End Using

        Return profile

    End Function


    Public Sub UpdateUserProfile(fullName As String,
                                 phone As String,
                                 username As String)

        Using connection As New SqliteConnection(connectionString)

            connection.Open()

            Dim query As String =
                "UPDATE Users SET " &
                "FullName = $name, " &
                "Phone = $phone, " &
                "Username = $username " &
                "WHERE UserID = $userID"

            Using command As New SqliteCommand(query, connection)

                command.Parameters.AddWithValue("$name", fullName)
                command.Parameters.AddWithValue("$phone", phone)
                command.Parameters.AddWithValue("$username", username)
                command.Parameters.AddWithValue("$userID", CurrentUserID)

                Dim rowsAffected As Integer = command.ExecuteNonQuery()

                If rowsAffected = 0 Then
                    Throw New Exception("User account could not be found.")
                End If

            End Using

        End Using

    End Sub

    Public Sub ChangeUserPassword(currentPassword As String,
                              newPassword As String)

        ' Hash the current password
        Dim currentHash As String

        Using sha As SHA256 = SHA256.Create()

            Dim passwordBytes As Byte() =
                Encoding.UTF8.GetBytes(currentPassword)

            currentHash =
                Convert.ToBase64String(sha.ComputeHash(passwordBytes))

        End Using

        ' Hash the new password
        Dim newHash As String

        Using sha As SHA256 = SHA256.Create()

            Dim passwordBytes As Byte() =
                Encoding.UTF8.GetBytes(newPassword)

            newHash =
                Convert.ToBase64String(sha.ComputeHash(passwordBytes))

        End Using

        Using connection As New SqliteConnection(connectionString)

            connection.Open()

            Dim query As String =
                "UPDATE Users SET PasswordHash = $newHash " &
                "WHERE UserID = $userID AND PasswordHash = $currentHash"

            Using command As New SqliteCommand(query, connection)

                command.Parameters.AddWithValue("$newHash", newHash)
                command.Parameters.AddWithValue("$userID", CurrentUserID)
                command.Parameters.AddWithValue("$currentHash", currentHash)

                Dim rowsAffected As Integer = command.ExecuteNonQuery()

                If rowsAffected = 0 Then
                    Throw New Exception("Your current password is incorrect.")
                End If

            End Using

        End Using

    End Sub
    Public Function GetReportSummary() As DataTable

        Dim summary As New DataTable()

        Using connection As New SqliteConnection(connectionString)

            connection.Open()

            Dim query As String = "
            SELECT
                (SELECT COUNT(*)
                 FROM Customers
                 WHERE UserID = $userID) AS TotalCustomers,

                (SELECT COALESCE(SUM(Balance), 0)
                 FROM Customers
                 WHERE UserID = $userID) AS OutstandingDebt,

                (SELECT COALESCE(SUM(T.Amount), 0)
                 FROM Transactions T
                 INNER JOIN Customers C
                 ON T.CustomerID = C.CustomerID
                 WHERE C.UserID = $userID
                 AND T.TransactionType = 'Credit') AS TotalCredit,

                (SELECT COALESCE(SUM(T.Amount), 0)
                 FROM Transactions T
                 INNER JOIN Customers C
                 ON T.CustomerID = C.CustomerID
                 WHERE C.UserID = $userID
                 AND T.TransactionType = 'Repayment') AS TotalRepayments
        "

            Using command As New SqliteCommand(query, connection)

                command.Parameters.AddWithValue("$userID", CurrentUserID)

                Using reader = command.ExecuteReader()
                    summary.Load(reader)
                End Using

            End Using

        End Using

        Return summary

    End Function
End Module