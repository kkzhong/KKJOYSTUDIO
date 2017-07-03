<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ImportForm
    Inherits System.Windows.Forms.Form

    'Form 重写 Dispose，以清理组件列表。
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

    'Windows 窗体设计器所必需的
    Private components As System.ComponentModel.IContainer

    '注意: 以下过程是 Windows 窗体设计器所必需的
    '可以使用 Windows 窗体设计器修改它。  
    '不要使用代码编辑器修改它。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ImportForm))
        Me.ImportToolStrip = New System.Windows.Forms.ToolStrip()
        Me.OpenFileButton = New System.Windows.Forms.ToolStripButton()
        Me.FileNameBox = New System.Windows.Forms.ToolStripTextBox()
        Me.ImportButton = New System.Windows.Forms.ToolStripButton()
        Me.DataStatusStrip = New System.Windows.Forms.StatusStrip()
        Me.ImportDataGridView = New System.Windows.Forms.DataGridView()
        Me.ImportToolStrip.SuspendLayout()
        CType(Me.ImportDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ImportToolStrip
        '
        Me.ImportToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OpenFileButton, Me.FileNameBox, Me.ImportButton})
        Me.ImportToolStrip.Location = New System.Drawing.Point(0, 0)
        Me.ImportToolStrip.Name = "ImportToolStrip"
        Me.ImportToolStrip.Size = New System.Drawing.Size(284, 25)
        Me.ImportToolStrip.TabIndex = 0
        Me.ImportToolStrip.Text = "ToolStrip1"
        '
        'OpenFileButton
        '
        Me.OpenFileButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.OpenFileButton.Image = CType(resources.GetObject("OpenFileButton.Image"), System.Drawing.Image)
        Me.OpenFileButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.OpenFileButton.Name = "OpenFileButton"
        Me.OpenFileButton.Size = New System.Drawing.Size(23, 22)
        Me.OpenFileButton.Text = "ToolStripButton1"
        '
        'FileNameBox
        '
        Me.FileNameBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.FileNameBox.Name = "FileNameBox"
        Me.FileNameBox.Size = New System.Drawing.Size(100, 25)
        '
        'ImportButton
        '
        Me.ImportButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ImportButton.Image = CType(resources.GetObject("ImportButton.Image"), System.Drawing.Image)
        Me.ImportButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ImportButton.Name = "ImportButton"
        Me.ImportButton.Size = New System.Drawing.Size(23, 22)
        Me.ImportButton.Text = "ToolStripButton2"
        '
        'DataStatusStrip
        '
        Me.DataStatusStrip.Location = New System.Drawing.Point(0, 239)
        Me.DataStatusStrip.Name = "DataStatusStrip"
        Me.DataStatusStrip.Size = New System.Drawing.Size(284, 22)
        Me.DataStatusStrip.TabIndex = 1
        Me.DataStatusStrip.Text = "StatusStrip1"
        '
        'ImportDataGridView
        '
        Me.ImportDataGridView.BackgroundColor = System.Drawing.SystemColors.Control
        Me.ImportDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.ImportDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ImportDataGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ImportDataGridView.Location = New System.Drawing.Point(0, 25)
        Me.ImportDataGridView.Name = "ImportDataGridView"
        Me.ImportDataGridView.RowTemplate.Height = 23
        Me.ImportDataGridView.Size = New System.Drawing.Size(284, 214)
        Me.ImportDataGridView.TabIndex = 2
        '
        'ImportForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.ImportDataGridView)
        Me.Controls.Add(Me.DataStatusStrip)
        Me.Controls.Add(Me.ImportToolStrip)
        Me.Name = "ImportForm"
        Me.Text = "ImportForm"
        Me.ImportToolStrip.ResumeLayout(False)
        Me.ImportToolStrip.PerformLayout()
        CType(Me.ImportDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ImportToolStrip As ToolStrip
    Friend WithEvents OpenFileButton As ToolStripButton
    Friend WithEvents FileNameBox As ToolStripTextBox
    Friend WithEvents DataStatusStrip As StatusStrip
    Friend WithEvents ImportDataGridView As DataGridView
    Friend WithEvents ImportButton As ToolStripButton
End Class
