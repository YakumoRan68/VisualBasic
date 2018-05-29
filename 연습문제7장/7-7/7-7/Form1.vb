Public Class Form1
    Dim Sec = 0
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Enabled = True
        TextBox1.Text = TimeOfDay
    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        TextBox1.Text = TimeOfDay
        Sec = TimeOfDay.Second() Mod 54
        OvalShape1.FillStyle = Sec - 2
    End Sub
End Class
