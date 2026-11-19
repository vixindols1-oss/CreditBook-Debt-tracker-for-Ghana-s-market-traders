Imports System.Data
Public Class frmTransaction
    Private Sub LoadTransactionCustomers()

        Try

            Dim customers As DataTable = DbHelper.GetAllCustomers()

            cmbCustomer.DataSource = customers
            cmbCustomer.DisplayMember = "Customer Name"
            cmbCustomer.ValueMember = "CustomerID"
            cmbCustomer.SelectedIndex = -1

        Catch ex As Exception

            MessageBox.Show("Unable to load customers: " & ex.Message,
                            "CreditBook",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error)

        End Try

    End Sub
    Private Sub LoadTransactions()

        Try

            Dim transactions As DataTable = DbHelper.GetAllTransactions()

            dgvTransactions.DataSource = transactions

            dgvTransactions.ReadOnly = True
            dgvTransactions.AllowUserToAddRows = False
            dgvTransactions.AllowUserToDeleteRows = False
            dgvTransactions.SelectionMode = DataGridViewSelectionMode.FullRowSelect
            dgvTransactions.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
            dgvTransactions.RowHeadersVisible = False

            If dgvTransactions.Columns.Contains("TransactionID") Then
                dgvTransactions.Columns("TransactionID").Visible = False
            End If

        Catch ex As Exception

            MessageBox.Show("Unable to load transactions: " & ex.Message)

        End Try

    End Sub
    Private Sub LoadTransactionTypes()

        cmbTransactionType.Items.Clear()

        cmbTransactionType.Items.Add("Credit")
        cmbTransactionType.Items.Add("Repayment")

        cmbTransactionType.SelectedIndex = -1

    End Sub

    Private Sub frmTransaction_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadTransactionCustomers()
        LoadTransactionTypes()
        LoadTransactions()
    End Sub

    Private Sub btnSaveTransaction_Click(sender As Object, e As EventArgs) Handles btnSaveTransaction.Click

        'Check customer selection
        If cmbCustomer.SelectedIndex = -1 Then
            MessageBox.Show("Please select a customer.")
            Return
        End If

        'Check transaction type
        If cmbTransactionType.SelectedIndex = -1 Then
            MessageBox.Show("Please select a transaction type.")
            Return
        End If

        'Check amount
        Dim amount As Decimal

        If Not Decimal.TryParse(txtAmount.Text.Trim(), amount) OrElse amount <= 0 Then
            MessageBox.Show("Please enter a valid amount.")
            txtAmount.Focus()
            Return
        End If

        Try

            Dim customerID As Integer =
            Convert.ToInt32(cmbCustomer.SelectedValue)

            Dim transactionType As String =
            cmbTransactionType.SelectedItem.ToString()

            Dim notes As String = txtNotes.Text.Trim()

            DbHelper.SaveTransaction(
            customerID,
            transactionType,
            amount,
            dtpTransactionDate.Value,
            notes
        )

            MessageBox.Show("Transaction saved successfully!",
                        "CreditBook",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information)
            LoadTransactions()

            'Clear fields after saving
            cmbCustomer.SelectedIndex = -1
            cmbTransactionType.SelectedIndex = -1
            txtAmount.Clear()
            txtNotes.Clear()
            dtpTransactionDate.Value = DateTime.Now

        Catch ex As Exception

            MessageBox.Show("Unable to save transaction: " & ex.Message,
                        "CreditBook",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error)

        End Try

    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub
End Class