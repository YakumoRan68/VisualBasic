Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim properties As FontStyle

        If RadioButton1.Checked Then TextBox1.ForeColor = Color.Black
        If RadioButton2.Checked Then TextBox1.ForeColor = Color.Red
        If RadioButton3.Checked Then TextBox1.ForeColor = Color.Blue

        If CheckBox1.Checked Then properties = properties Or FontStyle.Bold
        If CheckBox2.Checked Then properties = properties Or FontStyle.Underline
        If CheckBox3.Checked Then properties = properties Or FontStyle.Italic

        TextBox1.Font = New Font(Font.FontFamily, Font.Size, properties)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        End
    End Sub

End Class
