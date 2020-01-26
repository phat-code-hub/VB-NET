Public Class FmCustomerMaster
    Private db As New DBBox(My.Settings.ConnectionString)
    Private _ds As DataSet
    Private _fm As Form
    Const ENTRY_TOP As Integer = 100
    Const LIST_HEIGHT As Integer = 500
    Const ENTRY_HEIGHT As Integer = 120
    Private TargetOperation As Integer
    Private Enum Operation
        entry = 1
        update = 2
    End Enum
    Public Sub New(ByVal ds As DataSet, ByVal fm As Form)
        InitializeComponent()
        _ds = ds
        _fm = fm
    End Sub

    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles BtnClose.Click
        Me.Close()
    End Sub

    Private Sub FmCustomerMaster_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Me._fm.Show()
    End Sub
    Private Sub ShowCustomerList(ByVal Condition As String)
        Dim sql As String = "SELECT * FROM T顧客マスタ WHERE フリガナ LIKE '[" &
                            Condition & "]%' ORDER BY フリガナ"
        Dim dt As New DataTable
        If Not db.GetDataFormDB(dt, sql) Then
            Exit Sub
        End If
        With DgvList
            .DataSource = dt
            .Columns(0).HeaderText = "ID"
            .Columns(0).Width = 50
            .Columns(1).Width = 150
            .Columns(2).Width = 150
            .Columns(3).Width = 100
            .Columns(4).Width = 250
            .Columns(5).Width = 100
            .Columns(6).Width = 100
        End With
    End Sub

    Private Sub BtnA_Click(sender As Object, e As EventArgs) Handles BtnA.Click, BtnKA.Click, BtnSA.Click,
                                                                    BtnTA.Click, BtnNA.Click, BtnHA.Click,
                                                                    BtnMA.Click, BtnYA.Click, BtnRA.Click, BtnWA.Click
        ' Khi Option Strict la ON
        ShowCustomerList(DirectCast(sender, Button).Tag.ToString.Trim)
        ' Khi Option Strict la OFF
        'ShowCustomerList(sender.Tag.ToString)
        If DgvList.RowCount = 0 Then
            BtnUpdate.Visible = False
            BtnDelete.Visible = False
        End If

    End Sub

    Private Sub FmCustomerMaster_Load(sender As Object, e As EventArgs) Handles Me.Load
        With Me.DgvList
            .CellBorderStyle = DataGridViewCellBorderStyle.None
            .AllowUserToResizeRows = False
            .AllowUserToAddRows = False
            .ReadOnly = True
        End With
        InvisibleEntryArea()
        Me.BtnUpdate.Visible = False
        Me.BtnDelete.Visible = False
    End Sub

    Private Sub InvisibleEntryArea()
        Me.PanelEntry.Height = 0
        Me.PanelCustomerList.Top = ENTRY_TOP
        Me.PanelCustomerList.Height = LIST_HEIGHT + ENTRY_HEIGHT
    End Sub

    Private Sub BtnEntry_Click(sender As Object, e As EventArgs) Handles BtnEntry.Click
        VisibleEnntryArea()
        Me.TxtCustomerName.Focus()
        TargetOperation = Operation.entry
        Me.BtnEntry.Enabled = False
    End Sub

    Private Sub VisibleEnntryArea()
        Me.PanelEntry.Height = ENTRY_HEIGHT
        Me.PanelCustomerList.Top = ENTRY_TOP + ENTRY_HEIGHT
        Me.PanelCustomerList.Height = LIST_HEIGHT
    End Sub

    Private Sub BtnExe_Click(sender As Object, e As EventArgs) Handles BtnExe.Click
        Select Case TargetOperation
            Case Operation.entry
                EntryData()
            Case Operation.update
                UpdateData()
            Case Else
                Dim msg As String = "新規登録/更新の判断ができません"
                MessageBox.Show(msg, "確認", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Select
    End Sub

    Private Sub EntryData()
        If Me.TxtCustomerName.Text = String.Empty Then
            MessageBox.Show("顧客名を入力して下さい", "確認")
            Me.TxtCustomerName.Focus()
            Exit Sub
        End If
        Dim sql As String = "INSERT INTO T顧客マスタ (顧客名,フリガナ,Post,住所,TEL,FAX) "
        sql &= "VALUES('" & Me.TxtCustomerName.Text.Trim & "','"
        sql &= Me.TxtFurigana.Text.Trim & "','" & Me.TxtPost.Text.Trim & "','" & Me.TxtAddress.Text.Trim & "','"
        sql &= Me.TxtTEL.Text.Trim & "','" & Me.TxtFAX.Text & "')"
        If Not db.UpdateData(sql) Then
            MessageBox.Show("保存されませんでした。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        ClearControlData()
        InvisibleEntryArea()
        Me.BtnEntry.Enabled = True
    End Sub

    Private Sub ClearControlData()
        For Each ctl As Control In Me.PanelEntry.Controls
            Try
                If DirectCast(ctl, TextBox).Tag.ToString = "y" Then
                    ctl.Text = ""
                End If
            Catch ex As Exception

            End Try
        Next
    End Sub

    Private Sub BtnCancel_Click(sender As Object, e As EventArgs) Handles BtnCancel.Click
        ClearControlData()
        InvisibleEntryArea()
        Me.BtnEntry.Enabled = True
        Me.BtnUpdate.Visible = False
        Me.BtnDelete.Visible = False
        Me.DgvList.Enabled = True
    End Sub

    Private Sub DgvList_RowHeaderMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DgvList.RowHeaderMouseClick
        Me.BtnUpdate.Visible = True
        Me.BtnDelete.Visible = True
    End Sub

    Private Sub BtnUpdate_Click(sender As Object, e As EventArgs) Handles BtnUpdate.Click
        Me.BtnExe.Text = "修正"
        VisibleEnntryArea()
        SetDataToControl()
        TargetOperation = Operation.update
        Me.DgvList.Enabled = True
    End Sub

    Private Sub SetDataToControl()
        With Me.DgvList
            Me.TxtCustomerName.Text = (.CurrentRow.Cells("顧客名").Value.ToString.Trim)
            Me.TxtFurigana.Text = (.CurrentRow.Cells("フリガナ").Value.ToString.Trim)
            Me.TxtPost.Text = (.CurrentRow.Cells("Post").Value.ToString.Trim)
            Me.TxtAddress.Text = (.CurrentRow.Cells("住所").Value.ToString.Trim)
            Me.TxtTEL.Text = (.CurrentRow.Cells("TEL").Value.ToString.Trim)
            Me.TxtFAX.Text = (.CurrentRow.Cells("FAX").Value.ToString.Trim)
        End With
    End Sub

    Private Sub UpdateData()
        Dim sql As String = "UPDATE T顧客マスタ SET 顧客名='" & Me.TxtCustomerName.Text.Trim
        sql &= "' , フリガナ='" & Me.TxtFurigana.Text.Trim
        sql &= "' , Post='" & Me.TxtPost.Text.Trim
        sql &= "' , 住所='" & Me.TxtAddress.Text.Trim
        sql &= "' , TEL='" & Me.TxtTEL.Text.Trim
        sql &= "' , FAX='" & Me.TxtFAX.Text.Trim
        sql &= "' WHERE 顧客ID=" & Me.DgvList.CurrentRow.Cells("顧客ID").Value.ToString

        If Not db.UpdateData(sql) Then
            Dim msg As String = "もう一度修正ボタンをクリックしてください。"
            MessageBox.Show(msg, "確認", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If
        UpdateGridViewRowData()
        ClearControlData()
        InvisibleEntryArea()
        Me.BtnUpdate.Visible = False
        Me.BtnDelete.Visible = False
        Me.DgvList.Enabled = True
    End Sub

    Private Sub UpdateGridViewRowData()
        With Me.DgvList.CurrentRow
            .Cells("顧客名").Value = Me.TxtCustomerName.Text.Trim
            .Cells("フリガナ").Value = Me.TxtFurigana.Text.Trim
            .Cells("Post").Value = Me.TxtPost.Text.Trim
            .Cells("住所").Value = Me.TxtAddress.Text.Trim
            .Cells("TEL").Value = Me.TxtTEL.Text.Trim
            .Cells("FAX").Value = Me.TxtFAX.Text.Trim
        End With
    End Sub

    Private Sub BtnDelete_Click(sender As Object, e As EventArgs) Handles BtnDelete.Click
        Dim CustomerName As String = Me.DgvList.CurrentRow.Cells("顧客名").Value
        Dim msg As String = "以下のレコードを削除します。元に戻すことができません！よろしいですか？"
        msg &= vbNewLine & "顧客名: " & CustomerName
        Dim res As DialogResult = MessageBox.Show(msg, "削除の確認", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)
        If res = Windows.Forms.DialogResult.Yes Then
            Dim CustomerID As String = Me.DgvList.CurrentRow.Cells("顧客ID").Value.ToString.Trim
            Dim sql = "DELETE FROM T顧客マスタ WHERE 顧客ID=" & CustomerID
            If db.UpdateData(sql) Then
                Me.DgvList.Rows.RemoveAt(Me.DgvList.CurrentRow.Index)
                Me.BtnUpdate.Visible = False
                Me.BtnDelete.Visible = False
            End If
        End If
    End Sub
End Class