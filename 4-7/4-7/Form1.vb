Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim a = "가", b = "가"

        TextBox1.Text = "23 = 25 = " & CStr(23 = 25) & vbCrLf &
                        "24 <> 24 = " & CStr(24 <> 24) & vbCrLf &
                        "31 > 33 = " & CStr(31 > 33) & vbCrLf &
                        "11 >= 10 = " & CStr(11 <> 10) & vbCrLf &
                        "9 < 15 = " & CStr(9 < 15) & vbCrLf &
                        "21 <= 21 = " & CStr(21 <= 21) & vbCrLf &
                        "&a Is &b  =" & CStr(a Is b) & vbCrLf & '두 개체(변수)가 가리키는 값을 비교'
                        "Basic Like Basi = " & CStr("Basic" Like "Basi") & vbCrLf '문자열 비교'
    End Sub
End Class
