Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim sum As Integer
        sum = Val(TextBox2.Text) + Val(TextBox3.Text) + Val(TextBox4.Text) + Val(TextBox5.Text)
        TextBox6.Text = sum
        TextBox7.Text = sum / 4

        Dim Rank As String
        Select Case (sum / 4)
            Case 95 To 100
                Rank = "A+"
            Case Is >= 90
                Rank = "A"
            Case Is >= 85
                Rank = "B+"
            Case Is >= 80
                Rank = "B"
            Case Is >= 75
                Rank = "C+"
            Case Is >= 70
                Rank = "C"
            Case Is >= 65
                Rank = "D+"
            Case Is >= 60
                Rank = "D"
            Case Else
                Rank = "F"
        End Select

        MsgBox(TextBox1.Text & "님의 평점은 " & Rank & "입니다.")
    End Sub
End Class
