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
            .TxtSlipNo.ReadOnly = True
            .TxtGoodsID.TextAlign = HorizontalAlignment.Right
            .TxtPrice.TextAlign = HorizontalAlignment.Right
            .TxtQuantity.TextAlign = HorizontalAlignment.Right
            .BtnUpdateMeisai.Visible = False
            .BtnDeleteMeisai.Visible = False
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
            If _SlipNo = -1 Then '新規作成の場合
                Dim NewSlipNo As String = ""
                If Not GetSlipNo(NewSlipNo) Then
                    Dim msg As String = "伝票の生成に失敗しました。再度「新規作成」をお願い致します。"
                    MessageBox.Show(msg, "お願い", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Me.Close()
                    Exit Sub
                End If
                .TxtSlipNo.Text = NewSlipNo
                .BtnDeleteMeisai.Visible = False
                TargetOperation = Operation.entry
                .DateTimePicker1.Value = Date.Today
                Dim sql As String = "SELECT * FROM vwSalesMeisai WHERE 明細ID=0"
                If db.GetDataFormDB(dtSalesMeisai, sql) Then
                    Me.DgvMeisai.DataSource = dtSalesMeisai
                End If
            End If
        End With
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

    Private Sub FmSalesInfo_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        _fm.Show()
    End Sub

    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles BtnClose.Click
        Me.Close()
    End Sub

    Private Sub BtnCustomerSearch_Click(sender As Object, e As EventArgs) Handles BtnCustomerSearch.Click
        Dim fm As New Dialog1
        Dialog1.ShowDialog()
        If fm.DialogResult = DialogResult.OK Or DialogResult.Cancel Then
            Me.TxtCustomerID.Text = CustomerID
            TxtCustomerID_Leave(sender, e)
        End If
    End Sub


    Private Sub TxtCustomerID_Leave(sender As Object, e As EventArgs) Handles TxtCustomerID.Leave
        If Me.TxtCustomerID.Text = String.Empty Then
            Exit Sub
        End If
        SetCustomerInfo()
    End Sub

    Private Sub SetCustomerInfo()
        'Throw New NotImplementedException()
        Dim dt As New DataTable()
        Dim sql As String = "SELECT * FROM dbo.T顧客マスタ WHERE 顧客ID=" & CustomerID
        'Me.TxtCustomerID.Text.Trim
        If Not db.GetDataFormDB(dt, sql) Then
            Exit Sub
        End If
        If dt.Rows.Count = 0 Then
            ClearControl_CustomerInfo()
            Exit Sub
        End If
        With Me
            .TxtCustomerName.Text = dt.Rows(0)("顧客名").ToString
            .TxtKana.Text = dt.Rows(0)("フリガナ").ToString
            .TxtPost.Text = "〒" & dt.Rows(0)("Post").ToString
            .TxtAddress.Text = dt.Rows(0)("住所").ToString
            .TxtTEL.Text = "TEL: " & dt.Rows(0)("TEL").ToString
            .TxtFAX.Text = "FAX: " & dt.Rows(0)("FAX").ToString
            BtnAddMeisai.Enabled = True
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
            CustomerID = Me.TxtCustomerID.Text.Trim
            SetCustomerInfo()
        End If
    End Sub

    Private Sub BtnAddMeisai_Click(sender As Object, e As EventArgs) Handles BtnAddMeisai.Click
        VisibleEntryArea()
        Me.CbCategoryList.SelectedValue = 0
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
        AddMeisaiData()
        Me.LbTotal.Text = Format(GetTotal, "#,##0")

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
        Me.BtnUpdateMeisai.Visible = True
        Me.BtnDeleteMeisai.Visible = True
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
            End If
        Else '既存の伝票の場合
            'If TransUpdateSalesInfo() Then
            '    Me.Close() '正常に終了したら閉じる
            'End If
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

    Private Sub TxtCustomerID_MouseUp(sender As Object, e As MouseEventArgs) Handles TxtCustomerID.MouseUp
        If Me.TxtCustomerID.Text = String.Empty Then
            Me.BtnAddMeisai.Enabled = False
        Else
            Me.BtnAddMeisai.Enabled = True
        End If
    End Sub
    'Private Function TransUpdateSalesInfo() As Boolean
    '    'Throw New NotImplementedException()
    'End Function


End Class