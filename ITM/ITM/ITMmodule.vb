Imports System.Data.OleDb

Module ITMmodule
    Dim conStr = $"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={Application.StartupPath}\EnrollmentSystem.accdb"
    Public con As New OleDbConnection(conStr)
    Public isConnectionTested = False

    Public Sub TestConnection()

        If isConnectionTested Then

            Return

        End If

        Try

            If ConnectionState.Open Then

                con.Close()

            End If

            con.Open()
            isConnectionTested = True

        Catch ex As Exception
            MessageBox.Show("At ITMmodule " + vbNewLine + ex.Message)
        End Try

    End Sub
End Module
