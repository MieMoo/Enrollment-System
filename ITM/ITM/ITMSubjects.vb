Public Class ITMSubjects
    Private Sub cbSubjectsS_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbSubjectsS.SelectedIndexChanged
        cbSubjectsS.DropDownStyle = ComboBoxStyle.DropDownList
    End Sub

    Private Sub cbCourseSub_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbCourseSub.SelectedIndexChanged
        cbCourseSub.DropDownStyle = ComboBoxStyle.DropDownList
    End Sub

    Private Sub cbYRLVL_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbYRLVL.SelectedIndexChanged
        cbYRLVL.DropDownStyle = ComboBoxStyle.DropDownList
    End Sub

    Private Sub cbAcctStatus_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbAcctStatus.SelectedIndexChanged
        cbAcctStatus.DropDownStyle = ComboBoxStyle.DropDownList
    End Sub

    Private Sub cbYRMod_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbYRMod.SelectedIndexChanged
        cbYRMod.DropDownStyle = ComboBoxStyle.DropDownList
    End Sub
End Class