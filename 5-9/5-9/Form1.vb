Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim first, last, add, sum As Integer

        first = TextBox1.Text
        last = TextBox2.Text
        add = TextBox3.Text

        For i = first To last Step add
            sum = sum + i
        Next i

        TextBox4.Text = sum
    End Sub
End Class
