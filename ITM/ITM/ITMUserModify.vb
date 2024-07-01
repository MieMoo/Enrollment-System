Public Class ITMUserModify
    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub cbModule_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbModule.SelectedIndexChanged
        cbModule.DropDownStyle = ComboBoxStyle.DropDownList
    End Sub

    Private Sub cbAccessLVL_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbAccessLVL.SelectedIndexChanged
        cbAccessLVL.DropDownStyle = ComboBoxStyle.DropDownList
    End Sub

    Private Sub cbRole_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbRole.SelectedIndexChanged
        cbRole.DropDownStyle = ComboBoxStyle.DropDownList
    End Sub

    Private Sub cbAcctStatus_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbAcctStatus.SelectedIndexChanged
        cbAcctStatus.DropDownStyle = ComboBoxStyle.DropDownList
    End Sub

    Private Sub cbAccess_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbAccess.SelectedIndexChanged
        cbAccess.DropDownStyle = ComboBoxStyle.DropDownList
    End Sub
End Class