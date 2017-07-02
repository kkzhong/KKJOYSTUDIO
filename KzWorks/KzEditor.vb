Imports KzWorks.KzLibrary
Imports System.IO
Imports System.Text
Imports System.Globalization

Public Class KzEditor

    Private WithEvents iTab As KzTextTab
    Private WithEvents iBox As TextBox
    Private SelExpMode As Boolean

    Public Sub New()

        ' 此调用是设计器所必需的。
        InitializeComponent()

        ' 在 InitializeComponent() 调用之后添加任何初始化。

    End Sub

    Private Sub KzEditor_Load(sender As Object, e As EventArgs) Handles Me.Load
        TextKzTabControl.Initialize()
        TextKzTabControl.Type = KzTabControlTypes.TextEditor
        TextKzTabControl.AllowDrop = True
        InfoUpdate()
        SelExpMode = False
        ModeInfoItem.Text = "正常"
    End Sub

    Private Sub TextKzTabControl_SelectedIndexChanged(sender As Object, e As EventArgs) _
      Handles TextKzTabControl.SelectedIndexChanged

        Try
            iTab = TextKzTabControl.SelectedTab
        Catch ex As Exception
            iTab = Nothing
        End Try

        Try
            iBox = iTab.TextBox
        Catch ex As Exception
            iBox = Nothing
        End Try

        InfoUpdate()
    End Sub

    Private Sub NewToolStripButton_Click(sender As Object, e As EventArgs) _
        Handles NewToolStripButton.Click

        TextKzTabControl.AddTab(KzItemPosition.LastItem)
        iTab = TextKzTabControl.SelectedTab
        iBox = iTab.TextBox
        InfoUpdate()
    End Sub

    Private Sub OpenToolStripButton_Click(sender As Object, e As EventArgs) _
        Handles OpenToolStripButton.Click

        OpenTextFiles(KzFile.GetOpenFiles())
        Try
            iTab = TextKzTabControl.SelectedTab
            iBox = iTab.TextBox
        Catch ex As Exception

        End Try

        InfoUpdate()
    End Sub


#Region "DragDropEvent"
    Private Sub TextKzTabControl_DragEnter(sender As Object, e As DragEventArgs) _
        Handles TextKzTabControl.DragEnter

        If e.Data.GetDataPresent(DataFormats.FileDrop) Then
            e.Effect = DragDropEffects.All
        End If

        Try
            iBox.BackColor = Color.SkyBlue
            iBox.BorderStyle = BorderStyle.FixedSingle
        Catch ex As Exception

        End Try
    End Sub

    Private Sub TextKzTabControl_DragDrop(sender As Object, e As DragEventArgs) _
        Handles TextKzTabControl.DragDrop
        Try
            iBox.BackColor = SystemColors.Window
            iBox.BorderStyle = BorderStyle.None
        Catch ex As Exception

        End Try

        If e.Data.GetDataPresent(DataFormats.FileDrop) Then
            Dim DroppedFiles() As String = e.Data.GetData(DataFormats.FileDrop)
            OpenTextFiles(DroppedFiles)
        ElseIf e.Data.GetDataPresent(DataFormats.Text) Or e.Data.GetDataPresent(DataFormats.UnicodeText) Then

        End If
    End Sub

    Private Sub TextKzTabControl_DragLeave(sender As Object, e As EventArgs) _
        Handles TextKzTabControl.DragLeave
        Try
            iBox.BackColor = SystemColors.Window
            iBox.BorderStyle = BorderStyle.None
        Catch ex As Exception

        End Try
    End Sub

#End Region 'DragDropEvent


#Region "InsideJob"
    Private Sub OpenTextFiles(files As String(), Optional toSelectedTab As Boolean = False)
        If files.Length > 10 Then
            If MsgBox(
                "同時開啟文檔過多，有可能導致系統崩潰。是否繼續？",
                MsgBoxStyle.YesNo, "警告") = MsgBoxResult.No Then Exit Sub
        End If

        Me.Cursor = Cursors.WaitCursor

        Dim sb As New StringBuilder()
        If files IsNot Nothing And files.Length > 0 Then
            If toSelectedTab Then
                If Not IsOpened(files(0)) Then
                    Try
                        iTab.ReadText(files(0))
                    Catch ex As Exception
                        sb.AppendLine("#File: " & files(0))
                        sb.AppendLine(" [Error] " & ex.Message)
                    End Try
                End If

            Else
                For Each f As String In files
                    If Not IsOpened(f) Then
                        Try
                            Dim aTab As New KzTextTab
                            aTab.ReadText(f)
                            TextKzTabControl.AddTab(KzItemPosition.LastItem, aTab)

                            'My.Settings.EditorFileHistory.Add(f)
                        Catch ex As Exception
                            sb.AppendLine("#File: " & f)
                            sb.AppendLine(" [Error] " & ex.Message)
                        End Try
                    End If
                Next
            End If
        End If

        Me.Cursor = Cursors.Default

        If sb.Length > 0 Then
            MsgBox(sb.ToString, MsgBoxStyle.OkOnly, "Error list")
        End If
    End Sub

    Private Function IsOpened(PathStr As String) As Boolean
        If TextKzTabControl.TabCount > 0 Then
            For Each kt As KzTextTab In TextKzTabControl.TabPages
                If kt.FilePath = PathStr Then Return True
            Next
        End If

        Return False
    End Function

    Private Enum MsgType
        All
        State
        TextChanged
        Count
        TextCount
        SelectionCount
        SelectionMode
        EncodingName
        LoadingSpan
        File
        FileInfo
        FolderInfo
    End Enum

    Private Sub InfoUpdate(Optional infoType As MsgType = MsgType.All)
        If infoType = MsgType.State Or infoType = MsgType.All Or infoType = MsgType.TextChanged Then
            Try
                If iTab.IsNew Then
                    StateInfoItem.Text = "新建"
                Else
                    If iTab.NeedSave Then
                        StateInfoItem.Text = "變更"
                    Else
                        StateInfoItem.Text = "就緒"
                    End If
                End If
            Catch ex As Exception
                StateInfoItem.Text = "未知"
            End Try
        End If

        If infoType = MsgType.TextCount Or infoType = MsgType.Count Or
            infoType = MsgType.All Or infoType = MsgType.TextChanged Then
            Try
                TextInfoItem.Text = Strings.Format(iBox.TextLength, "#,0") & " 字長"
            Catch ex As Exception
                TextInfoItem.Text = " 無文本 "
            End Try
        End If

        If infoType = MsgType.SelectionCount Or infoType = MsgType.Count Or
            infoType = MsgType.All Or infoType = MsgType.TextChanged Then
            Try
                SelectionInfoItem.Text =
                    Strings.Format(iBox.SelectionStart, "#,0") & " 起 " &
                    Strings.Format(iBox.SelectionLength, "#,0") & "字"
                'LengthInfoItem.Text = Strings.Format(iBox.SelectionLength, "#,0")
            Catch ex As Exception
                SelectionInfoItem.Text = " 無選擇 "
                'LengthInfoItem.Text = "-"
            End Try
        End If

        If infoType = MsgType.EncodingName Or infoType = MsgType.All Then
            Try
                EncodingInfoItem.Text = iTab.Encoding.WebName.ToUpper '.EncodingName
            Catch ex As Exception
                EncodingInfoItem.Text = " 未知 "
            End Try
        End If

        If infoType = MsgType.LoadingSpan Or infoType = MsgType.All Then
            Try
                SpanInfoItem.Text = iTab.LastLoadingTime.Replace(" ", "")
            Catch ex As Exception
                SpanInfoItem.Text = " 0 "
            End Try
        End If

        If infoType = MsgType.FileInfo Or infoType = MsgType.File Or infoType = MsgType.All Then
            Try
                FileInfoItem.Text = KzStr.GetFileLength(iTab.FileInfo.Length)
            Catch ex As Exception
                FileInfoItem.Text = " 無文檔 "
            End Try
        End If

        If infoType = MsgType.FolderInfo Or infoType = MsgType.File Or infoType = MsgType.All Then
            Try
                FolderInfoItem.Text = Path.GetFileName(iTab.FileInfo.DirectoryName)
                FolderInfoItem.DropDownItems.Clear()
                FolderInfoItem.DropDownItems.Add _
                    (iTab.FileInfo.DirectoryName, Nothing,
                     New EventHandler(AddressOf OnFolderInfoItemClick))
            Catch ex As Exception
                FolderInfoItem.Text = ""
            End Try
        End If
    End Sub

    Private Sub OnFolderInfoItemClick()
        System.Diagnostics.Process.Start _
            ("explorer.exe", FolderInfoItem.DropDownItems(0).Text)
    End Sub

#End Region 'InsideJob


    Private Sub iBox_TextChanged(sender As Object, e As EventArgs) Handles iBox.TextChanged
        InfoUpdate(MsgType.TextChanged)
    End Sub

    Private Sub iBox_MouseDown(sender As Object, e As MouseEventArgs) _
        Handles iBox.MouseDown, iBox.MouseUp
        InfoUpdate(MsgType.SelectionCount)
    End Sub

    Private Sub iBox_KeyUp(sender As Object, e As KeyEventArgs) Handles iBox.KeyUp
        If e.KeyValue = Keys.Left Or e.KeyValue = Keys.Right Or
            e.KeyValue = Keys.Up Or e.KeyValue = Keys.Down Then
            InfoUpdate(MsgType.SelectionCount)
        End If
    End Sub

    Private Sub SaveToolStripButton_Click(sender As Object, e As EventArgs) _
        Handles SaveToolStripButton.Click
        Try
            iTab.Save()
            InfoUpdate(MsgType.State)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub SaveAllToolStripButton_Click(sender As Object, e As EventArgs) _
        Handles SaveAllToolStripButton.Click

        If TextKzTabControl.TabCount > 0 Then
            Try
                For Each tab As KzTextTab In TextKzTabControl.TabPages
                    tab.Save()
                Next
                InfoUpdate(MsgType.State)
            Catch ex As Exception

            End Try
        End If
    End Sub

    Private Sub CloseToolStripButton_Click(sender As Object, e As EventArgs) _
        Handles CloseToolStripButton.Click

        Dim CanClose As Boolean = True
        Dim NeedCheck As Boolean = True

        If TextKzTabControl.TabCount > 0 Then
            Try
                For Each tab As KzTextTab In TextKzTabControl.TabPages
                    If tab.NeedSave Then
                        CanClose = False
                        Exit For
                    End If
                Next
            Catch ex As Exception
                Dim r As MsgBoxResult = MsgBox(ex.Message & vbCrLf & "是否繼續退出？", MsgBoxStyle.YesNo, "確認")

                If r = MsgBoxResult.Yes Then
                    CanClose = True
                Else
                    CanClose = False
                    NeedCheck = False
                End If
            End Try
        End If

        If Not CanClose And NeedCheck Then
            Dim r As MsgBoxResult = MsgBox("還有已開啟但未保存的文檔。是否全部保存？", MsgBoxStyle.YesNoCancel, "確認")

            If r = MsgBoxResult.Yes Then
                SaveAllToolStripButton_Click(Nothing, Nothing)
                CanClose = True
            ElseIf r = MsgBoxResult.No Then
                CanClose = True
            End If
        End If

        If CanClose Then Me.Dispose()
    End Sub

    Private Function StdInt(number As Long) As String
        Return Strings.Format(number, "#,0")
    End Function

    Private Sub TextInfoItem_DropDownOpening(sender As Object, e As EventArgs) Handles TextInfoItem.DropDownOpening

        Try
            With iBox
                CharsTextItem.Text = "字 符 數：" & iTab.TextInfo.Length ' StdInt(.TextLength)
                CharsWoSpacesTextItem.Text = "無 空 格：" & StdInt(.Text.Replace("　", "").Replace(" ", "").Length)
                ChineseCharsTextItem.Text = "中文字符："
                WordsTextItem.Text = "詞    數："
                ChineseCharsTextItem.Text = "中文字數："
                ParagraphsTextItem.Text = "段 落 數："
                LinesTextItem.Text = "行    數：" & StdInt(.Lines.Count)
                PunctuationsTextItem.Text = "標 點 數："
                TextElementsTextItem.Text = "文本元素：" & StdInt(New StringInfo(.Text).LengthInTextElements)
                DetailTextItem.Text = "（詳細）"
            End With
        Catch ex As Exception
            CharsTextItem.Text = "字 符 數："
            CharsWoSpacesTextItem.Text = "無 空 格："
            ChineseCharsTextItem.Text = "中文字符："
            WordsTextItem.Text = "詞    數："
            ChineseCharsTextItem.Text = "中文字數："
            ParagraphsTextItem.Text = "段 落 數："
            LinesTextItem.Text = "行    數："
            PunctuationsTextItem.Text = "標 點 數："
            TextElementsTextItem.Text = "文本元素："
            DetailTextItem.Text = "（詳細）"
        End Try
    End Sub
End Class
