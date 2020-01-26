Public Class FmSalesInfo
    Const ENTRY_HEIGHT As Integer = 160
    Const LIST_HEIGHT As Integer = 150
    Const MAINTOP As Integer = 60
    Const SUB_TOP As Integer = 230
    Private db As New DBBox(My.Settings.ConnectionString)
    Private _ds As DataSet
    Private _fm As Form
    Private _SlipNo As Integer = -1
    Private TargetOperation As Integer
    Private dtSalesMeisai As New DataTable

    Private Enum Operation
        entry = 1
        update = 2
    End Enum

    Public Sub New(ByVal ds As DataSet, ByVal fm As Form)
        InitializeComponent()
        _ds = ds
        _fm = fm
    End Sub
    Public Sub New(ByVal ds As DataSet, ByVal fm As Form, ByVal slipNo As Integer)
        InitializeComponent()
        _ds = ds
        _fm = fm
        _SlipNo = slipNo
    End Sub

    Private Sub FmSalesInfo_Load(sender As Object, e As EventArgs) Handles Me.Load
        With Me
            .txtSlipNo.ReadOnly = True
            .txtGoodsID.TextAlign = HorizontalAlignment.Right
            .txtPrice.TextAlign = HorizontalAlignment.Right
            .txtQuantity.TextAlign = HorizontalAlignment.Right
            .btnUpdateMeisai.Visible = False
            .btnDeleteMeisai.Visible = False
            InvisibleEntryArea()
        End With
    End Sub

    Private Sub InvisibleEntryArea()
        'Throw New NotImplementedException()
        With Me
            .PanelMain.Height = ENTRY_HEIGHT
            .PanelEntry.Height = 0
            .panelSub.Top = MAINTOP
            '.Height = .panelSub.Top + .panelSub.Height + 10

        End With
    End Sub

    Private Sub FmSalesInfo_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        _fm.Show()
    End Sub

    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

End Class