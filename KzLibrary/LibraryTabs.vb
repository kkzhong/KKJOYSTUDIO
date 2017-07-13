Imports System.IO
Imports System.Drawing.Drawing2D

Public Class KzTabControl
    Inherits TabControl

    'Dim CloseButtonClicked As Boolean
    Dim iCloseBounds As Rectangle
    Dim iMouseOnIndex As Integer = -1
    Dim iMinTabWidth As Integer = 64

    Public Sub Initialize()
        Me.DrawMode = TabDrawMode.OwnerDrawFixed
        Me.SizeMode = TabSizeMode.Fixed        '// 选项卡大小模式
        Me.ItemSize = New Size(128, 24)         '// 选项卡大小（如果 SizeMode 选择了 Fixed）

        MyBase.SetStyle(ControlStyles.UserPaint Or          '// 控件将自行绘制，而不是通过操作系统来绘制
            ControlStyles.OptimizedDoubleBuffer Or          '// 该控件首先在缓冲区中绘制，而不是直接绘制到屏幕上，这样可以减少闪烁
            ControlStyles.AllPaintingInWmPaint Or           '// 控件将忽略 WM_ERASEBKGND 窗口消息以减少闪烁
            ControlStyles.ResizeRedraw Or                   '// 在调整控件大小时重绘控件
            ControlStyles.SupportsTransparentBackColor,     '// 控件接受 alpha 组件小于 255 的 BackColor 以模拟透明
            True)                                           '// 设置以上值为 true
        MyBase.UpdateStyles()

    End Sub

#Region "StyleProperties"
    'Public Property RootBackColor As Color = SystemColors.Control 'TabControl整體之背景色
    'Public Property AutoTabWidth As Boolean = True '自動調整Tab寬度
    'Public Property TabsUnderlineSize As Integer = 0
    'Public Property OpenSelectedTabUnderline As Boolean = False '
    'Public Property ShowCloseButtonOnTab As Boolean = True '
    'Public Property ShowCloseOnUnselectedTabs As Boolean = False
    'Public Property ShowAddOnSelectedTab As Boolean = False

    Public Property TabDesignSet As KzTabDesignSet
    'Public Property TabNormalAppearances As KzAppearances
    'Public Property BtnNormalAppearances As KzAppearances
    'Public Property TabSelectedAppearances As KzAppearances
    'Public Property BtnSelectedAppearances As KzAppearances

    'Public Property IgnorePrivateTabSetting As Boolean = True
    'IgnorePrivateTabSetting = False，將使用Tab定義的 TabStyle, ButtonStyle, ShowCloseButton, ShowCloseUnselected


#End Region 'StyleProperties

#Region "FunctionProperties"
    Public Property NewTitlePrefix As String = "New"
    Public Property SelectAfterAdd As Boolean = True

    Public ReadOnly Property NewSerialNumber As Integer
        Get
            Dim newStr As String
            If Me.NewTitlePrefix Is Nothing Then ' Or Me.NewTitlePrefix = "" Then
                newStr = ""
            Else
                newStr = Me.NewTitlePrefix
            End If

            Dim i As Integer = 0

            For Each tp As TabPage In Me.TabPages
                If tp.Text.StartsWith(newStr) Then
                    Dim x As Integer
                    Try
                        x = CInt(tp.Text.Substring(Me.NewTitlePrefix.Length))
                    Catch ex As Exception
                        x = 0
                    End Try

                    i = Math.Max(i, x)
                End If
            Next

            Return i + 1
        End Get
    End Property
#End Region 'FunctionProperties

#Region "PaintingMethods"
    Protected Overrides Sub OnPaint(e As PaintEventArgs)
        MyBase.OnPaint(e)
        Dim g As Graphics = e.Graphics

        g.SmoothingMode = SmoothingMode.AntiAlias '开启抗锯齿
        g.InterpolationMode = InterpolationMode.HighQualityBilinear '开启高质量插补模式
        g.TextRenderingHint = Drawing.Text.TextRenderingHint.ClearTypeGridFit '开启文字 ClearType

        g.FillRectangle(New SolidBrush(Me.TabDesignSet.RootBackColor), Me.ClientRectangle) '绘制 TabControl 整体背景色



    End Sub
#End Region 'PaintingMethods

#Region "PublicMethods"
    Public Sub SetTabWidth()
        If Not Me.TabDesignSet.AutoTabWidth Then Exit Sub

        If Me.TabCount > 0 Then
            Try
                Dim ItemWidth As Integer = Me.ItemSize.Width
                Dim ValidFullWidth As Integer = Me.ClientRectangle.Width - 20

                Dim ExpectedItemNumbers As Integer
                Select Case ValidFullWidth
                    Case Is < 400 : ExpectedItemNumbers = 3
                    Case 400 To 600 : ExpectedItemNumbers = 4
                    Case 600 To 800 : ExpectedItemNumbers = 5
                    Case 800 To 1000 : ExpectedItemNumbers = 6
                    Case 1000 To 1200 : ExpectedItemNumbers = 7
                    Case 1200 To 1800 : ExpectedItemNumbers = 8
                    Case Is > 1800 : ExpectedItemNumbers = 10
                End Select

                Dim SuitableWidth As Integer = CInt(ValidFullWidth / ExpectedItemNumbers)

                If ItemWidth * Me.TabCount <= ValidFullWidth And
                    SuitableWidth * Me.TabCount <= ValidFullWidth Then

                    ItemWidth = Math.Max(ItemWidth, SuitableWidth)

                ElseIf ItemWidth * Me.TabCount > ValidFullWidth And
                    SuitableWidth * Me.TabCount <= ValidFullWidth Then

                    ItemWidth = SuitableWidth

                ElseIf ItemWidth * Me.TabCount > ValidFullWidth And
                    SuitableWidth * Me.TabCount > ValidFullWidth Then

                    ItemWidth = Math.Max(CInt(ValidFullWidth / TabCount), iMinTabWidth)
                End If

                Me.ItemSize = New Size(ItemWidth, 24)
            Catch ex As Exception
            End Try
        End If
    End Sub

    Public Sub RemoveTab(moveTo As KzItemPosition, Optional tp As TabPage = Nothing)
        With Me
            If tp Is Nothing Then ' Or tp.Equals(Me.SelectedTab) Then
                If .TabCount > 1 Then
                    Dim iOldSelected As Integer = .SelectedIndex

                    .TabPages.Remove(.SelectedTab)

                    Select Case moveTo
                        Case KzItemPosition.None
                            .SelectedIndex = -1
                        Case KzItemPosition.PreviousItem
                            If iOldSelected = 0 Then
                                .SelectedIndex = 0
                            Else
                                .SelectedIndex = iOldSelected - 1
                            End If
                        Case KzItemPosition.NextItem
                            If iOldSelected > .TabPages.Count - 1 Then
                                .SelectedIndex = .TabPages.Count - 1
                            Else
                                .SelectedIndex = iOldSelected
                            End If
                        Case KzItemPosition.LastItem
                            .SelectedIndex = .TabPages.Count - 1
                    End Select
                ElseIf .TabCount = 1 Then
                    .TabPages.Clear()
                End If
            Else
                If Not tp.Equals(Me.SelectedTab) Then
                    .TabPages.Remove(tp)
                Else
                    Me.RemoveTab(moveTo)
                End If
            End If

        End With

        SetTabWidth()
    End Sub

    Public Sub AddTab(addTo As KzItemPosition, Optional tp As TabPage = Nothing, Optional idx As Integer = -1)
        With Me
            Dim newTab As TabPage
            If tp Is Nothing Then
                newTab = New TabPage
            Else
                newTab = tp
            End If

            If newTab.Text Is Nothing Or newTab.Text = "" Then
                newTab.Text = .NewTitlePrefix & Strings.Format(.NewSerialNumber(), "00")
                newTab.ToolTipText = newTab.Text
            Else
                newTab.ToolTipText = newTab.Text
            End If

            If idx = -1 Then
                Dim toIndex As Integer
                If .TabPages.Count > 0 Then
                    Select Case addTo
                        Case KzItemPosition.FirstItem
                            toIndex = 0
                        Case KzItemPosition.PreviousItem, KzItemPosition.Current
                            toIndex = .SelectedIndex
                        Case KzItemPosition.NextItem
                            If .SelectedIndex = .TabPages.Count - 1 Then
                                toIndex = -1
                            Else
                                toIndex = .SelectedIndex + 1
                            End If
                        Case Else
                            toIndex = -1
                    End Select
                Else
                    toIndex = -1
                End If

                If toIndex = -1 Then
                    .TabPages.Add(newTab)
                Else
                    .TabPages.Insert(toIndex, newTab)
                End If

            Else
                Try
                    .TabPages.Insert(idx, newTab)
                Catch ex As Exception
                    .AddTab(addTo, tp)
                End Try
            End If

            If Me.SelectAfterAdd Then
                .SelectedTab = newTab
            End If
        End With

        SetTabWidth()
    End Sub

#End Region 'PublicMethods

End Class


Public Class KzAprsTab
    Inherits TabPage

    Dim Aprs() As String = {
        "Name", "BorderRadius", "ShadowWidth", "ShadowShift", "FontFamily", "FontSize"}
    Dim Apr() As String = {
        "BorderSize", "BorderColor", "BackColor", "ForeLineSize", "ForeColor", "ShadowDirection", "ShadowColor", "FontStyle"}
    Dim fSizes() As Single = {
        5, 5.5, 6.5, 7.5, 8, 9, 10, 10.5, 11, 12,
        14, 16, 18, 20, 22, 24, 26, 28, 36, 48, 72}
    Dim iApr As KzAppearance
    Dim iAprs As KzAppearances
    Dim iStatus As Boolean

    Friend WithEvents RootPanel As TableLayoutPanel
    Friend WithEvents ResetDefaultButton As Button
    Friend WithEvents TitleLabel As Label

    Friend WithEvents NameTBox As TextBox
    Friend WithEvents BorderRadiusUD As NumericUpDown
    Friend WithEvents ShadowWidthUD As NumericUpDown
    Friend WithEvents ShadowShiftCheck As CheckBox
    Friend WithEvents FontFamilyTBox As TextBox
    Friend WithEvents FontStyleCBox As ComboBox
    Friend WithEvents FontSizeCBox As ComboBox

    Friend WithEvents BorderSizeUpDown As NumericUpDown
    Friend WithEvents BorderColorTBox As TextBox
    Friend WithEvents BackColorTBox As TextBox
    Friend WithEvents ForeLineSizeUpDown As NumericUpDown
    Friend WithEvents ForeColorTBox As TextBox
    Friend WithEvents ShadowDirectionCBox As ComboBox
    Friend WithEvents ShadowColorTBox As TextBox

    Private Sub InitializeComponent()
        Me.RootPanel = New System.Windows.Forms.TableLayoutPanel()
        Me.TitleLabel = New System.Windows.Forms.Label()
        Me.ResetDefaultButton = New System.Windows.Forms.Button()

        Me.BorderSizeUpDown = New System.Windows.Forms.NumericUpDown()
        Me.BorderColorTBox = New System.Windows.Forms.TextBox()
        Me.BackColorTBox = New System.Windows.Forms.TextBox()
        Me.ForeLineSizeUpDown = New System.Windows.Forms.NumericUpDown()
        Me.ForeColorTBox = New System.Windows.Forms.TextBox()
        Me.ShadowDirectionCBox = New System.Windows.Forms.ComboBox()
        Me.ShadowColorTBox = New System.Windows.Forms.TextBox()

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
        CType(Me.BorderSizeUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ForeLineSizeUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RootPanel
        '
        Me.RootPanel.ColumnCount = 3
        Me.RootPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120.0!))
        Me.RootPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.RootPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.RootPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RootPanel.Location = New System.Drawing.Point(0, 0)
        Me.RootPanel.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.RootPanel.Name = "RootPanel"
        Me.RootPanel.RowCount = 10
        Me.RootPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26.0!))
        Me.RootPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26.0!))
        Me.RootPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26.0!))
        Me.RootPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26.0!))
        Me.RootPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26.0!))
        Me.RootPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26.0!))
        Me.RootPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26.0!))
        Me.RootPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26.0!))
        Me.RootPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26.0!))
        Me.RootPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.RootPanel.Size = New System.Drawing.Size(277, 253)
        Me.RootPanel.TabIndex = 0
        '
        'TitleLabel
        '
        Me.TitleLabel.AutoSize = True
        Me.RootPanel.SetColumnSpan(Me.TitleLabel, 2)
        Me.TitleLabel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TitleLabel.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.TitleLabel.Location = New System.Drawing.Point(3, 0)
        Me.TitleLabel.Name = "TitleLabel"
        Me.TitleLabel.Size = New System.Drawing.Size(192, 26)
        Me.TitleLabel.TabIndex = 7
        Me.TitleLabel.Text = "Title"
        Me.TitleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.RootPanel.Controls.Add(Me.TitleLabel, 0, 0)
        '
        'ResetDefaultButton
        '
        Me.ResetDefaultButton.Dock = System.Windows.Forms.DockStyle.Right
        Me.ResetDefaultButton.Location = New System.Drawing.Point(253, 1)
        Me.ResetDefaultButton.Margin = New System.Windows.Forms.Padding(1)
        Me.ResetDefaultButton.Name = "ResetDefaultButton"
        Me.ResetDefaultButton.Size = New System.Drawing.Size(23, 24)
        Me.ResetDefaultButton.TabIndex = 15
        Me.ResetDefaultButton.Text = "R"
        Me.ResetDefaultButton.UseVisualStyleBackColor = True
        Me.RootPanel.Controls.Add(Me.ResetDefaultButton, 2, 0)

        Dim l As Label
        Dim ub As Integer = If(iStatus, 7, 5)
        For i As Integer = 0 To ub
            l = New Label With {
                .AutoSize = True,
                .Dock = System.Windows.Forms.DockStyle.Fill,
                .Location = New System.Drawing.Point(3, (i + 1) * 26),
                .Name = If(iStatus, Apr(i), Aprs(i)) & "Label",
                .Size = New System.Drawing.Size(114, 26),
                .Text = If(iStatus, Apr(i), Aprs(i)),
                .TextAlign = System.Drawing.ContentAlignment.MiddleRight}
            Me.RootPanel.Controls.Add(l, 0, (i + 1))
        Next

        If iStatus Then
            '
            'BorderSizeUpDown
            '
            Me.BorderSizeUpDown.Dock = System.Windows.Forms.DockStyle.Fill
            Me.BorderSizeUpDown.Location = New System.Drawing.Point(121, 27)
            Me.BorderSizeUpDown.Margin = New System.Windows.Forms.Padding(1)
            Me.BorderSizeUpDown.Maximum = New Decimal(New Integer() {10, 0, 0, 0})
            Me.BorderSizeUpDown.Name = "BorderSizeUpDown"
            Me.BorderSizeUpDown.Size = New System.Drawing.Size(76, 23)
            Me.BorderSizeUpDown.TabIndex = 8
            Me.BorderSizeUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
            Me.RootPanel.Controls.Add(Me.BorderSizeUpDown, 1, 1)
            '
            'BorderColorTBox
            '
            Me.RootPanel.SetColumnSpan(Me.BorderColorTBox, 2)
            Me.BorderColorTBox.Dock = System.Windows.Forms.DockStyle.Fill
            Me.BorderColorTBox.Location = New System.Drawing.Point(121, 53)
            Me.BorderColorTBox.Margin = New System.Windows.Forms.Padding(1)
            Me.BorderColorTBox.Name = "BorderColorTBox"
            Me.BorderColorTBox.Size = New System.Drawing.Size(155, 23)
            Me.BorderColorTBox.TabIndex = 9
            Me.RootPanel.Controls.Add(Me.BorderColorTBox, 1, 2)
            '
            'BackColorTBox
            '
            Me.RootPanel.SetColumnSpan(Me.BackColorTBox, 2)
            Me.BackColorTBox.Dock = System.Windows.Forms.DockStyle.Fill
            Me.BackColorTBox.Location = New System.Drawing.Point(121, 79)
            Me.BackColorTBox.Margin = New System.Windows.Forms.Padding(1)
            Me.BackColorTBox.Name = "BackColorTBox"
            Me.BackColorTBox.Size = New System.Drawing.Size(155, 23)
            Me.BackColorTBox.TabIndex = 10
            Me.RootPanel.Controls.Add(Me.BackColorTBox, 1, 3)
            '
            'ForeLineSizeUpDown
            '
            Me.ForeLineSizeUpDown.Dock = System.Windows.Forms.DockStyle.Fill
            Me.ForeLineSizeUpDown.Location = New System.Drawing.Point(121, 105)
            Me.ForeLineSizeUpDown.Margin = New System.Windows.Forms.Padding(1)
            Me.ForeLineSizeUpDown.Maximum = New Decimal(New Integer() {10, 0, 0, 0})
            Me.ForeLineSizeUpDown.Name = "ForeLineSizeUpDown"
            Me.ForeLineSizeUpDown.Size = New System.Drawing.Size(76, 23)
            Me.ForeLineSizeUpDown.TabIndex = 11
            Me.ForeLineSizeUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
            Me.RootPanel.Controls.Add(Me.ForeLineSizeUpDown, 1, 4)
            '
            'ForeColorTBox
            '
            Me.RootPanel.SetColumnSpan(Me.ForeColorTBox, 2)
            Me.ForeColorTBox.Dock = System.Windows.Forms.DockStyle.Fill
            Me.ForeColorTBox.Location = New System.Drawing.Point(121, 131)
            Me.ForeColorTBox.Margin = New System.Windows.Forms.Padding(1)
            Me.ForeColorTBox.Name = "ForeColorTBox"
            Me.ForeColorTBox.Size = New System.Drawing.Size(155, 23)
            Me.ForeColorTBox.TabIndex = 12
            Me.RootPanel.Controls.Add(Me.ForeColorTBox, 1, 5)
            '
            'ShadowDirectionCBox
            '
            Me.RootPanel.SetColumnSpan(Me.ShadowDirectionCBox, 2)
            Me.ShadowDirectionCBox.Dock = System.Windows.Forms.DockStyle.Fill
            Me.ShadowDirectionCBox.FormattingEnabled = True
            Me.ShadowDirectionCBox.Location = New System.Drawing.Point(121, 156)
            Me.ShadowDirectionCBox.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
            Me.ShadowDirectionCBox.Name = "ShadowDirectionCBox"
            Me.ShadowDirectionCBox.Size = New System.Drawing.Size(155, 25)
            Me.ShadowDirectionCBox.TabIndex = 13
            With ShadowDirectionCBox
                ub = [Enum].GetNames(GetType(KzSidePosition)).Count - 1
                For i As Integer = 0 To ub
                    .Items.Add(CType(i, KzSidePosition))
                Next
            End With
            Me.RootPanel.Controls.Add(Me.ShadowDirectionCBox, 1, 6)
            '
            'ShadowColorTBox
            '
            Me.RootPanel.SetColumnSpan(Me.ShadowColorTBox, 2)
            Me.ShadowColorTBox.Dock = System.Windows.Forms.DockStyle.Fill
            Me.ShadowColorTBox.Location = New System.Drawing.Point(121, 183)
            Me.ShadowColorTBox.Margin = New System.Windows.Forms.Padding(1)
            Me.ShadowColorTBox.Name = "ShadowColorTBox"
            Me.ShadowColorTBox.Size = New System.Drawing.Size(155, 23)
            Me.ShadowColorTBox.TabIndex = 14
            Me.RootPanel.Controls.Add(Me.ShadowColorTBox, 1, 7)
            '
            'FontStyleCBox
            '
            Me.RootPanel.SetColumnSpan(Me.FontStyleCBox, 2)
            Me.FontStyleCBox.Dock = System.Windows.Forms.DockStyle.Fill
            Me.FontStyleCBox.FormattingEnabled = True
            Me.FontStyleCBox.Location = New System.Drawing.Point(101, 156)
            Me.FontStyleCBox.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
            Me.FontStyleCBox.Name = "FontStyleCBox"
            Me.FontStyleCBox.Size = New System.Drawing.Size(88, 25)
            Me.FontStyleCBox.TabIndex = 16
            With FontStyleCBox
                ub = [Enum].GetNames(GetType(FontStyle)).Count - 1
                For i As Integer = 0 To ub
                    .Items.Add(CType(i, FontStyle))
                Next
                .DropDownWidth = 160
                .SelectedIndex = 0
            End With
            Me.RootPanel.Controls.Add(Me.FontStyleCBox, 1, 8)
        Else
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
            Me.RootPanel.Controls.Add(Me.NameTBox, 1, 1)
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
            Me.RootPanel.Controls.Add(Me.BorderRadiusUD, 1, 2)
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
            Me.RootPanel.Controls.Add(Me.ShadowWidthUD, 1, 3)
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
            Me.RootPanel.Controls.Add(Me.ShadowShiftCheck, 1, 4)
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
            Me.RootPanel.Controls.Add(Me.FontFamilyTBox, 1, 5)
            '
            'FontSizeCBox
            '
            Me.FontSizeCBox.Dock = System.Windows.Forms.DockStyle.Fill
            Me.FontSizeCBox.FormattingEnabled = True
            Me.FontSizeCBox.Location = New System.Drawing.Point(101, 182)
            Me.FontSizeCBox.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
            Me.FontSizeCBox.Name = "FontSizeCBox"
            Me.FontSizeCBox.Size = New System.Drawing.Size(178, 25)
            Me.FontSizeCBox.TabIndex = 17
            With FontSizeCBox
                For i As Integer = 0 To fSizes.GetUpperBound(0)
                    .Items.Add(fSizes(i))
                Next
                .SelectedIndex = 7
            End With
            Me.RootPanel.Controls.Add(Me.FontSizeCBox, 1, 6)
        End If
        '
        'KzAprsTab
        '
        Me.Controls.Add(Me.RootPanel)
        Me.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "KzAprsTab"
        Me.Size = New System.Drawing.Size(280, 250)
        Me.RootPanel.ResumeLayout(False)
        Me.RootPanel.PerformLayout()
        CType(Me.BorderRadiusUD, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ShadowWidthUD, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BorderSizeUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ForeLineSizeUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
    End Sub

    Public Sub New(Optional ByStatus As Boolean = True)
        iStatus = ByStatus
        InitializeComponent()
    End Sub

    Public Property AObject As Object
        Get
            If iStatus Then
                Return iApr
            Else
                Return iAprs
            End If
        End Get
        Set(value As Object)
            If iStatus And value.GetType = GetType(KzAppearance) Then
                iApr = value
            ElseIf Not iStatus And value.GetType = GetType(KzAppearances) Then
                iAprs = value
            End If
            ObjectToUI()
        End Set
    End Property

    Private Sub ObjectToUI()
        If iStatus Then
            BorderSizeUpDown.Value = iApr.BorderSize
            BorderColorTBox.Text = GetColorName(iApr.BorderColor)
            BackColorTBox.Text = GetColorName(iApr.BackColor)
            ForeLineSizeUpDown.Value = iApr.ForeLineSize
            ForeColorTBox.Text = GetColorName(iApr.ForeColor)
            ShadowDirectionCBox.SelectedItem = iApr.ShadowDirection
            ShadowColorTBox.Text = GetColorName(iApr.ShadowColor)
            FontStyleCBox.SelectedItem = iApr.FontStyle
        Else
            NameTBox.Text = iAprs.Name
            BorderRadiusUD.Value = iAprs.BorderRadius
            ShadowWidthUD.Value = iAprs.ShadowWidth
            ShadowShiftCheck.Checked = iAprs.ShadowShift
            FontFamilyTBox.Text = iAprs.FontFamily.Name
            FontSizeCBox.SelectedItem = iAprs.FontSize
        End If

    End Sub

    Private Sub UItoObject()
        If iStatus Then
            With iApr
                .BorderSize = BorderSizeUpDown.Value
                .BorderColor = GetColor(BorderColorTBox.Text)
                .BackColor = GetColor(BackColorTBox.Text)
                .ForeLineSize = ForeLineSizeUpDown.Value
                .ForeColor = GetColor(ForeColorTBox.Text)
                .ShadowDirection = ShadowDirectionCBox.SelectedItem
                .ShadowColor = GetColor(ShadowColorTBox.Text)
                .FontStyle = FontSizeCBox.SelectedItem
            End With
        Else
            With iAprs
                .Name = NameTBox.Text
                .BorderRadius = BorderRadiusUD.Value
                .ShadowWidth = ShadowWidthUD.Value
                .ShadowShift = ShadowShiftCheck.Checked
                .FontFamily = New FontFamily(FontFamilyTBox.Text)
                .FontSize = FontSizeCBox.SelectedItem
            End With
        End If
    End Sub

    Private Function GetColorName(color As Color) As String
        If color.IsEmpty Then
            Return "[Empty]"
        ElseIf color.IsNamedColor Then
            Return color.Name
        Else
            Return ("&H" & Hex(color.ToArgb)).ToUpper
        End If
    End Function

    Private Function GetColor(name As String) As Color
        Try
            If name.StartsWith("&H") Then
                Return Color.FromArgb(name)
            Else
                Return Color.FromName(name)
            End If
        Catch ex As Exception
            Return Color.FromArgb(0)
        End Try
    End Function
End Class

