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

        ResetFaceStyle()
    End Sub

#Region "StyleProperties"
    Public Property RootBackColor As Color = SystemColors.Control 'TabControl整體之背景色
    Public Property AutoTabWidth As Boolean = True '自動調整Tab寬度
    Public Property TabsUnderlineSize As Integer = 0
    Public Property OpenSelectedTabUnderline As Boolean = False '
    Public Property ShowCloseButtonOnTab As Boolean = True '
    Public Property ShowCloseOnUnselectedTabs As Boolean = False

    Public Property TabAppearances As KzAppearances
    Public Property BtnAppearances As KzAppearances

    Public Property IgnorePrivateTabSetting As Boolean = True
    'IgnorePrivateTabSetting = False，將使用Tab定義的 TabStyle, ButtonStyle, ShowCloseButton, ShowCloseUnselected

    Public Sub ResetFaceStyle()


    End Sub
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
        g.FillRectangle(New SolidBrush(Me.RootBackColor), Me.ClientRectangle) '绘制 TabControl 整体背景色



    End Sub
#End Region 'PaintingMethods

#Region "PublicMethods"
    Public Sub SetTabWidth()
        If Not AutoTabWidth Then Exit Sub

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


Public Class KzDrawingStyleCollection
    Inherits List(Of KzDrawingStyle)

    Public Overloads Sub AddRange(styles As IEnumerable(Of KzDrawingStyle), replace As Boolean)
        For Each style In styles
            Me.Add(style, replace)
        Next
    End Sub

    Public Overloads Sub Add(item As KzDrawingStyle, replace As Boolean)
        Dim go As Boolean = True
        Dim rs As KzDrawingStyle = GetStyle(item.Type)

        If Not rs.Equals(Nothing) Then
            If replace Then
                Me.Remove(rs)
            Else
                go = False
            End If
        End If

        'If Me.Count > 0 Then
        '    For Each style As KzDrawingStyle In Me
        '        If style.Type = item.Type And
        '            item.Type <> KzControlStatus.None Then

        '            If replace Then
        '                Me.Remove(style)
        '            Else
        '                go = False
        '            End If
        '            Exit For
        '        End If
        '    Next
        'End If

        If go Then
            Me.Add(item)
        End If
    End Sub

    Public Overloads Function Contains(styleStatus As KzControlStatus) As Boolean
        For Each item As KzDrawingStyle In Me
            If item.Type = styleStatus Then
                Return True
                Exit For
            End If
        Next

        Return False
    End Function

    Public Function GetStyle(status As KzControlStatus) As KzDrawingStyle
        If Me.Count > 0 Then
            For Each item As KzDrawingStyle In Me
                If item.Type = status Then
                    Return item
                    Exit For
                End If
            Next
        End If

        Return Nothing
    End Function
End Class 'KzDrawingStyleCollection

Public Class KzTripleStyles
    Public Property Normal As KzDrawingStyle
    Public Property Hover As KzDrawingStyle
    Public Property Pressed As KzDrawingStyle
End Class 'KzTripleStyles

Public Structure KzDrawingStyle
    Public Sub New(type As KzControlStatus)
        Me.Type = type
        Me.FrameWidth = 0
        Me.FrameColor = SystemColors.ActiveBorder
        Me.LineWidth = 1
        Me.LineColor = SystemColors.ControlDarkDark
        Me.FillColor = SystemColors.Control
        Me.FontColor = SystemColors.ControlText
        Me.FontName = SystemFonts.DefaultFont.FontFamily
        Me.FontSize = SystemFonts.DefaultFont.Size
        Me.FontStyle = SystemFonts.DefaultFont.Style
        Me.ShadowWidth = 0
        Me.ShadowColor = SystemColors.ButtonShadow
        Me.Radius = 0
    End Sub

    Public Property Type As KzControlStatus
    Public Property Radius As Integer
    Public Property FrameWidth As Integer
    Public Property FrameColor As Color
    Public Property LineWidth As Integer
    Public Property LineColor As Color
    Public Property FillColor As Color
    Public Property InnerColor As Color
    Public Property ShadowWidth As Integer
    Public Property ShadowColor As Color
    Public Property FontColor As Color
    Public Property FontName As FontFamily
    Public Property FontSize As Single
    Public Property FontStyle As FontStyle

    Public ReadOnly Property Font As Font
        Get
            Try
                Return New Font(Me.FontName, Me.FontSize, Me.FontStyle)
            Catch ex As Exception
                Return SystemFonts.DefaultFont
            End Try
        End Get
    End Property

    Public ReadOnly Property FramePen As Pen
        Get
            Return New Pen(Me.FrameColor, Me.FrameWidth)
        End Get
    End Property

    Public ReadOnly Property InnerPen As Pen
        Get
            Return New Pen(Me.LineColor, Me.LineWidth)
        End Get
    End Property

    Public ReadOnly Property FillBrush As Brush
        Get
            Return New SolidBrush(Me.FillColor)
        End Get
    End Property

    Public ReadOnly Property InnerFillBrush As Brush
        Get
            Return New SolidBrush(Me.InnerColor)
        End Get
    End Property

    Public ReadOnly Property FontBrush As Brush
        Get
            Return New SolidBrush(Me.FontColor)
        End Get
    End Property

    Public ReadOnly Property ShadowFillBrush As Brush
        Get
            Return New SolidBrush(Me.ShadowColor)
        End Get
    End Property
End Structure 'KzDrawingStyle



Public Class KzAppearancesTab
    Inherits TabPage

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
        Me.RootPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120.0!))
        Me.RootPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.RootPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
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
        Me.RootPanel.Size = New System.Drawing.Size(277, 253)
        Me.RootPanel.TabIndex = 0
        '
        'BorderSizeLabel
        '
        Me.BorderSizeLabel.AutoSize = True
        Me.BorderSizeLabel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BorderSizeLabel.Location = New System.Drawing.Point(3, 26)
        Me.BorderSizeLabel.Name = "BorderSizeLabel"
        Me.BorderSizeLabel.Size = New System.Drawing.Size(114, 26)
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
        Me.BorderColorLabel.Size = New System.Drawing.Size(114, 26)
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
        Me.BackColorLabel.Size = New System.Drawing.Size(114, 26)
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
        Me.ForeLineSizeLabel.Size = New System.Drawing.Size(114, 26)
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
        Me.ForeColorLabel.Size = New System.Drawing.Size(114, 26)
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
        Me.ShadowDirectionLabel.Size = New System.Drawing.Size(114, 26)
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
        Me.ShadowColorLabel.Size = New System.Drawing.Size(114, 26)
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
        Me.TitleLabel.Size = New System.Drawing.Size(246, 26)
        Me.TitleLabel.TabIndex = 7
        Me.TitleLabel.Text = "Title"
        Me.TitleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'BorderSizeUpDown
        '
        Me.BorderSizeUpDown.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BorderSizeUpDown.Location = New System.Drawing.Point(121, 27)
        Me.BorderSizeUpDown.Margin = New System.Windows.Forms.Padding(1)
        Me.BorderSizeUpDown.Maximum = New Decimal(New Integer() {10, 0, 0, 0})
        Me.BorderSizeUpDown.Name = "BorderSizeUpDown"
        Me.BorderSizeUpDown.Size = New System.Drawing.Size(130, 23)
        Me.BorderSizeUpDown.TabIndex = 8
        Me.BorderSizeUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'BorderColorTBox
        '
        Me.BorderColorTBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BorderColorTBox.Location = New System.Drawing.Point(121, 53)
        Me.BorderColorTBox.Margin = New System.Windows.Forms.Padding(1)
        Me.BorderColorTBox.Name = "BorderColorTBox"
        Me.BorderColorTBox.Size = New System.Drawing.Size(130, 23)
        Me.BorderColorTBox.TabIndex = 9
        '
        'BackColorTBox
        '
        Me.BackColorTBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BackColorTBox.Location = New System.Drawing.Point(121, 79)
        Me.BackColorTBox.Margin = New System.Windows.Forms.Padding(1)
        Me.BackColorTBox.Name = "BackColorTBox"
        Me.BackColorTBox.Size = New System.Drawing.Size(130, 23)
        Me.BackColorTBox.TabIndex = 10
        '
        'ForeLineSizeUpDown
        '
        Me.ForeLineSizeUpDown.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ForeLineSizeUpDown.Location = New System.Drawing.Point(121, 105)
        Me.ForeLineSizeUpDown.Margin = New System.Windows.Forms.Padding(1)
        Me.ForeLineSizeUpDown.Maximum = New Decimal(New Integer() {10, 0, 0, 0})
        Me.ForeLineSizeUpDown.Name = "ForeLineSizeUpDown"
        Me.ForeLineSizeUpDown.Size = New System.Drawing.Size(130, 23)
        Me.ForeLineSizeUpDown.TabIndex = 11
        Me.ForeLineSizeUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'ForeColorTBox
        '
        Me.ForeColorTBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ForeColorTBox.Location = New System.Drawing.Point(121, 131)
        Me.ForeColorTBox.Margin = New System.Windows.Forms.Padding(1)
        Me.ForeColorTBox.Name = "ForeColorTBox"
        Me.ForeColorTBox.Size = New System.Drawing.Size(130, 23)
        Me.ForeColorTBox.TabIndex = 12
        '
        'ShadowDirectionCBox
        '
        Me.ShadowDirectionCBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ShadowDirectionCBox.FormattingEnabled = True
        Me.ShadowDirectionCBox.Location = New System.Drawing.Point(121, 156)
        Me.ShadowDirectionCBox.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.ShadowDirectionCBox.Name = "ShadowDirectionCBox"
        Me.ShadowDirectionCBox.Size = New System.Drawing.Size(130, 25)
        Me.ShadowDirectionCBox.TabIndex = 13
        '
        'ShadowColorTBox
        '
        Me.ShadowColorTBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ShadowColorTBox.Location = New System.Drawing.Point(121, 183)
        Me.ShadowColorTBox.Margin = New System.Windows.Forms.Padding(1)
        Me.ShadowColorTBox.Name = "ShadowColorTBox"
        Me.ShadowColorTBox.Size = New System.Drawing.Size(130, 23)
        Me.ShadowColorTBox.TabIndex = 14
        '
        'ResetDefaultButton
        '
        Me.ResetDefaultButton.Dock = System.Windows.Forms.DockStyle.Left
        Me.ResetDefaultButton.Location = New System.Drawing.Point(253, 1)
        Me.ResetDefaultButton.Margin = New System.Windows.Forms.Padding(1)
        Me.ResetDefaultButton.Name = "ResetDefaultButton"
        Me.ResetDefaultButton.Size = New System.Drawing.Size(23, 24)
        Me.ResetDefaultButton.TabIndex = 15
        Me.ResetDefaultButton.Text = "R"
        Me.ResetDefaultButton.UseVisualStyleBackColor = True
        '
        'TestSettingTab
        '
        'Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        'Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.RootPanel)
        Me.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "NewSettingTab"
        Me.Size = New System.Drawing.Size(277, 253)
        Me.RootPanel.ResumeLayout(False)
        Me.RootPanel.PerformLayout()
        CType(Me.BorderSizeUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ForeLineSizeUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
    End Sub

    Public iAprc As KzAppearance

    Public Sub New()
        InitializeComponent()

        With ShadowDirectionCBox
            Dim ub As Integer = [Enum].GetNames(GetType(KzSidePosition)).Count - 1
            For i As Integer = 0 To ub
                .Items.Add(CType(i, KzSidePosition))
            Next
        End With

        iAprc = New KzAppearance
        AprcToUI()

    End Sub

    Public Property Appearance As KzAppearance
        Get
            Return iAprc
        End Get
        Set(value As KzAppearance)
            iAprc = value
            AprcToUI()
        End Set
    End Property

    Private Sub AprcToUI()
        BorderSizeUpDown.Value = iAprc.BorderSize
        BorderColorTBox.Text = GetColorName(iAprc.BorderColor)
        BackColorTBox.Text = GetColorName(iAprc.BackColor)
        ForeLineSizeUpDown.Value = iAprc.ForeLineSize
        ForeColorTBox.Text = GetColorName(iAprc.ForeColor)
        ShadowDirectionCBox.SelectedItem = iAprc.ShadowDirection
        ShadowColorTBox.Text = GetColorName(iAprc.ShadowColor)
    End Sub

    Private Sub UItoAprc()
        With iAprc
            .BorderSize = BorderSizeUpDown.Value
            .BorderColor = GetColor(BorderColorTBox.Text)
            .BackColor = GetColor(BackColorTBox.Text)
            .ForeLineSize = ForeLineSizeUpDown.Value
            .ForeColor = GetColor(ForeColorTBox.Text)
            .ShadowDirection = ShadowDirectionCBox.SelectedItem
            .ShadowColor = GetColor(ShadowColorTBox.Text)
        End With
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

End Class 'KzAppearancesTab
