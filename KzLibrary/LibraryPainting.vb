Imports System.Drawing.Drawing2D

Public MustInherit Class BaseShape
    '==================================
    'Type: 基类
    'Info: 用于基本图形（Shape）的基类
    '==================================

    Public Overridable ReadOnly Property Path As GraphicsPath

    Public ReadOnly Property Bounds As RectangleF
        Get
            Return Me.Path.GetBounds
        End Get
    End Property

    Public ReadOnly Property X As Integer
        Get
            Return Me.Bounds.X
        End Get
    End Property

    Public ReadOnly Property Y As Integer
        Get
            Return Me.Bounds.Y
        End Get
    End Property

    Public ReadOnly Property Width As Integer
        Get
            Return Me.Bounds.Width
        End Get
    End Property

    Public ReadOnly Property Height As Integer
        Get
            Return Me.Bounds.Height
        End Get
    End Property

    Public Overridable Sub Draw(g As Graphics, pen As Pen)
        g.DrawPath(pen, Me.Path)
    End Sub

    Public Overridable Sub Fill(g As Graphics, brush As Brush)
        g.FillPath(brush, Me.Path)
    End Sub

    Public Overridable Sub Paint(g As Graphics, pen As Pen, brush As Brush)
        g.DrawPath(pen, Me.Path)
        g.FillPath(brush, Me.Path)
    End Sub

End Class 'BaseShape

Public Class RoundRectangle
    Inherits BaseShape
    '==================================
    'Type: 衍生类
    'Info: 定义圆角矩形（Round Rectangle）
    '==================================

    Dim iRect As Rectangle
    Dim iSize As Size
    Dim iLocat As Point
    Dim iRadiuses As Size

    Public Sub New(rectangle As Rectangle, radiuses As Size)
        iRect = rectangle
        iRadiuses = radiuses
    End Sub

    Public Sub New(location As Point, size As Size, radiuses As Size)
        iRect = New Rectangle(location, size)
        iRadiuses = radiuses
    End Sub

    Public Sub New(x As Integer, y As Integer, width As Integer, hight As Integer, radiuses As Size)
        iRect = New Rectangle(x, y, width, hight)
        iRadiuses = radiuses
    End Sub

    Public Sub New(rectangle As Rectangle, radiusWidth As Integer, Optional radiusHeight As Integer = 0)
        iRect = rectangle
        If radiusWidth > 0 And radiusHeight = 0 Then
            iRadiuses = New Size(radiusWidth, radiusWidth)
        Else
            iRadiuses = New Size(radiusWidth, radiusHeight)
        End If
    End Sub

    Public Sub New(location As Point, size As Size, radiusWidth As Integer, Optional radiusHeight As Integer = 0)
        iRect = New Rectangle(location, size)
        If radiusWidth > 0 And radiusHeight = 0 Then
            iRadiuses = New Size(radiusWidth, radiusWidth)
        Else
            iRadiuses = New Size(radiusWidth, radiusHeight)
        End If
    End Sub

    Public Sub New(x As Integer, y As Integer, width As Integer, hight As Integer, radiusWidth As Integer, Optional radiusHeight As Integer = 0)
        iRect = New Rectangle(x, y, width, hight)
        If radiusWidth > 0 And radiusHeight = 0 Then
            iRadiuses = New Size(radiusWidth, radiusWidth)
        Else
            iRadiuses = New Size(radiusWidth, radiusHeight)
        End If
    End Sub


    Public Property Rectangle As Rectangle
        Get
            Return iRect
        End Get
        Set(value As Rectangle)
            iRect = value
            iLocat = iRect.Location
            iSize = iRect.Size
        End Set
    End Property

    Public Property Radiuses As Size
        Get
            Return iRadiuses
        End Get
        Set(value As Size)
            iRadiuses = value
        End Set
    End Property

    Public Property Location As Point
        Get
            Return iLocat
        End Get
        Set(value As Point)
            iLocat = value
            iRect = New Rectangle(iLocat, iSize)
        End Set
    End Property

    Public Property Size As Size
        Get
            Return iSize
        End Get
        Set(value As Size)
            iSize = value
            iRect = New Rectangle(iLocat, iSize)
        End Set
    End Property


    Public Overrides ReadOnly Property Path As GraphicsPath
        Get
            Dim gp As New GraphicsPath

            If iRadiuses.Width <= 1 And iRadiuses.Height <= 1 Then 'Or (iRadiuses.Height < 1 And iRadiuses.Height <> 0) Then
                gp.AddLines({iRect.Location,
                                New Point(iRect.Right, iRect.Top),
                                New Point(iRect.Right, iRect.Bottom),
                                New Point(iRect.Left, iRect.Bottom)})
                gp.CloseFigure()

            Else
                Dim w As Integer = iRadiuses.Width
                Dim h As Integer = iRadiuses.Height

                If w <= 1 And h > 1 Then
                    w = h
                ElseIf w > 1 And h <= 1 Then
                    h = w
                End If

                Dim cornerRect As New Rectangle(iRect.Location, New Size(w - 1, h - 1))
                gp.AddArc(cornerRect, 180, 90)     '左上角  
                cornerRect.X = iRect.Right - w   '右上角  
                gp.AddArc(cornerRect, 270, 90)
                cornerRect.Y = iRect.Bottom - h  '右下角  
                gp.AddArc(cornerRect, 0, 90)
                cornerRect.X = iRect.Left             '左下角  
                gp.AddArc(cornerRect, 90, 90)
                gp.CloseFigure()
            End If

            Return gp
        End Get
    End Property

    Public Shadows ReadOnly Property X As Integer
        Get
            Return iRect.X
        End Get
    End Property

    Public Shadows ReadOnly Property Y As Integer
        Get
            Return iRect.Y
        End Get
    End Property

    Public Shadows ReadOnly Property Width As Integer
        Get
            Return iRect.Width
        End Get
    End Property

    Public Shadows ReadOnly Property Height As Integer
        Get
            Return iRect.Height
        End Get
    End Property
End Class 'RoundRectangle

Public Class Triangle
    Inherits BaseShape
    '==================================
    'Type: 衍生类
    'Info: 定义三角形（Triangle）
    '==================================

    Dim iPt1, iPt2, iPt3 As Point

    Public Sub New(pt1 As Point, pt2 As Point, pt3 As Point)
        iPt1 = pt1
        iPt2 = pt2
        iPt3 = pt3
    End Sub

    Public Property Point1 As Point
        Get
            Return iPt1
        End Get
        Set(value As Point)
            iPt1 = value
        End Set
    End Property

    Public Property Point2 As Point
        Get
            Return iPt2
        End Get
        Set(value As Point)
            iPt2 = value
        End Set
    End Property

    Public Property Point3 As Point
        Get
            Return iPt3
        End Get
        Set(value As Point)
            iPt3 = value
        End Set
    End Property

    Public Overrides ReadOnly Property Path As GraphicsPath
        Get
            Dim gp As New GraphicsPath

            'If iPt1 = iPt2 Then
            '    gp.AddLine(iPt1, iPt3)
            'ElseIf iPt2 = iPt3 Then
            '    gp.AddLine(iPt2, iPt1)
            'ElseIf iPt1 = iPt3 Then
            '    gp.AddLine(iPt1, iPt2)
            'Else
            '    gp.AddLines({iPt1, iPt2, iPt3})
            '    gp.CloseFigure()
            'End If

            gp.AddPolygon({iPt1, iPt2, iPt3})

            Return gp

        End Get
    End Property
End Class 'Triangle

Public Class DirectionTriangle
    Inherits BaseShape

    Dim iLocat As Point
    Dim iSize As Size
    Dim iDirect As KzDirection

    Public Sub New(rectangle As Rectangle, direction As KzDirection)
        iLocat = rectangle.Location
        iSize = rectangle.Size
        iDirect = direction
    End Sub

    Public Sub New(location As Point, size As Size, direction As KzDirection)
        iLocat = location
        iSize = size
        iDirect = direction
    End Sub

    Public Sub New(location As Point, SideLength As Integer, direction As KzDirection)
        iLocat = location
        iSize = New Size(SideLength, SideLength)
        iDirect = direction
    End Sub


    Public Property Location As Point
        Get
            Return iLocat
        End Get
        Set(value As Point)
            iLocat = value
        End Set
    End Property

    Public Property Size As Size
        Get
            Return iSize
        End Get
        Set(value As Size)
            iSize = value
        End Set
    End Property

    Public Property Direction As KzDirection
        Get
            Return iDirect
        End Get
        Set(value As KzDirection)
            iDirect = value
        End Set
    End Property

    Public Overrides ReadOnly Property Path As GraphicsPath
        Get
            Dim p1, p2, p3 As Point
            Dim rect As New Rectangle(iLocat, iSize)

            With rect
                Select Case iDirect
                    Case KzDirection.RightLeft
                        p1 = New Point(.Left, .Top + .Height / 2)
                        p2 = New Point(.Right, .Top)
                        p3 = New Point(.Right, .Bottom)
                    Case KzDirection.BottomUp
                        p1 = New Point(.Left, .Bottom)
                        p2 = New Point(.Left + .Width / 2, .Top)
                        p3 = New Point(.Right, .Bottom)
                    Case KzDirection.TopDown
                        p1 = New Point(.Left, .Top)
                        p2 = New Point(.Right, .Top)
                        p3 = New Point(.Left + .Width / 2, .Bottom)
                    Case KzDirection.LeftUp
                        p1 = New Point(.Left, .Top)
                        p2 = New Point(.Right, .Top)
                        p3 = New Point(.Right, .Bottom)
                    Case KzDirection.RightUp
                        p1 = New Point(.Left, .Top)
                        p2 = New Point(.Right, .Top)
                        p3 = New Point(.Left, .Bottom)
                    Case KzDirection.LeftDown
                        p1 = New Point(.Left, .Bottom)
                        p2 = New Point(.Right, .Top)
                        p3 = New Point(.Right, .Bottom)
                    Case KzDirection.RightDown
                        p1 = New Point(.Left, .Top)
                        p2 = New Point(.Right, .Bottom)
                        p3 = New Point(.Left, .Bottom)
                        'Case KzDirection.Horizon
                        '    p1 = New Point()
                        '    p2 = New Point()
                        '    p3 = New Point()
                        'Case KzDirection.Vertical
                        '    p1 = New Point()
                        '    p2 = New Point()
                        '    p3 = New Point()
                        'Case KzDirection.ZoomIn
                        '    p1 = New Point()
                        '    p2 = New Point()
                        '    p3 = New Point()
                        'Case KzDirection.ZoomOut
                        '    p1 = New Point()
                        '    p2 = New Point()
                        '    p3 = New Point()
                    Case Else 'KzDirection.None, KzDirection.LeftRight
                        p1 = New Point(.Left, .Top)
                        p2 = New Point(.Right, .Top + .Height / 2)
                        p3 = New Point(.Left, .Bottom)
                End Select
            End With

            Return New Triangle(p1, p2, p3).Path
        End Get
    End Property

End Class 'DirectionTriangle

Public Enum ButtonType
    Blank
    Close
    Plus
    Minus
    Check
    Play
    Pause
    PlayPause
    NextTrack
    PreviousTrack
    FastForward
    FastRewind
    StopPlay
End Enum 'ButtonType

Public Class SquareButton

    Dim iOuterFrame As Rectangle
    Dim iInnerFrame As Rectangle
    Dim iShadowFrame As Rectangle


    Public Sub New(location As Point, sideLength As Integer,
                       Optional type As ButtonType = ButtonType.Blank)

        Me.SideLength = sideLength
        Me.Location = location

        Me.FrameWidth = 1
        Me.FrameRadius = 0
        Me.FrameColor = SystemColors.WindowFrame

        Me.KzSidePosition = KzSidePosition.RightBottom
        Me.ShadowWidth = 0
        Me.ShadowColor = SystemColors.ButtonShadow

        Me.BackColor = SystemColors.Control
        Me.ForeColor = SystemColors.ControlText
        Me.ForeLineWidth = 1

        Me.PaddingWidth = 1

        'UpdateFrame()

        Me.Type = type
    End Sub


    Private Sub UpdateFrame()
        Select Case KzSidePosition
            Case KzSidePosition.RightBottom
                iOuterFrame = New Rectangle(Me.Bounds.X, Me.Bounds.Y,
                                                Me.Bounds.Width - Me.ShadowWidth, Me.Bounds.Height - Me.ShadowWidth)
                iShadowFrame = New Rectangle(Me.Bounds.X + Me.ShadowWidth, Me.Bounds.Y + Me.ShadowWidth,
                                                 iOuterFrame.Width, iOuterFrame.Height)
            Case KzSidePosition.RightTop
                iOuterFrame = New Rectangle(Me.Bounds.X, Me.Bounds.Y + Me.ShadowWidth,
                                                Me.Bounds.Width - Me.ShadowWidth, Me.Bounds.Height - Me.ShadowWidth)
                iShadowFrame = New Rectangle(Me.Bounds.X + Me.ShadowWidth, Me.Bounds.Y,
                                                 iOuterFrame.Width, iOuterFrame.Height)
            Case KzSidePosition.LeftBottom
                iOuterFrame = New Rectangle(Me.Bounds.X + Me.ShadowWidth, Me.Bounds.Y,
                                                Me.Bounds.Width - Me.ShadowWidth, Me.Bounds.Height - Me.ShadowWidth)
                iShadowFrame = New Rectangle(Me.Bounds.X, Me.Bounds.Y + Me.ShadowWidth,
                                                 iOuterFrame.Width, iOuterFrame.Height)
            Case KzSidePosition.LeftTop
                iOuterFrame = New Rectangle(Me.Bounds.X + Me.ShadowWidth, Me.Bounds.Y + Me.ShadowWidth,
                                                Me.Bounds.Width - Me.ShadowWidth, Me.Bounds.Height - Me.ShadowWidth)
                iShadowFrame = New Rectangle(Me.Bounds.X, Me.Bounds.Y,
                                                 iOuterFrame.Width, iOuterFrame.Height)
            Case Else
        End Select

        iInnerFrame = New Rectangle(iOuterFrame.X + Me.FrameWidth + Me.PaddingWidth,
                                        iOuterFrame.Y + Me.FrameWidth + Me.PaddingWidth,
                                        iOuterFrame.Width - 2 * Me.FrameWidth - 2 * Me.PaddingWidth,
                                        iOuterFrame.Height - 2 * Me.FrameWidth - 2 * Me.PaddingWidth)
    End Sub

    Public Property Type As ButtonType
    Public Property FrameRadius As Integer
    Public Property FrameColor As Color
    Public Property FrameWidth As Integer
    Public Property BackColor As Color
    Public Property ForeColor As Color
    Public Property ForeLineWidth As Integer
    Public Property PaddingWidth As Integer
    Public Property KzSidePosition As KzSidePosition
    Public Property ShadowColor As Color
    Public Property ShadowWidth As Integer
    Public Property SideLength As Integer
    Public Property Location As Point

    Public ReadOnly Property Size As Size
        Get
            Return New Size(Me.SideLength, Me.SideLength)
        End Get
    End Property

    Public ReadOnly Property Bounds As Rectangle
        Get
            Return New Rectangle(Me.Location, Me.Size)
        End Get
    End Property

    Public ReadOnly Property ShadowBounds As Rectangle
        Get
            UpdateFrame()
            Return iShadowFrame
        End Get
    End Property

    Public ReadOnly Property OuterBounds As Rectangle
        Get
            UpdateFrame()
            Return iOuterFrame
        End Get
    End Property

    Public ReadOnly Property InnerBounds As Rectangle
        Get
            UpdateFrame()
            Return iInnerFrame
        End Get
    End Property

    Private Function GetInnerPath() As GraphicsPath
        Dim gp As New GraphicsPath
        Dim r As Rectangle = iInnerFrame

        Select Case Me.Type
            Case ButtonType.Close
                gp.AddLine(r.Location, New Point(r.Right, r.Bottom))
                gp.StartFigure()
                gp.AddLine(New Point(r.Left, r.Bottom), New Point(r.Right, r.Top))

            Case ButtonType.Plus
                gp.AddLine(New Point(r.Left, r.Top + r.Height / 2),
                               New Point(r.Right, r.Height / 2))
                gp.AddLine(New Point(r.Left + r.Width / 2, r.Top),
                               New Point(r.Left + r.Width / 2, r.Bottom))

            Case ButtonType.Minus
                gp.AddLine(New Point(r.Left, r.Top + r.Height / 2),
                               New Point(r.Right, r.Height / 2))

            Case ButtonType.Check
                gp.AddLines({New Point(r.Left, r.Top + r.Height / 2),
                                New Point(r.Left + r.Width / 2, r.Bottom),
                                New Point(r.Right, r.Top)})
            Case Else 'Blank

        End Select

        Return gp
    End Function

    Public ReadOnly Property InnerPath As GraphicsPath
        Get
            UpdateFrame()
            Return GetInnerPath()
        End Get
    End Property

    Public Sub Paint(g As Graphics)
        UpdateFrame()
        g.FillRectangle(New SolidBrush(Me.ShadowColor), iShadowFrame)       '填充陰影
        g.FillRectangle(New SolidBrush(Me.BackColor), iOuterFrame)          '填充背景
        g.DrawRectangle(New Pen(Me.FrameColor, Me.FrameWidth), iOuterFrame) '描畫邊框
        g.DrawPath(New Pen(Me.ForeColor, Me.ForeLineWidth), Me.InnerPath)   '描畫畫心
    End Sub


    Public Function Contains(pt As Point) As Boolean
        With Me.OuterBounds
            Return pt.X > .X And pt.X < .Right And pt.Y > .Y And pt.Y < .Bottom
        End With
    End Function

End Class 'SquareButton

Public Class KzTabDesignSet
    Public Property RootBackColor As Color = SystemColors.Control 'TabControl整體之背景色
    Public Property AutoTabWidth As Boolean = True '自動調整Tab寬度
    Public Property TabsUnderlineSize As Integer = 0
    Public Property OpenSelectedTabUnderline As Boolean = False '
    Public Property ShowCloseButtonOnTab As Boolean = True '
    Public Property ShowCloseOnUnselectedTabs As Boolean = False
    Public Property ShowAddOnSelectedTab As Boolean = False
    Public Property IgnorePrivateTabSetting As Boolean = True

    Public Property DefaultTab As KzAppearances
    Public Property SelectedTab As KzAppearances
    Public Property DefaultButton As KzAppearances
    Public Property SelectedButton As KzAppearances

    Public ReadOnly Property RootBackBrush As Brush
        Get
            Return New SolidBrush(Me.RootBackColor)
        End Get
    End Property
End Class

Public Class KzAppearances
    Public Property Name As String = "NewAppearances"
    Public Property BorderRadius As Integer = 0

    Public Property Normal As KzAppearance
    Public Property Hover As KzAppearance
    Public Property Pressed As KzAppearance
    Public Property Checked As KzAppearance

    Public Property ShadowWidth As Integer = 0
    Public Property ShadowShift As Boolean = False

    Public Property FontFamily As FontFamily = SystemFonts.DefaultFont.FontFamily
    Public Property FontSize As Single = SystemFonts.DefaultFont.Size

    Public Function Font(status As KzStatus) As Font
        Dim fs As FontStyle
        Select Case status
            Case KzStatus.Normal : fs = Me.Normal.FontStyle
            Case KzStatus.Hover : fs = Me.Hover.FontStyle
            Case KzStatus.Pressed : fs = Me.Pressed.FontStyle
            Case KzStatus.Checked : fs = Me.Checked.FontStyle
        End Select
        Return New Font(Me.FontFamily, Me.FontSize, fs)
    End Function

    Public Shared Function ColorAdd(color1 As Color, color2 As Color,
                                    Optional plus As Boolean = True) As Color
        Dim a, r, g, b As Byte

        If plus Then
            a = Math.Min(255, color1.A + color2.A)
            r = Math.Min(255, color1.R + color2.R)
            g = Math.Min(255, color1.G + color2.G)
            b = Math.Min(255, color1.B + color2.B)
        Else
            a = Math.Max(0, CType(color1.A, Short) - CType(color2.A, Short))
            r = Math.Max(0, CType(color1.R, Short) - CType(color2.R, Short))
            g = Math.Max(0, CType(color1.G, Short) - CType(color2.G, Short))
            b = Math.Max(0, CType(color1.B, Short) - CType(color2.B, Short))
        End If

        Return Color.FromArgb(a, r, g, b)
    End Function

    Public Shared Function ReColor(color As Color, argb As Char, value As Byte,
                                   Optional updown As Boolean = False) As Color
        Dim a, r, g, b As Byte
        a = color.A
        r = color.R
        g = color.G
        b = color.B

        Select Case argb
            Case "a" : a = If(updown, Math.Max(0, Math.Min(255, color.A + value)), value)
            Case "r" : r = If(updown, Math.Max(0, Math.Min(255, color.R + value)), value)
            Case "g" : g = If(updown, Math.Max(0, Math.Min(255, color.G + value)), value)
            Case "b" : b = If(updown, Math.Max(0, Math.Min(255, color.B + value)), value)
            Case Else
        End Select

        Return Color.FromArgb(a, r, g, b)
    End Function

    Public Shared Function FontResize(font As Font, value As Single,
                                      Optional updown As Boolean = False) As Font
        If updown Then
            Return New Font(font.FontFamily, font.Size + value, font.Style)
        Else
            Return New Font(font.FontFamily, value, font.Style)
        End If
    End Function

    Public Shared Function FontRestyle(font As Font, value As FontStyle,
                                       Optional addstyle As Boolean = False) As Font
        If addstyle Then
            Return New Font(font.FontFamily, font.Size, font.Style Or value)
        Else
            Return New Font(font.FontFamily, font.Size, value)
        End If
    End Function
End Class

Public Class KzAppearance
    Public Property BorderSize As Integer = 0
    Public Property BorderColor As Color = SystemColors.ActiveBorder
    Public Property BackColor As Color = SystemColors.Control
    Public Property ForeLineSize As Integer = 1
    Public Property ForeColor As Color = SystemColors.ControlText
    Public Property ShadowDirection As KzSidePosition = KzSidePosition.RightBottom
    Public Property ShadowColor As Color = SystemColors.ButtonShadow
    Public Property FontStyle As FontStyle = SystemFonts.DefaultFont.Style

    Public ReadOnly Property BorderPen As Pen
        Get
            Return New Pen(BorderColor, BorderSize)
        End Get
    End Property

    Public ReadOnly Property BackBrush As Brush
        Get
            Return New SolidBrush(BackColor)
        End Get
    End Property

    Public ReadOnly Property ForePen As Pen
        Get
            Return New Pen(ForeColor, ForeLineSize)
        End Get
    End Property

    Public ReadOnly Property ForeBrush As Brush
        Get
            Return New SolidBrush(ForeColor)
        End Get
    End Property

    Public ReadOnly Property ShadowBrush As Brush
        Get
            Return New SolidBrush(ShadowColor)
        End Get
    End Property

End Class




