Public Class Form1
    Private Sub Homepage_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles Homepage.LinkClicked
        Process.Start("chrome", "http://www.hanbit.co.kr")
    End Sub
    Private Sub LinkLabel2_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        Dim startInfo As New ProcessStartInfo
        startInfo.FileName = "control.exe" '제어판
        startInfo.Arguments = "/name Microsoft.DefaultPrograms" '파라메터 값'
        Process.Start(startInfo)
    End Sub
End Class
