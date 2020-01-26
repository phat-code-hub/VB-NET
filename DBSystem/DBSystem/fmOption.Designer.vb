<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FmOption
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
        Me.LblDate = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BtnGoodMaster = New System.Windows.Forms.Button()
        Me.BtnMonthlyProcess = New System.Windows.Forms.Button()
        Me.BtnCustomerMaster = New System.Windows.Forms.Button()
        Me.BtnPrintBill = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.MistyRose
        Me.Panel1.Controls.Add(Me.BtnClose)
        Me.Panel1.Controls.Add(Me.LblDate)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1174, 140)
        Me.Panel1.TabIndex = 0
        '
        'BtnClose
        '
        Me.BtnClose.Location = New System.Drawing.Point(992, 83)
        Me.BtnClose.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnClose.Name = "BtnClose"
        Me.BtnClose.Size = New System.Drawing.Size(90, 32)
        Me.BtnClose.TabIndex = 2
        Me.BtnClose.Text = "閉じる"
        Me.BtnClose.UseVisualStyleBackColor = True
        '
        'LblDate
        '
        Me.LblDate.AutoSize = True
        Me.LblDate.Location = New System.Drawing.Point(1020, 31)
        Me.LblDate.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblDate.Name = "LblDate"
        Me.LblDate.Size = New System.Drawing.Size(28, 21)
        Me.LblDate.TabIndex = 1
        Me.LblDate.Text = "---"
        Me.LblDate.TextAlign = System.Drawing.ContentAlignment.MiddleRight
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
        'BtnGoodMaster
        '
        Me.BtnGoodMaster.Location = New System.Drawing.Point(107, 199)
        Me.BtnGoodMaster.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnGoodMaster.Name = "BtnGoodMaster"
        Me.BtnGoodMaster.Size = New System.Drawing.Size(163, 190)
        Me.BtnGoodMaster.TabIndex = 1
        Me.BtnGoodMaster.Text = "商品マスタ"
        Me.BtnGoodMaster.UseVisualStyleBackColor = True
        '
        'BtnMonthlyProcess
        '
        Me.BtnMonthlyProcess.Location = New System.Drawing.Point(467, 199)
        Me.BtnMonthlyProcess.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnMonthlyProcess.Name = "BtnMonthlyProcess"
        Me.BtnMonthlyProcess.Size = New System.Drawing.Size(163, 190)
        Me.BtnMonthlyProcess.TabIndex = 2
        Me.BtnMonthlyProcess.Text = "月次処理"
        Me.BtnMonthlyProcess.UseVisualStyleBackColor = True
        '
        'BtnCustomerMaster
        '
        Me.BtnCustomerMaster.Location = New System.Drawing.Point(107, 450)
        Me.BtnCustomerMaster.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnCustomerMaster.Name = "BtnCustomerMaster"
        Me.BtnCustomerMaster.Size = New System.Drawing.Size(163, 190)
        Me.BtnCustomerMaster.TabIndex = 3
        Me.BtnCustomerMaster.Text = "顧客マスタ"
        Me.BtnCustomerMaster.UseVisualStyleBackColor = True
        '
        'BtnPrintBill
        '
        Me.BtnPrintBill.Location = New System.Drawing.Point(467, 450)
        Me.BtnPrintBill.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnPrintBill.Name = "BtnPrintBill"
        Me.BtnPrintBill.Size = New System.Drawing.Size(163, 190)
        Me.BtnPrintBill.TabIndex = 4
        Me.BtnPrintBill.Text = "請求書の印刷"
        Me.BtnPrintBill.UseVisualStyleBackColor = True
        '
        'FmOption
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1174, 756)
        Me.Controls.Add(Me.BtnPrintBill)
        Me.Controls.Add(Me.BtnCustomerMaster)
        Me.Controls.Add(Me.BtnMonthlyProcess)
        Me.Controls.Add(Me.BtnGoodMaster)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Times New Roman", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FmOption"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "売上管理システム"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents BtnClose As System.Windows.Forms.Button
    Friend WithEvents LblDate As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents BtnGoodMaster As System.Windows.Forms.Button
    Friend WithEvents BtnMonthlyProcess As System.Windows.Forms.Button
    Friend WithEvents BtnCustomerMaster As System.Windows.Forms.Button
    Friend WithEvents BtnPrintBill As System.Windows.Forms.Button
End Class
