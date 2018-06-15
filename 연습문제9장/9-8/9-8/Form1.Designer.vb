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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.열기ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.창보기ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.계단식ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.수직바둑판식ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.수평바둑판식ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout
        Me.SuspendLayout
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.열기ToolStripMenuItem, Me.창보기ToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(504, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        '열기ToolStripMenuItem
        '
        Me.열기ToolStripMenuItem.Name = "열기ToolStripMenuItem"
        Me.열기ToolStripMenuItem.Size = New System.Drawing.Size(43, 20)
        Me.열기ToolStripMenuItem.Text = "열기"
        '
        '창보기ToolStripMenuItem
        '
        Me.창보기ToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.계단식ToolStripMenuItem, Me.수직바둑판식ToolStripMenuItem, Me.수평바둑판식ToolStripMenuItem})
        Me.창보기ToolStripMenuItem.Name = "창보기ToolStripMenuItem"
        Me.창보기ToolStripMenuItem.Size = New System.Drawing.Size(55, 20)
        Me.창보기ToolStripMenuItem.Text = "창보기"
        '
        '계단식ToolStripMenuItem
        '
        Me.계단식ToolStripMenuItem.Name = "계단식ToolStripMenuItem"
        Me.계단식ToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.계단식ToolStripMenuItem.Text = "계단식"
        '
        '수직바둑판식ToolStripMenuItem
        '
        Me.수직바둑판식ToolStripMenuItem.Name = "수직바둑판식ToolStripMenuItem"
        Me.수직바둑판식ToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.수직바둑판식ToolStripMenuItem.Text = "수직바둑판식"
        '
        '수평바둑판식ToolStripMenuItem
        '
        Me.수평바둑판식ToolStripMenuItem.Name = "수평바둑판식ToolStripMenuItem"
        Me.수평바둑판식ToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.수평바둑판식ToolStripMenuItem.Text = "수평바둑판식"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7!, 12!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(504, 450)
        Me.Controls.Add(Me.MenuStrip1)
        Me.IsMdiContainer = true
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "MDI 폼 201804011"
        Me.MenuStrip1.ResumeLayout(false)
        Me.MenuStrip1.PerformLayout
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents 열기ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 창보기ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 계단식ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 수직바둑판식ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 수평바둑판식ToolStripMenuItem As ToolStripMenuItem
End Class
