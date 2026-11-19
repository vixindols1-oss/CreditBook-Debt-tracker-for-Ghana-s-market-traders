<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTransaction
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
        lblTitle = New Label()
        lblCustomer = New Label()
        cmbCustomer = New ComboBox()
        lblType = New Label()
        cmbTransactionType = New ComboBox()
        lblAmount = New Label()
        txtAmount = New TextBox()
        lblNotes = New Label()
        txtNotes = New TextBox()
        btnSaveTransaction = New Button()
        btnCancel = New Button()
        dtpTransactionDate = New DateTimePicker()
        lblTransactionDate = New Label()
        dgvTransactions = New DataGridView()
        CType(dgvTransactions, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' lblTitle
        ' 
        lblTitle.AutoSize = True
        lblTitle.Font = New Font("Segoe UI", 20F, FontStyle.Bold)
        lblTitle.ForeColor = Color.FromArgb(CByte(0), CByte(64), CByte(0))
        lblTitle.Location = New Point(283, 9)
        lblTitle.Name = "lblTitle"
        lblTitle.Size = New Size(332, 37)
        lblTitle.TabIndex = 0
        lblTitle.Text = "Record Credit / Payment"
        ' 
        ' lblCustomer
        ' 
        lblCustomer.AutoSize = True
        lblCustomer.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        lblCustomer.ForeColor = Color.FromArgb(CByte(0), CByte(64), CByte(0))
        lblCustomer.Location = New Point(169, 77)
        lblCustomer.Name = "lblCustomer"
        lblCustomer.Size = New Size(99, 15)
        lblCustomer.TabIndex = 1
        lblCustomer.Text = "Select Customer"
        ' 
        ' cmbCustomer
        ' 
        cmbCustomer.FormattingEnabled = True
        cmbCustomer.Location = New Point(165, 95)
        cmbCustomer.Name = "cmbCustomer"
        cmbCustomer.Size = New Size(223, 23)
        cmbCustomer.TabIndex = 2
        ' 
        ' lblType
        ' 
        lblType.AutoSize = True
        lblType.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        lblType.ForeColor = Color.FromArgb(CByte(0), CByte(64), CByte(0))
        lblType.Location = New Point(169, 136)
        lblType.Name = "lblType"
        lblType.Size = New Size(99, 15)
        lblType.TabIndex = 3
        lblType.Text = "Transaction Type"
        ' 
        ' cmbTransactionType
        ' 
        cmbTransactionType.FormattingEnabled = True
        cmbTransactionType.Location = New Point(165, 154)
        cmbTransactionType.Name = "cmbTransactionType"
        cmbTransactionType.Size = New Size(223, 23)
        cmbTransactionType.TabIndex = 4
        ' 
        ' lblAmount
        ' 
        lblAmount.AutoSize = True
        lblAmount.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        lblAmount.ForeColor = Color.FromArgb(CByte(0), CByte(64), CByte(0))
        lblAmount.Location = New Point(165, 202)
        lblAmount.Name = "lblAmount"
        lblAmount.Size = New Size(88, 15)
        lblAmount.TabIndex = 5
        lblAmount.Text = "Amount (GH₵)"
        ' 
        ' txtAmount
        ' 
        txtAmount.Location = New Point(165, 220)
        txtAmount.Name = "txtAmount"
        txtAmount.Size = New Size(223, 23)
        txtAmount.TabIndex = 6
        ' 
        ' lblNotes
        ' 
        lblNotes.AutoSize = True
        lblNotes.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        lblNotes.ForeColor = Color.FromArgb(CByte(0), CByte(64), CByte(0))
        lblNotes.Location = New Point(165, 267)
        lblNotes.Name = "lblNotes"
        lblNotes.Size = New Size(40, 15)
        lblNotes.TabIndex = 7
        lblNotes.Text = "Notes"
        ' 
        ' txtNotes
        ' 
        txtNotes.Location = New Point(165, 285)
        txtNotes.Name = "txtNotes"
        txtNotes.Size = New Size(223, 23)
        txtNotes.TabIndex = 8
        ' 
        ' btnSaveTransaction
        ' 
        btnSaveTransaction.BackColor = Color.Green
        btnSaveTransaction.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        btnSaveTransaction.ForeColor = Color.White
        btnSaveTransaction.Location = New Point(256, 413)
        btnSaveTransaction.Name = "btnSaveTransaction"
        btnSaveTransaction.Size = New Size(132, 34)
        btnSaveTransaction.TabIndex = 9
        btnSaveTransaction.Text = "Save Transaction"
        btnSaveTransaction.UseVisualStyleBackColor = False
        ' 
        ' btnCancel
        ' 
        btnCancel.BackColor = Color.FromArgb(CByte(192), CByte(0), CByte(0))
        btnCancel.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        btnCancel.ForeColor = Color.White
        btnCancel.Location = New Point(443, 413)
        btnCancel.Name = "btnCancel"
        btnCancel.Size = New Size(105, 34)
        btnCancel.TabIndex = 10
        btnCancel.Text = "Cancel"
        btnCancel.UseVisualStyleBackColor = False
        ' 
        ' dtpTransactionDate
        ' 
        dtpTransactionDate.CalendarForeColor = Color.FromArgb(CByte(0), CByte(64), CByte(0))
        dtpTransactionDate.CalendarTitleForeColor = Color.FromArgb(CByte(0), CByte(64), CByte(0))
        dtpTransactionDate.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        dtpTransactionDate.Format = DateTimePickerFormat.Short
        dtpTransactionDate.Location = New Point(165, 357)
        dtpTransactionDate.Name = "dtpTransactionDate"
        dtpTransactionDate.Size = New Size(223, 23)
        dtpTransactionDate.TabIndex = 11
        ' 
        ' lblTransactionDate
        ' 
        lblTransactionDate.AutoSize = True
        lblTransactionDate.Font = New Font("Segoe UI", 10F, FontStyle.Bold)
        lblTransactionDate.ForeColor = Color.FromArgb(CByte(0), CByte(64), CByte(0))
        lblTransactionDate.Location = New Point(165, 335)
        lblTransactionDate.Name = "lblTransactionDate"
        lblTransactionDate.Size = New Size(120, 19)
        lblTransactionDate.TabIndex = 12
        lblTransactionDate.Text = "Transaction Date"
        ' 
        ' dgvTransactions
        ' 
        dgvTransactions.AllowUserToAddRows = False
        dgvTransactions.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvTransactions.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvTransactions.Location = New Point(32, 458)
        dgvTransactions.Name = "dgvTransactions"
        dgvTransactions.ReadOnly = True
        dgvTransactions.RowHeadersVisible = False
        dgvTransactions.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvTransactions.Size = New Size(987, 250)
        dgvTransactions.TabIndex = 13
        ' 
        ' frmTransaction
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1084, 720)
        Controls.Add(dgvTransactions)
        Controls.Add(lblTransactionDate)
        Controls.Add(dtpTransactionDate)
        Controls.Add(btnCancel)
        Controls.Add(btnSaveTransaction)
        Controls.Add(txtNotes)
        Controls.Add(lblNotes)
        Controls.Add(txtAmount)
        Controls.Add(lblAmount)
        Controls.Add(cmbTransactionType)
        Controls.Add(lblType)
        Controls.Add(cmbCustomer)
        Controls.Add(lblCustomer)
        Controls.Add(lblTitle)
        FormBorderStyle = FormBorderStyle.FixedSingle
        MaximizeBox = False
        Name = "frmTransaction"
        StartPosition = FormStartPosition.CenterScreen
        Text = "CreditBook - Record Transaction"
        CType(dgvTransactions, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblTitle As Label
    Friend WithEvents lblCustomer As Label
    Friend WithEvents cmbCustomer As ComboBox
    Friend WithEvents lblType As Label
    Friend WithEvents cmbTransactionType As ComboBox
    Friend WithEvents lblAmount As Label
    Friend WithEvents txtAmount As TextBox
    Friend WithEvents lblNotes As Label
    Friend WithEvents txtNotes As TextBox
    Friend WithEvents btnSaveTransaction As Button
    Friend WithEvents btnCancel As Button
    Friend WithEvents dtpTransactionDate As DateTimePicker
    Friend WithEvents lblTransactionDate As Label
    Friend WithEvents dgvTransactions As DataGridView
End Class
