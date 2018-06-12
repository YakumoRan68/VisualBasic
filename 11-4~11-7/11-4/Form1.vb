Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: 이 코드는 데이터를 '학생정보DataSet.stuinfo' 테이블에 로드합니다. 필요 시 이 코드를 이동하거나 제거할 수 있습니다.
        Me.StuinfoTableAdapter.Fill(Me.학생정보DataSet.stuinfo)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim RowCnt As Integer
        RowCnt = BindingContext(StuinfoBindingSource).Count
        If RowCnt > 0 Then
            StuinfoBindingSource.Position = 0
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim RowCnt As Integer
        RowCnt = BindingContext(StuinfoBindingSource).Count
        If RowCnt > 0 Then
            StuinfoBindingSource.Position = StuinfoBindingSource.Position - 1
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim RowCnt As Integer
        RowCnt = BindingContext(StuinfoBindingSource).Count
        If RowCnt > StuinfoBindingSource.Position Then
            StuinfoBindingSource.Position = StuinfoBindingSource.Position + 1
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim RowCnt As Integer
        RowCnt = BindingContext(StuinfoBindingSource).Count
        If RowCnt > 0 Then
            StuinfoBindingSource.Position = RowCnt - 1
        End If
    End Sub
End Class
