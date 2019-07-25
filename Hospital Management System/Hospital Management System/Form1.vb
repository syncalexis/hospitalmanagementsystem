Public Class Form1
    Dim SQL As New sqlcontroler
    Private Sub Loginbtn_Click(sender As Object, e As EventArgs) Handles loginbtn.Click
        If SQL.connection = True Then
            If isauthenticated() = True Then
                MsgBox("LOGIN SUCCESSFUL")

                Form2.Show()
                Me.Hide()
                userBox.Clear()
                passBox.Clear()

            End If


        End If



    End Sub

    Public Function isauthenticated() As Boolean
        If SQL.ds IsNot Nothing Then
            SQL.ds.Clear()


        End If
        SQL.sqldata("select Count(userName) as UserCount from tbladmin where userName = '" & userBox.Text & "' and passWord= '" & passBox.Text & "' ")
        If SQL.ds.Tables(0).Rows(0).Item("UserCount") = 1 Then
            Return True

        End If
        MsgBox("invalid credentials.", MsgBoxStyle.Critical, "LOGIN FAILED")
    End Function
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' If SQL.connection = True Then
        'MsgBox("success")
        'Else
        'MsgBox("error")
        'End If

    End Sub
End Class
