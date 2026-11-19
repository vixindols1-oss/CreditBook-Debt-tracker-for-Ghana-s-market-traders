<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmReports
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
        Label1 = New Label()
        grpCustomers = New GroupBox()
        lblTotalCustomers = New Label()
        grpOutstandingDebt = New GroupBox()
        lblOutstandingDebt = New Label()
        lblTotalCredit = New Label()
        lblTotalRepayments = New Label()
        grpCredit = New GroupBox()
        grpRepayments = New GroupBox()
        grpCustomers.SuspendLayout()
        grpOutstandingDebt.SuspendLayout()
        grpCredit.SuspendLayout()
        grpRepayments.SuspendLayout()
        SuspendLayout()
        ' 
        ' lblHeading
        ' 
        lblHeading.AutoSize = True
        lblHeading.Font = New Font("Segoe UI", 22F, FontStyle.Bold)
        lblHeading.ForeColor = Color.FromArgb(CByte(0), CByte(64), CByte(0))
        lblHeading.Location = New Point(402, 9)
        lblHeading.Name = "lblHeading"
        lblHeading.RightToLeft = RightToLeft.No
        lblHeading.Size = New Size(255, 41)
        lblHeading.TabIndex = 0
        lblHeading.Text = "Business Reports"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 10F, FontStyle.Bold)
        Label1.ForeColor = Color.FromArgb(CByte(0), CByte(64), CByte(0))
        Label1.Location = New Point(341, 50)
        Label1.Name = "Label1"
        Label1.Size = New Size(367, 19)
        Label1.TabIndex = 1
        Label1.Text = "Track your credit, repayments and outstanding debts."
        ' 
        ' grpCustomers
        ' 
        grpCustomers.Controls.Add(lblTotalCustomers)
        grpCustomers.Font = New Font("Segoe UI", 13F, FontStyle.Bold)
        grpCustomers.ForeColor = Color.FromArgb(CByte(0), CByte(64), CByte(0))
        grpCustomers.Location = New Point(21, 104)
        grpCustomers.Name = "grpCustomers"
        grpCustomers.Size = New Size(240, 82)
        grpCustomers.TabIndex = 2
        grpCustomers.TabStop = False
        grpCustomers.Text = "Total Customers"
        ' 
        ' lblTotalCustomers
        ' 
        lblTotalCustomers.AutoSize = True
        lblTotalCustomers.Font = New Font("Segoe UI", 22F, FontStyle.Bold)
        lblTotalCustomers.Location = New Point(10, 34)
        lblTotalCustomers.Name = "lblTotalCustomers"
        lblTotalCustomers.Size = New Size(36, 41)
        lblTotalCustomers.TabIndex = 0
        lblTotalCustomers.Text = "o"
        ' 
        ' grpOutstandingDebt
        ' 
        grpOutstandingDebt.Controls.Add(lblOutstandingDebt)
        grpOutstandingDebt.Font = New Font("Segoe UI", 13F, FontStyle.Bold)
        grpOutstandingDebt.ForeColor = Color.FromArgb(CByte(0), CByte(64), CByte(0))
        grpOutstandingDebt.Location = New Point(21, 205)
        grpOutstandingDebt.Name = "grpOutstandingDebt"
        grpOutstandingDebt.Size = New Size(240, 100)
        grpOutstandingDebt.TabIndex = 3
        grpOutstandingDebt.TabStop = False
        grpOutstandingDebt.Text = "Outstanding Debt"
        ' 
        ' lblOutstandingDebt
        ' 
        lblOutstandingDebt.AutoSize = True
        lblOutstandingDebt.Location = New Point(14, 56)
        lblOutstandingDebt.Name = "lblOutstandingDebt"
        lblOutstandingDebt.Size = New Size(89, 25)
        lblOutstandingDebt.TabIndex = 0
        lblOutstandingDebt.Text = "GH₵ 0.00"
        ' 
        ' lblTotalCredit
        ' 
        lblTotalCredit.AutoSize = True
        lblTotalCredit.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        lblTotalCredit.Location = New Point(14, 40)
        lblTotalCredit.Name = "lblTotalCredit"
        lblTotalCredit.Size = New Size(77, 21)
        lblTotalCredit.TabIndex = 4
        lblTotalCredit.Text = "GH₵ 0.00"
        ' 
        ' lblTotalRepayments
        ' 
        lblTotalRepayments.AutoSize = True
        lblTotalRepayments.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        lblTotalRepayments.Location = New Point(10, 38)
        lblTotalRepayments.Name = "lblTotalRepayments"
        lblTotalRepayments.Size = New Size(77, 21)
        lblTotalRepayments.TabIndex = 5
        lblTotalRepayments.Text = "GH₵ 0.00"
        ' 
        ' grpCredit
        ' 
        grpCredit.Controls.Add(lblTotalCredit)
        grpCredit.Font = New Font("Segoe UI", 13F, FontStyle.Bold)
        grpCredit.ForeColor = Color.FromArgb(CByte(0), CByte(64), CByte(0))
        grpCredit.Location = New Point(21, 327)
        grpCredit.Name = "grpCredit"
        grpCredit.Size = New Size(240, 100)
        grpCredit.TabIndex = 6
        grpCredit.TabStop = False
        grpCredit.Text = "Total Credit Given"
        ' 
        ' grpRepayments
        ' 
        grpRepayments.Controls.Add(lblTotalRepayments)
        grpRepayments.Font = New Font("Segoe UI", 13F, FontStyle.Bold)
        grpRepayments.ForeColor = Color.FromArgb(CByte(0), CByte(64), CByte(0))
        grpRepayments.Location = New Point(21, 453)
        grpRepayments.Name = "grpRepayments"
        grpRepayments.Size = New Size(240, 100)
        grpRepayments.TabIndex = 7
        grpRepayments.TabStop = False
        grpRepayments.Text = "Total Repayments"
        ' 
        ' frmReports
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1084, 711)
        Controls.Add(grpRepayments)
        Controls.Add(grpCredit)
        Controls.Add(grpOutstandingDebt)
        Controls.Add(grpCustomers)
        Controls.Add(Label1)
        Controls.Add(lblHeading)
        Name = "frmReports"
        StartPosition = FormStartPosition.CenterScreen
        Text = "CreditBook - Reports"
        grpCustomers.ResumeLayout(False)
        grpCustomers.PerformLayout()
        grpOutstandingDebt.ResumeLayout(False)
        grpOutstandingDebt.PerformLayout()
        grpCredit.ResumeLayout(False)
        grpCredit.PerformLayout()
        grpRepayments.ResumeLayout(False)
        grpRepayments.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblHeading As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents grpCustomers As GroupBox
    Friend WithEvents lblTotalCustomers As Label
    Friend WithEvents grpOutstandingDebt As GroupBox
    Friend WithEvents lblOutstandingDebt As Label
    Friend WithEvents lblTotalCredit As Label
    Friend WithEvents lblTotalRepayments As Label
    Friend WithEvents grpCredit As GroupBox
    Friend WithEvents grpRepayments As GroupBox
End Class
