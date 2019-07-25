Public Class Form2
    Dim SQL As New sqlcontroler
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If SQL.connection = True Then
            SQL.sqldata("select * from tblpatient")
            If SQL.ds.Tables.Count > 0 Then
                DataGridView1.DataSource = SQL.ds.Tables(0)
            End If
        Else
            MsgBox("error")
        End If

    End Sub

    Private Sub Addbtn_Click(sender As Object, e As EventArgs) Handles addbtn.Click
        add.Show()

    End Sub

    Private Sub EditBtn_Click(sender As Object, e As EventArgs) Handles editBtn.Click
        editform.Show()

    End Sub

    Private Sub DeleteBtn_Click(sender As Object, e As EventArgs) Handles deleteBtn.Click
        Dim del As String = "delete from tblpatient where name = '" & searchBox.Text & "'"
        If SQL.update(del) = 0 Then
            MsgBox("name not found")
        End If
        MsgBox("record deleted")
    End Sub
End Class