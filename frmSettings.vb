Public Class frmSettings
    Private Sub frmSettings_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Try

            Dim profile As DataTable = DbHelper.GetCurrentUserProfile()

            If profile.Rows.Count > 0 Then

                txtFullName.Text = profile.Rows(0)("FullName").ToString()
                txtPhone.Text = profile.Rows(0)("Phone").ToString()
                txtFullName.Text = profile.Rows(0)("Username").ToString()

            Else

                MessageBox.Show("Unable to find your account.")

            End If

            txtDatabasePath.Text = DbHelper.dbPath

        Catch ex As Exception

            MessageBox.Show("Unable to load settings: " & ex.Message)

        End Try

    End Sub

    Private Sub btnUpdateProfile_Click(sender As Object, e As EventArgs) Handles btnUpdateProfile.Click
        If txtFullName.Text.Trim() = "" OrElse
   txtPhone.Text.Trim() = "" OrElse
   txtFullName.Text.Trim() = "" Then

            MessageBox.Show("Please complete all account information.")
            Return

        End If

        Try

            DbHelper.UpdateUserProfile(
                txtFullName.Text.Trim(),
                txtPhone.Text.Trim(),
                txtFullName.Text.Trim()
            )

            MessageBox.Show("Profile updated successfully!")

        Catch ex As Exception

            MessageBox.Show("Unable to update profile: " & ex.Message)

        End Try
    End Sub

    Private Sub btnChangePassword_Click(sender As Object, e As EventArgs) Handles btnChangePassword.Click
        If txtCurrentPassword.Text.Trim() = "" OrElse
   txtNewPassword.Text.Trim() = "" OrElse
   txtConfirmPassword.Text.Trim() = "" Then

            MessageBox.Show("Please complete all password fields.")
            Return

        End If

        If txtNewPassword.Text.Length < 8 Then

            MessageBox.Show("Your new password must contain at least 8 characters.")
            Return

        End If

        If txtNewPassword.Text <> txtConfirmPassword.Text Then

            MessageBox.Show("New password and confirmation do not match.")
            Return

        End If

        Try

            DbHelper.ChangeUserPassword(
                txtCurrentPassword.Text,
                txtNewPassword.Text
            )

            MessageBox.Show("Password changed successfully!")

            txtCurrentPassword.Clear()
            txtNewPassword.Clear()
            txtConfirmPassword.Clear()

        Catch ex As Exception

            MessageBox.Show("Unable to change password: " & ex.Message)

        End Try
    End Sub

    Private Sub btnOpenDatabaseFolder_Click(sender As Object, e As EventArgs) Handles btnOpenDatabaseFolder.Click
        Try

            Dim databaseFolder As String =
                System.IO.Path.GetDirectoryName(DbHelper.dbPath)

            If System.IO.Directory.Exists(databaseFolder) Then

                Process.Start(New ProcessStartInfo With {
                    .FileName = databaseFolder,
                    .UseShellExecute = True
                })

            Else

                MessageBox.Show("Database folder could not be found.")

            End If

        Catch ex As Exception

            MessageBox.Show("Unable to open database folder: " & ex.Message)

        End Try
    End Sub
End Class