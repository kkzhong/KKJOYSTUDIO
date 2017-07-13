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
        '            item.Type <> KzStatus.None Then

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

    Public Overloads Function Contains(styleStatus As KzStatus) As Boolean
        For Each item As KzDrawingStyle In Me
            If item.Type = styleStatus Then
                Return True
                Exit For
            End If
        Next

        Return False
    End Function

    Public Function GetStyle(status As KzStatus) As KzDrawingStyle
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
    Public Sub New(type As KzStatus)
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

    Public Property Type As KzStatus
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