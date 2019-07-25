Imports System.Data.Sql
Imports System.Data.SqlClient

Public Class sqlcontroler
    Private SQLcon As New SqlConnection With {.ConnectionString = "server = ALEXIS-PC; database=HOSPITAMIS; Integrated Security=SSPI"}
    Public ds As DataSet
    Public adapter As SqlDataAdapter
    Public sqlcmd As SqlCommand


    Public Function connection() As Boolean
        Try
            SQLcon.Open()
            SQLcon.Close()

            Return True
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try



    End Function

    Public Sub sqldata(data As String)
        Try
            SQLcon.Open()
            sqlcmd = New SqlCommand(data, SQLcon)
            adapter = New SqlDataAdapter(sqlcmd)
            ds = New DataSet
            adapter.Fill(ds)


            SQLcon.Close()
        Catch ex As Exception
            MsgBox(ex.Message)

        End Try




    End Sub

    Public Sub add(name As String, address As String, age As String, sex As String, blood_type As String, nationality As String, status As String)
        Dim strAdd As String = "insert into tblpatient(name,address,age,sex,blood_type,nationality,status) values('" & name & "','" & address & "','" & age & "','" & sex & "','" & blood_type & "','" & nationality & "','" & status & "' )"
        Try
            SQLcon.Open()
            sqlcmd = New SqlCommand(strAdd, SQLcon)
            sqlcmd.ExecuteNonQuery()
            MsgBox("success")

            SQLcon.Close()
        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
    End Sub


    Public Function update(datas As String) As Integer

        Try
            SQLcon.Open()
            sqlcmd = New SqlCommand(datas, SQLcon)
            Dim cCount As Integer = sqlcmd.ExecuteNonQuery()

            SQLcon.Close()
            Return cCount
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return 0
    End Function

End Class
