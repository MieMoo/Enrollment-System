Imports System.Data.OleDb

Module Module_Login

    Enum LoginStatus
        Success
        ZeroAttempt
        Locked
        Incorrect
        Empty
    End Enum

    Private ReadOnly maxAttempts As Integer = 5

    Private Function isZeroAttempts(reader As OleDbDataReader) As Boolean

        If reader("Attempts") >= maxAttempts Then

            DoUpdate($"UPDATE Account SET AccountStatus='Locked' WHERE AccountNo='{reader("AccountNo")}'")

            DoUpdate($"UPDATE Account SET Attempts='0' WHERE AccountNo='{reader("AccountNo")}'")

            Return True

        End If

        Return False

    End Function

    Public Function LoginResult(username As TextBox, password As TextBox, role() As String) As LoginStatus

        TestConnection()

        For i = 0 To role.Length - 1

            Dim sql = $"SELECT * FROM qryLogin WHERE Username='{username.Text}' AND Role='{role(i)}'"
            Dim command As New OleDbCommand(sql, con)
            Dim reader = command.ExecuteReader()

            If reader.Read Then
                If reader("AccountStatus").ToString = "Locked" Then
                    Return LoginStatus.Locked
                End If

                If reader("Passcode") <> password.Text Then

                    DoUpdate($"UPDATE Account SET Attempts='{reader("Attempts") + 1}' WHERE AccountNo='{reader("AccountNo")}'")

                    If isZeroAttempts(reader) Then
                        Return LoginStatus.ZeroAttempt
                    End If

                    Return LoginStatus.Incorrect
                Else

                    DoUpdate($"UPDATE Account SET Attempts='0' WHERE AccountNo='{reader("AccountNo")}'")

                    Return LoginStatus.Success

                End If
            End If
        Next

        Return LoginStatus.Empty

    End Function

    Public Function DoScalar(sql As String) As Object

        Dim cmd As New OleDbCommand(sql, con)
        Return cmd.ExecuteScalar()

    End Function

    Public Function DoReader(sql As String) As OleDbDataReader

        Dim cmd As New OleDbCommand(sql, con)
        Dim reader As OleDbDataReader = cmd.ExecuteReader()

        If reader.Read() Then
            Return reader
        Else
            Return Nothing
        End If

    End Function

End Module
