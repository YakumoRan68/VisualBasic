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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(27, 59)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(29, 12)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "영어"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(27, 26)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(29, 12)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "국어"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(27, 93)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(29, 12)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "수학"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(27, 157)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(41, 12)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "총점 : "
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(69, 157)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(0, 12)
        Me.Label5.TabIndex = 3
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(71, 22)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 21)
        Me.TextBox1.TabIndex = 4
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(71, 55)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(100, 21)
        Me.TextBox2.TabIndex = 5
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(71, 89)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(100, 21)
        Me.TextBox3.TabIndex = 6
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(71, 122)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(100, 23)
        Me.Button1.TabIndex = 7
        Me.Button1.Text = "총점 구하기"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(210, 194)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Button1 As Button
End Class
