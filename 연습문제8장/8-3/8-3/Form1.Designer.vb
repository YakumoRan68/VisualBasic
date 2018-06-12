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
        Dim TreeNode13 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("타원")
        Dim TreeNode14 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("사각형")
        Dim TreeNode15 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("선")
        Dim TreeNode16 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("도형", New System.Windows.Forms.TreeNode() {TreeNode13, TreeNode14, TreeNode15})
        Me.TreeView1 = New System.Windows.Forms.TreeView()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.LineShape1 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.OvalShape1 = New Microsoft.VisualBasic.PowerPacks.OvalShape()
        Me.RectangleShape1 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.GroupBox1.SuspendLayout
        Me.SuspendLayout
        '
        'TreeView1
        '
        Me.TreeView1.Location = New System.Drawing.Point(22, 21)
        Me.TreeView1.Name = "TreeView1"
        TreeNode13.Name = "shape1"
        TreeNode13.Text = "타원"
        TreeNode14.Name = "shape2"
        TreeNode14.Text = "사각형"
        TreeNode15.Name = "shape3"
        TreeNode15.Text = "선"
        TreeNode16.Name = "Node0"
        TreeNode16.Text = "도형"
        Me.TreeView1.Nodes.AddRange(New System.Windows.Forms.TreeNode() {TreeNode16})
        Me.TreeView1.Size = New System.Drawing.Size(313, 392)
        Me.TreeView1.TabIndex = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.ShapeContainer1)
        Me.GroupBox1.Location = New System.Drawing.Point(398, 21)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(309, 392)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = false
        Me.GroupBox1.Text = "선택한도형"
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(3, 17)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.RectangleShape1, Me.OvalShape1, Me.LineShape1})
        Me.ShapeContainer1.Size = New System.Drawing.Size(303, 372)
        Me.ShapeContainer1.TabIndex = 0
        Me.ShapeContainer1.TabStop = false
        '
        'LineShape1
        '
        Me.LineShape1.Name = "LineShape1"
        Me.LineShape1.Visible = false
        Me.LineShape1.X1 = 111
        Me.LineShape1.X2 = 193
        Me.LineShape1.Y1 = 137
        Me.LineShape1.Y2 = 220
        '
        'OvalShape1
        '
        Me.OvalShape1.Location = New System.Drawing.Point(102, 134)
        Me.OvalShape1.Name = "OvalShape1"
        Me.OvalShape1.Size = New System.Drawing.Size(95, 97)
        Me.OvalShape1.Visible = false
        '
        'RectangleShape1
        '
        Me.RectangleShape1.Location = New System.Drawing.Point(113, 146)
        Me.RectangleShape1.Name = "RectangleShape1"
        Me.RectangleShape1.Size = New System.Drawing.Size(75, 80)
        Me.RectangleShape1.Visible = false
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7!, 12!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.TreeView1)
        Me.Name = "Form1"
        Me.Text = "트리뷰 201804011"
        Me.GroupBox1.ResumeLayout(false)
        Me.ResumeLayout(false)

End Sub

    Friend WithEvents TreeView1 As TreeView
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents ShapeContainer1 As PowerPacks.ShapeContainer
    Friend WithEvents RectangleShape1 As PowerPacks.RectangleShape
    Friend WithEvents OvalShape1 As PowerPacks.OvalShape
    Friend WithEvents LineShape1 As PowerPacks.LineShape
End Class
