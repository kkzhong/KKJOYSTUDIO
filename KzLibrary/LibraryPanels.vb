Public Class KzInputPanel

End Class

Public Enum KzColorPanelCategory
    SystemColors
    WebColors
    NamedColors
End Enum

Public Class KzColorListPanel
    Inherits TableLayoutPanel

    Dim iCategory As KzColorPanelCategory

    Public Sub New(type As KzColorPanelCategory)
        AutoScroll = True
        BorderStyle = BorderStyle.None

        With ColumnStyles
            .Clear()
            .Add(New ColumnStyle(SizeType.Percent, 30))
            .Add(New ColumnStyle(SizeType.Percent, 70))
        End With

        RowStyles.Clear()

        Category = type
    End Sub

    Public Property Category As KzColorPanelCategory
        Get
            Return iCategory
        End Get
        Set(value As KzColorPanelCategory)
            iCategory = value
            SetList()
        End Set
    End Property

    Private Sub SetList()
        'Dim cList As IList(Of Color)
        Dim btn As Button
        Dim lbl As Label

        If Category = KzColorPanelCategory.WebColors Then
            For i As Integer = 0 To cNames.GetUpperBound(0)
                Me.RowStyles.Add(New RowStyle(SizeType.Absolute, 25))
                btn = New Button With {
                    .Text = "",
                    .BackColor = Color.FromName(cNames(i)),
                    .Margin = New Padding(0),
                    .Padding = New Padding(0),
                    .Dock = DockStyle.Fill}
                Me.Controls.Add(btn, 0, i)

                lbl = New Label With {
                    .Text = cNames(i),
                    .AutoSize = False,
                    .TextAlign = ContentAlignment.MiddleLeft,
                    .Dock = DockStyle.Fill}
                Me.Controls.Add(lbl, 1, i)
            Next
        End If
    End Sub

    Dim cNames() As String = {
        "AliceBlue",
        "AntiqueWhite",
"Aqua",
"Aquamarine",
"Azure",
"Beige",
"Bisque",
"Black",
"BlanchedAlmond",
"Blue",
"BlueViolet",
"Brown",
"BurlyWood",
"CadetBlue",
"Chartreuse",
"Chocolate",
"Coral",
"CornflowerBlue",
"Cornsilk",
"Crimson",
"Cyan",
"DarkBlue",
"DarkCyan",
"DarkGoldenrod",
"DarkGray",
"DarkGreen",
"DarkKhaki",
"DarkMagenta",
"DarkOliveGreen",
"DarkOrange",
"DarkOrchid",
"DarkRed",
"DarkSalmon",
"DarkSeaGreen",
"DarkSlateBlue",
"DarkSlateGray",
"DarkTurquoise",
"DarkViolet",
"DeepPink",
"DeepSkyBlue",
"DimGray",
"DodgerBlue",
"Firebrick",
"FloralWhite",
"ForestGreen",
"Fuchsia",
"Gainsboro",
"GhostWhite",
"Gold",
"Goldenrod",
"Gray",
"Green",
"GreenYellow",
"Honeydew",
"HotPink",
"IndianRed",
"Indigo",
"Ivory",
"Khaki",
"Lavender",
"LavenderBlush",
"LawnGreen",
"LemonChiffon",
"LightBlue",
"LightCoral",
"LightCyan",
"LightGoldenrodYellow",
"LightGray",
"LightGreen",
"LightPink",
"LightSalmon",
"LightSeaGreen",
"LightSkyBlue",
"LightSlateGray",
"LightSteelBlue",
"LightYellow",
"Lime",
"LimeGreen",
"Linen",
"Magenta",
"Maroon",
"MediumAquamarine",
"MediumBlue",
"MediumOrchid",
"MediumPurple",
"MediumSeaGreen",
"MediumSlateBlue",
"MediumSpringGreen",
"MediumTurquoise",
"MediumVioletRed",
"MidnightBlue",
"MintCream",
"MistyRose",
"Moccasin",
"NavajoWhite",
"Navy",
"OldLace",
"Olive",
"OliveDrab",
"Orange",
"OrangeRed",
"Orchid",
"PaleGoldenrod",
"PaleGreen",
"PaleTurquoise",
"PaleVioletRed",
"PapayaWhip",
"PeachPuff",
"Peru",
"Pink",
"Plum",
"PowderBlue",
"Purple",
"Red",
"RosyBrown",
"RoyalBlue",
"SaddleBrown",
"Salmon",
"SandyBrown",
"SeaGreen",
"SeaShell",
"Sienna",
"Silver",
"SkyBlue",
"SlateBlue",
"SlateGray",
"Snow",
"SpringGreen",
"SteelBlue",
"Tan",
"Teal",
"Thistle",
"Tomato",
"Transparent",
"Turquoise",
"Violet",
"Wheat",
"White",
"WhiteSmoke",
"Yellow",
"YellowGreen"
}

End Class