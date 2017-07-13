Imports KzLibrary.KzConstants
Imports System.Drawing.Text

Public Class KzInputPanel

End Class

Public Class KzInputItem

End Class

Public Class KzFlagSelector
    Inherits CheckedListBox

    Public Sub New()

    End Sub

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

Public Class KzFontListPanel
    Inherits FlowLayoutPanel

    Dim iByFont As Boolean

    Public Sub New()
        FlowDirection = FlowDirection.TopDown
        WrapContents = False
        AutoScroll = True
        Padding = New Padding(0)

        iByFont = True
        SetList()
    End Sub

    Public Property ShowNameByFont As Boolean
        Get
            Return iByFont
        End Get
        Set(value As Boolean)
            iByFont = value
            SetList()
        End Set
    End Property

    Public Property ExceptedList As String() = {}

    Private Sub SetList()
        Dim btn As Button
        Dim fmls As FontFamily() = (New InstalledFontCollection).Families
        Me.SuspendLayout()
        Controls.Clear()

        For Each fml As FontFamily In fmls

            btn = New Button With {
                .Height = 30,
                .Width = ClientRectangle.Width,
                .Margin = New Padding(0),
                .Text = fml.Name,
                .TextAlign = ContentAlignment.MiddleLeft,
                .BackColor = Color.WhiteSmoke}

            If iByFont Then btn.Font = New Font(fml, btn.Font.Size, btn.Font.Style)

            AddHandler btn.Click, AddressOf FontSelected
            Controls.Add(btn)
        Next
        Me.ResumeLayout()
    End Sub

    Private Sub FontSelected(sender As Object, e As EventArgs)
        Try
            If Tag.GetType = GetType(TextBox) Then
                Dim t As TextBox = CType(Tag, TextBox)
                Dim b As Button = CType(sender, Button)
                t.Text = b.Font.Name '.FontFamily.GetName(0)
                t.Tag = b.Font.FontFamily
            End If
        Catch ex As Exception

        End Try
    End Sub

    Protected Overrides Sub OnSizeChanged(e As EventArgs)
        MyBase.OnSizeChanged(e)
        For Each btn As Button In Me.Controls
            btn.Width = ClientRectangle.Width
        Next
    End Sub
End Class 'KzFontListPanel

Public Class KzColorPicker

End Class 'KzColorPicker

Public Class KzColorSticker
    Inherits UserControl

    Friend WithEvents Checker As CheckBox
    Public Color As Color
    Private Status As KzStatus = KzStatus.Normal

    Public Property Look As KzAppearances
    Public Property Checked As Boolean = False
    Public Property ShowRAGB As Boolean = False
    Public Property InnerMargin As Padding = New Padding(0)

    Private Sub InitializeComponent()
        Me.Checker = New System.Windows.Forms.CheckBox()
        Me.SuspendLayout()
        '
        'Checker
        '
        Me.Checker.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Checker.AutoSize = True
        Me.Checker.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Checker.Location = New System.Drawing.Point(183, 2)
        Me.Checker.Margin = New System.Windows.Forms.Padding(0)
        Me.Checker.Name = "Checker"
        Me.Checker.Size = New System.Drawing.Size(12, 11)
        Me.Checker.TabIndex = 0
        Me.Checker.UseVisualStyleBackColor = True
        '
        'TestColorPicker
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Checker)
        Me.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "TestColorPicker"
        Me.Size = New System.Drawing.Size(196, 42)
        Me.ResumeLayout(False)
        Me.PerformLayout()
    End Sub

    Public Sub New(Optional color As Color = Nothing)
        InitializeComponent()

        If color = Nothing Then
            Me.Color = Color.FromArgb(0)
        Else
            Me.Color = color
        End If

        SetDefaultAppearances()
    End Sub

    Private Sub SetDefaultAppearances()
        Me.Look = New KzAppearances With {
            .FontFamily = New FontFamily("Consolas"), .FontSize = 10.5}

        Me.Look.Normal = New KzAppearance With {
           .BackColor = Color.WhiteSmoke, .ForeColor = Color.Black, .BorderSize = 0,
           .BorderColor = Color.Black, .FontStyle = FontStyle.Regular}

        Me.Look.Hover = New KzAppearance With {
          .BackColor = Color.LightGray, .ForeColor = Color.Black, .BorderSize = 4,
          .BorderColor = Color.DarkGray, .FontStyle = FontStyle.Bold}

        Me.Look.Pressed = New KzAppearance With {
           .BackColor = Color.WhiteSmoke, .ForeColor = Color.Black, .BorderSize = 2,
           .BorderColor = Color.DarkGray, .FontStyle = FontStyle.Regular}

        Me.Look.Checked = New KzAppearance With {
           .BackColor = Color.WhiteSmoke, .ForeColor = Color.Black, .BorderSize = 4,
           .BorderColor = Color.Black, .FontStyle = FontStyle.Regular}
    End Sub

    Protected Overrides Sub OnPaint(e As PaintEventArgs)
        MyBase.OnPaint(e)

        Dim colorRect As New Rectangle(
            x:=0, y:=0, width:=Math.Min(Math.Max(Me.Height, Me.Width / 3), Me.Width / 2), height:=Me.Height)
        Dim nameRect As New Rectangle(
            x:=colorRect.Right + 5, y:=Me.Top + 2, width:=Me.Width - colorRect.Width - 5, height:=(Me.Height - 4) / 2)
        Dim codeRect As New Rectangle(
            x:=colorRect.Right + 5, y:=nameRect.Bottom + 1, width:=nameRect.Width, height:=nameRect.Height - 1)

        Dim sf As New StringFormat With {
            .Alignment = StringAlignment.Near,
            .LineAlignment = StringAlignment.Center,
            .Trimming = StringTrimming.EllipsisCharacter,
            .FormatFlags = StringFormatFlags.NoWrap}

        With e.Graphics
            Dim ap As New KzAppearance
            Dim cc As Color
            Select Case Me.Status
                Case KzStatus.Normal : ap = Me.Look.Normal : cc = Color.DarkGray
                Case KzStatus.Hover : ap = Me.Look.Hover : cc = Color.WhiteSmoke
                Case KzStatus.Pressed : ap = Me.Look.Pressed : cc = Color.DarkGray
                Case KzStatus.Checked : ap = Me.Look.Checked : cc = Color.DarkGray
            End Select

            .FillRectangle(ap.BackBrush, Me.ClientRectangle) 'MyBackColor

            .FillRectangle(New SolidBrush(Me.Color),
                           x:=colorRect.X + Me.InnerMargin.Left,
                           y:=colorRect.Y + Me.InnerMargin.Top,
                           width:=colorRect.Width - Me.InnerMargin.Horizontal,
                           height:=colorRect.Height - Me.InnerMargin.Vertical)

            If ap.BorderSize > 0 Then .DrawRectangle(ap.BorderPen, Me.ClientRectangle)

            Dim f As New Font(Me.Look.FontFamily, Me.Look.FontSize, ap.FontStyle)
            .DrawString(Me.Color.Name, f, ap.ForeBrush, nameRect, sf)

            Dim t As String = If(ShowRAGB,
                "ARGB(" & Me.Color.A & "," & Me.Color.R & "," & Me.Color.G & "," & Me.Color.B & ")",
                "&H" & Hex(Me.Color.ToArgb))

            .DrawString(t, f, New SolidBrush(cc), codeRect, sf)
        End With
    End Sub

    Protected Overrides Sub OnSizeChanged(e As EventArgs)
        MyBase.OnSizeChanged(e)
        Me.Invalidate()
    End Sub

    'Protected Overrides Sub OnMouseMove(e As MouseEventArgs)
    '    MyBase.OnMouseMove(e)
    '    Me.Status = KzStatus.Hover
    '    Me.Invalidate()
    'End Sub

    Protected Overrides Sub OnMouseEnter(e As EventArgs)
        MyBase.OnMouseEnter(e)
        Me.Status = KzStatus.Hover
        Me.Invalidate()
    End Sub

    Protected Overrides Sub OnMouseDown(e As MouseEventArgs)
        MyBase.OnMouseDown(e)
        Me.Status = KzStatus.Pressed
        Me.Invalidate()
    End Sub

    Protected Overrides Sub OnMouseUp(e As MouseEventArgs)
        MyBase.OnMouseUp(e)
        Me.Status = KzStatus.Hover
        Me.Invalidate()
    End Sub

    Protected Overrides Sub OnMouseLeave(e As EventArgs)
        MyBase.OnMouseLeave(e)
        Me.Status = KzStatus.Normal
        Me.Invalidate()
    End Sub

    Private Sub Checker_CheckedChanged(sender As Object, e As EventArgs) Handles Checker.CheckedChanged
        Me.Checked = Checker.Checked

        If Me.Checked Then
            Me.Look.Normal.BorderSize = 2
            Me.Look.Hover.BorderSize = 2
            Me.Look.Hover.BorderColor = Color.Black
            Me.Look.Pressed.BorderColor = Color.Black
        Else
            Me.Look.Normal.BorderSize = 0
            Me.Look.Hover.BorderSize = 4
            Me.Look.Hover.BorderColor = Color.DarkGray
            Me.Look.Pressed.BorderColor = Color.DarkGray
        End If

        Me.Invalidate()
    End Sub

    Private Sub Checker_MouseEnter(sender As Object, e As EventArgs) Handles Checker.MouseEnter, Checker.MouseLeave
        Me.Status = KzStatus.Hover
        Me.Invalidate()
    End Sub
End Class 'KzColorSticker

Public Class KzFontPicker

End Class