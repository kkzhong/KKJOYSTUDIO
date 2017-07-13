<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UCTestDialog
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
        Me.RootSpliter = New System.Windows.Forms.SplitContainer()
        Me.LeftSpliter = New System.Windows.Forms.SplitContainer()
        Me.SampleBox = New System.Windows.Forms.TextBox()
        CType(Me.RootSpliter, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RootSpliter.Panel1.SuspendLayout()
        Me.RootSpliter.Panel2.SuspendLayout()
        Me.RootSpliter.SuspendLayout()
        CType(Me.LeftSpliter, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LeftSpliter.SuspendLayout()
        Me.SuspendLayout()
        '
        'RootSpliter
        '
        Me.RootSpliter.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RootSpliter.Location = New System.Drawing.Point(0, 0)
        Me.RootSpliter.Name = "RootSpliter"
        '
        'RootSpliter.Panel1
        '
        Me.RootSpliter.Panel1.Controls.Add(Me.LeftSpliter)
        '
        'RootSpliter.Panel2
        '
        Me.RootSpliter.Panel2.Controls.Add(Me.SampleBox)
        Me.RootSpliter.Size = New System.Drawing.Size(476, 370)
        Me.RootSpliter.SplitterDistance = 242
        Me.RootSpliter.TabIndex = 0
        '
        'LeftSpliter
        '
        Me.LeftSpliter.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LeftSpliter.Location = New System.Drawing.Point(0, 0)
        Me.LeftSpliter.Name = "LeftSpliter"
        Me.LeftSpliter.Orientation = System.Windows.Forms.Orientation.Horizontal
        Me.LeftSpliter.Size = New System.Drawing.Size(242, 370)
        Me.LeftSpliter.SplitterDistance = 164
        Me.LeftSpliter.TabIndex = 0
        '
        'SampleBox
        '
        Me.SampleBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SampleBox.Location = New System.Drawing.Point(0, 0)
        Me.SampleBox.Multiline = True
        Me.SampleBox.Name = "SampleBox"
        Me.SampleBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.SampleBox.Size = New System.Drawing.Size(230, 370)
        Me.SampleBox.TabIndex = 0
        '
        'UCTestDialog
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(476, 370)
        Me.Controls.Add(Me.RootSpliter)
        Me.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "UCTestDialog"
        Me.Text = "UCTestDialog"
        Me.RootSpliter.Panel1.ResumeLayout(False)
        Me.RootSpliter.Panel2.ResumeLayout(False)
        Me.RootSpliter.Panel2.PerformLayout()
        CType(Me.RootSpliter, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RootSpliter.ResumeLayout(False)
        CType(Me.LeftSpliter, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LeftSpliter.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents RootSpliter As SplitContainer
    Friend WithEvents LeftSpliter As SplitContainer
    Friend WithEvents SampleBox As TextBox
End Class
