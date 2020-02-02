Imports System.Data.SqlClient

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
    Private MeisaiOperation As Integer

    Private Enum Operation
        entry = 1
        update = 2
    End Enum

    Public Sub New(ByVal ds As DataSet, ByVal fm As Form)
        InitializeComponent()
        _ds = ds
        _fm = fm
        CustomerID = 0
    End Sub
    Public Sub New(ByVal ds As DataSet, ByVal fm As Form, ByVal slipNo As Integer)
        InitializeComponent()
        _ds = ds
        _fm = fm
        _SlipNo = slipNo
        CustomerID = 0
    End Sub

    Private Sub FmSalesInfo_Load(sender As Object, e As EventArgs) Handles Me.Load
        With Me
            '.TxtSlipNo.ReadOnly = True
            .TxtGoodsID.TextAlign = HorizontalAlignment.Right
            .TxtPrice.TextAlign = HorizontalAlignment.Right
            .TxtQuantity.TextAlign = HorizontalAlignment.Right
            .BtnUpdateMeisai.Visible = False
            .BtnDeleteMeisai.Visible = False
            CustomerID = 0
            InvisibleEntryArea()
            With Me.CbCategoryList
                Dim dtCategory As New DataTable
                .DataSource = _ds.Tables("T分類マスタ")
                .ValueMember = "分類ID"
                .DisplayMember = "分類名"
                .DropDownStyle = ComboBoxStyle.DropDownList
            End With
            With Me.DgvGoods
                .CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal
                .AllowUserToResizeRows = False
                .AllowUserToAddRows = False
            End With
            DateTimePicker1.Value = Date.Today

            If _SlipNo = -1 Then '新規作成の場合
                Dim NewSlipNo As String = ""
                If Not GetSlipNo(NewSlipNo) Then
                    Dim msg As String = "伝票の生成に失敗しました。再度「新規作成」をお願い致します。"
                    MessageBox.Show(msg, "お願い", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Me.Close()
                    Exit Sub
                End If
                .TxtSlipNo.Text = NewSlipNo
                _SlipNo = NewSlipNo
                .BtnDeleteMeisai.Visible = False
                TargetOperation = Operation.entry
                Dim sql As String = "SELECT * FROM vwSalesMeisai WHERE 明細ID=0"
                If db.GetDataFormDB(dtSalesMeisai, sql) Then
                    Me.DgvMeisai.DataSource = dtSalesMeisai
                End If
            End If
            ShowSlipInfo(_SlipNo)
            'If _SlipNo > 0 Then '既存の伝票を開く場合
            '    Me.TxtSlipNo.Text = _SlipNo.ToString
            '    Dim dt As New DataTable()
            '    Dim sql As String = "SELECT * FROM T売上基本情報 WHERE 伝票番号=" & _SlipNo
            '    If Not db.GetDataFormDB(dt, sql) Then
            '        Dim msg As String = "エラー発生しました。"
            '        MessageBox.Show(msg, "", MessageBoxButtons.OK, MessageBoxIcon.Error)
            '        Me.Close()
            '    Else ' connected database _slipNo
            '        If dt.Rows.Count > 0 Then ' 
            '            Me.DateTimePicker1.Value = CDate(dt.Rows(0)("日付"))
            '            Me.TxtCustomerID.Text = dt.Rows(0)("顧客ID").ToString
            '            Me.TxtRemarks.Text = dt.Rows(0)("備考").ToString
            '            sql = "SELECT * FROM vwSalesMeisai WHERE 伝票番号=" & _SlipNo
            '            If Not db.GetDataFormDB(dtSalesMeisai, sql) Then
            '                Dim msg As String = "エラー発生しました。"
            '                MessageBox.Show(msg, "", MessageBoxButtons.OK, MessageBoxIcon.Error)
            '                Me.Close()
            '            End If
            '            TargetOperation = Operation.update
            '        Else
            '            _SlipNo = -1
            '            TargetOperation = Operation.entry
            '        End If
            '        With Me.DgvMeisai
            '            .DataSource = dtSalesMeisai
            '            .Columns("明細ID").Visible = False
            '            .Columns("伝票番号").Visible = False
            '            .Columns("単価").HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight
            '            .Columns("数量").HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight
            '            .Columns("単位").HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight
            '            .Columns("金額").HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight
            '            .Columns("単価").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            '            .Columns("数量").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            '            .Columns("単位").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            '            .Columns("金額").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            '            .Columns("単価").DefaultCellStyle.Format = "#,##0"
            '            .Columns("金額").DefaultCellStyle.Format = "#,##0"
            '        End With
            '        Me.LbTotal.Text = Format(GetTotal(), "#,##0")
            '    End If
            'End If
        End With
    End Sub
    Private Sub FmSalesInfo_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        If CustomerID > 0 Then
            Me.TxtCustomerID.Text = CustomerID
        End If
    End Sub
    Private Sub FmSalesInfo_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        _fm.Show()
    End Sub
    Private Function GetSlipNo(ByRef n As String) As Boolean
        'Throw New NotImplementedException()
        Using cn As New SqlConnection(My.Settings.ConnectionString)
            Using cmd As New SqlCommand("SetSlipNo", cn)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.Add("@SlipNo", SqlDbType.Int).Direction = ParameterDirection.Output
                cmd.Parameters.Add("ReturnValue", SqlDbType.Int).Direction = ParameterDirection.ReturnValue
                Try
                    cn.Open()
                    cmd.ExecuteNonQuery()
                    n = cmd.Parameters("@SlipNo").Value.ToString
                    Return CBool(cmd.Parameters("ReturnValue").Value)
                Catch ex As Exception
                    MessageBox.Show(ex.ToString)
                    Return False
                End Try

            End Using
        End Using

    End Function
    Private Sub ShowSlipInfo(ByVal slipNum As Integer)
        If slipNum > 0 Then
            Me.TxtSlipNo.Text = slipNum.ToString
            Dim dt As New DataTable()
            Dim sql As String = "SELECT * FROM T売上基本情報 WHERE 伝票番号=" & _SlipNo
            If Not db.GetDataFormDB(dt, sql) Then
                Dim msg As String = "エラー発生しました。"
                MessageBox.Show(msg, "", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Me.Close()
            Else ' connected database _slipNo
                If dt.Rows.Count > 0 Then ' 
                    Me.DateTimePicker1.Value = CDate(dt.Rows(0)("日付"))
                    Me.TxtCustomerID.Text = dt.Rows(0)("顧客ID").ToString
                    Me.TxtRemarks.Text = dt.Rows(0)("備考").ToString
                    sql = "SELECT * FROM vwSalesMeisai WHERE 伝票番号=" & _SlipNo
                    If Not db.GetDataFormDB(dtSalesMeisai, sql) Then
                        Dim msg As String = "エラー発生しました。"
                        MessageBox.Show(msg, "", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Me.Close()
                    End If
                    TargetOperation = Operation.update
                Else
                    _SlipNo = -1
                    TargetOperation = Operation.entry
                End If
                With Me.DgvMeisai
                    .DataSource = dtSalesMeisai
                    .Columns("明細ID").Visible = False
                    .Columns("伝票番号").Visible = False
                    .Columns("単価").HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight
                    .Columns("数量").HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight
                    .Columns("単位").HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight
                    .Columns("金額").HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight
                    .Columns("単価").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                    .Columns("数量").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                    .Columns("単位").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                    .Columns("金額").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                    .Columns("単価").DefaultCellStyle.Format = "#,##0"
                    .Columns("金額").DefaultCellStyle.Format = "#,##0"
                End With
                Me.LbTotal.Text = Format(GetTotal(), "#,##0")
            End If
        Else
            '新規作成の場合
            Dim NewSlipNo As String = ""
            If Not GetSlipNo(NewSlipNo) Then
                Dim msg As String = "伝票の生成に失敗しました。再度「新規作成」をお願い致します。"
                MessageBox.Show(msg, "お願い", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.Close()
                Exit Sub
            End If
            Me.TxtSlipNo.Text = NewSlipNo
            _SlipNo = NewSlipNo
            Me.BtnDeleteMeisai.Visible = False
            TargetOperation = Operation.entry
            Dim sql As String = "SELECT * FROM vwSalesMeisai WHERE 明細ID=0"
            If db.GetDataFormDB(dtSalesMeisai, sql) Then
                Me.DgvMeisai.DataSource = dtSalesMeisai
            End If
        End If
    End Sub
    Private Sub InvisibleEntryArea()
        'Throw New NotImplementedException()
        With Me
            .PanelMain.Height = ENTRY_HEIGHT
            .PanelEntry.Height = 0
            .PanelSub.Top = MAINTOP
            '.Height = .panelSub.Top + .panelSub.Height + 10

        End With
    End Sub
    Private Sub VisibleEntryArea()
        'Throw New NotImplementedException()
        Me.PanelMain.Height = 0
        Me.PanelEntry.Height = ENTRY_HEIGHT
        Me.PanelEntry.Top = MAINTOP
    End Sub



    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles BtnClose.Click
        Me.Close()
    End Sub

    Private Sub BtnCustomerSearch_Click(sender As Object, e As EventArgs) Handles BtnCustomerSearch.Click
        Dim fm As New Dialog1
        Dialog1.ShowDialog()
    End Sub

    Private Sub SetCustomerInfo(ByVal CustName)
        'Throw New NotImplementedException()
        Dim dt As New DataTable()
        Dim sql As String = "SELECT * FROM dbo.T顧客マスタ WHERE 顧客ID=" & CustName
        'Me.TxtCustomerID.Text.Trim
        If Not db.GetDataFormDB(dt, sql) Then
            Exit Sub
        End If
        If dt.Rows.Count = 0 Then
            ClearControl_CustomerInfo()
            Exit Sub
        Else
            If dt.Rows(0)("顧客ID").ToString = String.Empty Then
                ClearControl_CustomerInfo()
                Exit Sub
            End If
        End If
        With Me
            ClearControl_CustomerInfo()
            .TxtCustomerName.Text = dt.Rows(0)("顧客名").ToString
            .TxtKana.Text = dt.Rows(0)("フリガナ").ToString
            .TxtPost.Text = "〒" & dt.Rows(0)("Post").ToString
            .TxtAddress.Text = dt.Rows(0)("住所").ToString
            .TxtTEL.Text = "TEL: " & dt.Rows(0)("TEL").ToString
            .TxtFAX.Text = "FAX: " & dt.Rows(0)("FAX").ToString
            BtnAddMeisai.Enabled = True
            CustomerID = CustName
        End With
    End Sub

    Private Sub ClearControl_CustomerInfo()
        'Throw New NotImplementedException()
        With Me
            .TxtCustomerName.Text = ""
            .TxtKana.Text = ""
            .TxtPost.Text = ""
            .TxtAddress.Text = ""
            .TxtTEL.Text = ""
            .TxtFAX.Text = ""
            .BtnAddMeisai.Enabled = False
        End With
    End Sub

    Private Sub TxtCustomerID_TextChanged(sender As Object, e As EventArgs) Handles TxtCustomerID.TextChanged
        If Me.TxtCustomerID.Text = String.Empty Then
            ClearControl_CustomerInfo()
        Else
            SetCustomerInfo(Me.TxtCustomerID.Text.Trim)
        End If
    End Sub

    Private Sub BtnAddMeisai_Click(sender As Object, e As EventArgs) Handles BtnAddMeisai.Click
        VisibleEntryArea()
        Me.CbCategoryList.SelectedValue = 0
        MeisaiOperation = Operation.entry
        Me.CbCategoryList.Enabled = True
    End Sub


    Private Sub CbCategoryList_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles CbCategoryList.SelectionChangeCommitted
        ShowList()
    End Sub

    Private Sub ShowList()
        'Throw New NotImplementedException()
        Dim id As String = Me.CbCategoryList.SelectedValue.ToString
        Dim sql As String = "SELECT 商品ID,商品名,メーカー,単価,単位 FROM vwGoodsMaster WHERE 分類ID=" & id
        Dim dt As New DataTable
        If db.GetDataFormDB(dt, sql) Then
            With Me.DgvGoods
                .DataSource = dt
                .Columns("商品ID").HeaderText = "ID"
                .Columns("単位").Visible = False
                .Columns("商品ID").Width = 50
                .Columns("商品名").Width = 150
                .Columns("メーカー").Width = 100
                .Columns("単価").Width = 60
                .Columns("単価").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                .Columns("単価").DefaultCellStyle.Format = "#.##0"
            End With
        End If
    End Sub


    Private Sub DgvGoods_RowHeaderMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DgvGoods.RowHeaderMouseClick
        With Me.DgvGoods.CurrentRow
            Me.TxtGoodsID.Text = .Cells("商品ID").Value.ToString
            Me.TxtPrice.Text = Format(.Cells("単価").Value, "#,##0")
            Me.LbGoodsName.Text = .Cells("商品名").Value.ToString
        End With
        Me.TxtQuantity.Focus()
    End Sub

    Private Sub BtnCancel_Click(sender As Object, e As EventArgs) Handles BtnCancel.Click
        InvisibleEntryArea()
    End Sub

    Private Sub BtnExe_Click(sender As Object, e As EventArgs) Handles BtnExe.Click
        If Not IsNumeric(Me.TxtPrice.Text) Then
            Dim msg As String = "単価を正しく入力してください"
            MessageBox.Show(msg, "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        If Not IsNumeric(Me.TxtQuantity.Text) Then
            Dim msg As String = "数量を正しく入力してください"
            MessageBox.Show(msg, "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        Select Case MeisaiOperation
            Case Operation.entry
                AddMeisaiData()
            Case Operation.update
                UpdateMeisaiData()
        End Select

        Me.LbTotal.Text = Format(GetTotal, "#,##0")

    End Sub

    Private Sub UpdateMeisaiData()
        'Throw New NotImplementedException()
        Dim id As String = Me.DgvMeisai.CurrentRow.Cells("明細ID").Value.ToString
        Dim dr As DataRow() = dtSalesMeisai.Select("明細ID=" & id)
        dr(0)("単価") = Me.TxtPrice.Text
        dr(0)("数量") = Me.TxtQuantity.Text
        dr(0)("金額") = CInt(Me.TxtPrice.Text) * CInt(Me.TxtQuantity.Text)
        'Clear Controls
        With Me
            .TxtGoodsID.Text = ""
            .LbGoodsName.Text = ""
            .TxtPrice.Text = ""
            .TxtQuantity.Text = ""
            .DgvMeisai.Enabled = True
            .BtnUpdateMeisai.Visible = False
            .BtnDeleteMeisai.Visible = False
            .BtnExe.Text = "登録"
            InvisibleEntryArea()
        End With

    End Sub

    Private Sub AddMeisaiData()
        ' Throw New NotImplementedException()
        'Add new Meisai record to dgvMeisai
        Dim dr As DataRow = dtSalesMeisai.NewRow
        dr("明細ID") = Me.DgvMeisai.Rows.Count + 1
        dr("伝票番号") = Me.TxtSlipNo.Text
        dr("商品ID") = Me.TxtGoodsID.Text
        dr("商品名") = Me.LbGoodsName.Text
        dr("分類名") = Me.CbCategoryList.Text
        dr("メーカー") = Me.DgvGoods.CurrentRow.Cells("メーカー").Value
        dr("単価") = Me.TxtPrice.Text
        dr("数量") = Me.TxtQuantity.Text
        dr("単位") = Me.DgvGoods.CurrentRow.Cells("単位").Value
        dr("金額") = CInt(Me.TxtPrice.Text) * CInt(Me.TxtQuantity.Text)
        Me.dtSalesMeisai.Rows.Add(dr)
        Me.TxtGoodsID.Text = ""
        Me.TxtPrice.Text = ""
        Me.TxtQuantity.Text = ""
        Me.LbGoodsName.Text = ""
    End Sub

    Private Function GetTotal() As Integer
        'Throw New NotImplementedException()
        Dim total As Integer = 0
        For Each r As DataRow In dtSalesMeisai.Rows
            Try
                total += CInt(r("金額").ToString)
            Catch ex As Exception
            End Try
        Next r
        Return total
    End Function

    Private Sub DgvMeisai_RowHeaderMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DgvMeisai.RowHeaderMouseClick
        Me.BtnUpdateMeisai.Visible = False
        Me.BtnDeleteMeisai.Visible = False
        If Me.DgvMeisai.Rows.Count > 0 Then
            If Me.DgvMeisai.CurrentRow.Cells("明細ID").Value.ToString <> "" Then
                Me.BtnUpdateMeisai.Visible = True
                Me.BtnDeleteMeisai.Visible = True
            End If
        End If
    End Sub

    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click
        If _SlipNo = -1 Then '新規登録の場合
            If Me.DgvMeisai.RowCount = 0 Then
                Dim msg As String = "明細行を追加してください"
                MessageBox.Show(msg, "確認", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
            If TransEntrySalesInfo() Then
                Me.Close() '正常に終了したら閉じる
            Else
                MsgBox("Cannot Transacted")
            End If
        Else '既存の伝票の場合
            If TransUpdateSalesInfo() Then
                Me.Close() '正常に終了したら閉じる
            Else
                MsgBox("Cannot Update")
            End If
        End If
    End Sub
    Private Function TransEntrySalesInfo() As Boolean
        'Throw New NotImplementedException()
        'トランザクション処理
        Using cn As New SqlConnection(My.Settings.ConnectionString)
            cn.Open()
            Dim trans As SqlTransaction = cn.BeginTransaction()
            Dim sql As String = "INSERT INTO T売上基本情報　VALUES(" &
                                        Me.TxtSlipNo.Text & ",'" & Me.DateTimePicker1.Value & "'," &
                                        Me.TxtCustomerID.Text & ",'" & Me.TxtRemarks.Text & "')"
            Using cmd As New SqlCommand(sql, cn, trans)
                Try
                    cmd.ExecuteNonQuery() ' T売上基本情報へ追加
                    cmd.CommandText = "SELECT * FROM T売上明細 WHERE 明細ID=0"
                    Dim da As New SqlDataAdapter(cmd)
                    Dim cb As New SqlCommandBuilder(da)
                    da.Update(dtSalesMeisai) 'T売上明細に追加
                    trans.Commit()
                    Return True
                Catch ex As Exception
                    trans.Rollback()
                    Return False
                End Try
            End Using
        End Using
    End Function
    Private Function TransUpdateSalesInfo() As Boolean
        'Throw New NotImplementedException()
        'トランザクション処理
        Using cn As New SqlConnection(My.Settings.ConnectionString)
            cn.Open()
            Dim trans As SqlTransaction = cn.BeginTransaction()
            Dim sql As String = "UPDATE T売上基本情報 SET 日付='" & Me.DateTimePicker1.Value &
                            "', 顧客ID=" & Me.TxtCustomerID.Text &
                            ", 備考='" & Me.TxtRemarks.Text &
                            "' WHERE 伝票番号=" & _SlipNo

            Using cmd As New SqlCommand(sql, cn, trans)
                Try
                    cmd.ExecuteNonQuery() ' T売上基本情報の更新
                    cmd.CommandText = "SELECT * FROM T売上明細 WHERE 明細ID=0"
                    Dim da As New SqlDataAdapter(cmd)
                    Dim cb As New SqlCommandBuilder(da)
                    da.Update(dtSalesMeisai) 'T売上明細に新規追加
                    trans.Commit()
                    Return True
                Catch ex As Exception
                    trans.Rollback()
                    Return False
                End Try
            End Using
        End Using
    End Function

    Private Sub BtnUpdateMeisai_Click(sender As Object, e As EventArgs) Handles BtnUpdateMeisai.Click
        MeisaiOperation = Operation.update
        Me.BtnExe.Text = "修正"
        VisibleEntryArea()
        SetDataToControl()
        Me.DgvMeisai.Enabled = False
        Me.CbCategoryList.Enabled = False
    End Sub

    Private Sub SetDataToControl()
        'Throw New NotImplementedException()
        With Me.DgvMeisai.CurrentRow
            Me.TxtGoodsID.Text = .Cells("商品ID").Value.ToString
            Me.LbGoodsName.Text = .Cells("商品名").Value.ToString
            Me.TxtPrice.Text = Format(.Cells("単価").Value, "0") '小数点以下非表示
            Me.TxtQuantity.Text = .Cells("数量").Value.ToString
        End With
    End Sub

    Private Sub BtnDeleteMeisai_Click(sender As Object, e As EventArgs) Handles BtnDeleteMeisai.Click
        Dim GoodsName As String = Me.DgvMeisai.CurrentRow.Cells("商品名").Value.ToString
        Dim msg As String = "以下のレコードを削除します。元に戻すことはできません。よろしいですか？"
        msg &= vbNewLine & "商品名: " & GoodsName
        Dim res As DialogResult = MessageBox.Show(msg, "削除の確認", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)
        If res = DialogResult.Yes Then
            Me.DgvMeisai.Rows.RemoveAt(Me.DgvMeisai.CurrentRow.Index)
        End If
    End Sub



    Private Sub BtnDeleteSlip_Click(sender As Object, e As EventArgs) Handles BtnDeleteSlip.Click
        Dim msg As String = "この売上伝票を削除します。元に戻すことはできません。よろしいですか"
        Dim res As DialogResult = MessageBox.Show(msg, "注意", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)
        If res = DialogResult.No Then
            Exit Sub
        End If
        Dim sql As String = "DELETE FROM T売上基本情報　WHERE 伝票番号 =" & Me.TxtSlipNo.Text.Trim
        If db.UpdateData(sql) Then
            Me.Close()
        Else
            MsgBox("Cannot delete!")

        End If
    End Sub

    Private Sub TxtSlipNo_TextChanged(sender As Object, e As EventArgs) Handles TxtSlipNo.TextChanged

    End Sub

    Private Sub BtnSlipNew_Click(sender As Object, e As EventArgs) Handles BtnSlipNew.Click
        Dim NewSlipNo As String = ""
        If Not GetSlipNo(NewSlipNo) Then
            Dim msg As String = "伝票の生成に失敗しました。再度「新規作成」をお願い致します。"
            MessageBox.Show(msg, "お願い", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Close()
            Exit Sub
        Else
            Me.TxtSlipNo.Text = NewSlipNo - 1
            _SlipNo = NewSlipNo - 1
            Me.BtnDeleteMeisai.Visible = False
            TargetOperation = Operation.entry
        End If
    End Sub
End Class