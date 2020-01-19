Public Class fmmenu
    'Dim cnStr = "Data Source=YUKA-PC\SQLEXPRESS;Initial Catalog=SampleDB;" &
    '                           "Integrated Security=True"
    Dim cnStr = My.Settings.VB2012DBConnectionString
    Dim sql As String
    Dim dt As DataTable
    Dim db As New DBClass("")
    Dim ds As DataSet
   
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        Dim fm As New fmCustomer(ds)
        fm.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        End
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        'sql = "SELECT * FROM T分類マスタ"
        'dt = New DataTable
        'db = New DBClass(cnStr)
        'If Not db.GetDataFormDB(dt, sql) Then
        '    MessageBox.Show("Not Found !", "Error", MessageBoxButtons.OK,
        '                    MessageBoxIcon.Exclamation)
        '    Exit Sub
        'End If
        Me.Hide()
        Dim fm As New fmGoods(ds)
        fm.Show()

    End Sub

    Private Sub fmmenu_Load(sender As Object, e As EventArgs) Handles Me.Load
        sql = "SELECT * FROM T分類マスタ"
        dt = New DataTable
        db = New DBClass(cnStr)
        ds = New DataSet
        If Not db.GetDataFormDB(dt, sql) Then
            MessageBox.Show("Not Found !", "Error", MessageBoxButtons.OK,
                            MessageBoxIcon.Exclamation)
            Exit Sub
        End If
        dt.TableName = "T分類マスタ"
        ds.Tables.Add(dt)
    End Sub
End Class