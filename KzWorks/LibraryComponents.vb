Imports System.Drawing.Drawing2D

Namespace KzLibrary
    Public Class TextDialog
        Inherits Form

        'Windows 窗体设计器所必需的
        Private components As System.ComponentModel.IContainer

        'Form 重写 Dispose，以清理组件列表。
        <System.Diagnostics.DebuggerNonUserCode()>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            Try
                If disposing AndAlso components IsNot Nothing Then
                    components.Dispose()
                End If
            Finally
                MyBase.Dispose(disposing)
            End Try
        End Sub

        '注意: 以下过程是 Windows 窗体设计器所必需的
        '可以使用 Windows 窗体设计器修改它。  
        '不要使用代码编辑器修改它。
        <System.Diagnostics.DebuggerStepThrough()>
        Private Sub InitializeComponent()
            'Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(TextDialog))
            Me.RootSplitContainer = New SplitContainer()
            Me.MessageTextBox = New TextBox()
            Me.TextDialogToolStrip = New ToolStrip()
            Me.SaveToolStripButton = New ToolStripButton()
            Me.CopyToolStripButton = New ToolStripButton()
            Me.ToolStripSeparator1 = New ToolStripSeparator()
            Me.SearchToolStripTextBox = New ToolStripTextBox()
            Me.GoToolStripButton = New ToolStripButton()
            Me.OKCmd = New Button()
            Me.CancelCmd = New Button()
            Me.CountLabel = New Label()
            CType(Me.RootSplitContainer, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.RootSplitContainer.Panel1.SuspendLayout()
            Me.RootSplitContainer.Panel2.SuspendLayout()
            Me.RootSplitContainer.SuspendLayout()
            Me.TextDialogToolStrip.SuspendLayout()
            Me.SuspendLayout()
            '
            'RootSplitContainer
            '
            Me.RootSplitContainer.Dock = DockStyle.Fill
            Me.RootSplitContainer.FixedPanel = FixedPanel.Panel2
            Me.RootSplitContainer.Location = New Point(0, 0)
            Me.RootSplitContainer.Name = "RootSplitContainer"
            Me.RootSplitContainer.Orientation = Orientation.Horizontal
            '
            'RootSplitContainer.Panel1
            '
            Me.RootSplitContainer.Panel1.Controls.Add(Me.MessageTextBox)
            Me.RootSplitContainer.Panel1.Controls.Add(Me.TextDialogToolStrip)
            '
            'RootSplitContainer.Panel2
            '
            Me.RootSplitContainer.Panel2.Controls.Add(Me.CountLabel)
            Me.RootSplitContainer.Panel2.Controls.Add(Me.OKCmd)
            Me.RootSplitContainer.Panel2.Controls.Add(Me.CancelCmd)
            Me.RootSplitContainer.Size = New Size(404, 302)
            Me.RootSplitContainer.SplitterDistance = 254
            Me.RootSplitContainer.TabIndex = 0
            '
            'MessageTextBox
            '
            Me.MessageTextBox.BorderStyle = BorderStyle.None
            Me.MessageTextBox.Dock = DockStyle.Fill
            Me.MessageTextBox.Location = New Point(0, 25)
            Me.MessageTextBox.Multiline = True
            Me.MessageTextBox.Name = "MessageTextBox"
            Me.MessageTextBox.ScrollBars = ScrollBars.Vertical
            Me.MessageTextBox.Size = New Size(404, 229)
            Me.MessageTextBox.TabIndex = 1
            '
            'TextDialogToolStrip
            '
            Me.TextDialogToolStrip.GripStyle = ToolStripGripStyle.Hidden
            Me.TextDialogToolStrip.Items.AddRange(New ToolStripItem() {Me.SaveToolStripButton, Me.CopyToolStripButton, Me.ToolStripSeparator1, Me.SearchToolStripTextBox, Me.GoToolStripButton})
            Me.TextDialogToolStrip.Location = New Point(0, 0)
            Me.TextDialogToolStrip.Name = "TextDialogToolStrip"
            Me.TextDialogToolStrip.RenderMode = ToolStripRenderMode.System
            Me.TextDialogToolStrip.Size = New Size(404, 25)
            Me.TextDialogToolStrip.TabIndex = 0
            Me.TextDialogToolStrip.Text = "ToolStrip1"
            '
            'SaveToolStripButton
            '
            Me.SaveToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image
            'Me.SaveToolStripButton.Image = CType(resources.GetObject("SaveToolStripButton.Image"), Image)
            Me.SaveToolStripButton.Image = My.Resources.Add
            Me.SaveToolStripButton.ImageTransparentColor = Color.Magenta
            Me.SaveToolStripButton.Name = "SaveToolStripButton"
            Me.SaveToolStripButton.Size = New Size(23, 22)
            Me.SaveToolStripButton.Text = "ToolStripButton1"
            '
            'CopyToolStripButton
            '
            Me.CopyToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image
            'Me.CopyToolStripButton.Image = CType(resources.GetObject("CopyToolStripButton.Image"), Image)
            Me.CopyToolStripButton.Image = My.Resources.Refresh
            Me.CopyToolStripButton.ImageTransparentColor = Color.Magenta
            Me.CopyToolStripButton.Name = "CopyToolStripButton"
            Me.CopyToolStripButton.Size = New Size(23, 22)
            Me.CopyToolStripButton.Text = "複製到剪貼板"
            '
            'ToolStripSeparator1
            '
            Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
            Me.ToolStripSeparator1.Size = New Size(6, 25)
            '
            'SearchToolStripTextBox
            '
            Me.SearchToolStripTextBox.AutoCompleteMode = AutoCompleteMode.SuggestAppend
            Me.SearchToolStripTextBox.AutoCompleteSource = AutoCompleteSource.HistoryList
            Me.SearchToolStripTextBox.BorderStyle = BorderStyle.None
            Me.SearchToolStripTextBox.Name = "SearchToolStripTextBox"
            Me.SearchToolStripTextBox.Size = New Size(100, 25)
            '
            'GoToolStripButton
            '
            Me.GoToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image
            'Me.GoToolStripButton.Image = CType(resources.GetObject("GoToolStripButton.Image"), Image)
            Me.GoToolStripButton.Image = My.Resources.Play
            Me.GoToolStripButton.ImageTransparentColor = Color.Magenta
            Me.GoToolStripButton.Name = "GoToolStripButton"
            Me.GoToolStripButton.Size = New Size(23, 22)
            Me.GoToolStripButton.Text = "搜索"
            '
            'OKCmd
            '
            Me.OKCmd.Anchor = CType((AnchorStyles.Bottom Or AnchorStyles.Right), AnchorStyles)
            Me.OKCmd.DialogResult = DialogResult.OK
            Me.OKCmd.Location = New Point(236, 12)
            Me.OKCmd.Name = "OKCmd"
            Me.OKCmd.Size = New Size(75, 23)
            Me.OKCmd.TabIndex = 1
            Me.OKCmd.Text = "確定"
            Me.OKCmd.UseVisualStyleBackColor = True
            '
            'CancelCmd
            '
            Me.CancelCmd.Anchor = CType((AnchorStyles.Bottom Or AnchorStyles.Right), AnchorStyles)
            Me.CancelCmd.DialogResult = DialogResult.Cancel
            Me.CancelCmd.Location = New Point(317, 12)
            Me.CancelCmd.Name = "CancelCmd"
            Me.CancelCmd.Size = New Size(75, 23)
            Me.CancelCmd.TabIndex = 0
            Me.CancelCmd.Text = "取消"
            Me.CancelCmd.UseVisualStyleBackColor = True
            '
            'CountLabel
            '
            Me.CountLabel.AutoSize = True
            Me.CountLabel.Location = New Point(4, 8)
            Me.CountLabel.Name = "CountLabel"
            Me.CountLabel.Size = New Size(41, 12)
            Me.CountLabel.TabIndex = 2
            Me.CountLabel.Text = "Label1"
            '
            'TextDialog
            '
            Me.AutoScaleDimensions = New SizeF(6.0!, 12.0!)
            Me.AutoScaleMode = AutoScaleMode.Font
            Me.ClientSize = New Size(404, 302)
            Me.Controls.Add(Me.RootSplitContainer)
            Me.FormBorderStyle = FormBorderStyle.SizableToolWindow
            Me.Name = "TextDialog"
            Me.Text = "TextDialog"
            Me.RootSplitContainer.Panel1.ResumeLayout(False)
            Me.RootSplitContainer.Panel1.PerformLayout()
            Me.RootSplitContainer.Panel2.ResumeLayout(False)
            Me.RootSplitContainer.Panel2.PerformLayout()
            CType(Me.RootSplitContainer, System.ComponentModel.ISupportInitialize).EndInit()
            Me.RootSplitContainer.ResumeLayout(False)
            Me.TextDialogToolStrip.ResumeLayout(False)
            Me.TextDialogToolStrip.PerformLayout()
            Me.ResumeLayout(False)

        End Sub

        Friend WithEvents RootSplitContainer As SplitContainer
        Friend WithEvents MessageTextBox As TextBox
        Friend WithEvents TextDialogToolStrip As ToolStrip
        Friend WithEvents SaveToolStripButton As ToolStripButton
        Friend WithEvents CopyToolStripButton As ToolStripButton
        Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
        Friend WithEvents SearchToolStripTextBox As ToolStripTextBox
        Friend WithEvents GoToolStripButton As ToolStripButton
        Friend WithEvents OKCmd As Button
        Friend WithEvents CancelCmd As Button
        Friend WithEvents CountLabel As Label

        <STAThread()>
        Shared Sub Main()
            Application.EnableVisualStyles()
            Application.Run(New InputDialog())
        End Sub

        Public Sub New(ByVal text As String)
            ' 此调用是设计器所必需的。
            InitializeComponent()

            ' 在 InitializeComponent() 调用之后添加任何初始化。

            Me.MessageTextBox.Text = text
            Me.CountLabel.Text = "文本長度：" & Strings.Format(Me.MessageTextBox.TextLength, "#,0")
        End Sub
    End Class

    '■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■

    Public Class InputDialog
        Inherits Form

        <STAThread()>
        Shared Sub Main()
            Application.EnableVisualStyles()
            Application.Run(New InputDialog())
        End Sub

#Region "Public Properties"
        Public Property InputItems As String() 'Label
        Public Property ItemPresets As String() 'PresetText
        Public Property ItemToolTips As String() 'ToolTipText
        Public Property Pilot As String
        Public Property Remarks As String
        Public Property AutoColon As Boolean
        Public Property ItemLabelWidthPercentage As Integer
        Public Property ShowInputToolTips As Boolean

        Public ReadOnly Property InputResults As String()
            Get
                Return iResults
            End Get
        End Property
#End Region

        Private flp As FlowLayoutPanel
        Private PilotLabel As Label
        Private tlpInput As TableLayoutPanel
        Private RemarksLabel As Label
        Private tlpCommand As TableLayoutPanel
        Private OKCommand, CancelCommand As Button
        Private iResults As String()
        Private ttp As New ToolTip


        Public Sub New()
            [Text] = "InputPanel"
            [Padding] = New Padding(5, 10, 5, 10)
            [FormBorderStyle] = FormBorderStyle.FixedDialog
            If Me.Parent Is Nothing Then
                [StartPosition] = FormStartPosition.CenterScreen
            Else
                [StartPosition] = FormStartPosition.CenterParent
            End If

            AutoColon = False
            ItemLabelWidthPercentage = 0
            ShowInputToolTips = True
        End Sub

        Private Sub InitializeComponent()
            Me.SuspendLayout()
            '
            'InputDialog
            '
            Me.ClientSize = New Size(320, 240)
            Me.Name = "InputDialog"

            Me.ResumeLayout(False)

        End Sub

        Private Sub InputDialog_Load(sender As Object, e As EventArgs) Handles MyBase.Load

            flp = New FlowLayoutPanel()
            With flp
                .FlowDirection = FlowDirection.TopDown
                .Dock = DockStyle.Fill
                .Padding = New Padding(0, 3, 0, 3)
                .WrapContents = False

                AddHandler .Resize, AddressOf flp_Resize
            End With

            With ttp
                .InitialDelay = 100
                .AutoPopDelay = 50000
                .ReshowDelay = 100
                '.IsBalloon = True
                .BackColor = SystemColors.Info
            End With

#Region "Control 0: Pilot Label"
            PilotLabel = New Label()
            With PilotLabel
                .AutoSize = True
                If Pilot Is Nothing Then
                    .Text = "Please fill following item(s)." & vbCrLf & "-- Item(s) --"
                Else
                    .Text = Pilot & vbCrLf & " "
                End If
            End With
            flp.Controls.Add(PilotLabel)
#End Region

#Region "Control 1: Input items TableLayoutPanel"
            tlpInput = New TableLayoutPanel()
            Dim i As Integer
            With tlpInput
                .Padding = New Padding(10, 8, 20, 8)
                .ColumnCount = 4
                For i = 0 To 3
                    Dim csi As New ColumnStyle
                    Select Case i
                        Case 0, 3
                            csi.SizeType = SizeType.Absolute
                            csi.Width = 0
                        Case 1
                            csi.SizeType = SizeType.Percent
                            If ItemLabelWidthPercentage < 25 Then
                                csi.Width = 25
                            ElseIf ItemLabelWidthPercentage > 50 Then
                                csi.Width = 50
                            Else
                                csi.Width = ItemLabelWidthPercentage
                            End If
                        Case 2
                            csi.SizeType = SizeType.Percent
                            If ItemLabelWidthPercentage < 25 Then
                                csi.Width = 75
                            ElseIf ItemLabelWidthPercentage > 50 Then
                                csi.Width = 50
                            Else
                                csi.Width = 100 - ItemLabelWidthPercentage
                            End If

                    End Select
                    .ColumnStyles.Add(csi)
                Next

                Try
                    If InputItems.Count = 0 Then
                        Err.Raise(999, Me.InputItems, "InputItems is nothing.")
                    Else
                        .RowCount = InputItems.Count
                        For i = 0 To .RowCount - 1
                            Dim rci As New RowStyle
                            rci.SizeType = SizeType.Absolute
                            rci.Height = 25
                            .RowStyles.Add(rci)

                            Dim iLabel As New Label
                            With iLabel
                                If AutoColon Then
                                    .Text = InputItems(i) & " :"
                                Else
                                    .Text = InputItems(i)
                                End If
                                .AutoSize = False
                                .Dock = DockStyle.Fill
                                .TextAlign = ContentAlignment.MiddleRight
                            End With

                            Dim iBox As New TextBox
                            With iBox
                                .Dock = DockStyle.Fill

                                If ItemPresets IsNot Nothing Then
                                    .Text = ItemPresets(i)
                                End If
                            End With

                            If ShowInputToolTips Then
                                Try
                                    ttp.SetToolTip(iBox, ItemToolTips(i))
                                Catch ex As Exception
                                    ttp.SetToolTip(iBox, "Input here for [" & InputItems(i) & "]")
                                End Try
                            End If

                            .Controls.Add(iLabel, 1, i)
                            .Controls.Add(iBox, 2, i)
                        Next
                    End If

                Catch ex As Exception
                    .RowCount = 1
                    Dim rci As New RowStyle
                    rci.SizeType = SizeType.Absolute
                    rci.Height = 25
                    .RowStyles.Add(rci)

                    Dim iLabel As New Label
                    With iLabel
                        .Text = "Input :"
                        .AutoSize = False
                        .Dock = DockStyle.Fill
                        .TextAlign = ContentAlignment.MiddleRight
                    End With

                    Dim iBox As New TextBox
                    With iBox
                        .Dock = DockStyle.Fill
                    End With

                    If ShowInputToolTips Then
                        ttp.SetToolTip(iBox, "Input here.")
                    End If

                    .Controls.Add(iLabel, 1, 0)
                    .Controls.Add(iBox, 2, 0)

                    Err.Clear()
                End Try

                .Height = 25 * .RowCount + .Padding.Vertical

            End With
            flp.Controls.Add(tlpInput)
#End Region

#Region "Control 2: Remarks Label"
            RemarksLabel = New Label()
            With RemarksLabel
                .AutoSize = True
                If Remarks Is Nothing Then
                    .Text = "-- Remarks --"
                Else
                    .Text = Remarks
                End If
            End With
            flp.Controls.Add(RemarksLabel)
#End Region

#Region "Control 3: Command TableLayoutPanel"
            tlpCommand = New TableLayoutPanel()
            With tlpCommand
                .Height = 30
                .Padding = New Padding(10, 5, 20, 0)
                .ColumnCount = 4
                For i = 0 To 3
                    Dim csi As New ColumnStyle
                    csi.SizeType = SizeType.Percent
                    csi.Width = 25
                    .ColumnStyles.Add(csi)
                Next
                .RowCount = 1

                OKCommand = New Button()
                With OKCommand
                    .Text = "確定"
                    .Dock = DockStyle.Fill
                    AddHandler .Click, AddressOf OKCommand_Click
                End With
                ttp.SetToolTip(OKCommand, "Result(s) will be returned.")

                CancelCommand = New Button()
                With CancelCommand
                    .Text = "取消"
                    .Dock = DockStyle.Fill
                    AddHandler .Click, AddressOf CancelCommand_Click
                End With
                ttp.SetToolTip(CancelCommand, "No result will be returned.")

                .Controls.Add(OKCommand, 2, 0)
                .Controls.Add(CancelCommand, 3, 0)
            End With
            flp.Controls.Add(tlpCommand)
#End Region

            Me.Controls.Add(flp)
            Me.ClientSize = New Size(Me.Width, Me.Padding.Vertical + flp.Padding.Vertical +
                                     PilotLabel.Height + PilotLabel.Margin.Vertical +
                                     tlpInput.Height + tlpInput.Margin.Vertical +
                                     RemarksLabel.Height + RemarksLabel.Margin.Vertical +
                                     tlpCommand.Height + tlpCommand.Margin.Vertical)

        End Sub

        Private Sub flp_Resize(sender As Object, e As EventArgs)
            tlpInput.Width = flp.Width
            tlpCommand.Width = flp.Width
        End Sub

        Private Sub OKCommand_Click()
            Try
                If InputItems.Count = 0 Then
                    Err.Raise(999, Me.InputItems, "InputItems is nothing.")
                Else
                    ReDim iResults(InputItems.Count - 1)
                    For i As Integer = 0 To iResults.Count - 1
                        iResults(i) = tlpInput.GetControlFromPosition(2, i).Text
                    Next
                End If

            Catch ex As Exception
                ReDim iResults(0)
                iResults(0) = tlpInput.GetControlFromPosition(2, 0).Text
                Err.Clear()
            End Try

            Me.DialogResult = DialogResult.OK
        End Sub

        Private Sub CancelCommand_Click()
            iResults = Nothing
            Me.DialogResult = DialogResult.Cancel
        End Sub

    End Class 'InputDialog

    '■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■
    '<Serializable>
    Public Class KzColorSticker
        Inherits Panel
        Implements IComparable

        'Dim iAspectRatio As Double
        Dim isV As Boolean
        'Dim oldSize As Size
        'Dim WithEvents iCheck As CheckBox

        Public Sub New(color As Color, Optional name As String = Nothing)
            Me.IsVertical = False
            Me.Size = New Size(160, 65)

            Try
                Me.Color = color
                Me.ID = color.ToArgb
            Catch ex As Exception
                Me.Color = Color.White
                Me.ID = Color.White.ToArgb
            End Try


            If name Is Nothing Then
                If color.IsEmpty Or Not color.IsNamedColor Then
                    Me.Name = "#" & Hex(color.ToArgb)
                Else
                    Me.Name = color.Name
                End If
            Else
                Me.Name = name
            End If

            'iCheck = New CheckBox
            'With iCheck
            '    .Text = ""
            '    .Location = New Point(x:=Me.Left - .Width, y:=Me.Top)
            'End With

            'Me.Controls.Add(iCheck)
        End Sub

        Public Property Color As Color
        Public Property ID As Int32
        Public Property RefName As String = Nothing
        Public Property Checked As Boolean = False
        Public Property IsVertical As Boolean
        Public Property SortByID As Boolean = False
        Public Property ShadowWidth As Integer = 0

        Public Function CompareTo(obj As Object) As Integer Implements IComparable.CompareTo
            If obj Is Nothing Then Return 1

            Try
                Dim otherColor As KzColorSticker = CType(obj, KzColorSticker)

                If SortByID Then
                    Return Me.ID.CompareTo(otherColor.ID)
                Else
                    Return Me.Name.CompareTo(otherColor.Name)
                End If
            Catch ex As Exception
                Throw New NotImplementedException("Error!")
            End Try
        End Function

        Dim ColorArea, NameArea, InfoArea, CheckArea, TypeArea, CloseArea As Rectangle

        Protected Overrides Sub OnPaint(e As PaintEventArgs)
            MyBase.OnPaint(e)

            Dim CmdMagin As Integer = 1
            Dim CmdSide As Integer = Math.Min(15, Me.Height / 2 - 2)
            Dim TextGap As Integer = 2

            Dim g As Graphics = e.Graphics
            g.SmoothingMode = SmoothingMode.HighQuality
            g.CompositingQuality = CompositingQuality.HighQuality
            g.InterpolationMode = InterpolationMode.HighQualityBicubic
            g.TextRenderingHint = Drawing.Text.TextRenderingHint.ClearTypeGridFit

            'Dim fullRect As Rectangle = Me.ClientRectangle ' New Rectangle(0, 0, Me.Width, Me.Height)
            'g.DrawRectangle(New Pen(Color.Black, 2), fullRect) '.ClientRectangle)
            'Me.BorderStyle = BorderStyle.FixedSingle
            'Dim colorRect As New Rectangle(x:=Me.ClientRectangle.X,
            '                               y:=Me.ClientRectangle.Y,
            '                               width:=Math.Max(Me.ClientRectangle.Width / 3, Me.ClientRectangle.Height),
            '                               height:=Me.ClientRectangle.Height)
            'g.FillRectangle(New SolidBrush(Me.Color), colorRect)

            If IsVertical Then

            Else
                ColorArea = New Rectangle(x:=0, y:=0,
                                          width:=Math.Max(Me.Width / 3, Me.Height),
                                          height:=Me.Height)
                NameArea = New Rectangle(x:=ColorArea.Right + TextGap,'ColorArea.X + ColorArea.Width + TextGap,
                                         y:=0,
                                         width:=Me.Width - ColorArea.Right - TextGap - CmdMagin * 2 - CmdSide,' - 5,
                                         height:=Me.Height / 2)
                InfoArea = New Rectangle(x:=NameArea.X,
                                         y:=NameArea.Bottom + 1,
                                         width:=NameArea.Width,
                                         height:=Me.Height - NameArea.Bottom)
                CheckArea = New Rectangle(x:=Me.Width - CmdMagin - CmdSide,'NameArea.Right + CmdMagin,
                                          y:=CmdMagin, width:=CmdSide, height:=CmdSide)
                TypeArea = New Rectangle(x:=Me.Width - CmdMagin - CmdSide,
                                          y:=InfoArea.Y, width:=CmdSide, height:=CmdSide)

                Dim sf As New StringFormat
                sf.Alignment = StringAlignment.Near
                sf.LineAlignment = StringAlignment.Center

                g.FillRectangle(New SolidBrush(Me.Color), ColorArea)
                g.FillRectangle(New SolidBrush(Color.Ivory), NameArea)
                g.DrawString(Me.Name, New Font("Arial", 10, FontStyle.Regular), New SolidBrush(Color.Black), NameArea, sf)
                g.FillRectangle(New SolidBrush(Color.Lavender), InfoArea)
                g.DrawString("#" & Hex(Me.Color.ToArgb), New Font("Consolas", 10, FontStyle.Regular), New SolidBrush(Color.DarkGray), InfoArea, sf)

                g.DrawRectangle(New Pen(Color.Black, 2), CheckArea)
                If Me.Checked Then
                    g.DrawLine(New Pen(Color.Black, 2), CheckArea.Left + 2, CheckArea.Top + CInt(CheckArea.Height / 2), CheckArea.Left + CInt(CheckArea.Width / 2), CheckArea.Bottom - 2)
                    g.DrawLine(New Pen(Color.Black, 2), CheckArea.Left + CInt(CheckArea.Width / 2), CheckArea.Bottom - 2, CheckArea.Right - 2, CheckArea.Top + 2)
                End If

                g.DrawRectangle(New Pen(Color.Gray), TypeArea)
                Dim tw As String
                If Me.Color.IsEmpty Then
                    tw = "?"
                Else
                    If Me.Color.IsSystemColor Then
                        tw = "S"
                    ElseIf Me.Color.IsKnownColor Then
                        tw = "K"
                    ElseIf Me.Color.IsNamedColor Then
                        tw = "N"
                    Else
                        tw = "Y"
                    End If
                End If

                'sf.LineAlignment = StringAlignment.Center
                sf.Alignment = StringAlignment.Center
                g.DrawString(tw, New Font("Arial", 8, FontStyle.Bold), New SolidBrush(Color.DarkGray), TypeArea, sf)


                'With e.Graphics
                '    .DrawRectangle(New Pen(Color.Black), CloseArea)
                '    .FillRectangle(New SolidBrush(Me.Color), ColorArea)
                'End With
            End If
        End Sub

        Protected Overrides Sub OnMouseClick(e As MouseEventArgs)
            If e.Button = MouseButtons.Left Then
                If PointInCheck(e.Location) Then
                    Me.Checked = Not Me.Checked
                End If
            End If

            Me.Invalidate()
            MyBase.OnMouseClick(e)
        End Sub

        Private Function PointInCheck(pt As Point) As Boolean
            Try
                Return CheckArea.Contains(pt)
            Catch ex As Exception
                Return False
            End Try
        End Function

        Private Function PointInClose(pt As Point) As Boolean
            Try
                Return CloseArea.Contains(pt)
            Catch ex As Exception
                Return False
            End Try
        End Function

        Protected Overrides Sub OnSizeChanged(e As EventArgs)
            MyBase.OnSizeChanged(e)
            Me.Invalidate()
        End Sub
    End Class


    'Public Class KzColorSticker
    '    Inherits UserControl ' Panel

    '    'UserControl 重写释放以清理组件列表。
    '    <System.Diagnostics.DebuggerNonUserCode()>
    '    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
    '        Try
    '            If disposing AndAlso components IsNot Nothing Then
    '                components.Dispose()
    '            End If
    '        Finally
    '            MyBase.Dispose(disposing)
    '        End Try
    '    End Sub

    '    'Windows 窗体设计器所必需的
    '    Private components As System.ComponentModel.IContainer

    '    '注意: 以下过程是 Windows 窗体设计器所必需的
    '    '可以使用 Windows 窗体设计器修改它。  
    '    '不要使用代码编辑器修改它。
    '    <System.Diagnostics.DebuggerStepThrough()>
    '    Private Sub InitializeComponent()
    '        Me.ColorViewer = New Panel()
    '        Me.NameLabel = New Label()
    '        Me.CodeLabel = New Label()
    '        Me.Checker = New CheckBox()
    '        Me.TypeLabel = New Label()
    '        Me.SuspendLayout()
    '        '
    '        'ColorViewer
    '        '
    '        Me.ColorViewer.Location = New Point(3, 3)
    '        Me.ColorViewer.Name = "ColorViewer"
    '        Me.ColorViewer.Size = New Size(73, 58)
    '        Me.ColorViewer.TabIndex = 0
    '        '
    '        'NameLabel
    '        '
    '        Me.NameLabel.AutoSize = True
    '        Me.NameLabel.Location = New Point(83, 61)
    '        Me.NameLabel.Name = "NameLabel"
    '        Me.NameLabel.Size = New Size(41, 12)
    '        Me.NameLabel.TabIndex = 1
    '        Me.NameLabel.Text = "Label1"
    '        '
    '        'CodeLabel
    '        '
    '        Me.CodeLabel.AutoSize = True
    '        Me.CodeLabel.Location = New Point(83, 46)
    '        Me.CodeLabel.Name = "CodeLabel"
    '        Me.CodeLabel.Size = New Size(41, 12)
    '        Me.CodeLabel.TabIndex = 2
    '        Me.CodeLabel.Text = "Label2"
    '        '
    '        'Checker
    '        '
    '        Me.Checker.AutoSize = True
    '        Me.Checker.Location = New Point(178, 4)
    '        Me.Checker.Name = "Checker"
    '        Me.Checker.Size = New Size(78, 16)
    '        Me.Checker.TabIndex = 3
    '        Me.Checker.Text = "CheckBox1"
    '        Me.Checker.UseVisualStyleBackColor = True
    '        '
    '        'TypeLabel
    '        '
    '        Me.TypeLabel.AutoSize = True
    '        Me.TypeLabel.Location = New Point(222, 61)
    '        Me.TypeLabel.Name = "TypeLabel"
    '        Me.TypeLabel.Size = New Size(41, 12)
    '        Me.TypeLabel.TabIndex = 5
    '        Me.TypeLabel.Text = "Label3"
    '        '
    '        'KzColorSticker
    '        '
    '        Me.AutoScaleDimensions = New SizeF(6.0!, 12.0!)
    '        Me.AutoScaleMode = AutoScaleMode.Font
    '        Me.Controls.Add(Me.TypeLabel)
    '        Me.Controls.Add(Me.Checker)
    '        Me.Controls.Add(Me.CodeLabel)
    '        Me.Controls.Add(Me.NameLabel)
    '        Me.Controls.Add(Me.ColorViewer)
    '        Me.Name = "KzColorSticker"
    '        Me.Size = New Size(274, 94)
    '        Me.ResumeLayout(False)
    '        Me.PerformLayout()

    '    End Sub

    '    Friend WithEvents ColorViewer As Panel
    '    Friend WithEvents NameLabel As Label
    '    Friend WithEvents CodeLabel As Label
    '    Friend WithEvents Checker As CheckBox
    '    Friend WithEvents TypeLabel As Label

    '    Public Sub New(ByVal color As Color)
    '        InitializeComponent()

    '    End Sub

    '    Protected Overrides Sub OnPaint(e As PaintEventArgs)

    '    End Sub
    'End Class 'KzColorSticker

    '■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■
    <Serializable>
    Public Class KzIndecatorBar
        Inherits Panel

        Dim iStart, iEnd As Integer

        Public Sub New()
            Me.Size = New Size(150, 100)
            Me.Font = New Font("MicrosoftYaHei", 10.5, FontStyle.Regular)
            Me.Range = New KzRange(0, 100)
            Me.IndecatorList = New List(Of KzIndecator)
        End Sub

        Public Property Range As KzRange
            Get
                Return New KzRange(iStart, iEnd)
            End Get
            Set(value As KzRange)
                iStart = value.Min
                iEnd = value.Max
                Me.Invalidate()
            End Set
        End Property

        'Public Property ShowShadow As Boolean = False
        Public Property ShadowWidth As Integer = 0
        Public Property HighLightStart As Integer = -1

        Public ReadOnly Property Min As Integer
            Get
                Return iStart
            End Get
        End Property

        Public ReadOnly Property Max As Integer
            Get
                Return iEnd
            End Get
        End Property

        Public ReadOnly Property Indecators As Integer
            Get
                Return Me.IndecatorList.Count
            End Get
        End Property

        Public Property IndecatorList As List(Of KzIndecator)

        Protected Overrides Sub OnPaint(e As PaintEventArgs)
            MyBase.OnPaint(e)

            With Me.IndecatorList
                Try
                    If .FindIndex(Function(x) x.Start = iStart) = -1 Then
                        .Add(New KzIndecator() With {
                             .Name = "Start",
                             .Label = .Name,
                             .Start = iStart,
                             .StartColor = Color.Blue})
                    End If
                    If .FindIndex(Function(x) x.Start = iEnd) = -1 Then
                        .Add(New KzIndecator() With {
                             .Name = "End",
                             .Label = .Name,
                             .Start = iEnd,
                             .StartColor = Color.Red})
                    End If

                    .Sort()
                Catch ex As Exception

                End Try

                e.Graphics.SmoothingMode = SmoothingMode.AntiAlias '开启抗锯齿
                e.Graphics.InterpolationMode = InterpolationMode.HighQualityBilinear '开启高质量插补模式
                e.Graphics.TextRenderingHint = Drawing.Text.TextRenderingHint.ClearTypeGridFit '开启文字ClearType

                Dim labelWidth As Integer = CInt(Me.Width / .Count)
                Dim labelHeight As Integer = 20
                Dim numHeight As Integer = 20
                Dim barMargin As New Padding(10, CInt((Me.Height - labelHeight - numHeight) / 3), 10, 5)
                Dim barRect, labelRect, numRect As Rectangle
                Dim LSP, LEP As Point

                barRect = New Rectangle(x:=10,
                                        y:=labelHeight + numHeight + barMargin.Top,
                                        width:=Me.Width - barMargin.Horizontal,
                                        height:=Me.Height - labelHeight - numHeight - barMargin.Vertical)
                If Me.ShadowWidth > 0 Then
                    If Me.ShadowWidth > 5 Then Me.ShadowWidth = 5
                    Dim shadowRect As New Rectangle(x:=barRect.X + Me.ShadowWidth, y:=barRect.Y + Me.ShadowWidth,
                                                    width:=barRect.Width, height:=barRect.Height)
                    e.Graphics.FillRectangle(New SolidBrush(Color.Gray), shadowRect)
                End If
                e.Graphics.DrawRectangle(New Pen(Color.Black), barRect)
                e.Graphics.FillRectangle(New SolidBrush(Color.LightGray), barRect)

                Dim sf As StringFormat = New StringFormat() With {
                    .Trimming = StringTrimming.EllipsisCharacter,
                    .FormatFlags = StringFormatFlags.NoWrap,
                    .Alignment = StringAlignment.Center,
                    .LineAlignment = StringAlignment.Center}

                For i As Integer = 0 To .Count - 1

                    labelRect = New Rectangle(x:=labelWidth * i, y:=0, width:=labelWidth, height:=labelHeight)
                    numRect = New Rectangle(x:=labelWidth * i, y:=labelRect.Height + 1, width:=labelWidth, height:=numHeight)

                    Dim theFont As Font
                    If .Item(i).Start = Me.HighLightStart Then
                        theFont = New Font(Me.Font, FontStyle.Bold)
                    Else
                        theFont = Me.Font
                    End If

                    e.Graphics.DrawString(.Item(i).Label, theFont, New SolidBrush(Color.Black), labelRect, sf)
                    e.Graphics.DrawString(.Item(i).Start, theFont, New SolidBrush(Color.Black), numRect, sf)

                    LSP = New Point(x:=numRect.Left + numRect.Width / 2, y:=numRect.Bottom) 'labelRect.Height + numRect.Height)
                    LEP = New Point(x:=barRect.Left + barRect.Width * (.Item(i).Start - iStart) / (iEnd - iStart), y:=barRect.Top)
                    If LEP.X < 0 Then LEP.X = 1
                    If LEP.X > Me.Width Then LEP.X = Me.Width - 1

                    e.Graphics.DrawLine(.Item(i).StartPen, LSP, LEP)
                    e.Graphics.DrawLine(.Item(i).StartPen, LEP, New Point(x:=LEP.X, y:=LEP.Y + barRect.Height))

                    e.Graphics.DrawLine(.Item(i).StartPen,
                                        New Point(x:=numRect.Left + CInt(numRect.Width / 4), y:=numRect.Bottom),
                                        New Point(LSP.X + CInt(numRect.Width / 4), numRect.Bottom))

                    If Not (LEP.X = 1 Or LEP.X = Me.Width - 1 Or .Item(i).Start = iEnd Or i >= .Count - 1) Then
                        Dim secRect As New Rectangle(x:=LEP.X + 1, y:=LEP.Y + 1,
                                                     width:=(barRect.Right - LEP.X) - 2,
                                                     height:=barRect.Height - 2)
                        e.Graphics.FillRectangle(.Item(i).FillBrush, secRect)

                        If .Item(i).Start = Me.HighLightStart Then
                            secRect.Offset(1, 1)
                            secRect.Size = New Size(((barRect.Left + barRect.Width * (.Item(i + 1).Start - iStart) / (iEnd - iStart)) - secRect.X) - 2, secRect.Height - 2)
                            e.Graphics.DrawRectangle(New Pen(Color.Black, 2), secRect)
                        End If
                    End If

                Next
            End With
        End Sub

        Protected Overrides Sub OnResize(eventargs As EventArgs)
            MyBase.OnResize(eventargs)
            Me.Invalidate()
        End Sub
    End Class 'KzIndecatorBar




    'Public Structure KzFont
    '    Public Sub New(font As Font)

    '    End Sub

    '    Public Property Name As FontFamily
    'End Structure
End Namespace