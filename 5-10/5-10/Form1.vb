Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim start, final As Integer
        start = TextBox1.Text
        final = TextBox2.Text

        For i = start To final Step 1
            For j = 1 To 9 Step 1
                TextBox3.AppendText(i & " * " & j & " = " & i * j & vbCrLf)
            Next
            TextBox3.AppendText(vbCrLf & vbCrLf)
        Next
    End Sub
End Class
