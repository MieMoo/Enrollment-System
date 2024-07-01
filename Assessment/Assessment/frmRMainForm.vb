Public Class frmITMDashboard
    Private Sub frmITMDashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        frmRDashboard.TopLevel = False
        Panel2.Controls.Add(frmRDashboard)
        frmRDashboard.BringToFront()
        frmRDashboard.Show()
    End Sub

    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs) Handles Guna2Button2.Click
        frmStudentInfo.TopLevel = False
        Panel2.Controls.Add(frmStudentInfo)
        frmStudentInfo.BringToFront()
        frmStudentInfo.Show()
    End Sub

    Private Sub Guna2Button4_Click(sender As Object, e As EventArgs) Handles Guna2Button4.Click
        frmRSubjects.TopLevel = False
        Panel2.Controls.Add(frmRSubjects)
        frmRSubjects.BringToFront()
        frmRSubjects.Show()
    End Sub


    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to log out?", "Log Out Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If result = DialogResult.Yes Then

            Me.Close()

            Dim form1 As New frmRegistrarLogin()
            frmRegistrarLogin.Show()
        End If
    End Sub
End Class