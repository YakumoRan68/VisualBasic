Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Alphabet() As String = {"A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z"}
        Dim order As Integer = TextBox1.Text

        If order >= 1 And order <= 26 Then
            Label1.Text = "선택한 문자는 " & Alphabet(order - 1) & " 입니다."
        Else
            Label1.Text = "1 ~ 26 사이의 숫자를 입력하시오."
        End If
    End Sub
End Class
