<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.학생정보DataSet = New _11_9.학생정보DataSet()
        Me.학생정보DataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.StuinfoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.StuinfoTableAdapter = New _11_9.학생정보DataSetTableAdapters.stuinfoTableAdapter()
        Me.학번DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.이름DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.주소DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.연락처DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.학생정보DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.학생정보DataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StuinfoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.학번DataGridViewTextBoxColumn, Me.이름DataGridViewTextBoxColumn, Me.주소DataGridViewTextBoxColumn, Me.연락처DataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.StuinfoBindingSource
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Top
        Me.DataGridView1.Location = New System.Drawing.Point(0, 0)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.RowTemplate.Height = 23
        Me.DataGridView1.Size = New System.Drawing.Size(496, 320)
        Me.DataGridView1.TabIndex = 0
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(208, 330)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "닫기"
        Me.Button1.UseVisualStyleBackColor = True
        '
        '학생정보DataSet
        '
        Me.학생정보DataSet.DataSetName = "학생정보DataSet"
        Me.학생정보DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        '학생정보DataSetBindingSource
        '
        Me.학생정보DataSetBindingSource.DataSource = Me.학생정보DataSet
        Me.학생정보DataSetBindingSource.Position = 0
        '
        'StuinfoBindingSource
        '
        Me.StuinfoBindingSource.DataMember = "stuinfo"
        Me.StuinfoBindingSource.DataSource = Me.학생정보DataSetBindingSource
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
        Me.학번DataGridViewTextBoxColumn.ReadOnly = True
        '
        '이름DataGridViewTextBoxColumn
        '
        Me.이름DataGridViewTextBoxColumn.DataPropertyName = "이름"
        Me.이름DataGridViewTextBoxColumn.HeaderText = "이름"
        Me.이름DataGridViewTextBoxColumn.Name = "이름DataGridViewTextBoxColumn"
        Me.이름DataGridViewTextBoxColumn.ReadOnly = True
        '
        '주소DataGridViewTextBoxColumn
        '
        Me.주소DataGridViewTextBoxColumn.DataPropertyName = "주소"
        Me.주소DataGridViewTextBoxColumn.HeaderText = "주소"
        Me.주소DataGridViewTextBoxColumn.Name = "주소DataGridViewTextBoxColumn"
        Me.주소DataGridViewTextBoxColumn.ReadOnly = True
        '
        '연락처DataGridViewTextBoxColumn
        '
        Me.연락처DataGridViewTextBoxColumn.DataPropertyName = "연락처"
        Me.연락처DataGridViewTextBoxColumn.HeaderText = "연락처"
        Me.연락처DataGridViewTextBoxColumn.Name = "연락처DataGridViewTextBoxColumn"
        Me.연락처DataGridViewTextBoxColumn.ReadOnly = True
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(496, 373)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "Form2"
        Me.Text = "전체보기"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.학생정보DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.학생정보DataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StuinfoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Button1 As Button
    Friend WithEvents 학생정보DataSetBindingSource As BindingSource
    Friend WithEvents 학생정보DataSet As 학생정보DataSet
    Friend WithEvents StuinfoBindingSource As BindingSource
    Friend WithEvents StuinfoTableAdapter As 학생정보DataSetTableAdapters.stuinfoTableAdapter
    Friend WithEvents 학번DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents 이름DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents 주소DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents 연락처DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
