Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        '프로젝트 - 속성 - 컴파일탭 - Option Explicit = Off
        '묵시적 선언
        Kor = TextBox1.Text
        Eng = TextBox2.Text
        Mat = TextBox3.Text
        Total = Kor + Eng + Mat
        Label5.Text = Total
    End Sub
End Class
