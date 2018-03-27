Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox1.Text = "3 ^ 4 = " & 3 ^ 4 & vbCrLf &
                        "4 * 6 = " & 4 * 6 & vbCrLf &
                        "8 / 3 = " & 8 / 3 & vbCrLf &
                        "4 \ 3 = " & 4 \ 3 & vbCrLf & '몫'
                        "8 mod 3 = " & 3 Mod 4 & vbCrLf & '나머지'
                        "2 + 5 = " & 2 + 5 & vbCrLf &
                        "5 - 3 = " & 5 - 3
    End Sub
End Class
