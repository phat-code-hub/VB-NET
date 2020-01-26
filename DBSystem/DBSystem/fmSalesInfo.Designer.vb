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
        Me.BtnClose = New System.Windows.Forms.Button()
        Me.BtnSave = New System.Windows.Forms.Button()
        Me.BtnDeleteSlip = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PanelMain = New System.Windows.Forms.Panel()
        Me.TxtSlipNo = New System.Windows.Forms.TextBox()
        Me.BtnCustomerSearch = New System.Windows.Forms.Button()
        Me.TxtRemarks = New System.Windows.Forms.TextBox()
        Me.TxtFAX = New System.Windows.Forms.TextBox()
        Me.TxtTEL = New System.Windows.Forms.TextBox()
        Me.TxtAddress = New System.Windows.Forms.TextBox()
        Me.TxtPost = New System.Windows.Forms.TextBox()
        Me.TxtKana = New System.Windows.Forms.TextBox()
        Me.TxtCustomerName = New System.Windows.Forms.TextBox()
        Me.TxtCustomerID = New System.Windows.Forms.TextBox()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.PanelEntry = New System.Windows.Forms.Panel()
        Me.BtnCancel = New System.Windows.Forms.Button()
        Me.BtnExe = New System.Windows.Forms.Button()
        Me.LbGoodsName = New System.Windows.Forms.Label()
        Me.TxtQuantity = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TxtPrice = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TxtGoodsID = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.DgvGoods = New System.Windows.Forms.DataGridView()
        Me.CbCategoryList = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PanelSub = New System.Windows.Forms.Panel()
        Me.BtnDeleteMeisai = New System.Windows.Forms.Button()
        Me.DgvMeisai = New System.Windows.Forms.DataGridView()
        Me.BtnUpdateMeisai = New System.Windows.Forms.Button()
        Me.BtnAddMeisai = New System.Windows.Forms.Button()
        Me.LbTotal = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.PanelMain.SuspendLayout()
        Me.PanelEntry.SuspendLayout()
        CType(Me.DgvGoods, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelSub.SuspendLayout()
        CType(Me.DgvMeisai, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.MistyRose
        Me.Panel1.Controls.Add(Me.BtnClose)
        Me.Panel1.Controls.Add(Me.BtnSave)
        Me.Panel1.Controls.Add(Me.BtnDeleteSlip)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Font = New System.Drawing.Font("Times New Roman", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1174, 53)
        Me.Panel1.TabIndex = 0
        '
        'BtnClose
        '
        Me.BtnClose.Location = New System.Drawing.Point(968, 13)
        Me.BtnClose.Name = "BtnClose"
        Me.BtnClose.Size = New System.Drawing.Size(102, 27)
        Me.BtnClose.TabIndex = 3
        Me.BtnClose.Text = "閉じる"
        Me.BtnClose.UseVisualStyleBackColor = True
        '
        'BtnSave
        '
        Me.BtnSave.Location = New System.Drawing.Point(836, 13)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Size = New System.Drawing.Size(102, 27)
        Me.BtnSave.TabIndex = 2
        Me.BtnSave.Text = "保存"
        Me.BtnSave.UseVisualStyleBackColor = True
        '
        'BtnDeleteSlip
        '
        Me.BtnDeleteSlip.Location = New System.Drawing.Point(586, 13)
        Me.BtnDeleteSlip.Name = "BtnDeleteSlip"
        Me.BtnDeleteSlip.Size = New System.Drawing.Size(212, 27)
        Me.BtnDeleteSlip.TabIndex = 1
        Me.BtnDeleteSlip.Text = "この伝票を削除する"
        Me.BtnDeleteSlip.UseVisualStyleBackColor = True
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
        Me.PanelMain.Controls.Add(Me.Label6)
        Me.PanelMain.Controls.Add(Me.TxtSlipNo)
        Me.PanelMain.Controls.Add(Me.BtnCustomerSearch)
        Me.PanelMain.Controls.Add(Me.TxtRemarks)
        Me.PanelMain.Controls.Add(Me.TxtFAX)
        Me.PanelMain.Controls.Add(Me.TxtTEL)
        Me.PanelMain.Controls.Add(Me.TxtAddress)
        Me.PanelMain.Controls.Add(Me.TxtPost)
        Me.PanelMain.Controls.Add(Me.TxtKana)
        Me.PanelMain.Controls.Add(Me.TxtCustomerName)
        Me.PanelMain.Controls.Add(Me.TxtCustomerID)
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
        'TxtSlipNo
        '
        Me.TxtSlipNo.BackColor = System.Drawing.SystemColors.Control
        Me.TxtSlipNo.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtSlipNo.Font = New System.Drawing.Font("Times New Roman", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtSlipNo.ForeColor = System.Drawing.Color.Red
        Me.TxtSlipNo.Location = New System.Drawing.Point(958, 11)
        Me.TxtSlipNo.Name = "TxtSlipNo"
        Me.TxtSlipNo.ReadOnly = True
        Me.TxtSlipNo.Size = New System.Drawing.Size(43, 32)
        Me.TxtSlipNo.TabIndex = 22
        Me.TxtSlipNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'BtnCustomerSearch
        '
        Me.BtnCustomerSearch.Location = New System.Drawing.Point(33, 15)
        Me.BtnCustomerSearch.Name = "BtnCustomerSearch"
        Me.BtnCustomerSearch.Size = New System.Drawing.Size(75, 28)
        Me.BtnCustomerSearch.TabIndex = 21
        Me.BtnCustomerSearch.Text = "顧客ID"
        Me.BtnCustomerSearch.UseVisualStyleBackColor = True
        '
        'TxtRemarks
        '
        Me.TxtRemarks.Location = New System.Drawing.Point(586, 73)
        Me.TxtRemarks.Multiline = True
        Me.TxtRemarks.Name = "TxtRemarks"
        Me.TxtRemarks.Size = New System.Drawing.Size(484, 73)
        Me.TxtRemarks.TabIndex = 20
        '
        'TxtFAX
        '
        Me.TxtFAX.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtFAX.Location = New System.Drawing.Point(391, 124)
        Me.TxtFAX.Name = "TxtFAX"
        Me.TxtFAX.ReadOnly = True
        Me.TxtFAX.Size = New System.Drawing.Size(153, 22)
        Me.TxtFAX.TabIndex = 19
        '
        'TxtTEL
        '
        Me.TxtTEL.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtTEL.Location = New System.Drawing.Point(210, 124)
        Me.TxtTEL.Name = "TxtTEL"
        Me.TxtTEL.ReadOnly = True
        Me.TxtTEL.Size = New System.Drawing.Size(152, 22)
        Me.TxtTEL.TabIndex = 18
        '
        'TxtAddress
        '
        Me.TxtAddress.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtAddress.Location = New System.Drawing.Point(295, 89)
        Me.TxtAddress.Name = "TxtAddress"
        Me.TxtAddress.ReadOnly = True
        Me.TxtAddress.Size = New System.Drawing.Size(249, 22)
        Me.TxtAddress.TabIndex = 17
        '
        'TxtPost
        '
        Me.TxtPost.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtPost.Location = New System.Drawing.Point(210, 89)
        Me.TxtPost.Name = "TxtPost"
        Me.TxtPost.ReadOnly = True
        Me.TxtPost.Size = New System.Drawing.Size(79, 22)
        Me.TxtPost.TabIndex = 16
        '
        'TxtKana
        '
        Me.TxtKana.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtKana.Location = New System.Drawing.Point(210, 54)
        Me.TxtKana.Name = "TxtKana"
        Me.TxtKana.ReadOnly = True
        Me.TxtKana.Size = New System.Drawing.Size(334, 22)
        Me.TxtKana.TabIndex = 15
        '
        'TxtCustomerName
        '
        Me.TxtCustomerName.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtCustomerName.Location = New System.Drawing.Point(210, 19)
        Me.TxtCustomerName.Name = "TxtCustomerName"
        Me.TxtCustomerName.ReadOnly = True
        Me.TxtCustomerName.Size = New System.Drawing.Size(334, 22)
        Me.TxtCustomerName.TabIndex = 14
        '
        'TxtCustomerID
        '
        Me.TxtCustomerID.Location = New System.Drawing.Point(118, 16)
        Me.TxtCustomerID.Name = "TxtCustomerID"
        Me.TxtCustomerID.Size = New System.Drawing.Size(79, 29)
        Me.TxtCustomerID.TabIndex = 13
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
        Me.PanelEntry.Controls.Add(Me.BtnCancel)
        Me.PanelEntry.Controls.Add(Me.BtnExe)
        Me.PanelEntry.Controls.Add(Me.LbGoodsName)
        Me.PanelEntry.Controls.Add(Me.TxtQuantity)
        Me.PanelEntry.Controls.Add(Me.Label5)
        Me.PanelEntry.Controls.Add(Me.TxtPrice)
        Me.PanelEntry.Controls.Add(Me.Label4)
        Me.PanelEntry.Controls.Add(Me.TxtGoodsID)
        Me.PanelEntry.Controls.Add(Me.Label3)
        Me.PanelEntry.Controls.Add(Me.DgvGoods)
        Me.PanelEntry.Controls.Add(Me.CbCategoryList)
        Me.PanelEntry.Controls.Add(Me.Label2)
        Me.PanelEntry.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelEntry.Font = New System.Drawing.Font("Times New Roman", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PanelEntry.Location = New System.Drawing.Point(0, 218)
        Me.PanelEntry.Margin = New System.Windows.Forms.Padding(4)
        Me.PanelEntry.Name = "PanelEntry"
        Me.PanelEntry.Size = New System.Drawing.Size(1174, 143)
        Me.PanelEntry.TabIndex = 2
        '
        'BtnCancel
        '
        Me.BtnCancel.Location = New System.Drawing.Point(945, 76)
        Me.BtnCancel.Name = "BtnCancel"
        Me.BtnCancel.Size = New System.Drawing.Size(125, 36)
        Me.BtnCancel.TabIndex = 21
        Me.BtnCancel.Text = "キャンセル"
        Me.BtnCancel.UseVisualStyleBackColor = True
        '
        'BtnExe
        '
        Me.BtnExe.Location = New System.Drawing.Point(945, 10)
        Me.BtnExe.Name = "BtnExe"
        Me.BtnExe.Size = New System.Drawing.Size(125, 60)
        Me.BtnExe.TabIndex = 20
        Me.BtnExe.Text = "登録"
        Me.BtnExe.UseVisualStyleBackColor = True
        '
        'LbGoodsName
        '
        Me.LbGoodsName.AutoSize = True
        Me.LbGoodsName.Location = New System.Drawing.Point(815, 14)
        Me.LbGoodsName.Name = "LbGoodsName"
        Me.LbGoodsName.Size = New System.Drawing.Size(110, 21)
        Me.LbGoodsName.TabIndex = 19
        Me.LbGoodsName.Text = "__________"
        '
        'TxtQuantity
        '
        Me.TxtQuantity.Location = New System.Drawing.Point(748, 83)
        Me.TxtQuantity.Name = "TxtQuantity"
        Me.TxtQuantity.Size = New System.Drawing.Size(168, 29)
        Me.TxtQuantity.TabIndex = 18
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(662, 87)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(44, 21)
        Me.Label5.TabIndex = 17
        Me.Label5.Text = "数量"
        '
        'TxtPrice
        '
        Me.TxtPrice.Location = New System.Drawing.Point(748, 48)
        Me.TxtPrice.Name = "TxtPrice"
        Me.TxtPrice.Size = New System.Drawing.Size(168, 29)
        Me.TxtPrice.TabIndex = 16
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(662, 52)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(44, 21)
        Me.Label4.TabIndex = 15
        Me.Label4.Text = "単価"
        '
        'TxtGoodsID
        '
        Me.TxtGoodsID.Location = New System.Drawing.Point(748, 10)
        Me.TxtGoodsID.Name = "TxtGoodsID"
        Me.TxtGoodsID.Size = New System.Drawing.Size(50, 29)
        Me.TxtGoodsID.TabIndex = 14
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(662, 14)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(63, 21)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "商品ID"
        '
        'DgvGoods
        '
        Me.DgvGoods.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.DgvGoods.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvGoods.Location = New System.Drawing.Point(33, 45)
        Me.DgvGoods.Name = "DgvGoods"
        Me.DgvGoods.RowTemplate.Height = 24
        Me.DgvGoods.Size = New System.Drawing.Size(612, 75)
        Me.DgvGoods.TabIndex = 2
        '
        'CbCategoryList
        '
        Me.CbCategoryList.FormattingEnabled = True
        Me.CbCategoryList.Location = New System.Drawing.Point(203, 7)
        Me.CbCategoryList.Name = "CbCategoryList"
        Me.CbCategoryList.Size = New System.Drawing.Size(268, 28)
        Me.CbCategoryList.TabIndex = 1
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
        'PanelSub
        '
        Me.PanelSub.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.PanelSub.BackColor = System.Drawing.Color.MistyRose
        Me.PanelSub.Controls.Add(Me.BtnDeleteMeisai)
        Me.PanelSub.Controls.Add(Me.DgvMeisai)
        Me.PanelSub.Controls.Add(Me.BtnUpdateMeisai)
        Me.PanelSub.Controls.Add(Me.BtnAddMeisai)
        Me.PanelSub.Controls.Add(Me.LbTotal)
        Me.PanelSub.Controls.Add(Me.Label11)
        Me.PanelSub.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanelSub.Font = New System.Drawing.Font("Times New Roman", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PanelSub.Location = New System.Drawing.Point(0, 361)
        Me.PanelSub.Margin = New System.Windows.Forms.Padding(4)
        Me.PanelSub.Name = "PanelSub"
        Me.PanelSub.Size = New System.Drawing.Size(1174, 188)
        Me.PanelSub.TabIndex = 3
        '
        'BtnDeleteMeisai
        '
        Me.BtnDeleteMeisai.Location = New System.Drawing.Point(466, 7)
        Me.BtnDeleteMeisai.Name = "BtnDeleteMeisai"
        Me.BtnDeleteMeisai.Size = New System.Drawing.Size(120, 36)
        Me.BtnDeleteMeisai.TabIndex = 23
        Me.BtnDeleteMeisai.Text = "選択行の削除"
        Me.BtnDeleteMeisai.UseVisualStyleBackColor = True
        '
        'DgvMeisai
        '
        Me.DgvMeisai.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.DgvMeisai.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvMeisai.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.DgvMeisai.Location = New System.Drawing.Point(0, 49)
        Me.DgvMeisai.Name = "DgvMeisai"
        Me.DgvMeisai.RowTemplate.Height = 24
        Me.DgvMeisai.Size = New System.Drawing.Size(1174, 139)
        Me.DgvMeisai.TabIndex = 22
        '
        'BtnUpdateMeisai
        '
        Me.BtnUpdateMeisai.Location = New System.Drawing.Point(306, 7)
        Me.BtnUpdateMeisai.Name = "BtnUpdateMeisai"
        Me.BtnUpdateMeisai.Size = New System.Drawing.Size(134, 36)
        Me.BtnUpdateMeisai.TabIndex = 21
        Me.BtnUpdateMeisai.Text = "選択行の修正"
        Me.BtnUpdateMeisai.UseVisualStyleBackColor = True
        '
        'BtnAddMeisai
        '
        Me.BtnAddMeisai.Location = New System.Drawing.Point(33, 7)
        Me.BtnAddMeisai.Name = "BtnAddMeisai"
        Me.BtnAddMeisai.Size = New System.Drawing.Size(125, 36)
        Me.BtnAddMeisai.TabIndex = 20
        Me.BtnAddMeisai.Text = "明細の追加"
        Me.BtnAddMeisai.UseVisualStyleBackColor = True
        '
        'LbTotal
        '
        Me.LbTotal.AutoSize = True
        Me.LbTotal.Location = New System.Drawing.Point(964, 15)
        Me.LbTotal.Name = "LbTotal"
        Me.LbTotal.Size = New System.Drawing.Size(80, 21)
        Me.LbTotal.TabIndex = 19
        Me.LbTotal.Text = "_______"
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
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(582, 49)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(44, 21)
        Me.Label6.TabIndex = 23
        Me.Label6.Text = "備考"
        '
        'FmSalesInfo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1174, 549)
        Me.Controls.Add(Me.PanelSub)
        Me.Controls.Add(Me.PanelEntry)
        Me.Controls.Add(Me.PanelMain)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Times New Roman", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FmSalesInfo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "売上管理システム"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.PanelMain.ResumeLayout(False)
        Me.PanelMain.PerformLayout()
        Me.PanelEntry.ResumeLayout(False)
        Me.PanelEntry.PerformLayout()
        CType(Me.DgvGoods, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelSub.ResumeLayout(False)
        Me.PanelSub.PerformLayout()
        CType(Me.DgvMeisai, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents BtnClose As Button
    Friend WithEvents BtnSave As Button
    Friend WithEvents BtnDeleteSlip As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents PanelMain As Panel
    Friend WithEvents PanelEntry As Panel
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents Label10 As Label
    Friend WithEvents TxtCustomerName As TextBox
    Friend WithEvents TxtCustomerID As TextBox
    Friend WithEvents BtnCustomerSearch As Button
    Friend WithEvents TxtRemarks As TextBox
    Friend WithEvents TxtFAX As TextBox
    Friend WithEvents TxtTEL As TextBox
    Friend WithEvents TxtAddress As TextBox
    Friend WithEvents TxtPost As TextBox
    Friend WithEvents TxtKana As TextBox
    Friend WithEvents TxtSlipNo As TextBox
    Friend WithEvents BtnCancel As Button
    Friend WithEvents BtnExe As Button
    Friend WithEvents LbGoodsName As Label
    Friend WithEvents TxtQuantity As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TxtPrice As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TxtGoodsID As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents DgvGoods As DataGridView
    Friend WithEvents CbCategoryList As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents PanelSub As Panel
    Friend WithEvents BtnDeleteMeisai As Button
    Friend WithEvents DgvMeisai As DataGridView
    Friend WithEvents BtnUpdateMeisai As Button
    Friend WithEvents BtnAddMeisai As Button
    Friend WithEvents LbTotal As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label6 As Label
End Class
