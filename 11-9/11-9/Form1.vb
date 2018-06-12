Public Class Form1
    Dim dbConn As OleDb.OleDbConnection = New OleDb.OleDbConnection()
    Dim selectCom As OleDb.OleDbCommand = New OleDb.OleDbCommand()
    Dim insertCom As OleDb.OleDbCommand = New OleDb.OleDbCommand()
    Dim updateCom As OleDb.OleDbCommand = New OleDb.OleDbCommand()
    Dim deleteCom As OleDb.OleDbCommand = New OleDb.OleDbCommand()
    Dim dbDA As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter()
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: 이 코드는 데이터를 '학생정보DataSet.stuinfo' 테이블에 로드합니다. 필요 시 이 코드를 이동하거나 제거할 수 있습니다.
        Me.StuinfoTableAdapter.Fill(Me.학생정보DataSet.stuinfo)
    End Sub
    Private Sub db_connection()
        dbConn.ConnectionString = "DataSource = C:\학생정보.mdb"
        dbConn.Open()
        selectCom.Connection = dbConn
        selectCom.CommandText = "SELECT * FROM stuinfo"
    End Sub
    Private Sub db_update()
        dbDA.SelectCommand = selectCom
        dbDA.Fill(학생정보DataSet, "stuinfo")
        dbDA.Update(학생정보DataSet, "stuinfo")
        StuinfoTableAdapter.Fill(학생정보DataSet.stuinfo)
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form2.Show()
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        db_connection()
        insertCom.Connection = dbConn
        insertCom.CommandText = "INSERT INFO stuinfo(학번, 이름, 주소, 연락처) VALUES('" & TextBox1.Text & "', '" & TextBox2.Text & "','" & TextBox3.Text & "','" & TextBox4.Text & "')"
        insertCom.ExecuteNonQuery()
        db_update()
        StuinfoBindingSource.Position = BindingContext(StuinfoBindingSource).Count
        dbConn.Close()
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim pos As Integer
        db_connection()
        updateCom.Connection = dbConn
        updateCom.CommandText = "UPDATE stuinfo SET 이름 = '" & TextBox2.Text & "', 주소 = '" & TextBox3.Text & "', 연락처 = " & TextBox4.Text & "' WHERE 학번 = '" & TextBox1.Text & "'"
        updateCom.ExecuteNonQuery()
        pos = StuinfoBindingSource.Position
        db_update()
        StuinfoBindingSource.Position = pos
        dbConn.Close()
    End Sub
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim pos As Integer
        db_connection()
        deleteCom.Connection = dbConn
        deleteCom.CommandText = "DELETE FORM stuinfo WHERE 학번 = '" & TextBox1.Text & "'"
        deleteCom.ExecuteNonQuery()
        pos = StuinfoBindingSource.Position
        db_update()
        StuinfoBindingSource.Position = pos
        dbConn.Close()
    End Sub
End Class
