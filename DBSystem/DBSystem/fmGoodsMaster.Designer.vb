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
        Me.BtnEntry = New System.Windows.Forms.Button()
        Me.BtnClose = New System.Windows.Forms.Button()
        Me.LblDate = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PanelEntry = New System.Windows.Forms.Panel()
        Me.CbMaker = New System.Windows.Forms.ComboBox()
        Me.CbCategory = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TxtRemarks = New System.Windows.Forms.TextBox()
        Me.TxtUnit = New System.Windows.Forms.TextBox()
        Me.TxtPrice = New System.Windows.Forms.TextBox()
        Me.TxtCost = New System.Windows.Forms.TextBox()
        Me.TxtGoodsName = New System.Windows.Forms.TextBox()
        Me.BtnCancel = New System.Windows.Forms.Button()
        Me.BtnExe = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PanelCustomerList = New System.Windows.Forms.Panel()
        Me.CbCategoryList = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.BtnDelete = New System.Windows.Forms.Button()
        Me.BtnUpdate = New System.Windows.Forms.Button()
        Me.DgvList = New System.Windows.Forms.DataGridView()
        Me.Panel1.SuspendLayout()
        Me.PanelEntry.SuspendLayout()
        Me.PanelCustomerList.SuspendLayout()
        CType(Me.DgvList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.MistyRose
        Me.Panel1.Controls.Add(Me.BtnEntry)
        Me.Panel1.Controls.Add(Me.BtnClose)
        Me.Panel1.Controls.Add(Me.LblDate)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(964, 109)
        Me.Panel1.TabIndex = 0
        '
        'BtnEntry
        '
        Me.BtnEntry.Location = New System.Drawing.Point(643, 59)
        Me.BtnEntry.Name = "BtnEntry"
        Me.BtnEntry.Size = New System.Drawing.Size(110, 37)
        Me.BtnEntry.TabIndex = 3
        Me.BtnEntry.Text = "新規登録"
        Me.BtnEntry.UseVisualStyleBackColor = True
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
        'LblDate
        '
        Me.LblDate.AutoSize = True
        Me.LblDate.Location = New System.Drawing.Point(785, 22)
        Me.LblDate.Name = "LblDate"
        Me.LblDate.Size = New System.Drawing.Size(28, 21)
        Me.LblDate.TabIndex = 1
        Me.LblDate.Text = "---"
        Me.LblDate.TextAlign = System.Drawing.ContentAlignment.MiddleRight
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
        'PanelEntry
        '
        Me.PanelEntry.BackColor = System.Drawing.Color.LemonChiffon
        Me.PanelEntry.Controls.Add(Me.CbMaker)
        Me.PanelEntry.Controls.Add(Me.CbCategory)
        Me.PanelEntry.Controls.Add(Me.Label9)
        Me.PanelEntry.Controls.Add(Me.Label8)
        Me.PanelEntry.Controls.Add(Me.TxtRemarks)
        Me.PanelEntry.Controls.Add(Me.TxtUnit)
        Me.PanelEntry.Controls.Add(Me.TxtPrice)
        Me.PanelEntry.Controls.Add(Me.TxtCost)
        Me.PanelEntry.Controls.Add(Me.TxtGoodsName)
        Me.PanelEntry.Controls.Add(Me.BtnCancel)
        Me.PanelEntry.Controls.Add(Me.BtnExe)
        Me.PanelEntry.Controls.Add(Me.Label6)
        Me.PanelEntry.Controls.Add(Me.Label5)
        Me.PanelEntry.Controls.Add(Me.Label4)
        Me.PanelEntry.Controls.Add(Me.Label3)
        Me.PanelEntry.Controls.Add(Me.Label2)
        Me.PanelEntry.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PanelEntry.Location = New System.Drawing.Point(0, 102)
        Me.PanelEntry.Name = "PanelEntry"
        Me.PanelEntry.Size = New System.Drawing.Size(964, 134)
        Me.PanelEntry.TabIndex = 1
        '
        'CbMaker
        '
        Me.CbMaker.FormattingEnabled = True
        Me.CbMaker.Location = New System.Drawing.Point(85, 95)
        Me.CbMaker.Name = "CbMaker"
        Me.CbMaker.Size = New System.Drawing.Size(171, 25)
        Me.CbMaker.TabIndex = 17
        '
        'CbCategory
        '
        Me.CbCategory.FormattingEnabled = True
        Me.CbCategory.Location = New System.Drawing.Point(85, 50)
        Me.CbCategory.Name = "CbCategory"
        Me.CbCategory.Size = New System.Drawing.Size(171, 25)
        Me.CbCategory.TabIndex = 16
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
        'TxtRemarks
        '
        Me.TxtRemarks.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtRemarks.Location = New System.Drawing.Point(347, 92)
        Me.TxtRemarks.Name = "TxtRemarks"
        Me.TxtRemarks.Size = New System.Drawing.Size(406, 25)
        Me.TxtRemarks.TabIndex = 12
        Me.TxtRemarks.Tag = "y"
        '
        'TxtUnit
        '
        Me.TxtUnit.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtUnit.Location = New System.Drawing.Point(347, 50)
        Me.TxtUnit.Name = "TxtUnit"
        Me.TxtUnit.Size = New System.Drawing.Size(167, 25)
        Me.TxtUnit.TabIndex = 11
        Me.TxtUnit.Tag = "y"
        '
        'TxtPrice
        '
        Me.TxtPrice.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtPrice.Location = New System.Drawing.Point(347, 6)
        Me.TxtPrice.Name = "TxtPrice"
        Me.TxtPrice.Size = New System.Drawing.Size(167, 25)
        Me.TxtPrice.TabIndex = 10
        Me.TxtPrice.Tag = "y"
        '
        'TxtCost
        '
        Me.TxtCost.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtCost.Location = New System.Drawing.Point(584, 6)
        Me.TxtCost.Name = "TxtCost"
        Me.TxtCost.Size = New System.Drawing.Size(189, 25)
        Me.TxtCost.TabIndex = 9
        Me.TxtCost.Tag = "y"
        '
        'TxtGoodsName
        '
        Me.TxtGoodsName.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtGoodsName.Location = New System.Drawing.Point(85, 6)
        Me.TxtGoodsName.Name = "TxtGoodsName"
        Me.TxtGoodsName.Size = New System.Drawing.Size(171, 25)
        Me.TxtGoodsName.TabIndex = 8
        Me.TxtGoodsName.Tag = "y"
        '
        'BtnCancel
        '
        Me.BtnCancel.Location = New System.Drawing.Point(790, 83)
        Me.BtnCancel.Name = "BtnCancel"
        Me.BtnCancel.Size = New System.Drawing.Size(136, 29)
        Me.BtnCancel.TabIndex = 7
        Me.BtnCancel.Text = "キャンセル"
        Me.BtnCancel.UseVisualStyleBackColor = True
        '
        'BtnExe
        '
        Me.BtnExe.Location = New System.Drawing.Point(789, 12)
        Me.BtnExe.Name = "BtnExe"
        Me.BtnExe.Size = New System.Drawing.Size(137, 61)
        Me.BtnExe.TabIndex = 6
        Me.BtnExe.Text = "新規登録"
        Me.BtnExe.UseVisualStyleBackColor = True
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
        'PanelCustomerList
        '
        Me.PanelCustomerList.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.PanelCustomerList.Controls.Add(Me.CbCategoryList)
        Me.PanelCustomerList.Controls.Add(Me.Label7)
        Me.PanelCustomerList.Controls.Add(Me.BtnDelete)
        Me.PanelCustomerList.Controls.Add(Me.BtnUpdate)
        Me.PanelCustomerList.Controls.Add(Me.DgvList)
        Me.PanelCustomerList.Location = New System.Drawing.Point(0, 242)
        Me.PanelCustomerList.Name = "PanelCustomerList"
        Me.PanelCustomerList.Size = New System.Drawing.Size(964, 514)
        Me.PanelCustomerList.TabIndex = 2
        '
        'CbCategoryList
        '
        Me.CbCategoryList.FormattingEnabled = True
        Me.CbCategoryList.Location = New System.Drawing.Point(236, 14)
        Me.CbCategoryList.Name = "CbCategoryList"
        Me.CbCategoryList.Size = New System.Drawing.Size(236, 28)
        Me.CbCategoryList.TabIndex = 14
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(31, 18)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(164, 21)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "分類を指定してください"
        '
        'BtnDelete
        '
        Me.BtnDelete.Location = New System.Drawing.Point(795, 7)
        Me.BtnDelete.Name = "BtnDelete"
        Me.BtnDelete.Size = New System.Drawing.Size(131, 43)
        Me.BtnDelete.TabIndex = 12
        Me.BtnDelete.Text = "削除"
        Me.BtnDelete.UseVisualStyleBackColor = True
        '
        'BtnUpdate
        '
        Me.BtnUpdate.Location = New System.Drawing.Point(622, 7)
        Me.BtnUpdate.Name = "BtnUpdate"
        Me.BtnUpdate.Size = New System.Drawing.Size(131, 43)
        Me.BtnUpdate.TabIndex = 11
        Me.BtnUpdate.Text = "修正"
        Me.BtnUpdate.UseVisualStyleBackColor = True
        '
        'DgvList
        '
        Me.DgvList.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DgvList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvList.Location = New System.Drawing.Point(3, 63)
        Me.DgvList.Name = "DgvList"
        Me.DgvList.RowTemplate.Height = 27
        Me.DgvList.Size = New System.Drawing.Size(961, 448)
        Me.DgvList.TabIndex = 0
        '
        'fmGoodsMaster
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(968, 756)
        Me.Controls.Add(Me.PanelCustomerList)
        Me.Controls.Add(Me.PanelEntry)
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
        Me.PanelEntry.ResumeLayout(False)
        Me.PanelEntry.PerformLayout()
        Me.PanelCustomerList.ResumeLayout(False)
        Me.PanelCustomerList.PerformLayout()
        CType(Me.DgvList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents BtnClose As System.Windows.Forms.Button
    Friend WithEvents LblDate As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PanelEntry As System.Windows.Forms.Panel
    Friend WithEvents PanelCustomerList As System.Windows.Forms.Panel
    Friend WithEvents BtnEntry As System.Windows.Forms.Button
    Friend WithEvents TxtRemarks As System.Windows.Forms.TextBox
    Friend WithEvents TxtUnit As System.Windows.Forms.TextBox
    Friend WithEvents TxtPrice As System.Windows.Forms.TextBox
    Friend WithEvents TxtCost As System.Windows.Forms.TextBox
    Friend WithEvents TxtGoodsName As System.Windows.Forms.TextBox
    Friend WithEvents BtnCancel As System.Windows.Forms.Button
    Friend WithEvents BtnExe As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents BtnDelete As System.Windows.Forms.Button
    Friend WithEvents BtnUpdate As System.Windows.Forms.Button
    Friend WithEvents DgvList As System.Windows.Forms.DataGridView
    Friend WithEvents CbMaker As ComboBox
    Friend WithEvents CbCategory As ComboBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents CbCategoryList As ComboBox
    Friend WithEvents Label7 As Label
End Class
