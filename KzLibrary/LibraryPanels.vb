Imports KzLibrary.KzConstants
Imports System.Drawing.Text

Public Class KzInputPanel

End Class

Public Class KzInputItem

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

Public Class KzFlagSelector
    Inherits CheckedListBox

    Public Sub New()

    End Sub


End Class