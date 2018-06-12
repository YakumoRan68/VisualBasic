Public Class Form1
    Private Sub Form1_MouseEnter(sender As Object, e As EventArgs) Handles Me.MouseEnter
        TextBox1.Text = "마우스 포인터가 폼 안에 있어요."
    End Sub

    Private Sub Form1_MouseLeave(sender As Object, e As EventArgs) Handles Me.MouseLeave
        TextBox1.Text = "마우스 포인터가 폼 밖에 있어요."
    End Sub

    Private Sub Form1_MouseUp(sender As Object, e As MouseEventArgs) Handles Me.MouseUp
        TextBox1.Text = "마우스를 클릭했네요."
    End Sub
End Class
