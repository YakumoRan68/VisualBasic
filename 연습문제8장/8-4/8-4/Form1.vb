Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TreeView1.Nodes.Add(TextBox1.text)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim SelectedNode = TreeView1.selectednode
        SelectedNode.Nodes.Add(TextBox2.text)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        TreeView1.Nodes.Remove(Treeview1.selectednode) 
    End Sub
End Class
