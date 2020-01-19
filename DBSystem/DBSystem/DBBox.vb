Imports System.Data.SqlClient

Public Class DBBox
    Private _ConnectionString As String
    Public Sub New(ByVal ConnectionString As String)
        _ConnectionString = ConnectionString
    End Sub
    Public Overloads Function GetDataFormDB(ByVal DataTable As DataTable, ByVal strSQL As String) As Boolean
        Dim da As New SqlDataAdapter(strSQL, Me._ConnectionString)
        Try
            da.Fill(DataTable)
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function
    Public Overloads Function GetDataFormDB(ByVal ds As DataSet, ByVal strDataTable As String,
                        ByVal strSQL As String) As Boolean
        Dim da As New SqlDataAdapter(strSQL, Me._ConnectionString)
        Try
            da.Fill(ds, strDataTable)
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function
    Public Function UpdateData(ByVal strSQL As String) As Boolean
        Using cn As New SqlConnection(_ConnectionString)
            Using cmd As New SqlCommand(strSQL, cn)
                Try
                    cn.Open()
                    cmd.ExecuteNonQuery()
                    Return True
                Catch ex As Exception
                    Return False
                End Try
            End Using
        End Using
    End Function
End Class
