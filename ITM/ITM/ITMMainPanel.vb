Public Class ITMMainPanel
    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        ITMDashboard.TopLevel = False
        Panel2.Controls.Add(ITMDashboard)
        ITMDashboard.BringToFront()
        ITMDashboard.Show()
    End Sub

    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs) Handles Guna2Button2.Click
        ITMAssessment.TopLevel = False
        Panel2.Controls.Add(ITMAssessment)
        ITMAssessment.BringToFront()
        ITMAssessment.Show()
    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to log out?", "Log Out Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If result = DialogResult.Yes Then

            Me.Close()

            Dim form1 As New Form1()
            form1.Show()
        End If
    End Sub

    Private Sub Guna2Button4_Click(sender As Object, e As EventArgs) Handles Guna2Button4.Click
        ITMUserModify.TopLevel = False
        Panel2.Controls.Add(ITMUserModify)
        ITMUserModify.BringToFront()
        ITMUserModify.Show()
    End Sub

    Private Sub Guna2Button5_Click(sender As Object, e As EventArgs) Handles Guna2Button5.Click
        ITMSubjects.TopLevel = False
        Panel2.Controls.Add(ITMSubjects)
        ITMSubjects.BringToFront()
        ITMSubjects.Show()
    End Sub

    Private Sub Guna2Button6_Click(sender As Object, e As EventArgs) Handles Guna2Button6.Click
        ITMEnrollment.TopLevel = False
        Panel2.Controls.Add(ITMEnrollment)
        ITMEnrollment.BringToFront()
        ITMEnrollment.Show()
    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub

    Private Sub ITMMainPanel_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class