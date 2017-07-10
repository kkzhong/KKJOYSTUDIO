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
        Me.RadiusUD = New System.Windows.Forms.NumericUpDown()
        Me.LineWidthUD = New System.Windows.Forms.NumericUpDown()
        Me.LineColorBox = New System.Windows.Forms.TextBox()
        Me.FillColorBox = New System.Windows.Forms.TextBox()
        Me.ShadowWidthUD = New System.Windows.Forms.NumericUpDown()
        Me.ShadowColorBox = New System.Windows.Forms.TextBox()
        Me.FontColorBox = New System.Windows.Forms.TextBox()
        Me.FontSizeCBox = New System.Windows.Forms.ComboBox()
        Me.FontNameBox = New System.Windows.Forms.TextBox()
        Me.FontStyleCBox = New System.Windows.Forms.ComboBox()
        Me.InnerColorBox = New System.Windows.Forms.TextBox()
        Me.NameBox = New System.Windows.Forms.TextBox()
        Me.TRightSpliter = New System.Windows.Forms.SplitContainer()
        Me.CodeBox = New System.Windows.Forms.TextBox()
        Me.BottomSpliter = New System.Windows.Forms.SplitContainer()
        Me.CmdPanel = New System.Windows.Forms.TableLayoutPanel()
        Me.TabRadio = New System.Windows.Forms.RadioButton()
        Me.LetsGoButton = New System.Windows.Forms.Button()
        Me.TripleRadio = New System.Windows.Forms.RadioButton()
        Me.GiveUpButton = New System.Windows.Forms.Button()
        Me.SingleRadio = New System.Windows.Forms.RadioButton()
        Me.GetCodeButton = New System.Windows.Forms.Button()
        Me.ShowWordsBox = New System.Windows.Forms.TextBox()
        Me.MsgLabel = New System.Windows.Forms.Label()
        Me.TextLabel = New System.Windows.Forms.Label()
        Me.SetNorNor = New System.Windows.Forms.Button()
        Me.SetNorHov = New System.Windows.Forms.Button()
        Me.SetNorPrs = New System.Windows.Forms.Button()
        Me.SetSelNor = New System.Windows.Forms.Button()
        Me.SetSelHov = New System.Windows.Forms.Button()
        Me.SetSelPrs = New System.Windows.Forms.Button()
        Me.SetNorBtnNor = New System.Windows.Forms.Button()
        Me.SetNorBtnHov = New System.Windows.Forms.Button()
        Me.SetNorBtnPrs = New System.Windows.Forms.Button()
        Me.SetSelBtnNor = New System.Windows.Forms.Button()
        Me.SetSelBtnHov = New System.Windows.Forms.Button()
        Me.SetSelBtnPrs = New System.Windows.Forms.Button()
        Me.NorTab = New System.Windows.Forms.Label()
        Me.SelTab = New System.Windows.Forms.Label()
        Me.NorBtn = New System.Windows.Forms.Label()
        Me.SelBtn = New System.Windows.Forms.Label()
        CType(Me.RootSpliter, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RootSpliter.Panel1.SuspendLayout()
        Me.RootSpliter.Panel2.SuspendLayout()
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
        CType(Me.BottomSpliter, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BottomSpliter.Panel2.SuspendLayout()
        Me.BottomSpliter.SuspendLayout()
        Me.CmdPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'RootSpliter
        '
        Me.RootSpliter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.RootSpliter.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RootSpliter.FixedPanel = System.Windows.Forms.FixedPanel.Panel2
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
        Me.RootSpliter.Panel2.Controls.Add(Me.BottomSpliter)
        Me.RootSpliter.Size = New System.Drawing.Size(747, 493)
        Me.RootSpliter.SplitterDistance = 284
        Me.RootSpliter.TabIndex = 0
        '
        'TopSpliter
        '
        Me.TopSpliter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
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
        Me.TopSpliter.Size = New System.Drawing.Size(747, 284)
        Me.TopSpliter.SplitterDistance = 211
        Me.TopSpliter.SplitterWidth = 2
        Me.TopSpliter.TabIndex = 0
        '
        'InputPanel
        '
        Me.InputPanel.ColumnCount = 2
        Me.InputPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 90.0!))
        Me.InputPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.InputPanel.Controls.Add(Me.StatusCBox, 1, 1)
        Me.InputPanel.Controls.Add(Me.FrameWidthUD, 1, 2)
        Me.InputPanel.Controls.Add(Me.FrameColorBox, 1, 3)
        Me.InputPanel.Controls.Add(Me.RadiusUD, 1, 4)
        Me.InputPanel.Controls.Add(Me.LineWidthUD, 1, 5)
        Me.InputPanel.Controls.Add(Me.LineColorBox, 1, 6)
        Me.InputPanel.Controls.Add(Me.FillColorBox, 1, 7)
        Me.InputPanel.Controls.Add(Me.ShadowWidthUD, 1, 9)
        Me.InputPanel.Controls.Add(Me.ShadowColorBox, 1, 10)
        Me.InputPanel.Controls.Add(Me.FontColorBox, 1, 11)
        Me.InputPanel.Controls.Add(Me.FontSizeCBox, 1, 13)
        Me.InputPanel.Controls.Add(Me.FontNameBox, 1, 12)
        Me.InputPanel.Controls.Add(Me.FontStyleCBox, 1, 14)
        Me.InputPanel.Controls.Add(Me.InnerColorBox, 1, 8)
        Me.InputPanel.Controls.Add(Me.NameBox, 1, 0)
        Me.InputPanel.Dock = System.Windows.Forms.DockStyle.Top
        Me.InputPanel.Location = New System.Drawing.Point(0, 0)
        Me.InputPanel.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.InputPanel.Name = "InputPanel"
        Me.InputPanel.RowCount = 16
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
        Me.InputPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28.0!))
        Me.InputPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.InputPanel.Size = New System.Drawing.Size(192, 438)
        Me.InputPanel.TabIndex = 0
        '
        'StatusCBox
        '
        Me.StatusCBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.StatusCBox.FormattingEnabled = True
        Me.StatusCBox.Location = New System.Drawing.Point(93, 31)
        Me.StatusCBox.Name = "StatusCBox"
        Me.StatusCBox.Size = New System.Drawing.Size(96, 25)
        Me.StatusCBox.TabIndex = 0
        '
        'FrameWidthUD
        '
        Me.FrameWidthUD.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FrameWidthUD.Location = New System.Drawing.Point(93, 59)
        Me.FrameWidthUD.Maximum = New Decimal(New Integer() {9, 0, 0, 0})
        Me.FrameWidthUD.Name = "FrameWidthUD"
        Me.FrameWidthUD.Size = New System.Drawing.Size(96, 23)
        Me.FrameWidthUD.TabIndex = 1
        Me.FrameWidthUD.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'FrameColorBox
        '
        Me.FrameColorBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FrameColorBox.Location = New System.Drawing.Point(93, 87)
        Me.FrameColorBox.Name = "FrameColorBox"
        Me.FrameColorBox.Size = New System.Drawing.Size(96, 23)
        Me.FrameColorBox.TabIndex = 2
        '
        'RadiusUD
        '
        Me.RadiusUD.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RadiusUD.Location = New System.Drawing.Point(93, 115)
        Me.RadiusUD.Maximum = New Decimal(New Integer() {48, 0, 0, 0})
        Me.RadiusUD.Name = "RadiusUD"
        Me.RadiusUD.Size = New System.Drawing.Size(96, 23)
        Me.RadiusUD.TabIndex = 4
        Me.RadiusUD.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'LineWidthUD
        '
        Me.LineWidthUD.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LineWidthUD.Location = New System.Drawing.Point(93, 143)
        Me.LineWidthUD.Maximum = New Decimal(New Integer() {9, 0, 0, 0})
        Me.LineWidthUD.Name = "LineWidthUD"
        Me.LineWidthUD.Size = New System.Drawing.Size(96, 23)
        Me.LineWidthUD.TabIndex = 5
        Me.LineWidthUD.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'LineColorBox
        '
        Me.LineColorBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LineColorBox.Location = New System.Drawing.Point(93, 171)
        Me.LineColorBox.Name = "LineColorBox"
        Me.LineColorBox.Size = New System.Drawing.Size(96, 23)
        Me.LineColorBox.TabIndex = 6
        '
        'FillColorBox
        '
        Me.FillColorBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FillColorBox.Location = New System.Drawing.Point(93, 199)
        Me.FillColorBox.Name = "FillColorBox"
        Me.FillColorBox.Size = New System.Drawing.Size(96, 23)
        Me.FillColorBox.TabIndex = 7
        '
        'ShadowWidthUD
        '
        Me.ShadowWidthUD.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ShadowWidthUD.Location = New System.Drawing.Point(93, 255)
        Me.ShadowWidthUD.Maximum = New Decimal(New Integer() {9, 0, 0, 0})
        Me.ShadowWidthUD.Name = "ShadowWidthUD"
        Me.ShadowWidthUD.Size = New System.Drawing.Size(96, 23)
        Me.ShadowWidthUD.TabIndex = 10
        Me.ShadowWidthUD.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'ShadowColorBox
        '
        Me.ShadowColorBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ShadowColorBox.Location = New System.Drawing.Point(93, 283)
        Me.ShadowColorBox.Name = "ShadowColorBox"
        Me.ShadowColorBox.Size = New System.Drawing.Size(96, 23)
        Me.ShadowColorBox.TabIndex = 11
        '
        'FontColorBox
        '
        Me.FontColorBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FontColorBox.Location = New System.Drawing.Point(93, 311)
        Me.FontColorBox.Name = "FontColorBox"
        Me.FontColorBox.Size = New System.Drawing.Size(96, 23)
        Me.FontColorBox.TabIndex = 13
        '
        'FontSizeCBox
        '
        Me.FontSizeCBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FontSizeCBox.FormattingEnabled = True
        Me.FontSizeCBox.Location = New System.Drawing.Point(93, 367)
        Me.FontSizeCBox.Name = "FontSizeCBox"
        Me.FontSizeCBox.Size = New System.Drawing.Size(96, 25)
        Me.FontSizeCBox.TabIndex = 16
        '
        'FontNameBox
        '
        Me.FontNameBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FontNameBox.Location = New System.Drawing.Point(93, 339)
        Me.FontNameBox.Name = "FontNameBox"
        Me.FontNameBox.Size = New System.Drawing.Size(96, 23)
        Me.FontNameBox.TabIndex = 20
        '
        'FontStyleCBox
        '
        Me.FontStyleCBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FontStyleCBox.FormattingEnabled = True
        Me.FontStyleCBox.Location = New System.Drawing.Point(93, 395)
        Me.FontStyleCBox.Name = "FontStyleCBox"
        Me.FontStyleCBox.Size = New System.Drawing.Size(96, 25)
        Me.FontStyleCBox.TabIndex = 21
        '
        'InnerColorBox
        '
        Me.InnerColorBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.InnerColorBox.Location = New System.Drawing.Point(93, 227)
        Me.InnerColorBox.Name = "InnerColorBox"
        Me.InnerColorBox.Size = New System.Drawing.Size(96, 23)
        Me.InnerColorBox.TabIndex = 22
        '
        'NameBox
        '
        Me.NameBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.NameBox.Location = New System.Drawing.Point(93, 3)
        Me.NameBox.Name = "NameBox"
        Me.NameBox.Size = New System.Drawing.Size(96, 23)
        Me.NameBox.TabIndex = 23
        '
        'TRightSpliter
        '
        Me.TRightSpliter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TRightSpliter.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TRightSpliter.Location = New System.Drawing.Point(0, 0)
        Me.TRightSpliter.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TRightSpliter.Name = "TRightSpliter"
        '
        'TRightSpliter.Panel2
        '
        Me.TRightSpliter.Panel2.Controls.Add(Me.CodeBox)
        Me.TRightSpliter.Size = New System.Drawing.Size(534, 284)
        Me.TRightSpliter.SplitterDistance = 227
        Me.TRightSpliter.SplitterWidth = 2
        Me.TRightSpliter.TabIndex = 0
        '
        'CodeBox
        '
        Me.CodeBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CodeBox.Location = New System.Drawing.Point(0, 0)
        Me.CodeBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.CodeBox.Multiline = True
        Me.CodeBox.Name = "CodeBox"
        Me.CodeBox.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.CodeBox.Size = New System.Drawing.Size(303, 282)
        Me.CodeBox.TabIndex = 0
        Me.CodeBox.WordWrap = False
        '
        'BottomSpliter
        '
        Me.BottomSpliter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.BottomSpliter.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BottomSpliter.Location = New System.Drawing.Point(0, 0)
        Me.BottomSpliter.Name = "BottomSpliter"
        '
        'BottomSpliter.Panel1
        '
        '
        'BottomSpliter.Panel2
        '
        Me.BottomSpliter.Panel2.Controls.Add(Me.CmdPanel)
        Me.BottomSpliter.Panel2.Padding = New System.Windows.Forms.Padding(3, 3, 3, 0)
        Me.BottomSpliter.Size = New System.Drawing.Size(747, 205)
        Me.BottomSpliter.SplitterDistance = 351
        Me.BottomSpliter.SplitterWidth = 3
        Me.BottomSpliter.TabIndex = 0
        '
        'CmdPanel
        '
        Me.CmdPanel.ColumnCount = 6
        Me.CmdPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.CmdPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.CmdPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.CmdPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.CmdPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.CmdPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.CmdPanel.Controls.Add(Me.TabRadio, 4, 2)
        Me.CmdPanel.Controls.Add(Me.LetsGoButton, 5, 8)
        Me.CmdPanel.Controls.Add(Me.TripleRadio, 2, 2)
        Me.CmdPanel.Controls.Add(Me.GiveUpButton, 4, 8)
        Me.CmdPanel.Controls.Add(Me.SingleRadio, 0, 2)
        Me.CmdPanel.Controls.Add(Me.GetCodeButton, 1, 8)
        Me.CmdPanel.Controls.Add(Me.ShowWordsBox, 1, 1)
        Me.CmdPanel.Controls.Add(Me.MsgLabel, 0, 0)
        Me.CmdPanel.Controls.Add(Me.TextLabel, 0, 1)
        Me.CmdPanel.Controls.Add(Me.SetNorNor, 0, 4)
        Me.CmdPanel.Controls.Add(Me.SetNorHov, 1, 4)
        Me.CmdPanel.Controls.Add(Me.SetNorPrs, 2, 4)
        Me.CmdPanel.Controls.Add(Me.SetSelNor, 3, 4)
        Me.CmdPanel.Controls.Add(Me.SetSelHov, 4, 4)
        Me.CmdPanel.Controls.Add(Me.SetSelPrs, 5, 4)
        Me.CmdPanel.Controls.Add(Me.SetNorBtnNor, 0, 6)
        Me.CmdPanel.Controls.Add(Me.SetNorBtnHov, 1, 6)
        Me.CmdPanel.Controls.Add(Me.SetNorBtnPrs, 2, 6)
        Me.CmdPanel.Controls.Add(Me.SetSelBtnNor, 3, 6)
        Me.CmdPanel.Controls.Add(Me.SetSelBtnHov, 4, 6)
        Me.CmdPanel.Controls.Add(Me.SetSelBtnPrs, 5, 6)
        Me.CmdPanel.Controls.Add(Me.NorTab, 0, 3)
        Me.CmdPanel.Controls.Add(Me.SelTab, 3, 3)
        Me.CmdPanel.Controls.Add(Me.NorBtn, 0, 5)
        Me.CmdPanel.Controls.Add(Me.SelBtn, 3, 5)
        Me.CmdPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CmdPanel.Location = New System.Drawing.Point(3, 3)
        Me.CmdPanel.Name = "CmdPanel"
        Me.CmdPanel.RowCount = 9
        Me.CmdPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.CmdPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 23.0!))
        Me.CmdPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
        Me.CmdPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.CmdPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
        Me.CmdPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.CmdPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
        Me.CmdPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 6.0!))
        Me.CmdPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
        Me.CmdPanel.Size = New System.Drawing.Size(385, 200)
        Me.CmdPanel.TabIndex = 3
        '
        'TabRadio
        '
        Me.TabRadio.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TabRadio.AutoSize = True
        Me.CmdPanel.SetColumnSpan(Me.TabRadio, 2)
        Me.TabRadio.Location = New System.Drawing.Point(277, 45)
        Me.TabRadio.Margin = New System.Windows.Forms.Padding(0)
        Me.TabRadio.Name = "TabRadio"
        Me.TabRadio.Size = New System.Drawing.Size(86, 21)
        Me.TabRadio.TabIndex = 7
        Me.TabRadio.TabStop = True
        Me.TabRadio.Text = "TabModel"
        Me.TabRadio.UseVisualStyleBackColor = True
        '
        'LetsGoButton
        '
        Me.LetsGoButton.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.LetsGoButton.Dock = System.Windows.Forms.DockStyle.Top
        Me.LetsGoButton.Location = New System.Drawing.Point(320, 164)
        Me.LetsGoButton.Margin = New System.Windows.Forms.Padding(0)
        Me.LetsGoButton.Name = "LetsGoButton"
        Me.LetsGoButton.Size = New System.Drawing.Size(65, 25)
        Me.LetsGoButton.TabIndex = 1
        Me.LetsGoButton.Text = "OK"
        Me.LetsGoButton.UseVisualStyleBackColor = True
        '
        'TripleRadio
        '
        Me.TripleRadio.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TripleRadio.AutoSize = True
        Me.CmdPanel.SetColumnSpan(Me.TripleRadio, 2)
        Me.TripleRadio.Location = New System.Drawing.Point(143, 45)
        Me.TripleRadio.Margin = New System.Windows.Forms.Padding(0)
        Me.TripleRadio.Name = "TripleRadio"
        Me.TripleRadio.Size = New System.Drawing.Size(97, 21)
        Me.TripleRadio.TabIndex = 6
        Me.TripleRadio.TabStop = True
        Me.TripleRadio.Text = "TripleModel"
        Me.TripleRadio.UseVisualStyleBackColor = True
        '
        'GiveUpButton
        '
        Me.GiveUpButton.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.GiveUpButton.Dock = System.Windows.Forms.DockStyle.Top
        Me.GiveUpButton.Location = New System.Drawing.Point(256, 164)
        Me.GiveUpButton.Margin = New System.Windows.Forms.Padding(0)
        Me.GiveUpButton.Name = "GiveUpButton"
        Me.GiveUpButton.Size = New System.Drawing.Size(64, 25)
        Me.GiveUpButton.TabIndex = 2
        Me.GiveUpButton.Text = "Cancel"
        Me.GiveUpButton.UseVisualStyleBackColor = True
        '
        'SingleRadio
        '
        Me.SingleRadio.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.SingleRadio.AutoSize = True
        Me.CmdPanel.SetColumnSpan(Me.SingleRadio, 2)
        Me.SingleRadio.Location = New System.Drawing.Point(20, 45)
        Me.SingleRadio.Margin = New System.Windows.Forms.Padding(0)
        Me.SingleRadio.Name = "SingleRadio"
        Me.SingleRadio.Size = New System.Drawing.Size(88, 21)
        Me.SingleRadio.TabIndex = 5
        Me.SingleRadio.TabStop = True
        Me.SingleRadio.Text = "SingleStyle"
        Me.SingleRadio.UseVisualStyleBackColor = True
        '
        'GetCodeButton
        '
        Me.GetCodeButton.Dock = System.Windows.Forms.DockStyle.Top
        Me.GetCodeButton.Location = New System.Drawing.Point(64, 164)
        Me.GetCodeButton.Margin = New System.Windows.Forms.Padding(0)
        Me.GetCodeButton.Name = "GetCodeButton"
        Me.GetCodeButton.Size = New System.Drawing.Size(64, 25)
        Me.GetCodeButton.TabIndex = 3
        Me.GetCodeButton.Text = "Code"
        Me.GetCodeButton.UseVisualStyleBackColor = True
        '
        'ShowWordsBox
        '
        Me.CmdPanel.SetColumnSpan(Me.ShowWordsBox, 5)
        Me.ShowWordsBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ShowWordsBox.Location = New System.Drawing.Point(64, 20)
        Me.ShowWordsBox.Margin = New System.Windows.Forms.Padding(0)
        Me.ShowWordsBox.Name = "ShowWordsBox"
        Me.ShowWordsBox.Size = New System.Drawing.Size(321, 23)
        Me.ShowWordsBox.TabIndex = 4
        Me.ShowWordsBox.Text = "Words here"
        '
        'MsgLabel
        '
        Me.MsgLabel.AutoSize = True
        Me.CmdPanel.SetColumnSpan(Me.MsgLabel, 6)
        Me.MsgLabel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MsgLabel.Location = New System.Drawing.Point(3, 0)
        Me.MsgLabel.Name = "MsgLabel"
        Me.MsgLabel.Size = New System.Drawing.Size(379, 20)
        Me.MsgLabel.TabIndex = 0
        Me.MsgLabel.Text = "Label1"
        Me.MsgLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TextLabel
        '
        Me.TextLabel.AutoSize = True
        Me.TextLabel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TextLabel.Location = New System.Drawing.Point(3, 20)
        Me.TextLabel.Name = "TextLabel"
        Me.TextLabel.Size = New System.Drawing.Size(58, 23)
        Me.TextLabel.TabIndex = 8
        Me.TextLabel.Text = "Text:"
        Me.TextLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'SetNorNor
        '
        Me.SetNorNor.BackColor = System.Drawing.Color.LightSkyBlue
        Me.SetNorNor.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SetNorNor.FlatAppearance.BorderColor = System.Drawing.Color.LightSkyBlue
        Me.SetNorNor.FlatAppearance.BorderSize = 0
        Me.SetNorNor.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SetNorNor.Location = New System.Drawing.Point(0, 88)
        Me.SetNorNor.Margin = New System.Windows.Forms.Padding(0)
        Me.SetNorNor.Name = "SetNorNor"
        Me.SetNorNor.Size = New System.Drawing.Size(64, 25)
        Me.SetNorNor.TabIndex = 9
        Me.SetNorNor.Text = "Normal"
        Me.SetNorNor.UseVisualStyleBackColor = False
        '
        'SetNorHov
        '
        Me.SetNorHov.BackColor = System.Drawing.Color.LightSkyBlue
        Me.SetNorHov.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SetNorHov.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.SetNorHov.FlatAppearance.BorderSize = 0
        Me.SetNorHov.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SetNorHov.Location = New System.Drawing.Point(64, 88)
        Me.SetNorHov.Margin = New System.Windows.Forms.Padding(0)
        Me.SetNorHov.Name = "SetNorHov"
        Me.SetNorHov.Size = New System.Drawing.Size(64, 25)
        Me.SetNorHov.TabIndex = 10
        Me.SetNorHov.Text = "Hover"
        Me.SetNorHov.UseVisualStyleBackColor = False
        '
        'SetNorPrs
        '
        Me.SetNorPrs.BackColor = System.Drawing.Color.LightSkyBlue
        Me.SetNorPrs.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SetNorPrs.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.SetNorPrs.FlatAppearance.BorderSize = 0
        Me.SetNorPrs.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SetNorPrs.Location = New System.Drawing.Point(128, 88)
        Me.SetNorPrs.Margin = New System.Windows.Forms.Padding(0)
        Me.SetNorPrs.Name = "SetNorPrs"
        Me.SetNorPrs.Size = New System.Drawing.Size(64, 25)
        Me.SetNorPrs.TabIndex = 11
        Me.SetNorPrs.Text = "Pressed"
        Me.SetNorPrs.UseVisualStyleBackColor = False
        '
        'SetSelNor
        '
        Me.SetSelNor.BackColor = System.Drawing.Color.LightSteelBlue
        Me.SetSelNor.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SetSelNor.FlatAppearance.BorderSize = 0
        Me.SetSelNor.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SetSelNor.Location = New System.Drawing.Point(192, 88)
        Me.SetSelNor.Margin = New System.Windows.Forms.Padding(0)
        Me.SetSelNor.Name = "SetSelNor"
        Me.SetSelNor.Size = New System.Drawing.Size(64, 25)
        Me.SetSelNor.TabIndex = 12
        Me.SetSelNor.Text = "Normal"
        Me.SetSelNor.UseVisualStyleBackColor = False
        '
        'SetSelHov
        '
        Me.SetSelHov.BackColor = System.Drawing.Color.LightSteelBlue
        Me.SetSelHov.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SetSelHov.FlatAppearance.BorderSize = 0
        Me.SetSelHov.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SetSelHov.Location = New System.Drawing.Point(256, 88)
        Me.SetSelHov.Margin = New System.Windows.Forms.Padding(0)
        Me.SetSelHov.Name = "SetSelHov"
        Me.SetSelHov.Size = New System.Drawing.Size(64, 25)
        Me.SetSelHov.TabIndex = 13
        Me.SetSelHov.Text = "Hover"
        Me.SetSelHov.UseVisualStyleBackColor = False
        '
        'SetSelPrs
        '
        Me.SetSelPrs.BackColor = System.Drawing.Color.LightSteelBlue
        Me.SetSelPrs.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SetSelPrs.FlatAppearance.BorderSize = 0
        Me.SetSelPrs.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SetSelPrs.Location = New System.Drawing.Point(320, 88)
        Me.SetSelPrs.Margin = New System.Windows.Forms.Padding(0)
        Me.SetSelPrs.Name = "SetSelPrs"
        Me.SetSelPrs.Size = New System.Drawing.Size(65, 25)
        Me.SetSelPrs.TabIndex = 14
        Me.SetSelPrs.Text = "Pressed"
        Me.SetSelPrs.UseVisualStyleBackColor = False
        '
        'SetNorBtnNor
        '
        Me.SetNorBtnNor.BackColor = System.Drawing.Color.PaleGreen
        Me.SetNorBtnNor.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SetNorBtnNor.FlatAppearance.BorderSize = 0
        Me.SetNorBtnNor.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SetNorBtnNor.Location = New System.Drawing.Point(0, 133)
        Me.SetNorBtnNor.Margin = New System.Windows.Forms.Padding(0)
        Me.SetNorBtnNor.Name = "SetNorBtnNor"
        Me.SetNorBtnNor.Size = New System.Drawing.Size(64, 25)
        Me.SetNorBtnNor.TabIndex = 15
        Me.SetNorBtnNor.Text = "Normal"
        Me.SetNorBtnNor.UseVisualStyleBackColor = False
        '
        'SetNorBtnHov
        '
        Me.SetNorBtnHov.BackColor = System.Drawing.Color.PaleGreen
        Me.SetNorBtnHov.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SetNorBtnHov.FlatAppearance.BorderSize = 0
        Me.SetNorBtnHov.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SetNorBtnHov.Location = New System.Drawing.Point(64, 133)
        Me.SetNorBtnHov.Margin = New System.Windows.Forms.Padding(0)
        Me.SetNorBtnHov.Name = "SetNorBtnHov"
        Me.SetNorBtnHov.Size = New System.Drawing.Size(64, 25)
        Me.SetNorBtnHov.TabIndex = 16
        Me.SetNorBtnHov.Text = "Hover"
        Me.SetNorBtnHov.UseVisualStyleBackColor = False
        '
        'SetNorBtnPrs
        '
        Me.SetNorBtnPrs.BackColor = System.Drawing.Color.PaleGreen
        Me.SetNorBtnPrs.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SetNorBtnPrs.FlatAppearance.BorderSize = 0
        Me.SetNorBtnPrs.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SetNorBtnPrs.Location = New System.Drawing.Point(128, 133)
        Me.SetNorBtnPrs.Margin = New System.Windows.Forms.Padding(0)
        Me.SetNorBtnPrs.Name = "SetNorBtnPrs"
        Me.SetNorBtnPrs.Size = New System.Drawing.Size(64, 25)
        Me.SetNorBtnPrs.TabIndex = 17
        Me.SetNorBtnPrs.Text = "Pressed"
        Me.SetNorBtnPrs.UseVisualStyleBackColor = False
        '
        'SetSelBtnNor
        '
        Me.SetSelBtnNor.BackColor = System.Drawing.Color.LightGreen
        Me.SetSelBtnNor.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SetSelBtnNor.FlatAppearance.BorderSize = 0
        Me.SetSelBtnNor.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SetSelBtnNor.Location = New System.Drawing.Point(192, 133)
        Me.SetSelBtnNor.Margin = New System.Windows.Forms.Padding(0)
        Me.SetSelBtnNor.Name = "SetSelBtnNor"
        Me.SetSelBtnNor.Size = New System.Drawing.Size(64, 25)
        Me.SetSelBtnNor.TabIndex = 18
        Me.SetSelBtnNor.Text = "Normal"
        Me.SetSelBtnNor.UseVisualStyleBackColor = False
        '
        'SetSelBtnHov
        '
        Me.SetSelBtnHov.BackColor = System.Drawing.Color.LightGreen
        Me.SetSelBtnHov.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SetSelBtnHov.FlatAppearance.BorderSize = 0
        Me.SetSelBtnHov.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SetSelBtnHov.Location = New System.Drawing.Point(256, 133)
        Me.SetSelBtnHov.Margin = New System.Windows.Forms.Padding(0)
        Me.SetSelBtnHov.Name = "SetSelBtnHov"
        Me.SetSelBtnHov.Size = New System.Drawing.Size(64, 25)
        Me.SetSelBtnHov.TabIndex = 19
        Me.SetSelBtnHov.Text = "Hover"
        Me.SetSelBtnHov.UseVisualStyleBackColor = False
        '
        'SetSelBtnPrs
        '
        Me.SetSelBtnPrs.BackColor = System.Drawing.Color.LightGreen
        Me.SetSelBtnPrs.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SetSelBtnPrs.FlatAppearance.BorderSize = 0
        Me.SetSelBtnPrs.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SetSelBtnPrs.Location = New System.Drawing.Point(320, 133)
        Me.SetSelBtnPrs.Margin = New System.Windows.Forms.Padding(0)
        Me.SetSelBtnPrs.Name = "SetSelBtnPrs"
        Me.SetSelBtnPrs.Size = New System.Drawing.Size(65, 25)
        Me.SetSelBtnPrs.TabIndex = 20
        Me.SetSelBtnPrs.Text = "Pressed"
        Me.SetSelBtnPrs.UseVisualStyleBackColor = False
        '
        'NorTab
        '
        Me.NorTab.AutoSize = True
        Me.NorTab.BackColor = System.Drawing.Color.LightSkyBlue
        Me.CmdPanel.SetColumnSpan(Me.NorTab, 3)
        Me.NorTab.Dock = System.Windows.Forms.DockStyle.Fill
        Me.NorTab.Location = New System.Drawing.Point(0, 68)
        Me.NorTab.Margin = New System.Windows.Forms.Padding(0)
        Me.NorTab.Name = "NorTab"
        Me.NorTab.Size = New System.Drawing.Size(192, 20)
        Me.NorTab.TabIndex = 21
        Me.NorTab.Text = "Normal Tab"
        Me.NorTab.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'SelTab
        '
        Me.SelTab.AutoSize = True
        Me.SelTab.BackColor = System.Drawing.Color.LightSteelBlue
        Me.CmdPanel.SetColumnSpan(Me.SelTab, 3)
        Me.SelTab.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SelTab.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SelTab.Location = New System.Drawing.Point(192, 68)
        Me.SelTab.Margin = New System.Windows.Forms.Padding(0)
        Me.SelTab.Name = "SelTab"
        Me.SelTab.Size = New System.Drawing.Size(193, 20)
        Me.SelTab.TabIndex = 22
        Me.SelTab.Text = "Selected Tab"
        Me.SelTab.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'NorBtn
        '
        Me.NorBtn.AutoSize = True
        Me.NorBtn.BackColor = System.Drawing.Color.PaleGreen
        Me.CmdPanel.SetColumnSpan(Me.NorBtn, 3)
        Me.NorBtn.Dock = System.Windows.Forms.DockStyle.Fill
        Me.NorBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.NorBtn.Location = New System.Drawing.Point(0, 113)
        Me.NorBtn.Margin = New System.Windows.Forms.Padding(0)
        Me.NorBtn.Name = "NorBtn"
        Me.NorBtn.Size = New System.Drawing.Size(192, 20)
        Me.NorBtn.TabIndex = 23
        Me.NorBtn.Text = "Normal Btn"
        Me.NorBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'SelBtn
        '
        Me.SelBtn.AutoSize = True
        Me.SelBtn.BackColor = System.Drawing.Color.LightGreen
        Me.CmdPanel.SetColumnSpan(Me.SelBtn, 3)
        Me.SelBtn.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SelBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SelBtn.Location = New System.Drawing.Point(192, 113)
        Me.SelBtn.Margin = New System.Windows.Forms.Padding(0)
        Me.SelBtn.Name = "SelBtn"
        Me.SelBtn.Size = New System.Drawing.Size(193, 20)
        Me.SelBtn.TabIndex = 24
        Me.SelBtn.Text = "Sellected Btn"
        Me.SelBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'StylesForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(747, 493)
        Me.Controls.Add(Me.RootSpliter)
        Me.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "StylesForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "KzStyleForm"
        Me.RootSpliter.Panel1.ResumeLayout(False)
        Me.RootSpliter.Panel2.ResumeLayout(False)
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
        Me.BottomSpliter.Panel2.ResumeLayout(False)
        CType(Me.BottomSpliter, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BottomSpliter.ResumeLayout(False)
        Me.CmdPanel.ResumeLayout(False)
        Me.CmdPanel.PerformLayout()
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
    Friend WithEvents RadiusUD As NumericUpDown
    Friend WithEvents LineWidthUD As NumericUpDown
    Friend WithEvents LineColorBox As TextBox
    Friend WithEvents FillColorBox As TextBox
    Friend WithEvents ShadowWidthUD As NumericUpDown
    Friend WithEvents ShadowColorBox As TextBox
    Friend WithEvents FontColorBox As TextBox
    Friend WithEvents FontSizeCBox As ComboBox
    Friend WithEvents FontNameBox As TextBox
    Friend WithEvents BottomSpliter As SplitContainer
    Friend WithEvents MsgLabel As Label
    Friend WithEvents GiveUpButton As Button
    Friend WithEvents LetsGoButton As Button
    Friend WithEvents CmdPanel As TableLayoutPanel
    Friend WithEvents ShowWordsBox As TextBox
    Friend WithEvents FontStyleCBox As ComboBox
    Friend WithEvents GetCodeButton As Button
    Friend WithEvents InnerColorBox As TextBox
    Friend WithEvents TabRadio As RadioButton
    Friend WithEvents TripleRadio As RadioButton
    Friend WithEvents SingleRadio As RadioButton
    Friend WithEvents TextLabel As Label
    Friend WithEvents NameBox As TextBox
    Friend WithEvents SetNorNor As Button
    Friend WithEvents SetNorHov As Button
    Friend WithEvents SetNorPrs As Button
    Friend WithEvents SetSelNor As Button
    Friend WithEvents SetSelHov As Button
    Friend WithEvents SetSelPrs As Button
    Friend WithEvents SetNorBtnNor As Button
    Friend WithEvents SetNorBtnHov As Button
    Friend WithEvents SetNorBtnPrs As Button
    Friend WithEvents SetSelBtnNor As Button
    Friend WithEvents SetSelBtnHov As Button
    Friend WithEvents SetSelBtnPrs As Button
    Friend WithEvents NorTab As Label
    Friend WithEvents SelTab As Label
    Friend WithEvents NorBtn As Label
    Friend WithEvents SelBtn As Label
End Class
