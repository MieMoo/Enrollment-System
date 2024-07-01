Public Class ADMISSIONDashboard
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lblDate.Text = Date.Now.ToString("MMM | dd | yyyy")
        lblTime.Text = Date.Now.ToString("HH:MM:ss")
    End Sub

    Private Sub ADMISSIONDashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Timer1.Enabled = True

        lblEnrolled.Text = DoScalar("SELECT COUNT(*) FROM EnrollmentDetails WHERE EnrollmentStatus='Enrolled'")
        lblActive.Text = DoScalar("SELECT COUNT(*) FROM Account WHERE AccountStatus='Active' AND Role='Student'")
        lblInactive.Text = DoScalar("SELECT COUNT(*) FROM Account WHERE AccountStatus='Inactive' AND Role='Student'")

    End Sub

End Class