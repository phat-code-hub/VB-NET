<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Dialog1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.OK_Button = New System.Windows.Forms.Button()
        Me.Button10 = New System.Windows.Forms.Button()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.DgvCustomerList = New System.Windows.Forms.DataGridView()
        CType(Me.DgvCustomerList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'OK_Button
        '
        Me.OK_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.OK_Button.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.OK_Button.Location = New System.Drawing.Point(646, 413)
        Me.OK_Button.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.OK_Button.Name = "OK_Button"
        Me.OK_Button.Size = New System.Drawing.Size(89, 27)
        Me.OK_Button.TabIndex = 0
        Me.OK_Button.Text = "OK"
        '
        'Button10
        '
        Me.Button10.Location = New System.Drawing.Point(12, 408)
        Me.Button10.Name = "Button10"
        Me.Button10.Size = New System.Drawing.Size(54, 38)
        Me.Button10.TabIndex = 20
        Me.Button10.Tag = "わ-を"
        Me.Button10.Text = "わ"
        Me.Button10.UseVisualStyleBackColor = True
        '
        'Button9
        '
        Me.Button9.Location = New System.Drawing.Point(12, 364)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(54, 38)
        Me.Button9.TabIndex = 19
        Me.Button9.Tag = "ら-ろ"
        Me.Button9.Text = "ら"
        Me.Button9.UseVisualStyleBackColor = True
        '
        'Button8
        '
        Me.Button8.Location = New System.Drawing.Point(11, 320)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(54, 38)
        Me.Button8.TabIndex = 18
        Me.Button8.Tag = "や-よ"
        Me.Button8.Text = "や"
        Me.Button8.UseVisualStyleBackColor = True
        '
        'Button7
        '
        Me.Button7.Location = New System.Drawing.Point(12, 276)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(54, 38)
        Me.Button7.TabIndex = 17
        Me.Button7.Tag = "ま-も"
        Me.Button7.Text = "ま"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(11, 232)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(54, 38)
        Me.Button6.TabIndex = 16
        Me.Button6.Tag = "は-ほ"
        Me.Button6.Text = "は"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(12, 188)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(54, 38)
        Me.Button5.TabIndex = 15
        Me.Button5.Tag = "な-の"
        Me.Button5.Text = "な"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(12, 144)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(54, 38)
        Me.Button4.TabIndex = 14
        Me.Button4.Tag = "た-と"
        Me.Button4.Text = "た"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(11, 100)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(54, 38)
        Me.Button3.TabIndex = 13
        Me.Button3.Tag = "さ-そ"
        Me.Button3.Text = "さ"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(12, 56)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(54, 38)
        Me.Button2.TabIndex = 12
        Me.Button2.Tag = "か-こ"
        Me.Button2.Text = "か"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(12, 12)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(54, 38)
        Me.Button1.TabIndex = 11
        Me.Button1.Tag = "あ-お"
        Me.Button1.Text = "あ"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'DgvCustomerList
        '
        Me.DgvCustomerList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvCustomerList.Location = New System.Drawing.Point(91, 18)
        Me.DgvCustomerList.Name = "DgvCustomerList"
        Me.DgvCustomerList.RowTemplate.Height = 24
        Me.DgvCustomerList.Size = New System.Drawing.Size(657, 383)
        Me.DgvCustomerList.TabIndex = 21
        '
        'Dialog1
        '
        Me.AcceptButton = Me.OK_Button
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.OK_Button
        Me.ClientSize = New System.Drawing.Size(748, 452)
        Me.Controls.Add(Me.DgvCustomerList)
        Me.Controls.Add(Me.Button10)
        Me.Controls.Add(Me.Button9)
        Me.Controls.Add(Me.Button8)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.OK_Button)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Dialog1"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "顧客の選択"
        CType(Me.DgvCustomerList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents OK_Button As System.Windows.Forms.Button
    Friend WithEvents Button10 As Button
    Friend WithEvents Button9 As Button
    Friend WithEvents Button8 As Button
    Friend WithEvents Button7 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents DgvCustomerList As DataGridView
End Class
