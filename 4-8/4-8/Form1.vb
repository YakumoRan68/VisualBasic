Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim x, y As Boolean
        x = True
        y = False
        TextBox1.Text = "x And y : " & CStr(x And y) & vbCrLf &
                        "x or y : " & CStr(x Or y) & vbCrLf &
                        "x xor y : " & CStr(x Xor y) & vbCrLf &
                        "not x : " & CStr(Not x) & vbCrLf &
                        "x andalso y : " & CStr(x Or y) & vbCrLf &
                        "x orelse y : " & CStr(x Or y) & vbCrLf
    End Sub
End Class
