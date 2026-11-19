Public Class frmReports
    Private Sub frmReports_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        Try

            Dim summary As DataTable = DbHelper.GetReportSummary()

            If summary.Rows.Count > 0 Then

                Dim row As DataRow = summary.Rows(0)

                lblTotalCustomers.Text =
                row("TotalCustomers").ToString()

                lblOutstandingDebt.Text =
                "GH₵ " & Convert.ToDecimal(row("OutstandingDebt")).ToString("N2")

                lblTotalCredit.Text =
                "GH₵ " & Convert.ToDecimal(row("TotalCredit")).ToString("N2")

                lblTotalRepayments.Text =
                "GH₵ " & Convert.ToDecimal(row("TotalRepayments")).ToString("N2")

            End If

        Catch ex As Exception

            MessageBox.Show("Unable to load reports: " & ex.Message,
                        "CreditBook",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error)

        End Try

    End Sub

End Class