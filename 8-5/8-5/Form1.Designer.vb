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
        Me.Internet = New System.Windows.Forms.Label()
        Me.ini = New System.Windows.Forms.Label()
        Me.Homepage = New System.Windows.Forms.LinkLabel()
        Me.LinkLabel2 = New System.Windows.Forms.LinkLabel()
        Me.SuspendLayout()
        '
        'Internet
        '
        Me.Internet.AutoSize = True
        Me.Internet.Location = New System.Drawing.Point(32, 29)
        Me.Internet.Name = "Internet"
        Me.Internet.Size = New System.Drawing.Size(28, 12)
        Me.Internet.TabIndex = 0
        Me.Internet.Text = "URL"
        '
        'ini
        '
        Me.ini.AutoSize = True
        Me.ini.Location = New System.Drawing.Point(32, 114)
        Me.ini.Name = "ini"
        Me.ini.Size = New System.Drawing.Size(77, 12)
        Me.ini.TabIndex = 1
        Me.ini.Text = "기본프로그램"
        '
        'Homepage
        '
        Me.Homepage.AutoSize = True
        Me.Homepage.Location = New System.Drawing.Point(109, 29)
        Me.Homepage.Name = "Homepage"
        Me.Homepage.Size = New System.Drawing.Size(141, 12)
        Me.Homepage.TabIndex = 2
        Me.Homepage.TabStop = True
        Me.Homepage.Text = "http://www.hanbit.co.kr"
        '
        'LinkLabel2
        '
        Me.LinkLabel2.AutoSize = True
        Me.LinkLabel2.Location = New System.Drawing.Point(131, 114)
        Me.LinkLabel2.Name = "LinkLabel2"
        Me.LinkLabel2.Size = New System.Drawing.Size(29, 12)
        Me.LinkLabel2.TabIndex = 3
        Me.LinkLabel2.TabStop = True
        Me.LinkLabel2.Text = "열기"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(336, 194)
        Me.Controls.Add(Me.LinkLabel2)
        Me.Controls.Add(Me.Homepage)
        Me.Controls.Add(Me.ini)
        Me.Controls.Add(Me.Internet)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Internet As Label
    Friend WithEvents ini As Label
    Friend WithEvents Homepage As LinkLabel
    Friend WithEvents LinkLabel2 As LinkLabel
End Class
