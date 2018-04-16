Public Class Form1
    Private Function IsSoSu(a As Integer)
        Dim i = 2
        While i <= a
            If i = a Then
                Return "입니다"
            ElseIf a Mod i = 0 Then
                Return "가 아닙니다"
            End If
            i += 1
        End While
        End
    End Function

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Num = TextBox1.Text
        MsgBox("입력한 숫자는 소수" & IsSoSu(Num))
    End Sub

End Class