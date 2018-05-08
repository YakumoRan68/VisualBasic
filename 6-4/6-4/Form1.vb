Public Class Form1
    Dim DynamicArray() As Integer
    Dim i As Integer
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ReDim DynamicArray(2)
        For i = 1 To UBound(DynamicArray)
            DynamicArray(i) = DynamicArray(i) + 8
            TextBox1.Text = TextBox1.Text & "Array(" & i & ") = " & DynamicArray(i) & vbCrLf
        Next
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ReDim DynamicArray(5)
        For i = 1 To UBound(DynamicArray)
            DynamicArray(i) = DynamicArray(i) + 10
            TextBox2.Text = TextBox2.Text & "Array(" & i & ") = " & DynamicArray(i) & vbCrLf
        Next
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ReDim DynamicArray(10)
        For i = 1 To UBound(DynamicArray)
            DynamicArray(i) = DynamicArray(i) + 10
            TextBox3.Text = TextBox3.Text & "Array(" & i & ") = " & DynamicArray(i) & vbCrLf
        Next
    End Sub
End Class
