Public Class frmMain
    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DateTimePicker1.Format = DateTimePickerFormat.Long
        DateTimePicker1.Text = ""
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
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        RichTextBox1.SaveFile(DateTimePicker1.Text)
        MsgBox(DateTimePicker1.Text & "의 메모가 저장되었습니다!")
        RichTextBox1.Clear()
        Label1.Visible = False
    End Sub
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Try
            RichTextBox1.LoadFile(DateTimePicker1.Text)
            MsgBox(DateTimePicker1.Text & "의 메모를 불러왔습니다!")
            Label2.Text = DateTimePicker1.Text & "의 메모"
            Label2.Visible = True
        Catch ex As Exception
            MsgBox("해당 날짜에 메모가 존재하지 않습니다!")
        Finally

        End Try
    End Sub
End Class
