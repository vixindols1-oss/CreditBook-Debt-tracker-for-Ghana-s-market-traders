<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSignUp
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSignUp))
        lblTitle = New Label()
        Label1 = New Label()
        lblFullName = New Label()
        lblPhone = New Label()
        lblUsername = New Label()
        lblPassword = New Label()
        lblConfirmPassword = New Label()
        txtFullName = New TextBox()
        txtPhone = New TextBox()
        txtUsername = New TextBox()
        txtPassword = New TextBox()
        txtConfirmPassword = New TextBox()
        btnCreateAccount = New Button()
        btnBackToLogin = New Button()
        PictureBox1 = New PictureBox()
        PictureBox2 = New PictureBox()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' lblTitle
        ' 
        lblTitle.AutoSize = True
        lblTitle.Font = New Font("Segoe UI", 22F, FontStyle.Bold)
        lblTitle.ForeColor = Color.FromArgb(CByte(0), CByte(64), CByte(0))
        lblTitle.Location = New Point(197, 9)
        lblTitle.Name = "lblTitle"
        lblTitle.Size = New Size(303, 41)
        lblTitle.TabIndex = 0
        lblTitle.Text = "Create Your Account"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 10F, FontStyle.Bold)
        Label1.ForeColor = Color.FromArgb(CByte(0), CByte(64), CByte(0))
        Label1.Location = New Point(267, 61)
        Label1.Name = "Label1"
        Label1.Size = New Size(161, 19)
        Label1.TabIndex = 1
        Label1.Text = "Join CreditBook Today"
        ' 
        ' lblFullName
        ' 
        lblFullName.AutoSize = True
        lblFullName.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        lblFullName.ForeColor = Color.FromArgb(CByte(0), CByte(64), CByte(0))
        lblFullName.Location = New Point(267, 110)
        lblFullName.Name = "lblFullName"
        lblFullName.Size = New Size(62, 15)
        lblFullName.TabIndex = 2
        lblFullName.Text = "Full Name"
        ' 
        ' lblPhone
        ' 
        lblPhone.AutoSize = True
        lblPhone.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        lblPhone.ForeColor = Color.FromArgb(CByte(0), CByte(64), CByte(0))
        lblPhone.Location = New Point(267, 177)
        lblPhone.Name = "lblPhone"
        lblPhone.Size = New Size(91, 15)
        lblPhone.TabIndex = 3
        lblPhone.Text = "Phone Number"
        ' 
        ' lblUsername
        ' 
        lblUsername.AutoSize = True
        lblUsername.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        lblUsername.ForeColor = Color.FromArgb(CByte(0), CByte(64), CByte(0))
        lblUsername.Location = New Point(267, 238)
        lblUsername.Name = "lblUsername"
        lblUsername.Size = New Size(64, 15)
        lblUsername.TabIndex = 4
        lblUsername.Text = "Username"
        ' 
        ' lblPassword
        ' 
        lblPassword.AutoSize = True
        lblPassword.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        lblPassword.ForeColor = Color.FromArgb(CByte(0), CByte(64), CByte(0))
        lblPassword.Location = New Point(267, 308)
        lblPassword.Name = "lblPassword"
        lblPassword.Size = New Size(59, 15)
        lblPassword.TabIndex = 5
        lblPassword.Text = "Password"
        ' 
        ' lblConfirmPassword
        ' 
        lblConfirmPassword.AutoSize = True
        lblConfirmPassword.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        lblConfirmPassword.ForeColor = Color.FromArgb(CByte(0), CByte(64), CByte(0))
        lblConfirmPassword.Location = New Point(267, 380)
        lblConfirmPassword.Name = "lblConfirmPassword"
        lblConfirmPassword.Size = New Size(107, 15)
        lblConfirmPassword.TabIndex = 6
        lblConfirmPassword.Text = "Confirm Password"
        ' 
        ' txtFullName
        ' 
        txtFullName.Location = New Point(267, 128)
        txtFullName.Name = "txtFullName"
        txtFullName.Size = New Size(183, 23)
        txtFullName.TabIndex = 7
        ' 
        ' txtPhone
        ' 
        txtPhone.Location = New Point(267, 195)
        txtPhone.Name = "txtPhone"
        txtPhone.Size = New Size(183, 23)
        txtPhone.TabIndex = 8
        ' 
        ' txtUsername
        ' 
        txtUsername.Location = New Point(267, 256)
        txtUsername.Name = "txtUsername"
        txtUsername.Size = New Size(183, 23)
        txtUsername.TabIndex = 9
        ' 
        ' txtPassword
        ' 
        txtPassword.Location = New Point(267, 326)
        txtPassword.Name = "txtPassword"
        txtPassword.Size = New Size(183, 23)
        txtPassword.TabIndex = 10
        txtPassword.UseSystemPasswordChar = True
        ' 
        ' txtConfirmPassword
        ' 
        txtConfirmPassword.Location = New Point(267, 398)
        txtConfirmPassword.Name = "txtConfirmPassword"
        txtConfirmPassword.Size = New Size(183, 23)
        txtConfirmPassword.TabIndex = 11
        txtConfirmPassword.UseSystemPasswordChar = True
        ' 
        ' btnCreateAccount
        ' 
        btnCreateAccount.BackColor = Color.FromArgb(CByte(0), CByte(64), CByte(0))
        btnCreateAccount.FlatStyle = FlatStyle.Flat
        btnCreateAccount.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        btnCreateAccount.ForeColor = Color.White
        btnCreateAccount.Location = New Point(147, 482)
        btnCreateAccount.Name = "btnCreateAccount"
        btnCreateAccount.Size = New Size(437, 41)
        btnCreateAccount.TabIndex = 12
        btnCreateAccount.Text = "Create Account"
        btnCreateAccount.UseVisualStyleBackColor = False
        ' 
        ' btnBackToLogin
        ' 
        btnBackToLogin.BackColor = Color.Lime
        btnBackToLogin.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        btnBackToLogin.Location = New Point(293, 555)
        btnBackToLogin.Name = "btnBackToLogin"
        btnBackToLogin.Size = New Size(160, 23)
        btnBackToLogin.TabIndex = 13
        btnBackToLogin.Text = "Back to Login"
        btnBackToLogin.UseVisualStyleBackColor = False
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = Color.Transparent
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(-25, 9)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(222, 386)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 14
        PictureBox1.TabStop = False
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), Image)
        PictureBox2.Location = New Point(506, 9)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(195, 386)
        PictureBox2.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox2.TabIndex = 15
        PictureBox2.TabStop = False
        ' 
        ' frmSignUp
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(704, 615)
        Controls.Add(PictureBox2)
        Controls.Add(PictureBox1)
        Controls.Add(btnBackToLogin)
        Controls.Add(btnCreateAccount)
        Controls.Add(txtConfirmPassword)
        Controls.Add(txtPassword)
        Controls.Add(txtUsername)
        Controls.Add(txtPhone)
        Controls.Add(txtFullName)
        Controls.Add(lblConfirmPassword)
        Controls.Add(lblPassword)
        Controls.Add(lblUsername)
        Controls.Add(lblPhone)
        Controls.Add(lblFullName)
        Controls.Add(Label1)
        Controls.Add(lblTitle)
        FormBorderStyle = FormBorderStyle.FixedSingle
        MaximizeBox = False
        Name = "frmSignUp"
        StartPosition = FormStartPosition.CenterScreen
        Text = "CreditBook - Create Account"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblTitle As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents lblFullName As Label
    Friend WithEvents lblPhone As Label
    Friend WithEvents lblUsername As Label
    Friend WithEvents lblPassword As Label
    Friend WithEvents lblConfirmPassword As Label
    Friend WithEvents txtFullName As TextBox
    Friend WithEvents txtPhone As TextBox
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents txtConfirmPassword As TextBox
    Friend WithEvents btnCreateAccount As Button
    Friend WithEvents btnBackToLogin As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
End Class
