Public Class frmMain
    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DateTimePicker1.Format = DateTimePickerFormat.Long
        DateTimePicker1.Value = Now
        Label1.Text = "금일은 " & Now.Year & "년 " & Now.Month & "월 " & Now.Day & "일 입니다"
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If (DateTimePicker1.Value.Date < Now.Date) Then
            MsgBox("지나간 날자에 일정을 추가할 수 없습니다!", vbOKOnly, "Error")
        ElseIf (TextBox1.Text = "") Then
            MsgBox("추가할 내용을 입력해주세요!")
            TextBox1.Focus()
        Else
            CheckedListBox1.Items.Add(DateTimePicker1.Text & " " & TextBox1.Text)
            TextBox1.Clear()
        End If
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim k, cnt As Integer
        cnt = CheckedListBox1.Items.Count
        For i = 1 To cnt
            If CheckedListBox1.GetItemChecked(k) Then
                CheckedListBox1.Items.RemoveAt(k)
                cnt -= 1
            Else
                k += 1
            End If
        Next
    End Sub
End Class
