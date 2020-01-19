Public Class InputCell
    Public Structure CellStructure
        Dim Group As Byte
        Dim Index As Byte 'Index of cell in Entire Game 1~81 
        Dim Position As Byte ' The Index of cell in GroupCell 1 ~9
        Dim Row As Byte
        Dim Column As Byte
        Dim Control As TextBox
    End Structure
    'Public SubCell As CellStructure
    Dim TextFont As String = "Times New Roman"
    Dim TextMainSize As Integer = 36
    Dim TextSubSize As Integer = 10
    Dim UnitSize As Size = New Size(20, 20) ' Size of smallest Cell
    Public Cell() As CellStructure
    Public SubCell(,) As CellStructure
    Private Sub InputCell_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim Index As Byte = 0
        Dim SubIndex As Byte = 0
        With Me
            .Size = New Size(UnitSize.Width * 9, UnitSize.Height * 9)
            .BorderStyle = Windows.Forms.BorderStyle.Fixed3D
        End With
    End Sub
    Public Sub ChangeCellSize(ByVal Size0 As Integer, ByVal SGroup As Byte)  'Size0 is SubCell Width
        Me.SuspendLayout()
        Dim Index As Byte = 0
        Dim SubIndex As Byte = 0
        With Me
            'Initiate Cell
            ReDim Cell(8)
            ReDim SubCell(8, 8)
            For i As Byte = 0 To 2
                For j As Byte = 0 To 2
                    Index = i * 3 + j ' 0 ~8
                    Cell(Index) = New CellStructure
                    With Cell(Index)
                        .Group = SGroup
                        .Index = Index + 1
                        .Position = Index + 1
                        .Row = ((.Group - 1) \ 3) * 3 + i + 1
                        .Column = ((.Group - 1) Mod 3) * 3 + j + 1
                        .Control = New TextBox
                        With Cell(Index).Control
                            .Parent = Me
                            .Name = Cell(Index).Group.ToString + Cell(Index).Position.ToString ' +
                            'Cell(Index).Row.ToString + Cell(Index).Column.ToString +
                            'Cell(Index).Index.ToString
                            .Multiline = True
                            .MaxLength = 1
                            .BackColor = SystemColors.Control
                            .Font = New Font(TextFont, CInt(TextMainSize * ScaleXY * 0.8))
                            .TextAlign = HorizontalAlignment.Center
                            .Size = New Size(Size0 * 3, Size0 * 3)
                            .Location = New Point(j * .Size.Height, i * .Size.Width)
                            .Text = "" ' Cell(Index).Position
                            .Tag = 0
                            '.ContextMenuStrip = NumberChoice
                            AddHandler Me.Cell(Index).Control.GotFocus, AddressOf frmMain.CellFocus
                            AddHandler Me.Cell(Index).Control.LostFocus, AddressOf frmMain.CellFocusLost
                            AddHandler Me.Cell(Index).Control.TextChanged, AddressOf frmMain.ChangeText
                            'AddHandler Me.Cell(Index).Control.KeyUp, AddressOf frmMain.UpKey
                            'AddHandler Me.Cell(Index).Control.MouseUp, AddressOf frmMain.UpMouse
                            'AddHandler Me.Cell(Index).Control.MouseHover, AddressOf FrmMain.HoverMouse
                            'AddHandler Me.Cell(Index).Control.KeyUp, AddressOf FrmMain.ChangeValue
                            For k As Byte = 0 To 2
                                For l As Byte = 0 To 2
                                    SubIndex = k * 3 + l
                                    SubCell(Index, SubIndex) = New CellStructure
                                    With SubCell(Index, SubIndex)
                                        .Group = Cell(Index).Group
                                        .Index = SubIndex + 1
                                        .Position = SubIndex + 1
                                        .Row = k + 1
                                        .Column = l + 1
                                        .Control = New TextBox
                                        With SubCell(Index, SubIndex).Control
                                            .Parent = Me.Cell(Index).Control
                                            '.Name = "SubCell" + Me.Cell(Index).Group.ToString + Me.Cell(Index).Index.ToString +
                                            '         SubCell(Index, SubIndex).Index.ToString
                                            .Name = SubIndex
                                            .Multiline = True
                                            .MaxLength = 1
                                            .BackColor = SystemColors.Control
                                            .Font = New Font(TextFont, CInt(TextSubSize * ScaleXY * 0.8))
                                            .TextAlign = HorizontalAlignment.Center
                                            .Size = New Size(Size0, Size0)
                                            .Location = New Point(l * .Size.Height, k * .Size.Width)
                                            .Text = "" 'SubCell(Index, SubIndex).Index
                                            .Tag = 0
                                            .BorderStyle = Windows.Forms.BorderStyle.None
                                            '.Visible = True
                                            .Visible = False
                                            'AddHandler SubCell(Index, SubIndex).Control.MouseUp, AddressOf FrmMain.UpMouse
                                            'AddHandler SubCell(Index, SubIndex).Control.MouseMove, AddressOf FrmMain.MoveMouse
                                        End With
                                    End With
                                Next l
                            Next k
                        End With
                    End With
                Next j
            Next i
        End With
        Me.ResumeLayout()
    End Sub
End Class
