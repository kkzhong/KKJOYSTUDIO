Imports KzLibrary.KzConstants

Public Class KzInputPanel

End Class

Public Class KzColorListPanel
    Inherits TableLayoutPanel

    Public Sub New()
        AutoScroll = True
        BorderStyle = BorderStyle.None

        With ColumnStyles
            .Clear()
            .Add(New ColumnStyle(SizeType.Percent, 30))
            .Add(New ColumnStyle(SizeType.Percent, 70))
        End With

        RowStyles.Clear()
        SetList()
    End Sub


    Private Sub SetList()
        Dim btn As Button
        Dim lbl As Label

        For i As Integer = 0 To KzColorNameList.GetUpperBound(0)
            Me.RowStyles.Add(New RowStyle(SizeType.Absolute, 25))
            btn = New Button With {
                    .Text = "",
                    .BackColor = Color.FromName(KzColorNameList(i)),
                    .Margin = New Padding(0),
                    .Padding = New Padding(0),
                    .Dock = DockStyle.Fill,
                    .Tag = Color.FromName(KzColorNameList(i))}
            AddHandler btn.Click, AddressOf ColorSelected
            Me.Controls.Add(btn, 0, i)

            lbl = New Label With {
                    .Text = KzColorNameList(i),
                    .AutoSize = False,
                    .TextAlign = ContentAlignment.MiddleLeft,
                    .Dock = DockStyle.Fill}
            Me.Controls.Add(lbl, 1, i)
        Next

    End Sub

    Private Sub ColorSelected(sender As Object, e As EventArgs)
        Try
            If Me.Tag.GetType = GetType(TextBox) Then
                Dim t As TextBox = CType(Me.Tag, TextBox)
                Dim c As Color = CType(sender, Button).Tag
                t.Text = c.Name
                t.Tag = c
            End If
        Catch ex As Exception

        End Try
    End Sub
End Class 'KzColorListPanel

Public Class KzColorPalette

End Class

Public Class KzFontListPanel
    Inherits FlowLayoutPanel

    Public Sub New()
        FlowDirection = FlowDirection.TopDown
        AutoScroll = True
        SetList()
    End Sub

    Private Sub SetList()
        Dim btn As Button
        Dim ffs() As System.Windows.Media.FontFamily = System.Windows.Media.Fonts.SystemFontFamilies
        For Each ff As System.Windows.Media.FontFamily In ffs
            btn = New Button With {
                .Dock = DockStyle.Top,
                .Text = ff.FamilyNames.ToString,  ' ff.Name,
            .Font = New Font(ff.FamilyNames.ToString, 10.5, FontStyle.Regular)}
            AddHandler btn.Click, AddressOf FontSelected
            Me.Controls.Add(btn)
        Next
    End Sub

    Private Sub FontSelected(sender As Object, e As EventArgs)
        Try
            If Me.Tag.GetType = GetType(TextBox) Then
                Dim t As TextBox = CType(Me.Tag, TextBox)
                Dim b As Button = CType(sender, Button)
                t.Text = b.Font.Name
                t.Tag = b.Font
            End If
        Catch ex As Exception

        End Try
    End Sub
End Class

Public Class KzFlagsPanel
    Inherits FlowLayoutPanel

    Public Sub New()
        FlowDirection = FlowDirection.TopDown
        AutoScroll = True

    End Sub

    Public Property KeywordList As List(Of String)

End Class

Public Class KzFlagSelector
    Inherits CheckedListBox

    Public Sub New()

    End Sub


End Class