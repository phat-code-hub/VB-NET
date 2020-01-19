Public Class FrmMainMenu

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        End
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        FrmNewGame.Show()
    End Sub

    Private Sub FrmMainMenu_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        IsRestored = False
    End Sub

    Private Sub FrmMainMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GetSystemInfo()
        GetRegInfo()
        GetDataInfo()
        GetMaxIndex()
    End Sub
    Private Sub GetSystemInfo()

    End Sub
    Private Sub GetRegInfo()
        Dim StTime() As String
        Key = Key.OpenSubKey("Software\Sudoku")
        With RegInfo
            .Name = CType(Key.GetValue("Name"), String)
            .Language = CType(Key.GetValue("Language"), Byte)
            .Info = CType(Key.GetValue("Info"), String)
            .Level = CType(Key.GetValue("Level"), Byte)
            .Data = CType(Key.GetValue("Data"), String)
            .Lock = CType(Key.GetValue("Lock"), String)
            StTime = CType(Key.GetValue("Time"), String).Split(",")
            .Time = New TimeSpan(CInt(StTime(0)), CInt(StTime(1)), CInt(StTime(2)))
        End With
        'Key.Close()
    End Sub
    Private Sub GetDataInfo()
        Dim OriginPath As String = Application.StartupPath
        Dim Spl() As String = OriginPath.Split("\")
        For i = 0 To Spl.Length - 3
            FilePath += Spl(i) + "\"
        Next
        FilePath += "4649.txt"

    End Sub
    Private Sub GetMaxIndex()
        'Get max index of all level samples
        Dim DataSt As String
        Dim Index As Byte = 0
        Dim ord As Byte = 0
        For i = 0 To RegInfo.Info.Length - 1 Step 3
            DataSt = ""
            For j = 0 To 2
                Index = i + j
                DataSt += RegInfo.Info(Index)
            Next
            DataNum(ord) = Val(DataSt)
            ord += 1
        Next
        For i = 1 To Remain.Count
            Remain(i - 1) = 9
        Next
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Hide()
        IsRestored = True
        frmMain.Show()
    End Sub
End Class