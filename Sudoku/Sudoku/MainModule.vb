Module MainModule
    Structure ColorINFO
        Public Color1 As Color
        Public Color2 As Color
        Public ColorFont As Color
    End Structure
    Enum DisplayMode
        Normal = 0
        Play = 1
        InputData = 2
        Hint = 3
        ShowNumber = 4
        Memo = 5
    End Enum
    Structure CellINFO
        Public Name As String
        Public Value As Byte
        Public Tag As Byte
        Public Position As Byte '1~9
        Public Index As Byte '1~81
        Public NextIndexRow As String
        Public NextIndexRow1 As String
        Public NextIndexRow2 As String
        Public NextIndexColumn As String
        Public NextIndexColumn1 As String
        Public NextIndexColumn2 As String
        Public ValueBlock As String
        Public ValueRow As String
        Public ValueColumn As String
        Public ValueRowNext1 As String
        Public ValueRowNext2 As String
        Public ValueColumnNext1 As String
        Public ValueColumnNext2 As String
        Public Group As Byte
        Public Row As Byte
        Public Hint As String
        Public Column As Byte
        Public SubRow As Byte ' bo
        Public SubColumn As Byte 'Bo
    End Structure
    Public Started As Boolean
    Public UnitCellSize As Integer
    Public ColorSelect As ColorINFO
    Public CurCell As CellINFO
    Private OriginSize As Size = New Size(720, 600)
    Private ScaleX As Single
    Private SCaleY As Single
    Public ScaleXY As Single
    Public Mode As Byte
    Public Remain(8) As Byte
    Public Solved As Byte = 0
    Public Sub ArrangeControl()
        ScaleX = OriginSize.Width / OriginSize.Height
        AdjustSplitter()
        AdjustControl()
    End Sub

    Private Sub AdjustSplitter()
        With frmMain
            SCaleY = Screen.PrimaryScreen.Bounds.Height / .ClientSize.Height
            ScaleXY = (ScaleX + SCaleY) / 2
            .Size = New Size(OriginSize.Width * ScaleXY, OriginSize.Height * ScaleXY)
            'Config Panel1 contains Label SUDOKU
            .Panel1.Width = .ClientSize.Width
            .Panel1.Height = CInt(40 * ScaleXY)
            'Config Panel2 contains CellBlocks
            UnitCellSize = FindBlockHeight(18)
            .Panel2.ClientSize = New Size(UnitCellSize * 27, UnitCellSize * 27)
            .Panel2.Location = New Point(4, .Panel1.Bottom)
            .Panel2.BorderStyle = BorderStyle.None
            'Config Panel3 contains MenuControls
            .Panel3.Width = .ClientSize.Width - .Panel2.Width - 4
            .Panel3.Height = .Panel2.Height
            .Panel3.Location = New Point(.Panel2.Right, .Panel2.Top)
            'Config Panel4 contains InfoControls
            .Panel4.Height = .ClientSize.Height - .Panel1.Height - .Panel2.Height
            .Panel4.Location = New Point(0, .Panel2.Bottom)
        End With
    End Sub
    Private Function FindBlockHeight(ByVal BaseCellSize As Integer) As Integer
        Dim Result As Integer = BaseCellSize
        Dim Cond1 As Boolean = CBool(Result Mod 81 <> 0)
        Dim Cond2 As Boolean = CBool(frmMain.Panel4.ClientSize.Height < CInt(Result * ScaleXY * 1.4))
        Result = CInt(BaseCellSize * 27 * ScaleXY)
        Do While Cond1 And Cond2
            Result += 1
        Loop
        Return CInt(Result \ 27)
    End Function
    Private Sub AdjustControl()

    End Sub
    Public Sub ChangeMode(ByVal CurrentMode As DisplayMode, Optional ByVal Num As Byte = 0)
        Dim TXB As TextBox
        Dim TXM As TextBox
        With frmMain
            For i = 1 To .GroupCell.Count
                Select Case CurrentMode
                    Case DisplayMode.Normal
                        For j = 1 To .GroupCell(i - 1).Cell.Count
                            For k = 1 To 9
                                TXM = CType(.GroupCell(i - 1).SubCell(j - 1, k - 1).Control, TextBox)
                                TXM.Text = ""
                                TXM.Enabled = False
                                TXM.Visible = False
                            Next
                        Next
                    Case DisplayMode.Play
                        For j = 1 To .GroupCell(i - 1).Cell.Count
                            TXB = CType(.GroupCell(i - 1).Cell(j - 1).Control, TextBox)
                            If Not String.IsNullOrEmpty(TXB.Text) Then
                                TXB.Enabled = False
                                TXB.BackColor = Color.Black
                                TXB.ForeColor = Color.White
                                TXB.Tag = 2
                                Solved += 1
                            Else
                                TXB.Enabled = True
                                TXB.Tag = 0
                            End If
                        Next
                    Case DisplayMode.InputData
                    Case DisplayMode.Hint
                        For j = 1 To .GroupCell(i - 1).Cell.Count
                            TXB = CType(.GroupCell(i - 1).Cell(j - 1).Control, TextBox)
                            .GetCellInfo(TXB)
                            .ChangeCurCell(TXB)
                            If TXB.Text.Trim = "" Then
                                For k = 1 To 9
                                    TXM = CType(.GroupCell(i - 1).SubCell(j - 1, k - 1).Control, TextBox)
                                    If CurCell.Hint.Contains(k.ToString) Then
                                        TXM.Text = k
                                    End If
                                    TXM.Enabled = False
                                    TXM.Visible = True
                                Next
                            Else
                                TXB.Visible = True
                            End If
                        Next
                    Case DisplayMode.ShowNumber
                        For j = 1 To .GroupCell(i - 1).Cell.Count
                            TXB = CType(.GroupCell(i - 1).Cell(j - 1).Control, TextBox)
                            If TXB.Text.Trim = Num.ToString Then
                                TXB.BackColor = Color.SeaShell
                                TXB.ForeColor = Color.Red
                                TXB.Tag = 3
                            End If
                        Next
                    Case Else
                End Select

            Next
            .Label1.Text = Solved.ToString
        End With
    End Sub
   
End Module
