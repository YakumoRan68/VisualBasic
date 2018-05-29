Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim k, cnt As Integer
        cnt = CheckedListBox1.Items.Count
        k = 0
        For i = 1 To cnt
            If CheckedListBox1.GetItemChecked(k) Then
                CheckedListBox2.Items.Add(CheckedListBox1.Items.Item(k))
                CheckedListBox1.Items.RemoveAt(k)
                cnt -= 1
            Else
                k += 1
            End If
        Next
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim k, cnt As Integer
        cnt = CheckedListBox2.Items.Count
        k = 0
        For i = 1 To cnt
            If CheckedListBox2.GetItemChecked(k) Then
                CheckedListBox1.Items.Add(CheckedListBox2.Items.Item(k))
                CheckedListBox2.Items.RemoveAt(k)
                cnt -= 1
            Else
                k += 1
            End If
        Next
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Label3.Text = CheckedListBox1.Items.Count
    End Sub
End Class
