Imports System.Globalization
Imports Microsoft.Data.Sqlite

Public Class frmAddCustomer

    Private Sub btnSaveCustomer_Click(sender As Object, e As EventArgs) Handles btnSaveCustomer.Click

        ' 1. Get information from the form
        Dim customerName As String = txtCustomerName.Text.Trim()
        Dim phone As String = txtPhone.Text.Trim()
        Dim amountText As String = txtInitialAmount.Text.Trim()
        Dim promisedDate As DateTime = dtpPromisedDate.Value.Date

        ' 2. Check for empty fields
        If String.IsNullOrWhiteSpace(customerName) Then
            MessageBox.Show("Please enter the customer's name.")
            txtCustomerName.Focus()
            Exit Sub
        End If

        If String.IsNullOrWhiteSpace(phone) Then
            MessageBox.Show("Please enter the customer's phone number.")
            txtPhone.Focus()
            Exit Sub
        End If

        If String.IsNullOrWhiteSpace(amountText) Then
            MessageBox.Show("Please enter the initial amount owed.")
            txtInitialAmount.Focus()
            Exit Sub
        End If

        ' 3. Validate Ghanaian phone number
        If phone.Length <> 10 OrElse
       Not phone.StartsWith("0") OrElse
       Not phone.All(Function(c) Char.IsDigit(c)) Then

            MessageBox.Show("Enter a valid 10-digit Ghanaian phone number.")
            txtPhone.Focus()
            Exit Sub

        End If

        ' 4. Validate the amount
        Dim initialAmount As Decimal

        If Not Decimal.TryParse(amountText, NumberStyles.Number,
                            CultureInfo.CurrentCulture, initialAmount) _
       OrElse initialAmount < 0 Then

            MessageBox.Show("Enter a valid amount greater than or equal to zero.")
            txtInitialAmount.Focus()
            Exit Sub

        End If

        ' 5. Validate promised payment date
        If promisedDate < DateTime.Today Then
            MessageBox.Show("The promised payment date cannot be in the past.")
            Exit Sub
        End If

        Try

            Using connection As New SqliteConnection(connectionString)

                connection.Open()

                Using dbTransaction As SqliteTransaction = connection.BeginTransaction()

                    ' 6. Save customer information
                    Dim customerSQL As String =
    "INSERT INTO Customers " &
    "(CustomerName, Phone, Balance, PromisedDate, CreatedAt, UserID) " &
    "VALUES (@name, @phone, @balance, @date, @created, @userId)"
                    Using customerCommand As New SqliteCommand(customerSQL, connection)

                        customerCommand.Transaction = dbTransaction

                        customerCommand.Parameters.AddWithValue("@name", customerName)
                        customerCommand.Parameters.AddWithValue("@phone", phone)
                        customerCommand.Parameters.AddWithValue("@balance", initialAmount)
                        customerCommand.Parameters.AddWithValue("@date",
                        promisedDate.ToString("yyyy-MM-dd"))
                        customerCommand.Parameters.AddWithValue("@created",
                        DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"))
                        customerCommand.Parameters.AddWithValue("@userId", CurrentUserID)

                        customerCommand.ExecuteNonQuery()

                    End Using

                    ' 7. Get the new customer's ID
                    Dim customerId As Long

                    Using idCommand As New SqliteCommand(
                    "SELECT last_insert_rowid()", connection)

                        idCommand.Transaction = dbTransaction
                        customerId = CLng(idCommand.ExecuteScalar())

                    End Using

                    ' 8. Record the initial credit transaction
                    If initialAmount > 0 Then

                        Dim transactionSQL As String =
                        "INSERT INTO Transactions " &
                        "(CustomerID, TransactionType, Amount, TransactionDate, Notes) " &
                        "VALUES (@id, @type, @amount, @date, @notes)"

                        Using transactionCommand As New SqliteCommand(
                        transactionSQL, connection)

                            transactionCommand.Transaction = dbTransaction

                            transactionCommand.Parameters.AddWithValue("@id", customerId)
                            transactionCommand.Parameters.AddWithValue("@type", "Credit")
                            transactionCommand.Parameters.AddWithValue("@amount", initialAmount)
                            transactionCommand.Parameters.AddWithValue("@date",
                            DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"))
                            transactionCommand.Parameters.AddWithValue("@notes",
                            "Initial customer credit")

                            transactionCommand.ExecuteNonQuery()

                        End Using

                    End If

                    ' 9. Save both operations together
                    dbTransaction.Commit()

                End Using

            End Using

            MessageBox.Show(
            "Customer registered successfully!",
            "CreditBook",
            MessageBoxButtons.OK,
            MessageBoxIcon.Information)

            Me.Close()

        Catch ex As SqliteException

            If ex.SqliteErrorCode = 19 Then

                MessageBox.Show(
                "This phone number already exists. Please check the number.",
                "Duplicate Customer",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning)

            Else

                MessageBox.Show(
                "Database error: " & ex.Message,
                "CreditBook Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error)

            End If

        Catch ex As Exception

            MessageBox.Show(
            "Something went wrong: " & ex.Message,
            "CreditBook Error",
            MessageBoxButtons.OK,
            MessageBoxIcon.Error)

        End Try

    End Sub
End Class