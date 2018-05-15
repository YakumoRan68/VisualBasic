Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Label5.Text = "시작! " & NumericUpDown2.Value & "회 남았습니다."
        Timer1.Interval = NumericUpDown1.Value * 1000
        Timer1.Start()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If NumericUpDown2.Value > 0 Then
            NumericUpDown2.Value -= 1
            Label5.Text = NumericUpDown2.Value & "회 남았습니다."
        Else
            Timer1.Stop()
        End If
    End Sub
End Class
