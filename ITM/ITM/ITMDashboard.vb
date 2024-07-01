Public Class ITMDashboard
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lblDate.Text = Date.Now.ToString("MMM | dd | yyyy")
        lblTime.Text = Date.Now.ToString("HH:MM:ss")
    End Sub

    Private Sub ITMDashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Enabled = True
    End Sub
End Class