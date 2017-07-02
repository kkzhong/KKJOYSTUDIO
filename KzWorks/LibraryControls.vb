Imports System.IO
Imports System.Text
Imports System.Drawing.Drawing2D
'Imports System.Net
'Imports System.ComponentModel
'Imports System.Text.RegularExpressions
'Imports System.Globalization

Namespace KzLibrary

    Public Class KzTabControl
        Inherits TabControl

        Dim CloseEX As Boolean = False
        Dim CloseBTN As Rectangle ' = Nothing
        Dim TabEx As Integer = -1

        Private MinTabWidth As Integer = 64
        Private MenuOnTab As ContextMenuStrip

        Public Sub Initialize()
            Me.DrawMode = TabDrawMode.OwnerDrawFixed
            Me.SizeMode = TabSizeMode.Fixed        '// 选项卡大小模式
            Me.ItemSize = New Size(128, 24)         '// 选项卡大小（如果 SizeMode 选择了 Fixed）

            'SetStyles()
            MyBase.SetStyle(ControlStyles.UserPaint Or          '// 控件将自行绘制，而不是通过操作系统来绘制
                ControlStyles.OptimizedDoubleBuffer Or          '// 该控件首先在缓冲区中绘制，而不是直接绘制到屏幕上，这样可以减少闪烁
                ControlStyles.AllPaintingInWmPaint Or           '// 控件将忽略 WM_ERASEBKGND 窗口消息以减少闪烁
                ControlStyles.ResizeRedraw Or                   '// 在调整控件大小时重绘控件
                ControlStyles.SupportsTransparentBackColor,     '// 控件接受 alpha 组件小于 255 的 BackColor 以模拟透明
                True)                                           '// 设置以上值为 true
            MyBase.UpdateStyles()

            TabMenuCreator()

        End Sub

#Region "SettingProperties"
        Public Function GetDefaultStyle(ForTab As Boolean) As KzDrawingStyle
            Dim kds As New KzDrawingStyle(0)

            With kds
                If ForTab Then
                    .Radius = 0
                    .Margin = New Padding(0, 0, 0, 0)
                    .Padding = New Padding(0, 0, 0, 0)

                    .NormalFrameWidth = 0
                    .NormalFrameColor = Color.RoyalBlue
                    .NormalLineWidth = 1
                    .NormalForeColor = Color.Gray
                    .NormalFillColor = Color.LightGray
                    .NormalFont = Me.Font

                    .HoverFrameWidth = 0
                    .HoverFrameColor = .NormalFrameColor
                    .HoverLineWidth = 1
                    .HoverForeColor = Color.Ivory
                    .HoverFillColor = Color.DeepSkyBlue
                    .HoverFont = Me.Font

                    .SelectedFrameWidth = 0
                    .SelectedFrameColor = .NormalFrameColor
                    .SelectedLineWidth = 1
                    .SelectedForeColor = Color.White
                    .SelectedFillColor = Color.RoyalBlue
                    .SelectedFont = Me.Font
                Else
                    .Radius = 0
                    .Margin = New Padding(3, 3, 3, 3)
                    .Padding = New Padding(4, 4, 4, 4)

                    .NormalFrameWidth = 0
                    .NormalFrameColor = Color.RoyalBlue
                    .NormalLineWidth = 1
                    .NormalForeColor = Color.Ivory
                    .NormalFillColor = Color.RoyalBlue
                    .NormalFont = SystemFonts.DefaultFont

                    .HoverFrameWidth = 0
                    .HoverFrameColor = Color.White
                    .HoverLineWidth = 2
                    .HoverForeColor = Color.RoyalBlue
                    .HoverFillColor = Color.WhiteSmoke
                    .HoverFont = SystemFonts.DefaultFont

                    '.SelectedFrameWidth = 1
                    '.SelectedFrameColor = SystemColors.ActiveBorder
                    '.SelectedLineWidth = 1
                    '.SelectedForeColor = SystemColors.ControlText
                    '.SelectedFillColor = SystemColors.ControlDark
                    '.SelectedFont = SystemFonts.DefaultFont
                End If
            End With

            Return kds
        End Function 'GetDefaultStyle

        Private Function GetNewTab() As TabPage
            Select Case Me.Type
                Case KzTabControlTypes.TextEditor : Return New KzTextTab
                Case KzTabControlTypes.WebBrowser : Return New KzWebTab
                Case Else : Return New TabPage
            End Select
        End Function

        Public Property NewTitlePrefix As String = "New"
        Public Property SelectAfterAdd As Boolean = True
        Public Property Type As KzTabControlTypes = KzTabControlTypes.Blank  'KzTabControlTypes.TextEditor
        Public Property TabStyle As KzDrawingStyle = GetDefaultStyle(True)
        Public Property ButtonStyle As KzDrawingStyle = GetDefaultStyle(False)
        Public Property BackgroundColor As Color = SystemColors.Control
        Public Property ShowCloseButton As Boolean = True
        Public Property ShowTabMenu As Boolean = True
        Public Property DoAutoTabWidth As Boolean = True

#End Region 'SettingProperties

#Region "ReadOnlyProperties"
        Public ReadOnly Property NewSerialNumber As Integer
            Get
                Dim newStr As String
                If Me.NewTitlePrefix Is Nothing Then ' Or Me.NewTitlePrefix = "" Then
                    newStr = ""
                Else
                    newStr = Me.NewTitlePrefix
                End If

                Dim i As Integer = 0

                For Each tp As TabPage In Me.TabPages
                    If tp.Text.StartsWith(newStr) Then
                        Dim x As Integer
                        Try
                            x = CInt(tp.Text.Substring(Me.NewTitlePrefix.Length))
                        Catch ex As Exception
                            x = 0
                        End Try

                        i = Math.Max(i, x)
                    End If
                Next

                Return i + 1
            End Get
        End Property
#End Region 'ReadOnlyProperties

#Region "PaintingMethods"
        'Protected Overrides Sub OnDrawItem(e As DrawItemEventArgs)
        '    'If Me.TabPages(e.Index).Equals(Me.SelectedTab) Then
        '    '    e.Graphics.FillRectangle(New SolidBrush(Color.Beige), e.Bounds)
        '    'End If
        '    MyBase.OnDrawItem(e)
        'End Sub

        Protected Overrides Sub OnPaint(e As PaintEventArgs)
            MyBase.OnPaint(e)

            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias '开启抗锯齿
            e.Graphics.InterpolationMode = InterpolationMode.HighQualityBilinear '开启高质量插补模式
            e.Graphics.TextRenderingHint = Drawing.Text.TextRenderingHint.ClearTypeGridFit '开启文字ClearType
            '//背景
            e.Graphics.FillRectangle(New SolidBrush(Me.BackgroundColor), Me.ClientRectangle) 'TabControl背景
            'e.Graphics.FillRectangle(New SolidBrush(PageBackColor), Me.DisplayRectangle) 'TabPage背景

            If TabStyle.NormalFrameWidth > 0 Then '如果Frame有宽度则绘制页面边框
                Dim PageRect As Rectangle =
                    New Rectangle(Me.DisplayRectangle.X - TabStyle.NormalFrameWidth,
                                  Me.DisplayRectangle.Y - TabStyle.NormalFrameWidth,
                                  Me.DisplayRectangle.Width + 2 * TabStyle.NormalFrameWidth,
                                  Me.DisplayRectangle.Height + 2 * TabStyle.NormalFrameWidth)

                e.Graphics.DrawRectangle(New Pen(TabStyle.SelectedFrameColor,
                                                 TabStyle.NormalFrameWidth), PageRect)
            Else '如果Frame无宽度则在上部绘制横线
                e.Graphics.DrawLine(New Pen(TabStyle.SelectedFrameColor, 2),
                                    Me.DisplayRectangle.X - 1, Me.DisplayRectangle.Y - 2,
                                    Me.DisplayRectangle.Right + 1, Me.DisplayRectangle.Y - 2)
            End If

            '//绘制Tab标头
            For Each tp As TabPage In Me.TabPages
                DrawTabPage(e.Graphics, tp) ' Me.GetTabRect(Me.TabPages.IndexOf(tp)), tp)
            Next

            '//绘制新增按钮
            'If Me.TabPages.Count > 0 Then
            '    Dim lastRect As Rectangle = Me.GetTabRect(Me.TabPages.Count - 1)
            '    PlusBTN = New Rectangle(lastRect.Right + 10, lastRect.Top + buttonstyle.margin,
            '                            lastRect.Height - 2 * buttonstyle.margin, lastRect.Height - 2 * buttonstyle.margin)
            'Else
            '    PlusBTN = New Rectangle(Me.ClientRectangle.Left + 10, Me.ClientRectangle.Top + buttonstyle.margin,
            '                           Me.ItemSize.Height - 2 * buttonstyle.margin, Me.ItemSize.Height - 2 * buttonstyle.margin)
            'End If

            'DrawPlusButton(e.Graphics, PlusBTN)
        End Sub

        Private Sub DrawTabPage(g As Graphics, tp As TabPage) 'tabRect As Rectangle,
            Dim tabRect As Rectangle = Me.GetTabRect(Me.TabPages.IndexOf(tp))

            Dim sf As StringFormat = New StringFormat() With {
                .Trimming = StringTrimming.EllipsisCharacter,
                .FormatFlags = StringFormatFlags.NoWrap,
                .Alignment = StringAlignment.Near,
                .LineAlignment = StringAlignment.Center}

            Dim fontRect As Rectangle '//定义文字范围框

            Try
                If Me.SelectedTab.Equals(tp) Then '绘制选中的Tab
                    g.FillRectangle(New SolidBrush(TabStyle.SelectedFillColor), tabRect) '//填充标头背景

                    If TabStyle.NormalFrameWidth > 0 Then
                        g.DrawRectangle(New Pen(TabStyle.SelectedFrameColor, TabStyle.NormalFrameWidth), tabRect) '//绘制实边线
                        'g.DrawLine(New Pen(ColorSelected, 3), tabRect.X + 1, tabRect.Bottom, tabRect.Right, tabRect.Bottom)'//掩盖选中Tab的下部的绘制 
                    End If

                    '//绘制关闭按钮
                    If ShowCloseButton Then
                        Dim ButtonSide As Integer = tabRect.Height - 2 * ButtonStyle.Margin.All
                        CloseBTN = New Rectangle(
                            tabRect.Right - TabStyle.NormalFrameWidth - ButtonStyle.Margin.All - ButtonSide,
                            tabRect.Top + TabStyle.NormalFrameWidth + ButtonStyle.Margin.All,
                            ButtonSide, ButtonSide)
                        DrawCloseButton(g, CloseBTN)
                    End If

                    '//文字绘制(扩展阴影文字参考）
                    fontRect = New Rectangle(
                        tabRect.X + 5, tabRect.Y + 5,
                        tabRect.Width - 5 - CloseBTN.Width - 2 * ButtonStyle.Margin.All - TabStyle.NormalFrameWidth,
                        tabRect.Height - 7)
                    g.DrawString(tp.Text, tp.Font, New SolidBrush(TabStyle.SelectedForeColor), fontRect, sf)

                Else '//绘制非选中Tab
                    tabRect = New Rectangle(tabRect.X + 1, tabRect.Y, tabRect.Width - 1, tabRect.Height - 1) '标准区域
                    fontRect = New Rectangle(tabRect.X + 5, tabRect.Y + 5, tabRect.Width - 10, tp.Font.Height) '文字区域

                    If TabEx = Me.TabPages.IndexOf(tp) Then '判断是否鼠标悬停
                        g.FillRectangle(New SolidBrush(TabStyle.HoverFillColor), tabRect) '填充标头背景
                        g.DrawString(tp.Text, tp.Font, New SolidBrush(TabStyle.HoverForeColor), fontRect, sf) '标题
                    Else
                        g.FillRectangle(New SolidBrush(TabStyle.NormalFillColor), tabRect)
                        g.DrawString(tp.Text, tp.Font, New SolidBrush(TabStyle.NormalForeColor), fontRect, sf)
                    End If

                    If TabStyle.NormalFrameWidth > 0 Then
                        g.DrawRectangle(New Pen(TabStyle.NormalFrameColor, TabStyle.NormalFrameWidth), tabRect) '绘制实边线 
                    End If

                End If
            Catch ex As Exception

            End Try


            ''//文字绘制扩展: 阴影文字（先用高光色绘制第一遍，再用普通文字色（黑）绘制第二遍。）
            ''// Calculate text position  
            'Dim bounds As Rectangle = rectangle
            'Dim textPoint As PointF = New PointF()
            'Dim textSize As SizeF = TextRenderer.MeasureText(tp.Text, Me.Font)

            ''// 注意要加上每个标签的左偏移量X  
            'textpoint.X = bounds.X + (bounds.Width - textSize.Width) / 2
            'textpoint.Y = bounds.Bottom - textSize.Height - Me.Padding.Y

            ''// Draw highlights  
            'graphics.DrawString(tp.Text, Me.Font, SystemBrushes.ControlLightLight, textPoint.X, textPoint.Y) '// 高光颜色

            ''// 绘制正常文字  
            'textPoint.Y -= 1
            'graphics.DrawString(tp.Text, Me.Font, SystemBrushes.ControlText, textPoint.X, textPoint.Y) '// 正常颜色
        End Sub

        Private Sub DrawCloseButton(g As Graphics, btnRect As Rectangle)
            Dim lp, fp As Pen
            Dim br As SolidBrush

            If CloseEX Then
                br = ButtonStyle.HoverFillBrush ' New SolidBrush(ButtonStyle.HoverFillColor)
                lp = ButtonStyle.HoverForePen ' New Pen(ButtonStyle.HoverForeColor, 2)
                fp = ButtonStyle.HoverFramePen ' New Pen(ButtonStyle.HoverFrameColor, 1)
            Else
                br = ButtonStyle.NormalFillBrush ' New SolidBrush(ButtonStyle.NormalFillColor)
                lp = ButtonStyle.NormalForePen ' New Pen(ButtonStyle.NormalForeColor, 1)
                fp = ButtonStyle.NormalFramePen ' New Pen(ButtonStyle.NormalFrameColor, 1)
            End If

            g.FillRectangle(br, btnRect)

            If ButtonStyle.NormalFrameWidth > 0 Then
                g.DrawRectangle(fp, btnRect)
            End If

            g.DrawLine(lp,
                       btnRect.Left + ButtonStyle.Padding.All,
                       btnRect.Top + ButtonStyle.Padding.All,
                       btnRect.Right - ButtonStyle.Padding.All,
                       btnRect.Bottom - ButtonStyle.Padding.All)
            g.DrawLine(lp,
                       btnRect.Left + ButtonStyle.Padding.All,
                       btnRect.Bottom - ButtonStyle.Padding.All,
                       btnRect.Right - ButtonStyle.Padding.All,
                       btnRect.Top + ButtonStyle.Padding.All)
        End Sub

#End Region 'PaintingMethods

#Region "MouseActions"
        Protected Overrides Sub OnMouseDown(e As MouseEventArgs)
            If e.Button = MouseButtons.Left Then
                If ShowCloseButton Then
                    If PointInClose(e.Location) Then
                        RemoveTab(KzItemPosition.PreviousItem)
                        CloseEX = False
                    End If
                End If

            ElseIf e.Button = MouseButtons.Right Then
                If ShowTabMenu Then
                    MenuOnTab.Tag = e.Location
                    MenuOnTab.Show(Me, e.Location)
                End If
            End If
        End Sub

        Protected Overrides Sub OnDoubleClick(e As EventArgs)
            AutoTabWidth()
            MyBase.OnDoubleClick(e)
        End Sub

        Protected Overrides Sub OnMouseLeave(e As EventArgs)
            If ShowCloseButton Then
                CloseEX = False
            End If

            TabEx = -1
            Me.Invalidate()

            MyBase.OnMouseLeave(e)
        End Sub

        Protected Overrides Sub OnMouseMove(e As MouseEventArgs)
            If ShowCloseButton Then
                If PointInClose(e.Location) Then
                    CloseEX = True
                Else
                    CloseEX = False
                End If
            End If

            For Each tp As TabPage In Me.TabPages
                If Not Me.SelectedTab.Equals(tp) Then
                    Dim r As Rectangle = Me.GetTabRect(Me.TabPages.IndexOf(tp))
                    If r.Contains(e.Location) Then
                        TabEx = Me.TabPages.IndexOf(tp)
                        Exit For
                    Else
                        TabEx = -1
                    End If
                End If
            Next

            Me.Invalidate()

            MyBase.OnMouseMove(e)
        End Sub

        '//判断鼠标是否在关闭按钮上 
        Private Function PointInClose(pt As Point) As Boolean
            Return CloseBTN.Contains(pt)
        End Function

        Private Function GetTabOnPoint(pt As Point) As TabPage
            Dim tab As TabPage = Nothing
            For Each tp As TabPage In Me.TabPages
                Dim r As Rectangle = Me.GetTabRect(Me.TabPages.IndexOf(tp))
                If r.Contains(pt) Then
                    tab = tp
                    Exit For
                End If
            Next
            Return tab
        End Function
#End Region 'MouseActions

#Region "PublicMethods"
        Public Sub AutoTabWidth()
            If Not DoAutoTabWidth Then Exit Sub

            If Me.TabCount > 0 Then
                Try
                    Dim ItemWidth As Integer = Me.ItemSize.Width
                    Dim ValidFullWidth As Integer = Me.ClientRectangle.Width - 20

                    Dim ExpectedItemNumbers As Integer
                    Select Case ValidFullWidth
                        Case Is < 400 : ExpectedItemNumbers = 3
                        Case 400 To 600 : ExpectedItemNumbers = 4
                        Case 600 To 800 : ExpectedItemNumbers = 5
                        Case 800 To 1000 : ExpectedItemNumbers = 6
                        Case 1000 To 1200 : ExpectedItemNumbers = 7
                        Case 1200 To 1800 : ExpectedItemNumbers = 8
                        Case Is > 1800 : ExpectedItemNumbers = 10
                    End Select

                    Dim SuitableWidth As Integer = CInt(ValidFullWidth / ExpectedItemNumbers)

                    If ItemWidth * Me.TabCount <= ValidFullWidth And
                    SuitableWidth * Me.TabCount <= ValidFullWidth Then

                        ItemWidth = Math.Max(ItemWidth, SuitableWidth)

                    ElseIf ItemWidth * Me.TabCount > ValidFullWidth And
                    SuitableWidth * Me.TabCount <= ValidFullWidth Then

                        ItemWidth = SuitableWidth

                    ElseIf ItemWidth * Me.TabCount > ValidFullWidth And
                    SuitableWidth * Me.TabCount > ValidFullWidth Then

                        ItemWidth = Math.Max(CInt(ValidFullWidth / TabCount), MinTabWidth)
                        'ElseIf ItemWidth * Me.TabCount <= ValidFullWidth And SuitableWidth * Me.TabCount > ValidFullWidth Then
                        '    ItemWidth = ItemWidth
                    End If

                    Me.ItemSize = New Size(ItemWidth, 24)
                Catch ex As Exception
                End Try
            End If
        End Sub

        Public Sub RemoveTab(moveTo As KzItemPosition, Optional tp As TabPage = Nothing)
            With Me
                If tp Is Nothing Then ' Or tp.Equals(Me.SelectedTab) Then
                    If .TabCount > 1 Then
                        Dim iOldSelected As Integer = .SelectedIndex

                        .TabPages.Remove(.SelectedTab)

                        Select Case moveTo
                            Case KzItemPosition.None
                                .SelectedIndex = -1
                            Case KzItemPosition.PreviousItem
                                If iOldSelected = 0 Then
                                    .SelectedIndex = 0
                                Else
                                    .SelectedIndex = iOldSelected - 1
                                End If
                            Case KzItemPosition.NextItem
                                If iOldSelected > .TabPages.Count - 1 Then
                                    .SelectedIndex = .TabPages.Count - 1
                                Else
                                    .SelectedIndex = iOldSelected
                                End If
                            Case KzItemPosition.LastItem
                                .SelectedIndex = .TabPages.Count - 1
                        End Select
                    ElseIf .TabCount = 1 Then
                        .TabPages.Clear()
                    End If
                Else
                    If Not tp.Equals(Me.SelectedTab) Then
                        .TabPages.Remove(tp)
                    Else
                        Me.RemoveTab(moveTo)
                    End If
                End If

            End With

            AutoTabWidth()
        End Sub

        Public Sub AddTab(addTo As KzItemPosition, Optional tp As TabPage = Nothing, Optional idx As Integer = -1)
            With Me
                Dim newTab As TabPage
                If tp Is Nothing Then
                    newTab = GetNewTab()
                Else
                    newTab = tp
                End If

                If newTab.Text Is Nothing Or newTab.Text = "" Then
                    newTab.Text = .NewTitlePrefix & Strings.Format(.NewSerialNumber(), "00")
                    newTab.ToolTipText = newTab.Text
                Else
                    newTab.ToolTipText = newTab.Text
                End If

                If idx = -1 Then
                    Dim toIndex As Integer
                    If .TabPages.Count > 0 Then
                        Select Case addTo
                            Case KzItemPosition.FirstItem
                                toIndex = 0
                            Case KzItemPosition.PreviousItem, KzItemPosition.Current
                                toIndex = .SelectedIndex
                            Case KzItemPosition.NextItem
                                If .SelectedIndex = .TabPages.Count - 1 Then
                                    toIndex = -1
                                Else
                                    toIndex = .SelectedIndex + 1
                                End If
                            Case Else
                                toIndex = -1
                        End Select
                    Else
                        toIndex = -1
                    End If

                    If toIndex = -1 Then
                        .TabPages.Add(newTab)
                    Else
                        .TabPages.Insert(toIndex, newTab)
                    End If

                Else
                    Try
                        .TabPages.Insert(idx, newTab)
                    Catch ex As Exception
                        .AddTab(addTo, tp)
                    End Try
                End If

                If Me.SelectAfterAdd Then
                    .SelectedTab = newTab
                End If
            End With

            AutoTabWidth()
        End Sub

#End Region 'PublicMethods

#Region "MenuActions"
        Private Sub TabMenuCreator()
            MenuOnTab = New ContextMenuStrip
            With MenuOnTab.Items
                .Add("Close", Nothing, New EventHandler(AddressOf OnCloseMenuClick))
                .Add("Close All", Nothing, New EventHandler(AddressOf OnCloseAllMenuClick))
                .Add(New ToolStripSeparator)
                .Add("Add New", Nothing, New EventHandler(AddressOf OnAddMenuClick))
                .Add("Insert New", Nothing, New EventHandler(AddressOf OnInsertMenuClick))
                .Add(New ToolStripSeparator)
                .Add("Auto Width", Nothing, New EventHandler(AddressOf OnAutoWidthMenuClick))
                '.Add("Sorting", Nothing, New EventHandler(AddressOf OnSortingMenuClick))
            End With
        End Sub

        Private Sub OnCloseMenuClick()
            Try
                Dim tp As TabPage = GetTabOnPoint(MenuOnTab.Tag)
                If tp IsNot Nothing And Not tp.Equals(Me.SelectedTab) Then
                    Me.RemoveTab(KzItemPosition.PreviousItem, tp)
                ElseIf tp.Equals(Me.SelectedTab) Then
                    Me.RemoveTab(KzItemPosition.PreviousItem)
                End If
            Catch ex As Exception

            End Try
        End Sub

        Private Sub OnCloseAllMenuClick()
            Me.TabPages.Clear()
        End Sub

        Private Sub OnAddMenuClick()
            Me.AddTab(KzItemPosition.LastItem)
        End Sub

        Private Sub OnInsertMenuClick()
            Dim tp As TabPage = GetTabOnPoint(MenuOnTab.Tag)
            If tp IsNot Nothing Then
                Me.AddTab(KzItemPosition.Current, Nothing, Me.TabPages.IndexOf(tp))
            Else
                Me.AddTab(KzItemPosition.Current)
            End If
        End Sub

        Private Sub OnAutoWidthMenuClick()
            Me.AutoTabWidth()
        End Sub

#End Region 'MenuActions
    End Class 'KzTabControl


    Public Class KzTextTab
        Inherits TabPage
        Implements IComparable

        Dim WithEvents iBox As TextBox
        Dim iEncoding As Encoding
        Dim iPath As String
        Dim iSpan As String

        Public Sub New()
            Initialize()
        End Sub

        Public Sub Initialize()

            iBox = New TextBox() With {
            .Multiline = True,
            .ScrollBars = ScrollBars.Vertical,
            .HideSelection = False,
            .Dock = DockStyle.Fill,
            .BorderStyle = BorderStyle.None} ', .AllowDrop = True}

            Me.Controls.Add(iBox)

            iPath = Nothing
            iEncoding = Encoding.Default

            Me.NeedSave = False
            Me.IsNew = True
        End Sub

        Public Property FilePath As String
            Get
                Return iPath
            End Get
            Set(value As String)
                iPath = value
                RaiseEvent FilePathChanged()
            End Set
        End Property
        Public Property IsNew As Boolean
        Public Property NeedSave As Boolean

        Public Property Encoding As Encoding '= Encoding.UTF8
            Get
                Return iEncoding
            End Get
            Set(value As Encoding)
                If Not value.Equals(iEncoding) Then
                    iEncoding = value
                    RaiseEvent EncodingChanged()

                    If Not Me.IsNew And File.Exists(iPath) Then
                        If Me.NeedSave Then
                            Dim mr As MsgBoxResult = MsgBox("文檔已更改但未保存！是否以新編碼保存後再讀入？", MsgBoxStyle.YesNo, "確認")
                            If mr = MsgBoxResult.Yes Then
                                Me.Save()
                                Me.ReadText(iPath, iEncoding)
                            End If
                        Else
                            Me.ReadText(iPath, iEncoding)
                        End If
                    End If
                End If
            End Set
        End Property

#Region "ReadOnlyProperties"
        Public ReadOnly Property TextBox As TextBox
            Get
                Return iBox
            End Get
        End Property

        Public ReadOnly Property LastLoadingTime As String
            Get
                Return iSpan
            End Get
        End Property

        Public ReadOnly Property FileInfo As FileInfo
            Get
                Try
                    Return New FileInfo(Me.FilePath)
                Catch ex As Exception
                    Return Nothing
                End Try
            End Get
        End Property

        Public ReadOnly Property TextInfo As KzTextInfo
            Get
                'Dim kti As New KzTextInfo(iBox.Text)
                Try
                    Return New KzTextInfo(iBox.Text)
                Catch ex As Exception
                    Return New KzTextInfo("")
                End Try
            End Get
        End Property

#End Region 'ReadOnlyProperties

#Region "DragDropEvents"
        Private Sub TextDragEnter(sender As Object, drgevent As DragEventArgs) Handles iBox.DragEnter
            If drgevent.Data.GetDataPresent(DataFormats.FileDrop) Then
                drgevent.Effect = DragDropEffects.All
            End If

            iBox.BackColor = Color.SkyBlue
            iBox.BorderStyle = BorderStyle.FixedSingle
        End Sub

        Private Sub TextDragLeave(sender As Object, drgevent As DragEventArgs) Handles iBox.DragLeave
            iBox.BackColor = SystemColors.Window
            iBox.BorderStyle = BorderStyle.None
        End Sub

        Private Sub TextDragDrop(sender As Object, drgevent As DragEventArgs) Handles iBox.DragDrop
            If drgevent.Data.GetDataPresent(DataFormats.FileDrop) Then
                Dim DroppedFiles() As String = drgevent.Data.GetData(DataFormats.FileDrop)
                ReadText(DroppedFiles(0))

                iBox.BackColor = SystemColors.Window
                iBox.BorderStyle = BorderStyle.None
            End If
        End Sub
#End Region 'DragDropEvents

        Private Sub iBox_TextChanged(sender As Object, e As EventArgs) Handles iBox.TextChanged
            Me.NeedSave = True
        End Sub

#Region "PublicMethods"

        Public Sub PasteText(text As String,
                             Optional replaceAll As Boolean = False,
                             Optional theEncoding As Encoding = Nothing)

            If theEncoding Is Nothing Then
                theEncoding = iEncoding
            ElseIf Not theEncoding.Equals(iEncoding) Then
                iEncoding = theEncoding
            End If

            If replaceAll Then
                iBox.Text = text
            Else
                iBox.Paste(text)
            End If
        End Sub

        Public Sub AppendText(text As String,
                              Optional asNewLine As Boolean = False,
                              Optional theEncoding As Encoding = Nothing)

            If theEncoding Is Nothing Then
                theEncoding = iEncoding
            ElseIf Not theEncoding.Equals(iEncoding) Then
                iEncoding = theEncoding
            End If

            If asNewLine Then
                iBox.Text &= vbCrLf & text
            Else
                iBox.Text &= text
            End If
        End Sub

        Public Function TextIsEmpty(text As String) As Boolean
            Dim si As New System.Globalization.StringInfo(Strings.Trim(text))
            Return si.LengthInTextElements = 0 Or text Is Nothing
        End Function

        Public Sub ReadText(Optional PathStr As String = Nothing,
                            Optional theEncoding As Encoding = Nothing)

            If PathStr Is Nothing Or PathStr = "" Then
                PathStr = iPath
            End If

            If theEncoding Is Nothing Then
                theEncoding = iEncoding
            End If

            If File.Exists(PathStr) Then
                Dim go As Boolean

                With iBox
                    If TextIsEmpty(.Text) Then
                        go = True
                    Else
                        go = (KzMsg.ContentsIsNotEmpty = MsgBoxResult.Yes) '(KzMsgBox(MsgType.ContentsIsNotEmpty) = MsgBoxResult.Yes)
                    End If

                    If go Then
                        Try
                            Dim ts As New KzLibrary.KzTimeShift(Now())
                            iBox.Text = File.ReadAllText(PathStr, theEncoding)

                            If PathStr <> iPath Then
                                iPath = PathStr
                                Me.Text = Path.GetFileName(iPath)
                                RaiseEvent FilePathChanged()
                            End If

                            If Not theEncoding.Equals(iEncoding) Then
                                iEncoding = theEncoding
                                RaiseEvent EncodingChanged()
                            End If

                            ts.EndTime = Now()
                            iSpan = ts.SpanText

                            Me.NeedSave = False
                            Me.IsNew = False
                        Catch ex As Exception
                            MsgBox(ex.Message)
                        End Try
                    End If
                End With
            End If
        End Sub

        Public Sub Save(Optional pathStr As String = Nothing)
            If TextIsEmpty(iBox.Text) Then
                If KzMsg.ContentsIsEmptySelect = MsgBoxResult.No Then
                    Return
                End If
            End If

            Dim p As String = If(pathStr = Nothing, iPath, pathStr)
            Dim go As Boolean

            If Me.NeedSave Then
                If Me.IsNew Then
                    If File.Exists(p) Then
                        Dim mbr As MsgBoxResult = KzMsg.FileExistsForWrite
                        If mbr = MsgBoxResult.Yes Then
                            go = True
                        ElseIf mbr = MsgBoxResult.No Then
                            p = KzFile.GetAnotherFileName(p)
                            go = Not p Is Nothing
                        Else
                            go = False
                        End If
                    Else 'Not FileExists
                        If KzMsg.FileNotExistsForWrite = MsgBoxResult.Yes Then
                            p = KzFile.GetSaveFile()
                            go = True
                        Else
                            go = False
                        End If
                    End If
                Else 'Not IsNew
                    If File.Exists(p) Then
                        go = True
                    Else
                        If KzMsg.FileErrorForWrite = MsgBoxResult.Yes Then
                            p = KzFile.GetSaveFile()
                            go = True
                        Else
                            go = False
                        End If
                    End If
                End If
            End If

            If go Then
                Try
                    KzMsg.Break(p)
                    'If Not File.Exists(p) Then

                    'End If
                    File.WriteAllText(p, iBox.Text, iEncoding)

                    If p <> iPath Then
                        iPath = p
                        Me.Text = Path.GetFileName(iPath)
                        RaiseEvent FilePathChanged()
                    End If
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            End If
        End Sub

        Public Sub CovertText(text As String, fromEncoding As Encoding, toEncoding As Encoding)

        End Sub

        Public Function CompareTo(obj As Object) As Integer Implements IComparable.CompareTo
            If obj Is Nothing Then Return 0

            Try
                Dim another As KzTextTab = CType(obj, KzTextTab)
                Return Me.Text.CompareTo(another.Text)
            Catch ex As Exception
                Throw New NotImplementedException()
            End Try
        End Function

        Public Event FilePathChanged()
        Public Event EncodingChanged()
#End Region 'PublicMethods

    End Class 'KzTextTab


    Public Class KzRichTextTab
        Inherits TabPage

        Dim WithEvents iBox As RichTextBox
        Dim iEncoding As Encoding
        Dim iLoading As String

        Public Sub New()

            iBox = New RichTextBox With {
                .Multiline = True,
                .ScrollBars = RichTextBoxScrollBars.Vertical,
                .HideSelection = False,
                .BorderStyle = BorderStyle.FixedSingle,
                .Dock = DockStyle.Fill}

            Me.Controls.Add(iBox)

        End Sub

        Public Property FilePath As String = Nothing
        Public Property IsNew As Boolean = True
        Public Property NeedSave As Boolean = False
        Public Property Encoding As Encoding
            Get
                Return iEncoding
            End Get
            Set(value As Encoding)
                If Not value.Equals(iEncoding) Then
                    iEncoding = value
                End If
            End Set
        End Property

        Public ReadOnly Property TextBox As RichTextBox
            Get
                Return iBox
            End Get
        End Property

        Public ReadOnly Property LastLoadingTime As String
            Get
                Return iLoading
            End Get
        End Property

        Private Sub iBox_TextChanged(sender As Object, e As EventArgs) Handles iBox.TextChanged
            Me.NeedSave = True
        End Sub

#Region "PublicMethods"

        Public Sub PasteText(text As String,
                             Optional replaceAll As Boolean = False,
                             Optional theEncoding As Encoding = Nothing)

            If theEncoding Is Nothing Then
                theEncoding = iEncoding
            ElseIf Not theEncoding.Equals(iEncoding) Then
                iEncoding = theEncoding
            End If

            If replaceAll Then
                iBox.Text = text
            Else
                Clipboard.SetText(text)
                iBox.Paste(DataFormats.GetFormat(DataFormats.UnicodeText))
            End If
        End Sub

        Public Sub AppendText(text As String,
                              Optional asNewLine As Boolean = False,
                              Optional theEncoding As Encoding = Nothing)

            If theEncoding Is Nothing Then
                theEncoding = iEncoding
            ElseIf Not theEncoding.Equals(iEncoding) Then
                iEncoding = theEncoding
            End If

            If asNewLine Then
                iBox.Text &= vbCrLf & text
            Else
                iBox.Text &= text
            End If
        End Sub

        Public Function TextIsEmpty(text As String) As Boolean
            Dim si As New System.Globalization.StringInfo(Strings.Trim(text))
            Return si.LengthInTextElements = 0 Or text Is Nothing
        End Function

        Public Sub Read(Optional PathStr As String = Nothing,
                        Optional theEncoding As Encoding = Nothing)

            If PathStr Is Nothing Or PathStr = "" Then
                PathStr = Me.FilePath 'iPath
            End If

            If theEncoding Is Nothing Then
                theEncoding = iEncoding
            End If

            If File.Exists(PathStr) Then
                Dim go As Boolean

                With iBox
                    If TextIsEmpty(.Text) Then
                        go = True
                    Else
                        go = (KzMsg.ContentsIsNotEmpty = MsgBoxResult.Yes) '(KzMsgBox(MsgType.ContentsIsNotEmpty) = MsgBoxResult.Yes)
                    End If

                    If go Then
                        Try
                            Dim ts As New KzLibrary.KzTimeShift(Now())
                            iBox.Text = File.ReadAllText(PathStr, theEncoding)

                            If PathStr <> Me.FilePath Then 'iPath Then
                                Me.FilePath = PathStr 'iPath = PathStr
                                Me.Text = Path.GetFileName(Me.FilePath) 'iPath)
                            End If

                            If Not theEncoding.Equals(iEncoding) Then
                                iEncoding = theEncoding
                            End If

                            ts.EndTime = Now()
                            iLoading = ts.SpanText

                            Me.NeedSave = False
                            Me.IsNew = False
                        Catch ex As Exception
                            MsgBox(ex.Message)
                        End Try
                    End If
                End With
            End If
        End Sub

        Public Sub Write(Optional pathStr As String = Nothing)
            If TextIsEmpty(iBox.Text) Then
                If KzMsg.ContentsIsEmptySelect = MsgBoxResult.No Then
                    Return
                End If
            End If

            Dim p As String = If(pathStr = Nothing, Me.FilePath, pathStr) 'iPath, pathStr)
            Dim go As Boolean

            If Me.NeedSave Then
                If Me.IsNew Then
                    If File.Exists(p) Then
                        Dim mbr As MsgBoxResult = KzMsg.FileExistsForWrite
                        If mbr = MsgBoxResult.Yes Then
                            go = True
                        ElseIf mbr = MsgBoxResult.No Then
                            p = KzFile.GetAnotherFileName(p)
                            go = Not p Is Nothing
                        Else
                            go = False
                        End If
                    Else 'Not FileExists
                        If KzMsg.FileNotExistsForWrite = MsgBoxResult.Yes Then
                            p = KzFile.GetSaveFile()
                            go = True
                        Else
                            go = False
                        End If
                    End If
                Else 'Not IsNew
                    If File.Exists(p) Then
                        go = True
                    Else
                        If KzMsg.FileErrorForWrite = MsgBoxResult.Yes Then
                            p = KzFile.GetSaveFile()
                            go = True
                        Else
                            go = False
                        End If
                    End If
                End If
            End If

            If go Then
                Try
                    KzMsg.Break(p)
                    'If Not File.Exists(p) Then

                    'End If
                    File.WriteAllText(p, iBox.Text, iEncoding)

                    If p <> Me.FilePath Then 'iPath Then
                        Me.FilePath = p 'iPath = p
                        Me.Text = Path.GetFileName(Me.FilePath) 'iPath)
                    End If
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            End If
        End Sub

#End Region 'PublicMethods
    End Class


    Public Class KzWebTab
        Inherits TabPage

        Dim WithEvents iBro As WebBrowser
        Public Event UrlChanged(ByVal strUrl As String)

        Public Sub New()
            Me.Initialize()
        End Sub

        Public Sub Initialize()

            iBro = New WebBrowser() With {
                .Dock = DockStyle.Fill,
                .ScriptErrorsSuppressed = True
            }

            Me.Controls.Add(Me.WebBrowser)
        End Sub

        Public Property IconImage As Image
        Public ReadOnly Property WebBrowser As WebBrowser
            Get
                Return iBro
            End Get
        End Property

        Public Sub Navigate(ByVal strUrl As String)
            Application.DoEvents()
            iBro.Navigate(New Uri(strUrl))
        End Sub

        Private Sub iBro_DocumentCompleted _
            (ByVal sender As Object, ByVal e As WebBrowserDocumentCompletedEventArgs) _
            Handles iBro.DocumentCompleted

            Me.Text = iBro.Document.Title

            Try
                Dim icoPath As String = "http://" & iBro.Url.Host & "/favicon.ico"
                Me.IconImage = Drawing.Image.FromStream _
                    (System.Net.WebRequest.Create(icoPath).GetResponse().GetResponseStream())
            Catch ex As Exception
                Me.IconImage = Nothing
            End Try
        End Sub

        Private Sub iBro_DocumentTitleChanged _
            (ByVal sender As Object, ByVal e As System.EventArgs) _
            Handles iBro.DocumentTitleChanged

            Try
                Me.Text = iBro.Document.Title
                Me.ToolTipText = Me.Text
            Catch ex As Exception
                Me.Text = "未知..."
                Me.ToolTipText = ""
            End Try
        End Sub

        Private Sub iBro_Navigating _
            (ByVal sender As Object, ByVal e As WebBrowserNavigatingEventArgs) _
            Handles iBro.Navigating

            'Me.Text = "載入中..."
        End Sub

        Private Sub iBro_Navigated _
            (ByVal sender As Object, ByVal e As WebBrowserNavigatedEventArgs) _
            Handles iBro.Navigated

            RaiseEvent UrlChanged(iBro.Url.ToString)
        End Sub

    End Class 'KzWebTab


    Public Class KzDictionary
        Inherits DataTable

        Public Property FileName As String
        Public Property Splitter As Char = "|"
        Public Property Author As String
        Public Property Updated As DateTime
        Public ReadOnly Property DataLoaded As Boolean
            Get
                Return Me.FileName IsNot Nothing And
                    Me.Columns.Count > 0 And
                    Me.Rows.Count > 0
            End Get
        End Property

        Private Sub SetColumns(defStr As String)
            Dim colDef() As String = defStr.Split(Me.Splitter)
            Dim s() As String
            Dim column As DataColumn

            For i As Integer = 0 To colDef.Length - 1
                With colDef(i)
                    If .Contains("^") Then
                        s = .Split("^")
                        column = New DataColumn(s(0))
                        column.DataType = GetDataType(s(1))
                        Me.Columns.Add(column)
                        Me.PrimaryKey = {column}
                    Else
                        s = .Split("@")
                        column = New DataColumn(s(0))
                        column.DataType = GetDataType(s(1))
                        Me.Columns.Add(column)
                    End If
                End With
            Next
        End Sub

        Private Function GetDataType(typeStr As String) As Type
            Select Case typeStr
                Case "str" : Return Type.GetType("System.String")
                Case "int" : Return Type.GetType("System.Int32")
                Case "bool" : Return Type.GetType("System.Boolean")
                Case "byte" : Return Type.GetType("system.Byte")
                'Case "chr" : Return Type.GetType("system.Char")
                Case "dec" : Return Type.GetType("system.Decimal")
                Case "dbl" : Return Type.GetType("system.Double")
                Case "i16" : Return Type.GetType("system.Int16")
                Case "i64" : Return Type.GetType("system.Int64")
                Case "dt" : Return Type.GetType("system.DateTime")
                Case "ts" : Return Type.GetType("system.TimeSpan")
                Case "sgl" : Return Type.GetType("system.Single")
                Case "guid" : Return Type.GetType("system.Guid")
                    'SByte
                    'UInt16
                    'UInt32
                    'UInt64
                Case Else : Return Type.GetType("System.String")
            End Select
        End Function

        Public Sub ReadData(Optional fileName As String = Nothing)
            If fileName Is Nothing Then
                fileName = Me.FileName
            End If

            Try
                Dim l As String
                Using fs As FileStream = New FileStream(fileName, FileMode.Open)
                    Using sr As StreamReader = New StreamReader(fs)
                        Dim columns() As String
                        Dim row As DataRow

                        l = sr.ReadLine
                        If l.StartsWith("#KzDictionary:") Then _
                                Me.TableName = l.Replace("#KzDictionary:", "").Trim _
                                Else Throw New FormatException("字典格式錯誤。")

                        l = sr.ReadLine
                        If l.StartsWith("#Definition:") And l.Contains(Me.Splitter) Then _
                                SetColumns(l.Replace("#Definition:", "").Trim) _
                                Else Throw New FormatException("字典定義錯誤。")

                        Me.FileName = fileName

                        Do
                            l = sr.ReadLine

                            If l.StartsWith("#Author:") Then
                                Me.Author = l.Replace("#Author:", "").Trim
                            ElseIf l.StartsWith("#Date:") Then
                                Try
                                    Me.Updated = CDate(l.Replace("#Date:", "").Trim)
                                Catch ex As Exception
                                    Me.Updated = Now.ToString
                                End Try
                            Else
                                If Not l.StartsWith("#") And l IsNot Nothing And
                                    l.Contains(Me.Splitter) Then

                                    columns = l.Split(Me.Splitter)

                                    row = Me.NewRow
                                    For i As Integer = 0 To columns.GetUpperBound(0)
                                        row(Me.Columns(i)) = columns(i)
                                    Next

                                    Me.Rows.Add(row)
                                End If
                            End If
                        Loop Until sr.EndOfStream
                    End Using
                End Using
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End Sub

        Public Function GetDataByPKey _
            (pkey As Integer, column As String) As String

            Try
                Dim r As DataRow = Me.Rows.Find(pkey)
                Return r(column)
            Catch ex As Exception
                MsgBox(ex.Message)
                Return Nothing
            End Try
        End Function

        Public Function GetDataByWord _
            (keyword As String, columnFind As String, columnDest As String) As String

            Try
                For Each r As DataRow In Me.Rows
                    If r(columnFind) = keyword Then
                        Return r(columnDest)
                        Exit For
                    End If
                Next

                Return Nothing
            Catch ex As Exception
                MsgBox(ex.Message)
                Return Nothing
            End Try
        End Function

    End Class 'KzDictionary


    Public Class KzAttribute

        Public Sub New(ByVal Attribute As FileAttributes)
            Me.Source = Attribute
            'Initialize()
        End Sub

        Public Sub New(ByVal Path As String)
            Try
                Dim fi As New FileInfo(Path)
                Me.Source = fi.Attributes
            Catch ex As Exception
                Try
                    Dim ds As New DirectoryInfo(Path)
                    Me.Source = ds.Attributes
                Catch exp As Exception
                    Me.Source = Nothing
                End Try
            End Try

        End Sub

        Public Sub New(ByVal File As FileInfo)
            Me.Source = File.Attributes
            'Initialize()
        End Sub '

        Public Sub New(ByVal Directory As DirectoryInfo)
            Me.Source = Directory.Attributes
            'Initialize()
        End Sub


#Region "PublicProperties"
        Public Property Source As FileAttributes
        'Public Property TextSeparator As Char
#End Region 'PublicProperties


#Region "ReadOnlyProperties"
        Public ReadOnly Property IsArchive As Boolean
            Get
                If (Source And FileAttributes.Archive) = FileAttributes.Archive Then
                    Return True
                Else
                    Return False
                End If
            End Get
        End Property
        Public ReadOnly Property IsCompressed As Boolean
            Get
                If (Source And FileAttributes.Compressed) = FileAttributes.Compressed Then
                    Return True
                Else
                    Return False
                End If
            End Get
        End Property
        Public ReadOnly Property IsDevice As Boolean
            Get
                If (Source And FileAttributes.Device) = FileAttributes.Device Then
                    Return True
                Else
                    Return False
                End If
            End Get
        End Property
        Public ReadOnly Property IsDirectory As Boolean
            Get
                If (Source And FileAttributes.Directory) = FileAttributes.Directory Then
                    Return True
                Else
                    Return False
                End If
            End Get
        End Property
        Public ReadOnly Property IsEncrypted As Boolean
            Get
                If (Source And FileAttributes.Encrypted) = FileAttributes.Encrypted Then
                    Return True
                Else
                    Return False
                End If
            End Get
        End Property
        Public ReadOnly Property IsHidden As Boolean
            Get
                If (Source And FileAttributes.Hidden) = FileAttributes.Hidden Then
                    Return True
                Else
                    Return False
                End If
            End Get
        End Property
        Public ReadOnly Property IsIntegrityStream As Boolean
            Get
                If (Source And FileAttributes.IntegrityStream) = FileAttributes.IntegrityStream Then
                    Return True
                Else
                    Return False
                End If
            End Get
        End Property
        Public ReadOnly Property IsNormal As Boolean
            Get
                If (Source And FileAttributes.Normal) = FileAttributes.Normal Then
                    Return True
                Else
                    Return False
                End If
            End Get
        End Property
        Public ReadOnly Property IsNoScrubData As Boolean
            Get
                If (Source And FileAttributes.NoScrubData) = FileAttributes.NoScrubData Then
                    Return True
                Else
                    Return False
                End If
            End Get
        End Property
        Public ReadOnly Property IsNotContentIndexed As Boolean
            Get
                If (Source And FileAttributes.NotContentIndexed) = FileAttributes.NotContentIndexed Then
                    Return True
                Else
                    Return False
                End If
            End Get
        End Property
        Public ReadOnly Property IsOffline As Boolean
            Get
                If (Source And FileAttributes.Offline) = FileAttributes.Offline Then
                    Return True
                Else
                    Return False
                End If
            End Get
        End Property
        Public ReadOnly Property IsReadOnly As Boolean
            Get
                If (Source And FileAttributes.ReadOnly) = FileAttributes.ReadOnly Then
                    Return True
                Else
                    Return False
                End If
            End Get
        End Property
        Public ReadOnly Property IsReparsePoint As Boolean
            Get
                If (Source And FileAttributes.ReparsePoint) = FileAttributes.ReparsePoint Then
                    Return True
                Else
                    Return False
                End If
            End Get
        End Property
        Public ReadOnly Property IsSparseFile As Boolean
            Get
                If (Source And FileAttributes.SparseFile) = FileAttributes.SparseFile Then
                    Return True
                Else
                    Return False
                End If
            End Get
        End Property
        Public ReadOnly Property IsSystem As Boolean
            Get
                If (Source And FileAttributes.System) = FileAttributes.System Then
                    Return True
                Else
                    Return False
                End If
            End Get
        End Property
        Public ReadOnly Property IsTemporary As Boolean
            Get
                If (Source And FileAttributes.Temporary) = FileAttributes.Temporary Then
                    Return True
                Else
                    Return False
                End If
            End Get
        End Property

        Public ReadOnly Property LineInCht As String
            Get
                Return GetLine("T")
            End Get
        End Property

        Public ReadOnly Property LineInChs As String
            Get
                Return GetLine("S")
            End Get
        End Property

        Public ReadOnly Property LineInBinary As String
            Get
                Return GetLine("B")
            End Get
        End Property

        Public ReadOnly Property LineInEng As String
            Get
                Return GetLine("E")
            End Get
        End Property

        Public ReadOnly Property LineInAlphabet As String
            Get
                Return GetLine("A")
            End Get
        End Property
#End Region 'ReadOnlyProperties

#Region "InsideJobs"
        Private Function GetLine(ByVal Type As String) As String
            'Type = E,N,T,S,A,P,...K,B

            Dim sb As New StringBuilder()

            Select Case Type
                Case "E", "N", "T", "S", "A", "P"
                    sb.Append(If(IsReadOnly, Translate(FileAttributes.ReadOnly, Type) & "，", ""))
                    sb.Append(If(IsHidden, Translate(FileAttributes.Hidden, Type) & "，", ""))
                    sb.Append(If(IsSystem, Translate(FileAttributes.System, Type) & "，", ""))
                    sb.Append(If(IsDirectory, Translate(FileAttributes.Directory, Type) & "，", ""))
                    sb.Append(If(IsArchive, Translate(FileAttributes.Archive, Type) & "，", ""))
                    sb.Append(If(IsDevice, Translate(FileAttributes.Device, Type) & "，", ""))
                    sb.Append(If(IsNormal, Translate(FileAttributes.Normal, Type) & "，", ""))
                    sb.Append(If(IsTemporary, Translate(FileAttributes.Temporary, Type) & "，", ""))
                    sb.Append(If(IsSparseFile, Translate(FileAttributes.SparseFile, Type) & "，", ""))
                    sb.Append(If(IsReparsePoint, Translate(FileAttributes.ReparsePoint, Type) & "，", ""))
                    sb.Append(If(IsCompressed, Translate(FileAttributes.Compressed, Type) & "，", ""))
                    sb.Append(If(IsOffline, Translate(FileAttributes.Offline, Type) & "，", ""))
                    sb.Append(If(IsNotContentIndexed, Translate(FileAttributes.NotContentIndexed, Type) & "，", ""))
                    sb.Append(If(IsEncrypted, Translate(FileAttributes.Encrypted, Type) & "，", ""))
                    sb.Append(If(IsIntegrityStream, Translate(FileAttributes.IntegrityStream, Type) & "，", ""))
                    sb.Append(If(IsNoScrubData, Translate(FileAttributes.NoScrubData, Type) & "，", ""))

                    If sb.ToString.EndsWith("，") Then
                        sb.Remove(sb.Length - 1, 1)
                    End If

                    Select Case Type
                        Case "E", "N"
                            sb.Replace("，", ",")
                        Case "A"
                            sb.Replace("，", "")
                        Case "P"
                            sb.Replace("，", vbCrLf)
                        Case Else
                    End Select

                Case "B"
                    sb.Append(If(IsReadOnly, "1", "0"))
                    sb.Append(If(IsHidden, "1", "0"))
                    sb.Append(If(IsSystem, "1", "0"))
                    sb.Append(If(IsDirectory, "1", "0"))
                    sb.Append(If(IsArchive, "1", "0"))
                    sb.Append(If(IsDevice, "1", "0"))
                    sb.Append(If(IsNormal, "1", "0"))
                    sb.Append(If(IsTemporary, "1", "0"))
                    sb.Append(If(IsSparseFile, "1", "0"))
                    sb.Append(If(IsReparsePoint, "1", "0"))
                    sb.Append(If(IsCompressed, "1", "0"))
                    sb.Append(If(IsOffline, "1", "0"))
                    sb.Append(If(IsNotContentIndexed, "1", "0"))
                    sb.Append(If(IsEncrypted, "1", "0"))
                    sb.Append(If(IsIntegrityStream, "1", "0"))
                    sb.Append(If(IsNoScrubData, "1", "0"))

                Case "K"
                    sb.Append(If(IsReadOnly, Translate(FileAttributes.ReadOnly, "A"), "-"))
                    sb.Append(If(IsHidden, Translate(FileAttributes.Hidden, "A"), "-"))
                    sb.Append(If(IsSystem, Translate(FileAttributes.System, "A"), "-"))
                    sb.Append(If(IsDirectory, Translate(FileAttributes.Directory, "A"), "-"))
                    sb.Append(If(IsArchive, Translate(FileAttributes.Archive, "A"), "-"))
                    sb.Append(If(IsDevice, Translate(FileAttributes.Device, "A"), "-"))
                    sb.Append(If(IsNormal, Translate(FileAttributes.Normal, "A"), "-"))
                    sb.Append(If(IsTemporary, Translate(FileAttributes.Temporary, "A"), "-"))
                    sb.Append(If(IsSparseFile, Translate(FileAttributes.SparseFile, "A"), "-"))
                    sb.Append(If(IsReparsePoint, Translate(FileAttributes.ReparsePoint, "A"), "-"))
                    sb.Append(If(IsCompressed, Translate(FileAttributes.Compressed, "A"), "-"))
                    sb.Append(If(IsOffline, Translate(FileAttributes.Offline, "A"), "-"))
                    sb.Append(If(IsNotContentIndexed, Translate(FileAttributes.NotContentIndexed, "A"), "-"))
                    sb.Append(If(IsEncrypted, Translate(FileAttributes.Encrypted, "A"), "-"))
                    sb.Append(If(IsIntegrityStream, Translate(FileAttributes.IntegrityStream, "A"), "-"))
                    sb.Append(If(IsNoScrubData, Translate(FileAttributes.NoScrubData, "A"), "-"))

            End Select

            Return sb.ToString
        End Function

        Private Function Translate(ByVal AttrIndex As FileAttributes, ByVal Type As Char) As String
            'Type = E,N,T,S,A,P,K
            Dim x(15, 5) As String
            'Eng - E
            x(0, 0) = "ReadOnly"
            x(1, 0) = "Hidden"
            x(2, 0) = "System"
            x(3, 0) = "Directory"
            x(4, 0) = "Archive"
            x(5, 0) = "Device"
            x(6, 0) = "Normal"
            x(7, 0) = "Temporary"
            x(8, 0) = "SparseFile"
            x(9, 0) = "ReparsePoint"
            x(10, 0) = "Compressed"
            x(11, 0) = "Offline"
            x(12, 0) = "NotContentIndexed"
            x(13, 0) = "Encrypted"
            x(14, 0) = "IntegrityStream"
            x(15, 0) = "NoScrubData"
            'Eid - N
            x(0, 1) = "1"
            x(1, 1) = "2"
            x(2, 1) = "4"
            x(3, 1) = "16"
            x(4, 1) = "32"
            x(5, 1) = "64"
            x(6, 1) = "128"
            x(7, 1) = "256"
            x(8, 1) = "512"
            x(9, 1) = "1024"
            x(10, 1) = "2048"
            x(11, 1) = "4096"
            x(12, 1) = "8192"
            x(13, 1) = "16384"
            x(14, 1) = "32768"
            x(15, 1) = "131072"
            'Cht - T
            x(0, 2) = "唯讀"
            x(1, 2) = "隱藏"
            x(2, 2) = "系統"
            x(3, 2) = "資料夾"
            x(4, 2) = "歸檔"
            x(5, 2) = "設備"
            x(6, 2) = "一般"
            x(7, 2) = "臨時"
            x(8, 2) = "稀疏"
            x(9, 2) = "重解析"
            x(10, 2) = "壓縮"
            x(11, 2) = "離線"
            x(12, 2) = "無索引"
            x(13, 2) = "加密"
            x(14, 2) = "完整流"
            x(15, 2) = "未移除"
            'Chs - S
            x(0, 3) = "只读"
            x(1, 3) = "隐藏"
            x(2, 3) = "系统"
            x(3, 3) = "目录"
            x(4, 3) = "存档"
            x(5, 3) = "设备"
            x(6, 3) = "普通"
            x(7, 3) = "临时"
            x(8, 3) = "稀疏"
            x(9, 3) = "重解析点"
            x(10, 3) = "压缩"
            x(11, 3) = "脱机"
            x(12, 3) = "非索引"
            x(13, 3) = "加密"
            x(14, 3) = "完整支持"
            x(15, 3) = "非完整支持"
            'Alp - A
            x(0, 4) = "R"
            x(1, 4) = "H"
            x(2, 4) = "S"
            x(3, 4) = "D"
            x(4, 4) = "A"
            x(5, 4) = "-"
            x(6, 4) = "N"
            x(7, 4) = "T"
            x(8, 4) = "L"
            x(9, 4) = "P"
            x(10, 4) = "C"
            x(11, 4) = "O"
            x(12, 4) = "Z"
            x(13, 4) = "E"
            x(14, 4) = "I"
            x(15, 4) = "X"
            'Exp - P
            x(0, 5) = "此文件是只读的。"
            x(1, 5) = "文件是隐藏的，因此没有包括在普通的目录列表中。"
            x(2, 5) = "此文件是系统文件。 即，该文件是操作系统的一部分或者由操作系统以独占方式使用。"
            x(3, 5) = "此文件是一个目录。"
            x(4, 5) = "该文件是备份或移除的候选文件。"
            x(5, 5) = "保留供将来使用。"
            x(6, 5) = "该文件是没有特殊属性的标准文件。 仅当其单独使用时，此特性才有效。"
            x(7, 5) = "文件是临时文件。 临时文件包含当执行应用程序时需要的，但当应用程序完成后不需要的数据。 文件系统尝试将所有数据保存在内存中，而不是将数据刷新回大容量存储，以便可以快速访问。 当临时文件不再需要时，应用程序应立即删除它。"
            x(8, 5) = "此文件是稀疏文件。 稀疏文件一般是数据通常为零的大文件。"
            x(9, 5) = "文件包含一个重新分析点，它是一个与文件或目录关联的用户定义的数据块。"
            x(10, 5) = "此文件是压缩文件。"
            x(11, 5) = "此文件处于脱机状态， 文件数据不能立即供使用。"
            x(12, 5) = "将不会通过操作系统的内容索引服务来索引此文件。"
            x(13, 5) = "此文件或目录已加密。对于文件来说，表示文件中的所有数据都是加密的。对于目录来说，表示新创建的文件和目录在默认情况下是加密的。"
            x(14, 5) = "文件或目录包括完整性支持数据。 在此值适用于文件时，文件中的所有数据流具有完整性支持。 此值将应用于一个目录时，所有新文件和子目录在该目录中和默认情况下应包括完整性支持。"
            x(15, 5) = "文件或目录从完整性扫描数据中排除。 此值将应用于一个目录时，所有新文件和子目录在该目录中和默认情况下应不包括数据完整性。"

            Dim id As Integer = 0
            For i As Integer = 0 To 15
                If CInt(x(i, 1)) = AttrIndex Then
                    id = i
                End If
            Next

            Select Case Type
                Case "E"
                    Return x(id, 0)
                Case "N"
                    Return x(id, 1)
                Case "T"
                    Return x(id, 2)
                Case "S"
                    Return x(id, 3)
                Case "A"
                    Return x(id, 4)
                Case "P"
                    Return x(id, 5)
                Case Else
                    Return x(id, 0)
            End Select

        End Function
#End Region 'InsideJobs

#Region "Reference"
        ' 成员名称 描述 
        ' Archive       该文件是备份或移除的候选文件。 
        ' Compressed    此文件是压缩文件。 
        ' Device        保留供将来使用。 
        ' Directory     此文件是一个目录。 
        ' Encrypted     此文件或目录已加密。 对于文件来说，表示文件中的所有数据都是加密的。对于目录来说，表示新创建的文件和目录在默认情况下是加密的。 
        ' Hidden        文件是隐藏的，因此没有包括在普通的目录列表中。 
        ' IntegrityStream 文件或目录包括完整性支持数据。 在此值适用于文件时，文件中的所有数据流具有完整性支持。 此值将应用于一个目录时，所有新文件和子目录在该目录中和默认情况下应包括完整性支持。 
        ' Normal        该文件是没有特殊属性的标准文件。 仅当其单独使用时，此特性才有效。 
        ' NoScrubData   文件或目录从完整性扫描数据中排除。 此值将应用于一个目录时，所有新文件和子目录在该目录中和默认情况下应不包括数据完整性。 
        ' NotContentIndexed 将不会通过操作系统的内容索引服务来索引此文件。 
        ' Offline       此文件处于脱机状态， 文件数据不能立即供使用。 
        ' ReadOnly      此文件是只读的。 
        ' ReparsePoint  文件包含一个重新分析点，它是一个与文件或目录关联的用户定义的数据块。 
        ' SparseFile    此文件是稀疏文件。 稀疏文件一般是数据通常为零的大文件。 
        ' System        此文件是系统文件。 即，该文件是操作系统的一部分或者由操作系统以独占方式使用。 
        ' Temporary     文件是临时文件。 临时文件包含当执行应用程序时需要的，但当应用程序完成后不需要的数据。 文件系统尝试将所有数据保存在内存中，而不是将数据刷新回大容量存储，以便可以快速访问。 当临时文件不再需要时，应用程序应立即删除它。 

#End Region
    End Class




End Namespace