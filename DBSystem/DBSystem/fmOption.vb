Public Class fmOption
    Private _ds As DataSet
    Private _fm As Form
    Private db As New DBBox(My.Settings.ConnectionString)
    Public Sub New(ByVal ds As DataSet, ByVal fm As Form)
        InitializeComponent()
        Me._ds = ds
        Me._fm = fm
    End Sub

    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
        Me._fm.Show()
    End Sub

    Private Sub FmOption_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        Me._fm.Show()
    End Sub

    Private Sub BtnCustomerMaster_Click(sender As Object, e As EventArgs) Handles btnCustomerMaster.Click
        Dim fm As New FmCustomerMaster(Me._ds, Me)
        fm.Show()
        Me.Hide()
    End Sub

    Private Sub BtnGoodMaster_Click(sender As Object, e As EventArgs) Handles btnGoodMaster.Click
        Dim fm As New fmGoodsMaster(_ds, Me)
        fm.Show()
        Me.Hide()
    End Sub
End Class