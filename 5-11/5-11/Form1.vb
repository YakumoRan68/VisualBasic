Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim pwd As String
        Do
            pwd = InputBox("비밀번호", "입력")
            If (pwd <> "1234") Then
                Label1.Text = "다시 입력하세요."
            End If
        Loop Until pwd = "1234"
        Label1.Text = "올바른 비밀번호로 로그인에 성공"
    End Sub
End Class
