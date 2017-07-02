Imports System.ComponentModel

Public Class StartForm

#Region "Friends"

    Friend Sub FormSwitch(ByVal FormToOpen As Form, Optional FormText As String = Nothing,
                          Optional ByVal OpenAsMDI As Boolean = True,
                          Optional ByVal OpenMax As Boolean = True)
        Try
            If FormToOpen IsNot Nothing Then
                With FormToOpen
                    For Each f As Form In Me.MdiChildren
                        If f.Name <> .Name Then
                            f.Close()
                            Console.WriteLine("Form [" & f.Name & "] closed. [" & Now().ToString & "]")
                        End If
                    Next

                    If OpenAsMDI Then
                        .MdiParent = Me
                        .ControlBox = False
                    Else
                        .MdiParent = Nothing
                        .ControlBox = True
                    End If

                    If OpenMax Then
                        .WindowState = FormWindowState.Maximized
                    Else
                        .WindowState = FormWindowState.Normal
                    End If

                    .Text = FormText
                    .Show()
                    CmdTableLayoutPanel.Hide()
                End With

            Else
                For Each f As Form In Me.MdiChildren
                    f.Close()
                    CmdTableLayoutPanel.Show()
                Next
            End If
        Catch ex As Exception

        End Try
    End Sub

    Friend Function GetStartBounds(ByVal TryBounds As Rectangle) As Rectangle
        'MsgBox("[0]" & Screen.AllScreens(0).Bounds.ToString & vbNewLine & "[1]" & Screen.AllScreens(1).Bounds.ToString)
        Dim Ans As Rectangle = TryBounds
        Dim Temp As Rectangle = Screen.GetWorkingArea(TryBounds.Location)

        If Temp.Contains(TryBounds) Then
            Ans = TryBounds
        Else
            If Temp.Contains(TryBounds.Location) Then
                If TryBounds.X > (Temp.X + CInt(Temp.Width * 2 / 3)) And TryBounds.Y > CInt(Temp.Height * 2 / 3) Then
                    Ans.Location = New Point(Temp.X + CInt(Temp.Width * 2 / 3), CInt(Temp.Height * 2 / 3))
                ElseIf TryBounds.X > (Temp.X + CInt(Temp.Width * 2 / 3)) Then
                    Ans.Location = New Point(Temp.X + CInt(Temp.Width * 2 / 3), TryBounds.Y)
                ElseIf TryBounds.Y > CInt(Temp.Height * 2 / 3) Then
                    Ans.Location = New Point(TryBounds.X, CInt(Temp.Height * 2 / 3))
                End If
            Else
                If TryBounds.Width > Temp.Width And TryBounds.Height > Temp.Height Then
                    Ans = Temp
                ElseIf TryBounds.Width > Temp.Width Then
                    Ans.Location = New Point(Temp.X, TryBounds.Y)
                ElseIf TryBounds.Height > Temp.Height Then
                    Ans.Location = New Point(TryBounds.X, Temp.Y)
                ElseIf TryBounds.X > (Temp.X + Temp.Width) And TryBounds.Y > (Temp.Y + Temp.Height) Then
                    Ans.Location = New Point(Temp.X + CInt(Temp.Width * 2 / 3), CInt(Temp.Height * 2 / 3))
                ElseIf TryBounds.X > (Temp.X + Temp.Width) Then
                    Ans.Location = New Point(Temp.X + CInt(Temp.Width * 2 / 3), TryBounds.Y)
                ElseIf TryBounds.Y > (Temp.Y + Temp.Height) Then
                    Ans.Location = New Point(TryBounds.X, CInt(Temp.Height * 2 / 3))
                End If
            End If
        End If

        Return Ans
    End Function

#End Region 'Friends


    Private Sub StartForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Icon = My.Resources.logo

        With My.Settings
            Me.Text = .AppName & " " & .AppVersion

            Dim TryBounds As New Rectangle(.StartPoint, .StartSize)
            Me.DesktopBounds = GetStartBounds(TryBounds)

            Me.WindowState = .StartState

        End With

        GenToolTip.SetToolTip(EditorButton, "開啟編輯器")
        GenToolTip.SetToolTip(ExitButton, "退出程式")
    End Sub

    Private Sub StartForm_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        With My.Settings
            .StartState = Me.WindowState
            .StartPoint = Me.Location
            .StartSize = Me.Size
        End With
    End Sub

    Private Sub StartForm_SizeChanged(sender As Object, e As EventArgs) Handles Me.SizeChanged
        With CmdTableLayoutPanel
            Dim wRect As Rectangle = Me.ClientRectangle
            Dim side As Integer
            If wRect.Width > wRect.Height Then
                side = CInt(wRect.Height / 2)
            Else
                side = CInt(wRect.Width / 2)
            End If

            .SetBounds(CInt(wRect.Width - side) / 2, CInt(wRect.Height - side) / 2, side, side)
        End With
    End Sub



#Region "Commands"
    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click, ExitButton.Click
        Application.Exit()
    End Sub

    Private Sub CloseAllToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CloseAllToolStripMenuItem.Click
        FormSwitch(Nothing)
    End Sub

    Private Sub EditorButton_Click(sender As Object, e As EventArgs) Handles EditorButton.Click, EditorToolStripMenuItem.Click
        FormSwitch(EditorForm, "編輯器")
    End Sub

    Private Sub BrowserButton_Click(sender As Object, e As EventArgs) Handles BrowserButton.Click
        FormSwitch(BrowserForm, "瀏覽器")
    End Sub

    Private Sub TestToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles T2ToolStripMenuItem.Click
        'Dim kss As New KzLibrary.KzDrawingStyle(0)
        'MsgBox(kss.HoverFont.Name)

        'Dim fName As String
        'Dim ofd As New OpenFileDialog
        'If ofd.ShowDialog = DialogResult.OK Then
        '    fName = ofd.FileName
        '    MsgBox(KzLibrary.KzEncoding.GetEncoding(fName).ToString)
        '    'Dim fileEncoding As Encoding = KzLibrary.TextFileEncodingDetector.DetectTextFileEncoding(fName, Encoding.Default)
        '    'MsgBox(fileEncoding.EncodingName)
        'End If

        'KzMsgBox(MsgType.ProgramConfirm, KzLibrary.KzGetStr.FileLength(1568555365))

        'Dim ad As New KzLibrary.KzDictionary
        'If File.Exists(Path.Combine(MyPresetFolder, "Attributes.kzdict")) Then
        '    MsgBox("Exists")
        'Else
        '    MsgBox("NotExists")
        'End If
        'ad.ReadData(Path.Combine(MyPresetFolder, "Attributes.kzdict"))
        ''KzLibrary.KzMsg.Break(ad.GetDataByPKey(FileAttributes.ReparsePoint, "Chr"))
        'KzLibrary.KzMsg.Break(ad.GetDataByWord("Compressed", "Keyword", "Cht"))

        FormSwitch(ReplacementForm, "測試")
    End Sub



    Private Sub T1ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles T1ToolStripMenuItem.Click
        'Dim x As New KzLibrary.TextDialog("test")
        'x.ShowDialog()

        FormSwitch(CompTest, "測試")
    End Sub

#End Region 'Commands

End Class
