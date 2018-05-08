Public Class Form1
    Dim path = My.Application.Info.DirectoryPath
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If RadioButton1.Checked Then
            PictureBox1.Image = New Bitmap("media\Hydrangeas.jpg")
        ElseIf RadioButton2.Checked Then
            PictureBox1.Image = New Bitmap("media\Jellyfish.jpg")
        ElseIf RadioButton3.Checked Then
            PictureBox1.Image = New Bitmap(IO.Path.Combine(IO.Directory.GetParent(Application.ExecutablePath).FullName, "myPdfFile.pdf"))
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        PictureBox1.Image = Nothing
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim path = My.Application.Info.DirectoryPath
        IO.Path.Combine(path, "Koala.jpg")
    End Sub
End Class
