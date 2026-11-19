<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmLogin
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLogin))
        PictureBox1 = New PictureBox()
        lblTitle = New Label()
        lblTagline = New Label()
        lblUsername = New Label()
        txtUsername = New TextBox()
        lblPassword = New Label()
        txtPassword = New TextBox()
        chkRemember = New CheckBox()
        btnLogin = New Button()
        btnSignUp = New Button()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Dock = DockStyle.Left
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(0, 0)
        PictureBox1.MinimumSize = New Size(280, 0)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(280, 461)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' lblTitle
        ' 
        lblTitle.AutoSize = True
        lblTitle.Font = New Font("Segoe UI", 24F, FontStyle.Bold)
        lblTitle.ForeColor = Color.Green
        lblTitle.Location = New Point(338, 27)
        lblTitle.Name = "lblTitle"
        lblTitle.Size = New Size(190, 45)
        lblTitle.TabIndex = 1
        lblTitle.Text = "CreditBook"
        ' 
        ' lblTagline
        ' 
        lblTagline.AutoSize = True
        lblTagline.Font = New Font("Segoe UI", 10F, FontStyle.Bold)
        lblTagline.ForeColor = Color.Olive
        lblTagline.Location = New Point(341, 83)
        lblTagline.Name = "lblTagline"
        lblTagline.Size = New Size(214, 19)
        lblTagline.TabIndex = 2
        lblTagline.Text = "Keep every cedi you are owed"
        ' 
        ' lblUsername
        ' 
        lblUsername.AutoSize = True
        lblUsername.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        lblUsername.ForeColor = Color.FromArgb(CByte(0), CByte(192), CByte(0))
        lblUsername.Location = New Point(338, 135)
        lblUsername.Name = "lblUsername"
        lblUsername.Size = New Size(64, 15)
        lblUsername.TabIndex = 3
        lblUsername.Text = "Username"
        ' 
        ' txtUsername
        ' 
        txtUsername.Location = New Point(338, 153)
        txtUsername.Name = "txtUsername"
        txtUsername.Size = New Size(293, 23)
        txtUsername.TabIndex = 4
        ' 
        ' lblPassword
        ' 
        lblPassword.AutoSize = True
        lblPassword.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        lblPassword.ForeColor = Color.FromArgb(CByte(0), CByte(192), CByte(0))
        lblPassword.Location = New Point(341, 211)
        lblPassword.Name = "lblPassword"
        lblPassword.Size = New Size(59, 15)
        lblPassword.TabIndex = 5
        lblPassword.Text = "Password"
        ' 
        ' txtPassword
        ' 
        txtPassword.Location = New Point(338, 229)
        txtPassword.Name = "txtPassword"
        txtPassword.Size = New Size(293, 23)
        txtPassword.TabIndex = 6
        txtPassword.UseSystemPasswordChar = True
        ' 
        ' chkRemember
        ' 
        chkRemember.AutoSize = True
        chkRemember.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        chkRemember.ForeColor = Color.FromArgb(CByte(128), CByte(64), CByte(64))
        chkRemember.Location = New Point(327, 282)
        chkRemember.Name = "chkRemember"
        chkRemember.Size = New Size(110, 19)
        chkRemember.TabIndex = 7
        chkRemember.Text = "Remember me"
        chkRemember.UseVisualStyleBackColor = True
        ' 
        ' btnLogin
        ' 
        btnLogin.BackColor = Color.DarkGreen
        btnLogin.FlatStyle = FlatStyle.Flat
        btnLogin.Font = New Font("Segoe UI", 10F, FontStyle.Bold)
        btnLogin.ForeColor = Color.White
        btnLogin.Location = New Point(341, 410)
        btnLogin.Name = "btnLogin"
        btnLogin.Size = New Size(293, 29)
        btnLogin.TabIndex = 8
        btnLogin.Text = "Login"
        btnLogin.UseVisualStyleBackColor = False
        ' 
        ' btnSignUp
        ' 
        btnSignUp.BackColor = Color.FromArgb(CByte(0), CByte(64), CByte(0))
        btnSignUp.FlatStyle = FlatStyle.Flat
        btnSignUp.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        btnSignUp.ForeColor = Color.White
        btnSignUp.Location = New Point(341, 343)
        btnSignUp.Name = "btnSignUp"
        btnSignUp.Size = New Size(293, 31)
        btnSignUp.TabIndex = 9
        btnSignUp.Text = "Create New Account"
        btnSignUp.UseVisualStyleBackColor = False
        ' 
        ' frmLogin
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(704, 461)
        Controls.Add(btnSignUp)
        Controls.Add(btnLogin)
        Controls.Add(chkRemember)
        Controls.Add(txtPassword)
        Controls.Add(lblPassword)
        Controls.Add(txtUsername)
        Controls.Add(lblUsername)
        Controls.Add(lblTagline)
        Controls.Add(lblTitle)
        Controls.Add(PictureBox1)
        FormBorderStyle = FormBorderStyle.FixedSingle
        MaximizeBox = False
        Name = "frmLogin"
        StartPosition = FormStartPosition.CenterScreen
        Text = "CreditBook - Login"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents lblTitle As Label
    Friend WithEvents lblTagline As Label
    Friend WithEvents lblUsername As Label
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents lblPassword As Label
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents chkRemember As CheckBox
    Friend WithEvents btnLogin As Button
    Friend WithEvents btnSignUp As Button

End Class
