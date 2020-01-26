Public Class FmLogIn
    'Private cnStr = "Data Source=YUKA-PC\SQLEXPRESS;Initial Catalog=SampleDB;Integrated Security=True"
    Private ds As New DataSet
    Private db As New DBBox(My.Settings.ConnectionString)
    Private Sub BtnQuit_Click(sender As Object, e As EventArgs) Handles BtnQuit.Click
        Me.Close()
    End Sub

    Private Sub FmLogIn_Load(sender As Object, e As EventArgs) Handles Me.Load
        BtnLogin.Enabled = False
        If Not db.GetDataFormDB(ds, "T分類マスタ", "SELECT * FROM T分類マスタ") Then
            Dim msg As String = "データバースに接続できません！終了してください"
            MessageBox.Show(msg, "接続エラー", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.BtnLogin.Enabled = False
            Exit Sub
        End If
        db.GetDataFormDB(ds, "Tメーカーマスタ", "SELECT * FROM Tメーカーマスタ")
    End Sub

    Private Sub BtnLogin_Click(sender As Object, e As EventArgs) Handles BtnLogin.Click
        Dim sql As String = "SELECT PassWord, UserName,LogInID FROM TLogIn WHERE " &
                            "LogInID='" & Me.TxtID.Text & "'"
        If db.GetDataFormDB(ds, "TLogIn", sql) Then
            If ds.Tables("TLogIn").Rows.Count = 0 Then
                Exit Sub
            End If
            Dim KQ1 As Boolean = ds.Tables("TLogIn").Rows(0)("LogInID").ToString = Me.TxtID.Text.Trim
            Dim KQ2 As Boolean = ds.Tables("TLogIn").Rows(0)("PassWord").ToString = Me.TxtPW.Text.Trim
            If KQ1 Then
                If KQ2 Then
                    ' MessageBox.Show("正しいパスワードです.")
                    Dim fm As New FmMain(ds)
                    fm.Show()
                    Me.Hide()
                Else
                    MessageBox.Show("パスワードが正しくない!")
                End If
            Else
                MessageBox.Show("ユーザーIDが間違っています。")
            End If
        End If
    End Sub

    Private Sub TxtID_KeyUp(sender As Object, e As KeyEventArgs) Handles TxtID.KeyUp
        Me.BtnLogin.Enabled = True
    End Sub

End Class