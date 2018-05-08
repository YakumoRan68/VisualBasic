Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim Doremi(7) As String
        Dim i As Integer

        Doremi(1) = "도"
        Doremi(2) = "레"
        Doremi(3) = "미"
        Doremi(4) = "파"
        Doremi(5) = "솔"
        Doremi(6) = "라"
        Doremi(7) = "시"

        For i = 1 To 7
            Label1.Text = Label1.Text + Doremi(i)
        Next

    End Sub
End Class
