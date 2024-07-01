Imports System.Data.OleDb
Imports Guna.UI.WinForms
Imports System.IO

Module AccDB

#Region "Connection"

    Dim workingDirectory = Environment.CurrentDirectory
    Dim conStr = $"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={Directory.GetParent(workingDirectory).Parent.Parent.Parent.Parent.FullName}\Database\EnrollmentSystem.accdb"
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
            MessageBox.Show("At AccDB " + vbNewLine + ex.Message)
            Application.Exit()
        End Try

    End Sub

#End Region

#Region "Commands"

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

    Public Sub DoUpdate(sql As String)

        Dim command As New OleDbCommand(sql, con)
        command.ExecuteNonQuery()


    End Sub

    Public Function DoIncrement(sql As String) As String

        Return Integer.Parse((DoScalar(sql) + 1).ToString())

    End Function

    Public Sub DoDisplayToDataGridView(sql As String, dgv As DataGridView)

        Dim da As New OleDbDataAdapter(sql, con)
        Dim table As New DataTable
        da.Fill(table)

        dgv.DataSource = table

    End Sub

    Public Class MieInsertInto
        Private table As String

        Public Sub New(table As String)
            Me.table = table
        End Sub

        Private columnFormat As String
        Private valueFormat As String

        Public Sub AddValueToColumn(column As String, value As String)
            columnFormat += $"{column}, "
            valueFormat += $"'{value}', "
        End Sub

        Public Sub ExecuteNonQuery()

            Dim sql = $"INSERT INTO {table} ({columnFormat.Substring(0, columnFormat.Length - 2)}) VALUES ({valueFormat.Substring(0, valueFormat.Length - 2)})"
            MessageBox.Show(sql)
            Dim command As New OleDbCommand(sql, con)
            command.ExecuteNonQuery()

        End Sub

    End Class

    Public Sub DoUpdateObj(obj As Object, value As Object)

        If IsDBNull(value) Then
            Return
        End If

        If TypeOf obj Is TextBox Then

            DirectCast(obj, TextBox).Text = value

        ElseIf TypeOf obj Is ComboBox Then

            DirectCast(obj, ComboBox).SelectedItem = value

        ElseIf TypeOf obj Is DateTimePicker Then

            DirectCast(obj, DateTimePicker).Value = value

        ElseIf TypeOf obj Is GunaCheckBox Then

            DirectCast(obj, GunaCheckBox).Checked = value

        End If

    End Sub

#End Region

#Region "Login"
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

#End Region


End Module
