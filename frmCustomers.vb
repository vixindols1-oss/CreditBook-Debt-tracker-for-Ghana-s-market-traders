Imports System.Data
Public Class frmCustomers
    Private customerTable As System.Data.DataTable
    Private Sub frmCustomers_Load(sender As Object, e As EventArgs) Handles MyBase.Load




        LoadCustomers()

    End Sub

    Private Sub LoadCustomers()

        Try

            customerTable = DbHelper.GetAllCustomers()

            dgvCustomers.DataSource = customerTable

            dgvCustomers.ReadOnly = True
            dgvCustomers.AllowUserToAddRows = False
            dgvCustomers.AllowUserToDeleteRows = False
            dgvCustomers.SelectionMode = DataGridViewSelectionMode.FullRowSelect
            dgvCustomers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
            dgvCustomers.RowHeadersVisible = False

            If dgvCustomers.Columns.Contains("CustomerID") Then
                dgvCustomers.Columns("CustomerID").Visible = False
            End If

        Catch ex As Exception

            MessageBox.Show("Unable to load customers: " & ex.Message,
                        "CreditBook",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error)

        End Try

    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click


        If customerTable Is Nothing Then Return

        Dim searchText As String = txtSearch.Text.Trim().Replace("'", "''")

        If searchText = "" Then
            customerTable.DefaultView.RowFilter = ""
        Else
            customerTable.DefaultView.RowFilter =
            "[Customer Name] LIKE '%" & searchText & "%' OR " &
            "[Phone Number] LIKE '%" & searchText & "%'"
        End If

        dgvCustomers.DataSource = customerTable.DefaultView

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click


        txtSearch.Clear()

        LoadCustomers()


    End Sub

    Private Sub btnAddCustomer_Click(sender As Object, e As EventArgs) Handles btnAddCustomer.Click


        txtSearch.Clear()

        LoadCustomers()


    End Sub
End Class