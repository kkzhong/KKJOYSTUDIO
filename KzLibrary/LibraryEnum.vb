Public Enum KzItemPosition
    None
    FirstItem
    PreviousItem
    NextItem
    LastItem
    Current
End Enum

Public Enum KzAlign
    None
    Center
    CenterLeft
    CenterRight
    Left
    LeftTop
    LeftCenter
    LeftBottom
    Top
    TopLeft
    TopCenter
    TopRight
    Right
    RightTop
    RightCenter
    RightBottom
    Bottom
    BottomLeft
    BottomCenter
    BottomRight
End Enum 'KzAlign

Public Enum KzDirection
    None
    LeftRight
    RightLeft
    TopDown
    BottomUp
    LeftUp
    RightUp
    LeftDown
    RightDown
    Horizon
    Vertical
    ZoomIn
    ZoomOut
End Enum 'KzDirection

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
End Enum 'KzControlStatus

'Public Enum KzTabControlTypes
'    Blank
'    TextEditor
'    RichTextEditor
'    WebBrowser
'    DataSheet
'    ListViewer
'    TreeViewer
'End Enum 'KzTabControlTypes

'Public Structure xKzDrawingStyle
'    Public Sub New(index As Integer)
'        With Me
'            .Index = index
'            .Radius = 0
'            .Margin = New Padding(0, 0, 0, 0)
'            .Padding = New Padding(0, 0, 0, 0)

'            .NormalFrameWidth = 0
'            .NormalFrameColor = SystemColors.WindowFrame
'            .NormalLineWidth = 1
'            .NormalForeColor = SystemColors.ControlText
'            .NormalFillColor = SystemColors.Control
'            .NormalFont = SystemFonts.DefaultFont
'            .NormalShadowWidth = 0
'            .NormalShadowColor = SystemColors.ButtonShadow
'            .NormalShadowPosition = KzAlign.RightBottom

'            .HoverFrameWidth = 0
'            .HoverFrameColor = SystemColors.WindowFrame
'            .HoverLineWidth = 1
'            .HoverForeColor = SystemColors.HighlightText
'            .HoverFillColor = SystemColors.ControlLight
'            .HoverFont = SystemFonts.DefaultFont
'            .HoverShadowWidth = 0
'            .HoverShadowColor = SystemColors.ButtonShadow
'            .HoverShadowPosition = KzAlign.RightBottom

'            .SelectedFrameWidth = 1
'            .SelectedFrameColor = SystemColors.ActiveBorder
'            .SelectedLineWidth = 1
'            .SelectedForeColor = SystemColors.ControlText
'            .SelectedFillColor = SystemColors.ControlDark
'            .SelectedFont = SystemFonts.DefaultFont
'            .SelectedShadowWidth = 0
'            .SelectedShadowColor = SystemColors.ButtonShadow
'            .SelectedShadowPosition = KzAlign.LeftTop
'        End With
'    End Sub

'    Public Property Index As Integer
'    Public Property Radius As Integer '= 0
'    Public Property Margin As Padding '= New Padding(0, 0, 0, 0)
'    Public Property Padding As Padding '= New Padding(0, 0, 0, 0)

'    Public Property NormalFrameWidth As Integer '= 0
'    Public Property NormalFrameColor As Color '= SystemColors.WindowFrame
'    Public Property NormalLineWidth As Integer '= 1
'    Public Property NormalForeColor As Color '= SystemColors.ControlText
'    Public Property NormalFillColor As Color '= SystemColors.Control
'    Public Property NormalFont As Font '= SystemFonts.DefaultFont

'    Public Property HoverFrameWidth As Integer '= 0
'    Public Property HoverFrameColor As Color '= SystemColors.WindowFrame
'    Public Property HoverLineWidth As Integer '= 1
'    Public Property HoverForeColor As Color '= SystemColors.HighlightText
'    Public Property HoverFillColor As Color '= SystemColors.ControlLight
'    Public Property HoverFont As Font '= SystemFonts.DefaultFont

'    Public Property SelectedFrameWidth As Integer '= 1
'    Public Property SelectedFrameColor As Color '= SystemColors.ActiveBorder
'    Public Property SelectedLineWidth As Integer '= 1
'    Public Property SelectedForeColor As Color '= SystemColors.ControlText
'    Public Property SelectedFillColor As Color '= SystemColors.ControlDark
'    Public Property SelectedFont As Font '= SystemFonts.DefaultFont

'    Public Property NormalShadowWidth As Integer
'    Public Property NormalShadowColor As Color
'    Public Property NormalShadowPosition As KzAlign
'    Public Property HoverShadowWidth As Integer
'    Public Property HoverShadowColor As Color
'    Public Property HoverShadowPosition As KzAlign
'    Public Property SelectedShadowWidth As Integer
'    Public Property SelectedShadowColor As Color
'    Public Property SelectedShadowPosition As KzAlign

'    Public ReadOnly Property NormalFramePen As Pen
'        Get
'            Return New Pen(NormalFrameColor, NormalFrameWidth)
'        End Get
'    End Property

'    Public ReadOnly Property NormalForePen As Pen
'        Get
'            Return New Pen(NormalForeColor, NormalLineWidth)
'        End Get
'    End Property

'    Public ReadOnly Property NormalFillBrush As Brush
'        Get
'            Return New SolidBrush(NormalFillColor)
'        End Get
'    End Property

'    Public ReadOnly Property NormalForeBrush As Brush
'        Get
'            Return New SolidBrush(NormalForeColor)
'        End Get
'    End Property

'    Public ReadOnly Property NormalShadowBrush As Brush
'        Get
'            Return New SolidBrush(NormalShadowColor)
'        End Get
'    End Property

'    Public ReadOnly Property HoverFramePen As Pen
'        Get
'            Return New Pen(HoverFrameColor, HoverFrameWidth)
'        End Get
'    End Property

'    Public ReadOnly Property HoverForePen As Pen
'        Get
'            Return New Pen(HoverForeColor, HoverLineWidth)
'        End Get
'    End Property

'    Public ReadOnly Property HoverFillBrush As Brush
'        Get
'            Return New SolidBrush(HoverFillColor)
'        End Get
'    End Property

'    Public ReadOnly Property HoverForeBrush As Brush
'        Get
'            Return New SolidBrush(HoverForeColor)
'        End Get
'    End Property

'    Public ReadOnly Property HoverShadowBrush As Brush
'        Get
'            Return New SolidBrush(HoverShadowColor)
'        End Get
'    End Property

'    Public ReadOnly Property SelectedFramePen As Pen
'        Get
'            Return New Pen(SelectedFrameColor, SelectedFrameWidth)
'        End Get
'    End Property

'    Public ReadOnly Property SelectedForePen As Pen
'        Get
'            Return New Pen(SelectedForeColor, SelectedLineWidth)
'        End Get
'    End Property

'    Public ReadOnly Property SelectedFillBrush As Brush
'        Get
'            Return New SolidBrush(SelectedFillColor)
'        End Get
'    End Property

'    Public ReadOnly Property SelectedForeBrush As Brush
'        Get
'            Return New SolidBrush(SelectedForeColor)
'        End Get
'    End Property

'    Public ReadOnly Property SelectedShadowBrush As Brush
'        Get
'            Return New SolidBrush(SelectedShadowColor)
'        End Get
'    End Property
'End Structure 'KzDrawingStyle

Public Structure KzInputItem
    Public Property Label As String
    Public Property PresetText As String
    Public Property ToolTipText As String
    Public Property ShowClearButton As Boolean
    Public Property ShowFunctionButton As Boolean
    Public Property InputResult As Object
End Structure 'InputItem

Public Structure KzRange
    Public Sub New(fromIndex As Integer, toIndex As Integer)
        Me.Min = fromIndex
        Me.Max = toIndex
    End Sub

    Public Sub New(start As Integer, length As Integer, byLength As Boolean)
        Me.Min = start
        Me.Max = start + length - 1
    End Sub

    Public Property Min As Integer
    Public Property Max As Integer

    Public ReadOnly Property Length As Integer
        Get
            Return Math.Abs(Me.Max - Me.Min) + 1
        End Get
    End Property
End Structure 'KzRange

<Serializable>
Public Structure KzIndecator
    Implements IComparable

    Public Property Name As String
    Public Property Label As String
    Public Property Start As Integer
    Public Property StartColor As Color
    Public Property FillColor As Color
    Public ReadOnly Property FillBrush As Brush
        Get
            Return New SolidBrush(Me.FillColor)
        End Get
    End Property
    Public ReadOnly Property StartPen As Pen
        Get
            Return New Pen(Me.StartColor)
        End Get
    End Property

    Public Function CompareTo(obj As Object) As Integer Implements IComparable.CompareTo
        If obj Is Nothing Then Return 0
        Try
            Dim another As KzIndecator = CType(obj, KzIndecator)
            Return Me.Start.CompareTo(another.Start)
        Catch ex As Exception
            Throw New NotImplementedException()
        End Try
        'Throw New NotImplementedException()
    End Function
End Structure
