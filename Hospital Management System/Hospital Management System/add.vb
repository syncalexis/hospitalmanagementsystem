Public Class add
    Dim SQL As New sqlcontroler
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If fcheck.Checked = True Then
            SQL.add(nameBox.Text, addressBox.Text, ageBox.Text, "Female", bloodBox.Text, nationalityBox.Text, statusBox.Text)

        ElseIf mcheck.Checked = True Then

            SQL.add(nameBox.Text, addressBox.Text, ageBox.Text, "Memale", bloodBox.Text, nationalityBox.Text, statusBox.Text)

        Else
            MsgBox("pls choose your sex")
        End If

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        nameBox.Clear()
        addressBox.Clear()
        ageBox.Clear()
        bloodBox.Clear()
        nationalityBox.Clear()
        statusBox.Clear()

    End Sub
End Class