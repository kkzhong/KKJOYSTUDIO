'Imports System.Windows.Media
Imports System.Text

Public Class StylesForm

    Dim iList() As String = {
        "Type", "FrameWidth", "FrameColor", "Radius",
        "LineWidth", "LineColor", "FillColor",
        "ShadowWidth", "ShadowColor", "FontColor",
        "FontFamily", "FontSize", "FontStyle", "Font"}
    Dim fSizes() As Single = {
        5, 5.5, 6.5, 7.5, 8, 9, 10, 10.5, 11, 12,
        14, 16, 18, 20, 22, 24, 26, 28, 36, 48, 72}
    Dim ColorPanelIsOpened As Boolean = False

    Private Sub KzStyleForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        SetInputPanel()
        SetStatusList()
        SetText()
    End Sub

    Private Sub SetText()
        FrameColorBox.Text = Color.Black.Name
        FillColorBox.Text = Color.LightGray.Name
        FontColorBox.Text = Color.Blue.Name
        LineColorBox.Text = Color.Orange.Name
        ShadowColorBox.Text = Color.DarkGray.Name

        FontNameBox.Text = Me.Font.FontFamily.Name
        FontStyleBox.Text = "FontStyle." & Me.Font.Style.ToString
    End Sub

    Private Sub SetStatusList()
        With StatusCBox
            For i As Integer = 0 To 8
                Try
                    .Items.Add(CType(i, KzControlStatus).ToString)
                Catch ex As Exception
                End Try
            Next
            If .Items.Count > 0 Then .SelectedIndex = 0
        End With

        'With FontNameCBox
        '    .DropDownWidth = 200
        '    For Each fontFamily As FontFamily In Fonts.SystemFontFamilies
        '        ' FontFamily.Source contains the font family name.
        '        .Items.Add(fontFamily.Source)
        '    Next fontFamily
        'End With

        With FontSizeCBox
            For i As Integer = 0 To fSizes.GetUpperBound(0)
                .Items.Add(fSizes(i))
            Next
            .SelectedIndex = 7
        End With
    End Sub


    Private Sub SetInputPanel()
        Dim lbl As Label
        'Dim txt As TextBox

        With InputPanel
            For i As Integer = 0 To iList.GetUpperBound(0)
                lbl = New Label With {
                    .Text = iList(i),
                    .Dock = DockStyle.Fill,
                    .TextAlign = ContentAlignment.MiddleRight}
                .Controls.Add(lbl, 0, i)
            Next
        End With

        '    Dim iiList As New List(Of KzInputItem)
        '    For i As Integer = 0 To iList.Count - 1
        '        Dim kii As New KzInputItem
        '        kii.Label = iList(i)
        '        kii.PresetText = "Test"

        '        iiList.Add(kii)
        '    Next

        '    Dim iPanel As New KzInputListPanel With {
        '        .Dock = DockStyle.Fill, .InputItems = iiList}
        '    iPanel.ShowItems()
        '    TRightSpliter.Panel1.Controls.Clear()
        '    TRightSpliter.Panel1.Controls.Add(iPanel)
    End Sub

    Private Function GenCode() As String
        Dim sb As New StringBuilder
        sb.AppendLine("Dim theStyle As New KzDrawingStyle")
        sb.AppendLine("    With theStyle")
        sb.AppendLine("        .Type = " & StatusCBox.SelectedItem)
        sb.AppendLine("        .FrameWidth = " & FrameWidthUD.Value)
        sb.AppendLine("        .FrameColor = " & FrameColorBox.Text)
        sb.AppendLine("        .Radius = " & RadiusUD.Value)
        sb.AppendLine("        .LineWidth = " & LineWidthUD.Value)
        sb.AppendLine("        .LineColor = " & LineColorBox.Text)
        sb.AppendLine("        .FillColor = " & FillColorBox.Text)
        sb.AppendLine("        .ShadowWidth = " & ShadowWidthUD.Value)
        sb.AppendLine("        .ShadowColor = " & ShadowColorBox.Text)
        sb.AppendLine("        .FontColor = " & FontColorBox.Text)
        sb.AppendLine("        .FontFamily = " & FontNameBox.Text)
        sb.AppendLine("        .FontSize = " & FontSizeCBox.SelectedItem)
        sb.AppendLine("        .FontStyle = " & FontStyleBox.Text)
        sb.AppendLine("    End With")
        Return sb.ToString
    End Function

    Private Sub ItemChanged(sender As Object, e As EventArgs) Handles _
        StatusCBox.SelectedIndexChanged, FrameWidthUD.ValueChanged, FrameColorBox.TextChanged,
        RadiusUD.ValueChanged, LineWidthUD.ValueChanged, LineColorBox.TextChanged,
        FillColorBox.TextChanged, ShadowWidthUD.ValueChanged, ShadowColorBox.TextChanged,
        FontColorBox.TextChanged, FontNameBox.TextChanged, FontSizeCBox.SelectedIndexChanged, FontStyleBox.TextChanged

        If sender.Equals(FontSizeCBox) Or
            sender.Equals(FontNameBox) Or
            sender.Equals(FontStyleBox) Then

            FontBox.Text = "New Font(" & FontNameBox.Text & ", " &
                FontSizeCBox.SelectedItem & ", " & FontStyleBox.Text & ")"
            'FontBox.Tag =
        End If

        CodeBox.Text = GenCode()
        RootSpliter.Panel2.Invalidate()
    End Sub

    Private Sub ColorBoxActivated(sender As Object, e As EventArgs) Handles _
        FrameColorBox.GotFocus, FrameColorBox.Click, LineColorBox.GotFocus, LineColorBox.Click,
        FillColorBox.GotFocus, FillColorBox.Click, FontColorBox.GotFocus, FontColorBox.Click,
        ShadowColorBox.GotFocus, ShadowColorBox.Click, FontStyleBox.GotFocus, FontStyleBox.Click,
        FontNameBox.GotFocus, FontNameBox.Click

        Dim txt As TextBox = CType(sender, TextBox)
        txt.SelectAll()
        Me.Cursor = Cursors.WaitCursor

        With TRightSpliter.Panel1.Controls
            If sender.Equals(FontStyleBox) Then
                '字体格式列表
                If .ContainsKey("FStylePanel") Then
                    CType(.Find("FStylePanel", True)(0), CheckedListBox).Tag = txt
                Else
                    Dim clb As New CheckedListBox With {
                            .Name = "FStylePanel", .CheckOnClick = True,
                            .Dock = DockStyle.Fill, .Tag = txt}
                    clb.Items.AddRange({"Regular", "Bold", "Italic", "Underline", "Strikeout"})
                    AddHandler clb.SelectedIndexChanged, AddressOf StyleCheckedChanged
                    .Clear()
                    .Add(clb)
                End If

            ElseIf sender.Equals(FontNameBox) Then
                '字体名列表
                If .ContainsKey("FNamePanel") Then
                    CType(.Find("FNamePanel", True)(0), KzFontListPanel).Tag = txt
                Else
                    Dim lst As New KzFontListPanel With {
                        .Name = "FNamePanel", .Dock = DockStyle.Fill, .Tag = txt}
                    .Clear()
                    .Add(lst)
                End If

            Else
                '颜色名列表
                If .ContainsKey("ColorPanel") Then
                    CType(.Find("ColorPanel", True)(0), KzColorListPanel).Tag = txt
                Else
                    Dim kcp As New KzColorListPanel() With {
                            .Name = "ColorPanel", .Dock = DockStyle.Fill, .Tag = txt}
                    .Clear()
                    .Add(kcp)
                End If

            End If
        End With


        Me.Cursor = Cursors.Default
    End Sub

    'Private Sub FontStyleBoxActivated(sender As Object, e As EventArgs) Handles _
    '    FontStyleBox.GotFocus, FontStyleBox.Click

    '    Dim txt As TextBox = CType(sender, TextBox)
    '    txt.SelectAll()
    '    Me.Cursor = Cursors.WaitCursor
    '    With TRightSpliter.Panel1.Controls
    '        If .ContainsKey("FStylePanel") Then
    '            CType(.Find("FStylePanel", True)(0), CheckedListBox).Tag = txt
    '        Else
    '            Dim clb As New CheckedListBox With {
    '                .Name = "FStylePanel", .CheckOnClick = True,
    '                .Dock = DockStyle.Fill, .Tag = txt}
    '            clb.Items.AddRange({"Regular", "Bold", "Italic", "Underline", "Strikeout"})
    '            AddHandler clb.SelectedIndexChanged, AddressOf StyleCheckedChanged
    '            .Clear()
    '            .Add(clb)
    '        End If
    '    End With
    '    Me.Cursor = Cursors.Default
    'End Sub

    'Private Sub FontNameBoxActivated(sender As Object, e As EventArgs) Handles _
    '        FontNameBox.GotFocus, FontNameBox.Click

    'End Sub

    Private Sub StyleCheckedChanged(sender As Object, e As EventArgs)
        Dim c As CheckedListBox = CType(sender, CheckedListBox)
        Dim t As TextBox = CType(c.Tag, TextBox)

        With c.CheckedItems
            If .Count = 0 Or (.Count = 1 And c.CheckedItems(0) = "Regular") Then
                t.Text = "FontStyle.Regular"
                t.Tag = FontStyle.Regular
            Else
                t.Text = ""
                t.Tag = FontStyle.Regular
                For i As Integer = 0 To .Count - 1
                    t.Text &= " And " & "FontStyle." & c.CheckedItems(i)
                    t.Tag = t.Tag And [Enum].Parse(GetType(FontStyle), c.CheckedItems(i), True) 'GetName(GetType(FontStyle), c.CheckedItems(i))
                Next
            End If
        End With

    End Sub


    Private Sub RootSpliter_Panel2_Paint(sender As Object, e As PaintEventArgs) Handles RootSpliter.Panel2.Paint
        RootSpliter.Panel2.BackColor = Color.White

        Try
            Dim canvas As Rectangle = RootSpliter.Panel2.ClientRectangle
            Dim base As New Rectangle(x:=10, y:=10, width:=canvas.Height - 20, height:=canvas.Height - 20)

            With e.Graphics
                '.DrawRectangle(New Pen(Color.Black), base)
                '.DrawRectangle(New Pen(Color.FromName(FrameColorBox.Text), FrameWidthUD.Value), base)
                .DrawRectangle(New Pen(Color.FromName(FrameColorBox.Text)), base)
            End With
        Catch ex As Exception

        End Try

    End Sub


End Class