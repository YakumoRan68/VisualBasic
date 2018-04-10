Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim result As String
        Dim score As Integer

        score = TextBox2.Text

        'If score < 0 Or score > 100 Then GoTo WRONG
        Select Case score
            Case 100
                result = "A+"
            Case Is >= 95
                result = "A+"
            Case Is >= 90
                result = "A"
            Case Is >= 85
                result = "B+"
            Case Is >= 80
                result = "B"
            Case Is >= 75
                result = "C+"
            Case Is >= 70
                result = "C"
            Case Is >= 65
                result = "D+"
            Case Is >= 60
                result = "D"
            Case Else
                result = "F"
        End Select
        MsgBox(TextBox1.Text & "님의 점수는 " & TextBox2.Text & "입니다." & vbCrLf & "평점은" & result & "입니다." & vbOKOnly, "결과 확인")
        GoTo Right
WRONG:
        MsgBox(TextBox1.Text & "님의 점수는 잘못된 점수입니다." & vbCrLf & "점수는 1부터 100까지의 범위로 입력하세요.", vbOKOnly, "잘못입력")
Right:
    End Sub
End Class
