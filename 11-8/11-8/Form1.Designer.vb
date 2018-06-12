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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.StuinfoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.학생정보DataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.학생정보DataSet = New _11_8.학생정보DataSet()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.StuinfoTableAdapter = New _11_8.학생정보DataSetTableAdapters.stuinfoTableAdapter()
        Me.학번DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.이름DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.주소DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.연락처DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StuinfoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.학생정보DataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.학생정보DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.학번DataGridViewTextBoxColumn, Me.이름DataGridViewTextBoxColumn, Me.주소DataGridViewTextBoxColumn, Me.연락처DataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.StuinfoBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(12, 12)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowTemplate.Height = 23
        Me.DataGridView1.Size = New System.Drawing.Size(545, 184)
        Me.DataGridView1.TabIndex = 0
        '
        'StuinfoBindingSource
        '
        Me.StuinfoBindingSource.DataMember = "stuinfo"
        Me.StuinfoBindingSource.DataSource = Me.학생정보DataSetBindingSource
        '
        '학생정보DataSetBindingSource
        '
        Me.학생정보DataSetBindingSource.DataSource = Me.학생정보DataSet
        Me.학생정보DataSetBindingSource.Position = 0
        '
        '학생정보DataSet
        '
        Me.학생정보DataSet.DataSetName = "학생정보DataSet"
        Me.학생정보DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(45, 226)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(29, 12)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "학번"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(317, 226)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(29, 12)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "이름"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(45, 283)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(29, 12)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "주소"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(317, 283)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(41, 12)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "연락처"
        '
        'TextBox1
        '
        Me.TextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StuinfoBindingSource, "학번", True))
        Me.TextBox1.Location = New System.Drawing.Point(47, 242)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(113, 21)
        Me.TextBox1.TabIndex = 5
        '
        'TextBox2
        '
        Me.TextBox2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StuinfoBindingSource, "이름", True))
        Me.TextBox2.Location = New System.Drawing.Point(319, 242)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(113, 21)
        Me.TextBox2.TabIndex = 6
        '
        'TextBox3
        '
        Me.TextBox3.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StuinfoBindingSource, "주소", True))
        Me.TextBox3.Location = New System.Drawing.Point(47, 298)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(173, 21)
        Me.TextBox3.TabIndex = 7
        '
        'TextBox4
        '
        Me.TextBox4.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StuinfoBindingSource, "연락처", True))
        Me.TextBox4.Location = New System.Drawing.Point(319, 298)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(173, 21)
        Me.TextBox4.TabIndex = 8
        '
        'StuinfoTableAdapter
        '
        Me.StuinfoTableAdapter.ClearBeforeFill = True
        '
        '학번DataGridViewTextBoxColumn
        '
        Me.학번DataGridViewTextBoxColumn.DataPropertyName = "학번"
        Me.학번DataGridViewTextBoxColumn.HeaderText = "학번"
        Me.학번DataGridViewTextBoxColumn.Name = "학번DataGridViewTextBoxColumn"
        '
        '이름DataGridViewTextBoxColumn
        '
        Me.이름DataGridViewTextBoxColumn.DataPropertyName = "이름"
        Me.이름DataGridViewTextBoxColumn.HeaderText = "이름"
        Me.이름DataGridViewTextBoxColumn.Name = "이름DataGridViewTextBoxColumn"
        '
        '주소DataGridViewTextBoxColumn
        '
        Me.주소DataGridViewTextBoxColumn.DataPropertyName = "주소"
        Me.주소DataGridViewTextBoxColumn.HeaderText = "주소"
        Me.주소DataGridViewTextBoxColumn.Name = "주소DataGridViewTextBoxColumn"
        '
        '연락처DataGridViewTextBoxColumn
        '
        Me.연락처DataGridViewTextBoxColumn.DataPropertyName = "연락처"
        Me.연락처DataGridViewTextBoxColumn.HeaderText = "연락처"
        Me.연락처DataGridViewTextBoxColumn.Name = "연락처DataGridViewTextBoxColumn"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(569, 345)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StuinfoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.학생정보DataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.학생정보DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents 학생정보DataSetBindingSource As BindingSource
    Friend WithEvents 학생정보DataSet As 학생정보DataSet
    Friend WithEvents StuinfoBindingSource As BindingSource
    Friend WithEvents StuinfoTableAdapter As 학생정보DataSetTableAdapters.stuinfoTableAdapter
    Friend WithEvents 학번DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents 이름DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents 주소DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents 연락처DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
