Imports System.Text
Imports System.Text.RegularExpressions
Imports System.IO
Imports Microsoft.VisualBasic.FileIO

Namespace KzLibrary

    Public Class KzTimeShift
        Dim iStart, iEnd As DateTime

        Public Sub New(Optional ByVal StartTime As DateTime = #1/1/1 0:00:00#)
            SetDefault(StartTime)
        End Sub

        Private Sub SetDefault(Optional ByVal StartTime As DateTime = #1/1/1 0:00:00#)
            Try
                If StartTime <= #0:00:00# Then
                    iStart = Now()
                Else
                    iStart = StartTime
                End If
            Catch ex As Exception
                iStart = Now()
            End Try

            iEnd = iStart
        End Sub

        Public Property StartTime As DateTime
            Get
                Return iStart
            End Get
            Set(value As DateTime)
                SetDefault(value)
            End Set
        End Property

        Public Property EndTime As DateTime
            Get
                Return iEnd
            End Get
            Set(value As DateTime)
                If iEnd < iStart Then
                    iEnd = iStart
                Else
                    iEnd = value
                End If
            End Set
        End Property

        Public ReadOnly Property Span As TimeSpan
            Get
                Return iEnd.Subtract(iStart)
            End Get
        End Property

        Public ReadOnly Property SpanText As String
            Get
                Dim Unit As String()
                If InChinese Then
                    Unit = {"日"， "時", "分", "秒", "微秒"}
                Else
                    Unit = {"D"， "h", "m", "s", "ms"}
                End If

                Dim sb As New StringBuilder

                With Me.Span
                    If .Days > 0 Then
                        sb.Append(" " & .Days.ToString & " " & Unit(0))
                    End If

                    If .Hours > 0 Then
                        sb.Append(" " & .Hours.ToString & " " & Unit(1))
                    End If

                    If .Minutes > 0 Then
                        sb.Append(" " & .Minutes.ToString & " " & Unit(2))
                    End If

                    If .Seconds > 0 Then
                        sb.Append(" " & .Seconds.ToString & " " & Unit(3))
                    End If

                    sb.Append(" " & .Milliseconds.ToString & " " & Unit(4))
                End With

                If WithoutSpace Then
                    sb.Replace(" ", "")
                End If

                Return sb.ToString
            End Get
        End Property

        Public Property InChinese As Boolean = False
        Public Property WithoutSpace As Boolean = False
    End Class 'KzTimeShift


    Public Class KzEncoding
        '/// <summary>
        '/// 给定文件的路径，读取文件的二进制数据，判断文件的编码类型
        '/// </summary>
        '/// <param name="FILE_NAME">文件路径</param>
        '/// <returns>文件的编码类型</returns>
        Public Shared Function GetEncoding(TheFileName As String) As Encoding
            Dim fs As New FileStream(TheFileName, FileMode.Open, FileAccess.Read)
            Dim r As Encoding = GetEncoding(fs)
            fs.Close()
            Return r
        End Function

        '/// <summary>
        '/// 通过给定的文件流，判断文件的编码类型
        '/// </summary>
        '/// <param name="fs">文件流</param>
        '/// <returns>文件的编码类型</returns>
        Public Shared Function GetEncoding(TheFileStream As FileStream)
            Dim Unicode As Byte() = New Byte() {&HFF, &HFE, &H41}
            Dim UnicodeBig As Byte() = New Byte() {&HFE, &HFF, &H0}
            Dim UTF8 As Byte() = New Byte() {&HEF, &HBB, &HBF} '//带BOM
            Dim reVal As Encoding = Encoding.Default

            Dim r As BinaryReader = New BinaryReader(TheFileStream, Encoding.Default)
            Dim i As Integer
            Integer.TryParse(TheFileStream.Length.ToString, i)
            Dim ss As Byte() = r.ReadBytes(i)

            If IsUTF8Bytes(ss) Or (ss(0) = &HEF And ss(1) = &HBB And ss(2) = &HBF) Then
                reVal = Encoding.UTF8
            ElseIf ss(0) = &HFE And ss(1) = &HFF And ss(2) = &H0 Then
                reVal = Encoding.BigEndianUnicode
            ElseIf ss(0) = &HFF And ss(1) = &HFE And ss(2) = &H41 Then
                reVal = Encoding.Unicode
            End If
            r.Close()
            Return reVal
        End Function

        '/// <summary>
        '/// 判断是否是不带 BOM 的 UTF8 格式
        '/// </summary>
        '/// <param name="data"></param>
        '/// <returns></returns>
        Private Shared Function IsUTF8Bytes(data As Byte()) As Boolean
            Dim charByteCounter As Integer = 1 '//计算当前正分析的字符应还有的字节数
            Dim curByte As Byte '//当前分析的字节

            For i As Integer = 0 To data.Length - 1
                curByte = data(i)

                If charByteCounter = 1 Then
                    If curByte >= &H80 Then
                        '//判断当前
                        Do While ((curByte = curByte << 1) And &H80) <> 0
                            charByteCounter += 1
                        Loop
                        '//标记位首位若为非0 则至少以2个1开始 如:110XXXXX...........1111110X
                        If charByteCounter = 1 Or charByteCounter > 6 Then
                            Return False
                        End If
                    End If
                Else
                    '//若是UTF-8 此时第一位必须为1
                    If (curByte And &HC0) <> &H80 Then
                        Return False
                    End If
                    charByteCounter -= 1
                End If
            Next

            If charByteCounter > 1 Then
                Throw New Exception("非预期的byte格式")
            End If

            Return True
        End Function
    End Class 'KzEncoding


    Public Class KzStr
        Public Shared Function LinkStrings _
            (ByVal StringArray As String(),
             Optional ByVal ByLines As Boolean = False,
             Optional ByVal LinkChar As Char = Nothing) As String

            Dim sb As New StringBuilder

            For i As Integer = 0 To StringArray.Length - 1
                If ByLines Then
                    sb.AppendLine(StringArray(i))
                Else
                    sb.Append(StringArray(i) & LinkChar)
                End If
            Next

            Return sb.ToString
        End Function

        Public Shared Function DeleteWords _
            (ByVal textStr As String, ByVal word As String) As String

            Return textStr.Replace(word, "")
        End Function

        Public Shared Function DeleteWords _
            (ByVal textStr As String, ByVal words As String()) As String

            Dim r As String = textStr
            For Each s As String In words
                r = r.Replace(s, "")
            Next

            Return r
        End Function

        Public Shared Function WordsCount _
            (ByVal textStr As String, ByVal word As String) As Integer

            Dim rex As New Regex(word)
            Return rex.Matches(textStr).Count
        End Function

        Public Shared Function WordsCount _
            (ByVal textStr As String, ByVal words As String()) As Integer

            Dim rex As Regex
            Dim r As Integer = 0
            For Each word As String In words
                rex = New Regex(word)
                r += rex.Matches(textStr).Count
            Next

            Return r
        End Function

        Public Shared Function Cutting _
            (mode As KzStringCuttingMode, textStr As String,
             start As Integer, Optional length As Integer = 0) As String

            Return textStr
        End Function

        Public Shared Function DeleteChars _
            (ByVal OriginString As String, ByVal CharsString As String) As String
            '從OriginString中刪除CharsString所包含的每一個字符
            Dim ans As String = OriginString
            For i As Integer = 0 To CharsString.Length - 1
                ans = ans.Replace(CharsString.Chars(i), "")
            Next
            Return ans
        End Function

        Public Shared Function ReplaceChars _
            (ByVal OriginString As String, ByVal CharsString As String,
             ByVal Replacement As Char) As String
            '替換OriginString中每一個出現在CharsString的字符為Replacement
            'Err：Replacement為空字符時出錯，待解決。
            Dim ans As String = OriginString
            For i As Integer = 0 To CharsString.Length - 1
                ans = ans.Replace(CharsString.Chars(i), Replacement)
            Next
            Return ans
        End Function

        Public Shared Function ContainsChars _
            (ByVal OriginString As String, ByVal CharsString As String) As Boolean
            '判斷OriginString中是否包含CharsString中的字符，只要包含其中一個則返回True
            Dim ans As Boolean = False
            For i As Integer = 0 To CharsString.Length - 1
                If OriginString.Contains(CharsString.Chars(i)) Then
                    ans = True
                    Exit For
                End If
            Next
            Return ans
        End Function

        Public Shared Function MultiReplace _
            (ByVal OriginString As String, ByVal FindArray() As String,
             ByVal Optional ReplaceArray() As String = Nothing,
             ByVal Optional IsDelMode As Boolean = False) As String

            If OriginString = "" Or OriginString Is Nothing Then
                Return Nothing
            ElseIf FindArray Is Nothing Or FindArray.Length = 0 Then
                Return OriginString
            Else
                Dim ans As String = OriginString
                Dim i As Integer
                If ReplaceArray Is Nothing Or ReplaceArray.Length = 0 Then
                    If IsDelMode Then
                        For i = 0 To FindArray.Length - 1
                            ans = ans.Replace(FindArray(i), "")
                        Next
                    End If

                Else
                    If ReplaceArray.Length < FindArray.Length Then
                        For i = 0 To ReplaceArray.Length - 1
                            ans = ans.Replace(FindArray(i), ReplaceArray(i))
                        Next
                        If IsDelMode Then
                            For i = ReplaceArray.Length To FindArray.Length - 1
                                ans = ans.Replace(FindArray(i), "")
                            Next
                        End If
                    Else
                        For i = 0 To FindArray.Length - 1
                            ans = ans.Replace(FindArray(i), ReplaceArray(i))
                        Next
                    End If
                End If

                Return ans
            End If
        End Function

        Public Shared Function SingleReplace _
            (ByVal OriginString As String, ByVal FindArray() As String,
             ByVal Optional ReplaceString As String = Nothing) As String

            If OriginString = "" Or OriginString Is Nothing Then
                Return Nothing
            ElseIf FindArray Is Nothing Or FindArray.Length = 0 Then
                Return OriginString
            Else
                Dim ans As String = OriginString
                For i As Integer = 0 To FindArray.Length - 1
                    ans = ans.Replace(FindArray(i), ReplaceString)
                Next
                Return ans
            End If

        End Function

#Region "GetStrings"
        Public Shared Function GetTimeSerial _
            (Optional ByVal datetime As DateTime = Nothing,
             Optional ByVal index As Integer = 0) As String

            If datetime = Nothing Then
                datetime = Now()
            End If

            Select Case index
                Case 1
                    Return Strings.Format(datetime, "yyyyMMddHHmmss-fff")
                Case 2
                    Return Strings.Format(datetime, "yyyy-MM-dd-HH-mm-ss-fff")
                Case Else
                    Return Strings.Format(datetime, "yyyyMMddHHmmssfff")
            End Select

        End Function

        Public Shared Function GetFileLength _
            (ByVal LengthInByte As Long,
             Optional ByVal StandardView As Boolean = True,
             Optional ByVal UnitShowB As Boolean = False,
             Optional ByVal OriginReturn As Boolean = False) As String

            Dim ans As String
            Dim fmt As String = "#,0.##"

            If OriginReturn Then
                ans = Strings.Format(LengthInByte.ToString, fmt) & "B"
            Else
                Select Case LengthInByte
                    Case Is < 0
                        ans = "-"
                    Case Is <= 1024
                        ans = Strings.Format(LengthInByte, fmt) & "B"
                    Case Is <= 1024 * 1024
                        ans = Strings.Format(LengthInByte / 1024, fmt) & "K"
                    Case Is <= 1024 * 1024 * 1024
                        ans = Strings.Format(LengthInByte / 1024 / 1024, fmt) & "M"
                    Case Is > 1024 * 1024 * 1024
                        ans = Strings.Format(LengthInByte / 1024 / 1024 / 1024, fmt) & "G"
                    Case Else
                        ans = "-"
                End Select
            End If

            If UnitShowB And ans <> "-" Then
                ans = (ans & "B").Replace("BB", "B")
            End If

            If Not StandardView Then
                ans = ans.Replace(",", "")
            End If

            Return ans.Replace(".00", "").Replace("0B", "B").Replace("0K", "K").Replace("0M", "M").Replace("0G", "G")
        End Function
#End Region 'GetStrings
    End Class 'KzStr

    Public Class KzDirectory
#Region "SharedFunctions"

        Public Shared Function GetSize(ByVal Directory As DirectoryInfo) As Long
            '==============================
            ' The following example calculates the size of a directory
            ' and its subdirectories, if any, and displays the total size
            ' in bytes.
            '==============================

            Dim Size As Long = 0
            ' Add file sizes.
            Dim fis As FileInfo() = Directory.GetFiles()
            Dim fi As FileInfo
            For Each fi In fis
                Size += fi.Length
            Next fi
            ' Add subdirectory sizes.
            Dim dis As DirectoryInfo() = Directory.GetDirectories()
            Dim di As DirectoryInfo
            For Each di In dis
                Size += GetSize(di)
            Next di
            Return Size
        End Function 'GetSize by DirectoryInfo

        Public Shared Function GetSize(ByVal DirectoryPath As String) As Long
            If Directory.Exists(DirectoryPath) Then
                Dim odi As New DirectoryInfo(DirectoryPath)
                Return GetSize(odi)
            Else
                Return 0
            End If
        End Function 'GetSize by Path string

        Public Shared Function GetFileTypes(ByVal Directory As DirectoryInfo,
                                            Optional ByVal GetHidden As Boolean = False,
                                            Optional ByVal GetSystem As Boolean = False) As String()

            Dim fis As FileInfo() = Directory.GetFiles
            Dim fl As New List(Of String)

            If fis.Length > 0 Then
                Dim fi As FileInfo
                For Each fi In fis
                    If Not fl.Contains(fi.Extension.ToLower) Then
                        If GetHidden And GetSystem Then
                            fl.Add(fi.Extension.ToLower)
                        ElseIf Not GetHidden And GetSystem Then
                            If (fi.Attributes And FileAttributes.Hidden) <> FileAttributes.Hidden Then
                                fl.Add(fi.Extension.ToLower)
                            End If
                        ElseIf GetHidden And Not GetSystem Then
                            If (fi.Attributes And FileAttributes.System) <> FileAttributes.System Then
                                fl.Add(fi.Extension.ToLower)
                            End If
                        ElseIf Not GetHidden And Not GetSystem Then
                            If ((fi.Attributes And FileAttributes.Hidden) <> FileAttributes.Hidden) And
                            ((fi.Attributes And FileAttributes.System) <> FileAttributes.System) Then
                                fl.Add(fi.Extension.ToLower)
                            End If
                        End If
                    End If

                Next
            End If

            fl.Sort()
            Return fl.ToArray
        End Function

        Public Shared Function GetFileTypes(ByVal DirectoryPath As String,
                                            Optional ByVal GetHidden As Boolean = False,
                                            Optional ByVal GetSystem As Boolean = False) As String()
            '==============================
            ' 返回指定資料夾中的文件擴展名字符串數組。
            ' 如路徑不存在或資料夾中無文檔則返回空數組。
            '==============================

            If Directory.Exists(DirectoryPath) Then
                Dim di As New DirectoryInfo(DirectoryPath)
                Return GetFileTypes(di, GetHidden, GetSystem)
            Else
                Return {}
            End If
        End Function 'GetFileTypes
#End Region 'SharedFunctions
    End Class 'KzDirectory

    Public Class KzFile

        Public Shared Function GetOpenFiles() As String()
            Dim ofd As New OpenFileDialog
            With ofd
                If Directory.Exists(My.Settings.EditorInitialDirectory) Then
                    .InitialDirectory = My.Settings.EditorInitialDirectory
                Else
                    .InitialDirectory = SpecialDirectories.MyDocuments
                End If
                .AddExtension = True
                .CheckFileExists = True
                .CheckPathExists = True
                .DefaultExt = ".txt"
                .ShowReadOnly = True
                .Multiselect = True
                .Filter = My.Settings.EditorFileFilter

                If .ShowDialog = DialogResult.OK Then
                    My.Settings.EditorInitialDirectory = Path.GetDirectoryName(ofd.FileNames(0))
                    Return .FileNames
                Else
                    Return {} ' Nothing
                End If
            End With
        End Function

        Public Shared Function GetSaveFile() As String
            Dim sfd As New SaveFileDialog
            With sfd
                If Directory.Exists(My.Settings.EditorInitialDirectory) Then
                    .InitialDirectory = My.Settings.EditorInitialDirectory
                Else
                    .InitialDirectory = SpecialDirectories.MyDocuments
                End If
                .AddExtension = True
                '.CheckFileExists = True
                '.CheckPathExists = True
                .DefaultExt = ".txt"
                .Filter = My.Settings.EditorFileFilter

                If .ShowDialog = DialogResult.OK Then
                    My.Settings.EditorInitialDirectory = Path.GetDirectoryName(.FileName)
                    Return .FileName
                Else
                    Return Nothing
                End If
            End With
        End Function

        Public Shared Function GetAnotherFileName(fileName As String) As String
            Dim d As String = Path.GetDirectoryName(fileName)
            If Directory.Exists(d) Then
                Dim f As String = Path.GetFileNameWithoutExtension(fileName)
                Dim x As String = Path.GetExtension(fileName)

                Dim nf As String = fileName
                Dim i As Integer = 0
                Do While File.Exists(nf)
                    i += 1
                    nf = Path.Combine(d, f & " (" & i & ")" & x)
                Loop

                Return nf
            Else
                Return Nothing
            End If
        End Function

        Public Shared Function GetTextReader(ByVal textFile As String, ByVal encoding As Encoding) As StreamReader
            'Using fs As New FileStream(textFile, FileMode.Open, FileAccess.Read)
            '    Using sr As StreamReader = New StreamReader()

            '    End Using
            Return New StreamReader(textFile, encoding, True)
        End Function
    End Class 'KzFile

    Public Class KzTextInfo

        Public Sub New(ByVal text As String)
            Me.Text = text
        End Sub

        Public Property Text As String

        Public ReadOnly Property Length As Integer
            Get
                Return Me.Text.Length
            End Get
        End Property

        Public ReadOnly Property LengthInNoSpaces As Integer
            Get
                Return Me.Text.Replace(" ", "").Replace("　", "").Length
            End Get
        End Property

        Public ReadOnly Property TextElements As Integer
            Get
                Return New System.Globalization.StringInfo(Me.Text).LengthInTextElements
            End Get
        End Property

        Public ReadOnly Property Lines As Integer
        Public ReadOnly Property Paragraphs As Integer
        Public ReadOnly Property Punctuations As Integer
        Public ReadOnly Property ChineseCharacters As Integer

        Public Function WordCount(ByVal word As String) As Integer
            Return KzStr.WordsCount(Me.Text, word)
        End Function

        Public Function WordsCount(ByVal words As String()) As Integer
            Return KzStr.WordsCount(Me.Text, words)
        End Function
    End Class 'KzTextInfo

    Public Class KzCnNumber
        Private UserNumber As Double 'Set by OriginNumber
        Private UserIsGrandZero As Boolean 'Set by IsGrandZero
        Private UserIsGrandNumber As Boolean 'Set by IsGrandNumber
        Private UserIsSingleTen As Boolean 'Set by IsSingleTen
        Private UserIsOldCounting As Boolean 'Set by IsOldCounting
        Private UserYearMode As Integer 'Set by CnYearMode
        Private UserYearsFile As String

        Public Sub New()
            OriginNumber = 0
            IsGrandNumber = False
            IsGrandZero = False
            IsSingleTen = False
            IsOldCounting = False
            CnYearMode = CnYear.Common
            CNYearsFile = ""
        End Sub

        Public Property OriginNumber As Double '取得原始數字
            Get
                Return UserNumber
            End Get
            Set(value As Double)
                UserNumber = value
            End Set
        End Property

        Public Property CNYearsFile As String
            Get
                Return UserYearsFile
            End Get
            Set(value As String)
                UserYearsFile = value
            End Set
        End Property

        Public Property IsGrandZero() As Boolean '是否使用大寫零，是=零，否=〇
            Get
                Return UserIsGrandZero
            End Get
            Set(value As Boolean)
                If IsGrandNumber Then '如果設置了使用大寫數字，零也必須為大寫
                    UserIsGrandZero = True
                Else
                    UserIsGrandZero = value
                End If
            End Set
        End Property

        Public Property IsGrandNumber As Boolean '是否使用大寫數字，是=壹貳叁肆...，否=一二三四...
            Get
                Return UserIsGrandNumber
            End Get
            Set(value As Boolean)
                UserIsGrandNumber = value
                If UserIsGrandNumber Then '使用大寫數字時，零也必須用大寫
                    IsGrandZero = True
                End If
            End Set
        End Property

        Public Property IsSingleTen As Boolean '是否使用單十，是=二十/三十，否=廿/卅
            Get
                Return UserIsSingleTen
            End Get
            Set(value As Boolean)
                UserIsSingleTen = value
            End Set
        End Property

        Public Property IsOldCounting As Boolean
            Get
                Return UserIsOldCounting
            End Get
            Set(value As Boolean)
                UserIsOldCounting = value
            End Set
        End Property

        Public Property CnYearMode As Integer
            Get
                Return UserYearMode
            End Get
            Set(value As Integer)
                If value < CnYear.Common Then
                    UserYearMode = CnYear.Common
                ElseIf value > CnYear.HistoricalCommon Then
                    UserYearMode = CnYear.HistoricalCommon
                Else
                    UserYearMode = value
                End If
            End Set
        End Property

        Public ReadOnly Property StandardNumber As String '輸出標準記數，帶千分號及保留兩位小數
            Get
                If IsIntegerNumber Then
                    Return Format(UserNumber, "#,0")
                Else
                    Return Format(UserNumber, "#,0.00")
                End If
            End Get
        End Property

        Public Function ToConstantWidth(ByVal IntegerPartDigi As Integer, ByVal DecimalPartDigi As Integer) As String
            '輸出指定位數的數字，前後空位以0填充。
            If IsIntegerNumber Then
                Return Format(UserNumber, StrDup(IntegerPartDigi, "0"))
            Else
                Dim nPre As String = Nothing
                Dim nPos As String = Nothing

                If Len(IntegerPart.ToString) < IntegerPartDigi Then
                    nPre = StrDup(IntegerPartDigi - Len(IntegerPart.ToString), "0") & IntegerPart.ToString
                Else
                    nPre = IntegerPart.ToString
                End If

                If Len(DecimalPart) < DecimalPartDigi Then
                    nPos = DecimalPart & StrDup(DecimalPartDigi - Len(DecimalPart), "0")
                Else
                    nPos = DecimalPart
                End If

                Return nPre & "." & nPos
            End If
        End Function

        Public ReadOnly Property IntegerPart As Long '取得數字的整數部分
            Get
                If IsIntegerNumber Then
                    Return UserNumber
                Else
                    Return CLng(UserNumber)
                End If
            End Get
        End Property

        Public ReadOnly Property DecimalPart As String '取得數字的小數部分
            Get
                If IsIntegerNumber Then
                    Return "0"
                Else
                    Return Strings.Mid(UserNumber.ToString, InStr(UserNumber.ToString, ".") + 1)
                End If
            End Get
        End Property

        Public ReadOnly Property IsIntegerNumber As Boolean '判斷是否整數
            Get
                If CLng(UserNumber) = UserNumber Then
                    Return True
                Else
                    Return False
                End If
            End Get
        End Property

        Public ReadOnly Property IsPrimeNumber As Boolean '判斷是否質數
            Get
                'Dim i As Long
                For i As Long = 2 To Math.Sqrt(UserNumber)
                    If UserNumber Mod i = 0 Then
                        Return False
                        Exit Property
                    End If
                Next
                Return True
            End Get
        End Property

        Public ReadOnly Property ReadingForm As String
            Get
                If IsIntegerNumber Then
                    ReadingForm = ToCnNumbers(UserNumber)
                Else
                    ReadingForm = ToCnNumbers(IntegerPart) & "點" & ToCnSerial(DecimalPart)
                End If

                If UserIsGrandZero Then
                    ReadingForm = ReadingForm.Replace("〇", "零")
                End If

                If UserIsGrandNumber Then
                    ReadingForm = ToGrandForm(ReadingForm)
                End If

                If UserIsSingleTen Then
                    ReadingForm = ReadingForm.Replace("二十", "廿").Replace("三十", "卅").Replace("貳拾", "廿").Replace("叁拾", "卅")
                End If

                If UserIsOldCounting Then
                    Dim sLeft As String ' = Left(ReadingForm, InStr(ReadingForm, "點") - 1)
                    Dim sRight As String
                    If Strings.InStr(ReadingForm, "點") = 0 Then
                        sLeft = ReadingForm
                        sRight = ""
                    Else
                        sLeft = Left(ReadingForm, InStr(ReadingForm, "點") - 1)
                        sRight = Mid(ReadingForm, InStr(ReadingForm, "點"))
                    End If
                    sLeft = sLeft.Replace("一十", "十").Replace("一百", "百").Replace("一千", "千").Replace("一萬", "萬").Replace("〇", "")
                    sLeft = sLeft.Replace("壹拾", "拾").Replace("壹佰", "佰").Replace("壹仟", "仟").Replace("壹萬", "萬").Replace("零", "")

                    ReadingForm = sLeft & sRight
                End If
            End Get
        End Property

        Public ReadOnly Property SerialForm As String
            Get
                If IsIntegerNumber Then
                    SerialForm = ToCnSerial(UserNumber.ToString)
                Else
                    SerialForm = ToCnSerial(IntegerPart.ToString) & "點" & ToCnSerial(DecimalPart)
                End If

                If UserIsGrandZero Then
                    SerialForm = SerialForm.Replace("〇", "零")
                End If

                If UserIsGrandNumber Then
                    SerialForm = ToGrandForm(SerialForm)
                End If
            End Get
        End Property

        Public ReadOnly Property FinacialWriteForm As String
            Get
                Return ToCnFinalcial(UserNumber, FnFormat.WriteMode)
            End Get
        End Property

        Public ReadOnly Property FinacialReadForm As String
            Get
                Return ToCnFinalcial(UserNumber, FnFormat.ReadMode)
            End Get
        End Property

        Public ReadOnly Property SerialTianGan As String
            Get
                Return ToJiazi(Math.Abs(CLng(UserNumber)), SnFormat.CnTiangan)
            End Get
        End Property

        Public ReadOnly Property SerialDiZhi As String
            Get
                Return ToJiazi(Math.Abs(CLng(UserNumber)), SnFormat.CnDizhi)
            End Get
        End Property

        Public ReadOnly Property SerialJiazi As String
            Get
                Return ToJiazi(Math.Abs(CLng(UserNumber)), SnFormat.CnJiazi)
            End Get
        End Property

        Public ReadOnly Property RomeForm As String
            Get
                If UserIsGrandNumber Then
                    Return ToRomeNumber(Math.Abs(CLng(UserNumber)), True)
                Else
                    Return ToRomeNumber(Math.Abs(CLng(UserNumber)), False)
                End If
            End Get
        End Property

        Public ReadOnly Property CnYearDescription As String
            Get
                CnYearDescription = ToCnYear(CInt(UserNumber), CnYearMode)
                If UserIsGrandZero Then
                    CnYearDescription = CnYearDescription.Replace("〇", "零")
                End If
                If UserIsGrandNumber Then
                    CnYearDescription = ToGrandForm(CnYearDescription)
                End If
                If UserIsSingleTen Then
                    CnYearDescription = CnYearDescription.Replace("二十", "廿").Replace("三十", "卅").Replace("貳拾", "廿").Replace("叁拾", "卅")
                End If
            End Get
        End Property

#Region "NewFunction"
        '新計算函數
        Private Function ToCnNumbers(ByVal AnInteger As Long) As String
            Dim MyInteger As Long = Math.Abs(AnInteger) '分離正負號，取得數字的絕對值
            'Dim MyLen As Integer = MyInteger.ToString.Length  '取得絕對值數字的長度
            Dim MyMinus As String = "" '存儲正負號，正數時無符號
            If AnInteger < 0 Then
                MyMinus = "負"
            End If

            Dim CSN As String() = {"〇", "一", "二", "三", "四", "五", "六", "七", "八", "九"}
            Dim CSUN As String() = {"千", "百", "十", "兆", "千", "百", "十", "億", "千", "百", "十", "萬", "千", "百", "十", ""}
            Dim ei(MyInteger.ToString.Length - 1) As Integer
            Dim i As Integer
            Dim RStr As String = ""

            For i = 0 To MyInteger.ToString.Length - 1
                ei(i) = CInt(Mid(MyInteger.ToString, MyInteger.ToString.Length - i, 1))
            Next

            For i = 0 To ei.Count - 1
                RStr = Left(CSN(ei(i)), 1) & Left(CSUN(CSUN.Count - 1 - i), 1) & RStr
            Next

            If Right(RStr, 1) = "〇" Then
                RStr = Left(RStr, Len(RStr) - 1)
            End If
            RStr = RStr.Replace("〇十", "〇").Replace("〇百", "〇").Replace("〇千", "〇")
            RStr = RStr.Replace("〇萬", "萬").Replace("〇億", "億").Replace("〇兆", "兆").Replace("〇〇", "〇")
            If Left(RStr, 2) = "一十" Then
                RStr = Mid(RStr, 2)
            End If

            Return MyMinus & RStr
        End Function

        Private Function ToCnSerial(ByVal AnIntegerString As String) As String
            Dim MyString As String = AnIntegerString
            Dim MyMinus As String = ""
            If Left(MyString, 1) = "-" Then
                MyMinus = "負"
                MyString = Mid(MyString, 2)
            End If
            Dim CSN As String() = {"〇", "一", "二", "三", "四", "五", "六", "七", "八", "九"}
            Dim ei(MyString.Length - 1) As Integer
            Dim i As Integer
            Dim Rstr As String = ""

            For i = 0 To MyString.Length - 1
                ei(i) = CInt(Mid(MyString, MyString.Length - i, 1))
            Next

            For i = 0 To ei.Count - 1
                Rstr = Left(CSN(ei(i)), 1) & Rstr
            Next

            Return MyMinus & Rstr
        End Function

        Private Function ToGrandForm(ByVal OriginString As String) As String
            Dim CSN As String() = {"〇", "一", "二", "三", "四", "五", "六", "七", "八", "九", "十", "千", "百"}
            Dim CSG As String() = {"零", "壹", "貳", "叁", "肆", "伍", "陸", "柒", "捌", "玖", "拾", "仟", "佰"}

            ToGrandForm = OriginString
            For i As Integer = 0 To CSN.Count - 1
                ToGrandForm = ToGrandForm.Replace(CSN(i), CSG(i))
            Next
        End Function

        Private Function ReplaceArray(ByVal OriginString As String, ByVal FindStrings As String(), ByVal ReplaceStrings As String()) As String
            If FindStrings.Count = ReplaceStrings.Count And FindStrings.Count > 0 And ReplaceStrings.Count > 0 Then
                'Dim i As Integer
                ReplaceArray = OriginString
                For i As Integer = 0 To FindStrings.Count - 1
                    ReplaceArray = ReplaceArray.Replace(FindStrings(i), ReplaceStrings(i))
                Next
            Else
                ReplaceArray = Nothing
            End If
        End Function
#End Region 'NewFunctions

#Region "Functions"
        '以下為計算函數
        Private Enum SnFormat
            Standard = 0 '標準數字序列
            AlphabetCapital = 11 '大寫英文字母序列（1-26）
            Alphabet = 1 '小寫英文字母序列（1-26）
            CnLong = 2 '中文長數序列，如“一萬四千八百九十六”
            CnShort = 21 '中文短數序列“一四八九六”
            CnOldBook = 22 '中文古籍卷序列
            CnLongB0 = 23 '中文長數序列用大寫零
            CnShortB0 = 24 '中文短數序列用大寫零
            CnGrandLong = 3 '中文大寫長序列
            CnGrandShort = 31 '中文大寫短序列
            CnGrandMoney = 32 '中文大寫金額
            RomeCapital = 4 '羅馬數字序號（1-99）
            RomeSmall = 41 '羅馬數字小寫序號（1-99）
            CnTiangan = 51 '干序列（1-10）
            CnDizhi = 52 '支序列（1-12）
            CnJiazi = 5 '干支序列（1-60）
        End Enum

        Private Function ToCnSerial1(ByVal i As Long, ByVal iType As Integer) As String
            Dim CSN As String() = {"〇零", "一壹", "二貳", "三叁", "四肆", "五伍", "六陸", "七柒", "八捌", "九玖"}
            Dim CSUN As String() = {"千仟", "百佰", "十拾", "兆兆", "千仟", "百佰", "十拾", "億億", "千仟", "百佰", "十拾", "萬", "千仟", "百佰", "十拾", ""}
            Dim ei(Strings.Len(i.ToString) - 1) As Integer
            Dim e As Integer
            Dim ReturnStr As String = ""

            '拆分數字，每位付於數列，ei(0)=個位，數列反向賦值。
            For e = 0 To Strings.Len(i.ToString) - 1
                ei(e) = CInt(Strings.Mid(i.ToString, Strings.Len(i.ToString) - e, 1))
            Next

            If i >= 0 Then
                Select Case iType
                    Case SnFormat.CnLong, SnFormat.CnLongB0, SnFormat.CnOldBook
                        For e = 0 To ei.Count - 1
                            ReturnStr = Strings.Left(CSN(ei(e)), 1) & Strings.Left(CSUN(CSUN.Count - 1 - e), 1) & ReturnStr
                        Next
                        If Strings.Right(ReturnStr, 1) = "〇" Then
                            ReturnStr = Strings.Left(ReturnStr, Strings.Len(ReturnStr) - 1)
                        End If
                        'ReturnStr = ReplaceArray(ReturnStr, {}, {})
                        ReturnStr = ReturnStr.Replace("〇十", "〇").Replace("〇百", "〇").Replace("〇千", "〇")
                        ReturnStr = ReturnStr.Replace("〇萬", "萬").Replace("〇億", "億").Replace("〇兆", "兆").Replace("〇〇", "〇")
                        If Strings.Left(ReturnStr, 2) = "一十" Then
                            ReturnStr = Strings.Mid(ReturnStr, 2)
                        End If
                        If iType = SnFormat.CnOldBook Then
                            ReturnStr = ReturnStr.Replace("一十", "十").Replace("二十", "廿").Replace("三十", "卅")
                            ReturnStr = ReturnStr.Replace("一百", "百").Replace("一千", "千").Replace("一萬", "萬").Replace("〇", "")
                        End If
                        If iType = SnFormat.CnLongB0 Then
                            ReturnStr = ReturnStr.Replace("〇", "零")
                        End If
                    Case SnFormat.CnShort, SnFormat.CnShortB0
                        For e = 0 To ei.Count - 1
                            ReturnStr = Strings.Left(CSN(ei(e)), 1) & ReturnStr
                        Next
                        If iType = SnFormat.CnShortB0 Then
                            ReturnStr = ReturnStr.Replace("〇", "零")
                        End If
                    Case SnFormat.CnGrandLong
                        For e = 0 To ei.Count - 1
                            ReturnStr = Strings.Right(CSN(ei(e)), 1) & Strings.Right(CSUN(CSUN.Count - 1 - e), 1) & ReturnStr
                        Next
                        If Strings.Right(ReturnStr, 1) = "零" Then
                            ReturnStr = Strings.Left(ReturnStr, Strings.Len(ReturnStr) - 1)
                        End If
                        ReturnStr = Strings.Replace(ReturnStr, "零拾", "零")
                        ReturnStr = Strings.Replace(ReturnStr, "零佰", "零")
                        ReturnStr = Strings.Replace(ReturnStr, "零仟", "零")
                        ReturnStr = Strings.Replace(ReturnStr, "零萬", "萬")
                        ReturnStr = Strings.Replace(ReturnStr, "零億", "億")
                        ReturnStr = Strings.Replace(ReturnStr, "零兆", "兆")
                        ReturnStr = Strings.Replace(ReturnStr, "零零", "零")
                        If Strings.Left(ReturnStr, 2) = "壹拾" Then
                            ReturnStr = Strings.Mid(ReturnStr, 2)
                        End If
                    Case SnFormat.CnGrandShort
                        For e = 0 To ei.Count - 1
                            ReturnStr = Strings.Right(CSN(ei(e)), 1) & ReturnStr
                        Next
                    Case Else
                        MsgBox("else")
                        ReturnStr = ""
                End Select
            Else
                ReturnStr = "-"
            End If

            Return ReturnStr
        End Function

        Private Function ToJiazi(ByVal i As Long, ByVal iType As Integer) As String
            Dim Gan As String() = {"甲", "乙", "丙", "丁", "戊", "己", "庚", "辛", "壬", "癸"}
            Dim Zhi As String() = {"子", "丑", "寅", "卯", "辰", "巳", "午", "未", "申", "酉", "戌", "亥"}

            If i > 0 Then
                Select Case iType
                    Case SnFormat.CnTiangan
                        Dim g As Integer = i
                        'MsgBox(g.ToString)
                        Do Until g <= Gan.Count
                            g -= 10
                        Loop
                        'MsgBox(g.ToString)
                        ToJiazi = Gan(g - 1)
                    Case SnFormat.CnDizhi
                        Dim z As Integer = i
                        Do Until z <= Zhi.Count
                            z -= 12
                        Loop
                        ToJiazi = Zhi(z - 1)
                    Case SnFormat.CnJiazi
                        Dim g As Integer = i
                        Dim z As Integer = i
                        Do Until g <= Gan.Count
                            g = g - 10
                            'MsgBox("g:" & g)
                        Loop
                        Do Until z <= Zhi.Count
                            z = z - 12
                            'MsgBox("z:" & z)
                        Loop
                        ToJiazi = Gan(g - 1) & Zhi(z - 1)
                    Case Else
                        ToJiazi = ""
                End Select
            Else
                ToJiazi = "-"
            End If
        End Function

        Private Enum FnFormat
            WriteMode = 0 '詳細顯示每一位金額包括“零”
            ReadMode = 1 '顯示金額讀法
            NumbersMode = 2 '數字表示，兩位小數
            LongDigitalMode = 3 '數字表示，最多15位小數
        End Enum

        Private Function ToCnFinalcial(ByVal d As Double, ByVal iMode As Integer) As String
            Dim CSN As String() = {"〇零", "一壹", "二貳", "三叁", "四肆", "五伍", "六陸", "七柒", "八捌", "九玖"}
            Dim CSUN As String() = {"千仟", "百佰", "十拾", "兆兆", "千仟", "百佰", "十拾", "億億", "千仟", "百佰", "十拾", "萬", "千仟", "百佰", "十拾", "點圓", "角角", "分分"}
            Dim fNumber As Double
            Dim rStr As String = ""

            If iMode = FnFormat.WriteMode Or iMode = FnFormat.ReadMode Or iMode = FnFormat.NumbersMode Then
                fNumber = Math.Round(d, 2)
            Else
                fNumber = Math.Round(d, 15)
            End If

            Dim eFu As String
            Dim eZheng As String
            Dim eXiao As String

            If fNumber < 0 Then
                eFu = "負"
                fNumber = fNumber * -1
            Else
                eFu = ""
            End If

            If Strings.InStr(fNumber.ToString, ".") = 0 Then
                eZheng = fNumber
                eXiao = Nothing
            Else
                eZheng = Strings.Left(fNumber.ToString, Strings.InStr(fNumber.ToString, ".") - 1)
                eXiao = Strings.Mid(fNumber.ToString, InStr(fNumber.ToString, ".") + 1)
            End If
            Dim sZheng(Strings.Len(eZheng) - 1) As Integer
            Dim sXiao(Strings.Len(eXiao) - 1) As Integer

            Dim x As Integer
            For x = 0 To Strings.Len(eZheng) - 1
                sZheng(x) = CInt(Strings.Mid(eZheng, Strings.Len(eZheng) - x, 1))
            Next
            If eXiao IsNot Nothing Then
                For x = 0 To Strings.Len(eXiao) - 1
                    sXiao(x) = CInt(Strings.Mid(eXiao, x + 1, 1))
                Next
            Else
                sXiao = Nothing
            End If

            Select Case iMode
                Case FnFormat.WriteMode, FnFormat.ReadMode
                    For x = 0 To eZheng.Count - 1
                        rStr = Strings.Right(CSN(sZheng(x)), 1) & Strings.Right(CSUN(CSUN.Count - 1 - x - 2), 1) & rStr
                    Next
                    If Strings.Right(rStr, 1) = "零" Then
                        rStr = Strings.Left(rStr, Strings.Len(rStr) - 1)
                    End If
                    If eXiao IsNot Nothing Then
                        For x = 0 To eXiao.Count - 1
                            rStr = rStr & Strings.Right(CSN(sXiao(x)), 1) & Strings.Right(CSUN(CSUN.Count - 2 + x), 1)
                        Next
                    Else
                        rStr = rStr & "整"
                    End If

                    If iMode = FnFormat.ReadMode Then
                        rStr = Strings.Replace(rStr, "零拾", "零")
                        rStr = Strings.Replace(rStr, "零佰", "零")
                        rStr = Strings.Replace(rStr, "零仟", "零")
                        rStr = Strings.Replace(rStr, "零萬", "萬")
                        rStr = Strings.Replace(rStr, "零億", "億")
                        rStr = Strings.Replace(rStr, "零兆", "兆")
                        rStr = Strings.Replace(rStr, "零零", "零")
                        rStr = Strings.Replace(rStr, "零圓", "圓")
                        rStr = Strings.Replace(rStr, "零角", "")
                        rStr = Strings.Replace(rStr, "零分", "")
                    Else
                        If Strings.Right(rStr, 1) = "角" Then
                            rStr = rStr & "零分"
                        End If
                    End If

                Case FnFormat.NumbersMode, FnFormat.LongDigitalMode
                    For x = 0 To eZheng.Count - 1
                        rStr = Strings.Left(CSN(sZheng(x)), 1) & Strings.Left(CSUN(CSUN.Count - 1 - x - 2), 1) & rStr
                    Next
                    If Strings.Right(rStr, 1) = "零" Then
                        rStr = Strings.Left(rStr, Strings.Len(rStr) - 1)
                    End If
                    If eXiao IsNot Nothing Then
                        For x = 0 To eXiao.Count - 1
                            rStr = rStr & Strings.Left(CSN(sXiao(x)), 1) '& Strings.Left(CSUN(CSUN.Count - 2 + x), 1)
                        Next
                    End If

                    rStr = Strings.Replace(rStr, "〇十", "〇")
                    rStr = Strings.Replace(rStr, "〇百", "〇")
                    rStr = Strings.Replace(rStr, "〇千", "〇")
                    rStr = Strings.Replace(rStr, "〇萬", "萬")
                    rStr = Strings.Replace(rStr, "〇億", "億")
                    rStr = Strings.Replace(rStr, "〇兆", "兆")
                    rStr = Strings.Replace(rStr, "〇〇", "〇")
                    rStr = Strings.Replace(rStr, "〇點", "點")
                    If Strings.Left(rStr, 2) = "一十" Then
                        rStr = Strings.Mid(rStr, 2)
                    End If
                    If Strings.Right(rStr, 1) = "點" Then
                        rStr = Strings.Left(rStr, Strings.Len(rStr) - 1)
                    End If
                Case Else
            End Select

            ToCnFinalcial = eFu & rStr
        End Function

        Public Enum CnYear
            Common = 0 '僅顯示西元中文年
            Jiazi = 1 '僅顯示甲子年
            CommonJiazi = 2 '同時顯示西元及甲子，如“一九一一年辛亥” 
            Nianhao = 3 '僅顯示歷史紀年，如“漢建元元年”
            DihaoAndNianhao = 4 '同時顯示歷史紀年之帝號及年號，如“漢武帝建元元年”
            NianhaoAndJiazi = 5 '同時顯示歷史紀年及甲子，如“漢建元元年辛丑”
            Historical = 6 '全歷史紀年，如“漢武帝建元元年辛丑”
            CommonHistorical = 7 '西元及歷史紀年，如“前一四〇年〖漢武帝建元元年辛丑〗”
            HistoricalCommon = 8 '西元及歷史紀年，如“漢武帝建元元年辛丑（前一四〇年）”
        End Enum

        Private Function ToCnYear(ByVal i As Integer, ByVal yMode As Integer) As String
            '-2,147,483,648 到 2,147,483,647 （0除外）
            If i <> 0 Then
                Dim yCNY As String = ""
                Dim yJZ As String = ""
                Dim x As Integer
                If i > 0 Then
                    x = i + 57
                    yCNY = ToCnSerial1(i, SnFormat.CnShort) & "年"
                    yJZ = ToJiazi(x, SnFormat.CnJiazi)
                Else
                    x = 58 + i
                    Do Until x > 0
                        x = x + 60
                    Loop
                    yCNY = "前" & ToCnSerial1(i * -1, SnFormat.CnShort) & "年"
                    yJZ = ToJiazi(x, SnFormat.CnJiazi)
                End If

                Dim yStr As String = ""
                If yMode >= CnYear.Nianhao Then
                    If i >= -841 And i <= 1949 Then
                        Dim ySR As StreamReader
                        ySR = My.Computer.FileSystem.OpenTextFileReader(MyPresetFolder & "\cnyears.txt")
                        yStr = ySR.ReadLine
                        Do Until Strings.Left(yStr, Strings.InStr(yStr, "@") - 1) = i.ToString
                            yStr = ySR.ReadLine
                        Loop
                        ySR.Close()
                        ySR.Dispose()
                    Else
                        yStr = i.ToString & "@無紀年%無紀年"
                    End If
                End If

                Select Case yMode
                    Case CnYear.Common
                        ToCnYear = yCNY
                    Case CnYear.Jiazi
                        ToCnYear = yJZ
                    Case CnYear.CommonJiazi
                        ToCnYear = yCNY & yJZ
                    Case CnYear.Nianhao
                        ToCnYear = Strings.Mid(yStr, Strings.InStr(yStr, "%") + 1)
                    Case CnYear.DihaoAndNianhao
                        ToCnYear = Strings.Mid(yStr, Strings.InStr(yStr, "@") + 1, Strings.InStr(yStr, "%") - 1 - Strings.InStr(yStr, "@"))
                    Case CnYear.NianhaoAndJiazi
                        ToCnYear = Strings.Mid(yStr, Strings.InStr(yStr, "%") + 1) & yJZ
                    Case CnYear.Historical
                        ToCnYear = Strings.Mid(yStr, Strings.InStr(yStr, "@") + 1, Strings.InStr(yStr, "%") - 1 - Strings.InStr(yStr, "@")) & yJZ
                    Case CnYear.HistoricalCommon
                        ToCnYear = Strings.Mid(yStr, Strings.InStr(yStr, "@") + 1, Strings.InStr(yStr, "%") - 1 - Strings.InStr(yStr, "@")) & yJZ & "（" & yCNY & "）"
                    Case CnYear.CommonHistorical
                        ToCnYear = yCNY & "（" & Strings.Mid(yStr, Strings.InStr(yStr, "@") + 1, Strings.InStr(yStr, "%") - 1 - Strings.InStr(yStr, "@")) & yJZ & "）"
                    Case Else
                        ToCnYear = "*" 'cyMode can't find
                End Select
            Else
                ToCnYear = "無0年" 'i=0
            End If
        End Function

        Private Function ToAlphabetSerial(ByVal i As Integer, ByVal IsCapital As Boolean) As String
            'Chr(65)=A
            'Chr(97)=a
            If i > 0 And i < 27 Then
                If IsCapital Then
                    Return Chr(i + 64)
                Else
                    Return Chr(i + 96)
                End If
            Else
                Return "-"
            End If
        End Function

        Private Function ToRomeNumber(ByVal i As Long, ByVal IsCapital As Boolean) As String
            Dim iRome As String() = {"X,x", "I,i", "II,ii", "III,iii", "IV,iv", "V,v", "VI,vi", "VII,vii", "VIII,viii", "IX,ix"}

            Dim NumOfX As Integer = Math.Round((i / 10 - 0.5), 0)
            Dim SnOfRome As Integer = i Mod 10

            If i > 0 And i < 100 Then
                If IsCapital Then
                    Return Strings.StrDup(NumOfX, "X") & Strings.Left(iRome(SnOfRome), Strings.InStr(iRome(SnOfRome), ",") - 1)
                Else
                    Return Strings.StrDup(NumOfX, "x") & Strings.Mid(iRome(SnOfRome), Strings.InStr(iRome(SnOfRome), ",") + 1)
                End If
            Else
                Return "-"
            End If
        End Function
#End Region 'Functions

#Region "SharedFunctions"
        Public Shared Function CCDec(ByVal OriginChar As Char) As Integer
            Select Case OriginChar
                Case "零", "〇", ""
                    Return 0
                Case "一", "壹"
                    Return 1
                Case "二", "貳", "兩", "贰", "两"
                    Return 2
                Case "三", "叁"
                    Return 3
                Case "四", "肆"
                    Return 4
                Case "五", "伍"
                    Return 5
                Case "六", "陸", "陆"
                    Return 6
                Case "七", "柒"
                    Return 7
                Case "八", "捌"
                    Return 8
                Case "九", "玖"
                    Return 9
                Case Else
                    Return -1
            End Select
        End Function

        Public Shared Function CCSerial(ByVal ChineseSerial As String) As Integer
            Dim ans As String = ""
            For i As Integer = 0 To ChineseSerial.Length - 1
                ans = ans & CCDec(ChineseSerial(i))
            Next
            Return CInt(ans)
        End Function

        Public Shared Function CCInt(ByVal ChineseNumber As String) As Integer
            If ChineseNumber = "" Or ChineseNumber = Nothing Then
                Return 0
            Else
                Dim Temp As String = ChineseNumber.Replace("廿", "二十").Replace("卅", "三十")
                Dim Yi, Wan, Ling As String

                If "億亿萬万千仟百佰十拾".Contains(Temp(0)) Then
                    Temp = "一" & Temp
                End If

                If KzStr.ContainsChars(Temp, "億亿") And KzStr.ContainsChars(Temp, "萬万") Then
                    '億萬
                    Yi = KzStr.ReplaceChars(Temp, "億亿萬万", "|").Split("|")(0)
                    Wan = KzStr.ReplaceChars(Temp, "億亿萬万", "|").Split("|")(1)
                    Ling = KzStr.ReplaceChars(Temp, "億亿萬万", "|").Split("|")(2)
                ElseIf Not KzStr.ContainsChars(Temp, "億亿") And KzStr.ContainsChars(Temp, "萬万") Then
                    Yi = ""
                    Wan = KzStr.ReplaceChars(Temp, "萬万", "|").Split("|")(0)
                    Ling = KzStr.ReplaceChars(Temp, "萬万", "|").Split("|")(1)
                ElseIf KzStr.ContainsChars(Temp, "億亿") And Not KzStr.ContainsChars(Temp, "萬万") Then
                    Yi = KzStr.ReplaceChars(Temp, "億亿", "|").Split("|")(0)
                    Wan = ""
                    Ling = KzStr.ReplaceChars(Temp, "億亿", "|").Split("|")(1)
                ElseIf Not KzStr.ContainsChars(Temp, "億亿") And Not KzStr.ContainsChars(Temp, "萬万") Then
                    Yi = ""
                    Wan = ""
                    Ling = Temp
                Else
                    Yi = ""
                    Wan = ""
                    Ling = ""
                End If

                Try
                    Return CSection(Yi) * 100000000 + CSection(Wan) * 10000 + CSection(Ling)
                Catch ex As Exception
                    Return -1
                End Try
            End If

        End Function

        Private Shared Function CSection(ByVal Section As String) As Integer
            If Section = "" Or Section = Nothing Or KzStr.ContainsChars(Section, "萬億万亿") Then
                Return 0
            Else
                Dim Qian, Bai, Shi, Ge As String
                Section = Section.Replace("〇", "").Replace("零", "")

                If KzStr.ContainsChars(Section, "千仟") And KzStr.ContainsChars(Section, "百佰") _
                    And KzStr.ContainsChars(Section, "十拾") Then
                    '千百十
                    Qian = KzStr.ReplaceChars(Section, "千仟百佰十拾", "|").Split("|")(0)
                    Bai = KzStr.ReplaceChars(Section, "千仟百佰十拾", "|").Split("|")(1)
                    Shi = KzStr.ReplaceChars(Section, "千仟百佰十拾", "|").Split("|")(2)
                    Ge = KzStr.ReplaceChars(Section, "千仟百佰十拾", "|").Split("|")(3)
                ElseIf Not KzStr.ContainsChars(Section, "千仟") And KzStr.ContainsChars(Section, "百佰") _
                    And KzStr.ContainsChars(Section, "十拾") Then
                    '百十
                    Qian = ""
                    Bai = KzStr.ReplaceChars(Section, "百佰十拾", "|").Split("|")(0)
                    Shi = KzStr.ReplaceChars(Section, "百佰十拾", "|").Split("|")(1)
                    Ge = KzStr.ReplaceChars(Section, "百佰十拾", "|").Split("|")(2)
                ElseIf Not KzStr.ContainsChars(Section, "千仟") And Not KzStr.ContainsChars(Section, "百佰") _
                    And KzStr.ContainsChars(Section, "十拾") Then
                    '十
                    Qian = ""
                    Bai = ""
                    Shi = KzStr.ReplaceChars(Section, "十拾", "|").Split("|")(0)
                    Ge = KzStr.ReplaceChars(Section, "十拾", "|").Split("|")(1)
                ElseIf Not KzStr.ContainsChars(Section, "千仟") And Not KzStr.ContainsChars(Section, "百佰") _
                    And Not KzStr.ContainsChars(Section, "十拾") Then
                    '
                    Qian = ""
                    Bai = ""
                    Shi = ""
                    Ge = Section
                ElseIf KzStr.ContainsChars(Section, "千仟") And KzStr.ContainsChars(Section, "百佰") _
                    And Not KzStr.ContainsChars(Section, "十拾") Then
                    '千百
                    Qian = KzStr.ReplaceChars(Section, "千仟百佰", "|").Split("|")(0)
                    Bai = KzStr.ReplaceChars(Section, "千仟百佰", "|").Split("|")(1)
                    Shi = ""
                    Ge = KzStr.ReplaceChars(Section, "千仟百佰", "|").Split("|")(2)
                ElseIf KzStr.ContainsChars(Section, "千仟") And Not KzStr.ContainsChars(Section, "百佰") _
                    And Not KzStr.ContainsChars(Section, "十拾") Then
                    '千
                    Qian = KzStr.ReplaceChars(Section, "千仟", "|").Split("|")(0)
                    Bai = ""
                    Shi = ""
                    Ge = KzStr.ReplaceChars(Section, "千仟", "|").Split("|")(1)
                ElseIf KzStr.ContainsChars(Section, "千仟") And Not KzStr.ContainsChars(Section, "百佰") _
                    And KzStr.ContainsChars(Section, "十拾") Then
                    '千十
                    Qian = KzStr.ReplaceChars(Section, "千仟十拾", "|").Split("|")(0)
                    Bai = ""
                    Shi = KzStr.ReplaceChars(Section, "千仟十拾", "|").Split("|")(1)
                    Ge = KzStr.ReplaceChars(Section, "千仟十拾", "|").Split("|")(2)
                ElseIf Not KzStr.ContainsChars(Section, "千仟") And KzStr.ContainsChars(Section, "百佰") _
                    And Not KzStr.ContainsChars(Section, "十拾") Then
                    '百
                    Qian = ""
                    Bai = KzStr.ReplaceChars(Section, "百佰", "|").Split("|")(0)
                    Shi = ""
                    Ge = KzStr.ReplaceChars(Section, "百佰", "|").Split("|")(1)
                Else
                    Qian = ""
                    Bai = ""
                    Shi = ""
                    Ge = ""
                End If

                Try
                    Return CCDec(Qian) * 1000 + CCDec(Bai) * 100 + CCDec(Shi) * 10 + CCDec(Ge)
                Catch ex As Exception
                    Return -1
                End Try

            End If
        End Function
#End Region 'SharedFunctions
    End Class

End Namespace