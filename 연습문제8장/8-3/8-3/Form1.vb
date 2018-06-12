Public Class Form1
    Private Sub TreeView1_AfterSelect(sender As Object, e As TreeViewEventArgs) Handles TreeView1.AfterSelect
        if TreeView1.SelectedNode.index = 0 then
            OvalShape1.Visible = true
            RectangleShape1.Visible = false
            LineShape1.Visible = false
        elseif TreeView1.SelectedNode.index = 1 then
            OvalShape1.Visible = false
            RectangleShape1.Visible = true
            LineShape1.Visible = False
        ElseIf TreeView1.SelectedNode.index = 2 then
            OvalShape1.Visible = false
            RectangleShape1.Visible = false
            LineShape1.Visible = true
        End If
    End Sub
End Class
