Public Class ITMEnrollment
    Private Sub Guna2Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Guna2Panel2.Paint

    End Sub

    Private Sub cbYRMod_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbYRMod.SelectedIndexChanged
        cbYRMod.DropDownStyle = ComboBoxStyle.DropDownList
    End Sub

    Private Sub cbCourse_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbCourse.SelectedIndexChanged
        cbCourse.DropDownStyle = ComboBoxStyle.DropDownList
    End Sub

    Private Sub cbSemester_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbSemester.SelectedIndexChanged
        cbSemester.DropDownStyle = ComboBoxStyle.DropDownList
    End Sub

    Private Sub cbDCType_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbDCType.SelectedIndexChanged
        cbDCType.DropDownStyle = ComboBoxStyle.DropDownList
    End Sub

    Private Sub cbDCPercent_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbDCPercent.SelectedIndexChanged
        cbDCPercent.DropDownStyle = ComboBoxStyle.DropDownList
    End Sub

    Private Sub btnPrintForm_Click(sender As Object, e As EventArgs) Handles btnPrintForm.Click
        Dim printForm As New ITMPrintENROLL()
        printForm.Show()
    End Sub
End Class