<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class fmLogIn
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtID = New System.Windows.Forms.TextBox()
        Me.TxtPW = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.BtnLogin = New System.Windows.Forms.Button()
        Me.BtnQuit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(29, 19)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "ID"
        '
        'TxtID
        '
        Me.TxtID.ImeMode = System.Windows.Forms.ImeMode.Disable
        Me.TxtID.Location = New System.Drawing.Point(78, 17)
        Me.TxtID.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TxtID.Name = "TxtID"
        Me.TxtID.Size = New System.Drawing.Size(97, 26)
        Me.TxtID.TabIndex = 1
        '
        'TxtPW
        '
        Me.TxtPW.ImeMode = System.Windows.Forms.ImeMode.Disable
        Me.TxtPW.Location = New System.Drawing.Point(78, 84)
        Me.TxtPW.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TxtPW.Name = "TxtPW"
        Me.TxtPW.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TxtPW.Size = New System.Drawing.Size(97, 26)
        Me.TxtPW.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 84)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(29, 19)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "PW"
        '
        'BtnLogin
        '
        Me.BtnLogin.Location = New System.Drawing.Point(227, 50)
        Me.BtnLogin.Name = "BtnLogin"
        Me.BtnLogin.Size = New System.Drawing.Size(109, 91)
        Me.BtnLogin.TabIndex = 4
        Me.BtnLogin.Text = "ログイン"
        Me.BtnLogin.UseVisualStyleBackColor = True
        '
        'BtnQuit
        '
        Me.BtnQuit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.BtnQuit.Location = New System.Drawing.Point(34, 149)
        Me.BtnQuit.Name = "BtnQuit"
        Me.BtnQuit.Size = New System.Drawing.Size(151, 47)
        Me.BtnQuit.TabIndex = 5
        Me.BtnQuit.Text = "終了"
        Me.BtnQuit.UseVisualStyleBackColor = True
        '
        'fmLogIn
        '
        Me.AcceptButton = Me.BtnLogin
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.BtnQuit
        Me.ClientSize = New System.Drawing.Size(370, 214)
        Me.Controls.Add(Me.BtnQuit)
        Me.Controls.Add(Me.BtnLogin)
        Me.Controls.Add(Me.TxtPW)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TxtID)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("MS Mincho", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "fmLogIn"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ログイン"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TxtID As System.Windows.Forms.TextBox
    Friend WithEvents TxtPW As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents BtnLogin As System.Windows.Forms.Button
    Friend WithEvents BtnQuit As System.Windows.Forms.Button
End Class
