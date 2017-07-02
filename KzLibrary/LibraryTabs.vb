Imports System.IO
Imports System.Drawing.Drawing2D

Public Class KzTabControl
    Inherits TabControl

    'Dim CloseButtonClicked As Boolean
    Dim CloseButtonBounds As Rectangle
    Dim MouseOnTabIndex As Integer = -1
    Dim MinTabWidth As Integer = 64

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

#End Region
End Class

Public Enum KzStyleType
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

Public Class KzDrawingSet
    Inherits List(Of KzDrawingStyle)

    Public Sub New()

    End Sub

    Public Property Status As KzStyleType = KzStyleType.None
End Class

Public Structure KzDrawingStyle
    Dim iFont As Font
    Dim iFFamily As FontFamily
    Dim iFSize As Single
    Dim iFStyle As FontStyle

    Public Sub New(type As KzStyleType, Optional styleSet As KzDrawingSet = Nothing)
        Me.Parent = styleSet
        Me.StyleType = type

        Me.FrameWidth = 0
        Me.FrameColor = SystemColors.ActiveBorder
        Me.InnerLineWidth = 1
        Me.InnerLineColor = SystemColors.ControlDarkDark
        Me.FillColor = SystemColors.Control
        Me.FontColor = SystemColors.ControlText
        Me.Font = SystemFonts.DefaultFont
    End Sub

    Public Property Parent As KzDrawingSet
    Public Property StyleType As KzStyleType
    Public Property FrameWidth As Integer
    Public Property FrameColor As Color
    Public Property InnerLineWidth As Integer '= 1
    Public Property InnerLineColor As Color '= SystemColors.ControlText
    Public Property FillColor As Color '= SystemColors.Control
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
End Structure 'KzDrawingStyle