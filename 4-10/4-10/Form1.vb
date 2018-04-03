Public Class Form1
    Private intX, inty, result As Integer

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        intX = Val(TextBox1.Text)
        inty = Val(TextBox2.Text)
        result = intX + inty
        TextBox3.Text = result
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        intX = Val(TextBox1.Text)
        inty = Val(TextBox2.Text)
        result = intX - inty
        TextBox3.Text = result
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        intX = Val(TextBox1.Text)
        inty = Val(TextBox2.Text)
        result = intX * inty
        TextBox3.Text = result
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        intX = Val(TextBox1.Text)
        inty = Val(TextBox2.Text)
        result = intX / inty
        TextBox3.Text = result
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox1.Focus()
    End Sub
End Class
