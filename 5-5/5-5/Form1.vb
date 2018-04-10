Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim result As String
        Dim score As Integer

        score = TextBox2.Text
        If Not Integer.TryParse(TextBox2.Text, score) Then
            score = 0
        End If

        Select Case score
            Case 100
                result = "A+"
            Case 95 To 99 'n to n'
                result = "A+"
            Case 90 To 94
                result = "A"
            Case Is >= 85 'n >= '
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

        MsgBox(TextBox1.Text & "님의 점수는" & TextBox2.Text & "입니다." & vbCrLf & "평점은" & result & "입니다.")
    End Sub
End Class
