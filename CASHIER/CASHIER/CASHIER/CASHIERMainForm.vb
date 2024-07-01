Public Class CASHIERMainForm
    Private Sub btnDashboard_Click(sender As Object, e As EventArgs) Handles btnDashboard.Click
        CASHIERDashboard.TopLevel = False
        Panel2.Controls.Add(CASHIERDashboard)
        CASHIERDashboard.BringToFront()
        CASHIERDashboard.Show()
    End Sub

    Private Sub btnFinance_Click(sender As Object, e As EventArgs) Handles btnFinance.Click
        CASHIERFinance.TopLevel = False
        Panel2.Controls.Add(CASHIERFinance)
        CASHIERFinance.BringToFront()
        CASHIERFinance.Show()
    End Sub

    Private Sub btnStudents_Click(sender As Object, e As EventArgs) Handles btnStudents.Click
        CASHIERStudents.TopLevel = False
        Panel2.Controls.Add(CASHIERStudents)
        CASHIERStudents.BringToFront()
        CASHIERStudents.Show()
    End Sub


    Private Sub btnLogs_Click(sender As Object, e As EventArgs) Handles btnLogs.Click
        CASHIERLogs.TopLevel = False
        Panel2.Controls.Add(CASHIERLogs)
        CASHIERLogs.BringToFront()
        CASHIERLogs.Show()
    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to log out?", "Log Out Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If result = DialogResult.Yes Then

            Me.Close()

            Dim form1 As New Form1()
            form1.Show()
        End If
    End Sub
End Class