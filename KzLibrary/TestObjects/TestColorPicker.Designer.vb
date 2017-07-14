<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class TestColorPicker
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(TestColorPicker))
        Me.RootSpliter = New System.Windows.Forms.SplitContainer()
        Me.ColorsPanel = New System.Windows.Forms.FlowLayoutPanel()
        Me.RightSpliter = New System.Windows.Forms.SplitContainer()
        Me.CmdPanel = New System.Windows.Forms.TableLayoutPanel()
        Me.TitleLabel = New System.Windows.Forms.Label()
        Me.ArgbLabel = New System.Windows.Forms.Label()
        Me.AlphaLabel = New System.Windows.Forms.Label()
        Me.RedLabel = New System.Windows.Forms.Label()
        Me.GreenLabel = New System.Windows.Forms.Label()
        Me.BlueLabel = New System.Windows.Forms.Label()
        Me.AlphaUD = New System.Windows.Forms.NumericUpDown()
        Me.RedUD = New System.Windows.Forms.NumericUpDown()
        Me.GreenUD = New System.Windows.Forms.NumericUpDown()
        Me.BlueUD = New System.Windows.Forms.NumericUpDown()
        Me.HueLabel = New System.Windows.Forms.Label()
        Me.SaturationLabel = New System.Windows.Forms.Label()
        Me.BrightnessLabel = New System.Windows.Forms.Label()
        Me.HueTBox = New System.Windows.Forms.TextBox()
        Me.SaturationTBox = New System.Windows.Forms.TextBox()
        Me.BrightnessTBox = New System.Windows.Forms.TextBox()
        Me.HsbLabel = New System.Windows.Forms.Label()
        Me.GradualChecker = New System.Windows.Forms.CheckBox()
        Me.ColorOneButton = New System.Windows.Forms.Button()
        Me.ColorTwoButton = New System.Windows.Forms.Button()
        Me.PlusButton = New System.Windows.Forms.Button()
        Me.MinusButton = New System.Windows.Forms.Button()
        Me.SampleButton = New System.Windows.Forms.Button()
        Me.DirectionCBox = New System.Windows.Forms.ComboBox()
        Me.ExchangeButton = New System.Windows.Forms.Button()
        Me.RootMenu = New System.Windows.Forms.ToolStrip()
        Me.AllColorsButton = New System.Windows.Forms.ToolStripButton()
        Me.NamedColorsButton = New System.Windows.Forms.ToolStripButton()
        Me.SystemColorsButton = New System.Windows.Forms.ToolStripButton()
        Me.CustomColorsButton = New System.Windows.Forms.ToolStripButton()
        Me.CountLabel = New System.Windows.Forms.ToolStripLabel()
        Me.NameSearchBox = New System.Windows.Forms.ToolStripTextBox()
        Me.SelectedButton = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.SaveButton = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.StickerBackButton = New System.Windows.Forms.ToolStripButton()
        Me.ViewerBackButton = New System.Windows.Forms.ToolStripButton()
        CType(Me.RootSpliter, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RootSpliter.Panel1.SuspendLayout()
        Me.RootSpliter.Panel2.SuspendLayout()
        Me.RootSpliter.SuspendLayout()
        CType(Me.RightSpliter, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RightSpliter.Panel2.SuspendLayout()
        Me.RightSpliter.SuspendLayout()
        Me.CmdPanel.SuspendLayout()
        CType(Me.AlphaUD, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RedUD, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GreenUD, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BlueUD, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RootMenu.SuspendLayout()
        Me.SuspendLayout()
        '
        'RootSpliter
        '
        Me.RootSpliter.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RootSpliter.Location = New System.Drawing.Point(0, 25)
        Me.RootSpliter.Name = "RootSpliter"
        '
        'RootSpliter.Panel1
        '
        Me.RootSpliter.Panel1.Controls.Add(Me.ColorsPanel)
        '
        'RootSpliter.Panel2
        '
        Me.RootSpliter.Panel2.Controls.Add(Me.RightSpliter)
        Me.RootSpliter.Size = New System.Drawing.Size(724, 425)
        Me.RootSpliter.SplitterDistance = 286
        Me.RootSpliter.TabIndex = 0
        '
        'ColorsPanel
        '
        Me.ColorsPanel.AutoScroll = True
        Me.ColorsPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ColorsPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
        Me.ColorsPanel.Location = New System.Drawing.Point(0, 0)
        Me.ColorsPanel.Name = "ColorsPanel"
        Me.ColorsPanel.Size = New System.Drawing.Size(286, 425)
        Me.ColorsPanel.TabIndex = 1
        Me.ColorsPanel.WrapContents = False
        '
        'RightSpliter
        '
        Me.RightSpliter.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RightSpliter.Location = New System.Drawing.Point(0, 0)
        Me.RightSpliter.Name = "RightSpliter"
        Me.RightSpliter.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'RightSpliter.Panel2
        '
        Me.RightSpliter.Panel2.AutoScroll = True
        Me.RightSpliter.Panel2.Controls.Add(Me.CmdPanel)
        Me.RightSpliter.Size = New System.Drawing.Size(434, 425)
        Me.RightSpliter.SplitterDistance = 154
        Me.RightSpliter.TabIndex = 0
        '
        'CmdPanel
        '
        Me.CmdPanel.ColumnCount = 4
        Me.CmdPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.CmdPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.CmdPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.CmdPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.CmdPanel.Controls.Add(Me.TitleLabel, 0, 0)
        Me.CmdPanel.Controls.Add(Me.ArgbLabel, 0, 1)
        Me.CmdPanel.Controls.Add(Me.AlphaLabel, 0, 2)
        Me.CmdPanel.Controls.Add(Me.RedLabel, 1, 2)
        Me.CmdPanel.Controls.Add(Me.GreenLabel, 2, 2)
        Me.CmdPanel.Controls.Add(Me.BlueLabel, 3, 2)
        Me.CmdPanel.Controls.Add(Me.AlphaUD, 0, 3)
        Me.CmdPanel.Controls.Add(Me.RedUD, 1, 3)
        Me.CmdPanel.Controls.Add(Me.GreenUD, 2, 3)
        Me.CmdPanel.Controls.Add(Me.BlueUD, 3, 3)
        Me.CmdPanel.Controls.Add(Me.HueLabel, 1, 4)
        Me.CmdPanel.Controls.Add(Me.SaturationLabel, 2, 4)
        Me.CmdPanel.Controls.Add(Me.BrightnessLabel, 3, 4)
        Me.CmdPanel.Controls.Add(Me.HueTBox, 1, 5)
        Me.CmdPanel.Controls.Add(Me.SaturationTBox, 2, 5)
        Me.CmdPanel.Controls.Add(Me.BrightnessTBox, 3, 5)
        Me.CmdPanel.Controls.Add(Me.HsbLabel, 0, 4)
        Me.CmdPanel.Controls.Add(Me.GradualChecker, 0, 6)
        Me.CmdPanel.Controls.Add(Me.ColorOneButton, 0, 7)
        Me.CmdPanel.Controls.Add(Me.ColorTwoButton, 2, 7)
        Me.CmdPanel.Controls.Add(Me.PlusButton, 2, 1)
        Me.CmdPanel.Controls.Add(Me.MinusButton, 3, 1)
        Me.CmdPanel.Controls.Add(Me.SampleButton, 0, 8)
        Me.CmdPanel.Controls.Add(Me.DirectionCBox, 2, 8)
        Me.CmdPanel.Controls.Add(Me.ExchangeButton, 1, 8)
        Me.CmdPanel.Dock = System.Windows.Forms.DockStyle.Top
        Me.CmdPanel.Font = New System.Drawing.Font("Microsoft YaHei UI", 7.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.CmdPanel.Location = New System.Drawing.Point(0, 0)
        Me.CmdPanel.Name = "CmdPanel"
        Me.CmdPanel.RowCount = 11
        Me.CmdPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
        Me.CmdPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
        Me.CmdPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
        Me.CmdPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
        Me.CmdPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
        Me.CmdPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
        Me.CmdPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
        Me.CmdPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
        Me.CmdPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
        Me.CmdPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
        Me.CmdPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.CmdPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.CmdPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.CmdPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.CmdPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.CmdPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.CmdPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.CmdPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.CmdPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.CmdPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.CmdPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.CmdPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.CmdPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.CmdPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.CmdPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.CmdPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.CmdPanel.Size = New System.Drawing.Size(417, 276)
        Me.CmdPanel.TabIndex = 0
        '
        'TitleLabel
        '
        Me.TitleLabel.AutoSize = True
        Me.CmdPanel.SetColumnSpan(Me.TitleLabel, 4)
        Me.TitleLabel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TitleLabel.Font = New System.Drawing.Font("Microsoft YaHei UI", 7.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.TitleLabel.Location = New System.Drawing.Point(3, 0)
        Me.TitleLabel.Name = "TitleLabel"
        Me.TitleLabel.Size = New System.Drawing.Size(411, 25)
        Me.TitleLabel.TabIndex = 0
        Me.TitleLabel.Text = "ColorName : &HXXXXXXXX"
        Me.TitleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ArgbLabel
        '
        Me.CmdPanel.SetColumnSpan(Me.ArgbLabel, 2)
        Me.ArgbLabel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ArgbLabel.Location = New System.Drawing.Point(3, 25)
        Me.ArgbLabel.Name = "ArgbLabel"
        Me.ArgbLabel.Size = New System.Drawing.Size(202, 25)
        Me.ArgbLabel.TabIndex = 1
        Me.ArgbLabel.Text = "ARGB : 000000000"
        Me.ArgbLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'AlphaLabel
        '
        Me.AlphaLabel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.AlphaLabel.Location = New System.Drawing.Point(3, 50)
        Me.AlphaLabel.Name = "AlphaLabel"
        Me.AlphaLabel.Size = New System.Drawing.Size(98, 25)
        Me.AlphaLabel.TabIndex = 2
        Me.AlphaLabel.Text = "Alpha"
        Me.AlphaLabel.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'RedLabel
        '
        Me.RedLabel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RedLabel.Location = New System.Drawing.Point(107, 50)
        Me.RedLabel.Name = "RedLabel"
        Me.RedLabel.Size = New System.Drawing.Size(98, 25)
        Me.RedLabel.TabIndex = 3
        Me.RedLabel.Text = "Red"
        Me.RedLabel.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'GreenLabel
        '
        Me.GreenLabel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GreenLabel.Location = New System.Drawing.Point(211, 50)
        Me.GreenLabel.Name = "GreenLabel"
        Me.GreenLabel.Size = New System.Drawing.Size(98, 25)
        Me.GreenLabel.TabIndex = 4
        Me.GreenLabel.Text = "Green"
        Me.GreenLabel.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'BlueLabel
        '
        Me.BlueLabel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BlueLabel.Location = New System.Drawing.Point(315, 50)
        Me.BlueLabel.Name = "BlueLabel"
        Me.BlueLabel.Size = New System.Drawing.Size(99, 25)
        Me.BlueLabel.TabIndex = 5
        Me.BlueLabel.Text = "Blue"
        Me.BlueLabel.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'AlphaUD
        '
        Me.AlphaUD.Dock = System.Windows.Forms.DockStyle.Fill
        Me.AlphaUD.Location = New System.Drawing.Point(2, 77)
        Me.AlphaUD.Margin = New System.Windows.Forms.Padding(2)
        Me.AlphaUD.Maximum = New Decimal(New Integer() {255, 0, 0, 0})
        Me.AlphaUD.Name = "AlphaUD"
        Me.AlphaUD.Size = New System.Drawing.Size(100, 20)
        Me.AlphaUD.TabIndex = 6
        Me.AlphaUD.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'RedUD
        '
        Me.RedUD.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RedUD.Location = New System.Drawing.Point(106, 77)
        Me.RedUD.Margin = New System.Windows.Forms.Padding(2)
        Me.RedUD.Maximum = New Decimal(New Integer() {255, 0, 0, 0})
        Me.RedUD.Name = "RedUD"
        Me.RedUD.Size = New System.Drawing.Size(100, 20)
        Me.RedUD.TabIndex = 7
        Me.RedUD.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GreenUD
        '
        Me.GreenUD.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GreenUD.Location = New System.Drawing.Point(210, 77)
        Me.GreenUD.Margin = New System.Windows.Forms.Padding(2)
        Me.GreenUD.Maximum = New Decimal(New Integer() {255, 0, 0, 0})
        Me.GreenUD.Name = "GreenUD"
        Me.GreenUD.Size = New System.Drawing.Size(100, 20)
        Me.GreenUD.TabIndex = 8
        Me.GreenUD.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'BlueUD
        '
        Me.BlueUD.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BlueUD.Location = New System.Drawing.Point(314, 77)
        Me.BlueUD.Margin = New System.Windows.Forms.Padding(2)
        Me.BlueUD.Maximum = New Decimal(New Integer() {255, 0, 0, 0})
        Me.BlueUD.Name = "BlueUD"
        Me.BlueUD.Size = New System.Drawing.Size(101, 20)
        Me.BlueUD.TabIndex = 9
        Me.BlueUD.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'HueLabel
        '
        Me.HueLabel.AutoSize = True
        Me.HueLabel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.HueLabel.Location = New System.Drawing.Point(107, 100)
        Me.HueLabel.Name = "HueLabel"
        Me.HueLabel.Size = New System.Drawing.Size(98, 25)
        Me.HueLabel.TabIndex = 10
        Me.HueLabel.Text = "Hue"
        Me.HueLabel.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'SaturationLabel
        '
        Me.SaturationLabel.AutoSize = True
        Me.SaturationLabel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SaturationLabel.Location = New System.Drawing.Point(211, 100)
        Me.SaturationLabel.Name = "SaturationLabel"
        Me.SaturationLabel.Size = New System.Drawing.Size(98, 25)
        Me.SaturationLabel.TabIndex = 11
        Me.SaturationLabel.Text = "Saturation"
        Me.SaturationLabel.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'BrightnessLabel
        '
        Me.BrightnessLabel.AutoSize = True
        Me.BrightnessLabel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BrightnessLabel.Location = New System.Drawing.Point(315, 100)
        Me.BrightnessLabel.Name = "BrightnessLabel"
        Me.BrightnessLabel.Size = New System.Drawing.Size(99, 25)
        Me.BrightnessLabel.TabIndex = 12
        Me.BrightnessLabel.Text = "Brightness"
        Me.BrightnessLabel.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'HueTBox
        '
        Me.HueTBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.HueTBox.Location = New System.Drawing.Point(107, 128)
        Me.HueTBox.Name = "HueTBox"
        Me.HueTBox.ReadOnly = True
        Me.HueTBox.Size = New System.Drawing.Size(98, 20)
        Me.HueTBox.TabIndex = 13
        '
        'SaturationTBox
        '
        Me.SaturationTBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SaturationTBox.Location = New System.Drawing.Point(211, 128)
        Me.SaturationTBox.Name = "SaturationTBox"
        Me.SaturationTBox.ReadOnly = True
        Me.SaturationTBox.Size = New System.Drawing.Size(98, 20)
        Me.SaturationTBox.TabIndex = 14
        '
        'BrightnessTBox
        '
        Me.BrightnessTBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BrightnessTBox.Location = New System.Drawing.Point(315, 128)
        Me.BrightnessTBox.Name = "BrightnessTBox"
        Me.BrightnessTBox.ReadOnly = True
        Me.BrightnessTBox.Size = New System.Drawing.Size(99, 20)
        Me.BrightnessTBox.TabIndex = 15
        '
        'HsbLabel
        '
        Me.HsbLabel.AutoSize = True
        Me.HsbLabel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.HsbLabel.Location = New System.Drawing.Point(3, 100)
        Me.HsbLabel.Name = "HsbLabel"
        Me.CmdPanel.SetRowSpan(Me.HsbLabel, 2)
        Me.HsbLabel.Size = New System.Drawing.Size(98, 50)
        Me.HsbLabel.TabIndex = 16
        Me.HsbLabel.Text = "HSB Model"
        Me.HsbLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'GradualChecker
        '
        Me.GradualChecker.AutoSize = True
        Me.CmdPanel.SetColumnSpan(Me.GradualChecker, 2)
        Me.GradualChecker.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GradualChecker.Location = New System.Drawing.Point(3, 153)
        Me.GradualChecker.Name = "GradualChecker"
        Me.GradualChecker.Size = New System.Drawing.Size(202, 19)
        Me.GradualChecker.TabIndex = 18
        Me.GradualChecker.Text = "Gradual mode"
        Me.GradualChecker.UseVisualStyleBackColor = True
        '
        'ColorOneButton
        '
        Me.CmdPanel.SetColumnSpan(Me.ColorOneButton, 2)
        Me.ColorOneButton.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ColorOneButton.Location = New System.Drawing.Point(0, 175)
        Me.ColorOneButton.Margin = New System.Windows.Forms.Padding(0)
        Me.ColorOneButton.Name = "ColorOneButton"
        Me.ColorOneButton.Size = New System.Drawing.Size(208, 25)
        Me.ColorOneButton.TabIndex = 19
        Me.ColorOneButton.Text = "Color 1"
        Me.ColorOneButton.UseVisualStyleBackColor = True
        '
        'ColorTwoButton
        '
        Me.CmdPanel.SetColumnSpan(Me.ColorTwoButton, 2)
        Me.ColorTwoButton.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ColorTwoButton.Location = New System.Drawing.Point(208, 175)
        Me.ColorTwoButton.Margin = New System.Windows.Forms.Padding(0)
        Me.ColorTwoButton.Name = "ColorTwoButton"
        Me.ColorTwoButton.Size = New System.Drawing.Size(209, 25)
        Me.ColorTwoButton.TabIndex = 20
        Me.ColorTwoButton.Text = "Color 2"
        Me.ColorTwoButton.UseVisualStyleBackColor = True
        '
        'PlusButton
        '
        Me.PlusButton.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PlusButton.Location = New System.Drawing.Point(208, 25)
        Me.PlusButton.Margin = New System.Windows.Forms.Padding(0)
        Me.PlusButton.Name = "PlusButton"
        Me.PlusButton.Size = New System.Drawing.Size(104, 25)
        Me.PlusButton.TabIndex = 21
        Me.PlusButton.Text = "+"
        Me.PlusButton.UseVisualStyleBackColor = True
        '
        'MinusButton
        '
        Me.MinusButton.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MinusButton.Location = New System.Drawing.Point(312, 25)
        Me.MinusButton.Margin = New System.Windows.Forms.Padding(0)
        Me.MinusButton.Name = "MinusButton"
        Me.MinusButton.Size = New System.Drawing.Size(105, 25)
        Me.MinusButton.TabIndex = 22
        Me.MinusButton.Text = "-"
        Me.MinusButton.UseVisualStyleBackColor = True
        '
        'SampleButton
        '
        Me.SampleButton.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SampleButton.Location = New System.Drawing.Point(0, 200)
        Me.SampleButton.Margin = New System.Windows.Forms.Padding(0)
        Me.SampleButton.Name = "SampleButton"
        Me.SampleButton.Size = New System.Drawing.Size(104, 25)
        Me.SampleButton.TabIndex = 23
        Me.SampleButton.Text = "Sample"
        Me.SampleButton.UseVisualStyleBackColor = True
        '
        'DirectionCBox
        '
        Me.CmdPanel.SetColumnSpan(Me.DirectionCBox, 2)
        Me.DirectionCBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DirectionCBox.FormattingEnabled = True
        Me.DirectionCBox.Location = New System.Drawing.Point(209, 201)
        Me.DirectionCBox.Margin = New System.Windows.Forms.Padding(1)
        Me.DirectionCBox.Name = "DirectionCBox"
        Me.DirectionCBox.Size = New System.Drawing.Size(207, 24)
        Me.DirectionCBox.TabIndex = 24
        '
        'ExchangeButton
        '
        Me.ExchangeButton.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ExchangeButton.Location = New System.Drawing.Point(104, 200)
        Me.ExchangeButton.Margin = New System.Windows.Forms.Padding(0)
        Me.ExchangeButton.Name = "ExchangeButton"
        Me.ExchangeButton.Size = New System.Drawing.Size(104, 25)
        Me.ExchangeButton.TabIndex = 25
        Me.ExchangeButton.Text = "Exchange"
        Me.ExchangeButton.UseVisualStyleBackColor = True
        '
        'RootMenu
        '
        Me.RootMenu.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.RootMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AllColorsButton, Me.NamedColorsButton, Me.SystemColorsButton, Me.CustomColorsButton, Me.CountLabel, Me.NameSearchBox, Me.SelectedButton, Me.ToolStripSeparator1, Me.SaveButton, Me.ToolStripSeparator2, Me.StickerBackButton, Me.ViewerBackButton})
        Me.RootMenu.Location = New System.Drawing.Point(0, 0)
        Me.RootMenu.Name = "RootMenu"
        Me.RootMenu.Size = New System.Drawing.Size(724, 25)
        Me.RootMenu.TabIndex = 0
        Me.RootMenu.Text = "ToolStrip1"
        '
        'AllColorsButton
        '
        Me.AllColorsButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.AllColorsButton.Image = CType(resources.GetObject("AllColorsButton.Image"), System.Drawing.Image)
        Me.AllColorsButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.AllColorsButton.Name = "AllColorsButton"
        Me.AllColorsButton.Size = New System.Drawing.Size(23, 22)
        Me.AllColorsButton.Text = "ToolStripButton1"
        '
        'NamedColorsButton
        '
        Me.NamedColorsButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.NamedColorsButton.Image = CType(resources.GetObject("NamedColorsButton.Image"), System.Drawing.Image)
        Me.NamedColorsButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.NamedColorsButton.Name = "NamedColorsButton"
        Me.NamedColorsButton.Size = New System.Drawing.Size(23, 22)
        Me.NamedColorsButton.Text = "ToolStripButton2"
        '
        'SystemColorsButton
        '
        Me.SystemColorsButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.SystemColorsButton.Image = CType(resources.GetObject("SystemColorsButton.Image"), System.Drawing.Image)
        Me.SystemColorsButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.SystemColorsButton.Name = "SystemColorsButton"
        Me.SystemColorsButton.Size = New System.Drawing.Size(23, 22)
        Me.SystemColorsButton.Text = "ToolStripButton3"
        '
        'CustomColorsButton
        '
        Me.CustomColorsButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.CustomColorsButton.Image = CType(resources.GetObject("CustomColorsButton.Image"), System.Drawing.Image)
        Me.CustomColorsButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.CustomColorsButton.Name = "CustomColorsButton"
        Me.CustomColorsButton.Size = New System.Drawing.Size(23, 22)
        Me.CustomColorsButton.Text = "ToolStripButton1"
        '
        'CountLabel
        '
        Me.CountLabel.Name = "CountLabel"
        Me.CountLabel.Size = New System.Drawing.Size(37, 22)
        Me.CountLabel.Text = "[000]"
        '
        'NameSearchBox
        '
        Me.NameSearchBox.Name = "NameSearchBox"
        Me.NameSearchBox.Size = New System.Drawing.Size(100, 25)
        '
        'SelectedButton
        '
        Me.SelectedButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.SelectedButton.Image = CType(resources.GetObject("SelectedButton.Image"), System.Drawing.Image)
        Me.SelectedButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.SelectedButton.Name = "SelectedButton"
        Me.SelectedButton.Size = New System.Drawing.Size(23, 22)
        Me.SelectedButton.Text = "ToolStripButton1"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'SaveButton
        '
        Me.SaveButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.SaveButton.Image = CType(resources.GetObject("SaveButton.Image"), System.Drawing.Image)
        Me.SaveButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.SaveButton.Name = "SaveButton"
        Me.SaveButton.Size = New System.Drawing.Size(23, 22)
        Me.SaveButton.Text = "ToolStripButton1"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'StickerBackButton
        '
        Me.StickerBackButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.StickerBackButton.Image = CType(resources.GetObject("StickerBackButton.Image"), System.Drawing.Image)
        Me.StickerBackButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.StickerBackButton.Name = "StickerBackButton"
        Me.StickerBackButton.Size = New System.Drawing.Size(23, 22)
        Me.StickerBackButton.Text = "ToolStripButton1"
        '
        'ViewerBackButton
        '
        Me.ViewerBackButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ViewerBackButton.Image = CType(resources.GetObject("ViewerBackButton.Image"), System.Drawing.Image)
        Me.ViewerBackButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ViewerBackButton.Name = "ViewerBackButton"
        Me.ViewerBackButton.Size = New System.Drawing.Size(23, 22)
        Me.ViewerBackButton.Text = "ToolStripButton2"
        '
        'TestColorPicker
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.RootSpliter)
        Me.Controls.Add(Me.RootMenu)
        Me.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "TestColorPicker"
        Me.Size = New System.Drawing.Size(724, 450)
        Me.RootSpliter.Panel1.ResumeLayout(False)
        Me.RootSpliter.Panel2.ResumeLayout(False)
        CType(Me.RootSpliter, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RootSpliter.ResumeLayout(False)
        Me.RightSpliter.Panel2.ResumeLayout(False)
        CType(Me.RightSpliter, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RightSpliter.ResumeLayout(False)
        Me.CmdPanel.ResumeLayout(False)
        Me.CmdPanel.PerformLayout()
        CType(Me.AlphaUD, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RedUD, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GreenUD, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BlueUD, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RootMenu.ResumeLayout(False)
        Me.RootMenu.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents RootSpliter As SplitContainer
    Friend WithEvents ColorsPanel As FlowLayoutPanel
    Friend WithEvents RootMenu As ToolStrip
    Friend WithEvents RightSpliter As SplitContainer
    Friend WithEvents CmdPanel As TableLayoutPanel
    Friend WithEvents TitleLabel As Label
    Friend WithEvents ArgbLabel As Label
    Friend WithEvents AlphaLabel As Label
    Friend WithEvents RedLabel As Label
    Friend WithEvents GreenLabel As Label
    Friend WithEvents BlueLabel As Label
    Friend WithEvents AlphaUD As NumericUpDown
    Friend WithEvents RedUD As NumericUpDown
    Friend WithEvents GreenUD As NumericUpDown
    Friend WithEvents BlueUD As NumericUpDown
    Friend WithEvents HueLabel As Label
    Friend WithEvents SaturationLabel As Label
    Friend WithEvents BrightnessLabel As Label
    Friend WithEvents HueTBox As TextBox
    Friend WithEvents SaturationTBox As TextBox
    Friend WithEvents BrightnessTBox As TextBox
    Friend WithEvents HsbLabel As Label
    Friend WithEvents GradualChecker As CheckBox
    Friend WithEvents ColorOneButton As Button
    Friend WithEvents ColorTwoButton As Button
    Friend WithEvents PlusButton As Button
    Friend WithEvents MinusButton As Button
    Friend WithEvents SampleButton As Button
    Friend WithEvents DirectionCBox As ComboBox
    Friend WithEvents ExchangeButton As Button
    Friend WithEvents AllColorsButton As ToolStripButton
    Friend WithEvents NamedColorsButton As ToolStripButton
    Friend WithEvents SystemColorsButton As ToolStripButton
    Friend WithEvents CustomColorsButton As ToolStripButton
    Friend WithEvents CountLabel As ToolStripLabel
    Friend WithEvents NameSearchBox As ToolStripTextBox
    Friend WithEvents SelectedButton As ToolStripButton
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents SaveButton As ToolStripButton
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents StickerBackButton As ToolStripButton
    Friend WithEvents ViewerBackButton As ToolStripButton
End Class
