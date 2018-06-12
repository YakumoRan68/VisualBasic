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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.toolOpen = New System.Windows.Forms.ToolStripButton()
        Me.toolEdit = New System.Windows.Forms.ToolStripDropDownButton()
        Me.popUp = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.menuCopy = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuCut = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuPaste = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.toolExit = New System.Windows.Forms.ToolStripButton()
        Me.ToolStrip1.SuspendLayout()
        Me.popUp.SuspendLayout()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.toolOpen, Me.toolEdit, Me.ToolStripSeparator1, Me.toolExit})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(284, 25)
        Me.ToolStrip1.TabIndex = 0
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'toolOpen
        '
        Me.toolOpen.BackColor = System.Drawing.SystemColors.Control
        Me.toolOpen.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.toolOpen.Image = CType(resources.GetObject("toolOpen.Image"), System.Drawing.Image)
        Me.toolOpen.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.toolOpen.Name = "toolOpen"
        Me.toolOpen.Size = New System.Drawing.Size(23, 22)
        Me.toolOpen.Text = "열기"
        Me.toolOpen.ToolTipText = "Open"
        '
        'toolEdit
        '
        Me.toolEdit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.toolEdit.DropDown = Me.popUp
        Me.toolEdit.Image = CType(resources.GetObject("toolEdit.Image"), System.Drawing.Image)
        Me.toolEdit.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.toolEdit.Name = "toolEdit"
        Me.toolEdit.Size = New System.Drawing.Size(29, 22)
        Me.toolEdit.Text = "편집"
        '
        'popUp
        '
        Me.popUp.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.menuCopy, Me.menuCut, Me.menuPaste})
        Me.popUp.Name = "ContextMenuStrip1"
        Me.popUp.Size = New System.Drawing.Size(138, 70)
        '
        'menuCopy
        '
        Me.menuCopy.Name = "menuCopy"
        Me.menuCopy.Size = New System.Drawing.Size(137, 22)
        Me.menuCopy.Text = "복사(&C)"
        '
        'menuCut
        '
        Me.menuCut.Name = "menuCut"
        Me.menuCut.Size = New System.Drawing.Size(137, 22)
        Me.menuCut.Text = "잘라내기(&X)"
        '
        'menuPaste
        '
        Me.menuPaste.Name = "menuPaste"
        Me.menuPaste.Size = New System.Drawing.Size(137, 22)
        Me.menuPaste.Text = "붙여넣기(&P)"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'toolExit
        '
        Me.toolExit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.toolExit.Image = CType(resources.GetObject("toolExit.Image"), System.Drawing.Image)
        Me.toolExit.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.toolExit.Name = "toolExit"
        Me.toolExit.Size = New System.Drawing.Size(23, 22)
        Me.toolExit.Text = "종료"
        Me.toolExit.ToolTipText = "Exit"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 262)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.popUp.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents popUp As ContextMenuStrip
    Friend WithEvents menuCopy As ToolStripMenuItem
    Friend WithEvents menuCut As ToolStripMenuItem
    Friend WithEvents menuPaste As ToolStripMenuItem
    Friend WithEvents toolOpen As ToolStripButton
    Friend WithEvents toolEdit As ToolStripDropDownButton
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents toolExit As ToolStripButton
End Class
