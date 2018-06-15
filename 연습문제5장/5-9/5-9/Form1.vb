Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim height, weight, Aweight As Integer, BMI As Double
        height = TextBox1.Text
        weight = TextBox2.Text
        Aweight = (height - 100) * 0.9
        BMI = weight/ Aweight * 100

        TextBox3.Text = "표준체중은 " & Aweight & "이고 비만도는 " & BMI & "입니다."
    End Sub
End Class
