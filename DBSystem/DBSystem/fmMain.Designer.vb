﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FmMain
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
        Me.LblLogInMessage = New System.Windows.Forms.Label()
        Me.BtnQuit = New System.Windows.Forms.Button()
        Me.BtnOption = New System.Windows.Forms.Button()
        Me.BtnNewSlip = New System.Windows.Forms.Button()
        Me.LbDate = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.MistyRose
        Me.Panel1.Controls.Add(Me.LblLogInMessage)
        Me.Panel1.Controls.Add(Me.BtnQuit)
        Me.Panel1.Controls.Add(Me.BtnOption)
        Me.Panel1.Controls.Add(Me.BtnNewSlip)
        Me.Panel1.Controls.Add(Me.LbDate)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1174, 130)
        Me.Panel1.TabIndex = 0
        '
        'LblLogInMessage
        '
        Me.LblLogInMessage.AutoSize = True
        Me.LblLogInMessage.Font = New System.Drawing.Font("Times New Roman", 10.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblLogInMessage.ForeColor = System.Drawing.Color.Gray
        Me.LblLogInMessage.Location = New System.Drawing.Point(38, 85)
        Me.LblLogInMessage.Name = "LblLogInMessage"
        Me.LblLogInMessage.Size = New System.Drawing.Size(75, 19)
        Me.LblLogInMessage.TabIndex = 5
        Me.LblLogInMessage.Text = "User Info"
        '
        'BtnQuit
        '
        Me.BtnQuit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.BtnQuit.Location = New System.Drawing.Point(1023, 85)
        Me.BtnQuit.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnQuit.Name = "BtnQuit"
        Me.BtnQuit.Size = New System.Drawing.Size(90, 32)
        Me.BtnQuit.TabIndex = 4
        Me.BtnQuit.Text = "終了"
        Me.BtnQuit.UseVisualStyleBackColor = True
        '
        'BtnOption
        '
        Me.BtnOption.Location = New System.Drawing.Point(872, 85)
        Me.BtnOption.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnOption.Name = "BtnOption"
        Me.BtnOption.Size = New System.Drawing.Size(128, 32)
        Me.BtnOption.TabIndex = 3
        Me.BtnOption.Text = "オプション"
        Me.BtnOption.UseVisualStyleBackColor = True
        '
        'BtnNewSlip
        '
        Me.BtnNewSlip.Location = New System.Drawing.Point(713, 85)
        Me.BtnNewSlip.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnNewSlip.Name = "BtnNewSlip"
        Me.BtnNewSlip.Size = New System.Drawing.Size(137, 32)
        Me.BtnNewSlip.TabIndex = 2
        Me.BtnNewSlip.Text = "新規設定"
        Me.BtnNewSlip.UseVisualStyleBackColor = True
        '
        'LbDate
        '
        Me.LbDate.Font = New System.Drawing.Font("Meiryo UI", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbDate.Location = New System.Drawing.Point(987, 36)
        Me.LbDate.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LbDate.Name = "LbDate"
        Me.LbDate.Size = New System.Drawing.Size(126, 23)
        Me.LbDate.TabIndex = 1
        Me.LbDate.Text = "---"
        Me.LbDate.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Red
        Me.Label1.Location = New System.Drawing.Point(30, 27)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(261, 38)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "売上管理システム"
        '
        'FmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.BtnQuit
        Me.ClientSize = New System.Drawing.Size(1174, 756)
        Me.ControlBox = False
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Times New Roman", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "売上管理システム"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents BtnQuit As System.Windows.Forms.Button
    Friend WithEvents BtnOption As System.Windows.Forms.Button
    Friend WithEvents BtnNewSlip As System.Windows.Forms.Button
    Friend WithEvents LbDate As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents LblLogInMessage As System.Windows.Forms.Label
End Class
