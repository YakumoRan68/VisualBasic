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
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.VScrollBar1 = New System.Windows.Forms.VScrollBar()
        Me.HScrollBar1 = New System.Windows.Forms.HScrollBar()
        Me.SuspendLayout()
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(23, 12)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(280, 104)
        Me.TextBox1.TabIndex = 0
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(22, 122)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(93, 33)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "빨강"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(116, 122)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(93, 33)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "파랑"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(210, 122)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(93, 33)
        Me.Button3.TabIndex = 3
        Me.Button3.Text = "검정"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(326, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(29, 12)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "색상"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(20, 176)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(29, 12)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "크기"
        '
        'VScrollBar1
        '
        Me.VScrollBar1.LargeChange = 5
        Me.VScrollBar1.Location = New System.Drawing.Point(322, 31)
        Me.VScrollBar1.Maximum = 15
        Me.VScrollBar1.Name = "VScrollBar1"
        Me.VScrollBar1.Size = New System.Drawing.Size(40, 157)
        Me.VScrollBar1.TabIndex = 5
        Me.VScrollBar1.Value = 5
        '
        'HScrollBar1
        '
        Me.HScrollBar1.Location = New System.Drawing.Point(53, 167)
        Me.HScrollBar1.Maximum = 72
        Me.HScrollBar1.Minimum = 2
        Me.HScrollBar1.Name = "HScrollBar1"
        Me.HScrollBar1.Size = New System.Drawing.Size(250, 28)
        Me.HScrollBar1.TabIndex = 6
        Me.HScrollBar1.Value = 9
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(385, 208)
        Me.Controls.Add(Me.HScrollBar1)
        Me.Controls.Add(Me.VScrollBar1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TextBox1)
        Me.Name = "Form1"
        Me.Text = "스크롤바"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents VScrollBar1 As VScrollBar
    Friend WithEvents HScrollBar1 As HScrollBar
End Class
