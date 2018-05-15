<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form은 Dispose를 재정의하여 구성 요소 목록을 정리합니다.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Windows Form 디자이너에 필요합니다.
    Private components As System.ComponentModel.IContainer

    '참고: 다음 프로시저는 Windows Form 디자이너에 필요합니다.
    '수정하려면 Windows Form 디자이너를 사용하십시오.  
    '코드 편집기에서는 수정하지 마세요.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.DirListBox1 = New Microsoft.VisualBasic.Compatibility.VB6.DirListBox()
        Me.FileListBox1 = New Microsoft.VisualBasic.Compatibility.VB6.FileListBox()
        Me.DriveListBox1 = New Microsoft.VisualBasic.Compatibility.VB6.DriveListBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'DirListBox1
        '
        Me.DirListBox1.FormattingEnabled = True
        Me.DirListBox1.IntegralHeight = False
        Me.DirListBox1.Location = New System.Drawing.Point(12, 43)
        Me.DirListBox1.Name = "DirListBox1"
        Me.DirListBox1.Size = New System.Drawing.Size(211, 127)
        Me.DirListBox1.TabIndex = 0
        '
        'FileListBox1
        '
        Me.FileListBox1.FormattingEnabled = True
        Me.FileListBox1.Location = New System.Drawing.Point(12, 187)
        Me.FileListBox1.Name = "FileListBox1"
        Me.FileListBox1.Pattern = "*.*"
        Me.FileListBox1.Size = New System.Drawing.Size(211, 100)
        Me.FileListBox1.TabIndex = 1
        '
        'DriveListBox1
        '
        Me.DriveListBox1.FormattingEnabled = True
        Me.DriveListBox1.Location = New System.Drawing.Point(12, 12)
        Me.DriveListBox1.Name = "DriveListBox1"
        Me.DriveListBox1.Size = New System.Drawing.Size(211, 22)
        Me.DriveListBox1.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(230, 43)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 12)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "드라이브"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(230, 82)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 12)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "디렉토리"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(230, 123)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(57, 12)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "파일 경로"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(230, 170)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(41, 12)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "파일명"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(230, 210)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(65, 12)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "파일확장자"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(301, 40)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(132, 21)
        Me.TextBox1.TabIndex = 8
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(301, 79)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(132, 21)
        Me.TextBox2.TabIndex = 9
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(301, 123)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(132, 21)
        Me.TextBox3.TabIndex = 10
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(301, 167)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(132, 21)
        Me.TextBox4.TabIndex = 11
        '
        'TextBox5
        '
        Me.TextBox5.Location = New System.Drawing.Point(301, 207)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(132, 21)
        Me.TextBox5.TabIndex = 12
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(275, 252)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(114, 35)
        Me.Button1.TabIndex = 13
        Me.Button1.Text = "파일 목록 갱신"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(489, 304)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TextBox5)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DriveListBox1)
        Me.Controls.Add(Me.FileListBox1)
        Me.Controls.Add(Me.DirListBox1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DirListBox1 As Compatibility.VB6.DirListBox
    Friend WithEvents FileListBox1 As Compatibility.VB6.FileListBox
    Friend WithEvents DriveListBox1 As Compatibility.VB6.DriveListBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents Button1 As Button
End Class
