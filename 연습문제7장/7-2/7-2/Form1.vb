Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        With ComboBox1.Items
            .Add("타원 - 없음")
            .Add("타원 - 늘이기")
            .Add("타원 - 확대")
        End With
        ComboBox1.Text = ComboBox1.Items(2)
    End Sub
    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        OvalShape1.BackgroundImageLayout = ComboBox1.SelectedIndex + 2
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim filepointer = Val(OpenFileDialog1.ShowDialog())
        OvalShape1.BackgroundImage = New Bitmap(OpenFileDialog1.FileName)
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim filepointer = Val(OpenFileDialog1.ShowDialog())
        RectangleShape1.BackgroundImage = New Bitmap(OpenFileDialog1.FileName)
    End Sub
End Class
