Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        With ComboBox2
            .Items.Add("서울특별시")
            .Items.Add("인천광역시")
            .Items.Add("대전광역시")
            .Items.Add("대전광역시")
            .Items.Add("부산광역시")
            .Items.Add("광주광역시")
            .Items.Add("울산광역시")
            .Text = .Items(0)
        End With
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MsgBox(ComboBox1.Text & TextBox1.Text & "님은 " & ComboBox2.Text & "에 거주하십니다")
    End Sub
End Class
