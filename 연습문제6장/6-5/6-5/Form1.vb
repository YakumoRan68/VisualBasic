Public Class Form1
    Private rdn As New Random
    Private COLS = 5, ROWS = 3, ARRNUM As Integer 'ROW = 행, 가로 방향의 집합, 세로로 셈
    Private Arr(ROWS, COLS) As Integer

    Private Sub SetText(ByVal NUM, ByVal TxT)
        Dim TB As TextBox = CType(Controls.Find("TextBox" & NUM, True).ElementAt(0), TextBox) 'TextBox+인덱스' 값을 구해준다
        TB.Text = Int(TxT)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        For i = 1 To ROWS
            For j = 1 To COLS
                Arr(i, j) = rdn.Next(5, 100) '= Int((100 - 5 + 1) * Rnd() + 5)
                ARRNUM = (i - 1) * COLS + j 'TextBox 네임의 인덱스값 구함
                SetText(ARRNUM, Arr(i, j))
            Next
        Next
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim sum As Integer, TxT As String = ""

        For i = 1 To ROWS '가로 인덱스 합계
            For j = 1 To COLS
                sum = sum + Arr(i, j)
            Next
            If TxT = "" Then
                TxT = sum
            Else
                TxT = TxT & ", " & sum
            End If
        Next

        TextBox16.Text = TxT
        TxT = "" : sum = 0

        For i = 1 To COLS '세로 인덱스 합계
            For j = 1 To ROWS
                sum = sum + Arr(j, i)
            Next
            If TxT = "" Then
                TxT = sum
            Else
                TxT = TxT & ", " & sum
            End If
        Next
        TextBox17.Text = TxT

        For i = 1 To ROWS '전체 인덱스 합계
            For j = 1 To COLS
                sum = sum + Arr(i, j)
            Next
        Next
        TextBox18.Text = sum
    End Sub
End Class
