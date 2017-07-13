Public Enum KzItemPosition
    None
    FirstItem
    PreviousItem
    NextItem
    LastItem
    Current
End Enum

Public Enum KzSidePosition
    None
    RightBottom
    RightTop
    LeftTop
    LeftBottom
End Enum 'KzSidePosition

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

Public Enum KzStatus
    None
    Normal
    Hover
    Pressed
    Checked
    MoveIn
    MoveOut
    DragBegin
    DragEnd
    Zooming
End Enum 'KzControlStatus

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
