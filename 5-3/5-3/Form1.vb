Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim result As String

        If TextBox2.Text >= 95 Then
                result = "A+"
            ElseIf TextBox2.Text >= 90 Then
                result = "A"
            ElseIf TextBox2.Text >= 85 Then
                result = "B+"
            ElseIf TextBox2.Text >= 80 Then
                result = "B"
            ElseIf TextBox2.Text >= 75 Then
                result = "C+"
            ElseIf TextBox2.Text >= 70 Then
                result = "C"
            ElseIf TextBox2.Text >= 65 Then
                result = "D+"
            ElseIf TextBox2.Text >= 60 Then
                result = "D"
            Else
                result = "F"
        End If

        MessageBox.Show(TextBox1.Text & "님의 점수는 " & TextBox2.Text & "입니다." & vbCrLf & "평점은 " & result & " 입니다.")
    End Sub
End Class
