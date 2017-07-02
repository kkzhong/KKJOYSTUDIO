Imports System.ComponentModel
Imports KzWorks.KzLibrary
Imports System.Net
Imports System.IO
Imports System.Text

Public Class KzBrowser

    Private WithEvents iTab As KzWebTab
    Private WithEvents iBro As WebBrowser

    Public Sub New()

        ' 此调用是设计器所必需的。
        InitializeComponent()

        ' 在 InitializeComponent() 调用之后添加任何初始化。

    End Sub

    Protected Overrides Sub Finalize()
        MyBase.Finalize()
    End Sub

    Private Sub KzBrowser_Load(sender As Object, e As EventArgs) Handles Me.Load
        WebKzTabControl.Initialize()
        WebKzTabControl.Type = KzTabControlTypes.WebBrowser

    End Sub

    Private Sub BrowserToolStrip_SizeChanged(sender As Object, e As EventArgs) Handles Me.SizeChanged ' BrowserToolStrip.SizeChanged
        Dim lengthExpTextBox As Integer = 0
        For Each item As ToolStripItem In BrowserToolStrip.Items
            If Not item.GetType = GetType(ToolStripTextBox) Then
                lengthExpTextBox += item.Width
            End If
        Next

        UrlToolItem.Width = BrowserToolStrip.Width - lengthExpTextBox - 10
    End Sub


    Private Sub GoToolItem_Click(sender As Object, e As EventArgs) Handles GoToolItem.Click
        Dim strUrl As String = UrlToolItem.Text.Trim
        If strUrl.Contains("http://") = False Or strUrl.Contains("https://") Then strUrl = "http://" & strUrl

        UrlToolItem.Text = strUrl

        If WebKzTabControl.TabCount = 0 Then
            WebKzTabControl.AddTab(KzItemPosition.LastItem)
            iTab = WebKzTabControl.SelectedTab
            iBro = iTab.WebBrowser
        End If

        Application.DoEvents()
        iBro.Navigate(UrlToolItem.Text.Trim)
    End Sub

    Private Sub AddToolItem_Click(sender As Object, e As EventArgs) Handles AddToolItem.Click
        WebKzTabControl.AddTab(KzItemPosition.LastItem)
        iTab = WebKzTabControl.SelectedTab
        iBro = iTab.WebBrowser
    End Sub

    Private Sub WebKzTabControl_SelectedIndexChanged(sender As Object, e As EventArgs) _
        Handles WebKzTabControl.SelectedIndexChanged
        Try
            iTab = WebKzTabControl.SelectedTab
            iBro = iTab.WebBrowser
        Catch ex As Exception

        End Try
    End Sub

    Private Sub BackToolItem_Click(sender As Object, e As EventArgs) Handles BackToolItem.Click
        Try
            iBro.GoBack()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub ForwardToolItem_Click(sender As Object, e As EventArgs) Handles ForwardToolItem.Click
        Try
            iBro.GoForward()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub RefreshToolItem_Click(sender As Object, e As EventArgs) Handles RefreshToolItem.Click
        Try
            iBro.Refresh()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub UrlToolItem_KeyDown(sender As Object, e As KeyEventArgs) Handles UrlToolItem.KeyDown
        If e.KeyCode = Keys.Enter Then
            GoToolItem_Click(Nothing, Nothing)
        End If
    End Sub

    Private Sub CloseToolItem_Click(sender As Object, e As EventArgs) Handles CloseToolItem.Click
        Me.Dispose()
    End Sub

    Private Sub iBro_NewWindow(sender As Object, e As CancelEventArgs) Handles iBro.NewWindow
        Dim urlNew As String = sender.Document.ActiveElement.GetAttribute("href")
        If urlNew.Trim = "" Then urlNew = ""

        WebKzTabControl.AddTab(KzItemPosition.NextItem)
        iTab = WebKzTabControl.SelectedTab
        iBro = iTab.WebBrowser

        Application.DoEvents()
        iBro.Navigate(urlNew)

        e.Cancel = True
    End Sub

    Private Sub SourceToolStripMenuItem_Click _
        (sender As Object, e As EventArgs) Handles SourceToolStripMenuItem.Click
        Try
            'MsgBox(iBro.Url.ToString)
            Dim src As New TextDialog(GetWebCode(iBro.Url.ToString)) 'iBro.DocumentText) '
            src.ShowDialog()
        Catch ex As Exception

        End Try
    End Sub

#Region "CopyFrom[greatbody]"
    Private Function GetWebCode(ByVal strURL As String) As String
        Dim httpReq As System.Net.HttpWebRequest
        Dim httpResp As System.Net.HttpWebResponse
        Dim httpURL As New System.Uri(strURL)
        Dim ioS As System.IO.Stream, charSet As String, tCode As String
        Dim k() As Byte
        ReDim k(0)
        Dim dataQue As New Queue(Of Byte)
        httpReq = CType(WebRequest.Create(httpURL), HttpWebRequest)
        Dim sTime As Date = #1990-09-21 00:00:00# ' CDate("1990-09-21 00:00:00")
        httpReq.IfModifiedSince = sTime
        httpReq.Method = "GET"
        httpReq.Timeout = 7000

        Try
            httpResp = CType(httpReq.GetResponse(), HttpWebResponse)
        Catch
            Debug.Print("weberror")
            GetWebCode = "<title>no thing found</title>" : Exit Function
        End Try
        '以上为网络数据获取  
        ioS = CType(httpResp.GetResponseStream, Stream)
        Do While ioS.CanRead = True
            Try
                dataQue.Enqueue(ioS.ReadByte)
            Catch
                Debug.Print("read error")
                Exit Do
            End Try
        Loop
        ReDim k(dataQue.Count - 1)
        For j As Integer = 0 To dataQue.Count - 1
            k(j) = dataQue.Dequeue
        Next
        '以上，为获取流中的的二进制数据  
        tCode = Encoding.GetEncoding("UTF-8").GetString(k) '获取特定编码下的情况，毕竟UTF-8支持英文正常的显示  
        charSet = Replace(GetByDiv2(tCode, "charset=", """"), """", "") '进行编码类型识别  
        '以上，获取编码类型  
        If charSet = "" Then 'defalt  
            If httpResp.CharacterSet = "" Then
                tCode = Encoding.GetEncoding("UTF-8").GetString(k)
            Else
                tCode = Encoding.GetEncoding(httpResp.CharacterSet).GetString(k)
            End If
        Else
            tCode = Encoding.GetEncoding(charSet).GetString(k)
        End If
        Debug.Print(charSet)
        'Stop  
        '以上，按照获得的编码类型进行数据转换  
        '将得到的内容进行最后处理，比如判断是不是有出现字符串为空的情况  
        GetWebCode = tCode
        If tCode = "" Then GetWebCode = "<title>no thing found</title>"
    End Function

    Private Function GetByDiv2(ByVal code As String, ByVal divBegin As String, ByVal divEnd As String)  '获取分隔符所夹的内容[完成，未测试]  
        '仅用于获取编码数据  
        Dim lgStart As Integer
        Dim lens As Integer
        Dim lgEnd As Integer
        lens = Len(divBegin)
        If InStr(1, code, divBegin) = 0 Then GetByDiv2 = "" : Exit Function
        lgStart = InStr(1, code, divBegin) + CInt(lens)

        lgEnd = InStr(lgStart + 1, code, divEnd)
        If lgEnd = 0 Then GetByDiv2 = "" : Exit Function
        GetByDiv2 = Mid(code, lgStart, lgEnd - lgStart)
    End Function
#End Region



End Class
