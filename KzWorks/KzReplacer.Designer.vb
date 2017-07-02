<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class KzReplacer
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(KzReplacer))
        Me.RootSplitContainer = New System.Windows.Forms.SplitContainer()
        Me.TopSplitContainer = New System.Windows.Forms.SplitContainer()
        Me.SelectGroup = New System.Windows.Forms.GroupBox()
        Me.SelectPanel = New System.Windows.Forms.TableLayoutPanel()
        Me.FromButton = New System.Windows.Forms.Button()
        Me.ResetButton = New System.Windows.Forms.Button()
        Me.ToButton = New System.Windows.Forms.Button()
        Me.ToTextBox = New System.Windows.Forms.TextBox()
        Me.FromTextBox = New System.Windows.Forms.TextBox()
        Me.GoFromButton = New System.Windows.Forms.Button()
        Me.SelectButton = New System.Windows.Forms.Button()
        Me.GoToButton = New System.Windows.Forms.Button()
        Me.ReplaceGroupBox = New System.Windows.Forms.GroupBox()
        Me.Replacer = New System.Windows.Forms.TextBox()
        Me.FindGroupBox = New System.Windows.Forms.GroupBox()
        Me.Finder = New System.Windows.Forms.TextBox()
        Me.EffectedGroup = New System.Windows.Forms.GroupBox()
        Me.RangeLabel = New System.Windows.Forms.Label()
        Me.OptionsGroup = New System.Windows.Forms.GroupBox()
        Me.OptionsCheckedList = New System.Windows.Forms.CheckedListBox()
        Me.rdbMoveNone = New System.Windows.Forms.RadioButton()
        Me.rdbSelectedAll = New System.Windows.Forms.RadioButton()
        Me.rdbMovePrevious = New System.Windows.Forms.RadioButton()
        Me.rdbPreviousAll = New System.Windows.Forms.RadioButton()
        Me.rdbMoveNext = New System.Windows.Forms.RadioButton()
        Me.rdbNextAll = New System.Windows.Forms.RadioButton()
        Me.CommandsGroup = New System.Windows.Forms.GroupBox()
        Me.CommandsPanel = New System.Windows.Forms.TableLayoutPanel()
        Me.ReplaceButton = New System.Windows.Forms.Button()
        Me.AllCheckBox = New System.Windows.Forms.CheckBox()
        Me.RoundCheckBox = New System.Windows.Forms.CheckBox()
        Me.FirstButton = New System.Windows.Forms.Button()
        Me.PreviousButton = New System.Windows.Forms.Button()
        Me.ResaultListButton = New System.Windows.Forms.Button()
        Me.NextButton = New System.Windows.Forms.Button()
        Me.LastButton = New System.Windows.Forms.Button()
        Me.ReplacerToolStrip = New System.Windows.Forms.ToolStrip()
        Me.ObjectButton = New System.Windows.Forms.ToolStripButton()
        Me.RegexStatusStrip = New System.Windows.Forms.StatusStrip()
        Me.StateInfoItem = New System.Windows.Forms.ToolStripStatusLabel()
        Me.FoundInfoItem = New System.Windows.Forms.ToolStripStatusLabel()
        Me.FoundInSelInfoItem = New System.Windows.Forms.ToolStripStatusLabel()
        Me.IndexInfoItem = New System.Windows.Forms.ToolStripStatusLabel()
        Me.OptionsInfoItem = New System.Windows.Forms.ToolStripStatusLabel()
        Me.SpanInfoItem = New System.Windows.Forms.ToolStripStatusLabel()
        Me.RepKzTabControl = New KzWorks.KzLibrary.KzTabControl()
        Me.ListTab = New System.Windows.Forms.TabPage()
        Me.ResaultListView = New System.Windows.Forms.ListView()
        Me.resIndex = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.resOriginWord = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.resOriginIndex = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.resOriginLength = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.resPreWords = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.resPostWords = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.resReplacement = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.RecorderTab = New System.Windows.Forms.TabPage()
        Me.CmdRecorder = New System.Windows.Forms.TextBox()
        Me.ProjectTab = New System.Windows.Forms.TabPage()
        Me.ProjectListView = New System.Windows.Forms.ListView()
        Me.regID = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.regReplaceMode = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.regSubject = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.regFindParttern = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.regReplaceParttern = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.regRemarks = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ListStatusStrip = New System.Windows.Forms.StatusStrip()
        Me.IDListItem = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ResaultListItem = New System.Windows.Forms.ToolStripDropDownButton()
        Me.TryReplaceListItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClearResaultsListItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReplacerToolTip = New System.Windows.Forms.ToolTip(Me.components)
        CType(Me.RootSplitContainer, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RootSplitContainer.Panel1.SuspendLayout()
        Me.RootSplitContainer.Panel2.SuspendLayout()
        Me.RootSplitContainer.SuspendLayout()
        CType(Me.TopSplitContainer, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TopSplitContainer.Panel1.SuspendLayout()
        Me.TopSplitContainer.Panel2.SuspendLayout()
        Me.TopSplitContainer.SuspendLayout()
        Me.SelectGroup.SuspendLayout()
        Me.SelectPanel.SuspendLayout()
        Me.ReplaceGroupBox.SuspendLayout()
        Me.FindGroupBox.SuspendLayout()
        Me.EffectedGroup.SuspendLayout()
        Me.OptionsGroup.SuspendLayout()
        Me.CommandsGroup.SuspendLayout()
        Me.CommandsPanel.SuspendLayout()
        Me.ReplacerToolStrip.SuspendLayout()
        Me.RegexStatusStrip.SuspendLayout()
        Me.RepKzTabControl.SuspendLayout()
        Me.ListTab.SuspendLayout()
        Me.RecorderTab.SuspendLayout()
        Me.ProjectTab.SuspendLayout()
        Me.ListStatusStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'RootSplitContainer
        '
        Me.RootSplitContainer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.RootSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RootSplitContainer.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
        Me.RootSplitContainer.Location = New System.Drawing.Point(0, 0)
        Me.RootSplitContainer.Name = "RootSplitContainer"
        Me.RootSplitContainer.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'RootSplitContainer.Panel1
        '
        Me.RootSplitContainer.Panel1.Controls.Add(Me.TopSplitContainer)
        Me.RootSplitContainer.Panel1.Controls.Add(Me.ReplacerToolStrip)
        Me.RootSplitContainer.Panel1.Controls.Add(Me.RegexStatusStrip)
        Me.RootSplitContainer.Panel1MinSize = 226
        '
        'RootSplitContainer.Panel2
        '
        Me.RootSplitContainer.Panel2.Controls.Add(Me.RepKzTabControl)
        Me.RootSplitContainer.Panel2.Controls.Add(Me.ListStatusStrip)
        Me.RootSplitContainer.Size = New System.Drawing.Size(453, 579)
        Me.RootSplitContainer.SplitterDistance = 280
        Me.RootSplitContainer.TabIndex = 0
        '
        'TopSplitContainer
        '
        Me.TopSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TopSplitContainer.Location = New System.Drawing.Point(0, 25)
        Me.TopSplitContainer.Name = "TopSplitContainer"
        '
        'TopSplitContainer.Panel1
        '
        Me.TopSplitContainer.Panel1.Controls.Add(Me.SelectGroup)
        Me.TopSplitContainer.Panel1.Controls.Add(Me.ReplaceGroupBox)
        Me.TopSplitContainer.Panel1.Controls.Add(Me.FindGroupBox)
        Me.TopSplitContainer.Panel1.Controls.Add(Me.EffectedGroup)
        Me.TopSplitContainer.Panel1MinSize = 195
        '
        'TopSplitContainer.Panel2
        '
        Me.TopSplitContainer.Panel2.Controls.Add(Me.OptionsGroup)
        Me.TopSplitContainer.Panel2.Controls.Add(Me.CommandsGroup)
        Me.TopSplitContainer.Size = New System.Drawing.Size(451, 231)
        Me.TopSplitContainer.SplitterDistance = 195
        Me.TopSplitContainer.TabIndex = 0
        '
        'SelectGroup
        '
        Me.SelectGroup.Controls.Add(Me.SelectPanel)
        Me.SelectGroup.Dock = System.Windows.Forms.DockStyle.Top
        Me.SelectGroup.Location = New System.Drawing.Point(0, 160)
        Me.SelectGroup.Name = "SelectGroup"
        Me.SelectGroup.Size = New System.Drawing.Size(195, 65)
        Me.SelectGroup.TabIndex = 3
        Me.SelectGroup.TabStop = False
        Me.SelectGroup.Text = "擴選"
        '
        'SelectPanel
        '
        Me.SelectPanel.ColumnCount = 4
        Me.SelectPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 45.0!))
        Me.SelectPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.SelectPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
        Me.SelectPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.SelectPanel.Controls.Add(Me.FromButton, 0, 0)
        Me.SelectPanel.Controls.Add(Me.ResetButton, 3, 0)
        Me.SelectPanel.Controls.Add(Me.ToButton, 0, 1)
        Me.SelectPanel.Controls.Add(Me.ToTextBox, 1, 1)
        Me.SelectPanel.Controls.Add(Me.FromTextBox, 1, 0)
        Me.SelectPanel.Controls.Add(Me.GoFromButton, 2, 0)
        Me.SelectPanel.Controls.Add(Me.SelectButton, 3, 1)
        Me.SelectPanel.Controls.Add(Me.GoToButton, 2, 1)
        Me.SelectPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SelectPanel.Location = New System.Drawing.Point(3, 17)
        Me.SelectPanel.Name = "SelectPanel"
        Me.SelectPanel.RowCount = 2
        Me.SelectPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.SelectPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.SelectPanel.Size = New System.Drawing.Size(189, 45)
        Me.SelectPanel.TabIndex = 8
        '
        'FromButton
        '
        Me.FromButton.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FromButton.Location = New System.Drawing.Point(0, 0)
        Me.FromButton.Margin = New System.Windows.Forms.Padding(0)
        Me.FromButton.Name = "FromButton"
        Me.FromButton.Size = New System.Drawing.Size(45, 22)
        Me.FromButton.TabIndex = 1
        Me.FromButton.Text = "起始"
        Me.FromButton.UseVisualStyleBackColor = True
        '
        'ResetButton
        '
        Me.ResetButton.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ResetButton.Location = New System.Drawing.Point(129, 0)
        Me.ResetButton.Margin = New System.Windows.Forms.Padding(0)
        Me.ResetButton.Name = "ResetButton"
        Me.ResetButton.Size = New System.Drawing.Size(60, 22)
        Me.ResetButton.TabIndex = 7
        Me.ResetButton.Text = "復位"
        Me.ResetButton.UseVisualStyleBackColor = True
        '
        'ToButton
        '
        Me.ToButton.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ToButton.Location = New System.Drawing.Point(0, 22)
        Me.ToButton.Margin = New System.Windows.Forms.Padding(0)
        Me.ToButton.Name = "ToButton"
        Me.ToButton.Size = New System.Drawing.Size(45, 23)
        Me.ToButton.TabIndex = 2
        Me.ToButton.Text = "結束"
        Me.ToButton.UseVisualStyleBackColor = True
        '
        'ToTextBox
        '
        Me.ToTextBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ToTextBox.Location = New System.Drawing.Point(46, 23)
        Me.ToTextBox.Margin = New System.Windows.Forms.Padding(1)
        Me.ToTextBox.Name = "ToTextBox"
        Me.ToTextBox.Size = New System.Drawing.Size(57, 21)
        Me.ToTextBox.TabIndex = 5
        Me.ToTextBox.Text = "0"
        Me.ToTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'FromTextBox
        '
        Me.FromTextBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FromTextBox.Location = New System.Drawing.Point(46, 1)
        Me.FromTextBox.Margin = New System.Windows.Forms.Padding(1)
        Me.FromTextBox.Name = "FromTextBox"
        Me.FromTextBox.Size = New System.Drawing.Size(57, 21)
        Me.FromTextBox.TabIndex = 3
        Me.FromTextBox.Text = "0"
        Me.FromTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GoFromButton
        '
        Me.GoFromButton.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GoFromButton.Location = New System.Drawing.Point(104, 0)
        Me.GoFromButton.Margin = New System.Windows.Forms.Padding(0)
        Me.GoFromButton.Name = "GoFromButton"
        Me.GoFromButton.Size = New System.Drawing.Size(25, 22)
        Me.GoFromButton.TabIndex = 8
        Me.GoFromButton.Text = ">"
        Me.GoFromButton.UseVisualStyleBackColor = True
        '
        'SelectButton
        '
        Me.SelectButton.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SelectButton.Location = New System.Drawing.Point(129, 22)
        Me.SelectButton.Margin = New System.Windows.Forms.Padding(0)
        Me.SelectButton.Name = "SelectButton"
        Me.SelectButton.Size = New System.Drawing.Size(60, 23)
        Me.SelectButton.TabIndex = 9
        Me.SelectButton.Text = "選取"
        Me.SelectButton.UseVisualStyleBackColor = True
        '
        'GoToButton
        '
        Me.GoToButton.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GoToButton.Location = New System.Drawing.Point(104, 22)
        Me.GoToButton.Margin = New System.Windows.Forms.Padding(0)
        Me.GoToButton.Name = "GoToButton"
        Me.GoToButton.Size = New System.Drawing.Size(25, 23)
        Me.GoToButton.TabIndex = 10
        Me.GoToButton.Text = ">"
        Me.GoToButton.UseVisualStyleBackColor = True
        '
        'ReplaceGroupBox
        '
        Me.ReplaceGroupBox.Controls.Add(Me.Replacer)
        Me.ReplaceGroupBox.Dock = System.Windows.Forms.DockStyle.Top
        Me.ReplaceGroupBox.Location = New System.Drawing.Point(0, 100)
        Me.ReplaceGroupBox.Name = "ReplaceGroupBox"
        Me.ReplaceGroupBox.Size = New System.Drawing.Size(195, 60)
        Me.ReplaceGroupBox.TabIndex = 0
        Me.ReplaceGroupBox.TabStop = False
        Me.ReplaceGroupBox.Text = "替換式"
        '
        'Replacer
        '
        Me.Replacer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Replacer.HideSelection = False
        Me.Replacer.Location = New System.Drawing.Point(3, 17)
        Me.Replacer.Multiline = True
        Me.Replacer.Name = "Replacer"
        Me.Replacer.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.Replacer.Size = New System.Drawing.Size(189, 40)
        Me.Replacer.TabIndex = 1
        '
        'FindGroupBox
        '
        Me.FindGroupBox.Controls.Add(Me.Finder)
        Me.FindGroupBox.Dock = System.Windows.Forms.DockStyle.Top
        Me.FindGroupBox.Location = New System.Drawing.Point(0, 40)
        Me.FindGroupBox.Name = "FindGroupBox"
        Me.FindGroupBox.Size = New System.Drawing.Size(195, 60)
        Me.FindGroupBox.TabIndex = 0
        Me.FindGroupBox.TabStop = False
        Me.FindGroupBox.Text = "查找式"
        '
        'Finder
        '
        Me.Finder.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Finder.HideSelection = False
        Me.Finder.Location = New System.Drawing.Point(3, 17)
        Me.Finder.Multiline = True
        Me.Finder.Name = "Finder"
        Me.Finder.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.Finder.Size = New System.Drawing.Size(189, 40)
        Me.Finder.TabIndex = 0
        '
        'EffectedGroup
        '
        Me.EffectedGroup.Controls.Add(Me.RangeLabel)
        Me.EffectedGroup.Dock = System.Windows.Forms.DockStyle.Top
        Me.EffectedGroup.Location = New System.Drawing.Point(0, 0)
        Me.EffectedGroup.Name = "EffectedGroup"
        Me.EffectedGroup.Size = New System.Drawing.Size(195, 40)
        Me.EffectedGroup.TabIndex = 31
        Me.EffectedGroup.TabStop = False
        Me.EffectedGroup.Text = "範圍"
        '
        'RangeLabel
        '
        Me.RangeLabel.AutoSize = True
        Me.RangeLabel.Location = New System.Drawing.Point(32, 19)
        Me.RangeLabel.Name = "RangeLabel"
        Me.RangeLabel.Size = New System.Drawing.Size(41, 12)
        Me.RangeLabel.TabIndex = 0
        Me.RangeLabel.Text = "Label1"
        '
        'OptionsGroup
        '
        Me.OptionsGroup.Controls.Add(Me.OptionsCheckedList)
        Me.OptionsGroup.Controls.Add(Me.rdbMoveNone)
        Me.OptionsGroup.Controls.Add(Me.rdbSelectedAll)
        Me.OptionsGroup.Controls.Add(Me.rdbMovePrevious)
        Me.OptionsGroup.Controls.Add(Me.rdbPreviousAll)
        Me.OptionsGroup.Controls.Add(Me.rdbMoveNext)
        Me.OptionsGroup.Controls.Add(Me.rdbNextAll)
        Me.OptionsGroup.Dock = System.Windows.Forms.DockStyle.Top
        Me.OptionsGroup.Location = New System.Drawing.Point(0, 105)
        Me.OptionsGroup.Margin = New System.Windows.Forms.Padding(3, 8, 3, 3)
        Me.OptionsGroup.Name = "OptionsGroup"
        Me.OptionsGroup.Size = New System.Drawing.Size(252, 120)
        Me.OptionsGroup.TabIndex = 30
        Me.OptionsGroup.TabStop = False
        Me.OptionsGroup.Text = "選項"
        '
        'OptionsCheckedList
        '
        Me.OptionsCheckedList.CheckOnClick = True
        Me.OptionsCheckedList.FormattingEnabled = True
        Me.OptionsCheckedList.Items.AddRange(New Object() {"忽略大小寫", "忽略空格", "多行模式", "單線模式", "僅顯式捕獲", "地域化比較", "已編譯", "從右向左", "ECMA腳本匹配", "區分全半角"})
        Me.OptionsCheckedList.Location = New System.Drawing.Point(135, 18)
        Me.OptionsCheckedList.Name = "OptionsCheckedList"
        Me.OptionsCheckedList.Size = New System.Drawing.Size(112, 100)
        Me.OptionsCheckedList.TabIndex = 30
        '
        'rdbMoveNone
        '
        Me.rdbMoveNone.AutoSize = True
        Me.rdbMoveNone.Location = New System.Drawing.Point(10, 52)
        Me.rdbMoveNone.Name = "rdbMoveNone"
        Me.rdbMoveNone.Size = New System.Drawing.Size(107, 16)
        Me.rdbMoveNone.TabIndex = 24
        Me.rdbMoveNone.TabStop = True
        Me.rdbMoveNone.Text = "替換後停留原位"
        Me.rdbMoveNone.UseVisualStyleBackColor = True
        '
        'rdbSelectedAll
        '
        Me.rdbSelectedAll.AutoSize = True
        Me.rdbSelectedAll.Location = New System.Drawing.Point(10, 103)
        Me.rdbSelectedAll.Name = "rdbSelectedAll"
        Me.rdbSelectedAll.Size = New System.Drawing.Size(119, 16)
        Me.rdbSelectedAll.TabIndex = 27
        Me.rdbSelectedAll.TabStop = True
        Me.rdbSelectedAll.Text = "選中範圍替換全部"
        Me.rdbSelectedAll.UseVisualStyleBackColor = True
        '
        'rdbMovePrevious
        '
        Me.rdbMovePrevious.AutoSize = True
        Me.rdbMovePrevious.Location = New System.Drawing.Point(10, 35)
        Me.rdbMovePrevious.Name = "rdbMovePrevious"
        Me.rdbMovePrevious.Size = New System.Drawing.Size(107, 16)
        Me.rdbMovePrevious.TabIndex = 23
        Me.rdbMovePrevious.TabStop = True
        Me.rdbMovePrevious.Text = "替換後移至前筆"
        Me.rdbMovePrevious.UseVisualStyleBackColor = True
        '
        'rdbPreviousAll
        '
        Me.rdbPreviousAll.AutoSize = True
        Me.rdbPreviousAll.Location = New System.Drawing.Point(10, 86)
        Me.rdbPreviousAll.Name = "rdbPreviousAll"
        Me.rdbPreviousAll.Size = New System.Drawing.Size(95, 16)
        Me.rdbPreviousAll.TabIndex = 26
        Me.rdbPreviousAll.TabStop = True
        Me.rdbPreviousAll.Text = "向前替換全部"
        Me.rdbPreviousAll.UseVisualStyleBackColor = True
        '
        'rdbMoveNext
        '
        Me.rdbMoveNext.AutoSize = True
        Me.rdbMoveNext.Location = New System.Drawing.Point(10, 18)
        Me.rdbMoveNext.Name = "rdbMoveNext"
        Me.rdbMoveNext.Size = New System.Drawing.Size(107, 16)
        Me.rdbMoveNext.TabIndex = 22
        Me.rdbMoveNext.TabStop = True
        Me.rdbMoveNext.Text = "替換後移至次筆"
        Me.rdbMoveNext.UseVisualStyleBackColor = True
        '
        'rdbNextAll
        '
        Me.rdbNextAll.AutoSize = True
        Me.rdbNextAll.Location = New System.Drawing.Point(10, 69)
        Me.rdbNextAll.Name = "rdbNextAll"
        Me.rdbNextAll.Size = New System.Drawing.Size(95, 16)
        Me.rdbNextAll.TabIndex = 25
        Me.rdbNextAll.TabStop = True
        Me.rdbNextAll.Text = "向後替換全部"
        Me.rdbNextAll.UseVisualStyleBackColor = True
        '
        'CommandsGroup
        '
        Me.CommandsGroup.Controls.Add(Me.CommandsPanel)
        Me.CommandsGroup.Dock = System.Windows.Forms.DockStyle.Top
        Me.CommandsGroup.Location = New System.Drawing.Point(0, 0)
        Me.CommandsGroup.Name = "CommandsGroup"
        Me.CommandsGroup.Size = New System.Drawing.Size(252, 105)
        Me.CommandsGroup.TabIndex = 31
        Me.CommandsGroup.TabStop = False
        Me.CommandsGroup.Text = "指令"
        '
        'CommandsPanel
        '
        Me.CommandsPanel.ColumnCount = 4
        Me.CommandsPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.CommandsPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.CommandsPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.CommandsPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.CommandsPanel.Controls.Add(Me.ReplaceButton, 2, 2)
        Me.CommandsPanel.Controls.Add(Me.AllCheckBox, 2, 3)
        Me.CommandsPanel.Controls.Add(Me.RoundCheckBox, 0, 3)
        Me.CommandsPanel.Controls.Add(Me.FirstButton, 0, 0)
        Me.CommandsPanel.Controls.Add(Me.PreviousButton, 1, 0)
        Me.CommandsPanel.Controls.Add(Me.ResaultListButton, 0, 2)
        Me.CommandsPanel.Controls.Add(Me.NextButton, 2, 0)
        Me.CommandsPanel.Controls.Add(Me.LastButton, 3, 0)
        Me.CommandsPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CommandsPanel.Location = New System.Drawing.Point(3, 17)
        Me.CommandsPanel.Name = "CommandsPanel"
        Me.CommandsPanel.RowCount = 4
        Me.CommandsPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27.0!))
        Me.CommandsPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 5.0!))
        Me.CommandsPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27.0!))
        Me.CommandsPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 22.0!))
        Me.CommandsPanel.Size = New System.Drawing.Size(246, 85)
        Me.CommandsPanel.TabIndex = 0
        '
        'ReplaceButton
        '
        Me.CommandsPanel.SetColumnSpan(Me.ReplaceButton, 2)
        Me.ReplaceButton.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ReplaceButton.Location = New System.Drawing.Point(122, 32)
        Me.ReplaceButton.Margin = New System.Windows.Forms.Padding(0)
        Me.ReplaceButton.Name = "ReplaceButton"
        Me.ReplaceButton.Size = New System.Drawing.Size(124, 27)
        Me.ReplaceButton.TabIndex = 23
        Me.ReplaceButton.Text = "執行替換"
        Me.ReplaceButton.UseVisualStyleBackColor = True
        '
        'AllCheckBox
        '
        Me.AllCheckBox.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.AllCheckBox.AutoSize = True
        Me.CommandsPanel.SetColumnSpan(Me.AllCheckBox, 2)
        Me.AllCheckBox.Location = New System.Drawing.Point(149, 65)
        Me.AllCheckBox.Margin = New System.Windows.Forms.Padding(6, 6, 3, 3)
        Me.AllCheckBox.Name = "AllCheckBox"
        Me.AllCheckBox.Size = New System.Drawing.Size(72, 16)
        Me.AllCheckBox.TabIndex = 22
        Me.AllCheckBox.Text = "全部替換"
        Me.AllCheckBox.UseVisualStyleBackColor = True
        '
        'RoundCheckBox
        '
        Me.RoundCheckBox.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.RoundCheckBox.AutoSize = True
        Me.CommandsPanel.SetColumnSpan(Me.RoundCheckBox, 2)
        Me.RoundCheckBox.Location = New System.Drawing.Point(26, 65)
        Me.RoundCheckBox.Margin = New System.Windows.Forms.Padding(6, 6, 3, 3)
        Me.RoundCheckBox.Name = "RoundCheckBox"
        Me.RoundCheckBox.Size = New System.Drawing.Size(72, 16)
        Me.RoundCheckBox.TabIndex = 21
        Me.RoundCheckBox.Text = "循環移動"
        Me.RoundCheckBox.UseVisualStyleBackColor = True
        '
        'FirstButton
        '
        Me.FirstButton.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FirstButton.Location = New System.Drawing.Point(0, 0)
        Me.FirstButton.Margin = New System.Windows.Forms.Padding(0)
        Me.FirstButton.Name = "FirstButton"
        Me.FirstButton.Size = New System.Drawing.Size(61, 27)
        Me.FirstButton.TabIndex = 0
        Me.FirstButton.Text = "首筆"
        Me.FirstButton.UseVisualStyleBackColor = True
        '
        'PreviousButton
        '
        Me.PreviousButton.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PreviousButton.Location = New System.Drawing.Point(61, 0)
        Me.PreviousButton.Margin = New System.Windows.Forms.Padding(0)
        Me.PreviousButton.Name = "PreviousButton"
        Me.PreviousButton.Size = New System.Drawing.Size(61, 27)
        Me.PreviousButton.TabIndex = 1
        Me.PreviousButton.Text = "前筆"
        Me.PreviousButton.UseVisualStyleBackColor = True
        '
        'ResaultListButton
        '
        Me.ResaultListButton.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.CommandsPanel.SetColumnSpan(Me.ResaultListButton, 2)
        Me.ResaultListButton.Location = New System.Drawing.Point(28, 33)
        Me.ResaultListButton.Margin = New System.Windows.Forms.Padding(0)
        Me.ResaultListButton.Name = "ResaultListButton"
        Me.ResaultListButton.Size = New System.Drawing.Size(65, 25)
        Me.ResaultListButton.TabIndex = 4
        Me.ResaultListButton.Text = "列出結果"
        Me.ResaultListButton.UseVisualStyleBackColor = True
        '
        'NextButton
        '
        Me.NextButton.Dock = System.Windows.Forms.DockStyle.Fill
        Me.NextButton.Location = New System.Drawing.Point(122, 0)
        Me.NextButton.Margin = New System.Windows.Forms.Padding(0)
        Me.NextButton.Name = "NextButton"
        Me.NextButton.Size = New System.Drawing.Size(61, 27)
        Me.NextButton.TabIndex = 2
        Me.NextButton.Text = "次筆"
        Me.NextButton.UseVisualStyleBackColor = True
        '
        'LastButton
        '
        Me.LastButton.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LastButton.Location = New System.Drawing.Point(183, 0)
        Me.LastButton.Margin = New System.Windows.Forms.Padding(0)
        Me.LastButton.Name = "LastButton"
        Me.LastButton.Size = New System.Drawing.Size(63, 27)
        Me.LastButton.TabIndex = 3
        Me.LastButton.Text = "末筆"
        Me.LastButton.UseVisualStyleBackColor = True
        '
        'ReplacerToolStrip
        '
        Me.ReplacerToolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ReplacerToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ObjectButton})
        Me.ReplacerToolStrip.Location = New System.Drawing.Point(0, 0)
        Me.ReplacerToolStrip.Name = "ReplacerToolStrip"
        Me.ReplacerToolStrip.Size = New System.Drawing.Size(451, 25)
        Me.ReplacerToolStrip.TabIndex = 3
        Me.ReplacerToolStrip.Text = "ToolStrip1"
        '
        'ObjectButton
        '
        Me.ObjectButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ObjectButton.Image = CType(resources.GetObject("ObjectButton.Image"), System.Drawing.Image)
        Me.ObjectButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ObjectButton.Name = "ObjectButton"
        Me.ObjectButton.Size = New System.Drawing.Size(23, 22)
        Me.ObjectButton.Text = "ToolStripButton1"
        '
        'RegexStatusStrip
        '
        Me.RegexStatusStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.StateInfoItem, Me.FoundInfoItem, Me.FoundInSelInfoItem, Me.IndexInfoItem, Me.OptionsInfoItem, Me.SpanInfoItem})
        Me.RegexStatusStrip.Location = New System.Drawing.Point(0, 256)
        Me.RegexStatusStrip.Name = "RegexStatusStrip"
        Me.RegexStatusStrip.Size = New System.Drawing.Size(451, 22)
        Me.RegexStatusStrip.TabIndex = 2
        Me.RegexStatusStrip.Text = "StatusStrip1"
        '
        'StateInfoItem
        '
        Me.StateInfoItem.Name = "StateInfoItem"
        Me.StateInfoItem.Size = New System.Drawing.Size(32, 17)
        Me.StateInfoItem.Text = "狀態"
        '
        'FoundInfoItem
        '
        Me.FoundInfoItem.Name = "FoundInfoItem"
        Me.FoundInfoItem.Size = New System.Drawing.Size(32, 17)
        Me.FoundInfoItem.Text = "發現"
        '
        'FoundInSelInfoItem
        '
        Me.FoundInSelInfoItem.Name = "FoundInSelInfoItem"
        Me.FoundInSelInfoItem.Size = New System.Drawing.Size(32, 17)
        Me.FoundInSelInfoItem.Text = "選擇"
        '
        'IndexInfoItem
        '
        Me.IndexInfoItem.Name = "IndexInfoItem"
        Me.IndexInfoItem.Size = New System.Drawing.Size(32, 17)
        Me.IndexInfoItem.Text = "索引"
        '
        'OptionsInfoItem
        '
        Me.OptionsInfoItem.Name = "OptionsInfoItem"
        Me.OptionsInfoItem.Size = New System.Drawing.Size(32, 17)
        Me.OptionsInfoItem.Text = "選項"
        '
        'SpanInfoItem
        '
        Me.SpanInfoItem.Name = "SpanInfoItem"
        Me.SpanInfoItem.Size = New System.Drawing.Size(32, 17)
        Me.SpanInfoItem.Text = "需時"
        '
        'RepKzTabControl
        '
        Me.RepKzTabControl.BackgroundColor = System.Drawing.SystemColors.Control
        Me.RepKzTabControl.Controls.Add(Me.ListTab)
        Me.RepKzTabControl.Controls.Add(Me.RecorderTab)
        Me.RepKzTabControl.Controls.Add(Me.ProjectTab)
        Me.RepKzTabControl.DoAutoTabWidth = True
        Me.RepKzTabControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RepKzTabControl.ItemSize = New System.Drawing.Size(123, 24)
        Me.RepKzTabControl.Location = New System.Drawing.Point(0, 0)
        Me.RepKzTabControl.Name = "RepKzTabControl"
        Me.RepKzTabControl.NewTitlePrefix = "New"
        Me.RepKzTabControl.SelectAfterAdd = True
        Me.RepKzTabControl.SelectedIndex = 0
        Me.RepKzTabControl.ShowCloseButton = True
        Me.RepKzTabControl.ShowTabMenu = True
        Me.RepKzTabControl.Size = New System.Drawing.Size(451, 270)
        Me.RepKzTabControl.TabIndex = 3
        Me.RepKzTabControl.Type = KzWorks.KzLibrary.KzTabControlTypes.Blank
        '
        'ListTab
        '
        Me.ListTab.Controls.Add(Me.ResaultListView)
        Me.ListTab.Location = New System.Drawing.Point(4, 28)
        Me.ListTab.Name = "ListTab"
        Me.ListTab.Padding = New System.Windows.Forms.Padding(3)
        Me.ListTab.Size = New System.Drawing.Size(443, 238)
        Me.ListTab.TabIndex = 2
        Me.ListTab.Text = "列表"
        Me.ListTab.UseVisualStyleBackColor = True
        '
        'ResaultListView
        '
        Me.ResaultListView.CheckBoxes = True
        Me.ResaultListView.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.resIndex, Me.resOriginWord, Me.resOriginIndex, Me.resOriginLength, Me.resPreWords, Me.resPostWords, Me.resReplacement})
        Me.ResaultListView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ResaultListView.FullRowSelect = True
        Me.ResaultListView.GridLines = True
        Me.ResaultListView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.ResaultListView.LabelEdit = True
        Me.ResaultListView.Location = New System.Drawing.Point(3, 3)
        Me.ResaultListView.Name = "ResaultListView"
        Me.ResaultListView.Size = New System.Drawing.Size(437, 232)
        Me.ResaultListView.TabIndex = 9
        Me.ResaultListView.UseCompatibleStateImageBehavior = False
        Me.ResaultListView.View = System.Windows.Forms.View.Details
        '
        'resIndex
        '
        Me.resIndex.Text = "索引"
        '
        'resOriginWord
        '
        Me.resOriginWord.DisplayIndex = 2
        Me.resOriginWord.Text = "源文"
        Me.resOriginWord.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'resOriginIndex
        '
        Me.resOriginIndex.DisplayIndex = 4
        Me.resOriginIndex.Text = "源索引"
        '
        'resOriginLength
        '
        Me.resOriginLength.DisplayIndex = 5
        Me.resOriginLength.Text = "源長度"
        '
        'resPreWords
        '
        Me.resPreWords.DisplayIndex = 1
        Me.resPreWords.Text = "前文"
        Me.resPreWords.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'resPostWords
        '
        Me.resPostWords.DisplayIndex = 3
        Me.resPostWords.Text = "後文"
        '
        'resReplacement
        '
        Me.resReplacement.Text = "替換"
        Me.resReplacement.Width = 59
        '
        'RecorderTab
        '
        Me.RecorderTab.Controls.Add(Me.CmdRecorder)
        Me.RecorderTab.Location = New System.Drawing.Point(4, 28)
        Me.RecorderTab.Name = "RecorderTab"
        Me.RecorderTab.Padding = New System.Windows.Forms.Padding(3)
        Me.RecorderTab.Size = New System.Drawing.Size(443, 238)
        Me.RecorderTab.TabIndex = 3
        Me.RecorderTab.Text = "記錄"
        Me.RecorderTab.UseVisualStyleBackColor = True
        '
        'CmdRecorder
        '
        Me.CmdRecorder.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.CmdRecorder.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CmdRecorder.Location = New System.Drawing.Point(3, 3)
        Me.CmdRecorder.Multiline = True
        Me.CmdRecorder.Name = "CmdRecorder"
        Me.CmdRecorder.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.CmdRecorder.Size = New System.Drawing.Size(437, 232)
        Me.CmdRecorder.TabIndex = 1
        '
        'ProjectTab
        '
        Me.ProjectTab.Controls.Add(Me.ProjectListView)
        Me.ProjectTab.Location = New System.Drawing.Point(4, 28)
        Me.ProjectTab.Name = "ProjectTab"
        Me.ProjectTab.Padding = New System.Windows.Forms.Padding(3)
        Me.ProjectTab.Size = New System.Drawing.Size(443, 238)
        Me.ProjectTab.TabIndex = 1
        Me.ProjectTab.Text = "工程"
        Me.ProjectTab.UseVisualStyleBackColor = True
        '
        'ProjectListView
        '
        Me.ProjectListView.CheckBoxes = True
        Me.ProjectListView.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.regID, Me.regReplaceMode, Me.regSubject, Me.regFindParttern, Me.regReplaceParttern, Me.regRemarks})
        Me.ProjectListView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ProjectListView.FullRowSelect = True
        Me.ProjectListView.GridLines = True
        Me.ProjectListView.Location = New System.Drawing.Point(3, 3)
        Me.ProjectListView.Name = "ProjectListView"
        Me.ProjectListView.Size = New System.Drawing.Size(437, 232)
        Me.ProjectListView.TabIndex = 9
        Me.ProjectListView.UseCompatibleStateImageBehavior = False
        Me.ProjectListView.View = System.Windows.Forms.View.Details
        '
        'regID
        '
        Me.regID.Text = "#"
        '
        'regReplaceMode
        '
        Me.regReplaceMode.Text = "模式"
        '
        'regSubject
        '
        Me.regSubject.Text = "主題"
        '
        'regFindParttern
        '
        Me.regFindParttern.Text = "查找式"
        Me.regFindParttern.Width = 192
        '
        'regReplaceParttern
        '
        Me.regReplaceParttern.Text = "替換式"
        Me.regReplaceParttern.Width = 192
        '
        'regRemarks
        '
        Me.regRemarks.Text = "備註"
        Me.regRemarks.Width = 192
        '
        'ListStatusStrip
        '
        Me.ListStatusStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.IDListItem, Me.ResaultListItem})
        Me.ListStatusStrip.Location = New System.Drawing.Point(0, 270)
        Me.ListStatusStrip.Name = "ListStatusStrip"
        Me.ListStatusStrip.Size = New System.Drawing.Size(451, 23)
        Me.ListStatusStrip.TabIndex = 4
        Me.ListStatusStrip.Text = "StatusStrip1"
        '
        'IDListItem
        '
        Me.IDListItem.Name = "IDListItem"
        Me.IDListItem.Size = New System.Drawing.Size(21, 18)
        Me.IDListItem.Text = "ID"
        '
        'ResaultListItem
        '
        Me.ResaultListItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ResaultListItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TryReplaceListItem, Me.ClearResaultsListItem})
        Me.ResaultListItem.Image = CType(resources.GetObject("ResaultListItem.Image"), System.Drawing.Image)
        Me.ResaultListItem.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ResaultListItem.Name = "ResaultListItem"
        Me.ResaultListItem.ShowDropDownArrow = False
        Me.ResaultListItem.Size = New System.Drawing.Size(60, 21)
        Me.ResaultListItem.Text = "列出結果"
        '
        'TryReplaceListItem
        '
        Me.TryReplaceListItem.Name = "TryReplaceListItem"
        Me.TryReplaceListItem.Size = New System.Drawing.Size(124, 22)
        Me.TryReplaceListItem.Text = "嘗試替換"
        '
        'ClearResaultsListItem
        '
        Me.ClearResaultsListItem.Name = "ClearResaultsListItem"
        Me.ClearResaultsListItem.Size = New System.Drawing.Size(124, 22)
        Me.ClearResaultsListItem.Text = "清除列表"
        '
        'KzReplacer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.RootSplitContainer)
        Me.Margin = New System.Windows.Forms.Padding(3, 10, 3, 3)
        Me.Name = "KzReplacer"
        Me.Size = New System.Drawing.Size(453, 579)
        Me.RootSplitContainer.Panel1.ResumeLayout(False)
        Me.RootSplitContainer.Panel1.PerformLayout()
        Me.RootSplitContainer.Panel2.ResumeLayout(False)
        Me.RootSplitContainer.Panel2.PerformLayout()
        CType(Me.RootSplitContainer, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RootSplitContainer.ResumeLayout(False)
        Me.TopSplitContainer.Panel1.ResumeLayout(False)
        Me.TopSplitContainer.Panel2.ResumeLayout(False)
        CType(Me.TopSplitContainer, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TopSplitContainer.ResumeLayout(False)
        Me.SelectGroup.ResumeLayout(False)
        Me.SelectPanel.ResumeLayout(False)
        Me.SelectPanel.PerformLayout()
        Me.ReplaceGroupBox.ResumeLayout(False)
        Me.ReplaceGroupBox.PerformLayout()
        Me.FindGroupBox.ResumeLayout(False)
        Me.FindGroupBox.PerformLayout()
        Me.EffectedGroup.ResumeLayout(False)
        Me.EffectedGroup.PerformLayout()
        Me.OptionsGroup.ResumeLayout(False)
        Me.OptionsGroup.PerformLayout()
        Me.CommandsGroup.ResumeLayout(False)
        Me.CommandsPanel.ResumeLayout(False)
        Me.CommandsPanel.PerformLayout()
        Me.ReplacerToolStrip.ResumeLayout(False)
        Me.ReplacerToolStrip.PerformLayout()
        Me.RegexStatusStrip.ResumeLayout(False)
        Me.RegexStatusStrip.PerformLayout()
        Me.RepKzTabControl.ResumeLayout(False)
        Me.ListTab.ResumeLayout(False)
        Me.RecorderTab.ResumeLayout(False)
        Me.RecorderTab.PerformLayout()
        Me.ProjectTab.ResumeLayout(False)
        Me.ListStatusStrip.ResumeLayout(False)
        Me.ListStatusStrip.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents RootSplitContainer As SplitContainer
    Friend WithEvents TopSplitContainer As SplitContainer
    Friend WithEvents SelectGroup As GroupBox
    Friend WithEvents ResetButton As Button
    Friend WithEvents ToTextBox As TextBox
    Friend WithEvents FromTextBox As TextBox
    Friend WithEvents ToButton As Button
    Friend WithEvents FromButton As Button
    Friend WithEvents EffectedGroup As GroupBox
    Friend WithEvents RangeLabel As Label
    Friend WithEvents FirstButton As Button
    Friend WithEvents ReplaceButton As Button
    Friend WithEvents RoundCheckBox As CheckBox
    Friend WithEvents AllCheckBox As CheckBox
    Friend WithEvents ResaultListButton As Button
    Friend WithEvents LastButton As Button
    Friend WithEvents NextButton As Button
    Friend WithEvents PreviousButton As Button
    Friend WithEvents OptionsGroup As GroupBox
    Friend WithEvents OptionsCheckedList As CheckedListBox
    Friend WithEvents rdbMoveNone As RadioButton
    Friend WithEvents rdbSelectedAll As RadioButton
    Friend WithEvents rdbMovePrevious As RadioButton
    Friend WithEvents rdbPreviousAll As RadioButton
    Friend WithEvents rdbMoveNext As RadioButton
    Friend WithEvents rdbNextAll As RadioButton
    Friend WithEvents ReplaceGroupBox As GroupBox
    Friend WithEvents Replacer As TextBox
    Friend WithEvents FindGroupBox As GroupBox
    Friend WithEvents Finder As TextBox
    Friend WithEvents RepKzTabControl As KzLibrary.KzTabControl
    Friend WithEvents ProjectTab As TabPage
    Friend WithEvents ProjectListView As ListView
    Friend WithEvents regID As ColumnHeader
    Friend WithEvents regReplaceMode As ColumnHeader
    Friend WithEvents regSubject As ColumnHeader
    Friend WithEvents regFindParttern As ColumnHeader
    Friend WithEvents regReplaceParttern As ColumnHeader
    Friend WithEvents regRemarks As ColumnHeader
    Friend WithEvents ListTab As TabPage
    Friend WithEvents ResaultListView As ListView
    Friend WithEvents resIndex As ColumnHeader
    Friend WithEvents resOriginWord As ColumnHeader
    Friend WithEvents resOriginIndex As ColumnHeader
    Friend WithEvents resOriginLength As ColumnHeader
    Friend WithEvents resPreWords As ColumnHeader
    Friend WithEvents resPostWords As ColumnHeader
    Friend WithEvents resReplacement As ColumnHeader
    Friend WithEvents RegexStatusStrip As StatusStrip
    Friend WithEvents StateInfoItem As ToolStripStatusLabel
    Friend WithEvents FoundInfoItem As ToolStripStatusLabel
    Friend WithEvents SpanInfoItem As ToolStripStatusLabel
    Friend WithEvents RecorderTab As TabPage
    Friend WithEvents CmdRecorder As TextBox
    Friend WithEvents ListStatusStrip As StatusStrip
    Friend WithEvents CommandsGroup As GroupBox
    Friend WithEvents CommandsPanel As TableLayoutPanel
    Friend WithEvents IDListItem As ToolStripStatusLabel
    Friend WithEvents ReplacerToolTip As ToolTip
    Friend WithEvents ReplacerToolStrip As ToolStrip
    Friend WithEvents ObjectButton As ToolStripButton
    Friend WithEvents SelectPanel As TableLayoutPanel
    Friend WithEvents GoFromButton As Button
    Friend WithEvents SelectButton As Button
    Friend WithEvents GoToButton As Button
    Friend WithEvents FoundInSelInfoItem As ToolStripStatusLabel
    Friend WithEvents IndexInfoItem As ToolStripStatusLabel
    Friend WithEvents OptionsInfoItem As ToolStripStatusLabel
    Friend WithEvents ResaultListItem As ToolStripDropDownButton
    Friend WithEvents TryReplaceListItem As ToolStripMenuItem
    Friend WithEvents ClearResaultsListItem As ToolStripMenuItem
End Class
