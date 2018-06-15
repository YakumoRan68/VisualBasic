Public Class Form1
    Private Sub 종료ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 종료ToolStripMenuItem.Click
        end
    End Sub

    Private Sub 도형ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 도형ToolStripMenuItem.Click
        Form2.MdiParent = Me
        Form2.Show()
    End Sub
End Class
