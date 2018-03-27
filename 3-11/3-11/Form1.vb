Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        With ListBox1.Items
            .Add("장갑")
            .Add("타월")
            .Add("양말")
            .Add("바지")
        End With
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ListBox1.Items.Add(TextBox1.Text)
        TextBox1.Text = ""
        TextBox1.Focus()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If ListBox1.Text = "" Then Return
        ListBox2.Items.Add(ListBox1.Text)
        ListBox1.Items.Remove(ListBox1.Text)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If ListBox2.Text = "" Then Return
        ListBox1.Items.Add(ListBox2.Text)
        ListBox2.Items.Remove(ListBox2.Text)
    End Sub
End Class
