﻿Public Class FmMain
    Private _ds As DataSet
    Private db As New DBBox(My.Settings.ConnectionString)
    Public Sub New(ByVal ds As DataSet)
        InitializeComponent()
        Me._ds = ds
    End Sub

    Private Sub BtnQuit_Click(sender As Object, e As EventArgs) Handles BtnQuit.Click
        Dim msg As String = "売上管理システムを終了します。よろしいですか？"
        Dim res As DialogResult = MessageBox.Show(msg, "確認", MessageBoxButtons.OKCancel, MessageBoxIcon.Information)
        If res = Windows.Forms.DialogResult.OK Then
            Application.Exit()
        End If
    End Sub

    Private Sub FmMain_Load(sender As Object, e As EventArgs) Handles Me.Load
        Me.LblLogInMessage.Text = Me._ds.Tables("TLogIn").Rows(0)("UserName").ToString &
            " さん 今日も楽しい一日を"
    End Sub

    Private Sub BtnOption_Click(sender As Object, e As EventArgs) Handles BtnOption.Click
        Dim fm As New FmOption(_ds, Me)
        fm.Show()
        Me.Hide()
    End Sub

    Private Sub BtnNewSlip_Click(sender As Object, e As EventArgs) Handles BtnNewSlip.Click
        Dim fm As New FmSalesInfo(_ds, Me)
        fm.Show()
        Me.Hide()
    End Sub
End Class