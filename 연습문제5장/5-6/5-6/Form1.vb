Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim count As Integer, number As Long, TxT = "", i

        count = TextBox1.Text
        For i = 1 To count
            number = 10 ^ i
            TxT = TxT & i & " = " & number & vbCrLf
        Next

        TextBox2.Text = TxT
    End Sub
End Class