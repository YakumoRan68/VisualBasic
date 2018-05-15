Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox1.Text = DriveListBox1.Drive
        TextBox2.Text = DirListBox1.Path
        TextBox3.Text = FileListBox1.Path
        TextBox4.Text = FileListBox1.FileName
        TextBox5.Text = FileListBox1.Pattern
    End Sub
    Private Sub DriveListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles DriveListBox1.SelectedIndexChanged
        TextBox1.Text = DriveListBox1.Drive
        TextBox2.Text = DirListBox1.Path
        TextBox3.Text = FileListBox1.Path
        TextBox4.Text = FileListBox1.FileName
        TextBox5.Text = FileListBox1.Pattern
    End Sub
    Private Sub DirListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles DirListBox1.SelectedIndexChanged
        TextBox1.Text = DriveListBox1.Drive
        TextBox2.Text = DirListBox1.Path
        TextBox3.Text = FileListBox1.Path
        TextBox4.Text = FileListBox1.FileName
        TextBox5.Text = FileListBox1.Pattern
    End Sub
    Private Sub FileListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles FileListBox1.SelectedIndexChanged
        TextBox1.Text = DriveListBox1.Drive
        TextBox2.Text = DirListBox1.Path
        TextBox3.Text = FileListBox1.Path
        TextBox4.Text = FileListBox1.FileName
        TextBox5.Text = FileListBox1.Pattern
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        FileListBox1.Pattern = TextBox5.Text
        FileListBox1.Refresh()
        TextBox1.Text = DriveListBox1.Drive
        TextBox2.Text = DirListBox1.Path
        TextBox3.Text = FileListBox1.Path
        TextBox4.Text = FileListBox1.FileName
        TextBox5.Text = FileListBox1.Pattern
    End Sub
End Class
