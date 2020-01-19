Public Class DisplayCell
    Private Sub DisplayCell_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AddHandler Me.ChkCell.CheckedChanged, AddressOf frmMain.ShowNumber
    End Sub
End Class
