<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EndForm
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
        Me.components = New System.ComponentModel.Container()
        Me.LogoBox = New System.Windows.Forms.PictureBox()
        Me.ZoomTimer = New System.Windows.Forms.Timer(Me.components)
        Me.InfoLabel = New System.Windows.Forms.Label()
        CType(Me.LogoBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LogoBox
        '
        Me.LogoBox.Location = New System.Drawing.Point(39, 27)
        Me.LogoBox.Name = "LogoBox"
        Me.LogoBox.Size = New System.Drawing.Size(250, 250)
        Me.LogoBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.LogoBox.TabIndex = 0
        Me.LogoBox.TabStop = False
        '
        'ZoomTimer
        '
        '
        'InfoLabel
        '
        Me.InfoLabel.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.InfoLabel.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.InfoLabel.Location = New System.Drawing.Point(0, 294)
        Me.InfoLabel.Name = "InfoLabel"
        Me.InfoLabel.Size = New System.Drawing.Size(334, 17)
        Me.InfoLabel.TabIndex = 1
        Me.InfoLabel.Text = "Label1"
        Me.InfoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'EndForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Ivory
        Me.ClientSize = New System.Drawing.Size(334, 311)
        Me.ControlBox = False
        Me.Controls.Add(Me.InfoLabel)
        Me.Controls.Add(Me.LogoBox)
        Me.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "EndForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "EndForm"
        Me.TopMost = True
        CType(Me.LogoBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents LogoBox As PictureBox
    Friend WithEvents ZoomTimer As Timer
    Friend WithEvents InfoLabel As Label
End Class
