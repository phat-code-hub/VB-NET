<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class fmOption
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
        Me.lblDate = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnGoodMaster = New System.Windows.Forms.Button()
        Me.btnMonthlyProcess = New System.Windows.Forms.Button()
        Me.btnCustomerMaster = New System.Windows.Forms.Button()
        Me.btnPrintBill = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.MistyRose
        Me.Panel1.Controls.Add(Me.btnClose)
        Me.Panel1.Controls.Add(Me.lblDate)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1174, 140)
        Me.Panel1.TabIndex = 0
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(992, 83)
        Me.btnClose.Margin = New System.Windows.Forms.Padding(4)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(90, 32)
        Me.btnClose.TabIndex = 2
        Me.btnClose.Text = "閉じる"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'lblDate
        '
        Me.lblDate.AutoSize = True
        Me.lblDate.Location = New System.Drawing.Point(1020, 31)
        Me.lblDate.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(28, 21)
        Me.lblDate.TabIndex = 1
        Me.lblDate.Text = "---"
        Me.lblDate.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(29, 32)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(91, 27)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "オプション"
        '
        'btnGoodMaster
        '
        Me.btnGoodMaster.Location = New System.Drawing.Point(107, 199)
        Me.btnGoodMaster.Margin = New System.Windows.Forms.Padding(4)
        Me.btnGoodMaster.Name = "btnGoodMaster"
        Me.btnGoodMaster.Size = New System.Drawing.Size(163, 190)
        Me.btnGoodMaster.TabIndex = 1
        Me.btnGoodMaster.Text = "商品マスタ"
        Me.btnGoodMaster.UseVisualStyleBackColor = True
        '
        'btnMonthlyProcess
        '
        Me.btnMonthlyProcess.Location = New System.Drawing.Point(467, 199)
        Me.btnMonthlyProcess.Margin = New System.Windows.Forms.Padding(4)
        Me.btnMonthlyProcess.Name = "btnMonthlyProcess"
        Me.btnMonthlyProcess.Size = New System.Drawing.Size(163, 190)
        Me.btnMonthlyProcess.TabIndex = 2
        Me.btnMonthlyProcess.Text = "月次処理"
        Me.btnMonthlyProcess.UseVisualStyleBackColor = True
        '
        'btnCustomerMaster
        '
        Me.btnCustomerMaster.Location = New System.Drawing.Point(107, 450)
        Me.btnCustomerMaster.Margin = New System.Windows.Forms.Padding(4)
        Me.btnCustomerMaster.Name = "btnCustomerMaster"
        Me.btnCustomerMaster.Size = New System.Drawing.Size(163, 190)
        Me.btnCustomerMaster.TabIndex = 3
        Me.btnCustomerMaster.Text = "顧客マスタ"
        Me.btnCustomerMaster.UseVisualStyleBackColor = True
        '
        'btnPrintBill
        '
        Me.btnPrintBill.Location = New System.Drawing.Point(467, 450)
        Me.btnPrintBill.Margin = New System.Windows.Forms.Padding(4)
        Me.btnPrintBill.Name = "btnPrintBill"
        Me.btnPrintBill.Size = New System.Drawing.Size(163, 190)
        Me.btnPrintBill.TabIndex = 4
        Me.btnPrintBill.Text = "請求書の印刷"
        Me.btnPrintBill.UseVisualStyleBackColor = True
        '
        'fmOption
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1174, 756)
        Me.Controls.Add(Me.btnPrintBill)
        Me.Controls.Add(Me.btnCustomerMaster)
        Me.Controls.Add(Me.btnMonthlyProcess)
        Me.Controls.Add(Me.btnGoodMaster)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Times New Roman", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "fmOption"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "売上管理システム"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents lblDate As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnGoodMaster As System.Windows.Forms.Button
    Friend WithEvents btnMonthlyProcess As System.Windows.Forms.Button
    Friend WithEvents btnCustomerMaster As System.Windows.Forms.Button
    Friend WithEvents btnPrintBill As System.Windows.Forms.Button
End Class
