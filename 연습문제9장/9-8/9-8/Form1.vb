Public Class Form1
    Private Sub 열기ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 열기ToolStripMenuItem.Click
        Form2.Show()
        Form2.MdiParent = Me
        Form3.Show()
        Form3.MdiParent = Me
        Form4.Show()
        Form4.MdiParent = Me
    End Sub

    Private Sub 계단식ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 계단식ToolStripMenuItem.Click
        Me.LayoutMdi(MdiLayout.Cascade)
    End Sub

    Private Sub 수직바둑판식ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 수직바둑판식ToolStripMenuItem.Click
        Me.LayoutMdi(MdiLayout.TileHorizontal)
    End Sub

    Private Sub 수평바둑판식ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 수평바둑판식ToolStripMenuItem.Click
        Me.LayoutMdi(MdiLayout.TileVertical)
    End Sub
End Class
