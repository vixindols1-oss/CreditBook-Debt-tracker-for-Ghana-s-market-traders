Imports Microsoft.Data.Sqlite
Imports System.Security.Cryptography
Imports System.Text
Public Class frmSignUp

    Private Sub btnCreateAccount_Click(sender As Object, e As EventArgs) Handles btnCreateAccount.Click
        If txtFullName.Text.Trim() = "" OrElse
           txtPhone.Text.Trim() = "" OrElse
           txtUsername.Text.Trim() = "" OrElse
           txtPassword.Text = "" OrElse
           txtConfirmPassword.Text = "" Then

            MessageBox.Show("Please complete all fields.")
            Return
        End If

        If txtPassword.Text <> txtConfirmPassword.Text Then
            MessageBox.Show("Passwords do not match.")
            Return
        End If

        If txtPassword.Text.Length < 8 Then
            MessageBox.Show("Password must be at least 8 characters.")
            Return
        End If

        Dim passwordBytes As Byte() =
            SHA256.HashData(Encoding.UTF8.GetBytes(txtPassword.Text))

        Dim passwordHash As String =
            Convert.ToBase64String(passwordBytes)

        Try
            Using connection As New SqliteConnection(connectionString)
                connection.Open()

                Dim sql As String =
                    "INSERT INTO Users (FullName, Phone, Username, PasswordHash, CreatedAt) " &
                    "VALUES ($name, $phone, $username, $password, $created)"

                Using command As New SqliteCommand(sql, connection)
                    command.Parameters.AddWithValue("$name", txtFullName.Text.Trim())
                    command.Parameters.AddWithValue("$phone", txtPhone.Text.Trim())
                    command.Parameters.AddWithValue("$username", txtUsername.Text.Trim())
                    command.Parameters.AddWithValue("$password", passwordHash)
                    command.Parameters.AddWithValue("$created", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"))

                    command.ExecuteNonQuery()
                End Using
            End Using

            MessageBox.Show("Account created successfully!")
            Me.Close()

        Catch ex As SqliteException
            If ex.SqliteErrorCode = 19 Then
                MessageBox.Show("That username is already registered.")
            Else
                MessageBox.Show("Database error: " & ex.Message)
            End If

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub


End Class