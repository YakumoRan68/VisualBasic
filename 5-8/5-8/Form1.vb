Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim sum, i As Integer
        sum = 0
        For i = 0 To 20 Step 5
            sum = sum + i
        Next i
        TextBox1.Text = sum
    End Sub
End Class
