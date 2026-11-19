<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSettings
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        lblHeading = New Label()
        lblSubtitle = New Label()
        grpAccount = New GroupBox()
        txtUsername = New TextBox()
        lblUsername = New Label()
        btnUpdateProfile = New Button()
        txtPhone = New TextBox()
        txtFullName = New TextBox()
        lblPhoneNumber = New Label()
        lblFullNmae = New Label()
        GroupBox1 = New GroupBox()
        btnChangePassword = New Button()
        txtConfirmPassword = New TextBox()
        txtNewPassword = New TextBox()
        lblConfirmPassword = New Label()
        lblNewPassword = New Label()
        txtCurrentPassword = New TextBox()
        lblCurrentPassword = New Label()
        grpDatabase = New GroupBox()
        btnOpenDatabaseFolder = New Button()
        txtDatabasePath = New TextBox()
        lblDatabasePath = New Label()
        GroupBox2 = New GroupBox()
        txtabout = New Label()
        lblCopyright = New Label()
        grpAccount.SuspendLayout()
        GroupBox1.SuspendLayout()
        grpDatabase.SuspendLayout()
        GroupBox2.SuspendLayout()
        SuspendLayout()
        ' 
        ' lblHeading
        ' 
        lblHeading.AutoSize = True
        lblHeading.Font = New Font("Segoe UI", 20F, FontStyle.Bold)
        lblHeading.ForeColor = Color.FromArgb(CByte(0), CByte(64), CByte(0))
        lblHeading.Location = New Point(429, 9)
        lblHeading.Name = "lblHeading"
        lblHeading.Size = New Size(122, 37)
        lblHeading.TabIndex = 0
        lblHeading.Text = "Settings"
        ' 
        ' lblSubtitle
        ' 
        lblSubtitle.AutoSize = True
        lblSubtitle.Font = New Font("Segoe UI", 10F, FontStyle.Bold)
        lblSubtitle.ForeColor = Color.FromArgb(CByte(0), CByte(64), CByte(0))
        lblSubtitle.Location = New Point(349, 46)
        lblSubtitle.Name = "lblSubtitle"
        lblSubtitle.Size = New Size(345, 19)
        lblSubtitle.TabIndex = 1
        lblSubtitle.Text = "Manage your account and application preferences"
        ' 
        ' grpAccount
        ' 
        grpAccount.Controls.Add(txtUsername)
        grpAccount.Controls.Add(lblUsername)
        grpAccount.Controls.Add(btnUpdateProfile)
        grpAccount.Controls.Add(txtPhone)
        grpAccount.Controls.Add(txtFullName)
        grpAccount.Controls.Add(lblPhoneNumber)
        grpAccount.Controls.Add(lblFullNmae)
        grpAccount.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        grpAccount.ForeColor = Color.FromArgb(CByte(0), CByte(64), CByte(0))
        grpAccount.Location = New Point(12, 68)
        grpAccount.Name = "grpAccount"
        grpAccount.Size = New Size(950, 202)
        grpAccount.TabIndex = 2
        grpAccount.TabStop = False
        grpAccount.Text = "Account Information"
        ' 
        ' txtUsername
        ' 
        txtUsername.Location = New Point(337, 43)
        txtUsername.Name = "txtUsername"
        txtUsername.Size = New Size(226, 29)
        txtUsername.TabIndex = 6
        ' 
        ' lblUsername
        ' 
        lblUsername.AutoSize = True
        lblUsername.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        lblUsername.Location = New Point(337, 25)
        lblUsername.Name = "lblUsername"
        lblUsername.Size = New Size(64, 15)
        lblUsername.TabIndex = 5
        lblUsername.Text = "Username"
        ' 
        ' btnUpdateProfile
        ' 
        btnUpdateProfile.BackColor = Color.FromArgb(CByte(0), CByte(64), CByte(0))
        btnUpdateProfile.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        btnUpdateProfile.ForeColor = Color.White
        btnUpdateProfile.Location = New Point(107, 154)
        btnUpdateProfile.Name = "btnUpdateProfile"
        btnUpdateProfile.Size = New Size(333, 26)
        btnUpdateProfile.TabIndex = 4
        btnUpdateProfile.Text = "Profile"
        btnUpdateProfile.UseVisualStyleBackColor = False
        ' 
        ' txtPhone
        ' 
        txtPhone.Location = New Point(0, 108)
        txtPhone.Name = "txtPhone"
        txtPhone.Size = New Size(209, 29)
        txtPhone.TabIndex = 3
        ' 
        ' txtFullName
        ' 
        txtFullName.Location = New Point(0, 43)
        txtFullName.Name = "txtFullName"
        txtFullName.Size = New Size(209, 29)
        txtFullName.TabIndex = 2
        ' 
        ' lblPhoneNumber
        ' 
        lblPhoneNumber.AutoSize = True
        lblPhoneNumber.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        lblPhoneNumber.Location = New Point(10, 90)
        lblPhoneNumber.Name = "lblPhoneNumber"
        lblPhoneNumber.Size = New Size(91, 15)
        lblPhoneNumber.TabIndex = 1
        lblPhoneNumber.Text = "Phone Number"
        ' 
        ' lblFullNmae
        ' 
        lblFullNmae.AutoSize = True
        lblFullNmae.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        lblFullNmae.Location = New Point(10, 25)
        lblFullNmae.Name = "lblFullNmae"
        lblFullNmae.Size = New Size(62, 15)
        lblFullNmae.TabIndex = 0
        lblFullNmae.Text = "Full Name"
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(btnChangePassword)
        GroupBox1.Controls.Add(txtConfirmPassword)
        GroupBox1.Controls.Add(txtNewPassword)
        GroupBox1.Controls.Add(lblConfirmPassword)
        GroupBox1.Controls.Add(lblNewPassword)
        GroupBox1.Controls.Add(txtCurrentPassword)
        GroupBox1.Controls.Add(lblCurrentPassword)
        GroupBox1.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        GroupBox1.ForeColor = Color.FromArgb(CByte(0), CByte(64), CByte(0))
        GroupBox1.Location = New Point(12, 276)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(950, 254)
        GroupBox1.TabIndex = 3
        GroupBox1.TabStop = False
        GroupBox1.Text = "Change Password"
        ' 
        ' btnChangePassword
        ' 
        btnChangePassword.BackColor = Color.FromArgb(CByte(0), CByte(64), CByte(0))
        btnChangePassword.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        btnChangePassword.ForeColor = Color.White
        btnChangePassword.Location = New Point(255, 202)
        btnChangePassword.Name = "btnChangePassword"
        btnChangePassword.Size = New Size(236, 30)
        btnChangePassword.TabIndex = 6
        btnChangePassword.Text = "Change Password"
        btnChangePassword.UseVisualStyleBackColor = False
        ' 
        ' txtConfirmPassword
        ' 
        txtConfirmPassword.Location = New Point(5, 171)
        txtConfirmPassword.Name = "txtConfirmPassword"
        txtConfirmPassword.Size = New Size(209, 29)
        txtConfirmPassword.TabIndex = 5
        txtConfirmPassword.UseSystemPasswordChar = True
        ' 
        ' txtNewPassword
        ' 
        txtNewPassword.Location = New Point(6, 106)
        txtNewPassword.Name = "txtNewPassword"
        txtNewPassword.Size = New Size(208, 29)
        txtNewPassword.TabIndex = 4
        txtNewPassword.UseSystemPasswordChar = True
        ' 
        ' lblConfirmPassword
        ' 
        lblConfirmPassword.AutoSize = True
        lblConfirmPassword.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        lblConfirmPassword.Location = New Point(4, 153)
        lblConfirmPassword.Name = "lblConfirmPassword"
        lblConfirmPassword.Size = New Size(107, 15)
        lblConfirmPassword.TabIndex = 3
        lblConfirmPassword.Text = "Confirm Password"
        ' 
        ' lblNewPassword
        ' 
        lblNewPassword.AutoSize = True
        lblNewPassword.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        lblNewPassword.Location = New Point(6, 88)
        lblNewPassword.Name = "lblNewPassword"
        lblNewPassword.Size = New Size(88, 15)
        lblNewPassword.TabIndex = 2
        lblNewPassword.Text = "New Password"
        ' 
        ' txtCurrentPassword
        ' 
        txtCurrentPassword.Location = New Point(6, 43)
        txtCurrentPassword.Name = "txtCurrentPassword"
        txtCurrentPassword.Size = New Size(208, 29)
        txtCurrentPassword.TabIndex = 1
        txtCurrentPassword.UseSystemPasswordChar = True
        ' 
        ' lblCurrentPassword
        ' 
        lblCurrentPassword.AutoSize = True
        lblCurrentPassword.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        lblCurrentPassword.Location = New Point(6, 25)
        lblCurrentPassword.Name = "lblCurrentPassword"
        lblCurrentPassword.Size = New Size(105, 15)
        lblCurrentPassword.TabIndex = 0
        lblCurrentPassword.Text = "Current Password"
        ' 
        ' grpDatabase
        ' 
        grpDatabase.Controls.Add(btnOpenDatabaseFolder)
        grpDatabase.Controls.Add(txtDatabasePath)
        grpDatabase.Controls.Add(lblDatabasePath)
        grpDatabase.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        grpDatabase.ForeColor = Color.FromArgb(CByte(0), CByte(64), CByte(0))
        grpDatabase.Location = New Point(12, 536)
        grpDatabase.Name = "grpDatabase"
        grpDatabase.Size = New Size(950, 115)
        grpDatabase.TabIndex = 4
        grpDatabase.TabStop = False
        grpDatabase.Text = "Database Information"
        ' 
        ' btnOpenDatabaseFolder
        ' 
        btnOpenDatabaseFolder.BackColor = Color.FromArgb(CByte(0), CByte(64), CByte(0))
        btnOpenDatabaseFolder.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        btnOpenDatabaseFolder.ForeColor = Color.White
        btnOpenDatabaseFolder.Location = New Point(199, 80)
        btnOpenDatabaseFolder.Name = "btnOpenDatabaseFolder"
        btnOpenDatabaseFolder.Size = New Size(264, 23)
        btnOpenDatabaseFolder.TabIndex = 2
        btnOpenDatabaseFolder.Text = "Open Database Folder"
        btnOpenDatabaseFolder.UseVisualStyleBackColor = False
        ' 
        ' txtDatabasePath
        ' 
        txtDatabasePath.Location = New Point(6, 37)
        txtDatabasePath.Name = "txtDatabasePath"
        txtDatabasePath.ReadOnly = True
        txtDatabasePath.Size = New Size(208, 29)
        txtDatabasePath.TabIndex = 1
        ' 
        ' lblDatabasePath
        ' 
        lblDatabasePath.AutoSize = True
        lblDatabasePath.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        lblDatabasePath.Location = New Point(6, 19)
        lblDatabasePath.Name = "lblDatabasePath"
        lblDatabasePath.Size = New Size(108, 15)
        lblDatabasePath.TabIndex = 0
        lblDatabasePath.Text = "Database Location"
        ' 
        ' GroupBox2
        ' 
        GroupBox2.Controls.Add(lblCopyright)
        GroupBox2.Controls.Add(txtabout)
        GroupBox2.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        GroupBox2.ForeColor = Color.FromArgb(CByte(0), CByte(64), CByte(0))
        GroupBox2.Location = New Point(12, 657)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(950, 90)
        GroupBox2.TabIndex = 5
        GroupBox2.TabStop = False
        GroupBox2.Text = "About CreditBook"
        ' 
        ' txtabout
        ' 
        txtabout.AutoSize = True
        txtabout.Font = New Font("Segoe UI", 10F, FontStyle.Bold)
        txtabout.Location = New Point(6, 25)
        txtabout.Name = "txtabout"
        txtabout.Size = New Size(1033, 19)
        txtabout.TabIndex = 0
        txtabout.Text = "CreditBook - Keep every cedi you are owed. Version 1.0. Developed to help market traders manage customer debts, credit transactions and repayments."
        txtabout.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' lblCopyright
        ' 
        lblCopyright.AutoSize = True
        lblCopyright.Font = New Font("Segoe UI", 10F, FontStyle.Bold)
        lblCopyright.Location = New Point(10, 54)
        lblCopyright.Name = "lblCopyright"
        lblCopyright.Size = New Size(274, 19)
        lblCopyright.TabIndex = 1
        lblCopyright.Text = "© 2026 CreditBook. All rights reserved."
        ' 
        ' frmSettings
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1100, 749)
        Controls.Add(GroupBox2)
        Controls.Add(grpDatabase)
        Controls.Add(GroupBox1)
        Controls.Add(grpAccount)
        Controls.Add(lblSubtitle)
        Controls.Add(lblHeading)
        Name = "frmSettings"
        StartPosition = FormStartPosition.CenterScreen
        Text = "CreditBook - Settings"
        grpAccount.ResumeLayout(False)
        grpAccount.PerformLayout()
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        grpDatabase.ResumeLayout(False)
        grpDatabase.PerformLayout()
        GroupBox2.ResumeLayout(False)
        GroupBox2.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblHeading As Label
    Friend WithEvents lblSubtitle As Label
    Friend WithEvents grpAccount As GroupBox
    Friend WithEvents txtPhone As TextBox
    Friend WithEvents txtFullName As TextBox
    Friend WithEvents lblPhoneNumber As Label
    Friend WithEvents lblFullNmae As Label
    Friend WithEvents btnUpdateProfile As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtConfirmPassword As TextBox
    Friend WithEvents txtNewPassword As TextBox
    Friend WithEvents lblConfirmPassword As Label
    Friend WithEvents lblNewPassword As Label
    Friend WithEvents txtCurrentPassword As TextBox
    Friend WithEvents lblCurrentPassword As Label
    Friend WithEvents btnChangePassword As Button
    Friend WithEvents grpDatabase As GroupBox
    Friend WithEvents btnOpenDatabaseFolder As Button
    Friend WithEvents txtDatabasePath As TextBox
    Friend WithEvents lblDatabasePath As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents txtabout As Label
    Friend WithEvents lblUsername As Label
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents lblCopyright As Label
End Class
