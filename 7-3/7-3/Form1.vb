Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim filepointer = Val(OpenFileDialog1.ShowDialog())

        If filepointer = 1 Then
            PictureBox1.ImageLocation = OpenFileDialog1.Filename
        End If
    End Sub
End Class
