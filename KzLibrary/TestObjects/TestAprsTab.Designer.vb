<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class TestAprsTab
    Inherits System.Windows.Forms.UserControl

    'UserControl 重写释放以清理组件列表。
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
        Me.RootPanel = New System.Windows.Forms.TableLayoutPanel()
        Me.ResetDefaultButton = New System.Windows.Forms.Button()
        Me.TitleLabel = New System.Windows.Forms.Label()
        Me.Name_BorderSize = New System.Windows.Forms.Label()
        Me.BorderRadius_BorderColor = New System.Windows.Forms.Label()
        Me.ShadowWidth_BackColor = New System.Windows.Forms.Label()
        Me.ShadowShift_ForeLineSize = New System.Windows.Forms.Label()
        Me.FontFamily_ForeColor = New System.Windows.Forms.Label()
        Me.FontSize_ShadowDirection = New System.Windows.Forms.Label()
        Me.FontStyle_ShadowColor = New System.Windows.Forms.Label()
        Me.NameTBox = New System.Windows.Forms.TextBox()
        Me.BorderRadiusUD = New System.Windows.Forms.NumericUpDown()
        Me.ShadowWidthUD = New System.Windows.Forms.NumericUpDown()
        Me.ShadowShiftCheck = New System.Windows.Forms.CheckBox()
        Me.FontFamilyTBox = New System.Windows.Forms.TextBox()
        Me.FontStyleCBox = New System.Windows.Forms.ComboBox()
        Me.FontSizeCBox = New System.Windows.Forms.ComboBox()
        Me.RootPanel.SuspendLayout()
        CType(Me.BorderRadiusUD, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ShadowWidthUD, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RootPanel
        '
        Me.RootPanel.ColumnCount = 3
        Me.RootPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100.0!))
        Me.RootPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.RootPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.RootPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.RootPanel.Controls.Add(Me.ResetDefaultButton, 2, 0)
        Me.RootPanel.Controls.Add(Me.TitleLabel, 0, 0)
        Me.RootPanel.Controls.Add(Me.Name_BorderSize, 0, 1)
        Me.RootPanel.Controls.Add(Me.BorderRadius_BorderColor, 0, 2)
        Me.RootPanel.Controls.Add(Me.ShadowWidth_BackColor, 0, 3)
        Me.RootPanel.Controls.Add(Me.ShadowShift_ForeLineSize, 0, 4)
        Me.RootPanel.Controls.Add(Me.FontFamily_ForeColor, 0, 5)
        Me.RootPanel.Controls.Add(Me.FontSize_ShadowDirection, 0, 6)
        Me.RootPanel.Controls.Add(Me.FontStyle_ShadowColor, 0, 7)
        Me.RootPanel.Controls.Add(Me.NameTBox, 1, 1)
        Me.RootPanel.Controls.Add(Me.BorderRadiusUD, 1, 2)
        Me.RootPanel.Controls.Add(Me.ShadowWidthUD, 1, 3)
        Me.RootPanel.Controls.Add(Me.ShadowShiftCheck, 1, 4)
        Me.RootPanel.Controls.Add(Me.FontFamilyTBox, 1, 5)
        Me.RootPanel.Controls.Add(Me.FontStyleCBox, 1, 6)
        Me.RootPanel.Controls.Add(Me.FontSizeCBox, 1, 7)
        Me.RootPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RootPanel.Location = New System.Drawing.Point(0, 0)
        Me.RootPanel.Name = "RootPanel"
        Me.RootPanel.RowCount = 9
        Me.RootPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26.0!))
        Me.RootPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26.0!))
        Me.RootPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26.0!))
        Me.RootPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26.0!))
        Me.RootPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26.0!))
        Me.RootPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26.0!))
        Me.RootPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26.0!))
        Me.RootPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26.0!))
        Me.RootPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.RootPanel.Size = New System.Drawing.Size(280, 250)
        Me.RootPanel.TabIndex = 1
        '
        'ResetDefaultButton
        '
        Me.ResetDefaultButton.Dock = System.Windows.Forms.DockStyle.Right
        Me.ResetDefaultButton.Location = New System.Drawing.Point(256, 1)
        Me.ResetDefaultButton.Margin = New System.Windows.Forms.Padding(1)
        Me.ResetDefaultButton.Name = "ResetDefaultButton"
        Me.ResetDefaultButton.Size = New System.Drawing.Size(23, 24)
        Me.ResetDefaultButton.TabIndex = 16
        Me.ResetDefaultButton.Text = "R"
        Me.ResetDefaultButton.UseVisualStyleBackColor = True
        '
        'TitleLabel
        '
        Me.TitleLabel.AutoSize = True
        Me.RootPanel.SetColumnSpan(Me.TitleLabel, 2)
        Me.TitleLabel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TitleLabel.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.TitleLabel.Location = New System.Drawing.Point(3, 0)
        Me.TitleLabel.Name = "TitleLabel"
        Me.TitleLabel.Size = New System.Drawing.Size(184, 26)
        Me.TitleLabel.TabIndex = 8
        Me.TitleLabel.Text = "Title"
        Me.TitleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Name_BorderSize
        '
        Me.Name_BorderSize.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Name_BorderSize.Location = New System.Drawing.Point(3, 26)
        Me.Name_BorderSize.Name = "Name_BorderSize"
        Me.Name_BorderSize.Size = New System.Drawing.Size(94, 26)
        Me.Name_BorderSize.TabIndex = 4
        Me.Name_BorderSize.Text = "Name"
        Me.Name_BorderSize.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'BorderRadius_BorderColor
        '
        Me.BorderRadius_BorderColor.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BorderRadius_BorderColor.Location = New System.Drawing.Point(3, 52)
        Me.BorderRadius_BorderColor.Name = "BorderRadius_BorderColor"
        Me.BorderRadius_BorderColor.Size = New System.Drawing.Size(94, 26)
        Me.BorderRadius_BorderColor.TabIndex = 5
        Me.BorderRadius_BorderColor.Text = "BorderRadius"
        Me.BorderRadius_BorderColor.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'ShadowWidth_BackColor
        '
        Me.ShadowWidth_BackColor.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ShadowWidth_BackColor.Location = New System.Drawing.Point(3, 78)
        Me.ShadowWidth_BackColor.Name = "ShadowWidth_BackColor"
        Me.ShadowWidth_BackColor.Size = New System.Drawing.Size(94, 26)
        Me.ShadowWidth_BackColor.TabIndex = 6
        Me.ShadowWidth_BackColor.Text = "ShadowWidth"
        Me.ShadowWidth_BackColor.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'ShadowShift_ForeLineSize
        '
        Me.ShadowShift_ForeLineSize.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ShadowShift_ForeLineSize.Location = New System.Drawing.Point(3, 104)
        Me.ShadowShift_ForeLineSize.Name = "ShadowShift_ForeLineSize"
        Me.ShadowShift_ForeLineSize.Size = New System.Drawing.Size(94, 26)
        Me.ShadowShift_ForeLineSize.TabIndex = 7
        Me.ShadowShift_ForeLineSize.Text = "ShadowShift"
        Me.ShadowShift_ForeLineSize.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'FontFamily_ForeColor
        '
        Me.FontFamily_ForeColor.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FontFamily_ForeColor.Location = New System.Drawing.Point(3, 130)
        Me.FontFamily_ForeColor.Name = "FontFamily_ForeColor"
        Me.FontFamily_ForeColor.Size = New System.Drawing.Size(94, 26)
        Me.FontFamily_ForeColor.TabIndex = 8
        Me.FontFamily_ForeColor.Text = "FontFamily"
        Me.FontFamily_ForeColor.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'FontSize_ShadowDirection
        '
        Me.FontSize_ShadowDirection.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FontSize_ShadowDirection.Location = New System.Drawing.Point(3, 156)
        Me.FontSize_ShadowDirection.Name = "FontSize_ShadowDirection"
        Me.FontSize_ShadowDirection.Size = New System.Drawing.Size(94, 26)
        Me.FontSize_ShadowDirection.TabIndex = 9
        Me.FontSize_ShadowDirection.Text = "FontSize"
        Me.FontSize_ShadowDirection.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'FontStyle_ShadowColor
        '
        Me.FontStyle_ShadowColor.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FontStyle_ShadowColor.Location = New System.Drawing.Point(3, 182)
        Me.FontStyle_ShadowColor.Name = "FontStyle_ShadowColor"
        Me.FontStyle_ShadowColor.Size = New System.Drawing.Size(94, 26)
        Me.FontStyle_ShadowColor.TabIndex = 10
        Me.FontStyle_ShadowColor.Text = "FontStyle"
        Me.FontStyle_ShadowColor.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'NameTBox
        '
        Me.RootPanel.SetColumnSpan(Me.NameTBox, 2)
        Me.NameTBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.NameTBox.Location = New System.Drawing.Point(101, 27)
        Me.NameTBox.Margin = New System.Windows.Forms.Padding(1)
        Me.NameTBox.Name = "NameTBox"
        Me.NameTBox.Size = New System.Drawing.Size(178, 23)
        Me.NameTBox.TabIndex = 11
        '
        'BorderRadiusUD
        '
        Me.BorderRadiusUD.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BorderRadiusUD.Location = New System.Drawing.Point(101, 53)
        Me.BorderRadiusUD.Margin = New System.Windows.Forms.Padding(1)
        Me.BorderRadiusUD.Maximum = New Decimal(New Integer() {50, 0, 0, 0})
        Me.BorderRadiusUD.Name = "BorderRadiusUD"
        Me.BorderRadiusUD.Size = New System.Drawing.Size(88, 23)
        Me.BorderRadiusUD.TabIndex = 12
        Me.BorderRadiusUD.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'ShadowWidthUD
        '
        Me.ShadowWidthUD.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ShadowWidthUD.Location = New System.Drawing.Point(101, 79)
        Me.ShadowWidthUD.Margin = New System.Windows.Forms.Padding(1)
        Me.ShadowWidthUD.Maximum = New Decimal(New Integer() {10, 0, 0, 0})
        Me.ShadowWidthUD.Name = "ShadowWidthUD"
        Me.ShadowWidthUD.Size = New System.Drawing.Size(88, 23)
        Me.ShadowWidthUD.TabIndex = 13
        Me.ShadowWidthUD.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'ShadowShiftCheck
        '
        Me.ShadowShiftCheck.AutoSize = True
        Me.ShadowShiftCheck.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ShadowShiftCheck.Location = New System.Drawing.Point(103, 107)
        Me.ShadowShiftCheck.Name = "ShadowShiftCheck"
        Me.ShadowShiftCheck.Size = New System.Drawing.Size(84, 20)
        Me.ShadowShiftCheck.TabIndex = 14
        Me.ShadowShiftCheck.UseVisualStyleBackColor = True
        '
        'FontFamilyTBox
        '
        Me.RootPanel.SetColumnSpan(Me.FontFamilyTBox, 2)
        Me.FontFamilyTBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FontFamilyTBox.Location = New System.Drawing.Point(101, 131)
        Me.FontFamilyTBox.Margin = New System.Windows.Forms.Padding(1)
        Me.FontFamilyTBox.Name = "FontFamilyTBox"
        Me.FontFamilyTBox.Size = New System.Drawing.Size(178, 23)
        Me.FontFamilyTBox.TabIndex = 15
        '
        'FontStyleCBox
        '
        Me.FontStyleCBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FontStyleCBox.FormattingEnabled = True
        Me.FontStyleCBox.Location = New System.Drawing.Point(101, 156)
        Me.FontStyleCBox.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.FontStyleCBox.Name = "FontStyleCBox"
        Me.FontStyleCBox.Size = New System.Drawing.Size(88, 25)
        Me.FontStyleCBox.TabIndex = 16
        '
        'FontSizeCBox
        '
        Me.RootPanel.SetColumnSpan(Me.FontSizeCBox, 2)
        Me.FontSizeCBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FontSizeCBox.FormattingEnabled = True
        Me.FontSizeCBox.Location = New System.Drawing.Point(101, 182)
        Me.FontSizeCBox.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.FontSizeCBox.Name = "FontSizeCBox"
        Me.FontSizeCBox.Size = New System.Drawing.Size(178, 25)
        Me.FontSizeCBox.TabIndex = 17
        '
        'TestAprsTab
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.RootPanel)
        Me.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "TestAprsTab"
        Me.Size = New System.Drawing.Size(280, 250)
        Me.RootPanel.ResumeLayout(False)
        Me.RootPanel.PerformLayout()
        CType(Me.BorderRadiusUD, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ShadowWidthUD, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents RootPanel As TableLayoutPanel
    Friend WithEvents ResetDefaultButton As Button
    Friend WithEvents TitleLabel As Label
    Friend WithEvents Name_BorderSize As Label
    Friend WithEvents BorderRadius_BorderColor As Label
    Friend WithEvents ShadowWidth_BackColor As Label
    Friend WithEvents ShadowShift_ForeLineSize As Label
    Friend WithEvents FontFamily_ForeColor As Label
    Friend WithEvents FontSize_ShadowDirection As Label
    Friend WithEvents FontStyle_ShadowColor As Label
    Friend WithEvents NameTBox As TextBox
    Friend WithEvents BorderRadiusUD As NumericUpDown
    Friend WithEvents ShadowWidthUD As NumericUpDown
    Friend WithEvents ShadowShiftCheck As CheckBox
    Friend WithEvents FontFamilyTBox As TextBox
    Friend WithEvents FontStyleCBox As ComboBox
    Friend WithEvents FontSizeCBox As ComboBox
End Class
