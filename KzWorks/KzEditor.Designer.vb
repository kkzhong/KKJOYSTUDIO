<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class KzEditor
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(KzEditor))
        Me.EditorToolStrip = New System.Windows.Forms.ToolStrip()
        Me.NewToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.OpenToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.SaveToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.SaveAllToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.CloseToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.EditorStatusStrip = New System.Windows.Forms.StatusStrip()
        Me.StateInfoItem = New System.Windows.Forms.ToolStripDropDownButton()
        Me.TextInfoItem = New System.Windows.Forms.ToolStripDropDownButton()
        Me.CharsTextItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CharsWoSpacesTextItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ChineseCharsTextItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.WordsTextItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ChineseWordsTextItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ParagraphsTextItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LinesTextItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PunctuationsTextItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TextElementsTextItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.DetailTextItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SelectionInfoItem = New System.Windows.Forms.ToolStripDropDownButton()
        Me.StartSelItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LengthSelItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PosSelItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.InvertSelItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AheadSelItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PostSelItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator()
        Me.ExpModeSelItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExpFromHereSelItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ModeInfoItem = New System.Windows.Forms.ToolStripDropDownButton()
        Me.EncodingInfoItem = New System.Windows.Forms.ToolStripDropDownButton()
        Me.DefaultEncodingItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.ASCIIEncodingItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UTF8EncodingItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UnicodeEncodingItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UnicodeBEEncodingItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UTF7EncodingItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UTF32EncodingItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SpanInfoItem = New System.Windows.Forms.ToolStripDropDownButton()
        Me.FileInfoItem = New System.Windows.Forms.ToolStripDropDownButton()
        Me.NameFileItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TypeFileItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LengthFileItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CreatedFileItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AccessedFileItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.WritedFileItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.AttributesFileItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FolderInfoItem = New System.Windows.Forms.ToolStripDropDownButton()
        Me.TextKzTabControl = New KzWorks.KzLibrary.KzTabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.ToolStripSeparator7 = New System.Windows.Forms.ToolStripSeparator()
        Me.EditorToolStrip.SuspendLayout()
        Me.EditorStatusStrip.SuspendLayout()
        Me.TextKzTabControl.SuspendLayout()
        Me.SuspendLayout()
        '
        'EditorToolStrip
        '
        Me.EditorToolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.EditorToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewToolStripButton, Me.OpenToolStripButton, Me.SaveToolStripButton, Me.SaveAllToolStripButton, Me.CloseToolStripButton, Me.ToolStripSeparator7})
        Me.EditorToolStrip.Location = New System.Drawing.Point(0, 0)
        Me.EditorToolStrip.Name = "EditorToolStrip"
        Me.EditorToolStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.EditorToolStrip.Size = New System.Drawing.Size(528, 25)
        Me.EditorToolStrip.TabIndex = 1
        Me.EditorToolStrip.Text = "ToolStrip1"
        '
        'NewToolStripButton
        '
        Me.NewToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.NewToolStripButton.Image = CType(resources.GetObject("NewToolStripButton.Image"), System.Drawing.Image)
        Me.NewToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.NewToolStripButton.Name = "NewToolStripButton"
        Me.NewToolStripButton.Size = New System.Drawing.Size(23, 22)
        Me.NewToolStripButton.Text = "新建"
        '
        'OpenToolStripButton
        '
        Me.OpenToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.OpenToolStripButton.Image = CType(resources.GetObject("OpenToolStripButton.Image"), System.Drawing.Image)
        Me.OpenToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.OpenToolStripButton.Name = "OpenToolStripButton"
        Me.OpenToolStripButton.Size = New System.Drawing.Size(23, 22)
        Me.OpenToolStripButton.Text = "開啟"
        '
        'SaveToolStripButton
        '
        Me.SaveToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.SaveToolStripButton.Image = CType(resources.GetObject("SaveToolStripButton.Image"), System.Drawing.Image)
        Me.SaveToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.SaveToolStripButton.Name = "SaveToolStripButton"
        Me.SaveToolStripButton.Size = New System.Drawing.Size(23, 22)
        Me.SaveToolStripButton.Text = "保存"
        '
        'SaveAllToolStripButton
        '
        Me.SaveAllToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.SaveAllToolStripButton.Image = CType(resources.GetObject("SaveAllToolStripButton.Image"), System.Drawing.Image)
        Me.SaveAllToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.SaveAllToolStripButton.Name = "SaveAllToolStripButton"
        Me.SaveAllToolStripButton.Size = New System.Drawing.Size(23, 22)
        Me.SaveAllToolStripButton.Text = "全部保存"
        '
        'CloseToolStripButton
        '
        Me.CloseToolStripButton.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.CloseToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.CloseToolStripButton.Image = Global.KzWorks.My.Resources.Resources.WebClose
        Me.CloseToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.CloseToolStripButton.Name = "CloseToolStripButton"
        Me.CloseToolStripButton.Size = New System.Drawing.Size(23, 22)
        Me.CloseToolStripButton.Text = "ToolStripButton1"
        '
        'EditorStatusStrip
        '
        Me.EditorStatusStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.StateInfoItem, Me.TextInfoItem, Me.SelectionInfoItem, Me.ModeInfoItem, Me.EncodingInfoItem, Me.SpanInfoItem, Me.FileInfoItem, Me.FolderInfoItem})
        Me.EditorStatusStrip.Location = New System.Drawing.Point(0, 357)
        Me.EditorStatusStrip.Name = "EditorStatusStrip"
        Me.EditorStatusStrip.ShowItemToolTips = True
        Me.EditorStatusStrip.Size = New System.Drawing.Size(528, 23)
        Me.EditorStatusStrip.TabIndex = 2
        Me.EditorStatusStrip.Text = "StatusStrip1"
        '
        'StateInfoItem
        '
        Me.StateInfoItem.Name = "StateInfoItem"
        Me.StateInfoItem.ShowDropDownArrow = False
        Me.StateInfoItem.Size = New System.Drawing.Size(36, 21)
        Me.StateInfoItem.Text = "新建"
        Me.StateInfoItem.ToolTipText = "文檔狀態"
        '
        'TextInfoItem
        '
        Me.TextInfoItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CharsTextItem, Me.CharsWoSpacesTextItem, Me.ChineseCharsTextItem, Me.ToolStripSeparator1, Me.WordsTextItem, Me.ChineseWordsTextItem, Me.ParagraphsTextItem, Me.LinesTextItem, Me.PunctuationsTextItem, Me.TextElementsTextItem, Me.ToolStripSeparator2, Me.DetailTextItem})
        Me.TextInfoItem.Name = "TextInfoItem"
        Me.TextInfoItem.ShowDropDownArrow = False
        Me.TextInfoItem.Size = New System.Drawing.Size(36, 21)
        Me.TextInfoItem.Text = "字數"
        Me.TextInfoItem.ToolTipText = "字符計數"
        '
        'CharsTextItem
        '
        Me.CharsTextItem.Name = "CharsTextItem"
        Me.CharsTextItem.Size = New System.Drawing.Size(195, 22)
        Me.CharsTextItem.Text = "CharsWithSpaces"
        '
        'CharsWoSpacesTextItem
        '
        Me.CharsWoSpacesTextItem.Name = "CharsWoSpacesTextItem"
        Me.CharsWoSpacesTextItem.Size = New System.Drawing.Size(195, 22)
        Me.CharsWoSpacesTextItem.Text = "CharsWithoutSpaces"
        '
        'ChineseCharsTextItem
        '
        Me.ChineseCharsTextItem.Name = "ChineseCharsTextItem"
        Me.ChineseCharsTextItem.Size = New System.Drawing.Size(195, 22)
        Me.ChineseCharsTextItem.Text = "ChineseChars"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(192, 6)
        '
        'WordsTextItem
        '
        Me.WordsTextItem.Name = "WordsTextItem"
        Me.WordsTextItem.Size = New System.Drawing.Size(195, 22)
        Me.WordsTextItem.Text = "Words"
        '
        'ChineseWordsTextItem
        '
        Me.ChineseWordsTextItem.Name = "ChineseWordsTextItem"
        Me.ChineseWordsTextItem.Size = New System.Drawing.Size(195, 22)
        Me.ChineseWordsTextItem.Text = "ChineseWords"
        '
        'ParagraphsTextItem
        '
        Me.ParagraphsTextItem.Name = "ParagraphsTextItem"
        Me.ParagraphsTextItem.Size = New System.Drawing.Size(195, 22)
        Me.ParagraphsTextItem.Text = "Paragraphs"
        '
        'LinesTextItem
        '
        Me.LinesTextItem.Name = "LinesTextItem"
        Me.LinesTextItem.Size = New System.Drawing.Size(195, 22)
        Me.LinesTextItem.Text = "Lines"
        '
        'PunctuationsTextItem
        '
        Me.PunctuationsTextItem.Name = "PunctuationsTextItem"
        Me.PunctuationsTextItem.Size = New System.Drawing.Size(195, 22)
        Me.PunctuationsTextItem.Text = "Punctuations"
        '
        'TextElementsTextItem
        '
        Me.TextElementsTextItem.Name = "TextElementsTextItem"
        Me.TextElementsTextItem.Size = New System.Drawing.Size(195, 22)
        Me.TextElementsTextItem.Text = "TextElements"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(192, 6)
        '
        'DetailTextItem
        '
        Me.DetailTextItem.Name = "DetailTextItem"
        Me.DetailTextItem.Size = New System.Drawing.Size(195, 22)
        Me.DetailTextItem.Text = "Detail"
        '
        'SelectionInfoItem
        '
        Me.SelectionInfoItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.StartSelItem, Me.LengthSelItem, Me.PosSelItem, Me.ToolStripSeparator5, Me.InvertSelItem, Me.AheadSelItem, Me.PostSelItem, Me.ToolStripSeparator6, Me.ExpModeSelItem, Me.ExpFromHereSelItem})
        Me.SelectionInfoItem.Name = "SelectionInfoItem"
        Me.SelectionInfoItem.ShowDropDownArrow = False
        Me.SelectionInfoItem.Size = New System.Drawing.Size(36, 21)
        Me.SelectionInfoItem.Text = "起點"
        Me.SelectionInfoItem.ToolTipText = "選定起點"
        '
        'StartSelItem
        '
        Me.StartSelItem.Name = "StartSelItem"
        Me.StartSelItem.Size = New System.Drawing.Size(155, 22)
        Me.StartSelItem.Text = "Start"
        '
        'LengthSelItem
        '
        Me.LengthSelItem.Name = "LengthSelItem"
        Me.LengthSelItem.Size = New System.Drawing.Size(155, 22)
        Me.LengthSelItem.Text = "Length"
        '
        'PosSelItem
        '
        Me.PosSelItem.Name = "PosSelItem"
        Me.PosSelItem.Size = New System.Drawing.Size(155, 22)
        Me.PosSelItem.Text = "Pos"
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(152, 6)
        '
        'InvertSelItem
        '
        Me.InvertSelItem.Name = "InvertSelItem"
        Me.InvertSelItem.Size = New System.Drawing.Size(155, 22)
        Me.InvertSelItem.Text = "SelInvert"
        '
        'AheadSelItem
        '
        Me.AheadSelItem.Name = "AheadSelItem"
        Me.AheadSelItem.Size = New System.Drawing.Size(155, 22)
        Me.AheadSelItem.Text = "SelAhead"
        '
        'PostSelItem
        '
        Me.PostSelItem.Name = "PostSelItem"
        Me.PostSelItem.Size = New System.Drawing.Size(155, 22)
        Me.PostSelItem.Text = "SelPost"
        '
        'ToolStripSeparator6
        '
        Me.ToolStripSeparator6.Name = "ToolStripSeparator6"
        Me.ToolStripSeparator6.Size = New System.Drawing.Size(152, 6)
        '
        'ExpModeSelItem
        '
        Me.ExpModeSelItem.Name = "ExpModeSelItem"
        Me.ExpModeSelItem.Size = New System.Drawing.Size(155, 22)
        Me.ExpModeSelItem.Text = "ExpSelection"
        '
        'ExpFromHereSelItem
        '
        Me.ExpFromHereSelItem.Name = "ExpFromHereSelItem"
        Me.ExpFromHereSelItem.Size = New System.Drawing.Size(155, 22)
        Me.ExpFromHereSelItem.Text = "ExpFromHere"
        '
        'ModeInfoItem
        '
        Me.ModeInfoItem.Name = "ModeInfoItem"
        Me.ModeInfoItem.ShowDropDownArrow = False
        Me.ModeInfoItem.Size = New System.Drawing.Size(36, 21)
        Me.ModeInfoItem.Text = "擴展"
        Me.ModeInfoItem.ToolTipText = "選擇模式"
        '
        'EncodingInfoItem
        '
        Me.EncodingInfoItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DefaultEncodingItem, Me.ToolStripSeparator3, Me.ASCIIEncodingItem, Me.UTF8EncodingItem, Me.UnicodeEncodingItem, Me.UnicodeBEEncodingItem, Me.UTF7EncodingItem, Me.UTF32EncodingItem})
        Me.EncodingInfoItem.Name = "EncodingInfoItem"
        Me.EncodingInfoItem.ShowDropDownArrow = False
        Me.EncodingInfoItem.Size = New System.Drawing.Size(36, 21)
        Me.EncodingInfoItem.Text = "編碼"
        Me.EncodingInfoItem.ToolTipText = "文檔編碼"
        '
        'DefaultEncodingItem
        '
        Me.DefaultEncodingItem.Name = "DefaultEncodingItem"
        Me.DefaultEncodingItem.Size = New System.Drawing.Size(186, 22)
        Me.DefaultEncodingItem.Text = "Default"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(183, 6)
        '
        'ASCIIEncodingItem
        '
        Me.ASCIIEncodingItem.Name = "ASCIIEncodingItem"
        Me.ASCIIEncodingItem.Size = New System.Drawing.Size(186, 22)
        Me.ASCIIEncodingItem.Text = "ASCII"
        '
        'UTF8EncodingItem
        '
        Me.UTF8EncodingItem.Name = "UTF8EncodingItem"
        Me.UTF8EncodingItem.Size = New System.Drawing.Size(186, 22)
        Me.UTF8EncodingItem.Text = "UTF-8"
        '
        'UnicodeEncodingItem
        '
        Me.UnicodeEncodingItem.Name = "UnicodeEncodingItem"
        Me.UnicodeEncodingItem.Size = New System.Drawing.Size(186, 22)
        Me.UnicodeEncodingItem.Text = "Unicode (UTF-16)"
        '
        'UnicodeBEEncodingItem
        '
        Me.UnicodeBEEncodingItem.Name = "UnicodeBEEncodingItem"
        Me.UnicodeBEEncodingItem.Size = New System.Drawing.Size(186, 22)
        Me.UnicodeBEEncodingItem.Text = "Unicode BigEndian"
        '
        'UTF7EncodingItem
        '
        Me.UTF7EncodingItem.Name = "UTF7EncodingItem"
        Me.UTF7EncodingItem.Size = New System.Drawing.Size(186, 22)
        Me.UTF7EncodingItem.Text = "UTF-7"
        '
        'UTF32EncodingItem
        '
        Me.UTF32EncodingItem.Name = "UTF32EncodingItem"
        Me.UTF32EncodingItem.Size = New System.Drawing.Size(186, 22)
        Me.UTF32EncodingItem.Text = "UTF-32"
        '
        'SpanInfoItem
        '
        Me.SpanInfoItem.Name = "SpanInfoItem"
        Me.SpanInfoItem.ShowDropDownArrow = False
        Me.SpanInfoItem.Size = New System.Drawing.Size(36, 21)
        Me.SpanInfoItem.Text = "讀入"
        Me.SpanInfoItem.ToolTipText = "讀入時長"
        '
        'FileInfoItem
        '
        Me.FileInfoItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NameFileItem, Me.TypeFileItem, Me.LengthFileItem, Me.CreatedFileItem, Me.AccessedFileItem, Me.WritedFileItem, Me.ToolStripSeparator4, Me.AttributesFileItem})
        Me.FileInfoItem.Name = "FileInfoItem"
        Me.FileInfoItem.ShowDropDownArrow = False
        Me.FileInfoItem.Size = New System.Drawing.Size(36, 21)
        Me.FileInfoItem.Text = "容量"
        Me.FileInfoItem.ToolTipText = "文檔容量"
        '
        'NameFileItem
        '
        Me.NameFileItem.Name = "NameFileItem"
        Me.NameFileItem.Size = New System.Drawing.Size(132, 22)
        Me.NameFileItem.Text = "Name"
        '
        'TypeFileItem
        '
        Me.TypeFileItem.Name = "TypeFileItem"
        Me.TypeFileItem.Size = New System.Drawing.Size(132, 22)
        Me.TypeFileItem.Text = "Type"
        '
        'LengthFileItem
        '
        Me.LengthFileItem.Name = "LengthFileItem"
        Me.LengthFileItem.Size = New System.Drawing.Size(132, 22)
        Me.LengthFileItem.Text = "Length"
        '
        'CreatedFileItem
        '
        Me.CreatedFileItem.Name = "CreatedFileItem"
        Me.CreatedFileItem.Size = New System.Drawing.Size(132, 22)
        Me.CreatedFileItem.Text = "Created"
        '
        'AccessedFileItem
        '
        Me.AccessedFileItem.Name = "AccessedFileItem"
        Me.AccessedFileItem.Size = New System.Drawing.Size(132, 22)
        Me.AccessedFileItem.Text = "Accessed"
        '
        'WritedFileItem
        '
        Me.WritedFileItem.Name = "WritedFileItem"
        Me.WritedFileItem.Size = New System.Drawing.Size(132, 22)
        Me.WritedFileItem.Text = "Writed"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(129, 6)
        '
        'AttributesFileItem
        '
        Me.AttributesFileItem.Name = "AttributesFileItem"
        Me.AttributesFileItem.Size = New System.Drawing.Size(132, 22)
        Me.AttributesFileItem.Text = "Attributes"
        '
        'FolderInfoItem
        '
        Me.FolderInfoItem.Name = "FolderInfoItem"
        Me.FolderInfoItem.ShowDropDownArrow = False
        Me.FolderInfoItem.Size = New System.Drawing.Size(36, 21)
        Me.FolderInfoItem.Text = "存檔"
        Me.FolderInfoItem.ToolTipText = "存檔位置"
        '
        'TextKzTabControl
        '
        Me.TextKzTabControl.BackgroundColor = System.Drawing.SystemColors.Control
        Me.TextKzTabControl.Controls.Add(Me.TabPage1)
        Me.TextKzTabControl.Controls.Add(Me.TabPage2)
        Me.TextKzTabControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TextKzTabControl.Location = New System.Drawing.Point(0, 25)
        Me.TextKzTabControl.Name = "TextKzTabControl"
        Me.TextKzTabControl.NewTitlePrefix = "New"
        Me.TextKzTabControl.SelectAfterAdd = True
        Me.TextKzTabControl.SelectedIndex = 0
        Me.TextKzTabControl.Size = New System.Drawing.Size(528, 332)
        Me.TextKzTabControl.TabIndex = 3
        Me.TextKzTabControl.Type = KzWorks.KzLibrary.KzTabControlTypes.TextEditor
        '
        'TabPage1
        '
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(520, 306)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "TabPage1"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(520, 306)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "TabPage2"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'ToolStripSeparator7
        '
        Me.ToolStripSeparator7.Name = "ToolStripSeparator7"
        Me.ToolStripSeparator7.Size = New System.Drawing.Size(6, 25)
        '
        'KzEditor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.TextKzTabControl)
        Me.Controls.Add(Me.EditorStatusStrip)
        Me.Controls.Add(Me.EditorToolStrip)
        Me.Name = "KzEditor"
        Me.Size = New System.Drawing.Size(528, 380)
        Me.EditorToolStrip.ResumeLayout(False)
        Me.EditorToolStrip.PerformLayout()
        Me.EditorStatusStrip.ResumeLayout(False)
        Me.EditorStatusStrip.PerformLayout()
        Me.TextKzTabControl.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents EditorToolStrip As ToolStrip
    Friend WithEvents NewToolStripButton As ToolStripButton
    Friend WithEvents OpenToolStripButton As ToolStripButton
    Friend WithEvents SaveToolStripButton As ToolStripButton
    Friend WithEvents SaveAllToolStripButton As ToolStripButton
    Friend WithEvents EditorStatusStrip As StatusStrip
    Friend WithEvents StateInfoItem As ToolStripDropDownButton
    Friend WithEvents TextInfoItem As ToolStripDropDownButton
    Friend WithEvents SelectionInfoItem As ToolStripDropDownButton
    Friend WithEvents ModeInfoItem As ToolStripDropDownButton
    Friend WithEvents EncodingInfoItem As ToolStripDropDownButton
    Friend WithEvents SpanInfoItem As ToolStripDropDownButton
    Friend WithEvents FileInfoItem As ToolStripDropDownButton
    Friend WithEvents FolderInfoItem As ToolStripDropDownButton
    Friend WithEvents TextKzTabControl As KzLibrary.KzTabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents CloseToolStripButton As ToolStripButton
    Friend WithEvents CharsWoSpacesTextItem As ToolStripMenuItem
    Friend WithEvents CharsTextItem As ToolStripMenuItem
    Friend WithEvents ChineseWordsTextItem As ToolStripMenuItem
    Friend WithEvents WordsTextItem As ToolStripMenuItem
    Friend WithEvents TextElementsTextItem As ToolStripMenuItem
    Friend WithEvents ParagraphsTextItem As ToolStripMenuItem
    Friend WithEvents LinesTextItem As ToolStripMenuItem
    Friend WithEvents ChineseCharsTextItem As ToolStripMenuItem
    Friend WithEvents PunctuationsTextItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents DetailTextItem As ToolStripMenuItem
    Friend WithEvents DefaultEncodingItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator3 As ToolStripSeparator
    Friend WithEvents ASCIIEncodingItem As ToolStripMenuItem
    Friend WithEvents UTF8EncodingItem As ToolStripMenuItem
    Friend WithEvents UnicodeEncodingItem As ToolStripMenuItem
    Friend WithEvents UnicodeBEEncodingItem As ToolStripMenuItem
    Friend WithEvents UTF7EncodingItem As ToolStripMenuItem
    Friend WithEvents UTF32EncodingItem As ToolStripMenuItem
    Friend WithEvents NameFileItem As ToolStripMenuItem
    Friend WithEvents TypeFileItem As ToolStripMenuItem
    Friend WithEvents LengthFileItem As ToolStripMenuItem
    Friend WithEvents CreatedFileItem As ToolStripMenuItem
    Friend WithEvents AccessedFileItem As ToolStripMenuItem
    Friend WithEvents WritedFileItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator4 As ToolStripSeparator
    Friend WithEvents AttributesFileItem As ToolStripMenuItem
    Friend WithEvents StartSelItem As ToolStripMenuItem
    Friend WithEvents LengthSelItem As ToolStripMenuItem
    Friend WithEvents PosSelItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator5 As ToolStripSeparator
    Friend WithEvents InvertSelItem As ToolStripMenuItem
    Friend WithEvents AheadSelItem As ToolStripMenuItem
    Friend WithEvents PostSelItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator6 As ToolStripSeparator
    Friend WithEvents ExpModeSelItem As ToolStripMenuItem
    Friend WithEvents ExpFromHereSelItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator7 As ToolStripSeparator
End Class
