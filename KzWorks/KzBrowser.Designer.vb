<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class KzBrowser
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
        Me.BrowserToolStrip = New System.Windows.Forms.ToolStrip()
        Me.UrlToolItem = New System.Windows.Forms.ToolStripTextBox()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BrowserStatusStrip = New System.Windows.Forms.StatusStrip()
        Me.WebKzTabControl = New KzWorks.KzLibrary.KzTabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.CmdsToolStripDropDownButton = New System.Windows.Forms.ToolStripDropDownButton()
        Me.SourceToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BackToolItem = New System.Windows.Forms.ToolStripButton()
        Me.ForwardToolItem = New System.Windows.Forms.ToolStripButton()
        Me.RefreshToolItem = New System.Windows.Forms.ToolStripButton()
        Me.GoToolItem = New System.Windows.Forms.ToolStripButton()
        Me.AddToolItem = New System.Windows.Forms.ToolStripButton()
        Me.CloseToolItem = New System.Windows.Forms.ToolStripButton()
        Me.BrowserToolStrip.SuspendLayout()
        Me.BrowserStatusStrip.SuspendLayout()
        Me.WebKzTabControl.SuspendLayout()
        Me.SuspendLayout()
        '
        'BrowserToolStrip
        '
        Me.BrowserToolStrip.BackColor = System.Drawing.Color.Aquamarine
        Me.BrowserToolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.BrowserToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BackToolItem, Me.ForwardToolItem, Me.RefreshToolItem, Me.UrlToolItem, Me.GoToolItem, Me.ToolStripSeparator1, Me.AddToolItem, Me.CloseToolItem})
        Me.BrowserToolStrip.Location = New System.Drawing.Point(0, 0)
        Me.BrowserToolStrip.Name = "BrowserToolStrip"
        Me.BrowserToolStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.BrowserToolStrip.Size = New System.Drawing.Size(681, 25)
        Me.BrowserToolStrip.TabIndex = 0
        Me.BrowserToolStrip.Text = "ToolStrip1"
        '
        'UrlToolItem
        '
        Me.UrlToolItem.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.UrlToolItem.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.AllUrl
        Me.UrlToolItem.AutoSize = False
        Me.UrlToolItem.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.UrlToolItem.Name = "UrlToolItem"
        Me.UrlToolItem.Size = New System.Drawing.Size(100, 23)
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BrowserStatusStrip
        '
        Me.BrowserStatusStrip.BackColor = System.Drawing.Color.Aquamarine
        Me.BrowserStatusStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CmdsToolStripDropDownButton})
        Me.BrowserStatusStrip.Location = New System.Drawing.Point(0, 434)
        Me.BrowserStatusStrip.Name = "BrowserStatusStrip"
        Me.BrowserStatusStrip.Size = New System.Drawing.Size(681, 22)
        Me.BrowserStatusStrip.TabIndex = 1
        Me.BrowserStatusStrip.Text = "StatusStrip1"
        '
        'WebKzTabControl
        '
        Me.WebKzTabControl.BackgroundColor = System.Drawing.SystemColors.Control
        Me.WebKzTabControl.Controls.Add(Me.TabPage1)
        Me.WebKzTabControl.Controls.Add(Me.TabPage2)
        Me.WebKzTabControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.WebKzTabControl.Location = New System.Drawing.Point(0, 25)
        Me.WebKzTabControl.Name = "WebKzTabControl"
        Me.WebKzTabControl.NewTitlePrefix = "New"
        Me.WebKzTabControl.SelectAfterAdd = True
        Me.WebKzTabControl.SelectedIndex = 0
        Me.WebKzTabControl.Size = New System.Drawing.Size(681, 409)
        Me.WebKzTabControl.TabIndex = 2
        Me.WebKzTabControl.Type = KzWorks.KzLibrary.KzTabControlTypes.TextEditor
        '
        'TabPage1
        '
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(673, 383)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "TabPage1"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(673, 383)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "TabPage2"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'CmdsToolStripDropDownButton
        '
        Me.CmdsToolStripDropDownButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.CmdsToolStripDropDownButton.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SourceToolStripMenuItem})
        Me.CmdsToolStripDropDownButton.Image = Global.KzWorks.My.Resources.Resources.Command
        Me.CmdsToolStripDropDownButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.CmdsToolStripDropDownButton.Name = "CmdsToolStripDropDownButton"
        Me.CmdsToolStripDropDownButton.ShowDropDownArrow = False
        Me.CmdsToolStripDropDownButton.Size = New System.Drawing.Size(20, 20)
        Me.CmdsToolStripDropDownButton.Text = "ToolStripDropDownButton1"
        '
        'SourceToolStripMenuItem
        '
        Me.SourceToolStripMenuItem.Name = "SourceToolStripMenuItem"
        Me.SourceToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.SourceToolStripMenuItem.Text = "Source"
        '
        'BackToolItem
        '
        Me.BackToolItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BackToolItem.Image = Global.KzWorks.My.Resources.Resources.GoBack
        Me.BackToolItem.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BackToolItem.Name = "BackToolItem"
        Me.BackToolItem.Size = New System.Drawing.Size(23, 22)
        Me.BackToolItem.Text = "後退"
        '
        'ForwardToolItem
        '
        Me.ForwardToolItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ForwardToolItem.Image = Global.KzWorks.My.Resources.Resources.GoForward
        Me.ForwardToolItem.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ForwardToolItem.Name = "ForwardToolItem"
        Me.ForwardToolItem.Size = New System.Drawing.Size(23, 22)
        Me.ForwardToolItem.Text = "前進"
        '
        'RefreshToolItem
        '
        Me.RefreshToolItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.RefreshToolItem.Image = Global.KzWorks.My.Resources.Resources.Refresh
        Me.RefreshToolItem.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.RefreshToolItem.Name = "RefreshToolItem"
        Me.RefreshToolItem.Size = New System.Drawing.Size(23, 22)
        Me.RefreshToolItem.Text = "刷新"
        '
        'GoToolItem
        '
        Me.GoToolItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.GoToolItem.Image = Global.KzWorks.My.Resources.Resources.Play
        Me.GoToolItem.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.GoToolItem.Name = "GoToolItem"
        Me.GoToolItem.Size = New System.Drawing.Size(23, 22)
        Me.GoToolItem.Text = "前往"
        '
        'AddToolItem
        '
        Me.AddToolItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.AddToolItem.Image = Global.KzWorks.My.Resources.Resources.Add
        Me.AddToolItem.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.AddToolItem.Name = "AddToolItem"
        Me.AddToolItem.Size = New System.Drawing.Size(23, 22)
        Me.AddToolItem.Text = "ToolStripButton1"
        '
        'CloseToolItem
        '
        Me.CloseToolItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.CloseToolItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.CloseToolItem.Image = Global.KzWorks.My.Resources.Resources.WebClose
        Me.CloseToolItem.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.CloseToolItem.Name = "CloseToolItem"
        Me.CloseToolItem.Size = New System.Drawing.Size(23, 22)
        Me.CloseToolItem.Text = "退出"
        '
        'KzBrowser
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.WebKzTabControl)
        Me.Controls.Add(Me.BrowserStatusStrip)
        Me.Controls.Add(Me.BrowserToolStrip)
        Me.Name = "KzBrowser"
        Me.Size = New System.Drawing.Size(681, 456)
        Me.BrowserToolStrip.ResumeLayout(False)
        Me.BrowserToolStrip.PerformLayout()
        Me.BrowserStatusStrip.ResumeLayout(False)
        Me.BrowserStatusStrip.PerformLayout()
        Me.WebKzTabControl.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BrowserToolStrip As ToolStrip
    Friend WithEvents BackToolItem As ToolStripButton
    Friend WithEvents ForwardToolItem As ToolStripButton
    Friend WithEvents RefreshToolItem As ToolStripButton
    Friend WithEvents UrlToolItem As ToolStripTextBox
    Friend WithEvents GoToolItem As ToolStripButton
    Friend WithEvents BrowserStatusStrip As StatusStrip
    Friend WithEvents WebKzTabControl As KzLibrary.KzTabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents AddToolItem As ToolStripButton
    Friend WithEvents CmdsToolStripDropDownButton As ToolStripDropDownButton
    Friend WithEvents SourceToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CloseToolItem As ToolStripButton
End Class
