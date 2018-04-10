Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim total, endLoop, i As Integer
        endLoop = TextBox1.Text
        i = 0
        While i < endLoop
            i = i + 1
            total = total + i
        End While
        TextBox2.Text = total
    End Sub
End Class
