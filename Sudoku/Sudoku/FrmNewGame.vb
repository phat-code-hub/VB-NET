Public Class FrmNewGame

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
        FrmMainMenu.Show()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Me.Close()
        Level = PlayLevel.Custom
        frmMain.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
        Level = PlayLevel.Easy
        frmMain.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()
        Level = PlayLevel.Intermediate
        frmMain.Show()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Close()
        Level = PlayLevel.Hard
        frmMain.Show()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Me.Close()
        Level = PlayLevel.Professional
        frmMain.Show()
    End Sub

    Private Sub FrmNewGame_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        IsRestored = False
    End Sub
End Class