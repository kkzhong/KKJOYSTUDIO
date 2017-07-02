<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class StartForm
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
        Me.components = New System.ComponentModel.Container()
        Me.StartMenuStrip = New System.Windows.Forms.MenuStrip()
        Me.MainToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.CloseAllToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.TestToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.T1ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.T2ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CmdTableLayoutPanel = New System.Windows.Forms.TableLayoutPanel()
        Me.BrowserButton = New System.Windows.Forms.Button()
        Me.EditorButton = New System.Windows.Forms.Button()
        Me.FindReplaceButton = New System.Windows.Forms.Button()
        Me.ExitButton = New System.Windows.Forms.Button()
        Me.UnButton = New System.Windows.Forms.Button()
        Me.GenToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.StartMenuStrip.SuspendLayout()
        Me.CmdTableLayoutPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'StartMenuStrip
        '
        Me.StartMenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MainToolStripMenuItem})
        Me.StartMenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.StartMenuStrip.Name = "StartMenuStrip"
        Me.StartMenuStrip.Size = New System.Drawing.Size(435, 25)
        Me.StartMenuStrip.TabIndex = 1
        Me.StartMenuStrip.Text = "MenuStrip1"
        '
        'MainToolStripMenuItem
        '
        Me.MainToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EditorToolStripMenuItem, Me.ToolStripSeparator1, Me.CloseAllToolStripMenuItem, Me.ExitToolStripMenuItem, Me.ToolStripSeparator2, Me.TestToolStripMenuItem})
        Me.MainToolStripMenuItem.Name = "MainToolStripMenuItem"
        Me.MainToolStripMenuItem.Size = New System.Drawing.Size(49, 21)
        Me.MainToolStripMenuItem.Text = "Main"
        '
        'EditorToolStripMenuItem
        '
        Me.EditorToolStripMenuItem.Name = "EditorToolStripMenuItem"
        Me.EditorToolStripMenuItem.Size = New System.Drawing.Size(122, 22)
        Me.EditorToolStripMenuItem.Text = "Editor"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(119, 6)
        '
        'CloseAllToolStripMenuItem
        '
        Me.CloseAllToolStripMenuItem.Name = "CloseAllToolStripMenuItem"
        Me.CloseAllToolStripMenuItem.Size = New System.Drawing.Size(122, 22)
        Me.CloseAllToolStripMenuItem.Text = "CloseAll"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(122, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(119, 6)
        '
        'TestToolStripMenuItem
        '
        Me.TestToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.T1ToolStripMenuItem, Me.T2ToolStripMenuItem})
        Me.TestToolStripMenuItem.Name = "TestToolStripMenuItem"
        Me.TestToolStripMenuItem.Size = New System.Drawing.Size(122, 22)
        Me.TestToolStripMenuItem.Text = "Test"
        '
        'T1ToolStripMenuItem
        '
        Me.T1ToolStripMenuItem.Name = "T1ToolStripMenuItem"
        Me.T1ToolStripMenuItem.Size = New System.Drawing.Size(90, 22)
        Me.T1ToolStripMenuItem.Text = "T1"
        '
        'T2ToolStripMenuItem
        '
        Me.T2ToolStripMenuItem.Name = "T2ToolStripMenuItem"
        Me.T2ToolStripMenuItem.Size = New System.Drawing.Size(90, 22)
        Me.T2ToolStripMenuItem.Text = "T2"
        '
        'CmdTableLayoutPanel
        '
        Me.CmdTableLayoutPanel.ColumnCount = 3
        Me.CmdTableLayoutPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.CmdTableLayoutPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.CmdTableLayoutPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.CmdTableLayoutPanel.Controls.Add(Me.BrowserButton, 0, 2)
        Me.CmdTableLayoutPanel.Controls.Add(Me.EditorButton, 0, 0)
        Me.CmdTableLayoutPanel.Controls.Add(Me.FindReplaceButton, 1, 0)
        Me.CmdTableLayoutPanel.Controls.Add(Me.ExitButton, 2, 2)
        Me.CmdTableLayoutPanel.Controls.Add(Me.UnButton, 2, 0)
        Me.CmdTableLayoutPanel.Location = New System.Drawing.Point(113, 58)
        Me.CmdTableLayoutPanel.Name = "CmdTableLayoutPanel"
        Me.CmdTableLayoutPanel.RowCount = 3
        Me.CmdTableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.CmdTableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.CmdTableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.CmdTableLayoutPanel.Size = New System.Drawing.Size(160, 160)
        Me.CmdTableLayoutPanel.TabIndex = 2
        '
        'BrowserButton
        '
        Me.BrowserButton.BackgroundImage = Global.KzWorks.My.Resources.Resources.Internet
        Me.BrowserButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BrowserButton.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BrowserButton.Location = New System.Drawing.Point(3, 109)
        Me.BrowserButton.Name = "BrowserButton"
        Me.BrowserButton.Size = New System.Drawing.Size(47, 48)
        Me.BrowserButton.TabIndex = 3
        Me.BrowserButton.UseVisualStyleBackColor = True
        '
        'EditorButton
        '
        Me.EditorButton.BackgroundImage = Global.KzWorks.My.Resources.Resources.Editor
        Me.EditorButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.EditorButton.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EditorButton.Location = New System.Drawing.Point(3, 3)
        Me.EditorButton.Name = "EditorButton"
        Me.EditorButton.Size = New System.Drawing.Size(47, 47)
        Me.EditorButton.TabIndex = 0
        Me.EditorButton.UseVisualStyleBackColor = True
        '
        'FindReplaceButton
        '
        Me.FindReplaceButton.BackgroundImage = Global.KzWorks.My.Resources.Resources.Search
        Me.FindReplaceButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.FindReplaceButton.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FindReplaceButton.Location = New System.Drawing.Point(56, 3)
        Me.FindReplaceButton.Name = "FindReplaceButton"
        Me.FindReplaceButton.Size = New System.Drawing.Size(47, 47)
        Me.FindReplaceButton.TabIndex = 1
        Me.FindReplaceButton.UseVisualStyleBackColor = True
        '
        'ExitButton
        '
        Me.ExitButton.BackgroundImage = Global.KzWorks.My.Resources.Resources.Power
        Me.ExitButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ExitButton.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ExitButton.Location = New System.Drawing.Point(109, 109)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(48, 48)
        Me.ExitButton.TabIndex = 2
        Me.ExitButton.UseVisualStyleBackColor = True
        '
        'UnButton
        '
        Me.UnButton.BackgroundImage = Global.KzWorks.My.Resources.Resources.Scheduling
        Me.UnButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.UnButton.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UnButton.Location = New System.Drawing.Point(109, 3)
        Me.UnButton.Name = "UnButton"
        Me.UnButton.Size = New System.Drawing.Size(48, 47)
        Me.UnButton.TabIndex = 4
        Me.UnButton.UseVisualStyleBackColor = True
        '
        'StartForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(435, 261)
        Me.Controls.Add(Me.CmdTableLayoutPanel)
        Me.Controls.Add(Me.StartMenuStrip)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.StartMenuStrip
        Me.Name = "StartForm"
        Me.Text = "Form1"
        Me.StartMenuStrip.ResumeLayout(False)
        Me.StartMenuStrip.PerformLayout()
        Me.CmdTableLayoutPanel.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents StartMenuStrip As MenuStrip
    Friend WithEvents CmdTableLayoutPanel As TableLayoutPanel
    Friend WithEvents EditorButton As Button
    Friend WithEvents FindReplaceButton As Button
    Friend WithEvents MainToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EditorToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents CloseAllToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitButton As Button
    Friend WithEvents GenToolTip As ToolTip
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents TestToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BrowserButton As Button
    Friend WithEvents T1ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents T2ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UnButton As Button
End Class
