'Imports System.Windows.Media
Imports System.Text

Public Class StylesForm

    Public ReadOnly Property OutputStyle As KzDrawingStyle
        Get
            Return New KzDrawingStyle(KzStatus.None) With {
                    .Type = StatusCBox.SelectedItem,
                    .FrameWidth = FrameWidthUD.Value,
                    .FrameColor = FrameColorBox.Tag,
                    .Radius = RadiusUD.Value,
                    .LineWidth = LineWidthUD.Value,
                    .LineColor = LineColorBox.Tag,
                    .FillColor = FillColorBox.Tag,
                    .InnerColor = InnerColorBox.Tag,
                    .ShadowWidth = ShadowWidthUD.Value,
                    .ShadowColor = ShadowColorBox.Tag,
                    .FontColor = FontColorBox.Tag,
                    .FontName = FontNameBox.Tag,
                    .FontSize = FontSizeCBox.SelectedItem,
                    .FontStyle = FontStyleCBox.SelectedItem}
        End Get
    End Property

    Dim iList() As String = {"Name",
        "Type", "FrameWidth", "FrameColor", "Radius",
        "LineWidth", "LineColor", "FillColor", "InnerColor",
        "ShadowWidth", "ShadowColor", "FontColor",
        "FontFamily", "FontSize", "FontStyle"}
    Dim fSizes() As Single = {
        5, 5.5, 6.5, 7.5, 8, 9, 10, 10.5, 11, 12,
        14, 16, 18, 20, 22, 24, 26, 28, 36, 48, 72}

    Private Sub KzStyleForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Initialize()
    End Sub

    Private Sub Initialize()
        Me.SuspendLayout()

        SingleRadio.Checked = True

        Dim lbl As Label
        With InputPanel
            For i As Integer = 0 To iList.GetUpperBound(0)
                lbl = New Label With {
                    .Text = iList(i),
                    .Dock = DockStyle.Fill,
                    .TextAlign = ContentAlignment.MiddleRight}
                .Controls.Add(lbl, 0, i)
            Next
        End With

        NameBox.Text = "TheStyle"
        FrameColorBox.Text = Color.Black.Name
        FrameColorBox.Tag = Color.Black
        FillColorBox.Text = Color.LightGray.Name
        FillColorBox.Tag = Color.LightGray
        FontColorBox.Text = Color.Blue.Name
        FontColorBox.Tag = Color.Blue
        InnerColorBox.Text = Color.Ivory.Name
        InnerColorBox.Tag = Color.Ivory
        LineColorBox.Text = Color.Orange.Name
        LineColorBox.Tag = Color.Orange
        ShadowColorBox.Text = Color.DarkGray.Name
        ShadowColorBox.Tag = Color.DarkGray
        FontNameBox.Text = Me.Font.FontFamily.Name
        FontNameBox.Tag = Me.Font.FontFamily

        With StatusCBox
            For i As Integer = 0 To 8
                Try
                    .Items.Add(CType(i, KzStatus))
                Catch ex As Exception
                End Try
            Next
            .SelectedIndex = 0
        End With

        With FontSizeCBox
            For i As Integer = 0 To fSizes.GetUpperBound(0)
                .Items.Add(fSizes(i))
            Next
            .SelectedIndex = 7
        End With

        With FontStyleCBox
            For i As Integer = 0 To 15
                Try
                    .Items.Add(CType(i, FontStyle))
                Catch ex As Exception
                End Try
            Next
            .DropDownWidth = 128
            .SelectedIndex = 0
        End With

        MsgLabel.Text = "No infomation."
        Me.ResumeLayout()
    End Sub

    Private Function GenSingleStyleCode() As String
        Dim sb As New StringBuilder
        sb.AppendLine("    Dim " & NameBox.Text & " As New KzDrawingStyle With {")
        'sb.AppendLine("    With theStyle")

        Try
            sb.AppendLine("        .Type = KzStatus." & StatusCBox.SelectedItem.ToString)
        Catch ex As Exception
            sb.AppendLine("        .Type = KzStatus.None")
        End Try

        sb.AppendLine("        .FrameWidth = " & FrameWidthUD.Value)
        sb.AppendLine("        .FrameColor = Color." & FrameColorBox.Text)
        sb.AppendLine("        .Radius = " & RadiusUD.Value)
        sb.AppendLine("        .LineWidth = " & LineWidthUD.Value)
        sb.AppendLine("        .LineColor = Color." & LineColorBox.Text)
        sb.AppendLine("        .FillColor = Color." & FillColorBox.Text)
        sb.AppendLine("        .InnerColor = Color." & InnerColorBox.Text)
        sb.AppendLine("        .ShadowWidth = " & ShadowWidthUD.Value)
        sb.AppendLine("        .ShadowColor = Color." & ShadowColorBox.Text)
        sb.AppendLine("        .FontColor = Color." & FontColorBox.Text)
        sb.AppendLine("        .FontFamily = """ & FontNameBox.Text & """")
        sb.AppendLine("        .FontSize = " & FontSizeCBox.SelectedItem)

        Dim s As String = ""
        If FontStyleCBox.Text.Contains(",") Then
            Dim ss As String() = FontStyleCBox.Text.Split(",")
            For i = 0 To ss.GetUpperBound(0)
                If i = 0 Then
                    s = "FontStyle." & ss(i).Trim
                Else
                    s = s & " And " & "FontStyle." & ss(i).Trim
                End If
            Next
        Else
            s = "FontStyle." & FontStyleCBox.Text
        End If

        sb.AppendLine("        .FontStyle = " & s)
        sb.AppendLine("    }")
        Return sb.ToString
    End Function

    Private Sub ItemChanged(sender As Object, e As EventArgs) Handles _
        NameBox.TextChanged, StatusCBox.SelectedIndexChanged,
        FrameWidthUD.ValueChanged, FrameColorBox.TextChanged, RadiusUD.ValueChanged,
        LineWidthUD.ValueChanged, LineColorBox.TextChanged, InnerColorBox.TextChanged,
        FillColorBox.TextChanged, ShadowWidthUD.ValueChanged, ShadowColorBox.TextChanged,
        FontColorBox.TextChanged, FontNameBox.TextChanged, FontSizeCBox.SelectedIndexChanged,
        FontStyleCBox.SelectedIndexChanged, ShowWordsBox.TextChanged

        If sender.GetType = GetType(TextBox) Then
            With CType(sender, TextBox)
                Try
                    If .Tag.GetType = GetType(Color) Then
                        If Not .Text = CType(.Tag, Color).Name Then
                            Try
                                .Tag = Color.FromName(.Text)
                            Catch ex As Exception

                            End Try
                        End If
                    ElseIf .Tag.GetType = GetType(FontFamily) Then
                        If Not .Text = CType(.Tag, FontFamily).Name Then
                            Try
                                .Tag = New FontFamily(.Text)
                            Catch ex As Exception

                            End Try
                        End If
                    End If
                Catch ex As Exception

                End Try

            End With
        End If

        CodeBox.Text = GenSingleStyleCode()
        BottomSpliter.Panel1.Invalidate()
    End Sub

    Private Sub BoxActivated(sender As Object, e As EventArgs) Handles _
        FrameColorBox.GotFocus, FrameColorBox.Click, LineColorBox.GotFocus, LineColorBox.Click,
        FillColorBox.GotFocus, FillColorBox.Click, InnerColorBox.GotFocus, InnerColorBox.Click,
        FontColorBox.GotFocus, FontColorBox.Click, FontNameBox.GotFocus, FontNameBox.Click,
        ShadowColorBox.GotFocus, ShadowColorBox.Click

        Dim txt As TextBox = CType(sender, TextBox)
        txt.SelectAll()
        Me.Cursor = Cursors.WaitCursor

        With TRightSpliter.Panel1.Controls
            If sender.Equals(FontStyleCBox) Then
                MsgLabel.Text = "FontStyle setting."

            ElseIf sender.Equals(FontNameBox) Then
                '字体名列表
                If .ContainsKey("FNamePanel") Then
                    CType(.Find("FNamePanel", True)(0), KzFontListPanel).Tag = txt
                Else
                    Dim lst As New KzFontListPanel With {
                        .Name = "FNamePanel", .Dock = DockStyle.Fill, .Tag = txt}
                    MsgLabel.Text = "Total " & lst.Controls.Count & " font families found."
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
                    MsgLabel.Text = "Total " & kcp.Controls.Count / 2 & " colors listed."
                    .Clear()
                    .Add(kcp)
                End If

            End If
        End With

        Me.Cursor = Cursors.Default
    End Sub

    Private Sub SamplePaint(sender As Object, e As PaintEventArgs) Handles BottomSpliter.Panel1.Paint
        BottomSpliter.Panel1.BackColor = Color.White

        Try
            Dim st As KzDrawingStyle = Me.OutputStyle

            Dim canvas As New Rectangle(
                x:=BottomSpliter.Panel1.ClientRectangle.X + 2,
                y:=BottomSpliter.Panel1.ClientRectangle.Y + 2,
                width:=BottomSpliter.Panel1.ClientRectangle.Width - 4,
                height:=BottomSpliter.Panel1.ClientRectangle.Height - 4)

            Dim base As New Rectangle(
                x:=canvas.Width * 0.05, y:=canvas.Height * 0.05,
                width:=canvas.Width * 0.9, height:=canvas.Height * 0.9)

            With e.Graphics
                .InterpolationMode = Drawing2D.InterpolationMode.HighQualityBicubic
                .SmoothingMode = Drawing2D.SmoothingMode.HighQuality
                .TextRenderingHint = Drawing.Text.TextRenderingHint.ClearTypeGridFit

                Dim body, shadow As Rectangle
                Dim rbody As RoundRectangle

                If st.ShadowWidth = 0 Then
                    body = base
                    shadow = Nothing
                    rbody = New RoundRectangle(body, st.Radius)
                    If st.Radius > 0 Then

                        .FillPath(st.FillBrush, rbody.Path)
                    Else
                        .FillRectangle(st.FillBrush, body)
                    End If
                Else
                    body = New Rectangle(x:=base.X, y:=base.Y,
                        width:=base.Width - st.ShadowWidth, height:=base.Height - st.ShadowWidth)
                    shadow = New Rectangle(
                        x:=base.X + st.ShadowWidth, y:=base.Y + st.ShadowWidth,
                        width:=base.Width - st.ShadowWidth, height:=base.Height - st.ShadowWidth)
                    rbody = New RoundRectangle(body, st.Radius)

                    If st.Radius > 0 Then
                        Dim rshadow As New RoundRectangle(shadow, st.Radius)
                        .FillPath(st.ShadowFillBrush, rshadow.Path)
                        .FillPath(st.FillBrush, rbody.Path)
                    Else
                        .FillRectangle(st.ShadowFillBrush, shadow)
                        .FillRectangle(st.FillBrush, body)
                    End If
                End If

                If st.FrameWidth > 0 Then
                    If st.Radius > 0 Then
                        .DrawPath(st.FramePen, rbody.Path)
                    Else
                        .DrawRectangle(st.FramePen, body)
                    End If
                End If

                Dim wpad As New Rectangle(
                    x:=body.Left + body.Width / 3,
                    y:=body.Top + body.Height / 3 / 2,
                    width:=body.Width / 3 * 2 - 5,
                    height:=body.Height / 3 * 2)

                .FillRectangle(st.InnerFillBrush, wpad)
                If st.LineWidth > 0 Then .DrawRectangle(st.InnerPen, wpad)

                Dim sm As New StringFormat With {
                    .Alignment = StringAlignment.Near,
                    .LineAlignment = StringAlignment.Center,
                    .Trimming = StringTrimming.EllipsisCharacter}

                .DrawString(ShowWordsBox.Text, st.Font, st.FontBrush, wpad, sm)
            End With
        Catch ex As Exception

        End Try

    End Sub

    Private Sub LetsGoButton_Click(sender As Object, e As EventArgs) Handles LetsGoButton.Click
        Me.Close()
    End Sub

    Private Sub GetCodeButton_Click(sender As Object, e As EventArgs) Handles GetCodeButton.Click
        Clipboard.SetText(CodeBox.Text)
    End Sub

    Private Sub SingleRadio_CheckedChanged(sender As Object, e As EventArgs) Handles _
        SingleRadio.CheckedChanged, TripleRadio.CheckedChanged, TabRadio.CheckedChanged

        With CmdPanel
            For i As Integer = 3 To 6
                For j As Integer = 0 To 5
                    Try
                        If SingleRadio.Checked Then
                            .GetControlFromPosition(j, i).Enabled = False
                        ElseIf TripleRadio.Checked Then
                            If (i = 3 And (j = 0 Or j = 1 Or j = 2)) Or (i = 4 And (j = 0 Or j = 1 Or j = 2)) Then
                                .GetControlFromPosition(j, i).Enabled = True
                            Else
                                .GetControlFromPosition(j, i).Enabled = False
                            End If
                        ElseIf TabRadio.Checked Then
                            .GetControlFromPosition(j, i).Enabled = True
                        End If
                    Catch ex As Exception

                    End Try
                Next
            Next
        End With
    End Sub
End Class