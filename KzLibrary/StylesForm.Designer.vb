<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class StylesForm
    Inherits System.Windows.Forms.Form

    'Form 重写 Dispose，以清理组件列表。
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.RootSpliter = New System.Windows.Forms.SplitContainer()
        Me.TopSpliter = New System.Windows.Forms.SplitContainer()
        Me.InputPanel = New System.Windows.Forms.TableLayoutPanel()
        Me.StatusCBox = New System.Windows.Forms.ComboBox()
        Me.FrameWidthUD = New System.Windows.Forms.NumericUpDown()
        Me.FrameColorBox = New System.Windows.Forms.TextBox()
        Me.FrameColorGo = New System.Windows.Forms.Button()
        Me.RadiusUD = New System.Windows.Forms.NumericUpDown()
        Me.LineWidthUD = New System.Windows.Forms.NumericUpDown()
        Me.LineColorBox = New System.Windows.Forms.TextBox()
        Me.FillColorBox = New System.Windows.Forms.TextBox()
        Me.LineColorGo = New System.Windows.Forms.Button()
        Me.FillColorGo = New System.Windows.Forms.Button()
        Me.ShadowWidthUD = New System.Windows.Forms.NumericUpDown()
        Me.ShadowColorBox = New System.Windows.Forms.TextBox()
        Me.ShadowColorGo = New System.Windows.Forms.Button()
        Me.FontColorBox = New System.Windows.Forms.TextBox()
        Me.FontColorGo = New System.Windows.Forms.Button()
        Me.FontSizeCBox = New System.Windows.Forms.ComboBox()
        Me.FontStyleBox = New System.Windows.Forms.TextBox()
        Me.FontStyleGo = New System.Windows.Forms.Button()
        Me.FontBox = New System.Windows.Forms.TextBox()
        Me.FontNameBox = New System.Windows.Forms.TextBox()
        Me.TRightSpliter = New System.Windows.Forms.SplitContainer()
        Me.CodeBox = New System.Windows.Forms.TextBox()
        CType(Me.RootSpliter, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RootSpliter.Panel1.SuspendLayout()
        Me.RootSpliter.SuspendLayout()
        CType(Me.TopSpliter, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TopSpliter.Panel1.SuspendLayout()
        Me.TopSpliter.Panel2.SuspendLayout()
        Me.TopSpliter.SuspendLayout()
        Me.InputPanel.SuspendLayout()
        CType(Me.FrameWidthUD, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadiusUD, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LineWidthUD, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ShadowWidthUD, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TRightSpliter, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TRightSpliter.Panel2.SuspendLayout()
        Me.TRightSpliter.SuspendLayout()
        Me.SuspendLayout()
        '
        'RootSpliter
        '
        Me.RootSpliter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.RootSpliter.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RootSpliter.Location = New System.Drawing.Point(0, 0)
        Me.RootSpliter.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.RootSpliter.Name = "RootSpliter"
        Me.RootSpliter.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'RootSpliter.Panel1
        '
        Me.RootSpliter.Panel1.Controls.Add(Me.TopSpliter)
        '
        'RootSpliter.Panel2
        '
        Me.RootSpliter.Size = New System.Drawing.Size(584, 358)
        Me.RootSpliter.SplitterDistance = 246
        Me.RootSpliter.TabIndex = 0
        '
        'TopSpliter
        '
        Me.TopSpliter.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TopSpliter.Location = New System.Drawing.Point(0, 0)
        Me.TopSpliter.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TopSpliter.Name = "TopSpliter"
        '
        'TopSpliter.Panel1
        '
        Me.TopSpliter.Panel1.AutoScroll = True
        Me.TopSpliter.Panel1.Controls.Add(Me.InputPanel)
        '
        'TopSpliter.Panel2
        '
        Me.TopSpliter.Panel2.Controls.Add(Me.TRightSpliter)
        Me.TopSpliter.Size = New System.Drawing.Size(582, 244)
        Me.TopSpliter.SplitterDistance = 226
        Me.TopSpliter.SplitterWidth = 5
        Me.TopSpliter.TabIndex = 0
        '
        'InputPanel
        '
        Me.InputPanel.ColumnCount = 3
        Me.InputPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.InputPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.InputPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 21.0!))
        Me.InputPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.InputPanel.Controls.Add(Me.StatusCBox, 1, 0)
        Me.InputPanel.Controls.Add(Me.FrameWidthUD, 1, 1)
        Me.InputPanel.Controls.Add(Me.FrameColorBox, 1, 2)
        Me.InputPanel.Controls.Add(Me.FrameColorGo, 2, 2)
        Me.InputPanel.Controls.Add(Me.RadiusUD, 1, 3)
        Me.InputPanel.Controls.Add(Me.LineWidthUD, 1, 4)
        Me.InputPanel.Controls.Add(Me.LineColorBox, 1, 5)
        Me.InputPanel.Controls.Add(Me.FillColorBox, 1, 6)
        Me.InputPanel.Controls.Add(Me.LineColorGo, 2, 5)
        Me.InputPanel.Controls.Add(Me.FillColorGo, 2, 6)
        Me.InputPanel.Controls.Add(Me.ShadowWidthUD, 1, 7)
        Me.InputPanel.Controls.Add(Me.ShadowColorBox, 1, 8)
        Me.InputPanel.Controls.Add(Me.ShadowColorGo, 2, 8)
        Me.InputPanel.Controls.Add(Me.FontColorBox, 1, 9)
        Me.InputPanel.Controls.Add(Me.FontColorGo, 2, 9)
        Me.InputPanel.Controls.Add(Me.FontSizeCBox, 1, 11)
        Me.InputPanel.Controls.Add(Me.FontStyleBox, 1, 12)
        Me.InputPanel.Controls.Add(Me.FontStyleGo, 2, 12)
        Me.InputPanel.Controls.Add(Me.FontBox, 1, 13)
        Me.InputPanel.Controls.Add(Me.FontNameBox, 1, 10)
        Me.InputPanel.Dock = System.Windows.Forms.DockStyle.Top
        Me.InputPanel.Location = New System.Drawing.Point(0, 0)
        Me.InputPanel.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.InputPanel.Name = "InputPanel"
        Me.InputPanel.RowCount = 15
        Me.InputPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28.0!))
        Me.InputPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28.0!))
        Me.InputPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28.0!))
        Me.InputPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28.0!))
        Me.InputPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28.0!))
        Me.InputPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28.0!))
        Me.InputPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28.0!))
        Me.InputPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28.0!))
        Me.InputPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28.0!))
        Me.InputPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28.0!))
        Me.InputPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28.0!))
        Me.InputPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28.0!))
        Me.InputPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28.0!))
        Me.InputPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28.0!))
        Me.InputPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.InputPanel.Size = New System.Drawing.Size(209, 409)
        Me.InputPanel.TabIndex = 0
        '
        'StatusCBox
        '
        Me.StatusCBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.StatusCBox.FormattingEnabled = True
        Me.StatusCBox.Location = New System.Drawing.Point(97, 3)
        Me.StatusCBox.Name = "StatusCBox"
        Me.StatusCBox.Size = New System.Drawing.Size(88, 25)
        Me.StatusCBox.TabIndex = 0
        '
        'FrameWidthUD
        '
        Me.FrameWidthUD.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FrameWidthUD.Location = New System.Drawing.Point(97, 31)
        Me.FrameWidthUD.Maximum = New Decimal(New Integer() {9, 0, 0, 0})
        Me.FrameWidthUD.Name = "FrameWidthUD"
        Me.FrameWidthUD.Size = New System.Drawing.Size(88, 23)
        Me.FrameWidthUD.TabIndex = 1
        Me.FrameWidthUD.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'FrameColorBox
        '
        Me.FrameColorBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FrameColorBox.Location = New System.Drawing.Point(97, 59)
        Me.FrameColorBox.Name = "FrameColorBox"
        Me.FrameColorBox.Size = New System.Drawing.Size(88, 23)
        Me.FrameColorBox.TabIndex = 2
        '
        'FrameColorGo
        '
        Me.FrameColorGo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FrameColorGo.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.FrameColorGo.Location = New System.Drawing.Point(188, 56)
        Me.FrameColorGo.Margin = New System.Windows.Forms.Padding(0)
        Me.FrameColorGo.Name = "FrameColorGo"
        Me.FrameColorGo.Size = New System.Drawing.Size(21, 28)
        Me.FrameColorGo.TabIndex = 3
        Me.FrameColorGo.Text = "▶"
        Me.FrameColorGo.UseVisualStyleBackColor = True
        '
        'RadiusUD
        '
        Me.RadiusUD.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RadiusUD.Location = New System.Drawing.Point(97, 87)
        Me.RadiusUD.Maximum = New Decimal(New Integer() {9, 0, 0, 0})
        Me.RadiusUD.Name = "RadiusUD"
        Me.RadiusUD.Size = New System.Drawing.Size(88, 23)
        Me.RadiusUD.TabIndex = 4
        Me.RadiusUD.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'LineWidthUD
        '
        Me.LineWidthUD.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LineWidthUD.Location = New System.Drawing.Point(97, 115)
        Me.LineWidthUD.Maximum = New Decimal(New Integer() {9, 0, 0, 0})
        Me.LineWidthUD.Name = "LineWidthUD"
        Me.LineWidthUD.Size = New System.Drawing.Size(88, 23)
        Me.LineWidthUD.TabIndex = 5
        Me.LineWidthUD.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'LineColorBox
        '
        Me.LineColorBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LineColorBox.Location = New System.Drawing.Point(97, 143)
        Me.LineColorBox.Name = "LineColorBox"
        Me.LineColorBox.Size = New System.Drawing.Size(88, 23)
        Me.LineColorBox.TabIndex = 6
        '
        'FillColorBox
        '
        Me.FillColorBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FillColorBox.Location = New System.Drawing.Point(97, 171)
        Me.FillColorBox.Name = "FillColorBox"
        Me.FillColorBox.Size = New System.Drawing.Size(88, 23)
        Me.FillColorBox.TabIndex = 7
        '
        'LineColorGo
        '
        Me.LineColorGo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LineColorGo.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.LineColorGo.Location = New System.Drawing.Point(188, 140)
        Me.LineColorGo.Margin = New System.Windows.Forms.Padding(0)
        Me.LineColorGo.Name = "LineColorGo"
        Me.LineColorGo.Size = New System.Drawing.Size(21, 28)
        Me.LineColorGo.TabIndex = 8
        Me.LineColorGo.Text = "▶"
        Me.LineColorGo.UseVisualStyleBackColor = True
        '
        'FillColorGo
        '
        Me.FillColorGo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FillColorGo.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.FillColorGo.Location = New System.Drawing.Point(188, 168)
        Me.FillColorGo.Margin = New System.Windows.Forms.Padding(0)
        Me.FillColorGo.Name = "FillColorGo"
        Me.FillColorGo.Size = New System.Drawing.Size(21, 28)
        Me.FillColorGo.TabIndex = 9
        Me.FillColorGo.Text = "▶"
        Me.FillColorGo.UseVisualStyleBackColor = True
        '
        'ShadowWidthUD
        '
        Me.ShadowWidthUD.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ShadowWidthUD.Location = New System.Drawing.Point(97, 199)
        Me.ShadowWidthUD.Maximum = New Decimal(New Integer() {9, 0, 0, 0})
        Me.ShadowWidthUD.Name = "ShadowWidthUD"
        Me.ShadowWidthUD.Size = New System.Drawing.Size(88, 23)
        Me.ShadowWidthUD.TabIndex = 10
        Me.ShadowWidthUD.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'ShadowColorBox
        '
        Me.ShadowColorBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ShadowColorBox.Location = New System.Drawing.Point(97, 227)
        Me.ShadowColorBox.Name = "ShadowColorBox"
        Me.ShadowColorBox.Size = New System.Drawing.Size(88, 23)
        Me.ShadowColorBox.TabIndex = 11
        '
        'ShadowColorGo
        '
        Me.ShadowColorGo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ShadowColorGo.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.ShadowColorGo.Location = New System.Drawing.Point(188, 224)
        Me.ShadowColorGo.Margin = New System.Windows.Forms.Padding(0)
        Me.ShadowColorGo.Name = "ShadowColorGo"
        Me.ShadowColorGo.Size = New System.Drawing.Size(21, 28)
        Me.ShadowColorGo.TabIndex = 12
        Me.ShadowColorGo.Text = "▶"
        Me.ShadowColorGo.UseVisualStyleBackColor = True
        '
        'FontColorBox
        '
        Me.FontColorBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FontColorBox.Location = New System.Drawing.Point(97, 255)
        Me.FontColorBox.Name = "FontColorBox"
        Me.FontColorBox.Size = New System.Drawing.Size(88, 23)
        Me.FontColorBox.TabIndex = 13
        '
        'FontColorGo
        '
        Me.FontColorGo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FontColorGo.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.FontColorGo.Location = New System.Drawing.Point(188, 252)
        Me.FontColorGo.Margin = New System.Windows.Forms.Padding(0)
        Me.FontColorGo.Name = "FontColorGo"
        Me.FontColorGo.Size = New System.Drawing.Size(21, 28)
        Me.FontColorGo.TabIndex = 14
        Me.FontColorGo.Text = "▶"
        Me.FontColorGo.UseVisualStyleBackColor = True
        '
        'FontSizeCBox
        '
        Me.FontSizeCBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FontSizeCBox.FormattingEnabled = True
        Me.FontSizeCBox.Location = New System.Drawing.Point(97, 311)
        Me.FontSizeCBox.Name = "FontSizeCBox"
        Me.FontSizeCBox.Size = New System.Drawing.Size(88, 25)
        Me.FontSizeCBox.TabIndex = 16
        '
        'FontStyleBox
        '
        Me.FontStyleBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FontStyleBox.Location = New System.Drawing.Point(97, 339)
        Me.FontStyleBox.Name = "FontStyleBox"
        Me.FontStyleBox.Size = New System.Drawing.Size(88, 23)
        Me.FontStyleBox.TabIndex = 17
        '
        'FontStyleGo
        '
        Me.FontStyleGo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FontStyleGo.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.FontStyleGo.Location = New System.Drawing.Point(188, 336)
        Me.FontStyleGo.Margin = New System.Windows.Forms.Padding(0)
        Me.FontStyleGo.Name = "FontStyleGo"
        Me.FontStyleGo.Size = New System.Drawing.Size(21, 28)
        Me.FontStyleGo.TabIndex = 18
        Me.FontStyleGo.Text = "▶"
        Me.FontStyleGo.UseVisualStyleBackColor = True
        '
        'FontBox
        '
        Me.FontBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FontBox.Location = New System.Drawing.Point(97, 367)
        Me.FontBox.Name = "FontBox"
        Me.FontBox.Size = New System.Drawing.Size(88, 23)
        Me.FontBox.TabIndex = 19
        '
        'FontNameBox
        '
        Me.FontNameBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FontNameBox.Location = New System.Drawing.Point(97, 283)
        Me.FontNameBox.Name = "FontNameBox"
        Me.FontNameBox.Size = New System.Drawing.Size(88, 23)
        Me.FontNameBox.TabIndex = 20
        '
        'TRightSpliter
        '
        Me.TRightSpliter.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TRightSpliter.Location = New System.Drawing.Point(0, 0)
        Me.TRightSpliter.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TRightSpliter.Name = "TRightSpliter"
        '
        'TRightSpliter.Panel2
        '
        Me.TRightSpliter.Panel2.Controls.Add(Me.CodeBox)
        Me.TRightSpliter.Size = New System.Drawing.Size(351, 244)
        Me.TRightSpliter.SplitterDistance = 121
        Me.TRightSpliter.SplitterWidth = 5
        Me.TRightSpliter.TabIndex = 0
        '
        'CodeBox
        '
        Me.CodeBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CodeBox.Location = New System.Drawing.Point(0, 0)
        Me.CodeBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.CodeBox.Multiline = True
        Me.CodeBox.Name = "CodeBox"
        Me.CodeBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.CodeBox.Size = New System.Drawing.Size(225, 244)
        Me.CodeBox.TabIndex = 0
        '
        'StylesForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(584, 358)
        Me.Controls.Add(Me.RootSpliter)
        Me.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "StylesForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "KzStyleForm"
        Me.RootSpliter.Panel1.ResumeLayout(False)
        CType(Me.RootSpliter, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RootSpliter.ResumeLayout(False)
        Me.TopSpliter.Panel1.ResumeLayout(False)
        Me.TopSpliter.Panel2.ResumeLayout(False)
        CType(Me.TopSpliter, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TopSpliter.ResumeLayout(False)
        Me.InputPanel.ResumeLayout(False)
        Me.InputPanel.PerformLayout()
        CType(Me.FrameWidthUD, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadiusUD, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LineWidthUD, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ShadowWidthUD, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TRightSpliter.Panel2.ResumeLayout(False)
        Me.TRightSpliter.Panel2.PerformLayout()
        CType(Me.TRightSpliter, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TRightSpliter.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents RootSpliter As SplitContainer
    Friend WithEvents TopSpliter As SplitContainer
    Friend WithEvents TRightSpliter As SplitContainer
    Friend WithEvents InputPanel As TableLayoutPanel
    Friend WithEvents CodeBox As TextBox
    Friend WithEvents StatusCBox As ComboBox
    Friend WithEvents FrameWidthUD As NumericUpDown
    Friend WithEvents FrameColorBox As TextBox
    Friend WithEvents FrameColorGo As Button
    Friend WithEvents RadiusUD As NumericUpDown
    Friend WithEvents LineWidthUD As NumericUpDown
    Friend WithEvents LineColorBox As TextBox
    Friend WithEvents FillColorBox As TextBox
    Friend WithEvents LineColorGo As Button
    Friend WithEvents FillColorGo As Button
    Friend WithEvents ShadowWidthUD As NumericUpDown
    Friend WithEvents ShadowColorBox As TextBox
    Friend WithEvents ShadowColorGo As Button
    Friend WithEvents FontColorBox As TextBox
    Friend WithEvents FontColorGo As Button
    Friend WithEvents FontSizeCBox As ComboBox
    Friend WithEvents FontStyleBox As TextBox
    Friend WithEvents FontStyleGo As Button
    Friend WithEvents FontBox As TextBox
    Friend WithEvents FontNameBox As TextBox
End Class
