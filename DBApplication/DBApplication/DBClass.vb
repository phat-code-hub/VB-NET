Imports System.Data.SqlClient

Public Class DBClass
    Private _ConnectionString As String
    Public Sub New(ByVal ConnectionString As String)
        _ConnectionString = ConnectionString
    End Sub
    Public Function GetDataFormDB(ByVal DataTable As DataTable, ByVal strSQL As String) As Boolean
        Dim da As New SqlDataAdapter(strSQL, _ConnectionString)
        Try
            da.Fill(DataTable)
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function
End Class
