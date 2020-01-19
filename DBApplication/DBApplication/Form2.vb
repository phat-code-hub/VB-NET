Public Class fmGoods
    Dim sql As String
    Dim dt As DataTable
    'Dim cnStr = "Data Source=YUKA-PC\SQLEXPRESS;Initial Catalog=SampleDB;" &
    '                           "Integrated Security=True"
    Dim cnStr = My.Settings.VB2012DBConnectionString
    Dim db As New DBClass("")
    Private _dt As DataTable
    Private _ds As DataSet
    Public Sub New(ds As DataSet)
        InitializeComponent()
        ' Add any initialization after the InitializeComponent() call.
        _ds = ds
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        sql = "SELECT * FROM T商品マスタ WHERE 分類ID= " &
            Me.ComboBox1.SelectedValue
        dt = New DataTable
        db = New DBClass(cnStr)
        If Not db.GetDataFormDB(dt, sql) Then
            Exit Sub
        End If
        Me.DataGridView1.DataSource = dt
    End Sub

    Private Sub fmGoods_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'sql = "SELECT * FROM T分類マスタ"
        ''dt = New DataTable
        'db = New DBClass(cnStr)
        'If Not db.GetDataFormDB(dt, sql) Then
        '    Exit Sub
        'End If
        With Me.ComboBox1
            .DataSource = _ds.Tables("T分類マスタ")
            .ValueMember = "分類ID"
            .DisplayMember = "分類名"
        End With
    End Sub


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
        fmmenu.Show()
    End Sub

    
End Class