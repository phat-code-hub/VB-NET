Public Class fmGoodsMaster
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

    Private Sub FmGoodsMaster_Load(sender As Object, e As EventArgs) Handles Me.Load
        InvisibleEntryArea()
        Me.BtnUpdate.Visible = False
        Me.BtnDelete.Visible = False
        With Me.DgvList
            .CellBorderStyle = DataGridViewCellBorderStyle.None
            .AllowUserToResizeRows = False
            .AllowUserToAddRows = False
            .ReadOnly = True
        End With
        With Me.CbCategoryList
            .DataSource = _ds.Tables("T分類マスタ")
            .ValueMember = "分類ID"
            .DisplayMember = "分類名"
            .SelectedValue = 0
            .DropDownStyle = ComboBoxStyle.DropDownList
        End With
        With Me.CbCategory
            .DataSource = _ds.Tables("T分類マスタ")
            .ValueMember = "分類ID"
            .DisplayMember = "分類名"
            .SelectedValue = 0
            .DropDownStyle = ComboBoxStyle.DropDownList
        End With
        With Me.CbMaker
            .DataSource = _ds.Tables("Tメーカーマスタ")
            .ValueMember = "メーカーID"
            .DisplayMember = "メーカー"
            .SelectedValue = 0
            .DropDownStyle = ComboBoxStyle.DropDownList
        End With
        Me.TxtPrice.TextAlign = HorizontalAlignment.Right
        Me.TxtCost.TextAlign = HorizontalAlignment.Right
    End Sub

    Private Sub InvisibleEntryArea()
        Me.PanelEntry.Height = 0
        Me.PanelCustomerList.Top = ENTRY_TOP
        Me.PanelCustomerList.Height = LIST_HEIGHT + ENTRY_HEIGHT
    End Sub

    Private Sub VisibleEntryArea()
        Me.PanelEntry.Height = ENTRY_HEIGHT
        Me.PanelCustomerList.Top = ENTRY_TOP + ENTRY_HEIGHT
        Me.PanelCustomerList.Height = LIST_HEIGHT
    End Sub


    Private Sub CbCategoryList_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles CbCategoryList.SelectionChangeCommitted
        ShowList()
    End Sub

    Private Sub ShowList()
        'Throw New NotImplementedException()
        Dim id As Integer = CInt(Me.CbCategoryList.SelectedValue)
        Dim sql As String = "SELECT * FROM vwGoodsMaster WHERE 分類ID = " & id
        Dim dt As New DataTable
        If (Not db.GetDataFormDB(dt, sql)) Then
            Exit Sub
        End If
        With Me.DgvList
            .DataSource = dt
            .Columns("商品ID").HeaderText = "ID"
            .Columns("分類ID").Visible = False
            .Columns("メーカーID").Visible = False
            .Columns("商品ID").Width = 50
            .Columns("商品名").Width = 150
            .Columns("分類名").Width = 100
            .Columns("メーカー").Width = 100
            .Columns("単価").Width = 100
            .Columns("単位").Width = 100
            .Columns("仕入原価").Width = 100
            .Columns("備考").Width = 180
            .Columns("商品ID").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            .Columns("単価").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            .Columns("単価").HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight
            .Columns("仕入原価").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            .Columns("仕入原価").HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight
            .Columns("単位").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns("単位").HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight
            .Columns("単価").DefaultCellStyle.Format = "#,##0"
            .Columns("仕入原価").DefaultCellStyle.Format = "#,##0"
        End With
    End Sub

    Private Sub BtnEntry_Click(sender As Object, e As EventArgs) Handles BtnEntry.Click
        VisibleEntryArea()
        Me.TxtGoodsName.Focus()
        TargetOperation = Operation.entry
        Me.BtnEntry.Enabled = False
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
        If (Not CheckEntry()) Then
            Exit Sub
        End If

        Dim sql As String = "INSERT INTO T商品マスタ (商品名,メーカーID,単価,単位,分類ID,仕入原価,備考) "
        sql &= "VALUES('" & Me.TxtGoodsName.Text.Trim & "','"
        sql &= Me.CbMaker.SelectedValue.ToString.Trim & "','" & Me.TxtPrice.Text.Trim & "','"
        sql &= Me.TxtUnit.Text.Trim & "','" & Me.CbCategory.SelectedValue.ToString.Trim & "','"
        sql &= Me.TxtCost.Text.Trim & "','" & Me.TxtRemarks.Text & "')"
        If db.UpdateData(sql) Then

            ClearControlData()
            InvisibleEntryArea()
            Me.BtnEntry.Enabled = True
            ShowList()
        Else
            MessageBox.Show("保存されませんでした。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
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
    Function CheckEntry() As Boolean
        If (Not IsNumeric(Me.TxtPrice.Text)) Then
            MessageBox.Show("単価に数値を入力してください", "入力確認", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.TxtPrice.Focus()
            Return False
        End If
        If (Not IsNumeric(Me.TxtCost.Text)) Then
            MessageBox.Show("仕入原価に数値を入力してください", "入力確認", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.TxtCost.Focus()
            Return False
        End If
        If (CInt(Me.CbCategory.SelectedValue) = 0) Then
            MessageBox.Show("分類を選択してください", "入力確認", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End If
        If (CInt(Me.CbMaker.SelectedValue) = 0) Then
            MessageBox.Show("メーカーを選択してください", "入力確認", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End If
        Return True
    End Function
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
        VisibleEntryArea()
        SetDataToControl()
        TargetOperation = Operation.update
        Me.DgvList.Enabled = False
    End Sub
    Private Sub SetDataToControl()
        With Me.DgvList
            Me.TxtGoodsName.Text = .CurrentRow.Cells("商品名").Value.ToString.Trim
            Me.TxtPrice.Text = .CurrentRow.Cells("単価").Value.ToString.Trim
            Me.TxtCost.Text = .CurrentRow.Cells("仕入原価").Value.ToString.Trim
            Me.TxtUnit.Text = .CurrentRow.Cells("単位").Value.ToString.Trim
            Me.TxtRemarks.Text = .CurrentRow.Cells("備考").Value.ToString.Trim
            Me.CbCategory.SelectedValue = .CurrentRow.Cells("分類ID").Value.ToString.Trim
            Me.CbMaker.SelectedValue = .CurrentRow.Cells("メーカーID").Value.ToString.Trim
        End With
    End Sub
    Private Sub UpdateData()
        Dim sql As String = "UPDATE T商品マスタ SET 商品名='" & Me.TxtGoodsName.Text.Trim
        sql &= "' , 分類ID='" & Me.CbCategory.SelectedValue.ToString.Trim
        sql &= "' , メーカーID='" & Me.CbMaker.SelectedValue.ToString.Trim
        sql &= "' , 単価='" & Me.TxtPrice.Text.Trim
        sql &= "' , 仕入原価='" & Me.TxtCost.Text.Trim
        sql &= "' , 単位='" & Me.TxtUnit.Text.Trim
        sql &= "' , 備考='" & Me.TxtRemarks.Text.Trim
        sql &= "' WHERE 商品ID=" & Me.DgvList.CurrentRow.Cells("商品ID").Value.ToString

        If db.UpdateData(sql) Then
            ClearControlData()
            InvisibleEntryArea()
            Me.BtnUpdate.Visible = False
            Me.BtnDelete.Visible = False
            Me.DgvList.Enabled = True
            ShowList()
        Else
            Dim msg As String = "もう一度修正ボタンをクリックしてください。"
            MessageBox.Show(msg, "確認", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If
    End Sub
    Private Sub BtnDelete_Click(sender As Object, e As EventArgs) Handles BtnDelete.Click
        Dim GoodsName As String = Me.DgvList.CurrentRow.Cells("商品名").Value.ToString
        Dim msg As String = "以下のレコードを削除します。元に戻すことができません！よろしいですか？"
        msg &= vbNewLine & "商品名: " & GoodsName
        Dim res As DialogResult = MessageBox.Show(msg, "削除の確認", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)
        If res = Windows.Forms.DialogResult.Yes Then
            Dim GoodsID As String = Me.DgvList.CurrentRow.Cells("商品ID").Value.ToString.Trim
            Dim sql = "DELETE FROM T商品マスタ WHERE 商品ID=" & GoodsID
            If db.UpdateData(sql) Then
                Me.DgvList.Rows.RemoveAt(Me.DgvList.CurrentRow.Index)
                Me.BtnUpdate.Visible = False
                Me.BtnDelete.Visible = False
            End If
        End If
    End Sub

End Class