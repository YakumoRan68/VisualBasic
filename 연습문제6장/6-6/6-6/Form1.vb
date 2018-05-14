Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim TxT = "이 아닙니다."
        If TextBox2.Text ^ 2 + TextBox3.Text ^ 2 = TextBox1.Text ^ 2 Then
            TxT = "입니다."
        End If
        MsgBox("입력한 삼각형은 직각 삼각형" & TxT)
    End Sub
End Class
