<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TestSettingTab
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
        Me.RootPanel = New System.Windows.Forms.TableLayoutPanel()
        Me.BorderSizeLabel = New System.Windows.Forms.Label()
        Me.BorderColorLabel = New System.Windows.Forms.Label()
        Me.BackColorLabel = New System.Windows.Forms.Label()
        Me.ForeLineSizeLabel = New System.Windows.Forms.Label()
        Me.ForeColorLabel = New System.Windows.Forms.Label()
        Me.ShadowDirectionLabel = New System.Windows.Forms.Label()
        Me.ShadowColorLabel = New System.Windows.Forms.Label()
        Me.TitleLabel = New System.Windows.Forms.Label()
        Me.BorderSizeUpDown = New System.Windows.Forms.NumericUpDown()
        Me.BorderColorTBox = New System.Windows.Forms.TextBox()
        Me.BackColorTBox = New System.Windows.Forms.TextBox()
        Me.ForeLineSizeUpDown = New System.Windows.Forms.NumericUpDown()
        Me.ForeColorTBox = New System.Windows.Forms.TextBox()
        Me.ShadowDirectionCBox = New System.Windows.Forms.ComboBox()
        Me.ShadowColorTBox = New System.Windows.Forms.TextBox()
        Me.ResetDefaultButton = New System.Windows.Forms.Button()
        Me.RootPanel.SuspendLayout()
        CType(Me.BorderSizeUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ForeLineSizeUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RootPanel
        '
        Me.RootPanel.ColumnCount = 3
        Me.RootPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100.0!))
        Me.RootPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.RootPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.RootPanel.Controls.Add(Me.BorderSizeLabel, 0, 1)
        Me.RootPanel.Controls.Add(Me.BorderColorLabel, 0, 2)
        Me.RootPanel.Controls.Add(Me.BackColorLabel, 0, 3)
        Me.RootPanel.Controls.Add(Me.ForeLineSizeLabel, 0, 4)
        Me.RootPanel.Controls.Add(Me.ForeColorLabel, 0, 5)
        Me.RootPanel.Controls.Add(Me.ShadowDirectionLabel, 0, 6)
        Me.RootPanel.Controls.Add(Me.ShadowColorLabel, 0, 7)
        Me.RootPanel.Controls.Add(Me.TitleLabel, 0, 0)
        Me.RootPanel.Controls.Add(Me.BorderSizeUpDown, 1, 1)
        Me.RootPanel.Controls.Add(Me.BorderColorTBox, 1, 2)
        Me.RootPanel.Controls.Add(Me.BackColorTBox, 1, 3)
        Me.RootPanel.Controls.Add(Me.ForeLineSizeUpDown, 1, 4)
        Me.RootPanel.Controls.Add(Me.ForeColorTBox, 1, 5)
        Me.RootPanel.Controls.Add(Me.ShadowDirectionCBox, 1, 6)
        Me.RootPanel.Controls.Add(Me.ShadowColorTBox, 1, 7)
        Me.RootPanel.Controls.Add(Me.ResetDefaultButton, 2, 0)
        Me.RootPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RootPanel.Location = New System.Drawing.Point(0, 0)
        Me.RootPanel.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
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
        Me.RootPanel.TabIndex = 0
        '
        'BorderSizeLabel
        '
        Me.BorderSizeLabel.AutoSize = True
        Me.BorderSizeLabel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BorderSizeLabel.Location = New System.Drawing.Point(3, 26)
        Me.BorderSizeLabel.Name = "BorderSizeLabel"
        Me.BorderSizeLabel.Size = New System.Drawing.Size(94, 26)
        Me.BorderSizeLabel.TabIndex = 0
        Me.BorderSizeLabel.Text = "BorderSize"
        Me.BorderSizeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'BorderColorLabel
        '
        Me.BorderColorLabel.AutoSize = True
        Me.BorderColorLabel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BorderColorLabel.Location = New System.Drawing.Point(3, 52)
        Me.BorderColorLabel.Name = "BorderColorLabel"
        Me.BorderColorLabel.Size = New System.Drawing.Size(94, 26)
        Me.BorderColorLabel.TabIndex = 1
        Me.BorderColorLabel.Text = "BorderColor"
        Me.BorderColorLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'BackColorLabel
        '
        Me.BackColorLabel.AutoSize = True
        Me.BackColorLabel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BackColorLabel.Location = New System.Drawing.Point(3, 78)
        Me.BackColorLabel.Name = "BackColorLabel"
        Me.BackColorLabel.Size = New System.Drawing.Size(94, 26)
        Me.BackColorLabel.TabIndex = 2
        Me.BackColorLabel.Text = "BackColor"
        Me.BackColorLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'ForeLineSizeLabel
        '
        Me.ForeLineSizeLabel.AutoSize = True
        Me.ForeLineSizeLabel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ForeLineSizeLabel.Location = New System.Drawing.Point(3, 104)
        Me.ForeLineSizeLabel.Name = "ForeLineSizeLabel"
        Me.ForeLineSizeLabel.Size = New System.Drawing.Size(94, 26)
        Me.ForeLineSizeLabel.TabIndex = 3
        Me.ForeLineSizeLabel.Text = "ForeLineSize"
        Me.ForeLineSizeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'ForeColorLabel
        '
        Me.ForeColorLabel.AutoSize = True
        Me.ForeColorLabel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ForeColorLabel.Location = New System.Drawing.Point(3, 130)
        Me.ForeColorLabel.Name = "ForeColorLabel"
        Me.ForeColorLabel.Size = New System.Drawing.Size(94, 26)
        Me.ForeColorLabel.TabIndex = 4
        Me.ForeColorLabel.Text = "ForeColor"
        Me.ForeColorLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'ShadowDirectionLabel
        '
        Me.ShadowDirectionLabel.AutoSize = True
        Me.ShadowDirectionLabel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ShadowDirectionLabel.Location = New System.Drawing.Point(3, 156)
        Me.ShadowDirectionLabel.Name = "ShadowDirectionLabel"
        Me.ShadowDirectionLabel.Size = New System.Drawing.Size(94, 26)
        Me.ShadowDirectionLabel.TabIndex = 5
        Me.ShadowDirectionLabel.Text = "ShadowDirection"
        Me.ShadowDirectionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'ShadowColorLabel
        '
        Me.ShadowColorLabel.AutoSize = True
        Me.ShadowColorLabel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ShadowColorLabel.Location = New System.Drawing.Point(3, 182)
        Me.ShadowColorLabel.Name = "ShadowColorLabel"
        Me.ShadowColorLabel.Size = New System.Drawing.Size(94, 26)
        Me.ShadowColorLabel.TabIndex = 6
        Me.ShadowColorLabel.Text = "ShadowColor"
        Me.ShadowColorLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
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
        Me.TitleLabel.TabIndex = 7
        Me.TitleLabel.Text = "Title"
        Me.TitleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'BorderSizeUpDown
        '
        Me.BorderSizeUpDown.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BorderSizeUpDown.Location = New System.Drawing.Point(101, 27)
        Me.BorderSizeUpDown.Margin = New System.Windows.Forms.Padding(1)
        Me.BorderSizeUpDown.Maximum = New Decimal(New Integer() {10, 0, 0, 0})
        Me.BorderSizeUpDown.Name = "BorderSizeUpDown"
        Me.BorderSizeUpDown.Size = New System.Drawing.Size(88, 23)
        Me.BorderSizeUpDown.TabIndex = 8
        Me.BorderSizeUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'BorderColorTBox
        '
        Me.RootPanel.SetColumnSpan(Me.BorderColorTBox, 2)
        Me.BorderColorTBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BorderColorTBox.Location = New System.Drawing.Point(101, 53)
        Me.BorderColorTBox.Margin = New System.Windows.Forms.Padding(1)
        Me.BorderColorTBox.Name = "BorderColorTBox"
        Me.BorderColorTBox.Size = New System.Drawing.Size(178, 23)
        Me.BorderColorTBox.TabIndex = 9
        '
        'BackColorTBox
        '
        Me.RootPanel.SetColumnSpan(Me.BackColorTBox, 2)
        Me.BackColorTBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BackColorTBox.Location = New System.Drawing.Point(101, 79)
        Me.BackColorTBox.Margin = New System.Windows.Forms.Padding(1)
        Me.BackColorTBox.Name = "BackColorTBox"
        Me.BackColorTBox.Size = New System.Drawing.Size(178, 23)
        Me.BackColorTBox.TabIndex = 10
        '
        'ForeLineSizeUpDown
        '
        Me.ForeLineSizeUpDown.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ForeLineSizeUpDown.Location = New System.Drawing.Point(101, 105)
        Me.ForeLineSizeUpDown.Margin = New System.Windows.Forms.Padding(1)
        Me.ForeLineSizeUpDown.Maximum = New Decimal(New Integer() {10, 0, 0, 0})
        Me.ForeLineSizeUpDown.Name = "ForeLineSizeUpDown"
        Me.ForeLineSizeUpDown.Size = New System.Drawing.Size(88, 23)
        Me.ForeLineSizeUpDown.TabIndex = 11
        Me.ForeLineSizeUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'ForeColorTBox
        '
        Me.RootPanel.SetColumnSpan(Me.ForeColorTBox, 2)
        Me.ForeColorTBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ForeColorTBox.Location = New System.Drawing.Point(101, 131)
        Me.ForeColorTBox.Margin = New System.Windows.Forms.Padding(1)
        Me.ForeColorTBox.Name = "ForeColorTBox"
        Me.ForeColorTBox.Size = New System.Drawing.Size(178, 23)
        Me.ForeColorTBox.TabIndex = 12
        '
        'ShadowDirectionCBox
        '
        Me.RootPanel.SetColumnSpan(Me.ShadowDirectionCBox, 2)
        Me.ShadowDirectionCBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ShadowDirectionCBox.FormattingEnabled = True
        Me.ShadowDirectionCBox.Location = New System.Drawing.Point(101, 156)
        Me.ShadowDirectionCBox.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.ShadowDirectionCBox.Name = "ShadowDirectionCBox"
        Me.ShadowDirectionCBox.Size = New System.Drawing.Size(178, 25)
        Me.ShadowDirectionCBox.TabIndex = 13
        '
        'ShadowColorTBox
        '
        Me.RootPanel.SetColumnSpan(Me.ShadowColorTBox, 2)
        Me.ShadowColorTBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ShadowColorTBox.Location = New System.Drawing.Point(101, 183)
        Me.ShadowColorTBox.Margin = New System.Windows.Forms.Padding(1)
        Me.ShadowColorTBox.Name = "ShadowColorTBox"
        Me.ShadowColorTBox.Size = New System.Drawing.Size(178, 23)
        Me.ShadowColorTBox.TabIndex = 14
        '
        'ResetDefaultButton
        '
        Me.ResetDefaultButton.Dock = System.Windows.Forms.DockStyle.Right
        Me.ResetDefaultButton.Location = New System.Drawing.Point(256, 1)
        Me.ResetDefaultButton.Margin = New System.Windows.Forms.Padding(1)
        Me.ResetDefaultButton.Name = "ResetDefaultButton"
        Me.ResetDefaultButton.Size = New System.Drawing.Size(23, 24)
        Me.ResetDefaultButton.TabIndex = 15
        Me.ResetDefaultButton.Text = "R"
        Me.ResetDefaultButton.UseVisualStyleBackColor = True
        '
        'TestSettingTab
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.RootPanel)
        Me.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "TestSettingTab"
        Me.Size = New System.Drawing.Size(280, 250)
        Me.RootPanel.ResumeLayout(False)
        Me.RootPanel.PerformLayout()
        CType(Me.BorderSizeUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ForeLineSizeUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents RootPanel As TableLayoutPanel
    Friend WithEvents BorderSizeLabel As Label
    Friend WithEvents BorderColorLabel As Label
    Friend WithEvents BackColorLabel As Label
    Friend WithEvents ForeLineSizeLabel As Label
    Friend WithEvents ForeColorLabel As Label
    Friend WithEvents ShadowDirectionLabel As Label
    Friend WithEvents ShadowColorLabel As Label
    Friend WithEvents TitleLabel As Label
    Friend WithEvents BorderSizeUpDown As NumericUpDown
    Friend WithEvents BorderColorTBox As TextBox
    Friend WithEvents BackColorTBox As TextBox
    Friend WithEvents ForeLineSizeUpDown As NumericUpDown
    Friend WithEvents ForeColorTBox As TextBox
    Friend WithEvents ShadowDirectionCBox As ComboBox
    Friend WithEvents ShadowColorTBox As TextBox
    Friend WithEvents ResetDefaultButton As Button
End Class
