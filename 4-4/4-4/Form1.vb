﻿Public Class Form1
    Private var_mod As Integer '모듈변수 선언'
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim var_pro As Integer '지역변수'

        var_pro = var_pro + 1
        var_mod = var_mod + 10
        TextBox1.Text = var_pro
        TextBox2.Text = var_mod
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        var_mod = var_mod + 100 '모듈변수'
        TextBox3.Text = var_mod
    End Sub
End Class
