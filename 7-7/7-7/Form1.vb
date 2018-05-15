Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Enabled = True
        Label1.Text = Hour(TimeOfDay) & ":" & Minute(TimeOfDay) & ":" & Second(TimeOfDay)
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Label1.Text = Hour(TimeOfDay) & ":" & Minute(TimeOfDay) & ":" & Second(TimeOfDay)
    End Sub
End Class
