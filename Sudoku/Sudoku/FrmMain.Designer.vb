<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Me.components = New System.ComponentModel.Container()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.BtnEnd = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.ChkShowHint = New System.Windows.Forms.CheckBox()
        Me.LblHint = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.ChkHint = New System.Windows.Forms.CheckBox()
        Me.CheckBox9 = New System.Windows.Forms.CheckBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.CheckBox8 = New System.Windows.Forms.CheckBox()
        Me.CheckBox7 = New System.Windows.Forms.CheckBox()
        Me.CheckBox6 = New System.Windows.Forms.CheckBox()
        Me.CheckBox5 = New System.Windows.Forms.CheckBox()
        Me.CheckBox4 = New System.Windows.Forms.CheckBox()
        Me.CheckBox3 = New System.Windows.Forms.CheckBox()
        Me.CheckBox2 = New System.Windows.Forms.CheckBox()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.NuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Num2ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Num3ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Num4ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Num5ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Num6ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Num7ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Num8ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NUm9ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label11
        '
        Me.Label11.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Vineta BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(113, 6)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(116, 22)
        Me.Label11.TabIndex = 0
        Me.Label11.Text = "SUDOKU"
        '
        'BtnEnd
        '
        Me.BtnEnd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnEnd.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.BtnEnd.Location = New System.Drawing.Point(165, 256)
        Me.BtnEnd.Name = "BtnEnd"
        Me.BtnEnd.Size = New System.Drawing.Size(37, 26)
        Me.BtnEnd.TabIndex = 13
        Me.BtnEnd.Text = "Hint"
        Me.BtnEnd.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Panel5)
        Me.Panel1.Controls.Add(Me.Label11)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(900, 51)
        Me.Panel1.TabIndex = 14
        '
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.ChkShowHint)
        Me.Panel5.Controls.Add(Me.LblHint)
        Me.Panel5.Location = New System.Drawing.Point(334, 9)
        Me.Panel5.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(243, 30)
        Me.Panel5.TabIndex = 2
        '
        'ChkShowHint
        '
        Me.ChkShowHint.AutoSize = True
        Me.ChkShowHint.Location = New System.Drawing.Point(29, 8)
        Me.ChkShowHint.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.ChkShowHint.Name = "ChkShowHint"
        Me.ChkShowHint.Size = New System.Drawing.Size(45, 17)
        Me.ChkShowHint.TabIndex = 2
        Me.ChkShowHint.Text = "Hint"
        Me.ChkShowHint.UseVisualStyleBackColor = True
        '
        'LblHint
        '
        Me.LblHint.AutoSize = True
        Me.LblHint.ForeColor = System.Drawing.Color.Blue
        Me.LblHint.Location = New System.Drawing.Point(100, 9)
        Me.LblHint.Name = "LblHint"
        Me.LblHint.Size = New System.Drawing.Size(45, 13)
        Me.LblHint.TabIndex = 1
        Me.LblHint.Text = "Label31"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.Control
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel2.Location = New System.Drawing.Point(30, 57)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(253, 252)
        Me.Panel2.TabIndex = 15
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Panel3.Controls.Add(Me.Button4)
        Me.Panel3.Controls.Add(Me.ChkHint)
        Me.Panel3.Controls.Add(Me.CheckBox9)
        Me.Panel3.Controls.Add(Me.GroupBox1)
        Me.Panel3.Controls.Add(Me.Button3)
        Me.Panel3.Controls.Add(Me.Button2)
        Me.Panel3.Controls.Add(Me.Button1)
        Me.Panel3.Controls.Add(Me.BtnEnd)
        Me.Panel3.Location = New System.Drawing.Point(400, 57)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(248, 442)
        Me.Panel3.TabIndex = 16
        '
        'ChkHint
        '
        Me.ChkHint.Appearance = System.Windows.Forms.Appearance.Button
        Me.ChkHint.AutoSize = True
        Me.ChkHint.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ChkHint.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.ChkHint.Location = New System.Drawing.Point(36, 35)
        Me.ChkHint.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.ChkHint.Name = "ChkHint"
        Me.ChkHint.Size = New System.Drawing.Size(45, 26)
        Me.ChkHint.TabIndex = 19
        Me.ChkHint.Text = "Hint"
        Me.ChkHint.UseVisualStyleBackColor = True
        '
        'CheckBox9
        '
        Me.CheckBox9.AutoSize = True
        Me.CheckBox9.Location = New System.Drawing.Point(44, 381)
        Me.CheckBox9.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.CheckBox9.Name = "CheckBox9"
        Me.CheckBox9.Size = New System.Drawing.Size(81, 17)
        Me.CheckBox9.TabIndex = 8
        Me.CheckBox9.Text = "CheckBox9"
        Me.CheckBox9.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.CheckBox8)
        Me.GroupBox1.Controls.Add(Me.CheckBox7)
        Me.GroupBox1.Controls.Add(Me.CheckBox6)
        Me.GroupBox1.Controls.Add(Me.CheckBox5)
        Me.GroupBox1.Controls.Add(Me.CheckBox4)
        Me.GroupBox1.Controls.Add(Me.CheckBox3)
        Me.GroupBox1.Controls.Add(Me.CheckBox2)
        Me.GroupBox1.Controls.Add(Me.CheckBox1)
        Me.GroupBox1.Location = New System.Drawing.Point(31, 144)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GroupBox1.Size = New System.Drawing.Size(113, 259)
        Me.GroupBox1.TabIndex = 18
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Memo"
        '
        'CheckBox8
        '
        Me.CheckBox8.AutoSize = True
        Me.CheckBox8.Location = New System.Drawing.Point(13, 217)
        Me.CheckBox8.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.CheckBox8.Name = "CheckBox8"
        Me.CheckBox8.Size = New System.Drawing.Size(81, 17)
        Me.CheckBox8.TabIndex = 7
        Me.CheckBox8.Text = "CheckBox8"
        Me.CheckBox8.UseVisualStyleBackColor = True
        '
        'CheckBox7
        '
        Me.CheckBox7.AutoSize = True
        Me.CheckBox7.Location = New System.Drawing.Point(13, 196)
        Me.CheckBox7.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.CheckBox7.Name = "CheckBox7"
        Me.CheckBox7.Size = New System.Drawing.Size(81, 17)
        Me.CheckBox7.TabIndex = 6
        Me.CheckBox7.Text = "CheckBox7"
        Me.CheckBox7.UseVisualStyleBackColor = True
        '
        'CheckBox6
        '
        Me.CheckBox6.AutoSize = True
        Me.CheckBox6.Location = New System.Drawing.Point(13, 167)
        Me.CheckBox6.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.CheckBox6.Name = "CheckBox6"
        Me.CheckBox6.Size = New System.Drawing.Size(81, 17)
        Me.CheckBox6.TabIndex = 5
        Me.CheckBox6.Text = "CheckBox6"
        Me.CheckBox6.UseVisualStyleBackColor = True
        '
        'CheckBox5
        '
        Me.CheckBox5.AutoSize = True
        Me.CheckBox5.Location = New System.Drawing.Point(13, 137)
        Me.CheckBox5.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.CheckBox5.Name = "CheckBox5"
        Me.CheckBox5.Size = New System.Drawing.Size(81, 17)
        Me.CheckBox5.TabIndex = 4
        Me.CheckBox5.Text = "CheckBox5"
        Me.CheckBox5.UseVisualStyleBackColor = True
        '
        'CheckBox4
        '
        Me.CheckBox4.AutoSize = True
        Me.CheckBox4.Location = New System.Drawing.Point(13, 110)
        Me.CheckBox4.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.CheckBox4.Name = "CheckBox4"
        Me.CheckBox4.Size = New System.Drawing.Size(81, 17)
        Me.CheckBox4.TabIndex = 3
        Me.CheckBox4.Text = "CheckBox4"
        Me.CheckBox4.UseVisualStyleBackColor = True
        '
        'CheckBox3
        '
        Me.CheckBox3.AutoSize = True
        Me.CheckBox3.Location = New System.Drawing.Point(13, 84)
        Me.CheckBox3.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.CheckBox3.Name = "CheckBox3"
        Me.CheckBox3.Size = New System.Drawing.Size(81, 17)
        Me.CheckBox3.TabIndex = 2
        Me.CheckBox3.Text = "CheckBox3"
        Me.CheckBox3.UseVisualStyleBackColor = True
        '
        'CheckBox2
        '
        Me.CheckBox2.AutoSize = True
        Me.CheckBox2.Location = New System.Drawing.Point(13, 54)
        Me.CheckBox2.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(81, 17)
        Me.CheckBox2.TabIndex = 1
        Me.CheckBox2.Text = "CheckBox2"
        Me.CheckBox2.UseVisualStyleBackColor = True
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(13, 24)
        Me.CheckBox1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(81, 17)
        Me.CheckBox1.TabIndex = 0
        Me.CheckBox1.Text = "CheckBox1"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(165, 178)
        Me.Button3.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(53, 20)
        Me.Button3.TabIndex = 17
        Me.Button3.Text = "Memo"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(148, 219)
        Me.Button2.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(83, 26)
        Me.Button2.TabIndex = 16
        Me.Button2.Text = "ShowNumber"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button1.Location = New System.Drawing.Point(172, 301)
        Me.Button1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(46, 26)
        Me.Button1.TabIndex = 15
        Me.Button1.Text = "Lock"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.Transparent
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel4.Location = New System.Drawing.Point(0, 505)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(900, 56)
        Me.Panel4.TabIndex = 17
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NuToolStripMenuItem, Me.Num2ToolStripMenuItem, Me.Num3ToolStripMenuItem, Me.Num4ToolStripMenuItem, Me.Num5ToolStripMenuItem, Me.Num6ToolStripMenuItem, Me.Num7ToolStripMenuItem, Me.Num8ToolStripMenuItem, Me.NUm9ToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(111, 202)
        '
        'NuToolStripMenuItem
        '
        Me.NuToolStripMenuItem.Checked = True
        Me.NuToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked
        Me.NuToolStripMenuItem.Name = "NuToolStripMenuItem"
        Me.NuToolStripMenuItem.Size = New System.Drawing.Size(110, 22)
        Me.NuToolStripMenuItem.Text = "Num 1"
        '
        'Num2ToolStripMenuItem
        '
        Me.Num2ToolStripMenuItem.Checked = True
        Me.Num2ToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked
        Me.Num2ToolStripMenuItem.Name = "Num2ToolStripMenuItem"
        Me.Num2ToolStripMenuItem.Size = New System.Drawing.Size(110, 22)
        Me.Num2ToolStripMenuItem.Text = "Num 2"
        '
        'Num3ToolStripMenuItem
        '
        Me.Num3ToolStripMenuItem.Name = "Num3ToolStripMenuItem"
        Me.Num3ToolStripMenuItem.Size = New System.Drawing.Size(110, 22)
        Me.Num3ToolStripMenuItem.Text = "Num 3"
        '
        'Num4ToolStripMenuItem
        '
        Me.Num4ToolStripMenuItem.Name = "Num4ToolStripMenuItem"
        Me.Num4ToolStripMenuItem.Size = New System.Drawing.Size(110, 22)
        Me.Num4ToolStripMenuItem.Text = "Num 4"
        '
        'Num5ToolStripMenuItem
        '
        Me.Num5ToolStripMenuItem.Name = "Num5ToolStripMenuItem"
        Me.Num5ToolStripMenuItem.Size = New System.Drawing.Size(110, 22)
        Me.Num5ToolStripMenuItem.Text = "Num 5"
        '
        'Num6ToolStripMenuItem
        '
        Me.Num6ToolStripMenuItem.Name = "Num6ToolStripMenuItem"
        Me.Num6ToolStripMenuItem.Size = New System.Drawing.Size(110, 22)
        Me.Num6ToolStripMenuItem.Text = "Num 6"
        '
        'Num7ToolStripMenuItem
        '
        Me.Num7ToolStripMenuItem.Name = "Num7ToolStripMenuItem"
        Me.Num7ToolStripMenuItem.Size = New System.Drawing.Size(110, 22)
        Me.Num7ToolStripMenuItem.Text = "Num 7"
        '
        'Num8ToolStripMenuItem
        '
        Me.Num8ToolStripMenuItem.Name = "Num8ToolStripMenuItem"
        Me.Num8ToolStripMenuItem.Size = New System.Drawing.Size(110, 22)
        Me.Num8ToolStripMenuItem.Text = "Num 8"
        '
        'NUm9ToolStripMenuItem
        '
        Me.NUm9ToolStripMenuItem.Name = "NUm9ToolStripMenuItem"
        Me.NUm9ToolStripMenuItem.Size = New System.Drawing.Size(110, 22)
        Me.NUm9ToolStripMenuItem.Text = "Num 9"
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(158, 120)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(72, 24)
        Me.Button4.TabIndex = 20
        Me.Button4.Text = "Solve"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.Red
        Me.Label1.Location = New System.Drawing.Point(644, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Label1"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(775, 15)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(39, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Label2"
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.CancelButton = Me.BtnEnd
        Me.ClientSize = New System.Drawing.Size(900, 561)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.MaximizeBox = False
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SUDOKU"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents BtnEnd As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents LblHint As System.Windows.Forms.Label
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents ChkShowHint As System.Windows.Forms.CheckBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents NuToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Num2ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Num3ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Num4ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Num5ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Num6ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Num7ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Num8ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NUm9ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox9 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox8 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox7 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox6 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox5 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox4 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox3 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox2 As System.Windows.Forms.CheckBox
    Friend WithEvents ChkHint As System.Windows.Forms.CheckBox
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label

End Class
