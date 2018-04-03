Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Su = "짝수"
        If TextBox1.Text Mod 2 = 1 Then Su = "홀수"
        MsgBox("입력하신 숫자는 " & Su & "입니다.")
    End Sub
End Class