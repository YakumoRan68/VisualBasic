Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        IboxChoose.SelectedIndex = 0
        IvMain.LargeImageList = ImageList1
        IvMain.View = View.LargeIcon
    End Sub
    Private Sub IboxChoose_SelectedIndexChanged(sender As Object, e As EventArgs) Handles IboxChoose.SelectedIndexChanged
        IvMain.LargeImageList = ImageList1
        IvMain.View = IboxChoose.SelectedIndex
    End Sub
    Private Sub IvMain_SelectedIndexChanged(sender As Object, e As EventArgs) Handles IvMain.SelectedIndexChanged
        For i = 0 To IvMain.Items.Count - 1
            If IvMain.Items(i).Selected = True Then
                MsgBox(IvMain.Items(i).Text, MsgBoxStyle.Information, "확인")
            End If
        Next
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        End
    End Sub
End Class
