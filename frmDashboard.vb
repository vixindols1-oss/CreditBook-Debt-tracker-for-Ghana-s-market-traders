Public Class frmDashboard
    Private Sub btnAddCustomer_Click(sender As Object, e As EventArgs) Handles btnAddCustomer.Click

        Using customerForm As New frmAddCustomer()
            customerForm.ShowDialog()
        End Using

        dgvCustomers.DataSource = Nothing
        dgvCustomers.Columns.Clear()
        dgvCustomers.AutoGenerateColumns = True

        dgvCustomers.DataSource = GetAllCustomers()

        If dgvCustomers.Columns.Contains("CustomerID") Then
            dgvCustomers.Columns("CustomerID").Visible = False
        End If

        LoadDashboardStats()

    End Sub
    Private Sub frmDashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        dgvCustomers.DataSource = Nothing
        dgvCustomers.Columns.Clear()
        dgvCustomers.AutoGenerateColumns = True

        dgvCustomers.DataSource = GetAllCustomers()

        If dgvCustomers.Columns.Contains("CustomerID") Then
            dgvCustomers.Columns("CustomerID").Visible = False
        End If

        LoadDashboardStats()

    End Sub
    Private Sub LoadDashboardStats()

        Dim customers As DataTable = GetAllCustomers()

        Dim totalDebt As Decimal = 0
        Dim overdueCount As Integer = 0

        For Each customer As DataRow In customers.Rows

            Dim balance As Decimal = Convert.ToDecimal(customer("Total Debt Owed (GH₵)"))

            If balance > 0 Then
                totalDebt += balance
            End If

            If customer("Status").ToString() = "Overdue" Then
                overdueCount += 1
            End If

        Next

        lblTotalDebt.Text = "GH₵" & totalDebt.ToString("N2")

        lblTotalCustomers.Text = customers.Rows.Count.ToString()

        lblOverdueAccounts.Text = overdueCount.ToString()

    End Sub

    Private Sub btnTransaction_Click(sender As Object, e As EventArgs) Handles btnTransaction.Click
        Using transactionForm As New frmTransaction()
            transactionForm.ShowDialog(Me)
        End Using
    End Sub

    Private Sub btnCustomers_Click(sender As Object, e As EventArgs) Handles btnCustomers.Click
        Dim Customers_Click As New frmCustomers()
        Customers_Click.ShowDialog()
    End Sub
    Private Sub btnSettings_Click(sender As Object, e As EventArgs) Handles btnSettings.Click

        Using settingsForm As New frmSettings()
            settingsForm.ShowDialog(Me)
        End Using

    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click


        Dim result As DialogResult = MessageBox.Show(
        "Are you sure you want to logout?",
        "CreditBook - Logout",
        MessageBoxButtons.YesNo,
        MessageBoxIcon.Question
    )

        If result = DialogResult.Yes Then

            CurrentUserID = 0

            Me.Hide()

            Using loginForm As New frmLogin()
                loginForm.ShowDialog()
            End Using

            Me.Close()

        End If

    End Sub

    Private Sub btnViewReports_Click(sender As Object, e As EventArgs) Handles btnViewReports.Click
        Using reportsForm As New frmReports()
            reportsForm.ShowDialog(Me)
        End Using
    End Sub


End Class