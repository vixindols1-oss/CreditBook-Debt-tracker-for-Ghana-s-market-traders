Imports Microsoft.Data.Sqlite
Imports System.Security.Cryptography
Imports System.Text
Public Class frmLogin
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click

        If txtUsername.Text.Trim() = "" OrElse txtPassword.Text = "" Then
            MessageBox.Show("Please enter your username and password.")
            Return
        End If

        Dim enteredPasswordHash As String

        Using sha As SHA256 = SHA256.Create()
            Dim passwordBytes As Byte() =
            Encoding.UTF8.GetBytes(txtPassword.Text)

            enteredPasswordHash =
            Convert.ToBase64String(sha.ComputeHash(passwordBytes))
        End Using

        Dim foundUserID As Integer = 0
        Dim savedHash As String = ""

        Try
            ' STEP 1: Read the account details
            Using connection As New SqliteConnection(connectionString)
                connection.Open()

                Dim sql As String =
                "SELECT UserID, PasswordHash FROM Users WHERE Username = $username"

                Using command As New SqliteCommand(sql, connection)

                    command.Parameters.AddWithValue(
                    "$username", txtUsername.Text.Trim())

                    Using reader = command.ExecuteReader()

                        If reader.Read() Then
                            foundUserID = Convert.ToInt32(reader("UserID"))
                            savedHash = reader("PasswordHash").ToString()
                        End If

                    End Using
                End Using
            End Using

            ' STEP 2: Verify the password
            If foundUserID = 0 OrElse
           Not String.Equals(enteredPasswordHash, savedHash,
                             StringComparison.Ordinal) Then

                MessageBox.Show("Incorrect username or password.")
                Return
            End If

            CurrentUserID = foundUserID

            ' STEP 3: Migrate old customer records
            ' This runs only after the reader and first connection are closed.
            Using updateConnection As New SqliteConnection(connectionString)
                updateConnection.Open()

                Dim updateSQL As String =
                "UPDATE Customers SET UserID = $userId WHERE UserID IS NULL"

                Using updateCommand As New SqliteCommand(updateSQL, updateConnection)

                    updateCommand.Parameters.AddWithValue(
                    "$userId", CurrentUserID)

                    updateCommand.ExecuteNonQuery()

                End Using
            End Using

            ' STEP 4: Open the dashboard
            MessageBox.Show("Login successful!")

            frmDashboard.Show()
            Me.Hide()

        Catch ex As Exception
            MessageBox.Show("Login error: " & ex.Message)
        End Try

    End Sub

    Private Sub frmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        InitializeDatabase()
    End Sub

    Private Sub btnSignUp_Click(sender As Object, e As EventArgs) Handles btnSignUp.Click


        Using signUpForm As New frmSignUp()
            signUpForm.ShowDialog()
        End Using

    End Sub

End Class
