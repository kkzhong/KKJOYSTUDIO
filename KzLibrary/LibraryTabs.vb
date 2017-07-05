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
    Public Property AutoTabWidth As Boolean = True
    Public Property OpenPageFrame As Boolean = False

    Public Property TabStyle As KzTripleStyles
    Public Property ButtonStyle As KzTripleStyles
    Public Property PageStyle As KzTripleStyles

    Public Property ShowCloseButton As Boolean = True
    Public Property ShowCloseUnselected As Boolean = False

    Public Property IgnorePrivateTabSetting As Boolean = True
    'IgnorePrivateTabSetting = False，將使用Tab定義的 TabStyle, ButtonStyle, ShowCloseButton, ShowCloseUnselected

    Public Sub ResetFaceStyle()
        Dim nor, hov, sel As KzDrawingStyle

        '設定TabStyle
        nor = New KzDrawingStyle(KzControlStatus.Normal) With {
            .FrameWidth = 1, .FrameColor = Color.Gray}
        hov = New KzDrawingStyle(KzControlStatus.Hover) With {
            .FrameWidth = 0, .FrameColor = Color.Gray}
        sel = New KzDrawingStyle(KzControlStatus.Hover) With {
            .FrameWidth = 1, .FrameColor = Color.Black}

        With Me.TabStyle
            .Normal = nor
            .Hover = hov
            .Selected = sel
        End With

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
        'Dim psTab, psBtn, psPage As New KzDrawingStyleCollection

        g.SmoothingMode = SmoothingMode.AntiAlias '开启抗锯齿
        g.InterpolationMode = InterpolationMode.HighQualityBilinear '开启高质量插补模式
        g.TextRenderingHint = Drawing.Text.TextRenderingHint.ClearTypeGridFit '开启文字 ClearType
        g.FillRectangle(New SolidBrush(Me.RootBackColor), Me.ClientRectangle) '绘制 TabControl 整体背景色


        If PageStyle.Normal.FrameWidth = 0 Then

        End If
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
    Public Property Selected As KzDrawingStyle
End Class

Public Structure KzDrawingStyle
    Dim iFont As Font
    Dim iFFamily As FontFamily
    Dim iFSize As Single
    Dim iFStyle As FontStyle

    Public Sub New(type As KzControlStatus)
        Me.Type = type
        Me.FrameWidth = 0
        Me.FrameColor = SystemColors.ActiveBorder
        Me.LineWidth = 1
        Me.LineColor = SystemColors.ControlDarkDark
        Me.FillColor = SystemColors.Control
        Me.FontColor = SystemColors.ControlText
        Me.Font = SystemFonts.DefaultFont
        Me.ShadowWidth = 0
        Me.ShadowColor = SystemColors.ButtonShadow
        Me.Radius = 0
    End Sub

    Public Property Type As KzControlStatus
    Public Property Radius As Integer
    Public Property FrameWidth As Integer
    Public Property FrameColor As Color
    Public Property LineWidth As Integer '= 1
    Public Property LineColor As Color '= SystemColors.ControlText
    Public Property FillColor As Color '= SystemColors.Control
    Public Property ShadowWidth As Integer
    Public Property ShadowColor As Color
    Public Property FontColor As Color
    Public Property Font As Font '= SystemFonts.DefaultFont
        Get
            Return iFont
        End Get
        Set(value As Font)
            iFont = value
            iFFamily = value.FontFamily
            iFSize = value.Size
            iFStyle = value.Style
        End Set
    End Property
    Public Property FontSize As Single
        Get
            Return iFSize
        End Get
        Set(value As Single)
            If Not value = iFSize Then
                iFSize = value
                iFont = New Font(iFFamily, iFSize, iFStyle)
            End If
        End Set
    End Property
    Public Property FontName As FontFamily
        Get
            Return iFFamily
        End Get
        Set(value As FontFamily)
            If Not value.Equals(iFFamily) Then
                iFFamily = value
                iFont = New Font(iFFamily, iFSize, iFStyle)
            End If
        End Set
    End Property
    Public Property FontStyle As FontStyle
        Get
            Return iFStyle
        End Get
        Set(value As FontStyle)
            If Not value = iFStyle Then
                iFStyle = value
                iFont = New Font(iFFamily, iFSize, iFStyle)
            End If
        End Set
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

