Public Class ITMAssessment
    Private Sub cbSection_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbSection.SelectedIndexChanged
        cbSection.DropDownStyle = ComboBoxStyle.DropDownList
    End Sub

    Private Sub cbYRLVL_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbYRLVL.SelectedIndexChanged
        cbYRLVL.DropDownStyle = ComboBoxStyle.DropDownList
    End Sub

    Private Sub cbStudType_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbStudType.SelectedIndexChanged
        cbStudType.DropDownStyle = ComboBoxStyle.DropDownList
    End Sub

    Private Sub cbCourse_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbCourse.SelectedIndexChanged
        cbCourse.DropDownStyle = ComboBoxStyle.DropDownList
    End Sub

    Private Sub cbDCType_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbDCType.SelectedIndexChanged
        cbDCType.DropDownStyle = ComboBoxStyle.DropDownList
    End Sub

    Private Sub cbDCPercent_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbDCPercent.SelectedIndexChanged
        cbDCPercent.DropDownStyle = ComboBoxStyle.DropDownList
    End Sub

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        Dim btnPrint As New ITMPrintAssesment()
        btnPrint.Show()
    End Sub
End Class