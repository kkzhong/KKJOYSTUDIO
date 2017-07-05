<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class KzInputListPanel
    Inherits System.Windows.Forms.UserControl

    'UserControl 重写释放以清理组件列表。
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
        Me.InputPanel = New System.Windows.Forms.TableLayoutPanel()
        Me.SuspendLayout()
        '
        'InputPanel
        '
        Me.InputPanel.AutoScroll = True
        Me.InputPanel.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.InputPanel.ColumnCount = 4
        Me.InputPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.InputPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.InputPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
        Me.InputPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 26.0!))
        Me.InputPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.InputPanel.Location = New System.Drawing.Point(0, 0)
        Me.InputPanel.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.InputPanel.Name = "InputPanel"
        Me.InputPanel.RowCount = 2
        Me.InputPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.InputPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.InputPanel.Size = New System.Drawing.Size(327, 174)
        Me.InputPanel.TabIndex = 0
        '
        'KzInputListPanel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.InputPanel)
        Me.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "KzInputListPanel"
        Me.Size = New System.Drawing.Size(327, 174)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents InputPanel As TableLayoutPanel
End Class
