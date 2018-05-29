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
        Dim ListViewItem5 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("휴지통", 2)
        Dim ListViewItem6 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("인터넷", 1)
        Dim ListViewItem7 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("설정", 3)
        Dim ListViewItem8 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("내 컴퓨터", 0)
        Me.IboxChoose = New System.Windows.Forms.ListBox()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.IvMain = New System.Windows.Forms.ListView()
        Me.SuspendLayout()
        '
        'IboxChoose
        '
        Me.IboxChoose.FormattingEnabled = True
        Me.IboxChoose.ItemHeight = 12
        Me.IboxChoose.Items.AddRange(New Object() {"큰 아이콘", "자세히", "작은 아이콘", "간단히", "타일" & Global.Microsoft.VisualBasic.ChrW(9)})
        Me.IboxChoose.Location = New System.Drawing.Point(12, 12)
        Me.IboxChoose.Name = "IboxChoose"
        Me.IboxChoose.Size = New System.Drawing.Size(197, 196)
        Me.IboxChoose.TabIndex = 0
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(58, 257)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(83, 35)
        Me.btnExit.TabIndex = 1
        Me.btnExit.Text = "종료"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "Chrysanthemum.jpg")
        Me.ImageList1.Images.SetKeyName(1, "Desert.jpg")
        Me.ImageList1.Images.SetKeyName(2, "Hydrangeas.jpg")
        Me.ImageList1.Images.SetKeyName(3, "Jellyfish.jpg")
        Me.ImageList1.Images.SetKeyName(4, "Koala.jpg")
        Me.ImageList1.Images.SetKeyName(5, "Tulips.jpg")
        '
        'IvMain
        '
        Me.IvMain.Items.AddRange(New System.Windows.Forms.ListViewItem() {ListViewItem5, ListViewItem6, ListViewItem7, ListViewItem8})
        Me.IvMain.LargeImageList = Me.ImageList1
        Me.IvMain.Location = New System.Drawing.Point(230, 12)
        Me.IvMain.Name = "IvMain"
        Me.IvMain.Size = New System.Drawing.Size(306, 302)
        Me.IvMain.SmallImageList = Me.ImageList1
        Me.IvMain.TabIndex = 2
        Me.IvMain.UseCompatibleStateImageBehavior = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(548, 337)
        Me.Controls.Add(Me.IvMain)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.IboxChoose)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents IboxChoose As ListBox
    Friend WithEvents btnExit As Button
    Friend WithEvents ImageList1 As ImageList
    Friend WithEvents IvMain As ListView
End Class
