Public Class Form1
    Private Sec = 0
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        For Each i In {1, 2, 4}
            Dim cb As ComboBox = Controls("GroupBox1").Controls("combobox" & i)
            cb.Items.AddRange({"Solid", "Dash", "Dot", "DashDot", "DashDotDot"})
            cb.SelectedIndex = 0
        Next
        For Each i In {3, 5}
            Dim cb As ComboBox = Controls("GroupBox1").Controls("combobox" & i)
            For j = -2 To 52
                Dim shadeName As String = CType(j, PowerPacks.FillStyle).ToString()
                cb.Items.Add(shadeName)
            Next
            cb.SelectedIndex = 0
        Next
        Timer1.Interval = 1000 '기본값 : 100
        Timer1.Start()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim value = ComboBox1.SelectedIndex
        LineShape1.BorderStyle = value
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim value = ComboBox2.SelectedIndex
        OvalShape1.BorderStyle = value

        value = ComboBox3.SelectedIndex
        OvalShape1.FillStyle = value - 2
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim value = ComboBox4.SelectedIndex
        RectangleShape1.BorderStyle = value

        value = ComboBox5.SelectedIndex
        RectangleShape1.FillStyle = value - 2
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Sec += 1
        If Sec > 54 Then
            Sec = 0
        End If
        RectangleShape1.FillStyle = Sec - 2
        ComboBox5.SelectedIndex = Sec
    End Sub
End Class
