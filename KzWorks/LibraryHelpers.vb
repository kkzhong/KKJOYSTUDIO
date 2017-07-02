Imports System.Text
Imports System.IO

Namespace KzLibrary
    '/// <summary>
    '/// 对ListView点击列标题自动排序功能
    '/// </summary>
    Public Class ListViewHelper
        '/// 构造函数
        Public Sub New()

        End Sub

        Public Shared Sub ListView_ColumnClick(ByVal sender As Object, ByVal e As System.Windows.Forms.ColumnClickEventArgs)
            Dim lv As ListView
            lv = DirectCast(sender, ListView)

            '// 检查点击的列是不是现在的排序列.
            If DirectCast(lv.ListViewItemSorter, ListViewColumnSorter).SortColumn = e.Column Then
                '// 重新设置此列的排序方法.
                If System.Windows.Forms.SortOrder.Ascending = DirectCast(lv.ListViewItemSorter, ListViewColumnSorter).Order Then '1
                    DirectCast(lv.ListViewItemSorter, ListViewColumnSorter).Order = System.Windows.Forms.SortOrder.Descending  '2
                Else
                    DirectCast(lv.ListViewItemSorter, ListViewColumnSorter).Order = System.Windows.Forms.SortOrder.Ascending   '1
                End If
            Else
                '// 设置排序列，默认为正向排序
                DirectCast(lv.ListViewItemSorter, ListViewColumnSorter).SortColumn = e.Column
                DirectCast(lv.ListViewItemSorter, ListViewColumnSorter).Order = System.Windows.Forms.SortOrder.Ascending   '1
            End If
            '// 用新的排序方法对ListView排序
            '((System.Windows.Forms.ListView)sender).Sort()
            DirectCast(sender, ListView).Sort()

            '// 設色，add by kk
            SetListColor(lv)
        End Sub

        Public Shared Sub SetListColor(ByVal TheList As ListView)
            If TheList.View = View.Details And TheList.Columns.Count > 0 And TheList.Items.Count > 0 Then
                For i As Integer = 0 To TheList.Items.Count - 1
                    If i Mod 2 = 0 Then
                        TheList.Items(i).BackColor = Color.WhiteSmoke
                    Else
                        TheList.Items(i).BackColor = Color.Snow
                    End If
                Next
            End If
        End Sub

        Public Shared Sub MoveListItem(ByVal ThisListBox As ListBox, ByVal FromIndex As Integer, ByVal ToIndex As Integer)
            Dim TempListItem As String

            With ThisListBox
                If .SelectedItems.Count > 0 Then
                    TempListItem = .Items(FromIndex).ToString
                    .Items.RemoveAt(FromIndex)
                    .Items.Insert(ToIndex, TempListItem)
                End If
            End With
        End Sub
    End Class

    '/// <summary>
    '/// 继承自IComparer
    '/// </summary>
    Public Class ListViewColumnSorter

        Implements System.Collections.IComparer

        '/// <summary>
        '/// 指定按照哪个列排序
        '/// </summary>
        Private ColumnToSort As Integer

        '/// <summary>
        '/// 指定排序的方式
        '/// </summary>
        Private OrderOfSort As System.Windows.Forms.SortOrder

        '/// <summary>
        '/// 声明CaseInsensitiveComparer类对象
        '/// </summary>
        Private ObjectCompare As System.Collections.CaseInsensitiveComparer

        '/// <summary>
        '/// 构造函数
        '/// </summary>
        Public Sub New()
            '// 默认按第一列排序
            ColumnToSort = 0

            '// 排序方式为不排序
            OrderOfSort = System.Windows.Forms.SortOrder.None

            '// 初始化CaseInsensitiveComparer类对象
            ObjectCompare = New System.Collections.CaseInsensitiveComparer
        End Sub

        '/// <summary>
        '/// 重写IComparer接口.
        '/// </summary>
        '/// <param name="x">要比较的第一个对象</param>
        '/// <param name="y">要比较的第二个对象</param>
        '/// <returns>比较的结果.如果相等返回0，如果x大于y返回1，如果x小于y返回-1</returns>
        Public Function Compare(ByVal x As Object, ByVal y As Object) As Integer Implements System.Collections.IComparer.Compare
            Dim compareResult As Integer

            '// 将比较对象转换为ListViewItem对象
            Dim listviewX As ListViewItem
            Dim listviewY As ListViewItem

            listviewX = DirectCast(x, ListViewItem)
            listviewY = DirectCast(y, ListViewItem)

            Dim xText As String = listviewX.SubItems(ColumnToSort).Text
            Dim yText As String = listviewY.SubItems(ColumnToSort).Text

            'Dim xInt, yInt As Integer

            '//比较对象
            compareResult = ObjectCompare.Compare(xText, yText)

            '// 根据上面的比较结果返回正确的比较结果
            If (OrderOfSort = System.Windows.Forms.SortOrder.Ascending) Then
                '// 因为是正序排序，所以直接返回结果
                Return compareResult
            ElseIf (OrderOfSort = System.Windows.Forms.SortOrder.Descending) Then
                '// 如果是反序排序，所以要取负值再返回
                Return (-compareResult)
            Else
                '// 如果相等返回0
                Return 0
            End If
        End Function

        '/// <summary>
        '/// 获取或设置按照哪一列排序.
        '/// </summary>
        Public Property SortColumn() As Integer
            Get
                Return ColumnToSort
            End Get

            Set(ByVal Value As Integer)
                ColumnToSort = Value
            End Set
        End Property

        '/// <summary>
        '/// 获取或设置排序方式.
        '/// </summary>
        Public Property Order() As System.Windows.Forms.SortOrder
            Get
                Return OrderOfSort
            End Get

            Set(ByVal Value As System.Windows.Forms.SortOrder)
                OrderOfSort = Value
            End Set
        End Property
    End Class

    '//调用方法，在窗体启动函数内加上以下两句
    '// Me.ListView1.ListViewItemSorter = New ListViewColumnSorter
    '// AddHandler Me.ListView1.ColumnClick, New ColumnClickEventHandler(AddressOf ListViewHelper.ListView_ColumnClick)
    '//




    Public Class KzMsg
        Public Property Massage As String
        Public Property Title As String
        Public Property Type As MsgBoxStyle

        Dim m As String = "消息文字"
        Dim t As String = "提示"
        Dim b As MsgBoxStyle = MsgBoxStyle.OkOnly

        Public Shared Function Blank() As MsgBoxResult
            Return MsgBox("", MsgBoxStyle.OkOnly, "空")
        End Function
        Public Shared Function Break(message As String) As MsgBoxResult
            Return MsgBox(message, MsgBoxStyle.OkOnly, "中斷")
        End Function
        Public Shared Function ContentsIsEmptyTip() As MsgBoxResult
            Return MsgBox("原內容為空！" & vbCrLf &
                          "不執行任何操作。",
                          MsgBoxStyle.OkOnly, "提示")
        End Function
        Public Shared Function ContentsIsEmptySelect() As MsgBoxResult
            Return MsgBox("原內容為空！是否繼續？。" & vbCrLf &
                          "【是】繼續當前操作。" & vbCrLf &
                          "【否】終止當前操作。"，
                          MsgBoxStyle.OkOnly, "提示")
        End Function
        Public Shared Function ContentsIsNotEmpty() As MsgBoxResult
            Return MsgBox("原內容非空！導致當前文檔內容丟失。是否繼續？" & vbCrLf &
                          "【是】繼續讀入新文檔并丟棄當前內容。" & vbCrLf &
                          "【否】保留當前內容，不執行任何操作。",
                          MsgBoxStyle.YesNo, "確認")
        End Function
        Public Shared Function FileNotExistsForWrite() As MsgBoxResult
            Return MsgBox("文檔不存在！是否創建新文檔？" & vbCrLf &
                          "【是】將創建新文檔并保存內容。" & vbCrLf &
                          "【否】取消保存，不執行任何操作。",
                          MsgBoxStyle.YesNo, "確認")
        End Function
        Public Shared Function FileExistsForWrite() As MsgBoxResult
            Return MsgBox("文檔已存在！是否覆蓋原文檔？" & vbCrLf &
                          "【是】將以當前內容替換已存在文檔。" & vbCrLf &
                          "【否】自動添加文檔名序號保存。" & vbCrLf &
                          "【取消】取消保存，不執行任何操作。",
                          MsgBoxStyle.YesNoCancel, "確認")
        End Function
        Public Shared Function FileErrorForWrite() As MsgBoxResult
            Return MsgBox("文檔離線或讀寫錯誤！是否另存？" & vbCrLf &
                          "【是】將創建新文檔并保存內容。" & vbCrLf &
                          "【否】取消保存，不執行任何操作。",
                          MsgBoxStyle.YesNo, "確認")
        End Function

    End Class 'KzMsg


    Public Class TextFileEncodingDetector
        '/*
        '* Simple class to handle text file encoding woes (in a primarily English-speaking tech
        '* world).
        '*
        '* - This code Is fully managed, no shady calls to MLang (the unmanaged codepage
        '* detection library originally developed for Internet Explorer).
        '*
        '* - This class does Not try to detect arbitrary codepages/charsets, it really only
        '* aims to differentiate between some of the most common variants of Unicode
        '* encoding, And a "default" (western / ascii-based) encoding alternative provided
        '* by the caller.
        '*
        '* - As there Is no "Reliable" way to distinguish between UTF-8 (without BOM) And
        '* Windows-1252 (in .Net, also incorrectly called "ASCII") encodings, we use a
        '* heuristic - so the more of the file we can sample the better the guess. If you
        '* are going to read the whole file into memory at some point, then best to pass
        '* in the whole byte byte array directly. Otherwise, decide how to trade off
        '* reliability against performance / memory usage.
        '*
        '* - The UTF-8 detection heuristic only works for western text, as it relies on
        '* the presence of UTF-8 encoded accented And other characters found in the upper
        '* ranges of the Latin-1 And (particularly) Windows-1252 codepages.
        '*
        '* - For more general detection routines, see existing projects / resources:
        '* - MLang - Microsoft library originally for IE6, available in Windows XP And later APIs now (I think?)
        '* - MLang .Net bindings: http://www.codeproject.com/KB/recipes/DetectEncoding.aspx
        '* - CharDet - Mozilla browser's detection routines
        '* - Ported to Java then .Net: http://www.conceptdevelopment.net/Localization/NCharDet/
        '* - Ported straight to .Net: http://code.google.com/p/chardetsharp/source/browse
        '*
        '* Copyright Tao Klerks, Jan 2010, tao@klerks.biz
        '* Licensed under the modified BSD license:
        '*

        'Redistribution And use in source And binary forms, with Or without modification, are
        'permitted provided that the following conditions are met:

        '- Redistributions of source code must retain the above copyright notice, this list of
        'conditions And the following disclaimer.
        '- Redistributions in binary form must reproduce the above copyright notice, this list
        'of conditions And the following disclaimer in the documentation And/Or other materials
        'provided with the distribution.
        '- The name of the author may Not be used to endorse Or promote products derived from
        'this software without specific prior written permission.

        'THIS SOFTWARE Is PROVIDED BY THE AUTHOR ``As Is'' AND ANY EXPRESS OR IMPLIED WARRANTIES,
        'INCLUDING, BUT Not LIMITED TO, THE IMPLIED WARRANTIES OF MERCHANTABILITY And FITNESS FOR
        'A PARTICULAR PURPOSE ARE DISCLAIMED. In NO Event SHALL THE AUTHOR BE LIABLE For ANY
        'DIRECT, INDIRECT, INCIDENTAL, SPECIAL, EXEMPLARY, Or CONSEQUENTIAL DAMAGES (INCLUDING,
        'BUT Not LIMITED TO, PROCUREMENT OF SUBSTITUTE GOODS Or SERVICES; LOSS OF USE, DATA, Or
        'PROFITS; Or BUSINESS INTERRUPTION) HOWEVER CAUSED And ON ANY THEORY OF LIABILITY,
        'WHETHER IN CONTRACT, STRICT LIABILITY, Or TORT (INCLUDING NEGLIGENCE Or OTHERWISE)
        'ARISING IN ANY WAY OUT OF THE USE OF THIS SOFTWARE, EVEN IF ADVISED OF THE POSSIBILITY
        'OF SUCH DAMAGE.
        '*
        '*/

        Const _defaultHeuristicSampleSize As Long = &H10000
        '//completely arbitrary - inappropriate for high numbers of files / high speed requirements

        Public Shared Function DetectTextFileEncoding _
            (InputFilename As String, DefaultEncoding As Encoding) As Encoding

            Using textfileStream As FileStream = File.OpenRead(InputFilename)
                Return DetectTextFileEncoding _
                    (textfileStream, DefaultEncoding, _defaultHeuristicSampleSize)
            End Using
        End Function

        Public Shared Function DetectTextFileEncoding _
            (InputFileStream As FileStream, DefaultEncoding As Encoding,
             HeuristicSampleSize As Long) As Encoding

            If InputFileStream Is Nothing Then
                Throw New ArgumentNullException _
                    ("Must provide a valid Filestream!", "InputFileStream")
            End If

            If Not InputFileStream.CanRead Then
                Throw New ArgumentException _
                    ("Provided file stream is not readable!", "InputFileStream")
            End If

            If Not InputFileStream.CanSeek Then
                Throw New ArgumentException _
                    ("Provided file stream cannot seek!", "InputFileStream")
            End If

            Dim encodingFound As Encoding = Nothing
            Dim originalPos As Long = InputFileStream.Position
            InputFileStream.Position = 0

            '//First read only what we need for BOM detection
            Dim bomBytes(Math.Min(4, InputFileStream.Length)) As Byte
            InputFileStream.Read(bomBytes, 0, bomBytes.Length)

            If encodingFound IsNot Nothing Then
                InputFileStream.Position = originalPos
                Return encodingFound
            End If

            '//BOM Detection failed, going for heuristics now.
            '// create sample byte array And populate it
            Dim sampleBytes(Math.Min(InputFileStream.Length, HeuristicSampleSize)) As Byte
            Array.Copy(bomBytes, sampleBytes, bomBytes.Length)

            If InputFileStream.Length > bomBytes.Length Then _
                InputFileStream.Read(sampleBytes, bomBytes.Length, sampleBytes.Length - bomBytes.Length)

            InputFileStream.Position = originalPos

            '//test byte array content
            encodingFound = DetectUnicodeInByteSampleByHeuristics(sampleBytes)

            If encodingFound IsNot Nothing Then
                Return encodingFound
            Else
                Return DefaultEncoding
            End If
        End Function

        Public Shared Function DetectUnicodeInByteSampleByHeuristics _
            (TextData As Byte(), DefaultEncoding As Encoding) As Encoding

            If TextData Is Nothing Then
                Throw New ArgumentNullException _
                    ("Must provide a valid text data byte array!", "TextData")
            End If

            Dim encodingFound As Encoding = Nothing
            encodingFound = DetectBOMBytes(TextData)

            If encodingFound IsNot Nothing Then
                Return encodingFound
            Else
                '//test byte array content
                encodingFound = DetectUnicodeInByteSampleByHeuristics(TextData)

                If encodingFound IsNot Nothing Then
                    Return encodingFound
                Else
                    Return DefaultEncoding
                End If
            End If
        End Function

        Public Shared Function DetectBOMBytes(BOMBytes As Byte()) As Encoding
            If BOMBytes Is Nothing Then _
                Throw New ArgumentNullException _
                ("Must provide a valid BOM byte array!", "BOMBytes")

            If BOMBytes.Length < 2 Then Return Nothing

            If BOMBytes(0) = &HFF And BOMBytes(1) = &HFE And
                (BOMBytes.Length < 4 Or BOMBytes(2) <> 0 Or BOMBytes(3) <> 0) Then _
                Return Encoding.Unicode

            If BOMBytes(0) = &HFE And BOMBytes(1) = &HFF Then _
                Return Encoding.BigEndianUnicode

            If BOMBytes.Length < 3 Then Return Nothing

            If BOMBytes(0) = &HEF And BOMBytes(1) = &HBB And BOMBytes(2) = &HBF Then _
                Return Encoding.UTF8

            If BOMBytes(0) = &H2B And BOMBytes(1) = &H2F And BOMBytes(2) = &H76 Then _
                Return Encoding.UTF7

            If BOMBytes.Length < 4 Then Return Nothing

            If BOMBytes(0) = &HFF And BOMBytes(1) = &HFE And
                BOMBytes(2) = 0 And BOMBytes(3) = 0 Then _
                Return Encoding.UTF32

            If BOMBytes(0) = 0 And BOMBytes(1) = 0 And
                BOMBytes(2) = &HFE And BOMBytes(3) = &HFF Then _
                Return Encoding.GetEncoding(12001)

            Return Nothing
        End Function

        Public Shared Function DetectUnicodeInByteSampleByHeuristics _
            (SampleBytes As Byte()) As Encoding

            Dim oddBinaryNullsInSample As Long = 0
            Dim evenBinaryNullsInSample As Long = 0
            Dim suspiciousUTF8SequenceCount As Long = 0
            Dim suspiciousUTF8BytesTotal As Long = 0
            Dim likelyUSASCIIBytesInSample As Long = 0

            '//Cycle through, keeping count of binary null positions, possible UTF-8
            '// sequences from upper ranges of Windows-1252, And probable US-ASCII
            '// character counts.

            Dim currentPos As Long = 0
            Dim skipUTF8Bytes As Integer = 0

            Do While currentPos < SampleBytes.Length
                '//binary null distribution
                If SampleBytes(currentPos) = 0 Then
                    If currentPos Mod 2 = 0 Then _
                        evenBinaryNullsInSample += 1 Else _
                        oddBinaryNullsInSample += 1
                End If

                '//likely US-ASCII characters
                If IsCommonUSASCIIByte(SampleBytes(currentPos)) Then _
                    likelyUSASCIIBytesInSample += 1

                '//suspicious sequences (look like UTF-8)
                If skipUTF8Bytes = 0 Then
                    Dim lengthFound As Integer =
                        DetectSuspiciousUTF8SequenceLength(SampleBytes, currentPos)

                    If lengthFound > 0 Then
                        suspiciousUTF8SequenceCount += 1
                        suspiciousUTF8BytesTotal += lengthFound
                        skipUTF8Bytes = lengthFound - 1
                    End If
                Else
                    skipUTF8Bytes -= 1
                End If

                currentPos += 1
            Loop

            '//1 UTF-16 LE - In english / european environments, this Is usually characterized by a
            '// high proportion of odd binary nulls (starting at 0), with (as this Is text) a low
            '// proportion of even binary nulls.
            '// The thresholds here used (less than 20% nulls where you expect non-nulls, And more than
            '// 60% nulls where you do expect nulls) are completely arbitrary.

            If ((evenBinaryNullsInSample * 2.0) / SampleBytes.Length) < 0.2 And
                ((oddBinaryNullsInSample * 2.0) / SampleBytes.Length) > 0.6 Then _
                Return Encoding.Unicode

            '//2 UTF-16 BE - In english / european environments, this Is usually characterized by a
            '// high proportion of even binary nulls (starting at 0), with (as this Is text) a low
            '// proportion of odd binary nulls.
            '// The thresholds here used (less than 20% nulls where you expect non-nulls, And more than
            '// 60% nulls where you do expect nulls) are completely arbitrary.

            If ((oddBinaryNullsInSample * 2.0) / SampleBytes.Length) < 0.2 And
                ((evenBinaryNullsInSample * 2.0) / SampleBytes.Length) > 0.6 Then _
                Return Encoding.BigEndianUnicode

            '//3 UTF-8 - Martin Dürst outlines a method for detecting whether something CAN be UTF-8 content
            '// using regexp, in his w3c.org unicode FAQ entry:
            '// http//www.w3.org/International/questions/qa-forms-utf-8
            '// adapted here for C#.
            Dim potentiallyMangledString As String = Encoding.ASCII.GetString(SampleBytes)
            Dim UTF8Validator As New System.Text.RegularExpressions.Regex _
                ("\A(" +
                "[\x09\x0A\x0D\x20-\x7E]" +
                "|[\xC2-\xDF][\x80-\xBF]" +
                "|\xE0[\xA0-\xBF][\x80-\xBF]" +
                "|[\xE1-\xEC\xEE\xEF][\x80-\xBF]{2}" +
                "|\xED[\x80-\x9F][\x80-\xBF]" +
                "|\xF0[\x90-\xBF][\x80-\xBF]{2}" +
                "|[\xF1-\xF3][\x80-\xBF]{3}" +
                "|\xF4[\x80-\x8F][\x80-\xBF]{2}" +
                ")*\z")
            'Dim RegexStr As String = "\A([\x09\x0A\x0D\x20-\x7E]|[\xC2-\xDF][\x80-\xBF]|\xE0[\xA0-\xBF][\x80-\xBF]|[\xE1-\xEC\xEE\xEF][\x80-\xBF]{2}|\xED[\x80-\x9F][\x80-\xBF]|\xF0[\x90-\xBF][\x80-\xBF]{2}|[\xF1-\xF3][\x80-\xBF]{3}|\xF4[\x80-\x8F][\x80-\xBF]{2})*\z"

            If UTF8Validator.IsMatch(potentiallyMangledString) Then
                '//Unfortunately, just the fact that it CAN be UTF-8 doesn't tell you much about probabilities.
                '//If all the characters are in the 0-127 range, no harm done, most western charsets are same as UTF-8 in these ranges.
                '//If some of the characters were in the upper range (western accented characters), however, they would likely be mangled to 2-byte by the UTF-8 encoding process.
                '// So, we need to play stats.

                '// The "Random" likelihood of any pair of randomly generated characters being one
                '// of these "suspicious" character sequences Is:
                '// 128 / (256 * 256) = 0.2%.
                '//
                '// In western text data, that Is SIGNIFICANTLY reduced - most text data stays in the <127
                '// character range, so we assume that more than 1 in 500,000 of these character
                '// sequences indicates UTF-8. The number 500,000 Is completely arbitrary - so sue me.
                '//
                '// We can only assume these character sequences will be rare if we ALSO assume that this
                '// Is in fact western text - in which case the bulk of the UTF-8 encoded data (that Is
                '// Not already suspicious sequences) should be plain US-ASCII bytes. This, I
                '// arbitrarily decided, should be 80% (a random distribution, eg binary data, would yield
                '// approx 40%, so the chances of hitting this threshold by accident in random data are
                '// VERY low).

                '//suspicious sequences AND
                '//all suspicious, so cannot evaluate proportion of US-Ascii
                If (suspiciousUTF8SequenceCount * 500000.0 / SampleBytes.Length >= 1) And
                        (SampleBytes.Length - suspiciousUTF8BytesTotal = 0 Or
                        likelyUSASCIIBytesInSample * 1.0 / (SampleBytes.Length - suspiciousUTF8BytesTotal) >= 0.8) Then _
                    Return Encoding.UTF8

            End If

            Return Nothing
        End Function

        Public Shared Function IsCommonUSASCIIByte(testByte As Byte) As Boolean
            If testByte = &HA Or '// lf
               testByte = &HD Or  '//cr
               testByte = &H9 Or  '//tab
               (testByte >= &H20 And testByte <= &H2F) Or  '//common punctuation
               (testByte >= &H30 And testByte <= &H39) Or  '//digits
               (testByte >= &H3A And testByte <= &H40) Or  '//common punctuation
               (testByte >= &H41 And testByte <= &H5A) Or  '//capital letters
               (testByte >= &H5B And testByte <= &H60) Or  '//common punctuation
               (testByte >= &H61 And testByte <= &H7A) Or  '//lowercase letters
               (testByte >= &H7B And testByte <= &H7E) Then  '//common punctuation

                Return True
            Else
                Return False
            End If
        End Function

        Public Shared Function DetectSuspiciousUTF8SequenceLength _
            (SampleBytes As Byte(), currentPos As Long) As Integer

            Dim lengthFound As Integer = 0

            If SampleBytes.Length >= currentPos + 1 And
                SampleBytes(currentPos) = &HC2 Then

                If SampleBytes(currentPos + 1) = &H81 Or
                    SampleBytes(currentPos + 1) = &H8D Or
                    SampleBytes(currentPos + 1) = &H8F Then

                    lengthFound = 2

                ElseIf SampleBytes(currentPos + 1) = &H90 Or
                    SampleBytes(currentPos + 1) = &H9D Then

                    lengthFound = 2

                ElseIf SampleBytes(currentPos + 1) >= &HA0 And
                    SampleBytes(currentPos + 1) <= &HBF Then

                    lengthFound = 2
                End If

            ElseIf SampleBytes.Length >= currentPos + 1 And
                SampleBytes(currentPos) = &HC3 Then

                If SampleBytes(currentPos + 1) >= &H80 And
                    SampleBytes(currentPos + 1) <= &HBF Then

                    lengthFound = 2
                End If

            ElseIf SampleBytes.Length >= currentPos + 1 And
                SampleBytes(currentPos) = &HC5 Then

                If SampleBytes(currentPos + 1) = &H92 Or
                    SampleBytes(currentPos + 1) = &H93 Then

                    lengthFound = 2

                ElseIf SampleBytes(currentPos + 1) = &HA0 Or
                    SampleBytes(currentPos + 1) = &HA1 Then

                    lengthFound = 2

                ElseIf SampleBytes(currentPos + 1) = &HB8 Or
                    SampleBytes(currentPos + 1) = &HBD Or
                    SampleBytes(currentPos + 1) = &HBE Then

                    lengthFound = 2
                End If

            ElseIf SampleBytes.Length >= currentPos + 1 And
                SampleBytes(currentPos) = &HC6 Then

                If SampleBytes(currentPos + 1) = &H92 Then
                    lengthFound = 2
                End If

            ElseIf SampleBytes.Length >= currentPos + 1 And
                SampleBytes(currentPos) = &HCB Then

                If SampleBytes(currentPos + 1) = &H86 Or
                    SampleBytes(currentPos + 1) = &H9C Then

                    lengthFound = 2
                End If

            ElseIf SampleBytes.Length >= currentPos + 2 And
                SampleBytes(currentPos) = &HE2 Then

                If SampleBytes(currentPos + 1) = &H80 Then
                    If SampleBytes(currentPos + 2) = &H93 Or
                        SampleBytes(currentPos + 2) = &H94 Then

                        lengthFound = 3
                    End If

                    If SampleBytes(currentPos + 2) = &H98 Or
                        SampleBytes(currentPos + 2) = &H99 Or
                        SampleBytes(currentPos + 2) = &H9A Then

                        lengthFound = 3
                    End If

                    If SampleBytes(currentPos + 2) = &H9C Or
                        SampleBytes(currentPos + 2) = &H9D Or
                        SampleBytes(currentPos + 2) = &H9E Then

                        lengthFound = 3
                    End If

                    If SampleBytes(currentPos + 2) = &HA0 Or
                        SampleBytes(currentPos + 2) = &HA1 Or
                        SampleBytes(currentPos + 2) = &HA2 Then

                        lengthFound = 3
                    End If

                    If SampleBytes(currentPos + 2) = &HA6 Then
                        lengthFound = 3
                    End If

                    If SampleBytes(currentPos + 2) = &HB0 Then
                        lengthFound = 3
                    End If

                    If SampleBytes(currentPos + 2) = &HB9 Or
                        SampleBytes(currentPos + 2) = &HBA Then

                        lengthFound = 3
                    End If

                End If

            ElseIf SampleBytes(currentPos + 1) = &H82 And
                SampleBytes(currentPos + 2) = &HAC Then

                lengthFound = 3

            ElseIf SampleBytes(currentPos + 1) = &H84 And
                SampleBytes(currentPos + 2) = &HA2 Then

                lengthFound = 3
            End If

            Return lengthFound
        End Function

        '//使用方法
        '//Encoding fileEncoding = TextFileEncodingDetector.DetectTextFileEncoding("you file path",Encoding.Default);
        '//Dim fileEncoding As Encoding = TextFileEncodingDetector.DetectTextFileEncoding("you file path", Encoding.Default)
    End Class 'TextFileEncodingDetector
End Namespace