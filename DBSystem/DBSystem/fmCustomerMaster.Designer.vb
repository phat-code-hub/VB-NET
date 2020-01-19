<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class fmCustomerMaster
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
        Me.txtFAX = New System.Windows.Forms.TextBox()
        Me.txtTEL = New System.Windows.Forms.TextBox()
        Me.txtAddress = New System.Windows.Forms.TextBox()
        Me.txtPost = New System.Windows.Forms.TextBox()
        Me.txtFurigana = New System.Windows.Forms.TextBox()
        Me.txtCustomerName = New System.Windows.Forms.TextBox()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnExe = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.panelCustomerList = New System.Windows.Forms.Panel()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnWA = New System.Windows.Forms.Button()
        Me.btnRA = New System.Windows.Forms.Button()
        Me.btnYA = New System.Windows.Forms.Button()
        Me.btnMA = New System.Windows.Forms.Button()
        Me.btnHA = New System.Windows.Forms.Button()
        Me.btnNA = New System.Windows.Forms.Button()
        Me.btnTA = New System.Windows.Forms.Button()
        Me.btnSA = New System.Windows.Forms.Button()
        Me.btnKA = New System.Windows.Forms.Button()
        Me.btnA = New System.Windows.Forms.Button()
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
        Me.lblDate.Size = New System.Drawing.Size(33, 25)
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
        Me.Label1.Size = New System.Drawing.Size(203, 40)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "顧客マスタ"
        '
        'panelEntry
        '
        Me.panelEntry.BackColor = System.Drawing.Color.LemonChiffon
        Me.panelEntry.Controls.Add(Me.txtFAX)
        Me.panelEntry.Controls.Add(Me.txtTEL)
        Me.panelEntry.Controls.Add(Me.txtAddress)
        Me.panelEntry.Controls.Add(Me.txtPost)
        Me.panelEntry.Controls.Add(Me.txtFurigana)
        Me.panelEntry.Controls.Add(Me.txtCustomerName)
        Me.panelEntry.Controls.Add(Me.btnCancel)
        Me.panelEntry.Controls.Add(Me.btnExe)
        Me.panelEntry.Controls.Add(Me.Label7)
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
        'txtFAX
        '
        Me.txtFAX.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFAX.Location = New System.Drawing.Point(584, 80)
        Me.txtFAX.Name = "txtFAX"
        Me.txtFAX.Size = New System.Drawing.Size(167, 28)
        Me.txtFAX.TabIndex = 13
        Me.txtFAX.Tag = "y"
        '
        'txtTEL
        '
        Me.txtTEL.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTEL.Location = New System.Drawing.Point(347, 78)
        Me.txtTEL.Name = "txtTEL"
        Me.txtTEL.Size = New System.Drawing.Size(167, 28)
        Me.txtTEL.TabIndex = 12
        Me.txtTEL.Tag = "y"
        '
        'txtAddress
        '
        Me.txtAddress.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAddress.Location = New System.Drawing.Point(347, 40)
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Size = New System.Drawing.Size(404, 28)
        Me.txtAddress.TabIndex = 11
        Me.txtAddress.Tag = "y"
        '
        'txtPost
        '
        Me.txtPost.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPost.Location = New System.Drawing.Point(347, 6)
        Me.txtPost.Name = "txtPost"
        Me.txtPost.Size = New System.Drawing.Size(167, 28)
        Me.txtPost.TabIndex = 10
        Me.txtPost.Tag = "y"
        '
        'txtFurigana
        '
        Me.txtFurigana.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFurigana.Location = New System.Drawing.Point(85, 45)
        Me.txtFurigana.Name = "txtFurigana"
        Me.txtFurigana.Size = New System.Drawing.Size(189, 28)
        Me.txtFurigana.TabIndex = 9
        Me.txtFurigana.Tag = "y"
        '
        'txtCustomerName
        '
        Me.txtCustomerName.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCustomerName.Location = New System.Drawing.Point(85, 6)
        Me.txtCustomerName.Name = "txtCustomerName"
        Me.txtCustomerName.Size = New System.Drawing.Size(189, 28)
        Me.txtCustomerName.TabIndex = 8
        Me.txtCustomerName.Tag = "y"
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
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(520, 83)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(43, 20)
        Me.Label7.TabIndex = 5
        Me.Label7.Text = "FAX"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(286, 86)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(43, 20)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "TEL"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(286, 49)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(41, 20)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "住所"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(286, 10)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(25, 20)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "〒"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(21, 49)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(55, 20)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "フリガナ"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(21, 10)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(57, 20)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "顧客名"
        '
        'panelCustomerList
        '
        Me.panelCustomerList.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.panelCustomerList.Controls.Add(Me.btnDelete)
        Me.panelCustomerList.Controls.Add(Me.btnUpdate)
        Me.panelCustomerList.Controls.Add(Me.btnWA)
        Me.panelCustomerList.Controls.Add(Me.btnRA)
        Me.panelCustomerList.Controls.Add(Me.btnYA)
        Me.panelCustomerList.Controls.Add(Me.btnMA)
        Me.panelCustomerList.Controls.Add(Me.btnHA)
        Me.panelCustomerList.Controls.Add(Me.btnNA)
        Me.panelCustomerList.Controls.Add(Me.btnTA)
        Me.panelCustomerList.Controls.Add(Me.btnSA)
        Me.panelCustomerList.Controls.Add(Me.btnKA)
        Me.panelCustomerList.Controls.Add(Me.btnA)
        Me.panelCustomerList.Controls.Add(Me.dgvList)
        Me.panelCustomerList.Location = New System.Drawing.Point(0, 242)
        Me.panelCustomerList.Name = "panelCustomerList"
        Me.panelCustomerList.Size = New System.Drawing.Size(964, 514)
        Me.panelCustomerList.TabIndex = 2
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
        'btnWA
        '
        Me.btnWA.Location = New System.Drawing.Point(548, 14)
        Me.btnWA.Name = "btnWA"
        Me.btnWA.Size = New System.Drawing.Size(50, 37)
        Me.btnWA.TabIndex = 10
        Me.btnWA.Tag = "わ-を"
        Me.btnWA.Text = "わ"
        Me.btnWA.UseVisualStyleBackColor = True
        '
        'btnRA
        '
        Me.btnRA.Location = New System.Drawing.Point(478, 14)
        Me.btnRA.Name = "btnRA"
        Me.btnRA.Size = New System.Drawing.Size(50, 37)
        Me.btnRA.TabIndex = 9
        Me.btnRA.Tag = "ら-ろ"
        Me.btnRA.Text = "ら"
        Me.btnRA.UseVisualStyleBackColor = True
        '
        'btnYA
        '
        Me.btnYA.Location = New System.Drawing.Point(416, 14)
        Me.btnYA.Name = "btnYA"
        Me.btnYA.Size = New System.Drawing.Size(50, 37)
        Me.btnYA.TabIndex = 8
        Me.btnYA.Tag = "や-よ"
        Me.btnYA.Text = "や"
        Me.btnYA.UseVisualStyleBackColor = True
        '
        'btnMA
        '
        Me.btnMA.Location = New System.Drawing.Point(358, 14)
        Me.btnMA.Name = "btnMA"
        Me.btnMA.Size = New System.Drawing.Size(50, 37)
        Me.btnMA.TabIndex = 7
        Me.btnMA.Tag = "ま-も"
        Me.btnMA.Text = "ま"
        Me.btnMA.UseVisualStyleBackColor = True
        '
        'btnHA
        '
        Me.btnHA.Location = New System.Drawing.Point(299, 14)
        Me.btnHA.Name = "btnHA"
        Me.btnHA.Size = New System.Drawing.Size(50, 37)
        Me.btnHA.TabIndex = 6
        Me.btnHA.Tag = "は-ほ"
        Me.btnHA.Text = "は"
        Me.btnHA.UseVisualStyleBackColor = True
        '
        'btnNA
        '
        Me.btnNA.Location = New System.Drawing.Point(244, 14)
        Me.btnNA.Name = "btnNA"
        Me.btnNA.Size = New System.Drawing.Size(50, 37)
        Me.btnNA.TabIndex = 5
        Me.btnNA.Tag = "な-の"
        Me.btnNA.Text = "な"
        Me.btnNA.UseVisualStyleBackColor = True
        '
        'btnTA
        '
        Me.btnTA.Location = New System.Drawing.Point(188, 14)
        Me.btnTA.Name = "btnTA"
        Me.btnTA.Size = New System.Drawing.Size(50, 37)
        Me.btnTA.TabIndex = 4
        Me.btnTA.Tag = "た-と"
        Me.btnTA.Text = "た"
        Me.btnTA.UseVisualStyleBackColor = True
        '
        'btnSA
        '
        Me.btnSA.Location = New System.Drawing.Point(132, 14)
        Me.btnSA.Name = "btnSA"
        Me.btnSA.Size = New System.Drawing.Size(50, 37)
        Me.btnSA.TabIndex = 3
        Me.btnSA.Tag = "さ-そ"
        Me.btnSA.Text = "さ"
        Me.btnSA.UseVisualStyleBackColor = True
        '
        'btnKA
        '
        Me.btnKA.Location = New System.Drawing.Point(68, 14)
        Me.btnKA.Name = "btnKA"
        Me.btnKA.Size = New System.Drawing.Size(51, 37)
        Me.btnKA.TabIndex = 2
        Me.btnKA.Tag = "か-こ"
        Me.btnKA.Text = "か"
        Me.btnKA.UseVisualStyleBackColor = True
        '
        'btnA
        '
        Me.btnA.Location = New System.Drawing.Point(10, 14)
        Me.btnA.Name = "btnA"
        Me.btnA.Size = New System.Drawing.Size(50, 37)
        Me.btnA.TabIndex = 1
        Me.btnA.Tag = "あ-お"
        Me.btnA.Text = "あ"
        Me.btnA.UseVisualStyleBackColor = True
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
        'fmCustomerMaster
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(963, 756)
        Me.Controls.Add(Me.panelCustomerList)
        Me.Controls.Add(Me.panelEntry)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Times New Roman", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "fmCustomerMaster"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "売上管理システム"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.panelEntry.ResumeLayout(False)
        Me.panelEntry.PerformLayout()
        Me.panelCustomerList.ResumeLayout(False)
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
    Friend WithEvents txtTEL As System.Windows.Forms.TextBox
    Friend WithEvents txtAddress As System.Windows.Forms.TextBox
    Friend WithEvents txtPost As System.Windows.Forms.TextBox
    Friend WithEvents txtFurigana As System.Windows.Forms.TextBox
    Friend WithEvents txtCustomerName As System.Windows.Forms.TextBox
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents btnExe As System.Windows.Forms.Button
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtFAX As System.Windows.Forms.TextBox
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents btnUpdate As System.Windows.Forms.Button
    Friend WithEvents btnWA As System.Windows.Forms.Button
    Friend WithEvents btnRA As System.Windows.Forms.Button
    Friend WithEvents btnYA As System.Windows.Forms.Button
    Friend WithEvents btnMA As System.Windows.Forms.Button
    Friend WithEvents btnHA As System.Windows.Forms.Button
    Friend WithEvents btnNA As System.Windows.Forms.Button
    Friend WithEvents btnTA As System.Windows.Forms.Button
    Friend WithEvents btnSA As System.Windows.Forms.Button
    Friend WithEvents btnKA As System.Windows.Forms.Button
    Friend WithEvents btnA As System.Windows.Forms.Button
    Friend WithEvents dgvList As System.Windows.Forms.DataGridView
End Class
