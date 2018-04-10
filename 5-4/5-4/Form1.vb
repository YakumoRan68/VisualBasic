Public Class Form1
    Dim i As Integer
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        i = Rnd(1) * 100
        Label3.Text = i
        Label3.Visible = False
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        i = Rnd(1) * 100
        Label2.Text = "준비"
        Label3.Visible = False
        Label3.Text = i
        TextBox1.Text = ""
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If TextBox1.Text = "" Then
            MsgBox("값을 입력하세요", vbOKOnly, "에러")
        ElseIf TextBox1.Text > i Then
            Label2.Text = "정답은" & TextBox1.Text & "보다 작습니다."
        ElseIf TextBox1.Text < i Then
            Label2.Text = "정답은" & TextBox1.Text & "보다 작습니다."
        Else
            Label2.Text = "정답입니다!"
            Label3.Visible = True
        End If
    End Sub
End Class
