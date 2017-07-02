Imports System.IO
Imports System.Text.RegularExpressions
'Imports System.Windows.Controls.Primitives

Public Class KzReplacer
    Dim WithEvents iBox As TextBox

    Public Sub New()
        ' 此调用是设计器所必需的。
        InitializeComponent()
        ' 在 InitializeComponent() 调用之后添加任何初始化。

        With RepKzTabControl
            .Initialize()
            .ItemSize = New Size(50, 25)
            .ShowCloseButton = False
            .ShowTabMenu = False
            .DoAutoTabWidth = False
        End With
    End Sub

    Private Sub KzReplacer_Load(sender As Object, e As EventArgs) Handles Me.Load
        SetCoreInfo(True, True)
        SetSpanInfo()
    End Sub

#Region "PublicProperties"
    Public Property EffectedBox As TextBox
        Get
            Return iBox
        End Get
        Set(value As TextBox)
            iBox = value
            SetCoreInfo(True)
            FromTextBox.Text = 0
            Try
                ToTextBox.Text = iBox.TextLength
                ObjectButton.ToolTipText = iBox.GetType.ToString
            Catch ex As Exception
                ToTextBox.Text = 0
                ObjectButton.ToolTipText = "No Object"
            End Try
        End Set
    End Property

#End Region 'PublicProperties

#Region "Messages"
    Private Sub SetCoreInfo(Optional withState As Boolean = False,
                           Optional withOptions As Boolean = False)
        If withState Then
            SetState()
        End If
        SetRangeInfo()
        SetRegexInfo(withOptions)
    End Sub 'SetCoreInfo()

    Private Sub SetState()
        If iBox Is Nothing Then
            StateInfoItem.Text = "掛起"
        Else
            StateInfoItem.Text = "就緒"
        End If
    End Sub 'SetState()

    Private Sub SetRangeInfo()
        Dim r As String = Nothing
        Try
            If iBox.TextLength > 0 Then
                Dim l As Integer = iBox.TextLength
                Dim st As Integer = iBox.SelectionStart

                If iBox.SelectionLength = 0 Then
                    If rdbPreviousAll.Checked Then
                        If st = 0 Then
                            r = "<->0..." & l
                        ElseIf st = l Then
                            r = "<0...>" & l
                        Else
                            r = "<0...>" & st & "..." & l
                        End If

                    ElseIf rdbNextAll.Checked Then
                        If st = 0 Then
                            r = "0<..." & l & ">"
                        ElseIf st = l Then
                            r = "0..." & l & "<~>"
                        Else
                            r = "0..." & st & "<..." & l & ">"
                        End If
                    Else
                        If st = 0 Then
                            r = "<0>..." & l
                        ElseIf st = l Then
                            r = "0...<" & l & ">"
                        Else
                            r = "0...<" & st & ">..." & l
                        End If

                    End If

                Else
                    Dim en As Integer = iBox.SelectionStart + iBox.SelectionLength
                    If rdbSelectedAll.Checked Then
                        If st = 0 And en = l Then
                            r = "<0-" & en & ">"
                        ElseIf st = 0 And en < l Then
                            r = "<0-" & en & ">..." & l
                        ElseIf st > 0 And en = l Then
                            r = "0...<" & st & "-" & l & ">"
                        Else
                            r = "0...<" & st & "-" & en & ">..." & l
                        End If

                    ElseIf rdbPreviousAll.Checked Then
                        If st = 0 And en = l Then
                            r = "<-1>0-" & en
                        ElseIf st = 0 And en < l Then
                            r = "<-1>0-" & en & "..." & l
                        ElseIf st > 0 And en = l Then
                            r = "<0...>" & st & "-" & l
                        Else
                            r = "<0...>" & st & "-" & en & "..." & l
                        End If

                    ElseIf rdbNextAll.Checked Then
                        If st = 0 And en = l Then
                            r = "0-" & en & "<~>"
                        ElseIf st = 0 And en < l Then
                            r = "0-" & en & "<..." & l & ">"
                        ElseIf st > 0 And en = l Then
                            r = "0..." & st & "-" & l & "<~>"
                        Else
                            r = "0..." & st & "-" & en & "<..." & l & ">"
                        End If

                    Else
                        If st = 0 And en = l Then
                            r = "<0-" & en & ">"
                        ElseIf st = 0 And en < l Then
                            r = "<0-" & en & ">..." & l
                        ElseIf st > 0 And en = l Then
                            r = "<0..." & st & "-" & l & ">"
                        Else
                            r = "<0..." & st & "-" & en & "..." & l & ">"
                        End If
                    End If
                End If

            Else
                r = "（無文本）"
            End If

        Catch ex As Exception
            r = "（無文檔）"
        End Try

        If rdbSelectedAll.Checked Or rdbPreviousAll.Checked Or rdbNextAll.Checked Then
            RangeLabel.Text = "選定：" & r
        Else
            RangeLabel.Text = "全文：" & r
        End If
    End Sub 'SetRangeInfo()

    Private Sub SetRegexInfo(Optional withOptions As Boolean = False)
        If Finder.TextLength > 0 Then
            Try
                Dim rgx As Regex = GetRegEx()
                Dim mts As MatchCollection = rgx.Matches(iBox.Text)
                FoundInfoItem.Text = "共 " & mts.Count & " 筆"
                FoundInSelInfoItem.Text = "(選中 " & rgx.Matches(iBox.SelectedText).Count & " 筆) "
                IndexInfoItem.Text = MatchPosition(iBox.SelectionStart, mts)
            Catch ex As Exception
                FoundInfoItem.Text = "[無文本]"
                FoundInSelInfoItem.Text = ""
                IndexInfoItem.Text = ""
            End Try
        Else
            FoundInfoItem.Text = "[無查找]"
            FoundInSelInfoItem.Text = ""
            IndexInfoItem.Text = ""
        End If

        If withOptions Then
            OptionsInfoItem.Text = "[" & GetOptions() & "]"
        End If
    End Sub 'SetRegexInfo()

    Private Sub SetSpanInfo(Optional objectName As String = Nothing, Optional span As String = Nothing)
        If objectName Is Nothing Then
            SpanInfoItem.Text = ""
        Else
            SpanInfoItem.Text = objectName & ": " & span
        End If
    End Sub 'SetSpanInfo
#End Region

#Region "PrivateMethods"

    Private Function GetRegEx(Optional ByVal ForcedRightToLeft As Boolean = False) As Regex
        Return New Regex(Finder.Text, GetOptions(ForcedRightToLeft))
    End Function

    Private Function GetOptions(Optional ByVal ForcedRightToLeft As Boolean = False) As RegexOptions
        Dim ro As RegexOptions ' = RegexOptions.None
        With OptionsCheckedList
            If .GetItemChecked(0) Then ro = ro Or RegexOptions.IgnoreCase '忽略大小寫
            If .GetItemChecked(1) Then ro = ro Or RegexOptions.IgnorePatternWhitespace '忽略空格
            If .GetItemChecked(2) Then ro = ro Or RegexOptions.Multiline '多行模式
            If .GetItemChecked(3) Then ro = ro Or RegexOptions.Singleline '單線模式
            If .GetItemChecked(4) Then ro = ro Or RegexOptions.ExplicitCapture  '僅顯式捕獲
            If .GetItemChecked(5) Then ro = ro Or RegexOptions.CultureInvariant  '地域化比較
            'If .GetItemChecked(6) Then ro = ro Or RegexOptions.Compiled  '已編譯
            'If .GetItemChecked(7) Then ro = ro Or RegexOptions.RightToLeft  '從右向左
            'If .GetItemChecked(8) Then ro = ro Or RegexOptions.ECMAScript  'ECMA腳本匹配
            'If .GetItemChecked(9) Then  '區分全半角

            If ForcedRightToLeft Then
                ro = ro Or RegexOptions.RightToLeft
            End If
        End With

        Return ro
    End Function

    Private Function MatchID _
        (ByVal TheIndex As Integer, ByVal TheMatches As MatchCollection) As Integer

        Dim ans As Integer = -1
        If TheMatches.Count > 0 Then
            If TheIndex > TheMatches(TheMatches.Count - 1).Index Then
                ans = -2
            Else
                For i As Integer = 0 To TheMatches.Count - 1
                    If TheMatches(i).Index >= TheIndex Then
                        ans = i
                        Exit For
                    End If
                Next
            End If
        End If

        Return ans '(-1：無匹配； -2：位於末筆之後； 0：位於首筆之前； 其他：n筆之前）
    End Function

    Private Function MatchPosition _
        (ByVal TheIndex As Integer, ByVal TheMatches As MatchCollection) As String

        Dim id As Integer = MatchID(TheIndex, TheMatches)
        Select Case id
            Case -1
                Return "無一致項"
            Case -2
                Return "位於第 " & TheMatches.Count & " 筆之後"
                'Return "第 " & TheMatches.Count & " 筆[" & TheMatches(TheMatches.Count - 1).Index & "]尾筆之後"
            Case Else
                Dim s As String = "位於第 " & id + 1 & " 筆"
                'Dim s As String = "第 " & id + 1 & " 筆[" & TheMatches(id).Index & "]"
                'If id = 0 Then
                '    s = s & "(首筆)"
                'ElseIf id = TheMatches.Count - 1 Then
                '    s = s & "(尾筆)"
                'End If

                If TheIndex = TheMatches(id).Index Then
                    Return s & ""
                Else
                    Return s & "之前"
                End If
        End Select
    End Function

    Private Sub SetSelection _
        (selectionStart As Integer, selectionLength As Integer,
         Optional senderName As String = Nothing, Optional number As Integer = -1)

        Try
            iBox.Select(selectionStart, selectionLength)
            'iBox.SelectionStart = selectionStart
            'iBox.SelectionLength = selectionLength
            iBox.ScrollToCaret()

            If senderName IsNot Nothing Then
                If number = -1 Then
                    SetRecorder(senderName, "@" & selectionStart)
                Else
                    SetRecorder(senderName, "&" & number)
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub SetRecorder _
        (objectName As String, Optional message As String = Nothing)

        CmdRecorder.Text &= Now().ToString & " " & objectName & " " & message & vbCrLf
        CmdRecorder.ScrollToCaret()
    End Sub

    ''' <summary>
    ''' 取得預設樣式列表，用於顯示在 ProjectListView
    ''' </summary>
    ''' <param name="RepLstName">需要開啟的預設列表文檔名</param>
    Private Sub GetPatterns(ByVal Optional RepLstName As String = "Common.replst")
        Try
            Using Sr As New StreamReader(Path.Combine(MyPresetFolder, RepLstName), System.Text.Encoding.Default)
                Dim Tx As String
                Dim Txs() As String
                Dim Ix As Integer
                ProjectListView.Items.Clear()

                Do
                    Tx = Sr.ReadLine
                    If Tx <> "" And Tx IsNot Nothing And Strings.Left(Tx, 1) <> "#" Then
                        If Tx.Contains("┇") Then

                            Ix = Ix + 1
                            Txs = Tx.Split("┇")

                            Dim item As ListViewItem = Nothing
                            Dim subItems() As ListViewItem.ListViewSubItem
                            item = New ListViewItem(Txs(0))
                            subItems = New ListViewItem.ListViewSubItem() {
                                New ListViewItem.ListViewSubItem(item, Txs(1)),
                                New ListViewItem.ListViewSubItem(item, Txs(2)),
                                New ListViewItem.ListViewSubItem(item, Txs(3)),
                                New ListViewItem.ListViewSubItem(item, Txs(4)),
                                New ListViewItem.ListViewSubItem(item, Txs(5))}
                            item.SubItems.AddRange(subItems)
                            ProjectListView.Items.Add(item)
                        End If
                    End If
                Loop Until Sr.EndOfStream
            End Using

            ProjectListView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize)

            If regFindParttern.Width > 128 Then
                regFindParttern.Width = 128
            End If
            If regReplaceParttern.Width > 128 Then
                regReplaceParttern.Width = 128
            End If

            KzLibrary.ListViewHelper.SetListColor(ProjectListView)
            SetRecorder("讀入樣式表", "共 " & ProjectListView.Items.Count & " 筆")
        Catch ex As Exception
            SetRecorder("讀入樣式表", ex.Message)
        End Try


    End Sub

    ''' <summary>
    ''' 取得查找結果列表，用於顯示在 ResaultListView
    ''' </summary>
    ''' <param name="IsClear"></param>
    Private Sub GetResult(ByVal Optional IsClear As Boolean = False)
        If IsClear Then
            ResaultListView.Items.Clear()
        Else
            If iBox.TextLength > 0 And Finder.Text.Length > 0 Then
                Try
                    Dim mts As MatchCollection = GetRegEx().Matches(iBox.Text)
                    If mts.Count > 256 Then
                        If MsgBox("查找結果 " & Strings.Format(mts.Count, "#,0.") & " 筆" &
                                  vbCrLf & "列表將花費過多時間。是否繼續？", vbOKCancel, "確認") = MsgBoxResult.Cancel Then
                            Exit Sub
                        End If
                    End If

                    ResaultListView.Items.Clear()

                    If mts.Count > 0 Then
                        Dim ts As New KzLibrary.KzTimeShift(Now())
                        Me.Cursor = Cursors.WaitCursor

                        Dim item As ListViewItem = Nothing
                        Dim subItems() As ListViewItem.ListViewSubItem

                        For i As Integer = 0 To mts.Count - 1
                            item = New ListViewItem((i + 1).ToString)

                            Dim x As Integer = mts.Item(i).Index
                            Dim l As Integer = mts.Item(i).Length

                            subItems = New ListViewItem.ListViewSubItem() {
                                        New ListViewItem.ListViewSubItem(item, mts.Item(i).Value),
                                        New ListViewItem.ListViewSubItem(item, x),
                                        New ListViewItem.ListViewSubItem(item, l),
                                        New ListViewItem.ListViewSubItem(item, iBox.Text.Substring(Math.Max(x - 20, 0), Math.Min(20, x))),
                                        New ListViewItem.ListViewSubItem(item, iBox.Text.Substring(x + l, Math.Min(20, iBox.TextLength - x - l))),
                                        New ListViewItem.ListViewSubItem(item, If(Replacer.Text = "", "", mts.Item(i).Result(Replacer.Text)))}
                            item.SubItems.AddRange(subItems)
                            ResaultListView.Items.Add(item)
                        Next
                        ResaultListView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize)
                        KzLibrary.ListViewHelper.SetListColor(ResaultListView)

                        Me.Cursor = Cursors.Default
                        ts.EndTime = Now()

                        SetSpanInfo("列表", ts.SpanText.Replace(" ", ""))
                    End If
                    SetRecorder("列出查找結果", "共 " & ResaultListView.Items.Count & " 筆")
                Catch ex As Exception
                    SetRecorder("列出查找結果", ex.Message)
                End Try
            End If
        End If


    End Sub

#End Region 'PrivateMethods


    Private Sub Finder_TextChanged _
        (sender As Object, e As EventArgs) Handles Finder.TextChanged

        Finder.Text = Finder.Text
        SetRegexInfo()
    End Sub

    Private Sub Replacer_TextChanged _
        (sender As Object, e As EventArgs) Handles Replacer.TextChanged

    End Sub

    Private Sub OptionsCheckedList_SelectedIndexChanged _
        (sender As Object, e As EventArgs) Handles OptionsCheckedList.SelectedIndexChanged
        'OptionIDLabel.Text = GetOptions()
        SetRegexInfo(True)
    End Sub

    Private Sub iBox_TextChanged _
        (sender As Object, e As EventArgs) Handles iBox.TextChanged

        SetCoreInfo()
    End Sub

    Private Sub iBox_MouseUp _
        (sender As Object, e As MouseEventArgs) Handles iBox.MouseUp
        If e.Button = MouseButtons.Left Then
            SetCoreInfo()
        End If
    End Sub

    Private Sub iBox_KeyDown(sender As Object, e As KeyEventArgs) Handles iBox.KeyUp
        If e.KeyCode = Keys.Left Or Keys.Right Or Keys.Up Or Keys.Down Then
            SetCoreInfo()
        End If
    End Sub

    Private Sub FromTextBox_KeyPress _
        (sender As Object, e As KeyPressEventArgs) Handles FromTextBox.KeyPress, ToTextBox.KeyPress
        '限制文本框只能輸入數字
        If Char.IsDigit(e.KeyChar) Then ' Or e.KeyChar = Chr(8) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub FirstButton_Click(sender As Object, e As EventArgs) Handles FirstButton.Click
        Try
            Dim rgx As Regex = GetRegEx()
            Dim mt As Match = rgx.Match(iBox.Text)

            If mt.Success Then
                SetSelection(mt.Index, mt.Length, sender.Text)
            End If

            SetRegexInfo()
        Catch ex As Exception
            SetRecorder(sender.Text, ex.Message)
        End Try
    End Sub

    Private Sub PreviousButton_Click(sender As Object, e As EventArgs) Handles PreviousButton.Click
        Try
            Dim rgx As Regex = GetRegEx(True)
            Dim mt As Match = rgx.Match(iBox.Text, iBox.SelectionStart)

            If mt.Success Then
                SetSelection(mt.Index, mt.Length, sender.Text)
            Else
                If RoundCheckBox.Checked Then
                    mt = rgx.Match(iBox.Text, iBox.TextLength)
                    If mt.Success Then
                        SetSelection(mt.Index, mt.Length, sender.Text)
                    Else
                        MsgBox("已查找到達文初，未找到一致項。", vbOKOnly, "確認")
                        SetRecorder(sender.Text, "ToStart")
                    End If
                Else
                    MsgBox("已查找到達文初，未找到一致項。", vbOKOnly, "確認")
                    SetRecorder(sender.Text, "ToStart")
                End If
            End If

            SetRegexInfo()
        Catch ex As Exception
            SetRecorder(sender.Text, ex.Source)
        End Try
    End Sub

    Private Sub NextButton_Click(sender As Object, e As EventArgs) Handles NextButton.Click
        Try
            Dim rgx As Regex = GetRegEx()
            Dim mt As Match = rgx.Match(iBox.Text, iBox.SelectionStart)

            If mt.Success And mt.NextMatch.Success Then
                If iBox.SelectedText = mt.Value Then
                    mt = mt.NextMatch
                End If
                SetSelection(mt.Index, mt.Length, sender.Text)
            ElseIf mt.Success And Not mt.NextMatch.Success Then
                If iBox.SelectedText = mt.Value Then
                    If RoundCheckBox.Checked Then
                        mt = rgx.Match(iBox.Text, 0)
                        SetSelection(mt.Index, mt.Length, sender.Text)
                    Else
                        MsgBox("已查找到達文末，未找到一致項。", vbOKOnly, "確認")
                        SetRecorder(sender.Text, "ToEnd")
                    End If
                Else
                    SetSelection(mt.Index, mt.Length, sender.Text)
                End If
            Else
                If RoundCheckBox.Checked Then
                    mt = rgx.Match(iBox.Text, 0)
                    SetSelection(mt.Index, mt.Length, sender.Text)
                Else
                    MsgBox("已查找到達文末，未找到一致項。", vbOKOnly, "確認")
                    SetRecorder(sender.Text, "ToEnd")
                End If
            End If

            SetRegexInfo()
        Catch ex As Exception
            SetRecorder(sender.Text, ex.Message)
        End Try
    End Sub

    Private Sub LastButton_Click(sender As Object, e As EventArgs) Handles LastButton.Click
        Try
            Dim rgx As Regex = GetRegEx(True)
            Dim mt As Match = rgx.Match(iBox.Text, iBox.TextLength)

            If mt.Success Then
                SetSelection(mt.Index, mt.Length, sender.Text)
            End If

            SetRegexInfo()
        Catch ex As Exception
            SetRecorder(sender.Text, ex.Source)
        End Try
    End Sub

    Private Sub ReplaceButton_Click(sender As Object, e As EventArgs) Handles ReplaceButton.Click
        If iBox Is Nothing Then Exit Sub

        Dim go As Boolean
        Dim rgx As Regex
        Dim ic As Integer = 0 '計數器

        Try
            rgx = GetRegEx()
        Catch ex As Exception
            MsgBox("查找式錯誤！", MsgBoxStyle.OkOnly, "錯誤")
            Exit Sub
        End Try

        '判斷是否可以執行替換
        If iBox.TextLength > 0 And Finder.Text.Length > 0 Then
            If rgx.IsMatch(iBox.Text) Then
                If Replacer.Text.Length = 0 Then
                    If MsgBox("替換式為空，查找一致內容將被刪除。" & vbCrLf & "是否繼續？", vbYesNo, "確認") = MsgBoxResult.Yes Then
                        go = True
                    Else
                        go = False
                    End If
                Else
                    go = True
                End If
            Else
                MsgBox("未找到一致項，未能執行替換！", vbOKOnly, "警告")
                go = False
            End If
        Else
            MsgBox("原文或查找式為空，未能執行替換！", vbOKOnly, "警告")
            go = False
        End If

        If Not go Then Exit Sub

        '執行替換
        If AllCheckBox.Checked Then
            'rgx = GetRegEx()
            With iBox
                ic = rgx.Matches(.Text).Count
                .Text = rgx.Replace(.Text, Replacer.Text)
                SetSelection(0, 0, sender.text, ic)
            End With
            MsgBox("全部替換完成。共 " & ic & " 筆", vbOKOnly, "確認")

        Else

            If rdbMoveNext.Checked Or
                (Not rdbMoveNext.Checked And Not rdbMoveNone.Checked And Not rdbMovePrevious.Checked And
                Not rdbNextAll.Checked And Not rdbPreviousAll.Checked And Not rdbSelectedAll.Checked) Then

                'rgx = New Regex(Finder.text)
                With iBox
                    Dim mt As Match = rgx.Match(.Text, .SelectionStart)
                    If .SelectedText <> mt.Value Then
                        SetSelection(mt.Index, mt.Length, sender.Text, 1)
                    Else
                        If .SelectedText.Length > 0 Then
                            .SelectedText = mt.Result(Replacer.Text)
                            mt = rgx.Match(.Text, .SelectionStart)
                            If mt.Success Then
                                SetSelection(mt.Index, mt.Length, sender.Text, 1)
                            Else
                                If RoundCheckBox.Checked And rgx.IsMatch(.Text) Then
                                    mt = rgx.Match(.Text, 0)
                                    SetSelection(mt.Index, mt.Length, sender.Text, 1)
                                ElseIf Not RoundCheckBox.Checked And rgx.IsMatch(.Text) Then
                                    If MsgBox("已到達文末，向後未找到一致文本！" & vbCrLf & "是否從文初開始繼續替換？", vbOKCancel, "確認") = vbOK Then
                                        mt = rgx.Match(.Text, 0)
                                        SetSelection(mt.Index, mt.Length, sender.Text, 1)
                                    Else
                                        MsgBox("已到達文末，向後未找到一致文本！" & vbCrLf & "替換完成。", vbOKOnly, "確認")
                                        SetRecorder(sender.Text, "ToEnd")
                                    End If
                                Else
                                    MsgBox("未找到一致文本！" & vbCrLf & "替換完成。", vbOKOnly, "確認")
                                    SetRecorder(sender.Text, "Nothing ToEnd")
                                End If
                            End If
                        End If
                    End If
                End With

            ElseIf rdbMovePrevious.Checked Then
                rgx = GetRegEx(True)
                'rgx = New Regex(Finder.text, RegexOptions.RightToLeft)
                With iBox
                    Dim mt As Match = rgx.Match(.Text, .SelectionStart + .SelectionLength)
                    If .SelectedText <> mt.Value Then
                        SetSelection(mt.Index, mt.Length, sender.Text, 1)
                    Else
                        If .SelectedText.Length > 0 Then
                            .SelectedText = mt.Result(Replacer.Text)
                            mt = rgx.Match(.Text, .SelectionStart + .SelectionLength)
                            If mt.Success Then
                                SetSelection(mt.Index, mt.Length, sender.Text, 1)
                            Else
                                If RoundCheckBox.Checked And rgx.IsMatch(.Text, .TextLength) Then
                                    mt = rgx.Match(.Text, .TextLength)
                                    SetSelection(mt.Index, mt.Length, sender.Text, 1)
                                ElseIf Not RoundCheckBox.Checked And rgx.IsMatch(.Text, .TextLength) Then
                                    If MsgBox("已到達文初，向前未找到一致項目！" & vbCrLf & "是否從文末開始繼續替換？", vbOKCancel, "確認") = vbOK Then
                                        mt = rgx.Match(.Text, .TextLength)
                                        SetSelection(mt.Index, mt.Length, sender.Text, 1)
                                    Else
                                        MsgBox("已到達文初，向前未找到一致項目！" & vbCrLf & "替換完成。", vbOKOnly, "確認")
                                        SetRecorder(sender.Text, "ToStart")
                                    End If
                                Else
                                    MsgBox("未找到一致項目！" & vbCrLf & "替換完成。", vbOKOnly, "確認")
                                    SetRecorder(sender.Text, "Nothing ToStart")
                                End If
                            End If
                        End If
                    End If
                End With

            ElseIf rdbMoveNone.Checked Then

                'rgx = New Regex(Finder.text)
                With iBox
                    Dim mt As Match = rgx.Match(.Text, .SelectionStart)
                    If .SelectedText.Length > 0 And .SelectedText = mt.Value Then
                        .SelectedText = mt.Result(Replacer.Text)
                        SetSelection(mt.Index, mt.Result(Replacer.Text).Length, sender.Text, 1)
                    End If
                End With

            ElseIf rdbNextAll.Checked Or rdbPreviousAll.Checked Or rdbSelectedAll.Checked Then
                'rgx = New Regex(Finder.text)
                Dim contents As String = Nothing

                With iBox
                    Dim iStart, iEnd As Integer

                    If rdbNextAll.Checked Then
                        iStart = .SelectionStart
                        iEnd = .TextLength
                    ElseIf rdbPreviousAll.Checked Then
                        iStart = 0
                        iEnd = .SelectionStart
                    ElseIf rdbSelectedAll.Text Then
                        iStart = .SelectionStart
                        iEnd = .SelectionStart + .SelectionLength
                    End If

                    If iEnd > iStart And rgx.IsMatch(.Text.Substring(iStart, iEnd - iStart)) Then
                        ic = rgx.Matches(.Text.Substring(iStart, iEnd - iStart)).Count
                        .Text = .Text.Substring(0, iStart) &
                            rgx.Replace(.Text.Substring(iStart, iEnd - iStart), Replacer.Text) &
                            .Text.Substring(iEnd, .TextLength - iEnd)
                        SetSelection(iStart, 0, sender.Text, ic)
                        MsgBox("替換完成。共 " & ic & " 筆。")
                    Else
                        MsgBox("")
                    End If
                End With
            End If
        End If
    End Sub

    Private Sub ResaultListButton_Click(sender As Object, e As EventArgs) Handles ResaultListButton.Click
        GetResult()
        RepKzTabControl.SelectedTab = ListTab
    End Sub

    Private Sub FromButton_Click(sender As Object, e As EventArgs) Handles FromButton.Click
        Try
            FromTextBox.Text = iBox.SelectionStart
        Catch ex As Exception
            FromTextBox.Text = "0"
        End Try
    End Sub

    Private Sub ToButton_Click(sender As Object, e As EventArgs) Handles ToButton.Click
        Try
            ToTextBox.Text = iBox.SelectionStart
        Catch ex As Exception
            ToTextBox.Text = "0"
        End Try
    End Sub

    Private Sub ResetButton_Click(sender As Object, e As EventArgs) Handles ResetButton.Click
        FromTextBox.Text = 0
        Try
            ToTextBox.Text = iBox.TextLength
        Catch ex As Exception
            ToTextBox.Text = 0
        End Try
    End Sub

    Private Sub SelectButton_Click(sender As Object, e As EventArgs) Handles SelectButton.Click
        Dim st As Integer = FromTextBox.Text
        Dim en As Integer = ToTextBox.Text

        If st > en Then
            st = ToTextBox.Text
            en = FromTextBox.Text
        End If

        Try
            SetSelection(st, en - st + 1, sender.Text, st)
            SetCoreInfo()
        Catch ex As Exception
            SetRecorder(sender.Text, ex.Message)
        End Try
    End Sub

    Private Sub RepKzTabControl_SelectedIndexChanged _
        (sender As Object, e As EventArgs) Handles RepKzTabControl.SelectedIndexChanged

        'Dim tp As TabPage = RepKzTabControl.SelectedTab

        'If tp.Equals(NormalTab) Then
        '    ResaultListButton.Enabled = True
        'ElseIf tp.Equals(ProjectTab) Then
        '    ResaultListButton.Enabled = True
        'ElseIf tp.Equals(ListTab) Then
        '    ResaultListButton.Enabled = False
        'ElseIf tp.Equals(RecorderTab) Then
        '    ResaultListButton.Enabled = True
        'End If

        'IDListItem.Text = RepKzTabControl.SelectedIndex
    End Sub

    Private Sub ResaultListView_SelectedIndexChanged _
        (sender As Object, e As EventArgs) Handles ResaultListView.SelectedIndexChanged
        Try
            With ResaultListView
                If .SelectedItems.Count > 0 Then
                    SetSelection(.SelectedItems(0).SubItems(2).Text,
                                 .SelectedItems(0).SubItems(3).Text)
                End If
            End With
        Catch ex As Exception

        End Try
    End Sub

    Private Sub TryReplaceListItem_Click _
        (sender As Object, e As EventArgs) Handles TryReplaceListItem.Click
        If resReplacement.DisplayIndex = 6 Then
            resOriginWord.DisplayIndex = 6
            resReplacement.DisplayIndex = 2
        ElseIf resReplacement.DisplayIndex = 2 Then
            resOriginWord.DisplayIndex = 2
            resReplacement.DisplayIndex = 6
        End If

        With ResaultListView
            .Refresh()
            .AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize)
            'SetListColor(lvwResult)
        End With
    End Sub

    Private Sub ClearResaultsListItem_Click _
        (sender As Object, e As EventArgs) Handles ClearResaultsListItem.Click
        ResaultListView.Items.Clear()
    End Sub

    Private Sub GoFromButton_Click(sender As Object, e As EventArgs) Handles GoFromButton.Click, GoToButton.Click
        Try
            If sender.Name = "GoFromButton" Then
                SetSelection(FromTextBox.Text, 0)
            Else
                SetSelection(ToTextBox.Text, 0)
            End If

            SetRangeInfo()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub GoToButton_Click(sender As Object, e As EventArgs) Handles GoToButton.Click
        Try

        Catch ex As Exception

        End Try
    End Sub
End Class

Public Class KzRegexPatternListView
    Inherits ListView

    Public Sub New(Optional fileName As String = Nothing)
        Me.FileName = fileName

        With Me
            .CheckBoxes = True
            .FullRowSelect = True
            .GridLines = True
            .UseCompatibleStateImageBehavior = False
            .View = View.Details
            '.Dock = DockStyle.Fill

            Dim chs As ColumnHeader() = {
                New ColumnHeader() With {.Text = "#", .DisplayIndex = 0},
                New ColumnHeader() With {.Text = "模式", .DisplayIndex = 1},
                New ColumnHeader() With {.Text = "主題", .DisplayIndex = 2},
                New ColumnHeader() With {.Text = "查找式", .DisplayIndex = 3},
                New ColumnHeader() With {.Text = "替換式", .DisplayIndex = 4}
            }

            .Columns.AddRange(chs)
        End With

    End Sub

    Public Property DefaultDirectory As String = Path.Combine(Application.StartupPath, "Preset")
    Public Property Category As String
    Public Property CreatedDate As String
    Public Property Comments As String
    Public Property Author As String
    Public Property LastUpdated As String
    Public Property FileName As String
    '    Get
    '        Return iPath
    '    End Get
    '    Set(value As String)
    '        iPath = value
    '    End Set
    'End Property

    Private Function GetHeader() As String
        Return _
            "#Category:" & Me.Category & vbCrLf &
            "#Author:" & Me.Author & vbCrLf &
            "#Created:" & Me.CreatedDate & vbCrLf &
            "#LastUpdated:" & Now().ToString & vbCrLf &
            "#Comments:" & Me.Comments & vbCrLf &
            "#┇模式┇主題┇查找式┇替換式" & vbCrLf &
            "#┇1┇2┇3┇4" & vbCrLf &
            "#BOF" & vbCrLf
    End Function

    Public Sub GetPatterns(Optional isRenew As Boolean = True)
        Try
            If isRenew Then
                Me.Items.Clear()
            End If

            Using sr As New StreamReader(Me.FileName)
                Dim Tx As String
                Dim Txs() As String
                Dim Ix As Integer

                Do
                    Tx = sr.ReadLine

                    If Tx.StartsWith("#Category:") Then
                        Me.Category = Tx.Replace("#Category:", "").Trim
                    ElseIf Tx.StartsWith("#Author:") Then
                        Me.Author = Tx.Replace("#Author:", "").Trim
                    ElseIf Tx.StartsWith("#Created:") Then
                        Me.CreatedDate = Tx.Replace("#Created:", "").Trim
                    ElseIf Tx.StartsWith("#LastUpdated:") Then
                        Me.LastUpdated = Tx.Replace("#LastUpdated:", "").Trim
                    ElseIf Tx.StartsWith("#Comments:") Then
                        Me.Comments = Tx.Replace("#Comments:", "").Trim
                    ElseIf Tx <> "" And Tx IsNot Nothing And
                        Strings.Left(Tx, 1) <> "#" And Tx.Contains("┇") Then

                        Ix = Ix + 1
                        Txs = Tx.Split("┇")

                        Dim item As ListViewItem = Nothing
                        Dim subItems() As ListViewItem.ListViewSubItem
                        item = New ListViewItem(Txs(0))
                        subItems = New ListViewItem.ListViewSubItem() {
                                New ListViewItem.ListViewSubItem(item, Txs(1)),
                                New ListViewItem.ListViewSubItem(item, Txs(2)),
                                New ListViewItem.ListViewSubItem(item, Txs(3)),
                                New ListViewItem.ListViewSubItem(item, Txs(4))}
                        item.SubItems.AddRange(subItems)
                        Me.Items.Add(item)
                    End If
                Loop Until sr.EndOfStream
            End Using

            Me.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize)
            If Me.Columns(3).Width > 128 Then Me.Columns(3).Width = 128
            If Me.Columns(4).Width > 128 Then Me.Columns(4).Width = 128
            KzLibrary.ListViewHelper.SetListColor(Me)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Sub SavePatterns(Optional filePath As String = Nothing)
        If filePath Is Nothing Then
            filePath = Me.FileName
        Else
            If File.Exists(filePath) Then
                Dim mr As MsgBoxResult
                mr = MsgBox("文檔已存在，是否覆蓋存檔？", MsgBoxStyle.YesNo, "警告")
                If mr = MsgBoxResult.No Then Exit Sub
            End If
        End If

        Dim Tx As String
        Try
            Using sw As StreamWriter = New StreamWriter(filePath)
                sw.Write(GetHeader())

                For i As Integer = 0 To Me.Items.Count - 1
                    Tx = ""
                    For j As Integer = 0 To Me.Items(i).SubItems.Count - 1
                        Tx &= Me.Items(i).SubItems(j).Text
                        If j < Me.Items(i).SubItems.Count - 1 Then
                            Tx &= "┇"
                        End If
                    Next
                    sw.WriteLine(Tx)
                Next

                sw.WriteLine("#EOF")
            End Using

            Me.FileName = filePath
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class




