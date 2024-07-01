Imports System.Data.OleDb

Module Module_Login
    Enum LoginStatus
        Success
        ZeroAttempt
        Locked
        Incorrect
        Empty
    End Enum

    Private Sub UpdateAttempts(reader As OleDbDataReader)

        Dim sql = $"UPDATE tblUser SET Attempts={reader("Attempts") + 1} WHERE EmployeeNo='{reader("EmployeeNo")}'"
        Dim command As New OleDbCommand(sql, con)
        command.ExecuteNonQuery()

    End Sub

    Private Sub ResetAttempts(reader As OleDbDataReader)

        Dim sql = $"UPDATE tblUser SET Attempts=0 WHERE EmployeeNo='{reader("EmployeeNo")}'"
        Dim command As New OleDbCommand(sql, con)
        command.ExecuteNonQuery()

    End Sub

    Private ReadOnly maxAttempts As Integer = 5

    Private Function isZeroAttempts(reader As OleDbDataReader) As Boolean

        If reader("Attempts") >= maxAttempts Then

            Dim sql = $"UPDATE tblUser SET AcctStatus='Locked' WHERE EmployeeNo='{reader("EmployeeNo")}'"
            Dim command As New OleDbCommand(sql, con)
            command.ExecuteNonQuery()

            ResetAttempts(reader)

            Return True

        End If


    End Function

    Public Function LogiinREsult(username As TextBox, password As TextBox, role() As String) As LoginStatus

        TestConnection()

        For i = 0 To role.Length - 1

            Dim sql = $"SELECT * FROM qryUser WHERE Username='{username.Text}' AND Role='{role(i)}'"
            Dim command As New OleDbCommand(sql, con)
            Dim reader = command.ExecuteReader()

            If reader.Read Then
                If reader("AcctStatus").ToString = "Locked" Then
                    Return LoginStatus.Locked
                End If

                If reader("Password") <> password.Text Then

                    UpdateAttempts(reader)

                    If isZeroAttempts(reader) Then
                        Return LoginStatus.ZeroAttempt
                    End If

                    Return LoginStatus.Incorrect
                Else
                    ResetAttempts(reader)

                    Return LoginStatus.Success
                End If
            End If

        Next

        Return LoginStatus.Empty

    End Function
End Module
