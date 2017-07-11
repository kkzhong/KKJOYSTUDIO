<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class KzAprsDialog
    Inherits System.Windows.Forms.Form

    'Form 重写 Dispose，以清理组件列表。
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
        Me.RootSpliter = New System.Windows.Forms.SplitContainer()
        Me.TopSpliter = New System.Windows.Forms.SplitContainer()
        Me.KzTabPanel = New System.Windows.Forms.TableLayoutPanel()
        Me.IgnorePTSLabel = New System.Windows.Forms.Label()
        Me.ShowAOSTLabel = New System.Windows.Forms.Label()
        Me.TabTitleLabel = New System.Windows.Forms.Label()
        Me.RootBCLabel = New System.Windows.Forms.Label()
        Me.ShowCOUTLabel = New System.Windows.Forms.Label()
        Me.ShowCBOTLabel = New System.Windows.Forms.Label()
        Me.AutoTWLabel = New System.Windows.Forms.Label()
        Me.TabsUSLabel = New System.Windows.Forms.Label()
        Me.OpenSTULabel = New System.Windows.Forms.Label()
        Me.RootBackColorBox = New System.Windows.Forms.TextBox()
        Me.AutoTabWidthCheck = New System.Windows.Forms.CheckBox()
        Me.TabsUnderlineSizeUD = New System.Windows.Forms.NumericUpDown()
        Me.OpenUnderlineCheck = New System.Windows.Forms.CheckBox()
        Me.ShowCloseCheck = New System.Windows.Forms.CheckBox()
        Me.ShowUnselectedCheck = New System.Windows.Forms.CheckBox()
        Me.ShowAddCheck = New System.Windows.Forms.CheckBox()
        Me.IgnoreTabCheck = New System.Windows.Forms.CheckBox()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.BottomSpliter = New System.Windows.Forms.SplitContainer()
        Me.AprTabs = New KzLibrary.KzTabControl()
        Me.AprsTabs = New KzLibrary.KzTabControl()
        CType(Me.RootSpliter, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RootSpliter.Panel1.SuspendLayout()
        Me.RootSpliter.Panel2.SuspendLayout()
        Me.RootSpliter.SuspendLayout()
        CType(Me.TopSpliter, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TopSpliter.Panel1.SuspendLayout()
        Me.TopSpliter.Panel2.SuspendLayout()
        Me.TopSpliter.SuspendLayout()
        Me.KzTabPanel.SuspendLayout()
        CType(Me.TabsUnderlineSizeUD, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        CType(Me.BottomSpliter, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BottomSpliter.Panel1.SuspendLayout()
        Me.BottomSpliter.Panel2.SuspendLayout()
        Me.BottomSpliter.SuspendLayout()
        Me.SuspendLayout()
        '
        'RootSpliter
        '
        Me.RootSpliter.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RootSpliter.FixedPanel = System.Windows.Forms.FixedPanel.Panel2
        Me.RootSpliter.Location = New System.Drawing.Point(0, 0)
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
        Me.RootSpliter.Size = New System.Drawing.Size(663, 456)
        Me.RootSpliter.SplitterDistance = 239
        Me.RootSpliter.TabIndex = 0
        '
        'TopSpliter
        '
        Me.TopSpliter.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TopSpliter.Location = New System.Drawing.Point(0, 0)
        Me.TopSpliter.Name = "TopSpliter"
        '
        'TopSpliter.Panel1
        '
        Me.TopSpliter.Panel1.Controls.Add(Me.KzTabPanel)
        '
        'TopSpliter.Panel2
        '
        Me.TopSpliter.Panel2.Controls.Add(Me.TabControl1)
        Me.TopSpliter.Size = New System.Drawing.Size(663, 239)
        Me.TopSpliter.SplitterDistance = 256
        Me.TopSpliter.TabIndex = 0
        '
        'KzTabPanel
        '
        Me.KzTabPanel.ColumnCount = 3
        Me.KzTabPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 145.0!))
        Me.KzTabPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.KzTabPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.KzTabPanel.Controls.Add(Me.IgnorePTSLabel, 0, 8)
        Me.KzTabPanel.Controls.Add(Me.ShowAOSTLabel, 0, 7)
        Me.KzTabPanel.Controls.Add(Me.TabTitleLabel, 0, 0)
        Me.KzTabPanel.Controls.Add(Me.RootBCLabel, 0, 1)
        Me.KzTabPanel.Controls.Add(Me.ShowCOUTLabel, 0, 6)
        Me.KzTabPanel.Controls.Add(Me.ShowCBOTLabel, 0, 5)
        Me.KzTabPanel.Controls.Add(Me.AutoTWLabel, 0, 2)
        Me.KzTabPanel.Controls.Add(Me.TabsUSLabel, 0, 3)
        Me.KzTabPanel.Controls.Add(Me.OpenSTULabel, 0, 4)
        Me.KzTabPanel.Controls.Add(Me.RootBackColorBox, 1, 1)
        Me.KzTabPanel.Controls.Add(Me.AutoTabWidthCheck, 1, 2)
        Me.KzTabPanel.Controls.Add(Me.TabsUnderlineSizeUD, 1, 3)
        Me.KzTabPanel.Controls.Add(Me.OpenUnderlineCheck, 2, 4)
        Me.KzTabPanel.Controls.Add(Me.ShowCloseCheck, 2, 5)
        Me.KzTabPanel.Controls.Add(Me.ShowUnselectedCheck, 2, 6)
        Me.KzTabPanel.Controls.Add(Me.ShowAddCheck, 2, 7)
        Me.KzTabPanel.Controls.Add(Me.IgnoreTabCheck, 2, 8)
        Me.KzTabPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KzTabPanel.Location = New System.Drawing.Point(0, 0)
        Me.KzTabPanel.Name = "KzTabPanel"
        Me.KzTabPanel.RowCount = 10
        Me.KzTabPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26.0!))
        Me.KzTabPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26.0!))
        Me.KzTabPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26.0!))
        Me.KzTabPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26.0!))
        Me.KzTabPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26.0!))
        Me.KzTabPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26.0!))
        Me.KzTabPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26.0!))
        Me.KzTabPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26.0!))
        Me.KzTabPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26.0!))
        Me.KzTabPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.KzTabPanel.Size = New System.Drawing.Size(256, 239)
        Me.KzTabPanel.TabIndex = 0
        '
        'IgnorePTSLabel
        '
        Me.KzTabPanel.SetColumnSpan(Me.IgnorePTSLabel, 2)
        Me.IgnorePTSLabel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.IgnorePTSLabel.Location = New System.Drawing.Point(3, 208)
        Me.IgnorePTSLabel.Name = "IgnorePTSLabel"
        Me.IgnorePTSLabel.Size = New System.Drawing.Size(194, 26)
        Me.IgnorePTSLabel.TabIndex = 12
        Me.IgnorePTSLabel.Text = "IgnorePrivateTabSetting"
        Me.IgnorePTSLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'ShowAOSTLabel
        '
        Me.KzTabPanel.SetColumnSpan(Me.ShowAOSTLabel, 2)
        Me.ShowAOSTLabel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ShowAOSTLabel.Location = New System.Drawing.Point(3, 182)
        Me.ShowAOSTLabel.Name = "ShowAOSTLabel"
        Me.ShowAOSTLabel.Size = New System.Drawing.Size(194, 26)
        Me.ShowAOSTLabel.TabIndex = 13
        Me.ShowAOSTLabel.Text = "ShowAddOnSelectedTab"
        Me.ShowAOSTLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TabTitleLabel
        '
        Me.TabTitleLabel.AutoSize = True
        Me.KzTabPanel.SetColumnSpan(Me.TabTitleLabel, 2)
        Me.TabTitleLabel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabTitleLabel.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.TabTitleLabel.Location = New System.Drawing.Point(3, 0)
        Me.TabTitleLabel.Name = "TabTitleLabel"
        Me.TabTitleLabel.Size = New System.Drawing.Size(194, 26)
        Me.TabTitleLabel.TabIndex = 9
        Me.TabTitleLabel.Text = "Title"
        Me.TabTitleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'RootBCLabel
        '
        Me.RootBCLabel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RootBCLabel.Location = New System.Drawing.Point(3, 26)
        Me.RootBCLabel.Name = "RootBCLabel"
        Me.RootBCLabel.Size = New System.Drawing.Size(139, 26)
        Me.RootBCLabel.TabIndex = 6
        Me.RootBCLabel.Text = "RootBackColor"
        Me.RootBCLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'ShowCOUTLabel
        '
        Me.KzTabPanel.SetColumnSpan(Me.ShowCOUTLabel, 2)
        Me.ShowCOUTLabel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ShowCOUTLabel.Location = New System.Drawing.Point(3, 156)
        Me.ShowCOUTLabel.Name = "ShowCOUTLabel"
        Me.ShowCOUTLabel.Size = New System.Drawing.Size(194, 26)
        Me.ShowCOUTLabel.TabIndex = 10
        Me.ShowCOUTLabel.Text = "ShowCloseOnUnselectedTabs"
        Me.ShowCOUTLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'ShowCBOTLabel
        '
        Me.KzTabPanel.SetColumnSpan(Me.ShowCBOTLabel, 2)
        Me.ShowCBOTLabel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ShowCBOTLabel.Location = New System.Drawing.Point(3, 130)
        Me.ShowCBOTLabel.Name = "ShowCBOTLabel"
        Me.ShowCBOTLabel.Size = New System.Drawing.Size(194, 26)
        Me.ShowCBOTLabel.TabIndex = 11
        Me.ShowCBOTLabel.Text = "ShowCloseButtonOnTab"
        Me.ShowCBOTLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'AutoTWLabel
        '
        Me.AutoTWLabel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.AutoTWLabel.Location = New System.Drawing.Point(3, 52)
        Me.AutoTWLabel.Name = "AutoTWLabel"
        Me.AutoTWLabel.Size = New System.Drawing.Size(139, 26)
        Me.AutoTWLabel.TabIndex = 8
        Me.AutoTWLabel.Text = "AutoTabWidth"
        Me.AutoTWLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TabsUSLabel
        '
        Me.TabsUSLabel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabsUSLabel.Location = New System.Drawing.Point(3, 78)
        Me.TabsUSLabel.Name = "TabsUSLabel"
        Me.TabsUSLabel.Size = New System.Drawing.Size(139, 26)
        Me.TabsUSLabel.TabIndex = 7
        Me.TabsUSLabel.Text = "TabsUnderlineSize"
        Me.TabsUSLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'OpenSTULabel
        '
        Me.KzTabPanel.SetColumnSpan(Me.OpenSTULabel, 2)
        Me.OpenSTULabel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.OpenSTULabel.Location = New System.Drawing.Point(3, 104)
        Me.OpenSTULabel.Name = "OpenSTULabel"
        Me.OpenSTULabel.Size = New System.Drawing.Size(194, 26)
        Me.OpenSTULabel.TabIndex = 9
        Me.OpenSTULabel.Text = "OpenSelectedTabUnderline"
        Me.OpenSTULabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'RootBackColorBox
        '
        Me.KzTabPanel.SetColumnSpan(Me.RootBackColorBox, 2)
        Me.RootBackColorBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RootBackColorBox.Location = New System.Drawing.Point(146, 27)
        Me.RootBackColorBox.Margin = New System.Windows.Forms.Padding(1)
        Me.RootBackColorBox.Name = "RootBackColorBox"
        Me.RootBackColorBox.Size = New System.Drawing.Size(109, 23)
        Me.RootBackColorBox.TabIndex = 14
        '
        'AutoTabWidthCheck
        '
        Me.AutoTabWidthCheck.AutoSize = True
        Me.AutoTabWidthCheck.Dock = System.Windows.Forms.DockStyle.Fill
        Me.AutoTabWidthCheck.Location = New System.Drawing.Point(148, 55)
        Me.AutoTabWidthCheck.Name = "AutoTabWidthCheck"
        Me.AutoTabWidthCheck.Size = New System.Drawing.Size(49, 20)
        Me.AutoTabWidthCheck.TabIndex = 15
        Me.AutoTabWidthCheck.UseVisualStyleBackColor = True
        '
        'TabsUnderlineSizeUD
        '
        Me.KzTabPanel.SetColumnSpan(Me.TabsUnderlineSizeUD, 2)
        Me.TabsUnderlineSizeUD.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabsUnderlineSizeUD.Location = New System.Drawing.Point(146, 79)
        Me.TabsUnderlineSizeUD.Margin = New System.Windows.Forms.Padding(1)
        Me.TabsUnderlineSizeUD.Maximum = New Decimal(New Integer() {10, 0, 0, 0})
        Me.TabsUnderlineSizeUD.Name = "TabsUnderlineSizeUD"
        Me.TabsUnderlineSizeUD.Size = New System.Drawing.Size(109, 23)
        Me.TabsUnderlineSizeUD.TabIndex = 16
        '
        'OpenUnderlineCheck
        '
        Me.OpenUnderlineCheck.AutoSize = True
        Me.OpenUnderlineCheck.Dock = System.Windows.Forms.DockStyle.Fill
        Me.OpenUnderlineCheck.Location = New System.Drawing.Point(203, 107)
        Me.OpenUnderlineCheck.Name = "OpenUnderlineCheck"
        Me.OpenUnderlineCheck.Size = New System.Drawing.Size(50, 20)
        Me.OpenUnderlineCheck.TabIndex = 17
        Me.OpenUnderlineCheck.UseVisualStyleBackColor = True
        '
        'ShowCloseCheck
        '
        Me.ShowCloseCheck.AutoSize = True
        Me.ShowCloseCheck.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ShowCloseCheck.Location = New System.Drawing.Point(203, 133)
        Me.ShowCloseCheck.Name = "ShowCloseCheck"
        Me.ShowCloseCheck.Size = New System.Drawing.Size(50, 20)
        Me.ShowCloseCheck.TabIndex = 18
        Me.ShowCloseCheck.UseVisualStyleBackColor = True
        '
        'ShowUnselectedCheck
        '
        Me.ShowUnselectedCheck.AutoSize = True
        Me.ShowUnselectedCheck.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ShowUnselectedCheck.Location = New System.Drawing.Point(203, 159)
        Me.ShowUnselectedCheck.Name = "ShowUnselectedCheck"
        Me.ShowUnselectedCheck.Size = New System.Drawing.Size(50, 20)
        Me.ShowUnselectedCheck.TabIndex = 19
        Me.ShowUnselectedCheck.UseVisualStyleBackColor = True
        '
        'ShowAddCheck
        '
        Me.ShowAddCheck.AutoSize = True
        Me.ShowAddCheck.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ShowAddCheck.Location = New System.Drawing.Point(203, 185)
        Me.ShowAddCheck.Name = "ShowAddCheck"
        Me.ShowAddCheck.Size = New System.Drawing.Size(50, 20)
        Me.ShowAddCheck.TabIndex = 20
        Me.ShowAddCheck.UseVisualStyleBackColor = True
        '
        'IgnoreTabCheck
        '
        Me.IgnoreTabCheck.AutoSize = True
        Me.IgnoreTabCheck.Dock = System.Windows.Forms.DockStyle.Fill
        Me.IgnoreTabCheck.Location = New System.Drawing.Point(203, 211)
        Me.IgnoreTabCheck.Name = "IgnoreTabCheck"
        Me.IgnoreTabCheck.Size = New System.Drawing.Size(50, 20)
        Me.IgnoreTabCheck.TabIndex = 21
        Me.IgnoreTabCheck.UseVisualStyleBackColor = True
        '
        'TabControl1
        '
        Me.TabControl1.Alignment = System.Windows.Forms.TabAlignment.Left
        Me.TabControl1.Appearance = System.Windows.Forms.TabAppearance.Buttons
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Multiline = True
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(403, 239)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Location = New System.Drawing.Point(147, 4)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(252, 231)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "TabPage1"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.Location = New System.Drawing.Point(127, 4)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(272, 231)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "TabPage2"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'BottomSpliter
        '
        Me.BottomSpliter.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BottomSpliter.Location = New System.Drawing.Point(0, 0)
        Me.BottomSpliter.Name = "BottomSpliter"
        '
        'BottomSpliter.Panel1
        '
        Me.BottomSpliter.Panel1.Controls.Add(Me.AprsTabs)
        '
        'BottomSpliter.Panel2
        '
        Me.BottomSpliter.Panel2.Controls.Add(Me.AprTabs)
        Me.BottomSpliter.Size = New System.Drawing.Size(663, 213)
        Me.BottomSpliter.SplitterDistance = 307
        Me.BottomSpliter.TabIndex = 0
        '
        'AprTabs
        '
        Me.AprTabs.AutoTabWidth = True
        Me.AprTabs.BtnAppearances = Nothing
        Me.AprTabs.Dock = System.Windows.Forms.DockStyle.Fill
        Me.AprTabs.IgnorePrivateTabSetting = True
        Me.AprTabs.Location = New System.Drawing.Point(0, 0)
        Me.AprTabs.Name = "AprTabs"
        Me.AprTabs.NewTitlePrefix = "New"
        Me.AprTabs.OpenSelectedTabUnderline = False
        Me.AprTabs.RootBackColor = System.Drawing.SystemColors.Control
        Me.AprTabs.SelectAfterAdd = True
        Me.AprTabs.SelectedIndex = 0
        Me.AprTabs.ShowCloseButtonOnTab = True
        Me.AprTabs.ShowCloseOnUnselectedTabs = False
        Me.AprTabs.Size = New System.Drawing.Size(352, 213)
        Me.AprTabs.TabAppearances = Nothing
        Me.AprTabs.TabIndex = 0
        Me.AprTabs.TabsUnderlineSize = 0
        '
        'AprsTabs
        '
        Me.AprsTabs.AutoTabWidth = True
        Me.AprsTabs.BtnAppearances = Nothing
        Me.AprsTabs.Dock = System.Windows.Forms.DockStyle.Fill
        Me.AprsTabs.IgnorePrivateTabSetting = True
        Me.AprsTabs.Location = New System.Drawing.Point(0, 0)
        Me.AprsTabs.Name = "AprsTabs"
        Me.AprsTabs.NewTitlePrefix = "New"
        Me.AprsTabs.OpenSelectedTabUnderline = False
        Me.AprsTabs.RootBackColor = System.Drawing.SystemColors.Control
        Me.AprsTabs.SelectAfterAdd = True
        Me.AprsTabs.SelectedIndex = 0
        Me.AprsTabs.ShowCloseButtonOnTab = True
        Me.AprsTabs.ShowCloseOnUnselectedTabs = False
        Me.AprsTabs.Size = New System.Drawing.Size(307, 213)
        Me.AprsTabs.TabAppearances = Nothing
        Me.AprsTabs.TabIndex = 0
        Me.AprsTabs.TabsUnderlineSize = 0
        '
        'KzAprsDialog
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(663, 456)
        Me.Controls.Add(Me.RootSpliter)
        Me.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "KzAprsDialog"
        Me.Text = "KzAprsDialog"
        Me.RootSpliter.Panel1.ResumeLayout(False)
        Me.RootSpliter.Panel2.ResumeLayout(False)
        CType(Me.RootSpliter, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RootSpliter.ResumeLayout(False)
        Me.TopSpliter.Panel1.ResumeLayout(False)
        Me.TopSpliter.Panel2.ResumeLayout(False)
        CType(Me.TopSpliter, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TopSpliter.ResumeLayout(False)
        Me.KzTabPanel.ResumeLayout(False)
        Me.KzTabPanel.PerformLayout()
        CType(Me.TabsUnderlineSizeUD, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.BottomSpliter.Panel1.ResumeLayout(False)
        Me.BottomSpliter.Panel2.ResumeLayout(False)
        CType(Me.BottomSpliter, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BottomSpliter.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents RootSpliter As SplitContainer
    Friend WithEvents TopSpliter As SplitContainer
    Friend WithEvents BottomSpliter As SplitContainer
    Friend WithEvents AprTabs As KzTabControl
    Friend WithEvents KzTabPanel As TableLayoutPanel
    Friend WithEvents TabTitleLabel As Label
    Friend WithEvents TabsUSLabel As Label
    Friend WithEvents RootBCLabel As Label
    Friend WithEvents ShowAOSTLabel As Label
    Friend WithEvents IgnorePTSLabel As Label
    Friend WithEvents ShowCBOTLabel As Label
    Friend WithEvents ShowCOUTLabel As Label
    Friend WithEvents OpenSTULabel As Label
    Friend WithEvents AutoTWLabel As Label
    Friend WithEvents RootBackColorBox As TextBox
    Friend WithEvents AutoTabWidthCheck As CheckBox
    Friend WithEvents TabsUnderlineSizeUD As NumericUpDown
    Friend WithEvents OpenUnderlineCheck As CheckBox
    Friend WithEvents ShowCloseCheck As CheckBox
    Friend WithEvents ShowUnselectedCheck As CheckBox
    Friend WithEvents ShowAddCheck As CheckBox
    Friend WithEvents IgnoreTabCheck As CheckBox
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents AprsTabs As KzTabControl
End Class
