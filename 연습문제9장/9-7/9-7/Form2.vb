Public Class Form2
    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        If ComboBox1.SelectedIndex = 1 Then
            Label2.Text = "반지름"
            Label3.Visible = false
            TextBox3.Visible = false
        Else
            Label2.Text = "가로"
            Label3.Visible = true
            TextBox3.Visible = true
        End If
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If ComboBox1.SelectedIndex = 0 Then
            TextBox4.Text = TextBox2.Text * TextBox3.Text
        ElseIf ComboBox1.SelectedIndex = 2 Then
            TextBox4.Text = TextBox2.Text * TextBox3.Text / 2 
        Else
            TextBox4.Text = TextBox2.Text ^ 2 * 3.14
        End If
    End Sub
End Class