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
        Me.BottomSpliter = New System.Windows.Forms.SplitContainer()
        Me.KzTabs = New KzLibrary.KzTabControl()
        Me.KzApPanel = New System.Windows.Forms.TableLayoutPanel()
        CType(Me.RootSpliter, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RootSpliter.Panel1.SuspendLayout()
        Me.RootSpliter.Panel2.SuspendLayout()
        Me.RootSpliter.SuspendLayout()
        CType(Me.TopSpliter, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TopSpliter.Panel1.SuspendLayout()
        Me.TopSpliter.SuspendLayout()
        CType(Me.BottomSpliter, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BottomSpliter.Panel1.SuspendLayout()
        Me.BottomSpliter.SuspendLayout()
        Me.SuspendLayout()
        '
        'RootSpliter
        '
        Me.RootSpliter.Dock = System.Windows.Forms.DockStyle.Fill
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
        Me.RootSpliter.Size = New System.Drawing.Size(518, 370)
        Me.RootSpliter.SplitterDistance = 172
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
        Me.TopSpliter.Panel1.Controls.Add(Me.KzApPanel)
        Me.TopSpliter.Size = New System.Drawing.Size(518, 172)
        Me.TopSpliter.SplitterDistance = 241
        Me.TopSpliter.TabIndex = 0
        '
        'BottomSpliter
        '
        Me.BottomSpliter.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BottomSpliter.Location = New System.Drawing.Point(0, 0)
        Me.BottomSpliter.Name = "BottomSpliter"
        '
        'BottomSpliter.Panel1
        '
        Me.BottomSpliter.Panel1.Controls.Add(Me.KzTabs)
        Me.BottomSpliter.Size = New System.Drawing.Size(518, 194)
        Me.BottomSpliter.SplitterDistance = 241
        Me.BottomSpliter.TabIndex = 0
        '
        'KzTabs
        '
        Me.KzTabs.AutoTabWidth = True
        Me.KzTabs.BtnAppearances = Nothing
        Me.KzTabs.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KzTabs.IgnorePrivateTabSetting = True
        Me.KzTabs.Location = New System.Drawing.Point(0, 0)
        Me.KzTabs.Name = "KzTabs"
        Me.KzTabs.NewTitlePrefix = "New"
        Me.KzTabs.OpenSelectedTabUnderline = False
        Me.KzTabs.RootBackColor = System.Drawing.SystemColors.Control
        Me.KzTabs.SelectAfterAdd = True
        Me.KzTabs.SelectedIndex = 0
        Me.KzTabs.ShowCloseButtonOnTab = True
        Me.KzTabs.ShowCloseOnUnselectedTabs = False
        Me.KzTabs.Size = New System.Drawing.Size(241, 194)
        Me.KzTabs.TabAppearances = Nothing
        Me.KzTabs.TabIndex = 0
        Me.KzTabs.TabsUnderlineSize = 0
        '
        'KzApPanel
        '
        Me.KzApPanel.ColumnCount = 2
        Me.KzApPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.KzApPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.KzApPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KzApPanel.Location = New System.Drawing.Point(0, 0)
        Me.KzApPanel.Name = "KzApPanel"
        Me.KzApPanel.RowCount = 2
        Me.KzApPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.KzApPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.KzApPanel.Size = New System.Drawing.Size(241, 172)
        Me.KzApPanel.TabIndex = 0
        '
        'KzAprsDialog
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(518, 370)
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
        CType(Me.TopSpliter, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TopSpliter.ResumeLayout(False)
        Me.BottomSpliter.Panel1.ResumeLayout(False)
        CType(Me.BottomSpliter, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BottomSpliter.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents RootSpliter As SplitContainer
    Friend WithEvents TopSpliter As SplitContainer
    Friend WithEvents BottomSpliter As SplitContainer
    Friend WithEvents KzTabs As KzTabControl
    Friend WithEvents KzApPanel As TableLayoutPanel
End Class
