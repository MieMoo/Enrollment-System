Imports System.Data.OleDb
Public Class Form1

    Private Sub btnlogin_Click(sender As Object, e As EventArgs) Handles btnlogin.Click

        Dim status = LoginResult(txtUsername, txtPassword, {"Dean"})

        Select Case status
            Case LoginStatus.Success

                Hide()
                DEANMainPanel.Show()

            Case LoginStatus.Incorrect

                MessageBox.Show("Incorrect Password")

            Case LoginStatus.ZeroAttempt

                MessageBox.Show("Attempts Exceeded")

            Case LoginStatus.Locked

                MessageBox.Show("Locked")

            Case Else

        End Select

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
