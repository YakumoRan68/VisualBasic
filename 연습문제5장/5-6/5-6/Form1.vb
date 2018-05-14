Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim number As Long, TxT = "", i As Integer, n As Integer

        n = TextBox1.Text
        For i = 1 To 10
            number = n ^ i
            TxT = TxT & i & " = " & number & vbCrLf
        Next

        TextBox2.Text = TxT
    End Sub

End Class