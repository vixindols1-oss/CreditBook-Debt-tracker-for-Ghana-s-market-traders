<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCustomers
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
        txtSearch = New TextBox()
        btnSearch = New Button()
        btnAddCustomer = New Button()
        Button1 = New Button()
        dgvCustomers = New DataGridView()
        CType(dgvCustomers, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' lblHeading
        ' 
        lblHeading.AutoSize = True
        lblHeading.Font = New Font("Segoe UI", 20F, FontStyle.Bold)
        lblHeading.ForeColor = Color.FromArgb(CByte(0), CByte(64), CByte(0))
        lblHeading.Location = New Point(21, 9)
        lblHeading.Name = "lblHeading"
        lblHeading.Size = New Size(153, 37)
        lblHeading.TabIndex = 0
        lblHeading.Text = "Customers"
        ' 
        ' lblSubtitle
        ' 
        lblSubtitle.AutoSize = True
        lblSubtitle.Font = New Font("Segoe UI", 10F, FontStyle.Bold)
        lblSubtitle.ForeColor = Color.FromArgb(CByte(0), CByte(64), CByte(0))
        lblSubtitle.Location = New Point(21, 59)
        lblSubtitle.Name = "lblSubtitle"
        lblSubtitle.Size = New Size(332, 19)
        lblSubtitle.TabIndex = 1
        lblSubtitle.Text = "Manage your customers and their credit records"
        ' 
        ' txtSearch
        ' 
        txtSearch.Font = New Font("Segoe UI", 10F)
        txtSearch.Location = New Point(30, 120)
        txtSearch.Name = "txtSearch"
        txtSearch.Size = New Size(350, 25)
        txtSearch.TabIndex = 2
        ' 
        ' btnSearch
        ' 
        btnSearch.BackColor = Color.FromArgb(CByte(0), CByte(64), CByte(0))
        btnSearch.FlatStyle = FlatStyle.Flat
        btnSearch.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        btnSearch.ForeColor = Color.White
        btnSearch.Location = New Point(395, 118)
        btnSearch.Name = "btnSearch"
        btnSearch.Size = New Size(100, 35)
        btnSearch.TabIndex = 3
        btnSearch.Text = "Search"
        btnSearch.UseVisualStyleBackColor = False
        ' 
        ' btnAddCustomer
        ' 
        btnAddCustomer.BackColor = Color.FromArgb(CByte(0), CByte(64), CByte(0))
        btnAddCustomer.FlatStyle = FlatStyle.Flat
        btnAddCustomer.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        btnAddCustomer.ForeColor = Color.White
        btnAddCustomer.Location = New Point(518, 120)
        btnAddCustomer.Name = "btnAddCustomer"
        btnAddCustomer.Size = New Size(160, 35)
        btnAddCustomer.TabIndex = 4
        btnAddCustomer.Text = "Add Customer"
        btnAddCustomer.UseVisualStyleBackColor = False
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.FromArgb(CByte(64), CByte(64), CByte(0))
        Button1.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        Button1.ForeColor = Color.Black
        Button1.Location = New Point(696, 118)
        Button1.Name = "Button1"
        Button1.Size = New Size(75, 37)
        Button1.TabIndex = 5
        Button1.Text = "Refresh"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' dgvCustomers
        ' 
        dgvCustomers.AllowUserToAddRows = False
        dgvCustomers.AllowUserToDeleteRows = False
        dgvCustomers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvCustomers.BackgroundColor = Color.White
        dgvCustomers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvCustomers.Location = New Point(30, 180)
        dgvCustomers.MultiSelect = False
        dgvCustomers.Name = "dgvCustomers"
        dgvCustomers.ReadOnly = True
        dgvCustomers.RowHeadersVisible = False
        dgvCustomers.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvCustomers.Size = New Size(1000, 380)
        dgvCustomers.TabIndex = 6
        ' 
        ' frmCustomers
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(1084, 611)
        Controls.Add(dgvCustomers)
        Controls.Add(Button1)
        Controls.Add(btnAddCustomer)
        Controls.Add(btnSearch)
        Controls.Add(txtSearch)
        Controls.Add(lblSubtitle)
        Controls.Add(lblHeading)
        FormBorderStyle = FormBorderStyle.FixedSingle
        MaximizeBox = False
        Name = "frmCustomers"
        StartPosition = FormStartPosition.CenterScreen
        Text = "CreditBook - Customers"
        CType(dgvCustomers, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblHeading As Label
    Friend WithEvents lblSubtitle As Label
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents btnSearch As Button
    Friend WithEvents btnAddCustomer As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents dgvCustomers As DataGridView
End Class
