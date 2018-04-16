Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim a, b, i, sum As Integer

        a = TextBox1.Text
        b = TextBox2.Text / a
        For i = 1 To b Step a
            sum = sum + i
        Next
        MsgBox("최종값은 " & sum & "입니다.")
    End Sub
End Class
