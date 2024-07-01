Public Class DEANScheduling
    Private Sub DEANScheduling_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        DoDisplayToDataGridView($"SELECT * FROM qryTeacher", dgvProf)
        DoDisplayToDataGridView($"SELECT * FROM qrySchedule", dgvAssigedProf)

    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click



    End Sub

End Class