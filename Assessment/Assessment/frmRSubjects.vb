Public Class frmRSubjects

    Private Sub frmRSubjects_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        DoDisplayToDataGridView($"SELECT * FROM qrySubjects", dgv)

    End Sub

    Private Sub txtSubCode_TextChanged(sender As Object, e As EventArgs) Handles txtSubCode.TextChanged


        Dim reader = DoReader($"SELECT * FROM qrySubjects WHERE SubjectCode='{txtSubCode.Text}'")

        If reader IsNot Nothing Then

            DoDisplayToDataGridView($"SELECT * FROM qrySubjects WHERE SubjectCode='{txtSubCode.Text}'", dgv)

        Else

            DoDisplayToDataGridView($"SELECT * FROM qrySubjects", dgv)

        End If

    End Sub


End Class