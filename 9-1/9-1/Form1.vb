Public Class Form1
    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Dim digmessage As DialogResult
        digmessage = MessageBox.Show("종료할까요?", "종료확인", MessageBoxButtons.YesNo)
        If digmessage = DialogResult.No Then
            e.Cancel = True
        End If
    End Sub
End Class
