<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FmCustomerMaster
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
        Me.TxtFAX = New System.Windows.Forms.TextBox()
        Me.TxtTEL = New System.Windows.Forms.TextBox()
        Me.TxtAddress = New System.Windows.Forms.TextBox()
        Me.TxtPost = New System.Windows.Forms.TextBox()
        Me.TxtFurigana = New System.Windows.Forms.TextBox()
        Me.TxtCustomerName = New System.Windows.Forms.TextBox()
        Me.BtnCancel = New System.Windows.Forms.Button()
        Me.BtnExe = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PanelCustomerList = New System.Windows.Forms.Panel()
        Me.BtnDelete = New System.Windows.Forms.Button()
        Me.BtnUpdate = New System.Windows.Forms.Button()
        Me.BtnWA = New System.Windows.Forms.Button()
        Me.BtnRA = New System.Windows.Forms.Button()
        Me.BtnYA = New System.Windows.Forms.Button()
        Me.BtnMA = New System.Windows.Forms.Button()
        Me.BtnHA = New System.Windows.Forms.Button()
        Me.BtnNA = New System.Windows.Forms.Button()
        Me.BtnTA = New System.Windows.Forms.Button()
        Me.BtnSA = New System.Windows.Forms.Button()
        Me.BtnKA = New System.Windows.Forms.Button()
        Me.BtnA = New System.Windows.Forms.Button()
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
        Me.Label1.Text = "顧客マスタ"
        '
        'PanelEntry
        '
        Me.PanelEntry.BackColor = System.Drawing.Color.LemonChiffon
        Me.PanelEntry.Controls.Add(Me.TxtFAX)
        Me.PanelEntry.Controls.Add(Me.TxtTEL)
        Me.PanelEntry.Controls.Add(Me.TxtAddress)
        Me.PanelEntry.Controls.Add(Me.TxtPost)
        Me.PanelEntry.Controls.Add(Me.TxtFurigana)
        Me.PanelEntry.Controls.Add(Me.TxtCustomerName)
        Me.PanelEntry.Controls.Add(Me.BtnCancel)
        Me.PanelEntry.Controls.Add(Me.BtnExe)
        Me.PanelEntry.Controls.Add(Me.Label7)
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
        'TxtFAX
        '
        Me.TxtFAX.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtFAX.Location = New System.Drawing.Point(584, 80)
        Me.TxtFAX.Name = "TxtFAX"
        Me.TxtFAX.Size = New System.Drawing.Size(167, 25)
        Me.TxtFAX.TabIndex = 13
        Me.TxtFAX.Tag = "y"
        '
        'TxtTEL
        '
        Me.TxtTEL.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtTEL.Location = New System.Drawing.Point(347, 78)
        Me.TxtTEL.Name = "TxtTEL"
        Me.TxtTEL.Size = New System.Drawing.Size(167, 25)
        Me.TxtTEL.TabIndex = 12
        Me.TxtTEL.Tag = "y"
        '
        'TxtAddress
        '
        Me.TxtAddress.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtAddress.Location = New System.Drawing.Point(347, 40)
        Me.TxtAddress.Name = "TxtAddress"
        Me.TxtAddress.Size = New System.Drawing.Size(404, 25)
        Me.TxtAddress.TabIndex = 11
        Me.TxtAddress.Tag = "y"
        '
        'TxtPost
        '
        Me.TxtPost.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtPost.Location = New System.Drawing.Point(347, 6)
        Me.TxtPost.Name = "TxtPost"
        Me.TxtPost.Size = New System.Drawing.Size(167, 25)
        Me.TxtPost.TabIndex = 10
        Me.TxtPost.Tag = "y"
        '
        'TxtFurigana
        '
        Me.TxtFurigana.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtFurigana.Location = New System.Drawing.Point(85, 45)
        Me.TxtFurigana.Name = "TxtFurigana"
        Me.TxtFurigana.Size = New System.Drawing.Size(189, 25)
        Me.TxtFurigana.TabIndex = 9
        Me.TxtFurigana.Tag = "y"
        '
        'TxtCustomerName
        '
        Me.TxtCustomerName.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtCustomerName.Location = New System.Drawing.Point(85, 6)
        Me.TxtCustomerName.Name = "TxtCustomerName"
        Me.TxtCustomerName.Size = New System.Drawing.Size(189, 25)
        Me.TxtCustomerName.TabIndex = 8
        Me.TxtCustomerName.Tag = "y"
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
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(520, 83)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(36, 17)
        Me.Label7.TabIndex = 5
        Me.Label7.Text = "FAX"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(286, 86)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(35, 17)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "TEL"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(286, 49)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(36, 17)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "住所"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(286, 10)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(22, 17)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "〒"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(21, 49)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(47, 17)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "フリガナ"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(21, 10)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(50, 17)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "顧客名"
        '
        'PanelCustomerList
        '
        Me.PanelCustomerList.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.PanelCustomerList.Controls.Add(Me.BtnDelete)
        Me.PanelCustomerList.Controls.Add(Me.BtnUpdate)
        Me.PanelCustomerList.Controls.Add(Me.BtnWA)
        Me.PanelCustomerList.Controls.Add(Me.BtnRA)
        Me.PanelCustomerList.Controls.Add(Me.BtnYA)
        Me.PanelCustomerList.Controls.Add(Me.BtnMA)
        Me.PanelCustomerList.Controls.Add(Me.BtnHA)
        Me.PanelCustomerList.Controls.Add(Me.BtnNA)
        Me.PanelCustomerList.Controls.Add(Me.BtnTA)
        Me.PanelCustomerList.Controls.Add(Me.BtnSA)
        Me.PanelCustomerList.Controls.Add(Me.BtnKA)
        Me.PanelCustomerList.Controls.Add(Me.BtnA)
        Me.PanelCustomerList.Controls.Add(Me.DgvList)
        Me.PanelCustomerList.Location = New System.Drawing.Point(0, 242)
        Me.PanelCustomerList.Name = "PanelCustomerList"
        Me.PanelCustomerList.Size = New System.Drawing.Size(964, 514)
        Me.PanelCustomerList.TabIndex = 2
        '
        'BtnDelete
        '
        Me.BtnDelete.Location = New System.Drawing.Point(795, 14)
        Me.BtnDelete.Name = "BtnDelete"
        Me.BtnDelete.Size = New System.Drawing.Size(131, 43)
        Me.BtnDelete.TabIndex = 12
        Me.BtnDelete.Text = "削除"
        Me.BtnDelete.UseVisualStyleBackColor = True
        '
        'BtnUpdate
        '
        Me.BtnUpdate.Location = New System.Drawing.Point(622, 14)
        Me.BtnUpdate.Name = "BtnUpdate"
        Me.BtnUpdate.Size = New System.Drawing.Size(131, 43)
        Me.BtnUpdate.TabIndex = 11
        Me.BtnUpdate.Text = "修正"
        Me.BtnUpdate.UseVisualStyleBackColor = True
        '
        'BtnWA
        '
        Me.BtnWA.Location = New System.Drawing.Point(548, 14)
        Me.BtnWA.Name = "BtnWA"
        Me.BtnWA.Size = New System.Drawing.Size(50, 37)
        Me.BtnWA.TabIndex = 10
        Me.BtnWA.Tag = "わ-を"
        Me.BtnWA.Text = "わ"
        Me.BtnWA.UseVisualStyleBackColor = True
        '
        'BtnRA
        '
        Me.BtnRA.Location = New System.Drawing.Point(478, 14)
        Me.BtnRA.Name = "BtnRA"
        Me.BtnRA.Size = New System.Drawing.Size(50, 37)
        Me.BtnRA.TabIndex = 9
        Me.BtnRA.Tag = "ら-ろ"
        Me.BtnRA.Text = "ら"
        Me.BtnRA.UseVisualStyleBackColor = True
        '
        'BtnYA
        '
        Me.BtnYA.Location = New System.Drawing.Point(416, 14)
        Me.BtnYA.Name = "BtnYA"
        Me.BtnYA.Size = New System.Drawing.Size(50, 37)
        Me.BtnYA.TabIndex = 8
        Me.BtnYA.Tag = "や-よ"
        Me.BtnYA.Text = "や"
        Me.BtnYA.UseVisualStyleBackColor = True
        '
        'BtnMA
        '
        Me.BtnMA.Location = New System.Drawing.Point(358, 14)
        Me.BtnMA.Name = "BtnMA"
        Me.BtnMA.Size = New System.Drawing.Size(50, 37)
        Me.BtnMA.TabIndex = 7
        Me.BtnMA.Tag = "ま-も"
        Me.BtnMA.Text = "ま"
        Me.BtnMA.UseVisualStyleBackColor = True
        '
        'BtnHA
        '
        Me.BtnHA.Location = New System.Drawing.Point(299, 14)
        Me.BtnHA.Name = "BtnHA"
        Me.BtnHA.Size = New System.Drawing.Size(50, 37)
        Me.BtnHA.TabIndex = 6
        Me.BtnHA.Tag = "は-ほ"
        Me.BtnHA.Text = "は"
        Me.BtnHA.UseVisualStyleBackColor = True
        '
        'BtnNA
        '
        Me.BtnNA.Location = New System.Drawing.Point(244, 14)
        Me.BtnNA.Name = "BtnNA"
        Me.BtnNA.Size = New System.Drawing.Size(50, 37)
        Me.BtnNA.TabIndex = 5
        Me.BtnNA.Tag = "な-の"
        Me.BtnNA.Text = "な"
        Me.BtnNA.UseVisualStyleBackColor = True
        '
        'BtnTA
        '
        Me.BtnTA.Location = New System.Drawing.Point(188, 14)
        Me.BtnTA.Name = "BtnTA"
        Me.BtnTA.Size = New System.Drawing.Size(50, 37)
        Me.BtnTA.TabIndex = 4
        Me.BtnTA.Tag = "た-と"
        Me.BtnTA.Text = "た"
        Me.BtnTA.UseVisualStyleBackColor = True
        '
        'BtnSA
        '
        Me.BtnSA.Location = New System.Drawing.Point(132, 14)
        Me.BtnSA.Name = "BtnSA"
        Me.BtnSA.Size = New System.Drawing.Size(50, 37)
        Me.BtnSA.TabIndex = 3
        Me.BtnSA.Tag = "さ-そ"
        Me.BtnSA.Text = "さ"
        Me.BtnSA.UseVisualStyleBackColor = True
        '
        'BtnKA
        '
        Me.BtnKA.Location = New System.Drawing.Point(68, 14)
        Me.BtnKA.Name = "BtnKA"
        Me.BtnKA.Size = New System.Drawing.Size(51, 37)
        Me.BtnKA.TabIndex = 2
        Me.BtnKA.Tag = "か-こ"
        Me.BtnKA.Text = "か"
        Me.BtnKA.UseVisualStyleBackColor = True
        '
        'BtnA
        '
        Me.BtnA.Location = New System.Drawing.Point(10, 14)
        Me.BtnA.Name = "BtnA"
        Me.BtnA.Size = New System.Drawing.Size(50, 37)
        Me.BtnA.TabIndex = 1
        Me.BtnA.Tag = "あ-お"
        Me.BtnA.Text = "あ"
        Me.BtnA.UseVisualStyleBackColor = True
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
        'FmCustomerMaster
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(963, 756)
        Me.Controls.Add(Me.PanelCustomerList)
        Me.Controls.Add(Me.PanelEntry)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Times New Roman", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FmCustomerMaster"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "売上管理システム"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.PanelEntry.ResumeLayout(False)
        Me.PanelEntry.PerformLayout()
        Me.PanelCustomerList.ResumeLayout(False)
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
    Friend WithEvents TxtTEL As System.Windows.Forms.TextBox
    Friend WithEvents TxtAddress As System.Windows.Forms.TextBox
    Friend WithEvents TxtPost As System.Windows.Forms.TextBox
    Friend WithEvents TxtFurigana As System.Windows.Forms.TextBox
    Friend WithEvents TxtCustomerName As System.Windows.Forms.TextBox
    Friend WithEvents BtnCancel As System.Windows.Forms.Button
    Friend WithEvents BtnExe As System.Windows.Forms.Button
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TxtFAX As System.Windows.Forms.TextBox
    Friend WithEvents BtnDelete As System.Windows.Forms.Button
    Friend WithEvents BtnUpdate As System.Windows.Forms.Button
    Friend WithEvents BtnWA As System.Windows.Forms.Button
    Friend WithEvents BtnRA As System.Windows.Forms.Button
    Friend WithEvents BtnYA As System.Windows.Forms.Button
    Friend WithEvents BtnMA As System.Windows.Forms.Button
    Friend WithEvents BtnHA As System.Windows.Forms.Button
    Friend WithEvents BtnNA As System.Windows.Forms.Button
    Friend WithEvents BtnTA As System.Windows.Forms.Button
    Friend WithEvents BtnSA As System.Windows.Forms.Button
    Friend WithEvents BtnKA As System.Windows.Forms.Button
    Friend WithEvents BtnA As System.Windows.Forms.Button
    Friend WithEvents DgvList As System.Windows.Forms.DataGridView
End Class
