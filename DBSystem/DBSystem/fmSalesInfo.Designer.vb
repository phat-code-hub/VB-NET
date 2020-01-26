<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FmSalesInfo
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnDeleteSlip = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PanelMain = New System.Windows.Forms.Panel()
        Me.txtSlipNo = New System.Windows.Forms.TextBox()
        Me.btnCustomerSearch = New System.Windows.Forms.Button()
        Me.txtRemarks = New System.Windows.Forms.TextBox()
        Me.txtFAX = New System.Windows.Forms.TextBox()
        Me.txtTEL = New System.Windows.Forms.TextBox()
        Me.txtAddress = New System.Windows.Forms.TextBox()
        Me.txtPost = New System.Windows.Forms.TextBox()
        Me.txtKana = New System.Windows.Forms.TextBox()
        Me.txtCustomerName = New System.Windows.Forms.TextBox()
        Me.txtCustomerID = New System.Windows.Forms.TextBox()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.PanelEntry = New System.Windows.Forms.Panel()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnExe = New System.Windows.Forms.Button()
        Me.lbGoodsName = New System.Windows.Forms.Label()
        Me.txtQuantity = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtPrice = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtGoodsID = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dgvGoods = New System.Windows.Forms.DataGridView()
        Me.cbCategoryList = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.panelSub = New System.Windows.Forms.Panel()
        Me.btnDeleteMeisai = New System.Windows.Forms.Button()
        Me.dgvMeisai = New System.Windows.Forms.DataGridView()
        Me.btnUpdateMeisai = New System.Windows.Forms.Button()
        Me.btnAddMeisai = New System.Windows.Forms.Button()
        Me.lbTotal = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.PanelMain.SuspendLayout()
        Me.PanelEntry.SuspendLayout()
        CType(Me.dgvGoods, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelSub.SuspendLayout()
        CType(Me.dgvMeisai, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.MistyRose
        Me.Panel1.Controls.Add(Me.btnClose)
        Me.Panel1.Controls.Add(Me.btnSave)
        Me.Panel1.Controls.Add(Me.btnDeleteSlip)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Font = New System.Drawing.Font("Times New Roman", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1174, 53)
        Me.Panel1.TabIndex = 0
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(968, 13)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(102, 27)
        Me.btnClose.TabIndex = 3
        Me.btnClose.Text = "閉じる"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(836, 13)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(102, 27)
        Me.btnSave.TabIndex = 2
        Me.btnSave.Text = "保存"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnDeleteSlip
        '
        Me.btnDeleteSlip.Location = New System.Drawing.Point(586, 13)
        Me.btnDeleteSlip.Name = "btnDeleteSlip"
        Me.btnDeleteSlip.Size = New System.Drawing.Size(212, 27)
        Me.btnDeleteSlip.TabIndex = 1
        Me.btnDeleteSlip.Text = "この伝票を削除する"
        Me.btnDeleteSlip.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Red
        Me.Label1.Location = New System.Drawing.Point(33, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(143, 35)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "売上伝票"
        '
        'PanelMain
        '
        Me.PanelMain.BackColor = System.Drawing.Color.MistyRose
        Me.PanelMain.Controls.Add(Me.txtSlipNo)
        Me.PanelMain.Controls.Add(Me.btnCustomerSearch)
        Me.PanelMain.Controls.Add(Me.txtRemarks)
        Me.PanelMain.Controls.Add(Me.txtFAX)
        Me.PanelMain.Controls.Add(Me.txtTEL)
        Me.PanelMain.Controls.Add(Me.txtAddress)
        Me.PanelMain.Controls.Add(Me.txtPost)
        Me.PanelMain.Controls.Add(Me.txtKana)
        Me.PanelMain.Controls.Add(Me.txtCustomerName)
        Me.PanelMain.Controls.Add(Me.txtCustomerID)
        Me.PanelMain.Controls.Add(Me.DateTimePicker1)
        Me.PanelMain.Controls.Add(Me.Label10)
        Me.PanelMain.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelMain.Font = New System.Drawing.Font("Times New Roman", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PanelMain.Location = New System.Drawing.Point(0, 53)
        Me.PanelMain.Margin = New System.Windows.Forms.Padding(4)
        Me.PanelMain.Name = "PanelMain"
        Me.PanelMain.Size = New System.Drawing.Size(1174, 165)
        Me.PanelMain.TabIndex = 1
        '
        'txtSlipNo
        '
        Me.txtSlipNo.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtSlipNo.Location = New System.Drawing.Point(958, 15)
        Me.txtSlipNo.Name = "txtSlipNo"
        Me.txtSlipNo.ReadOnly = True
        Me.txtSlipNo.Size = New System.Drawing.Size(112, 22)
        Me.txtSlipNo.TabIndex = 22
        '
        'btnCustomerSearch
        '
        Me.btnCustomerSearch.Location = New System.Drawing.Point(33, 15)
        Me.btnCustomerSearch.Name = "btnCustomerSearch"
        Me.btnCustomerSearch.Size = New System.Drawing.Size(75, 28)
        Me.btnCustomerSearch.TabIndex = 21
        Me.btnCustomerSearch.Text = "顧客ID"
        Me.btnCustomerSearch.UseVisualStyleBackColor = True
        '
        'txtRemarks
        '
        Me.txtRemarks.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtRemarks.Location = New System.Drawing.Point(586, 54)
        Me.txtRemarks.Multiline = True
        Me.txtRemarks.Name = "txtRemarks"
        Me.txtRemarks.ReadOnly = True
        Me.txtRemarks.Size = New System.Drawing.Size(484, 82)
        Me.txtRemarks.TabIndex = 20
        '
        'txtFAX
        '
        Me.txtFAX.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtFAX.Location = New System.Drawing.Point(391, 124)
        Me.txtFAX.Name = "txtFAX"
        Me.txtFAX.ReadOnly = True
        Me.txtFAX.Size = New System.Drawing.Size(153, 22)
        Me.txtFAX.TabIndex = 19
        '
        'txtTEL
        '
        Me.txtTEL.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtTEL.Location = New System.Drawing.Point(210, 124)
        Me.txtTEL.Name = "txtTEL"
        Me.txtTEL.ReadOnly = True
        Me.txtTEL.Size = New System.Drawing.Size(152, 22)
        Me.txtTEL.TabIndex = 18
        '
        'txtAddress
        '
        Me.txtAddress.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtAddress.Location = New System.Drawing.Point(295, 89)
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.ReadOnly = True
        Me.txtAddress.Size = New System.Drawing.Size(249, 22)
        Me.txtAddress.TabIndex = 17
        '
        'txtPost
        '
        Me.txtPost.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtPost.Location = New System.Drawing.Point(210, 89)
        Me.txtPost.Name = "txtPost"
        Me.txtPost.ReadOnly = True
        Me.txtPost.Size = New System.Drawing.Size(79, 22)
        Me.txtPost.TabIndex = 16
        '
        'txtKana
        '
        Me.txtKana.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtKana.Location = New System.Drawing.Point(210, 54)
        Me.txtKana.Name = "txtKana"
        Me.txtKana.ReadOnly = True
        Me.txtKana.Size = New System.Drawing.Size(334, 22)
        Me.txtKana.TabIndex = 15
        '
        'txtCustomerName
        '
        Me.txtCustomerName.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtCustomerName.Location = New System.Drawing.Point(210, 19)
        Me.txtCustomerName.Name = "txtCustomerName"
        Me.txtCustomerName.ReadOnly = True
        Me.txtCustomerName.Size = New System.Drawing.Size(334, 22)
        Me.txtCustomerName.TabIndex = 14
        '
        'txtCustomerID
        '
        Me.txtCustomerID.Location = New System.Drawing.Point(118, 16)
        Me.txtCustomerID.Name = "txtCustomerID"
        Me.txtCustomerID.Size = New System.Drawing.Size(79, 29)
        Me.txtCustomerID.TabIndex = 13
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(657, 13)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(281, 29)
        Me.DateTimePicker1.TabIndex = 11
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(582, 19)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(44, 21)
        Me.Label10.TabIndex = 8
        Me.Label10.Text = "日付"
        '
        'PanelEntry
        '
        Me.PanelEntry.BackColor = System.Drawing.Color.MistyRose
        Me.PanelEntry.Controls.Add(Me.btnCancel)
        Me.PanelEntry.Controls.Add(Me.btnExe)
        Me.PanelEntry.Controls.Add(Me.lbGoodsName)
        Me.PanelEntry.Controls.Add(Me.txtQuantity)
        Me.PanelEntry.Controls.Add(Me.Label5)
        Me.PanelEntry.Controls.Add(Me.txtPrice)
        Me.PanelEntry.Controls.Add(Me.Label4)
        Me.PanelEntry.Controls.Add(Me.txtGoodsID)
        Me.PanelEntry.Controls.Add(Me.Label3)
        Me.PanelEntry.Controls.Add(Me.dgvGoods)
        Me.PanelEntry.Controls.Add(Me.cbCategoryList)
        Me.PanelEntry.Controls.Add(Me.Label2)
        Me.PanelEntry.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelEntry.Font = New System.Drawing.Font("Times New Roman", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PanelEntry.Location = New System.Drawing.Point(0, 218)
        Me.PanelEntry.Margin = New System.Windows.Forms.Padding(4)
        Me.PanelEntry.Name = "PanelEntry"
        Me.PanelEntry.Size = New System.Drawing.Size(1174, 143)
        Me.PanelEntry.TabIndex = 2
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(945, 69)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(125, 36)
        Me.btnCancel.TabIndex = 21
        Me.btnCancel.Text = "キャンセル"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnExe
        '
        Me.btnExe.Location = New System.Drawing.Point(945, 3)
        Me.btnExe.Name = "btnExe"
        Me.btnExe.Size = New System.Drawing.Size(125, 60)
        Me.btnExe.TabIndex = 20
        Me.btnExe.Text = "登録"
        Me.btnExe.UseVisualStyleBackColor = True
        '
        'lbGoodsName
        '
        Me.lbGoodsName.AutoSize = True
        Me.lbGoodsName.Location = New System.Drawing.Point(658, 11)
        Me.lbGoodsName.Name = "lbGoodsName"
        Me.lbGoodsName.Size = New System.Drawing.Size(80, 21)
        Me.lbGoodsName.TabIndex = 19
        Me.lbGoodsName.Text = "_______"
        '
        'txtQuantity
        '
        Me.txtQuantity.Location = New System.Drawing.Point(570, 80)
        Me.txtQuantity.Name = "txtQuantity"
        Me.txtQuantity.Size = New System.Drawing.Size(168, 29)
        Me.txtQuantity.TabIndex = 18
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(484, 84)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(44, 21)
        Me.Label5.TabIndex = 17
        Me.Label5.Text = "数量"
        '
        'txtPrice
        '
        Me.txtPrice.Location = New System.Drawing.Point(570, 45)
        Me.txtPrice.Name = "txtPrice"
        Me.txtPrice.Size = New System.Drawing.Size(168, 29)
        Me.txtPrice.TabIndex = 16
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(484, 49)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(44, 21)
        Me.Label4.TabIndex = 15
        Me.Label4.Text = "単価"
        '
        'txtGoodsID
        '
        Me.txtGoodsID.Location = New System.Drawing.Point(570, 7)
        Me.txtGoodsID.Name = "txtGoodsID"
        Me.txtGoodsID.Size = New System.Drawing.Size(82, 29)
        Me.txtGoodsID.TabIndex = 14
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(484, 11)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(63, 21)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "商品ID"
        '
        'dgvGoods
        '
        Me.dgvGoods.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.dgvGoods.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvGoods.Location = New System.Drawing.Point(33, 45)
        Me.dgvGoods.Name = "dgvGoods"
        Me.dgvGoods.RowTemplate.Height = 24
        Me.dgvGoods.Size = New System.Drawing.Size(438, 75)
        Me.dgvGoods.TabIndex = 2
        '
        'cbCategoryList
        '
        Me.cbCategoryList.FormattingEnabled = True
        Me.cbCategoryList.Location = New System.Drawing.Point(182, 7)
        Me.cbCategoryList.Name = "cbCategoryList"
        Me.cbCategoryList.Size = New System.Drawing.Size(268, 28)
        Me.cbCategoryList.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(33, 11)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(164, 21)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "分類を指定してください"
        '
        'panelSub
        '
        Me.panelSub.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.panelSub.BackColor = System.Drawing.Color.MistyRose
        Me.panelSub.Controls.Add(Me.btnDeleteMeisai)
        Me.panelSub.Controls.Add(Me.dgvMeisai)
        Me.panelSub.Controls.Add(Me.btnUpdateMeisai)
        Me.panelSub.Controls.Add(Me.btnAddMeisai)
        Me.panelSub.Controls.Add(Me.lbTotal)
        Me.panelSub.Controls.Add(Me.Label11)
        Me.panelSub.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.panelSub.Font = New System.Drawing.Font("Times New Roman", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.panelSub.Location = New System.Drawing.Point(0, 361)
        Me.panelSub.Margin = New System.Windows.Forms.Padding(4)
        Me.panelSub.Name = "panelSub"
        Me.panelSub.Size = New System.Drawing.Size(1174, 188)
        Me.panelSub.TabIndex = 3
        '
        'btnDeleteMeisai
        '
        Me.btnDeleteMeisai.Location = New System.Drawing.Point(466, 7)
        Me.btnDeleteMeisai.Name = "btnDeleteMeisai"
        Me.btnDeleteMeisai.Size = New System.Drawing.Size(120, 36)
        Me.btnDeleteMeisai.TabIndex = 23
        Me.btnDeleteMeisai.Text = "選択行の削除"
        Me.btnDeleteMeisai.UseVisualStyleBackColor = True
        '
        'dgvMeisai
        '
        Me.dgvMeisai.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.dgvMeisai.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvMeisai.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.dgvMeisai.Location = New System.Drawing.Point(0, 74)
        Me.dgvMeisai.Name = "dgvMeisai"
        Me.dgvMeisai.RowTemplate.Height = 24
        Me.dgvMeisai.Size = New System.Drawing.Size(1174, 114)
        Me.dgvMeisai.TabIndex = 22
        '
        'btnUpdateMeisai
        '
        Me.btnUpdateMeisai.Location = New System.Drawing.Point(306, 7)
        Me.btnUpdateMeisai.Name = "btnUpdateMeisai"
        Me.btnUpdateMeisai.Size = New System.Drawing.Size(134, 36)
        Me.btnUpdateMeisai.TabIndex = 21
        Me.btnUpdateMeisai.Text = "選択行の修正"
        Me.btnUpdateMeisai.UseVisualStyleBackColor = True
        '
        'btnAddMeisai
        '
        Me.btnAddMeisai.Location = New System.Drawing.Point(33, 7)
        Me.btnAddMeisai.Name = "btnAddMeisai"
        Me.btnAddMeisai.Size = New System.Drawing.Size(125, 36)
        Me.btnAddMeisai.TabIndex = 20
        Me.btnAddMeisai.Text = "明細の追加"
        Me.btnAddMeisai.UseVisualStyleBackColor = True
        '
        'lbTotal
        '
        Me.lbTotal.AutoSize = True
        Me.lbTotal.Location = New System.Drawing.Point(964, 15)
        Me.lbTotal.Name = "lbTotal"
        Me.lbTotal.Size = New System.Drawing.Size(80, 21)
        Me.lbTotal.TabIndex = 19
        Me.lbTotal.Text = "_______"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(793, 15)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(78, 21)
        Me.Label11.TabIndex = 0
        Me.Label11.Text = "合計金額"
        '
        'fmSalesInfo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1174, 549)
        Me.Controls.Add(Me.panelSub)
        Me.Controls.Add(Me.PanelEntry)
        Me.Controls.Add(Me.PanelMain)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Times New Roman", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "fmSalesInfo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "売上管理システム"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.PanelMain.ResumeLayout(False)
        Me.PanelMain.PerformLayout()
        Me.PanelEntry.ResumeLayout(False)
        Me.PanelEntry.PerformLayout()
        CType(Me.dgvGoods, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelSub.ResumeLayout(False)
        Me.panelSub.PerformLayout()
        CType(Me.dgvMeisai, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btnClose As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents btnDeleteSlip As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents PanelMain As Panel
    Friend WithEvents PanelEntry As Panel
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents Label10 As Label
    Friend WithEvents txtCustomerName As TextBox
    Friend WithEvents txtCustomerID As TextBox
    Friend WithEvents btnCustomerSearch As Button
    Friend WithEvents txtRemarks As TextBox
    Friend WithEvents txtFAX As TextBox
    Friend WithEvents txtTEL As TextBox
    Friend WithEvents txtAddress As TextBox
    Friend WithEvents txtPost As TextBox
    Friend WithEvents txtKana As TextBox
    Friend WithEvents txtSlipNo As TextBox
    Friend WithEvents btnCancel As Button
    Friend WithEvents btnExe As Button
    Friend WithEvents lbGoodsName As Label
    Friend WithEvents txtQuantity As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtPrice As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtGoodsID As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents dgvGoods As DataGridView
    Friend WithEvents cbCategoryList As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents panelSub As Panel
    Friend WithEvents btnDeleteMeisai As Button
    Friend WithEvents dgvMeisai As DataGridView
    Friend WithEvents btnUpdateMeisai As Button
    Friend WithEvents btnAddMeisai As Button
    Friend WithEvents lbTotal As Label
    Friend WithEvents Label11 As Label
End Class
