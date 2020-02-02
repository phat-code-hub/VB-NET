Imports System.Windows.Forms

Public Class Dialog1
    Private db As New DBBox(My.Settings.ConnectionString)
    'Public CustomerID As String = ""
    Private Sub FmCustomerSearch_Load(sender As Object, e As EventArgs) Handles Me.Load
        Me.DgvCustomerList.AllowUserToResizeRows = False
    End Sub

    Private Sub Button_Click(sender As Object, e As EventArgs) Handles Button1.Click, Button2.Click, Button3.Click,
                                                                    Button4.Click, Button5.Click, Button6.Click, Button7.Click,
                                                                    Button8.Click, Button9.Click, Button10.Click
        FilterCustomerInfo(DirectCast(sender, Button).Tag.ToString)
    End Sub

    Private Sub FilterCustomerInfo(condition As String)
        'Throw New NotImplementedException()
        Dim sql As String = "SELECT 顧客ID,顧客名,フリガナ,Post,住所,TEL,FAX FROM T顧客マスタ"
        sql &= " WHERE フリガナ LIKE '[" & condition & "]%'"
        sql &= " ORDER BY フリガナ"
        Dim dt As New DataTable
        If db.GetDataFormDB(dt, sql) Then
            With Me.DgvCustomerList
                .DataSource = dt
                .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
            End With
        End If
    End Sub

    Private Sub DgvCustomerInfo_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvCustomerList.CellContentClick
        CustomerID = Me.DgvCustomerList.CurrentRow.Cells("顧客ID").Value.ToString
    End Sub
    Private Sub DgvCustomerList_RowHeaderMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DgvCustomerList.RowHeaderMouseClick
        'CustomerID = Me.DgvCustomerList.CurrentRow.Cells("顧客ID").Value.ToString
        ' CustomerID = Me.DgvCustomerList.SelectedCells.Item(0).Value.ToString
        ' Me.OK_Button_Click(sender, e)
        'Me.Close()
        CustomerInfoSelected()
    End Sub

    Private Sub CustomerInfoSelected()
        If Me.DgvCustomerList.RowCount > 0 And Me.DgvCustomerList.SelectedCells.Count <> 0 Then
            CustomerID = Me.DgvCustomerList.SelectedCells.Item(0).Value.ToString
            Me.Close()
        End If

    End Sub

    Private Sub DgvCustomerList_KeyUp(sender As Object, e As KeyEventArgs) Handles DgvCustomerList.KeyUp
        If e.KeyCode = Keys.Enter Then
            Me.DgvCustomerList.CurrentRow.Selected = True
            CustomerInfoSelected()
        End If
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub

    Private Sub Dialog1_KeyUp(sender As Object, e As KeyEventArgs) Handles Me.KeyUp
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub
End Class
