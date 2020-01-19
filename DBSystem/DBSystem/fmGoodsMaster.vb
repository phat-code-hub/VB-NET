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

    Private Sub fmCustomerMaster_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Me._fm.Show()
    End Sub

    Private Sub fmGoodsMaster_Load(sender As Object, e As EventArgs) Handles Me.Load
        InvisibleEntryArea()
        Me.btnUpdate.Visible = False
        Me.btnDelete.Visible = False
        With Me.dgvList
            .CellBorderStyle = DataGridViewCellBorderStyle.None
            .AllowUserToResizeRows = False
            .AllowUserToAddRows = False
            .ReadOnly = True
        End With
        With Me.cbCategoryList
            .DataSource = _ds.Tables("T分類マスタ")
            .ValueMember = "分類ID"
            .DisplayMember = "分類名"
            .SelectedValue = 0
            .DropDownStyle = ComboBoxStyle.DropDownList
        End With
        With Me.cbCategory
            .DataSource = _ds.Tables("T分類マスタ")
            .ValueMember = "分類ID"
            .DisplayMember = "分類名"
            .SelectedValue = 0
            .DropDownStyle = ComboBoxStyle.DropDownList
        End With
        With Me.cbMaker
            .DataSource = _ds.Tables("Tメーカーマスタ")
            .ValueMember = "メーカーID"
            .DisplayMember = "メーカー"
            .SelectedValue = 0
            .DropDownStyle = ComboBoxStyle.DropDownList
        End With
        Me.txtPrice.TextAlign = HorizontalAlignment.Right
        Me.txtCost.TextAlign = HorizontalAlignment.Right
    End Sub

    Private Sub InvisibleEntryArea()
        Me.panelEntry.Height = 0
        Me.panelCustomerList.Top = ENTRY_TOP
        Me.panelCustomerList.Height = LIST_HEIGHT + ENTRY_HEIGHT
    End Sub

    Private Sub VisibleEntryArea()
        Me.panelEntry.Height = ENTRY_HEIGHT
        Me.panelCustomerList.Top = ENTRY_TOP + ENTRY_HEIGHT
        Me.panelCustomerList.Height = LIST_HEIGHT
    End Sub


    Private Sub cbCategoryList_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cbCategoryList.SelectionChangeCommitted
        ShowList()
    End Sub

    Private Sub ShowList()
        'Throw New NotImplementedException()
        Dim id As Integer = CInt(Me.cbCategoryList.SelectedValue)
        Dim sql As String = "SELECT * FROM vwGoodsMaster WHERE 分類ID = " & id
        Dim dt As New DataTable
        If (Not db.GetDataFormDB(dt, sql)) Then
            Exit Sub
        End If
        With Me.dgvList
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

    Private Sub btnEntry_Click(sender As Object, e As EventArgs) Handles btnEntry.Click
        VisibleEntryArea()
        Me.txtGoodsName.Focus()
        TargetOperation = Operation.entry
        Me.btnEntry.Enabled = False
    End Sub

    Private Sub btnExe_Click(sender As Object, e As EventArgs) Handles btnExe.Click
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
        sql &= "VALUES('" & Me.txtGoodsName.Text.Trim & "','"
        sql &= Me.cbMaker.SelectedValue.ToString.Trim & "','" & Me.txtPrice.Text.Trim & "','"
        sql &= Me.txtUnit.Text.Trim & "','" & Me.cbCategory.SelectedValue.ToString.Trim & "','"
        sql &= Me.txtCost.Text.Trim & "','" & Me.txtRemarks.Text & "')"
        If db.UpdateData(sql) Then

            ClearControlData()
            InvisibleEntryArea()
            Me.btnEntry.Enabled = True
            ShowList()
        Else
            MessageBox.Show("保存されませんでした。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
    End Sub

    Private Sub ClearControlData()
        For Each ctl As Control In Me.panelEntry.Controls
            Try
                If DirectCast(ctl, TextBox).Tag.ToString = "y" Then
                    ctl.Text = ""
                End If
            Catch ex As Exception

            End Try
        Next
    End Sub
    Function CheckEntry() As Boolean
        If (Not IsNumeric(Me.txtPrice.Text)) Then
            MessageBox.Show("単価に数値を入力してください", "入力確認", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.txtPrice.Focus()
            Return False
        End If
        If (Not IsNumeric(Me.txtCost.Text)) Then
            MessageBox.Show("仕入原価に数値を入力してください", "入力確認", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.txtCost.Focus()
            Return False
        End If
        If (CInt(Me.cbCategory.SelectedValue) = 0) Then
            MessageBox.Show("分類を選択してください", "入力確認", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End If
        If (CInt(Me.cbMaker.SelectedValue) = 0) Then
            MessageBox.Show("メーカーを選択してください", "入力確認", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End If
        Return True
    End Function
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        ClearControlData()
        InvisibleEntryArea()
        Me.btnEntry.Enabled = True
        Me.btnUpdate.Visible = False
        Me.btnDelete.Visible = False
        Me.dgvList.Enabled = True
    End Sub
    Private Sub dgvList_RowHeaderMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgvList.RowHeaderMouseClick
        Me.btnUpdate.Visible = True
        Me.btnDelete.Visible = True
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Me.btnExe.Text = "修正"
        VisibleEntryArea()
        SetDataToControl()
        TargetOperation = Operation.update
        Me.dgvList.Enabled = False
    End Sub
    Private Sub SetDataToControl()
        With Me.dgvList
            Me.txtGoodsName.Text = .CurrentRow.Cells("商品名").Value.ToString.Trim
            Me.txtPrice.Text = .CurrentRow.Cells("単価").Value.ToString.Trim
            Me.txtCost.Text = .CurrentRow.Cells("仕入原価").Value.ToString.Trim
            Me.txtUnit.Text = .CurrentRow.Cells("単位").Value.ToString.Trim
            Me.txtRemarks.Text = .CurrentRow.Cells("備考").Value.ToString.Trim
            Me.cbCategory.SelectedValue = .CurrentRow.Cells("分類ID").Value.ToString.Trim
            Me.cbMaker.SelectedValue = .CurrentRow.Cells("メーカーID").Value.ToString.Trim
        End With
    End Sub
    Private Sub UpdateData()
        Dim sql As String = "UPDATE T商品マスタ SET 商品名='" & Me.txtGoodsName.Text.Trim
        sql &= "' , 分類ID='" & Me.cbCategory.SelectedValue.ToString.Trim
        sql &= "' , メーカーID='" & Me.cbMaker.SelectedValue.ToString.Trim
        sql &= "' , 単価='" & Me.txtPrice.Text.Trim
        sql &= "' , 仕入原価='" & Me.txtCost.Text.Trim
        sql &= "' , 単位='" & Me.txtUnit.Text.Trim
        sql &= "' , 備考='" & Me.txtRemarks.Text.Trim
        sql &= "' WHERE 商品ID=" & Me.dgvList.CurrentRow.Cells("商品ID").Value.ToString

        If db.UpdateData(sql) Then
            ClearControlData()
            InvisibleEntryArea()
            Me.btnUpdate.Visible = False
            Me.btnDelete.Visible = False
            Me.dgvList.Enabled = True
            ShowList()
        Else
            Dim msg As String = "もう一度修正ボタンをクリックしてください。"
            MessageBox.Show(msg, "確認", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If
    End Sub
    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Dim GoodsName As String = Me.dgvList.CurrentRow.Cells("商品名").Value.ToString
        Dim msg As String = "以下のレコードを削除します。元に戻すことができません！よろしいですか？"
        msg &= vbNewLine & "商品名: " & GoodsName
        Dim res As DialogResult = MessageBox.Show(msg, "削除の確認", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)
        If res = Windows.Forms.DialogResult.Yes Then
            Dim GoodsID As String = Me.dgvList.CurrentRow.Cells("商品ID").Value.ToString.Trim
            Dim sql = "DELETE FROM T商品マスタ WHERE 商品ID=" & GoodsID
            If db.UpdateData(sql) Then
                Me.dgvList.Rows.RemoveAt(Me.dgvList.CurrentRow.Index)
                Me.btnUpdate.Visible = False
                Me.btnDelete.Visible = False
            End If
        End If
    End Sub

End Class