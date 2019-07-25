Public Class editform
    Dim SQL As New sqlcontroler
    Private Sub TextBox7_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub SaveBtn_Click(sender As Object, e As EventArgs) Handles saveBtn.Click
        Dim edit As String
        If maleCheck.Checked = True Then
            edit = "update tblpatient set name = '" & nameBox.Text & "', address = '" & addressBox.Text & "', age = '" & ageBox.Text & "',
                                                       sex = '" & "male" & "', blood_type = '" & bloodtypeBox.Text & "', nationality = '" & nationalityBox.Text & "', status = '" & statusBox.Text & "' where name = '" & Form2.searchBox.Text & "' "
            If SQL.update(edit) = 0 Then
                MsgBox("name found")
            Else
                MsgBox("updated")
            End If

        ElseIf femaleCheck.Checked = True Then
            edit = "update tblpatient set name = '" & nameBox.Text & "', address = '" & addressBox.Text & "', age = '" & ageBox.Text & "',
                                                       sex = '" & "female" & "', blood_type = '" & bloodtypeBox.Text & "', nationality = '" & nationalityBox.Text & "', status = '" & statusBox.Text & "' where name = '" & Form2.searchBox.Text & "' "

            If SQL.update(edit) = 0 Then
                MsgBox("name found")
            Else
                MsgBox("updated")
            End If
        Else
            MsgBox("pls choose your sex")

        End If

    End Sub

    Private Sub CancelBtn_Click(sender As Object, e As EventArgs) Handles cancelBtn.Click
        Me.Hide()
        nameBox.Clear()
        addressBox.Clear()
        ageBox.Clear()
        bloodtypeBox.Clear()
        nationalityBox.Clear()
        statusBox.Clear()
    End Sub
End Class