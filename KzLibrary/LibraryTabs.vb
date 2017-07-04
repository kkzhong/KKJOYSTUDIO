Imports System.IO
Imports System.Drawing.Drawing2D

Public Class KzTabControl
    Inherits TabControl

    'Dim CloseButtonClicked As Boolean
    Dim iCloseBounds As Rectangle
    Dim iMouseOnIndex As Integer = -1
    Dim iMinTabWidth As Integer = 64
    Dim sNormal As KzControlStatus = KzControlStatus.Normal
    Dim sHover As KzControlStatus = KzControlStatus.Hover
    Dim sSelected As KzControlStatus = KzControlStatus.Selected

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

#Region "StyleSetting"
    Public Property TabStyle As KzDrawingStyleCollection
    Public Property ButtonStyle As KzDrawingStyleCollection
    Public Sub ResetStyle()
        Dim nor, hov, sel As KzDrawingStyle
        Me.TabStyle = New KzDrawingStyleCollection
        Me.ButtonStyle = New KzDrawingStyleCollection

        '設定TabStyle
        nor = New KzDrawingStyle(KzControlStatus.Normal) With {
            .FrameWidth = 1, .FrameColor = Color.Gray}
        hov = New KzDrawingStyle(KzControlStatus.Hover) With {
            .FrameWidth = 0, .FrameColor = Color.Gray}
        sel = New KzDrawingStyle(KzControlStatus.Hover) With {
            .FrameWidth = 1, .FrameColor = Color.Black}

        Me.TabStyle.AddRange({nor, hov, sel}, True)

        '設定ButtonStyle
        nor = New KzDrawingStyle(KzControlStatus.Normal) With {
            .FrameWidth = 1, .FrameColor = Color.Gray}
        hov = New KzDrawingStyle(KzControlStatus.Hover) With {
            .FrameWidth = 0, .FrameColor = Color.Gray}
        sel = New KzDrawingStyle(KzControlStatus.Hover) With {
            .FrameWidth = 1, .FrameColor = Color.Black}

        Me.ButtonStyle.AddRange({nor, hov, sel}, True)
    End Sub
#End Region

End Class

Public Enum KzControlStatus
    None
    Normal
    Hover
    MoveIn
    MoveOut
    Selected
    DragBegin
    DragEnd
    Zooming
End Enum

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
        Me.InnerLineWidth = 1
        Me.InnerLineColor = SystemColors.ControlDarkDark
        Me.FillColor = SystemColors.Control
        Me.FontColor = SystemColors.ControlText
        Me.Font = SystemFonts.DefaultFont
        Me.ShadowWidth = 0
        Me.ShadowFillColor = SystemColors.ButtonShadow
    End Sub

    Public Property Type As KzControlStatus
    Public Property FrameWidth As Integer
    Public Property FrameColor As Color
    Public Property InnerLineWidth As Integer '= 1
    Public Property InnerLineColor As Color '= SystemColors.ControlText
    Public Property FillColor As Color '= SystemColors.Control
    Public Property ShadowWidth As Integer
    Public Property ShadowFillColor As Color
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
            Return New Pen(Me.InnerLineColor, Me.InnerLineWidth)
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
            Return New SolidBrush(Me.ShadowFillColor)
        End Get
    End Property
End Structure 'KzDrawingStyle