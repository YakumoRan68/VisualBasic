Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        With ComboBox1.Items
            .Add("도착역")
            .Add("서울")
            .Add("대전")
            .Add("부산")
        End With
        ComboBox1.Text = ComboBox1.Items(0)

        With ComboBox2.Items
            .Add("열차종류")
            .Add("새마을")
            .Add("KTX")
        End With
        ComboBox2.Text = ComboBox2.Items(0)

        With ListBox1.Items
            .Add("영화관람")
            .Add("동반석")
            .Add("유아 동반")
            .Add("할인석")
        End With
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TextBox1.Text = "도착역은 " & ComboBox1.Text & "입니다. 기차 종류는 " & ComboBox2.Text & "이고, " & ListBox1.Text & "을 선택하셨습니다."
    End Sub
End Class
