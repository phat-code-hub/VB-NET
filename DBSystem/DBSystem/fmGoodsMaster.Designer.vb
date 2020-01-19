<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class fmGoodsMaster
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
        Me.btnEntry = New System.Windows.Forms.Button()
        Me.BtnClose = New System.Windows.Forms.Button()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.panelEntry = New System.Windows.Forms.Panel()
        Me.cbMaker = New System.Windows.Forms.ComboBox()
        Me.cbCategory = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtRemarks = New System.Windows.Forms.TextBox()
        Me.txtUnit = New System.Windows.Forms.TextBox()
        Me.txtPrice = New System.Windows.Forms.TextBox()
        Me.txtCost = New System.Windows.Forms.TextBox()
        Me.txtGoodsName = New System.Windows.Forms.TextBox()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnExe = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.panelCustomerList = New System.Windows.Forms.Panel()
        Me.cbCategoryList = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.dgvList = New System.Windows.Forms.DataGridView()
        Me.Panel1.SuspendLayout()
        Me.panelEntry.SuspendLayout()
        Me.panelCustomerList.SuspendLayout()
        CType(Me.dgvList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.MistyRose
        Me.Panel1.Controls.Add(Me.btnEntry)
        Me.Panel1.Controls.Add(Me.BtnClose)
        Me.Panel1.Controls.Add(Me.lblDate)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(964, 109)
        Me.Panel1.TabIndex = 0
        '
        'btnEntry
        '
        Me.btnEntry.Location = New System.Drawing.Point(643, 59)
        Me.btnEntry.Name = "btnEntry"
        Me.btnEntry.Size = New System.Drawing.Size(110, 37)
        Me.btnEntry.TabIndex = 3
        Me.btnEntry.Text = "新規登録"
        Me.btnEntry.UseVisualStyleBackColor = True
        '
        'BtnClose
        '
        Me.BtnClose.Location = New System.Drawing.Point(802, 59)
        Me.BtnClose.Name = "BtnClose"
        Me.BtnClose.Size = New System.Drawing.Size(110, 37)
        Me.BtnClose.TabIndex = 2
        Me.BtnClose.Text = "閉じる"
        Me.BtnClose.UseVisualStyleBackColor = True
        '
        'lblDate
        '
        Me.lblDate.AutoSize = True
        Me.lblDate.Location = New System.Drawing.Point(785, 22)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(28, 21)
        Me.lblDate.TabIndex = 1
        Me.lblDate.Text = "---"
        Me.lblDate.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("MS PMincho", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Red
        Me.Label1.Location = New System.Drawing.Point(54, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(175, 34)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "商品マスタ"
        '
        'panelEntry
        '
        Me.panelEntry.BackColor = System.Drawing.Color.LemonChiffon
        Me.panelEntry.Controls.Add(Me.cbMaker)
        Me.panelEntry.Controls.Add(Me.cbCategory)
        Me.panelEntry.Controls.Add(Me.Label9)
        Me.panelEntry.Controls.Add(Me.Label8)
        Me.panelEntry.Controls.Add(Me.txtRemarks)
        Me.panelEntry.Controls.Add(Me.txtUnit)
        Me.panelEntry.Controls.Add(Me.txtPrice)
        Me.panelEntry.Controls.Add(Me.txtCost)
        Me.panelEntry.Controls.Add(Me.txtGoodsName)
        Me.panelEntry.Controls.Add(Me.btnCancel)
        Me.panelEntry.Controls.Add(Me.btnExe)
        Me.panelEntry.Controls.Add(Me.Label6)
        Me.panelEntry.Controls.Add(Me.Label5)
        Me.panelEntry.Controls.Add(Me.Label4)
        Me.panelEntry.Controls.Add(Me.Label3)
        Me.panelEntry.Controls.Add(Me.Label2)
        Me.panelEntry.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.panelEntry.Location = New System.Drawing.Point(0, 102)
        Me.panelEntry.Name = "panelEntry"
        Me.panelEntry.Size = New System.Drawing.Size(964, 134)
        Me.panelEntry.TabIndex = 1
        '
        'cbMaker
        '
        Me.cbMaker.FormattingEnabled = True
        Me.cbMaker.Location = New System.Drawing.Point(85, 95)
        Me.cbMaker.Name = "cbMaker"
        Me.cbMaker.Size = New System.Drawing.Size(171, 25)
        Me.cbMaker.TabIndex = 17
        '
        'cbCategory
        '
        Me.cbCategory.FormattingEnabled = True
        Me.cbCategory.Location = New System.Drawing.Point(85, 50)
        Me.cbCategory.Name = "cbCategory"
        Me.cbCategory.Size = New System.Drawing.Size(171, 25)
        Me.cbCategory.TabIndex = 16
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(21, 95)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(50, 17)
        Me.Label9.TabIndex = 15
        Me.Label9.Text = "メーカー"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(21, 56)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(50, 17)
        Me.Label8.TabIndex = 14
        Me.Label8.Text = "分類名"
        '
        'txtRemarks
        '
        Me.txtRemarks.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRemarks.Location = New System.Drawing.Point(347, 92)
        Me.txtRemarks.Name = "txtRemarks"
        Me.txtRemarks.Size = New System.Drawing.Size(406, 25)
        Me.txtRemarks.TabIndex = 12
        Me.txtRemarks.Tag = "y"
        '
        'txtUnit
        '
        Me.txtUnit.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUnit.Location = New System.Drawing.Point(347, 50)
        Me.txtUnit.Name = "txtUnit"
        Me.txtUnit.Size = New System.Drawing.Size(167, 25)
        Me.txtUnit.TabIndex = 11
        Me.txtUnit.Tag = "y"
        '
        'txtPrice
        '
        Me.txtPrice.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPrice.Location = New System.Drawing.Point(347, 6)
        Me.txtPrice.Name = "txtPrice"
        Me.txtPrice.Size = New System.Drawing.Size(167, 25)
        Me.txtPrice.TabIndex = 10
        Me.txtPrice.Tag = "y"
        '
        'txtCost
        '
        Me.txtCost.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCost.Location = New System.Drawing.Point(584, 6)
        Me.txtCost.Name = "txtCost"
        Me.txtCost.Size = New System.Drawing.Size(189, 25)
        Me.txtCost.TabIndex = 9
        Me.txtCost.Tag = "y"
        '
        'txtGoodsName
        '
        Me.txtGoodsName.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGoodsName.Location = New System.Drawing.Point(85, 6)
        Me.txtGoodsName.Name = "txtGoodsName"
        Me.txtGoodsName.Size = New System.Drawing.Size(171, 25)
        Me.txtGoodsName.TabIndex = 8
        Me.txtGoodsName.Tag = "y"
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(790, 83)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(136, 29)
        Me.btnCancel.TabIndex = 7
        Me.btnCancel.Text = "キャンセル"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnExe
        '
        Me.btnExe.Location = New System.Drawing.Point(789, 12)
        Me.btnExe.Name = "btnExe"
        Me.btnExe.Size = New System.Drawing.Size(137, 61)
        Me.btnExe.TabIndex = 6
        Me.btnExe.Text = "新規登録"
        Me.btnExe.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(286, 100)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(36, 17)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "備考"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(286, 54)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(36, 17)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "単位"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(286, 10)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(36, 17)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "単価"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(520, 10)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(64, 17)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "仕入単価"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(21, 10)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(50, 17)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "商品名"
        '
        'panelCustomerList
        '
        Me.panelCustomerList.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.panelCustomerList.Controls.Add(Me.cbCategoryList)
        Me.panelCustomerList.Controls.Add(Me.Label7)
        Me.panelCustomerList.Controls.Add(Me.btnDelete)
        Me.panelCustomerList.Controls.Add(Me.btnUpdate)
        Me.panelCustomerList.Controls.Add(Me.dgvList)
        Me.panelCustomerList.Location = New System.Drawing.Point(0, 242)
        Me.panelCustomerList.Name = "panelCustomerList"
        Me.panelCustomerList.Size = New System.Drawing.Size(964, 514)
        Me.panelCustomerList.TabIndex = 2
        '
        'cbCategoryList
        '
        Me.cbCategoryList.FormattingEnabled = True
        Me.cbCategoryList.Location = New System.Drawing.Point(236, 14)
        Me.cbCategoryList.Name = "cbCategoryList"
        Me.cbCategoryList.Size = New System.Drawing.Size(236, 28)
        Me.cbCategoryList.TabIndex = 14
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(31, 23)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(164, 21)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "分類を指定してください"
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(795, 14)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(131, 43)
        Me.btnDelete.TabIndex = 12
        Me.btnDelete.Text = "削除"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnUpdate
        '
        Me.btnUpdate.Location = New System.Drawing.Point(622, 14)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(131, 43)
        Me.btnUpdate.TabIndex = 11
        Me.btnUpdate.Text = "修正"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'dgvList
        '
        Me.dgvList.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvList.Location = New System.Drawing.Point(3, 63)
        Me.dgvList.Name = "dgvList"
        Me.dgvList.RowTemplate.Height = 27
        Me.dgvList.Size = New System.Drawing.Size(961, 448)
        Me.dgvList.TabIndex = 0
        '
        'fmGoodsMaster
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(968, 756)
        Me.Controls.Add(Me.panelCustomerList)
        Me.Controls.Add(Me.panelEntry)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Times New Roman", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "fmGoodsMaster"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "売上管理システム"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.panelEntry.ResumeLayout(False)
        Me.panelEntry.PerformLayout()
        Me.panelCustomerList.ResumeLayout(False)
        Me.panelCustomerList.PerformLayout()
        CType(Me.dgvList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents BtnClose As System.Windows.Forms.Button
    Friend WithEvents lblDate As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents panelEntry As System.Windows.Forms.Panel
    Friend WithEvents panelCustomerList As System.Windows.Forms.Panel
    Friend WithEvents btnEntry As System.Windows.Forms.Button
    Friend WithEvents txtRemarks As System.Windows.Forms.TextBox
    Friend WithEvents txtUnit As System.Windows.Forms.TextBox
    Friend WithEvents txtPrice As System.Windows.Forms.TextBox
    Friend WithEvents txtCost As System.Windows.Forms.TextBox
    Friend WithEvents txtGoodsName As System.Windows.Forms.TextBox
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents btnExe As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents btnUpdate As System.Windows.Forms.Button
    Friend WithEvents dgvList As System.Windows.Forms.DataGridView
    Friend WithEvents cbMaker As ComboBox
    Friend WithEvents cbCategory As ComboBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents cbCategoryList As ComboBox
    Friend WithEvents Label7 As Label
End Class
