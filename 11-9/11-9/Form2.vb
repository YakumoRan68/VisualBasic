Public Class Form2
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: 이 코드는 데이터를 '학생정보DataSet.stuinfo' 테이블에 로드합니다. 필요 시 이 코드를 이동하거나 제거할 수 있습니다.
        Me.StuinfoTableAdapter.Fill(Me.학생정보DataSet.stuinfo)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub
End Class