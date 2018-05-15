Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim newFs As Single = HScrollBar1.Value
        TextBox1.Font = New Font("굴림", newFs)
        TextBox1.ForeColor = Color.FromArgb(QBColor(VScrollBar1.Value))
    End Sub
    Private Sub HScrollBar1_Scroll(sender As Object, e As ScrollEventArgs) Handles HScrollBar1.Scroll
        Dim newFs As Single = HScrollBar1.Value
        TextBox1.Font = New Font("굴림", newFs)
    End Sub
    Private Sub VScrollBar1_Scroll(sender As Object, e As ScrollEventArgs) Handles VScrollBar1.Scroll
        TextBox1.ForeColor = Color.FromArgb(QBColor(VScrollBar1.Value))
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TextBox1.ForeColor = Color.Red
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox1.ForeColor = Color.Blue
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        TextBox1.ForeColor = Color.Black
    End Sub
End Class
