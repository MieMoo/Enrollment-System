Public Class Form1
    Private Sub btnlogin_Click(sender As Object, e As EventArgs)
        Dim status = LogiinREsult(txtUsername, txtPassword, {"ITM"})

        Select Case status
            Case LoginStatus.Success

                Hide()
                ITMMainPanel.Show()

            Case LoginStatus.Incorrect

                MessageBox.Show("Incorrect Password")

            Case LoginStatus.ZeroAttempt

                MessageBox.Show("Attempts Exceeded")

            Case LoginStatus.Locked

                MessageBox.Show("Locked")

            Case Else

        End Select
    End Sub
End Class
