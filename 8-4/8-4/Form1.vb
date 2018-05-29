Public Class frmMain
    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DateTimePicker1.Format = DateTimePickerFormat.Long
        DateTimePicker1.Text = ""
        DateTimePicker1.Value = Now
        Label1.Text = "금일은 " & Now.Year & "년 " & Now.Month & "월 " & Now.Day & "일 입니다"

        Try
            RichTextBox1.LoadFile(DateTimePicker1.Text)
            Label2.Text = DateTimePicker1.Text & "의 메모"
            Label2.Visible = True
        Catch ex As Exception
            RichTextBox1.Text = "금일은 메모가 없습니다."
        End Try

        ToolTip1.SetToolTip(Label1, "금일 날짜를 나타냅니다")
        ToolTip2.SetToolTip(DateTimePicker1, "일정을 작성할 날짜를 선택하세요")
        ToolTip3.SetToolTip(CheckedListBox1, "일정들을 나타냅니다")
        ToolTip4.SetToolTip(TextBox1, "추가할 일정을 입력합니다")
        ToolTip5.SetToolTip(RichTextBox1, "메모를 나타냅니다")
        ToolTip6.SetToolTip(Button1, "날짜를 선택한 후 추가할 내용을 입력하고 클릭하세요")
        ToolTip7.SetToolTip(Button2, "삭제할 일정을 체크한 후 클릭하세요")
        ToolTip8.SetToolTip(Button3, "날짜를 선택한 후 메모할 내용을 입력하고 클릭하세요. 기존의 파일에 덮어씁니다.")
        ToolTip9.SetToolTip(Button4, "메모를 확인할 날짜를 선택한 후 클릭하세요")
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
