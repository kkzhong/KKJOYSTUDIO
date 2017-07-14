Imports System.Text

Public Class TestColorPicker

    Private Enum ColorListType
        All
        Named
        System
        Custom
        Checked
    End Enum

    Private Stickers As New List(Of KzColorSticker)
    Private SelectedStickers As New List(Of KzColorSticker)

    Public Sub New()

        ' 此调用是设计器所必需的。
        InitializeComponent()

        ' 在 InitializeComponent() 调用之后添加任何初始化。

        SetStickerList(ColorListType.Named)
    End Sub

    Private Sub SetStickerList(listType As ColorListType)
        ' Get all the values from the KnownColor enumeration.
        Dim colorsArray As System.Array = [Enum].GetValues(GetType(KnownColor))
        'Dim allColors(colorsArray.Length) As KnownColor
        'Array.Copy(colorsArray, allColors, colorsArray.Length)

        Dim c As Color
        Dim cs As KzColorSticker

        For i As Integer = 0 To colorsArray.GetUpperBound(0)
            c = Color.FromName(colorsArray(i).ToString())
            cs = New KzColorSticker(c)
            AddHandler cs.CheckedChanged, AddressOf StickerCheckedChanged
            'With cs
            '    .NameLabel.Text = c.Name
            '    .PropertyLabel.Text = Hex(c.ToArgb)
            'End With
            Select Case listType
                Case ColorListType.All
                    Stickers.Add(cs)
                Case ColorListType.Named
                    If c.IsNamedColor Then Stickers.Add(cs)
                Case ColorListType.System
                    If c.IsSystemColor Then Stickers.Add(cs)
            End Select
        Next

        With ColorsPanel
            .BackColor = Color.DarkGray
            .Controls.Clear()
            .Controls.AddRange(Stickers.ToArray)
        End With

        CountLabel.Text = "Total " & Stickers.Count & " Selected " & SelectedStickers.Count

        'Dim p As New KzColorListPanel With {.Dock = DockStyle.Fill}
        'RootSpliter.Panel1.Controls.Clear()
        'RootSpliter.Panel1.Controls.Add(p)
    End Sub


    Private Sub ColorsPanel_SizeChanged(sender As Object, e As EventArgs) Handles ColorsPanel.SizeChanged
        With ColorsPanel
            .SuspendLayout()
            For Each c As Control In .Controls
                c.Width = .ClientRectangle.Width
            Next
            .ResumeLayout(False)
            .PerformLayout()
        End With

    End Sub

    Private Sub TestColorPicker_Load(sender As Object, e As EventArgs) Handles Me.Load

    End Sub

    Private Sub StickerCheckedChanged(sender As Object, e As EventArgs)
        If CType(sender, KzColorSticker).Checked Then
            SelectedStickers.Add(sender)
        Else
            SelectedStickers.Remove(sender)
        End If
    End Sub
End Class
