Public Class Form1
    Public Structure score
        Dim name As String
        Dim mid As Integer
        Dim final As Integer
        Dim total As Integer
        Dim avg As Double
    End Structure
    Dim Vbscore(2) As score
    Private Sub setvb(n)
        TextBox1.Text = Vbscore(n).name
        TextBox2.Text = Vbscore(n).mid
        TextBox3.Text = Vbscore(n).final
        TextBox4.Text = Vbscore(n).total
        TextBox5.Text = Vbscore(n).avg
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Vbscore(0).name = "홍길동"
        Vbscore(0).mid = 90
        Vbscore(0).final = 97
        Vbscore(0).total = Vbscore(0).mid + Vbscore(0).final
        Vbscore(0).avg = Vbscore(0).total / 2.0

        setvb(0)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Vbscore(1).name = "이몽룡"
        Vbscore(1).mid = 98
        Vbscore(1).final = 95
        Vbscore(1).total = Vbscore(1).mid + Vbscore(1).final
        Vbscore(1).avg = Vbscore(1).total / 2.0

        setvb(1)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Vbscore(2).name = "심청이"
        Vbscore(2).mid = 100
        Vbscore(2).final = 97
        Vbscore(2).total = Vbscore(2).mid + Vbscore(2).final
        Vbscore(2).avg = Vbscore(2).total / 2.0

        setvb(2)
    End Sub
End Class
