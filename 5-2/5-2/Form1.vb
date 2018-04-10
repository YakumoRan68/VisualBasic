Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim result As String

        If TextBox2.Text >= 80 Then
            result = "합격입니다."
        Else
            result = "불합격입니다."
        End If

        MessageBox.Show(TextBox1.Text & "님의 점수는 " & TextBox2.Text & "입니다." & result)
    End Sub
End Class
