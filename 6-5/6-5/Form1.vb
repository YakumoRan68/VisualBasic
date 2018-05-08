Imports System.Collections
Public Class Form1
    Dim words As New ArrayList()
    Dim sentence As String = ""
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        words.Add(TextBox1.Text)
        Print_Result()
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        words.Remove(TextBox1.Text)
        Print_Result()
    End Sub
    Private Sub Print_result()
        Dim i As Integer
        sentence = ""
        For i = 0 To words.Count - 1
            sentence = sentence & " " & words.Item(i)
        Next
        Label3.Text = sentence
        Label5.Text = words.Count
    End Sub
End Class
