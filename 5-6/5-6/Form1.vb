Public Class Form1
    Dim coin As Integer
    Dim selection As Integer
    Dim orange = 0
    Dim grape = 0
    Dim apple = 0
    Dim mango = 0
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Button2.Enabled = False
        Button3.Enabled = False
        Label2.Visible = False
        Label3.Text = "잔액 : 0원"
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text = "" Then
            MsgBox("투입할 금액을 입력하시오.")
        Else
            coin = TextBox1.Text
            TextBox1.Enabled = False
            Button1.Enabled = False
            Button2.Enabled = True
            Button3.Enabled = True
        End If
    End Sub
    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        selection = 1
    End Sub
    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        selection = 2
    End Sub
    Private Sub RadioButton3_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton3.CheckedChanged
        selection = 3
    End Sub
    Private Sub RadioButton4_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton4.CheckedChanged
        selection = 4
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Select Case selection
            Case 1
                If coin >= 1000 Then
                    coin -= 1000
                    orange += 1
                Else
                    MsgBox("금액이 부족합니다.")
                End If
            Case 2
                If coin >= 700 Then
                    coin -= 700
                    grape += 1
                Else
                    MsgBox("금액이 부족합니다.")
                End If
            Case 3
                If coin >= 500 Then
                    coin -= 500
                    apple += 1
                Else
                    MsgBox("금액이 부족합니다.")
                End If
            Case 4
                If coin >= 100 Then
                    coin -= 100
                    mango += 1
                Else
                    MsgBox("금액이 부족합니다.")
                End If
        End Select
        Label3.Text = "잔액 : " & coin & "원"
        Label2.Text = "오렌지 주스 : " & orange & "개" & vbCr & "포도 주스 :" & grape & "개" & vbCr & "사과 주스 : " & apple & "개" & vbCr & "망고 주스 : " & mango & "개"
        Label2.Visible = True
        Label3.Visible = True
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        TextBox1.Text = ""
        orange = 0
        grape = 0
        apple = 0
        mango = 0
        TextBox1.Enabled = True
        Button1.Enabled = True
        Button2.Enabled = True
        Button3.Enabled = True
        Label2.Visible = False
        Label3.Visible = False
    End Sub
End Class
