Public Class frmColor
    Dim RT As DialogResult
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        RT = ColorDialog1.ShowDialog()
        If RT = Windows.Forms.DialogResult.OK Then
            Me.PictureBox1.BackColor = Me.ColorDialog1.Color
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        RT = ColorDialog2.ShowDialog()
        If RT = Windows.Forms.DialogResult.OK Then
            Me.PictureBox2.BackColor = Me.ColorDialog2.Color
        End If
    End Sub

    Private Sub frmColor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.PictureBox1.BackColor = ColorSelect.Color1
        Me.PictureBox2.BackColor = ColorSelect.Color2
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ColorSelect.Color1 = Me.PictureBox1.BackColor
        ColorSelect.Color2 = Me.PictureBox2.BackColor
        frmMain.ChangeBlockColor(ColorSelect.Color1, ColorSelect.Color2)
        Me.Close()
    End Sub
End Class