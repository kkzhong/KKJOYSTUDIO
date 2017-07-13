Imports System.Text

Public Class TestColorPicker

    Public Sub New()

        ' 此调用是设计器所必需的。
        InitializeComponent()

        ' 在 InitializeComponent() 调用之后添加任何初始化。

    End Sub

    Private Sub RefreshColorList(ShowAllColors As Decimal)
        ' Get all the values from the KnownColor enumeration.
        Dim colorsArray As System.Array = [Enum].GetValues(GetType(KnownColor))
        Dim allColors(colorsArray.Length) As KnownColor

        Array.Copy(colorsArray, allColors, colorsArray.Length)

        Dim colors As Array
        Select Case ShowAllColors
            Case 0 : colors = [Enum].GetValues(GetType(KnownColor))
            Case 1 : colors = [Enum].GetValues(GetType(SystemColors))
            Case 2 : colors = [Enum].GetValues(GetType(Color))
        End Select

    End Sub
End Class
