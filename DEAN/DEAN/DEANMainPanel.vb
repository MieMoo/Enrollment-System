Public Class DEANMainPanel
    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        DEANDashboard.TopLevel = False
        Panel2.Controls.Add(DEANDashboard)
        DEANDashboard.BringToFront()
        DEANDashboard.Show()
    End Sub

    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs) Handles Guna2Button2.Click
        DEANProfileTab.TopLevel = False
        Panel2.Controls.Add(DEANProfileTab)
        DEANProfileTab.BringToFront()
        DEANProfileTab.Show()
    End Sub

    Private Sub Guna2Button3_Click(sender As Object, e As EventArgs) Handles Guna2Button3.Click
        DEANStudentTab.TopLevel = False
        Panel2.Controls.Add(DEANStudentTab)
        DEANStudentTab.BringToFront()
        DEANStudentTab.Show()
    End Sub

    Private Sub Guna2Button4_Click(sender As Object, e As EventArgs) Handles Guna2Button4.Click
        DEANScheduling.TopLevel = False
        Panel2.Controls.Add(DEANScheduling)
        DEANScheduling.BringToFront()
        DEANScheduling.Show()
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