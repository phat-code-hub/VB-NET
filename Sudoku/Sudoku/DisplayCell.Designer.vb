<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DisplayCell
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.LblNum = New System.Windows.Forms.Label()
        Me.ChkCell = New System.Windows.Forms.CheckBox()
        Me.SuspendLayout()
        '
        'LblNum
        '
        Me.LblNum.AutoSize = True
        Me.LblNum.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblNum.ForeColor = System.Drawing.Color.Red
        Me.LblNum.Location = New System.Drawing.Point(22, 58)
        Me.LblNum.Name = "LblNum"
        Me.LblNum.Size = New System.Drawing.Size(24, 27)
        Me.LblNum.TabIndex = 3
        Me.LblNum.Text = "8"
        '
        'ChkCell
        '
        Me.ChkCell.Appearance = System.Windows.Forms.Appearance.Button
        Me.ChkCell.AutoSize = True
        Me.ChkCell.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ChkCell.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.ChkCell.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.ChkCell.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ChkCell.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ChkCell.Font = New System.Drawing.Font("Times New Roman", 26.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkCell.Location = New System.Drawing.Point(3, 0)
        Me.ChkCell.Name = "ChkCell"
        Me.ChkCell.Size = New System.Drawing.Size(61, 70)
        Me.ChkCell.TabIndex = 4
        Me.ChkCell.Text = "1"
        Me.ChkCell.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ChkCell.UseVisualStyleBackColor = True
        '
        'DisplayCell
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.LblNum)
        Me.Controls.Add(Me.ChkCell)
        Me.Name = "DisplayCell"
        Me.Size = New System.Drawing.Size(73, 100)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LblNum As System.Windows.Forms.Label
    Friend WithEvents ChkCell As System.Windows.Forms.CheckBox

End Class
