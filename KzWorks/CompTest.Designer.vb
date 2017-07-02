<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CompTest
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
        Me.TheSpliter = New System.Windows.Forms.SplitContainer()
        CType(Me.TheSpliter, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TheSpliter.SuspendLayout()
        Me.SuspendLayout()
        '
        'TheSpliter
        '
        Me.TheSpliter.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TheSpliter.Location = New System.Drawing.Point(0, 0)
        Me.TheSpliter.Name = "TheSpliter"
        Me.TheSpliter.Size = New System.Drawing.Size(407, 261)
        Me.TheSpliter.SplitterDistance = 177
        Me.TheSpliter.TabIndex = 0
        '
        'CompTest
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(407, 261)
        Me.Controls.Add(Me.TheSpliter)
        Me.Name = "CompTest"
        Me.Text = "CompTest"
        CType(Me.TheSpliter, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TheSpliter.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TheSpliter As SplitContainer
End Class
