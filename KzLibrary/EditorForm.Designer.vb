<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EditorForm
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
        Me.EditorMenu = New System.Windows.Forms.MenuStrip()
        Me.RootSplitContainer = New System.Windows.Forms.SplitContainer()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ReturnToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditorMenu.SuspendLayout()
        CType(Me.RootSplitContainer, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RootSplitContainer.SuspendLayout()
        Me.SuspendLayout()
        '
        'EditorMenu
        '
        Me.EditorMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem})
        Me.EditorMenu.Location = New System.Drawing.Point(0, 0)
        Me.EditorMenu.Name = "EditorMenu"
        Me.EditorMenu.Padding = New System.Windows.Forms.Padding(7, 3, 0, 3)
        Me.EditorMenu.Size = New System.Drawing.Size(637, 27)
        Me.EditorMenu.TabIndex = 0
        Me.EditorMenu.Text = "MenuStrip1"
        '
        'RootSplitContainer
        '
        Me.RootSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RootSplitContainer.Location = New System.Drawing.Point(0, 27)
        Me.RootSplitContainer.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.RootSplitContainer.Name = "RootSplitContainer"
        Me.RootSplitContainer.Size = New System.Drawing.Size(637, 411)
        Me.RootSplitContainer.SplitterDistance = 294
        Me.RootSplitContainer.SplitterWidth = 5
        Me.RootSplitContainer.TabIndex = 1
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OpenToolStripMenuItem, Me.ToolStripSeparator1, Me.ReturnToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(39, 21)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'OpenToolStripMenuItem
        '
        Me.OpenToolStripMenuItem.Name = "OpenToolStripMenuItem"
        Me.OpenToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.OpenToolStripMenuItem.Text = "Open"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(149, 6)
        '
        'ReturnToolStripMenuItem
        '
        Me.ReturnToolStripMenuItem.Name = "ReturnToolStripMenuItem"
        Me.ReturnToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ReturnToolStripMenuItem.Text = "Return"
        '
        'EditorForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(637, 438)
        Me.Controls.Add(Me.RootSplitContainer)
        Me.Controls.Add(Me.EditorMenu)
        Me.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.MainMenuStrip = Me.EditorMenu
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "EditorForm"
        Me.Text = "EditorForm"
        Me.EditorMenu.ResumeLayout(False)
        Me.EditorMenu.PerformLayout()
        CType(Me.RootSplitContainer, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RootSplitContainer.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents EditorMenu As MenuStrip
    Friend WithEvents RootSplitContainer As SplitContainer
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OpenToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents ReturnToolStripMenuItem As ToolStripMenuItem
End Class
