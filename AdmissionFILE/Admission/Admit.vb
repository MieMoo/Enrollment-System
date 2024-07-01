Imports System.Data.OleDb
Imports Guna.UI.WinForms

Public Class Admit

    Private Sub Guna2Button1_Click_1(sender As Object, e As EventArgs) Handles Guna2Button1.Click

        Dim currentNo = DoIncrement("SELECT MAX(AccountNo) FROM Users")
        Dim currentStudentNo = DoIncrement("SELECT MAX(StudentID) FROM Student")

        Dim users As New MieInsertInto("Users")
        users.AddValueToColumn("AccountNo", currentNo)
        users.AddValueToColumn("FirstName", tbFN.Text)
        users.AddValueToColumn("MiddleName", tbMN.Text)
        users.AddValueToColumn("LastName", tbLN.Text)
        users.AddValueToColumn("Address", tbAddress.Text)
        users.AddValueToColumn("Email", tbEmail.Text)
        users.AddValueToColumn("ContactNo", tbContact.Text)
        users.AddValueToColumn("BDate", dtpBirthday.Value)
        users.AddValueToColumn("GuardianName", tbGuardianN.Text)
        users.AddValueToColumn("Relationship", cbRS.SelectedItem)
        users.AddValueToColumn("GuardianNo", tbGContact.Text)
        users.ExecuteNonQuery()


        Dim account As New MieInsertInto("Account")
        account.AddValueToColumn("AccountNo", currentNo)
        account.AddValueToColumn("Role", "Student")
        account.AddValueToColumn("Username", "")
        account.AddValueToColumn("Passcode", "")
        account.AddValueToColumn("AccountStatus", "Active")
        account.AddValueToColumn("Attempts", "0")
        account.AddValueToColumn("DateRegistered", Date.Now)
        account.ExecuteNonQuery()

        Dim requirements As New MieInsertInto("requirements")
        requirements.AddValueToColumn("studentid", currentStudentNo)
        requirements.AddValueToColumn("birthcert", chbBirth.Checked)
        requirements.AddValueToColumn("form137", chbF137.Checked)
        requirements.AddValueToColumn("form138", chbReportCard.Checked)
        requirements.AddValueToColumn("goodmoral", chbGoodMoral.Checked)
        requirements.AddValueToColumn("2by2pic", chb2by2.Checked)
        requirements.AddValueToColumn("2pcsenvelope", chb2pcsEnvelope.Checked)
        requirements.ExecuteNonQuery()

        Dim student As New MieInsertInto("Student")
        student.AddValueToColumn("StudentID", currentStudentNo)
        student.AddValueToColumn("AccountNo", currentNo)
        student.AddValueToColumn("Course", cbCourse.SelectedItem)
        student.AddValueToColumn("SchoolYear", cbYRLVL.SelectedItem)
        student.AddValueToColumn("Semester", cbSemester.SelectedItem)
        student.AddValueToColumn("Balance", "0")
        student.AddValueToColumn("Discount", "0")
        student.ExecuteNonQuery()

    End Sub

    Private Sub cbYRLVL_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbYRLVL.SelectedIndexChanged
        cbYRLVL.DropDownStyle = ComboBoxStyle.DropDownList
    End Sub

    Private Sub cbCourse_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbCourse.SelectedIndexChanged
        cbCourse.DropDownStyle = ComboBoxStyle.DropDownList
    End Sub

    Private Sub cbRS_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbRS.SelectedIndexChanged
        cbRS.DropDownStyle = ComboBoxStyle.DropDownList
    End Sub

    Private Sub cbSemester_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbSemester.SelectedIndexChanged
        cbSemester.DropDownStyle = ComboBoxStyle.DropDownList
    End Sub

    Private Sub Admit_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub ClearValues()


        For Each ctrl As Control In Me.Controls
            If TypeOf ctrl Is TextBox Then
                If DirectCast(ctrl, TextBox).Name = "tbStudentNo" Then
                    Continue For
                End If
                DirectCast(ctrl, TextBox).Text = ""
            ElseIf TypeOf ctrl Is ComboBox Then
                DirectCast(ctrl, ComboBox).SelectedIndex = 0
            ElseIf TypeOf ctrl Is DateTimePicker Then
                DirectCast(ctrl, DateTimePicker).Value = DirectCast(ctrl, DateTimePicker).MaxDate
            ElseIf TypeOf ctrl Is GunaCheckBox Then
                DirectCast(ctrl, GunaCheckBox).Checked = False
            End If
        Next

    End Sub

    Private Sub TextBox1_TextChanged_1(sender As Object, e As EventArgs) Handles tbStudentNo.TextChanged

        Dim reader = DoReader($"SELECT * FROM qryStudent WHERE StudentID='{tbStudentNo.Text}'")

        If reader Is Nothing Then
            ClearValues()
            Return
        End If

        DoUpdateObj(tbFN, reader("Firstname"))
        DoUpdateObj(tbMN, reader("Middlename"))
        DoUpdateObj(tbLN, reader("Lastname"))
        DoUpdateObj(tbContact, reader("ContactNo"))
        DoUpdateObj(dtpBirthday, reader("BDate"))
        DoUpdateObj(tbAge, Date.Now.Year - dtpBirthday.Value.Year)
        DoUpdateObj(tbEmail, reader("Email"))
        DoUpdateObj(tbAddress, reader("Address"))
        DoUpdateObj(cbSemester, reader("Semester"))
        DoUpdateObj(cbYRLVL, reader("SchoolYear"))
        DoUpdateObj(cbCourse, reader("Course"))
        DoUpdateObj(tbGuardianN, reader("GuardianName"))
        DoUpdateObj(cbRS, reader("Relationship"))
        DoUpdateObj(tbGContact, reader("GuardianNo"))

        DoUpdateObj(chbBirth, reader("BirthCert"))
        DoUpdateObj(chbF137, reader("Form137"))
        DoUpdateObj(chbReportCard, reader("Form138"))
        DoUpdateObj(chbGoodMoral, reader("GoodMoral"))
        DoUpdateObj(chb2by2, reader("2by2Pic"))
        DoUpdateObj(chb2pcsEnvelope, reader("2pcsEnvelope"))

    End Sub
End Class