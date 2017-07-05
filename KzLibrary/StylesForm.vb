Imports System.Windows.Media
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

    Private Sub KzStyleForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        SetInputPanel()
        SetStatusList()

    End Sub

    Private Sub SetStatusList()
        With StatusCBox
            For i As Integer = 0 To 8
                Try
                    .Items.Add(CType(i, KzControlStatus).ToString)
                Catch ex As Exception

                End Try
            Next
        End With

        With FontNameCBox
            .DropDownWidth = 200
            For Each fontFamily As FontFamily In Fonts.SystemFontFamilies
                ' FontFamily.Source contains the font family name.
                .Items.Add(fontFamily.Source)
            Next fontFamily
        End With

        With FontSizeCBox
            For i As Integer = 0 To fSizes.GetUpperBound(0)
                .Items.Add(fSizes(i))
                '.DisplayMember = fSizes(i)
                '.ValueMember = fSizes(i)
            Next
        End With

        'For Each ud As NumericUpDown In InputPanel.Controls
        '    ud.Minimum = 0
        '    ud.Maximum = 9
        'Next
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
        'Dim xs As String = "    "
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
        sb.AppendLine("        .FontFamily = " & FontNameCBox.SelectedItem)
        sb.AppendLine("        .FontSize = " & FontSizeCBox.SelectedItem)
        sb.AppendLine("        .FontStyle = " & FontStyleBox.Text)
        sb.AppendLine("    End With")
        Return sb.ToString
    End Function

    Private Sub ItemChanged(sender As Object, e As EventArgs) Handles _
        StatusCBox.SelectedIndexChanged, FrameWidthUD.ValueChanged, FrameColorBox.TextChanged,
        RadiusUD.ValueChanged, LineWidthUD.ValueChanged, LineColorBox.TextChanged,
        FillColorBox.TextChanged, ShadowWidthUD.ValueChanged, ShadowColorBox.TextChanged,
        FontColorBox.TextChanged, FontNameCBox.SelectedIndexChanged, FontSizeCBox.SelectedIndexChanged,
        FontSizeCBox.TextChanged

        CodeBox.Text = GenCode()
    End Sub

    Private Sub FrameColorGo_Click(sender As Object, e As EventArgs) Handles FrameColorGo.Click
        Dim kcp As New KzColorListPanel(KzColorPanelCategory.WebColors) With {
            .Dock = DockStyle.Fill}
        TRightSpliter.Panel1.Controls.Add(kcp)
    End Sub
End Class