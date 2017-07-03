Imports KzDBReader.KzLibrary

Public Class ImportForm
    Private Sub OpenFileButton_Click(sender As Object, e As EventArgs) Handles OpenFileButton.Click
        Dim ofd As New OpenFileDialog
        ofd.Filter = "Excel Files (*.xls;*.xlsx;*.xlsm;*.xlt)|*.xls;*.xlsx;*.xlsm;*.xlt|" &
            "Text Files (*.txt;*.csv)|*.txt;*.csv|" & "All files (*.*)|*.*"

        If ofd.ShowDialog() = DialogResult.OK Then
            FileNameBox.Text = ofd.FileName
            ImportDataGridView.DataSource = KzDataImport.GetExcelSheetData(ofd.FileName)
            MsgBox("成功讀入 " & ImportDataGridView.Rows.Count & " 行。")
        End If

        'MsgBox(ImportDataGridView.Columns(22))
    End Sub

    Private Sub ImportData(sender As Object, e As EventArgs) Handles ImportButton.Click
        Dim importTable As New KzDataReaderDataSet.导入表DataTable
        Dim importDA As New KzDataReaderDataSetTableAdapters.导入表TableAdapter


    End Sub


    Private Sub ImportButton_Click(sender As Object, e As EventArgs) 'Handles ImportButton.Click
        Dim ofd As New OpenFileDialog
        ofd.Filter = "Excel Files (*.xls;*.xlsx;*.xlsm;*.xlt)|*.xls;*.xlsx;*.xlsm;*.xlt|" &
            "Text Files (*.txt;*.csv)|*.txt;*.csv|" & "All files (*.*)|*.*"

        If ofd.ShowDialog() = DialogResult.OK Then
            FileNameBox.Text = ofd.FileName
            Me.Cursor = Cursors.WaitCursor

            'Dim dt As DataTable = KzDataImport.GetExcelSheetData(ofd.FileName)
            Dim dt As New DataTable
            With dt
                Dim i As Integer
                Dim c As DataColumn

                For i = 0 To 54
                    c = New DataColumn

                    Select Case i
                        Case 0, 32 To 39
                            c.DataType = GetType(System.Int32)
                        Case 1 To 7, 9 To 31, 40
                            c.DataType = GetType(System.String)
                        Case 41 To 54
                            c.DataType = GetType(System.Double)
                        Case 8
                            c.DataType = GetType(System.DateTime)
                    End Select

                    dt.Columns.Add(c)
                Next

            End With

            dt.Load(KzDataImport.GetExcelSheetData(ofd.FileName).CreateDataReader)
            Me.Cursor = Cursors.Default

            '+MsgBox(dt.Columns(22).DataType.ToString)
            ImportDataGridView.DataSource = dt
        End If
    End Sub
End Class