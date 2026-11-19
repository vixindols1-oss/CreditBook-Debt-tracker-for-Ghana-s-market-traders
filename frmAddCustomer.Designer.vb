<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAddCustomer
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
        lblFormTitle = New Label()
        lblSubtitle = New Label()
        lblCustomerName = New Label()
        lblPhone = New Label()
        lblInitialAmount = New Label()
        lblPromisedDate = New Label()
        txtCustomerName = New TextBox()
        txtPhone = New TextBox()
        txtInitialAmount = New TextBox()
        dtpPromisedDate = New DateTimePicker()
        btnSaveCustomer = New Button()
        btnCancel = New Button()
        SuspendLayout()
        ' 
        ' lblFormTitle
        ' 
        lblFormTitle.AutoSize = True
        lblFormTitle.Font = New Font("Segoe UI", 22F, FontStyle.Bold)
        lblFormTitle.ForeColor = Color.FromArgb(CByte(0), CByte(64), CByte(0))
        lblFormTitle.Location = New Point(152, 21)
        lblFormTitle.Name = "lblFormTitle"
        lblFormTitle.Size = New Size(292, 41)
        lblFormTitle.TabIndex = 0
        lblFormTitle.Text = "Add New Customer"
        ' 
        ' lblSubtitle
        ' 
        lblSubtitle.AutoSize = True
        lblSubtitle.Font = New Font("Segoe UI", 10F)
        lblSubtitle.Location = New Point(143, 73)
        lblSubtitle.Name = "lblSubtitle"
        lblSubtitle.Size = New Size(313, 19)
        lblSubtitle.TabIndex = 1
        lblSubtitle.Text = "Register a customer and record their credit details"
        ' 
        ' lblCustomerName
        ' 
        lblCustomerName.AutoSize = True
        lblCustomerName.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        lblCustomerName.Location = New Point(44, 139)
        lblCustomerName.Name = "lblCustomerName"
        lblCustomerName.Size = New Size(97, 15)
        lblCustomerName.TabIndex = 2
        lblCustomerName.Text = "Customer Name"
        ' 
        ' lblPhone
        ' 
        lblPhone.AutoSize = True
        lblPhone.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        lblPhone.Location = New Point(44, 216)
        lblPhone.Name = "lblPhone"
        lblPhone.Size = New Size(91, 15)
        lblPhone.TabIndex = 3
        lblPhone.Text = "Phone Number"
        ' 
        ' lblInitialAmount
        ' 
        lblInitialAmount.AutoSize = True
        lblInitialAmount.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        lblInitialAmount.Location = New Point(49, 289)
        lblInitialAmount.Name = "lblInitialAmount"
        lblInitialAmount.Size = New Size(122, 15)
        lblInitialAmount.TabIndex = 4
        lblInitialAmount.Text = "Initial Amount Owed"
        ' 
        ' lblPromisedDate
        ' 
        lblPromisedDate.AutoSize = True
        lblPromisedDate.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        lblPromisedDate.Location = New Point(44, 362)
        lblPromisedDate.Name = "lblPromisedDate"
        lblPromisedDate.Size = New Size(141, 15)
        lblPromisedDate.TabIndex = 5
        lblPromisedDate.Text = "Promised Payment Date"
        ' 
        ' txtCustomerName
        ' 
        txtCustomerName.Font = New Font("Segoe UI", 11F)
        txtCustomerName.Location = New Point(44, 157)
        txtCustomerName.Name = "txtCustomerName"
        txtCustomerName.Size = New Size(200, 27)
        txtCustomerName.TabIndex = 6
        ' 
        ' txtPhone
        ' 
        txtPhone.Font = New Font("Segoe UI", 11F)
        txtPhone.Location = New Point(44, 234)
        txtPhone.MaxLength = 10
        txtPhone.Name = "txtPhone"
        txtPhone.Size = New Size(200, 27)
        txtPhone.TabIndex = 7
        ' 
        ' txtInitialAmount
        ' 
        txtInitialAmount.Font = New Font("Segoe UI", 11F)
        txtInitialAmount.Location = New Point(49, 307)
        txtInitialAmount.Name = "txtInitialAmount"
        txtInitialAmount.Size = New Size(195, 27)
        txtInitialAmount.TabIndex = 8
        ' 
        ' dtpPromisedDate
        ' 
        dtpPromisedDate.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        dtpPromisedDate.Location = New Point(49, 380)
        dtpPromisedDate.Name = "dtpPromisedDate"
        dtpPromisedDate.Size = New Size(195, 23)
        dtpPromisedDate.TabIndex = 9
        ' 
        ' btnSaveCustomer
        ' 
        btnSaveCustomer.BackColor = Color.FromArgb(CByte(0), CByte(64), CByte(0))
        btnSaveCustomer.FlatStyle = FlatStyle.Flat
        btnSaveCustomer.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        btnSaveCustomer.ForeColor = Color.White
        btnSaveCustomer.Location = New Point(168, 459)
        btnSaveCustomer.Name = "btnSaveCustomer"
        btnSaveCustomer.Size = New Size(117, 31)
        btnSaveCustomer.TabIndex = 10
        btnSaveCustomer.Text = "Save Customer"
        btnSaveCustomer.UseVisualStyleBackColor = False
        ' 
        ' btnCancel
        ' 
        btnCancel.BackColor = Color.Gainsboro
        btnCancel.FlatStyle = FlatStyle.Flat
        btnCancel.Location = New Point(315, 459)
        btnCancel.Name = "btnCancel"
        btnCancel.Size = New Size(75, 31)
        btnCancel.TabIndex = 11
        btnCancel.Text = "Cancel"
        btnCancel.UseVisualStyleBackColor = False
        ' 
        ' frmAddCustomer
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(634, 535)
        Controls.Add(btnCancel)
        Controls.Add(btnSaveCustomer)
        Controls.Add(dtpPromisedDate)
        Controls.Add(txtInitialAmount)
        Controls.Add(txtPhone)
        Controls.Add(txtCustomerName)
        Controls.Add(lblPromisedDate)
        Controls.Add(lblInitialAmount)
        Controls.Add(lblPhone)
        Controls.Add(lblCustomerName)
        Controls.Add(lblSubtitle)
        Controls.Add(lblFormTitle)
        FormBorderStyle = FormBorderStyle.FixedSingle
        MaximizeBox = False
        Name = "frmAddCustomer"
        StartPosition = FormStartPosition.CenterScreen
        Text = "CreditBook - Add Customer"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblFormTitle As Label
    Friend WithEvents lblSubtitle As Label
    Friend WithEvents lblCustomerName As Label
    Friend WithEvents lblPhone As Label
    Friend WithEvents lblInitialAmount As Label
    Friend WithEvents lblPromisedDate As Label
    Friend WithEvents txtCustomerName As TextBox
    Friend WithEvents txtPhone As TextBox
    Friend WithEvents txtInitialAmount As TextBox
    Friend WithEvents dtpPromisedDate As DateTimePicker
    Friend WithEvents btnSaveCustomer As Button
    Friend WithEvents btnCancel As Button
End Class
