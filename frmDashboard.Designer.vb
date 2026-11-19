<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDashboard
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDashboard))
        pnlSidebar = New Panel()
        PictureBox1 = New PictureBox()
        btnLogout = New Button()
        btnSettings = New Button()
        btnCustomers = New Button()
        btnDashboard = New Button()
        lblSidebarTagLine = New Label()
        lblLogo = New Label()
        lblDashboardTitle = New Label()
        txtSearch = New TextBox()
        btnSearch = New Button()
        btnAddCustomer = New Button()
        btnTransaction = New Button()
        btnViewReports = New Button()
        dgvCustomers = New DataGridView()
        lblOverdueAccounts = New Label()
        lblOverdue = New Label()
        pnlOverdue = New Panel()
        lblTotalCustomers = New Label()
        lblCustomers = New Label()
        pnlTotalCustomers = New Panel()
        lblTotalDebt = New Label()
        lblTotal = New Label()
        pnlTotalDebt = New Panel()
        pnlSidebar.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(dgvCustomers, ComponentModel.ISupportInitialize).BeginInit()
        pnlOverdue.SuspendLayout()
        pnlTotalCustomers.SuspendLayout()
        pnlTotalDebt.SuspendLayout()
        SuspendLayout()
        ' 
        ' pnlSidebar
        ' 
        pnlSidebar.BackColor = Color.FromArgb(CByte(0), CByte(70), CByte(40))
        pnlSidebar.Controls.Add(PictureBox1)
        pnlSidebar.Controls.Add(btnLogout)
        pnlSidebar.Controls.Add(btnSettings)
        pnlSidebar.Controls.Add(btnCustomers)
        pnlSidebar.Controls.Add(btnDashboard)
        pnlSidebar.Controls.Add(lblSidebarTagLine)
        pnlSidebar.Controls.Add(lblLogo)
        pnlSidebar.Dock = DockStyle.Left
        pnlSidebar.Location = New Point(0, 0)
        pnlSidebar.Name = "pnlSidebar"
        pnlSidebar.Size = New Size(220, 561)
        pnlSidebar.TabIndex = 0
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(3, 3)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(217, 167)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 7
        PictureBox1.TabStop = False
        ' 
        ' btnLogout
        ' 
        btnLogout.FlatStyle = FlatStyle.Flat
        btnLogout.Font = New Font("Segoe UI", 10.0F, FontStyle.Bold)
        btnLogout.ForeColor = Color.White
        btnLogout.Location = New Point(30, 503)
        btnLogout.Name = "btnLogout"
        btnLogout.Size = New Size(150, 30)
        btnLogout.TabIndex = 6
        btnLogout.Text = "Logout"
        btnLogout.UseVisualStyleBackColor = True
        ' 
        ' btnSettings
        ' 
        btnSettings.FlatStyle = FlatStyle.Flat
        btnSettings.Font = New Font("Segoe UI", 10.0F, FontStyle.Bold)
        btnSettings.ForeColor = Color.White
        btnSettings.Location = New Point(30, 438)
        btnSettings.Name = "btnSettings"
        btnSettings.Size = New Size(150, 30)
        btnSettings.TabIndex = 5
        btnSettings.Text = "Settings"
        btnSettings.UseVisualStyleBackColor = True
        ' 
        ' btnCustomers
        ' 
        btnCustomers.FlatStyle = FlatStyle.Flat
        btnCustomers.Font = New Font("Segoe UI", 10.0F, FontStyle.Bold)
        btnCustomers.ForeColor = Color.White
        btnCustomers.Location = New Point(27, 372)
        btnCustomers.Name = "btnCustomers"
        btnCustomers.Size = New Size(150, 30)
        btnCustomers.TabIndex = 3
        btnCustomers.Text = "Customers"
        btnCustomers.UseVisualStyleBackColor = True
        ' 
        ' btnDashboard
        ' 
        btnDashboard.BackColor = Color.FromArgb(CByte(0), CByte(192), CByte(0))
        btnDashboard.FlatStyle = FlatStyle.Flat
        btnDashboard.Font = New Font("Segoe UI", 10.0F, FontStyle.Bold)
        btnDashboard.ForeColor = Color.White
        btnDashboard.Location = New Point(30, 315)
        btnDashboard.Name = "btnDashboard"
        btnDashboard.Size = New Size(150, 30)
        btnDashboard.TabIndex = 2
        btnDashboard.Text = "Dashboard"
        btnDashboard.UseVisualStyleBackColor = False
        ' 
        ' lblSidebarTagLine
        ' 
        lblSidebarTagLine.AutoSize = True
        lblSidebarTagLine.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold)
        lblSidebarTagLine.ForeColor = Color.White
        lblSidebarTagLine.Location = New Point(30, 247)
        lblSidebarTagLine.Name = "lblSidebarTagLine"
        lblSidebarTagLine.Size = New Size(175, 15)
        lblSidebarTagLine.TabIndex = 1
        lblSidebarTagLine.Text = "Keep every cedi you are owed"
        ' 
        ' lblLogo
        ' 
        lblLogo.AutoSize = True
        lblLogo.Font = New Font("Segoe UI", 28.0F, FontStyle.Bold)
        lblLogo.ForeColor = Color.White
        lblLogo.Location = New Point(3, 196)
        lblLogo.Name = "lblLogo"
        lblLogo.Size = New Size(223, 51)
        lblLogo.TabIndex = 0
        lblLogo.Text = "CreditBook"
        ' 
        ' lblDashboardTitle
        ' 
        lblDashboardTitle.AutoSize = True
        lblDashboardTitle.Font = New Font("Segoe UI", 15.0F, FontStyle.Bold)
        lblDashboardTitle.ForeColor = Color.FromArgb(CByte(0), CByte(64), CByte(0))
        lblDashboardTitle.Location = New Point(237, 27)
        lblDashboardTitle.Name = "lblDashboardTitle"
        lblDashboardTitle.Size = New Size(414, 28)
        lblDashboardTitle.TabIndex = 1
        lblDashboardTitle.Text = "CreditBook: Keep every cedi you are owed"
        ' 
        ' txtSearch
        ' 
        txtSearch.Location = New Point(237, 90)
        txtSearch.Name = "txtSearch"
        txtSearch.Size = New Size(320, 23)
        txtSearch.TabIndex = 2
        ' 
        ' btnSearch
        ' 
        btnSearch.BackColor = Color.FromArgb(CByte(0), CByte(64), CByte(0))
        btnSearch.ForeColor = Color.White
        btnSearch.Location = New Point(567, 78)
        btnSearch.Name = "btnSearch"
        btnSearch.Size = New Size(98, 44)
        btnSearch.TabIndex = 3
        btnSearch.Text = "Search"
        btnSearch.UseVisualStyleBackColor = False
        ' 
        ' btnAddCustomer
        ' 
        btnAddCustomer.BackColor = Color.FromArgb(CByte(0), CByte(64), CByte(0))
        btnAddCustomer.ForeColor = Color.White
        btnAddCustomer.Location = New Point(680, 78)
        btnAddCustomer.Name = "btnAddCustomer"
        btnAddCustomer.Size = New Size(118, 44)
        btnAddCustomer.TabIndex = 4
        btnAddCustomer.Text = "Add Customer"
        btnAddCustomer.UseVisualStyleBackColor = False
        ' 
        ' btnTransaction
        ' 
        btnTransaction.BackColor = Color.FromArgb(CByte(0), CByte(0), CByte(192))
        btnTransaction.ForeColor = Color.White
        btnTransaction.Location = New Point(817, 78)
        btnTransaction.Name = "btnTransaction"
        btnTransaction.Size = New Size(170, 44)
        btnTransaction.TabIndex = 5
        btnTransaction.Text = "Record Credit / Payment"
        btnTransaction.UseVisualStyleBackColor = False
        ' 
        ' btnViewReports
        ' 
        btnViewReports.BackColor = Color.FromArgb(CByte(0), CByte(64), CByte(0))
        btnViewReports.ForeColor = Color.White
        btnViewReports.Location = New Point(993, 78)
        btnViewReports.Name = "btnViewReports"
        btnViewReports.Size = New Size(102, 44)
        btnViewReports.TabIndex = 6
        btnViewReports.Text = "View Reports"
        btnViewReports.UseVisualStyleBackColor = False
        ' 
        ' dgvCustomers
        ' 
        dgvCustomers.AllowUserToAddRows = False
        dgvCustomers.AllowUserToDeleteRows = False
        dgvCustomers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvCustomers.BackgroundColor = Color.White
        dgvCustomers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvCustomers.Dock = DockStyle.Bottom
        dgvCustomers.Location = New Point(220, 166)
        dgvCustomers.MultiSelect = False
        dgvCustomers.Name = "dgvCustomers"
        dgvCustomers.ReadOnly = True
        dgvCustomers.RowHeadersVisible = False
        dgvCustomers.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvCustomers.Size = New Size(898, 395)
        dgvCustomers.TabIndex = 7
        ' 
        ' lblOverdueAccounts
        ' 
        lblOverdueAccounts.AutoSize = True
        lblOverdueAccounts.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold)
        lblOverdueAccounts.Location = New Point(45, 12)
        lblOverdueAccounts.Name = "lblOverdueAccounts"
        lblOverdueAccounts.Size = New Size(128, 15)
        lblOverdueAccounts.TabIndex = 0
        lblOverdueAccounts.Text = "OVERDUE ACCOUNTS"
        ' 
        ' lblOverdue
        ' 
        lblOverdue.AutoSize = True
        lblOverdue.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold)
        lblOverdue.Location = New Point(45, 50)
        lblOverdue.Name = "lblOverdue"
        lblOverdue.Size = New Size(43, 15)
        lblOverdue.TabIndex = 1
        lblOverdue.Text = "Label4"
        ' 
        ' pnlOverdue
        ' 
        pnlOverdue.Controls.Add(lblOverdue)
        pnlOverdue.Controls.Add(lblOverdueAccounts)
        pnlOverdue.Location = New Point(327, 541)
        pnlOverdue.Name = "pnlOverdue"
        pnlOverdue.Size = New Size(10, 10)
        pnlOverdue.TabIndex = 10
        ' 
        ' lblTotalCustomers
        ' 
        lblTotalCustomers.AutoSize = True
        lblTotalCustomers.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold)
        lblTotalCustomers.Location = New Point(57, 14)
        lblTotalCustomers.Name = "lblTotalCustomers"
        lblTotalCustomers.Size = New Size(117, 15)
        lblTotalCustomers.TabIndex = 0
        lblTotalCustomers.Text = "TOTAL CUSTOMERS"
        ' 
        ' lblCustomers
        ' 
        lblCustomers.AutoSize = True
        lblCustomers.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold)
        lblCustomers.Location = New Point(57, 50)
        lblCustomers.Name = "lblCustomers"
        lblCustomers.Size = New Size(43, 15)
        lblCustomers.TabIndex = 1
        lblCustomers.Text = "Label3"
        ' 
        ' pnlTotalCustomers
        ' 
        pnlTotalCustomers.Controls.Add(lblCustomers)
        pnlTotalCustomers.Controls.Add(lblTotalCustomers)
        pnlTotalCustomers.Location = New Point(288, 535)
        pnlTotalCustomers.Name = "pnlTotalCustomers"
        pnlTotalCustomers.Size = New Size(33, 10)
        pnlTotalCustomers.TabIndex = 9
        ' 
        ' lblTotalDebt
        ' 
        lblTotalDebt.AutoSize = True
        lblTotalDebt.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold)
        lblTotalDebt.Location = New Point(68, 11)
        lblTotalDebt.Name = "lblTotalDebt"
        lblTotalDebt.Size = New Size(115, 15)
        lblTotalDebt.TabIndex = 0
        lblTotalDebt.Text = "TOTAL DEBT OWED"
        ' 
        ' lblTotal
        ' 
        lblTotal.AutoSize = True
        lblTotal.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold)
        lblTotal.Location = New Point(68, 50)
        lblTotal.Name = "lblTotal"
        lblTotal.Size = New Size(32, 15)
        lblTotal.TabIndex = 1
        lblTotal.Text = "GH₵"
        ' 
        ' pnlTotalDebt
        ' 
        pnlTotalDebt.Controls.Add(lblTotal)
        pnlTotalDebt.Controls.Add(lblTotalDebt)
        pnlTotalDebt.Location = New Point(226, 535)
        pnlTotalDebt.Name = "pnlTotalDebt"
        pnlTotalDebt.Size = New Size(56, 10)
        pnlTotalDebt.TabIndex = 8
        ' 
        ' frmDashboard
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1118, 561)
        Controls.Add(pnlOverdue)
        Controls.Add(pnlTotalCustomers)
        Controls.Add(pnlTotalDebt)
        Controls.Add(dgvCustomers)
        Controls.Add(btnViewReports)
        Controls.Add(btnTransaction)
        Controls.Add(btnAddCustomer)
        Controls.Add(btnSearch)
        Controls.Add(txtSearch)
        Controls.Add(lblDashboardTitle)
        Controls.Add(pnlSidebar)
        MinimumSize = New Size(802, 383)
        Name = "frmDashboard"
        StartPosition = FormStartPosition.CenterScreen
        Text = "CreditBook - Dashboard"
        WindowState = FormWindowState.Maximized
        pnlSidebar.ResumeLayout(False)
        pnlSidebar.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(dgvCustomers, ComponentModel.ISupportInitialize).EndInit()
        pnlOverdue.ResumeLayout(False)
        pnlOverdue.PerformLayout()
        pnlTotalCustomers.ResumeLayout(False)
        pnlTotalCustomers.PerformLayout()
        pnlTotalDebt.ResumeLayout(False)
        pnlTotalDebt.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents pnlSidebar As Panel
    Friend WithEvents lblLogo As Label
    Friend WithEvents lblSidebarTagLine As Label
    Friend WithEvents btnLogout As Button
    Friend WithEvents btnSettings As Button
    Friend WithEvents btnCustomers As Button
    Friend WithEvents btnDashboard As Button
    Friend WithEvents lblDashboardTitle As Label
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents btnSearch As Button
    Friend WithEvents btnAddCustomer As Button
    Friend WithEvents btnTransaction As Button
    Friend WithEvents btnViewReports As Button
    Friend WithEvents dgvCustomers As DataGridView
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents lblOverdueAccounts As Label
    Friend WithEvents lblOverdue As Label
    Friend WithEvents pnlOverdue As Panel
    Friend WithEvents lblTotalCustomers As Label
    Friend WithEvents lblCustomers As Label
    Friend WithEvents pnlTotalCustomers As Panel
    Friend WithEvents lblTotalDebt As Label
    Friend WithEvents lblTotal As Label
    Friend WithEvents pnlTotalDebt As Panel
End Class
