Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ToolStripStatusLabel1.Text = "재생"
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ToolStripStatusLabel1.Text = "정지"
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If (ToolStripStatusLabel2.Text = "일방") Then
            ToolStripStatusLabel2.Text = "반복"
        Else
            ToolStripStatusLabel2.Text = "일방"
        End If
    End Sub
End Class
