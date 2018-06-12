Public Class Form1
    Private Sub VScrollBar1_Scroll(sender As Object, e As ScrollEventArgs) Handles VScrollBar1.Scroll
        Dim HeightValue = VScrollBar1.Value
        PictureBox1.Height = HeightValue
    End Sub

    Private Sub HScrollBar1_Scroll(sender As Object, e As ScrollEventArgs) Handles HScrollBar1.Scroll
        Dim WidthValue = HScrollBar1.Value
        PictureBox1.Width = WidthValue
    End Sub
End Class

