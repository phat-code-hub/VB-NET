Imports System.Collections.Generic
Public Class frmMain
    Public GroupCell As InputCell()
    Private TX As TextBox
    Private InputC As InputCell
    Private RowNext1 As Byte = 0
    Private RowNext2 As Byte = 0
    Private ColumnNext1 As Byte = 0
    Private ColumnNext2 As Byte = 0
    Private MainGroup As Byte
    Private FirstGroup As Byte
    Private HorizoneGroup As Byte()
    Private VerticalGroup As Byte()
    Private HasDoubled As Boolean
    Private CurBlock As String
    Private CurRow As String
    Private CurColumn As String
    Private DoubleBlock As Boolean
    Private DoubleRow As Boolean
    Private DoubleColumn As Boolean
    Private All As String = "1,2,3,4,5,6,7,8,9"
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim Index As Byte = 0
        Me.SuspendLayout()
        MainModule.ArrangeControl()
        Me.CenterToScreen()
        Me.GroupCell = New InputCell(8) {}
        For i As Byte = 0 To 2
            For j As Byte = 0 To 2
                With Me
                    Index = (i * 3) + j
                    .GroupCell(Index) = New InputCell
                    .GroupCell(Index).Parent = Me.Panel2
                    .GroupCell(Index).Name = (Index + 1).ToString
                    With .GroupCell(Index)
                        .Parent = Me.Panel2
                        .Size = New Size(UnitCellSize * 9, UnitCellSize * 9)
                        .Location = New Point(j * .Width, i * .Height)
                        .ChangeCellSize(UnitCellSize, Index + 1)
                    End With
                End With
            Next j
        Next i
        AssignMainIndex()
        Me.Panel2.Controls.AddRange(GroupCell)
        With ColorSelect
            .Color1 = Color.LightCyan
            .Color2 = Color.Gold
        End With
        ChangeBlockColor(ColorSelect.Color1, ColorSelect.Color2)
        Me.ChkShowHint.Checked = True
        Me.LblHint.Text = ""
        Mode = DisplayMode.InputData
        Me.ResumeLayout()
        Started = False
    End Sub
    Private Function TrimText(ByVal Words As String, Optional ByVal Direction As Boolean = True,
                                Optional ByVal DelNum As Byte = 1) As String
        Dim Ans As String = ""
        If Words.Trim <> "" Then
            Select Case Direction
                Case True ' Delete Right to Left
                    Ans = Words.Substring(0, Words.Length - DelNum)
                Case False 'Delete Left to Right
                    Ans = Words.Trim.Substring(DelNum) ', Words.Trim.Length - DelNum)
            End Select
        End If
        Return Ans
    End Function
    Private Sub AssignMainIndex()
        Dim Position As Byte = 0
        Dim FirstCell As Byte = 0
        Dim NextCell As Byte = 0
        For i = 0 To 8
            FirstCell = (i \ 3) * 27 + (i Mod 3) * 3
            For j = 0 To 2
                For k = 0 To 2
                    Position = j * 3 + k
                    Me.GroupCell(i).Cell(Position).Index = FirstCell + j * 9 + k + 1
                    Me.GroupCell(i).Cell(Position).Control.Name = Me.GroupCell(i).Cell(Position).Group.ToString +
                                                                Me.GroupCell(i).Cell(Position).Position.ToString +
                                                                 Me.GroupCell(i).Cell(Position).Row.ToString +
                                                                  Me.GroupCell(i).Cell(Position).Column.ToString +
                                                                Me.GroupCell(i).Cell(Position).Index.ToString
                Next
            Next
        Next
    End Sub
    Public Sub ChangeBlockColor(ByVal Color1 As Color, ByVal Color2 As Color)
        With Me
            .SuspendLayout()
            For i = 0 To .GroupCell.Count - 1
                For j = 0 To .GroupCell(i).Cell.Count - 1
                    If (.GroupCell(i).Cell(j).Group Mod 2) = 0 Then
                        .GroupCell(i).Cell(j).Control.BackColor = Color2
                        For k As Byte = 0 To UBound(.GroupCell(i).SubCell, 2)
                            .GroupCell(i).SubCell(j, k).Control.BackColor = Color2
                        Next
                    Else
                        .GroupCell(i).Cell(j).Control.BackColor = Color1
                        For k As Byte = 0 To UBound(.GroupCell(i).SubCell, 2)
                            .GroupCell(i).SubCell(j, k).Control.BackColor = Color1
                        Next
                    End If
                Next j
            Next i
            .ResumeLayout()
        End With
    End Sub
    Private Sub BtnEnd_Click(sender As Object, e As EventArgs) Handles BtnEnd.Click
        'Mode = DisplayMode.Hint
        'MainModule.ChangeMode(Mode)
        'End
    End Sub
    Public Sub CellFocus(ByVal sender As Object, e As EventArgs)
        Dim INP As InputCell
        For Each CT As Control In Me.Panel2.Controls
            If TypeOf (CT) Is InputCell Then
                INP = CType(CT, InputCell)
                For Each CTs As Control In INP.Controls
                    If TypeOf (CTs) Is TextBox Then
                        CTs.ForeColor = SystemColors.ControlText
                    End If
                Next
            End If
        Next
        GetCellInfo(CType(sender, TextBox))
        ChangeCurCell(CType(sender, TextBox))
        CType(sender, TextBox).BackColor = Color.Ivory
        CType(sender, TextBox).ForeColor = Color.DarkOrange
        Me.ToolTip1.Show(CurCell.Hint, CType(sender, TextBox))
        If Mode = DisplayMode.Memo Then

        End If
    End Sub
    Public Sub GetCellInfo(ByVal TXs As TextBox)
        With CurCell
            .Group = Val(TXs.Name.Trim.Substring(0, 1))
            .Name = TXs.Name.Trim
            .Value = Val(TXs.Text)
            If .Value > 0 Then
                .Tag = 1
            Else
                .Tag = 0
            End If
            With GroupCell(.Group - 1)
                For i = 1 To .Cell.Count
                    If .Cell(i - 1).Control.Name = CurCell.Name Then
                        CurCell.Position = i
                        CurCell.Index = .Cell(i - 1).Index
                        CurCell.Row = .Cell(i - 1).Row
                        CurCell.Column = .Cell(i - 1).Column
                    End If
                Next
            End With
        End With
    End Sub
    Private Sub DisplayInfo(ByVal Info As CellINFO)
        Me.LblHint.Text = Info.Hint
        'With Info
        '    Me.Label6.Text = .Group
        '    Me.Label7.Text = .Row
        '    Me.Label8.Text = .Column
        '    Me.Label9.Text = .NextIndexRow
        '    Me.Label10.Text = .NextIndexColumn
        '    Me.Label12.Text = .Name
        '    Me.Label15.Text = .Tag
        '    Me.Label16.Text = .Value
        '    Me.Label18.Text = .ValueBlock
        '    Me.Label19.Text = .ValueRow
        '    Me.Label29.Text = .ValueRowNext1
        '    Me.Label27.Text = .ValueRowNext2
        '    Me.Label21.Text = .ValueColumn
        '    Me.Label25.Text = .ValueColumnNext1
        '    Me.Label23.Text = .ValueColumnNext2
        '    Me.LblHint.Text = .Hint
        'End With
    End Sub
    Public Sub CellFocusLost(ByVal sender As Object, ByVal e As EventArgs)
        If CurCell.Group Mod 2 = 0 Then
            CType(sender, TextBox).BackColor = ColorSelect.Color2
        Else
            CType(sender, TextBox).BackColor = ColorSelect.Color1
        End If
    End Sub
    Public Sub ChangeText(ByVal sender As Object, ByVal e As EventArgs)
        Dim TexBox As TextBox = CType(sender, TextBox)
        ChangeCurCell(TexBox)
        If CurCell.Hint.Contains(TexBox.Text) Then
            If String.IsNullOrEmpty(TexBox.Text.Trim) Then
                TexBox.Tag = 1
            Else
                TexBox.Tag = 0
            End If
        Else
            MessageBox.Show("Double!", "Check Hint Please!", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.ToolTip1.Hide(TexBox)
            TexBox.Text = ""
            TexBox.Tag = 0
        End If
    End Sub
    Public Sub ChangeCurCell(ByRef CellBox As TextBox)
        'Dim Cond1, Cond2, Cond3 As Boolean
        With CurCell
            .Value = Val(CellBox.Text)
            .ValueBlock = ""
            .ValueRow = ""
            .ValueRowNext1 = ""
            .ValueRowNext2 = ""
            .ValueColumn = ""
            .ValueColumnNext1 = ""
            .ValueColumnNext2 = ""
            .NextIndexRow = ""
            .NextIndexColumn = ""
            .Hint = ""
            Dim TextValue As String = ""
            For i = 1 To Me.GroupCell.Count
                For j = 1 To Me.GroupCell(i - 1).Cell.Count
                    TextValue = GroupCell(i - 1).Cell(j - 1).Control.Text.Trim
                    If Me.GroupCell(i - 1).Cell(j - 1).Group = .Group Then 'In the same Block
                        If GroupCell(i - 1).Cell(j - 1).Index <> .Index Then
                            If TextValue <> "" Then
                                CurCell.ValueBlock += TextValue
                            End If

                            If Me.GroupCell(i - 1).Cell(j - 1).Row = .Row Then
                                If TextValue <> "" Then
                                    .ValueRow += TextValue
                                End If
                                .NextIndexRow += Me.GroupCell(i - 1).Cell(j - 1).Position.ToString
                            End If
                            If Me.GroupCell(i - 1).Cell(j - 1).Column = .Column Then
                                If TextValue <> "" Then
                                    .ValueColumn += TextValue
                                End If
                                .NextIndexColumn += Me.GroupCell(i - 1).Cell(j - 1).Position.ToString
                            End If
                        End If
                    Else
                        ' Not the same group but has the same Row or Column
                        If TextValue <> "" Then
                            If Me.GroupCell(i - 1).Cell(j - 1).Row = .Row Then
                                .ValueRow += TextValue
                            Else
                                If ((Me.GroupCell(i - 1).Cell(j - 1).Group - 1) \ 3 = .Group \ 3) And (Me.GroupCell(i - 1).Cell(j - 1).Group <> .Group) Then
                                    Select Case (.Position - 1) \ 3
                                        Case 0
                                            Select Case (Me.GroupCell(i - 1).Cell(j - 1).Position - 1) \ 3
                                                Case 0
                                                Case 1
                                                    .ValueRowNext1 += TextValue
                                                Case 2
                                                    .ValueRowNext2 += TextValue
                                            End Select
                                        Case 1
                                            Select Case (Me.GroupCell(i - 1).Cell(j - 1).Position - 1) \ 3
                                                Case 0
                                                    .ValueRowNext1 += TextValue
                                                Case 1

                                                Case 2
                                                    .ValueRowNext2 += TextValue
                                            End Select
                                        Case 2
                                            Select Case (Me.GroupCell(i - 1).Cell(j - 1).Position - 1) \ 3
                                                Case 0
                                                    .ValueRowNext1 += TextValue
                                                Case 1
                                                    .ValueRowNext2 += TextValue
                                                Case 2

                                            End Select
                                    End Select
                                End If
                            End If
                            If Me.GroupCell(i - 1).Cell(j - 1).Column = .Column Then
                                .ValueColumn += TextValue
                            Else
                                If ((Me.GroupCell(i - 1).Cell(j - 1).Group - 1) Mod 3 = (.Group - 1) Mod 3) And (Me.GroupCell(i - 1).Cell(j - 1).Group <> .Group) Then
                                    Select Case (.Position - 1) Mod 3
                                        Case 0
                                            Select Case (Me.GroupCell(i - 1).Cell(j - 1).Position - 1) Mod 3
                                                Case 0
                                                Case 1
                                                    .ValueColumnNext1 += TextValue
                                                Case 2
                                                    .ValueColumnNext2 += TextValue
                                            End Select
                                        Case 1
                                            Select Case (Me.GroupCell(i - 1).Cell(j - 1).Position - 1) Mod 3
                                                Case 0
                                                    .ValueColumnNext1 += TextValue
                                                Case 1

                                                Case 2
                                                    .ValueColumnNext2 += TextValue
                                            End Select
                                        Case 2
                                            Select Case (Me.GroupCell(i - 1).Cell(j - 1).Position - 1) Mod 3
                                                Case 0
                                                    .ValueColumnNext1 += TextValue
                                                Case 1
                                                    .ValueColumnNext2 += TextValue
                                                Case 2

                                            End Select
                                    End Select
                                End If
                            End If
                        End If
                    End If
                Next
            Next
            .Hint = FindHint(CurCell)
        End With
        DisplayInfo(CurCell)
    End Sub
    Public Sub UpKey(ByVal sender As Object, ByVal e As KeyEventArgs)
        Select Case e.KeyCode
            Case Keys.D1 To Keys.D9, Keys.NumPad1 To Keys.NumPad9, Keys.None
                GetCellInfo(CType(sender, TextBox))
            Case Keys.Enter
            Case Else
                Beep()
                CType(sender, TextBox).Text = ""
        End Select
    End Sub
    Private Function FindHint(ByVal CellInfos As CellINFO) As String
        Dim Hint As String = "123456789"
        Dim Spl As Array
        Dim Chars As Char
        With CellInfos
            If .ValueBlock.Trim <> "" Then
                For i As Byte = 0 To .ValueBlock.Length - 1
                    Chars = .ValueBlock.Substring(i, 1)
                    If Hint.Contains(Chars) Then
                        Hint = Hint.Replace(Chars, "")
                    End If
                Next
            End If
            If Hint.Trim <> "" Then
                If .ValueRow.Trim <> "" Then
                    For i As Byte = 0 To .ValueRow.Length - 1
                        Chars = .ValueRow.Substring(i, 1)
                        If Hint.Contains(Chars) Then
                            Hint = Hint.Replace(Chars, "")
                        End If
                    Next
                End If
            End If
            If Hint.Trim <> "" Then
                If .ValueColumn.Trim <> "" Then
                    For i As Byte = 0 To .ValueColumn.Length - 1
                        Chars = .ValueColumn.Substring(i, 1)
                        If Hint.Contains(Chars) Then
                            Hint = Hint.Replace(Chars, "")
                        End If
                    Next
                End If
            End If
            Spl = Hint.ToArray
            If Spl.Length > 1 Then
                Hint = ""
                For i = 0 To Spl.Length - 1
                    Hint += Spl(i) + ","
                Next
                Hint = TrimText(Hint)
            End If
            Return Hint
        End With
    End Function
    'Public Sub UpMouse(ByVal sender As Object, ByVal e As MouseEventArgs)
    '    If e.Button = Windows.Forms.MouseButtons.Right Then

    '    End If
    'End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'Started = Not Started
        Mode = DisplayMode.Play
        MainModule.ChangeMode(Mode)
    End Sub

   

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        'MainModule.ChangeMode(DisplayMode.ShowNumber, 2)
        'Me.ContextMenuStrip1.Show(Me.Button2, New Point(0, 0))
    End Sub

   
   
   
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Mode = DisplayMode.Memo
    End Sub

   
   
    Private Sub ChkShowHint_CheckedChanged(sender As Object, e As EventArgs) Handles ChkShowHint.CheckedChanged
        Me.LblHint.Visible = ChkShowHint.Checked
    End Sub

    Private Sub ChkHint_CheckedChanged(sender As Object, e As EventArgs) Handles ChkHint.CheckedChanged
        If ChkHint.Checked Then
            Mode = DisplayMode.Hint

        Else
            Mode = DisplayMode.Normal
        End If
        MainModule.ChangeMode(Mode)
    End Sub
    Private Sub AutoSolve()
        Dim TX As TextBox
        Dim RepeatNum As Integer = 0
        Dim MAX = 81
        With Me
            Do Until Solved = MAX Or RepeatNum > 30
                For i = 1 To .GroupCell.Count
                    For j = 1 To .GroupCell(i - 1).Cell.Count
                        TX = .GroupCell(i - 1).Cell(j - 1).Control
                        If String.IsNullOrEmpty(TX.Text.Trim) Then
                            Me.GetCellInfo(TX)
                            Me.ChangeCurCell(TX)
                            If CurCell.Hint.Trim.Length = 1 Then
                                TX.ForeColor = Color.Red
                                TX.Text = CurCell.Hint.Trim
                                Solved += 1
                            End If
                        End If
                        If Solved = MAX Then
                            Exit Do
                        End If
                    Next
                Next
                RepeatNum += 1
            Loop
            .Label1.Text = Solved
            .Label2.Text = RepeatNum
        End With
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        AutoSolve()
    End Sub
End Class
