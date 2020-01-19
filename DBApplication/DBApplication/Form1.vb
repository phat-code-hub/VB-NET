Imports System.Data.SqlClient
Public Class fmCustomer
    'Dim cnStr = "Data Source=YUKA-PC\SQLEXPRESS;Initial Catalog=SampleDB;" &
    ' "Integrated Security=True"
    Dim cnStr = My.Settings.VB2012DBConnectionString
    Dim sql As String
    Dim dt As New DataTable
    Dim db As New DBClass("")
    Dim _ds As DataSet
    

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
        fmmenu.Show()
    End Sub

    Private Sub BtnShow_Click(sender As Object, e As EventArgs) Handles BtnShow.Click
        
        sql = "SELECT * FROM T顧客マスタ WHERE フリガナ LIKE '" &
                        Me.TextBox1.Text.Trim & "%'"
        dt = New DataTable
        db = New DBClass(cnStr)
        If Not db.GetDataFormDB(dt, sql) Then
            Exit Sub
        End If
        Me.DataGridView1.DataSource = dt
    End Sub

    Public Sub New(ds As DataSet)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        _ds = ds
    End Sub

    
End Class
