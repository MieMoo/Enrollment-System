Public Class frmStudentInfo
    Private Sub frmStudentInfo_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        DoDisplayToDataGridView($"SELECT * FROM qryStudent", dgv)

    End Sub

    Private Sub tbStudentID_TextChanged(sender As Object, e As EventArgs) Handles tbStudentID.TextChanged

        Dim reader = DoReader($"SELECT * FROM qryStudent WHERE StudentID='{tbStudentID.Text}'")

        If reader IsNot Nothing Then

            DoDisplayToDataGridView($"SELECT * FROM qryStudent WHERE StudentID='{tbStudentID.Text}'", dgv)

        Else

            DoDisplayToDataGridView($"SELECT * FROM qryStudent", dgv)

        End If

    End Sub

End Class