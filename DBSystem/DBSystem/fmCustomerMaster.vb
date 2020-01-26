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
        With dgvList
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

    Private Sub BtnA_Click(sender As Object, e As EventArgs) Handles btnA.Click, btnKA.Click, btnSA.Click,
                                                                    btnTA.Click, btnNA.Click, btnHA.Click,
                                                                    btnMA.Click, btnYA.Click, btnRA.Click, btnWA.Click
        ' Khi Option Strict la ON
        ShowCustomerList(DirectCast(sender, Button).Tag.ToString.Trim)
        ' Khi Option Strict la OFF
        'ShowCustomerList(sender.Tag.ToString)
        If dgvList.RowCount = 0 Then
            btnUpdate.Visible = False
            btnDelete.Visible = False
        End If

    End Sub

    Private Sub FmCustomerMaster_Load(sender As Object, e As EventArgs) Handles Me.Load
        With Me.dgvList
            .CellBorderStyle = DataGridViewCellBorderStyle.None
            .AllowUserToResizeRows = False
            .AllowUserToAddRows = False
            .ReadOnly = True
        End With
        InvisibleEntryArea()
        Me.btnUpdate.Visible = False
        Me.btnDelete.Visible = False
    End Sub

    Private Sub InvisibleEntryArea()
        Me.panelEntry.Height = 0
        Me.panelCustomerList.Top = ENTRY_TOP
        Me.panelCustomerList.Height = LIST_HEIGHT + ENTRY_HEIGHT
    End Sub

    Private Sub BtnEntry_Click(sender As Object, e As EventArgs) Handles btnEntry.Click
        VisibleEnntryArea()
        Me.txtCustomerName.Focus()
        TargetOperation = Operation.entry
        Me.btnEntry.Enabled = False
    End Sub

    Private Sub VisibleEnntryArea()
        Me.panelEntry.Height = ENTRY_HEIGHT
        Me.panelCustomerList.Top = ENTRY_TOP + ENTRY_HEIGHT
        Me.panelCustomerList.Height = LIST_HEIGHT
    End Sub

    Private Sub BtnExe_Click(sender As Object, e As EventArgs) Handles btnExe.Click
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
        If Me.txtCustomerName.Text = String.Empty Then
            MessageBox.Show("顧客名を入力して下さい", "確認")
            Me.txtCustomerName.Focus()
            Exit Sub
        End If
        Dim sql As String = "INSERT INTO T顧客マスタ (顧客名,フリガナ,Post,住所,TEL,FAX) "
        sql &= "VALUES('" & Me.txtCustomerName.Text.Trim & "','"
        sql &= Me.txtFurigana.Text.Trim & "','" & Me.txtPost.Text.Trim & "','" & Me.txtAddress.Text.Trim & "','"
        sql &= Me.txtTEL.Text.Trim & "','" & Me.txtFAX.Text & "')"
        If Not db.UpdateData(sql) Then
            MessageBox.Show("保存されませんでした。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        ClearControlData()
        InvisibleEntryArea()
        Me.btnEntry.Enabled = True
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

    Private Sub BtnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        ClearControlData()
        InvisibleEntryArea()
        Me.btnEntry.Enabled = True
        Me.btnUpdate.Visible = False
        Me.btnDelete.Visible = False
        Me.dgvList.Enabled = True
    End Sub

    Private Sub DgvList_RowHeaderMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgvList.RowHeaderMouseClick
        Me.btnUpdate.Visible = True
        Me.btnDelete.Visible = True
    End Sub

    Private Sub BtnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Me.btnExe.Text = "修正"
        VisibleEnntryArea()
        SetDataToControl()
        TargetOperation = Operation.update
        Me.dgvList.Enabled = True
    End Sub

    Private Sub SetDataToControl()
        With Me.dgvList
            Me.txtCustomerName.Text = (.CurrentRow.Cells("顧客名").Value.ToString.Trim)
            Me.txtFurigana.Text = (.CurrentRow.Cells("フリガナ").Value.ToString.Trim)
            Me.txtPost.Text = (.CurrentRow.Cells("Post").Value.ToString.Trim)
            Me.txtAddress.Text = (.CurrentRow.Cells("住所").Value.ToString.Trim)
            Me.txtTEL.Text = (.CurrentRow.Cells("TEL").Value.ToString.Trim)
            Me.txtFAX.Text = (.CurrentRow.Cells("FAX").Value.ToString.Trim)
        End With
    End Sub

    Private Sub UpdateData()
        Dim sql As String = "UPDATE T顧客マスタ SET 顧客名='" & Me.txtCustomerName.Text.Trim
        sql &= "' , フリガナ='" & Me.txtFurigana.Text.Trim
        sql &= "' , Post='" & Me.txtPost.Text.Trim
        sql &= "' , 住所='" & Me.txtAddress.Text.Trim
        sql &= "' , TEL='" & Me.txtTEL.Text.Trim
        sql &= "' , FAX='" & Me.txtFAX.Text.Trim
        sql &= "' WHERE 顧客ID=" & Me.dgvList.CurrentRow.Cells("顧客ID").Value.ToString

        If Not db.UpdateData(sql) Then
            Dim msg As String = "もう一度修正ボタンをクリックしてください。"
            MessageBox.Show(msg, "確認", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If
        UpdateGridViewRowData()
        ClearControlData()
        InvisibleEntryArea()
        Me.btnUpdate.Visible = False
        Me.btnDelete.Visible = False
        Me.dgvList.Enabled = True
    End Sub

    Private Sub UpdateGridViewRowData()
        With Me.dgvList.CurrentRow
            .Cells("顧客名").Value = Me.txtCustomerName.Text.Trim
            .Cells("フリガナ").Value = Me.txtFurigana.Text.Trim
            .Cells("Post").Value = Me.txtPost.Text.Trim
            .Cells("住所").Value = Me.txtAddress.Text.Trim
            .Cells("TEL").Value = Me.txtTEL.Text.Trim
            .Cells("FAX").Value = Me.txtFAX.Text.Trim
        End With
    End Sub

    Private Sub BtnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Dim CustomerName As String = Me.dgvList.CurrentRow.Cells("顧客名").Value
        Dim msg As String = "以下のレコードを削除します。元に戻すことができません！よろしいですか？"
        msg &= vbNewLine & "顧客名: " & CustomerName
        Dim res As DialogResult = MessageBox.Show(msg, "削除の確認", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)
        If res = Windows.Forms.DialogResult.Yes Then
            Dim CustomerID As String = Me.dgvList.CurrentRow.Cells("顧客ID").Value.ToString.Trim
            Dim sql = "DELETE FROM T顧客マスタ WHERE 顧客ID=" & CustomerID
            If db.UpdateData(sql) Then
                Me.dgvList.Rows.RemoveAt(Me.dgvList.CurrentRow.Index)
                Me.btnUpdate.Visible = False
                Me.btnDelete.Visible = False
            End If
        End If
    End Sub
End Class