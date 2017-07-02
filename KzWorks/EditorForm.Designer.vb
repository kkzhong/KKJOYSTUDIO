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
        Me.KzEditor1 = New KzWorks.KzEditor()
        Me.SuspendLayout()
        '
        'KzEditor1
        '
        Me.KzEditor1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KzEditor1.Location = New System.Drawing.Point(0, 0)
        Me.KzEditor1.Name = "KzEditor1"
        Me.KzEditor1.Size = New System.Drawing.Size(492, 334)
        Me.KzEditor1.TabIndex = 0
        '
        'EditorForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(492, 334)
        Me.Controls.Add(Me.KzEditor1)
        Me.Name = "EditorForm"
        Me.Text = "EditorForm"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents KzEditor1 As KzEditor
End Class
