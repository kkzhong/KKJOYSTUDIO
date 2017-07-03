Imports Microsoft.Office.Interop
Imports System.Data.OleDb

Namespace KzLibrary

    Public Class KzDataImport

        Public Shared Sub FillListWithTableNames _
            (ByVal TheListBox As ListBox, ByVal DatabaseConnection As OleDbConnection)
            Try
                TheListBox.Items.Clear()
                Dim TableNamesSchemaTable As DataTable =
                        DatabaseConnection.GetOleDbSchemaTable _
                        (OleDbSchemaGuid.Tables, New Object() {Nothing, Nothing, Nothing, "TABLE"})
                Dim TableNamesDataTableReader As DataTableReader = TableNamesSchemaTable.CreateDataReader()
                Dim ItemTitle As String = ""

                While TableNamesDataTableReader.Read()
                    ItemTitle = TableNamesDataTableReader.GetValue(2)

                    TheListBox.Items.Add(ItemTitle)
                End While

                TableNamesDataTableReader.Close()
            Catch ex As Exception

            End Try
        End Sub

        Public Shared Sub FillListWithTableNames _
            (ByVal TheComboBox As ComboBox, ByVal DatabaseConnection As OleDbConnection)
            Try
                TheComboBox.Items.Clear()
                Dim TableNamesSchemaTable As DataTable =
                        DatabaseConnection.GetOleDbSchemaTable _
                        (OleDbSchemaGuid.Tables, New Object() {Nothing, Nothing, Nothing, "TABLE"})
                Dim TableNamesDataTableReader As DataTableReader = TableNamesSchemaTable.CreateDataReader()
                Dim ItemTitle As String = ""

                While TableNamesDataTableReader.Read()
                    ItemTitle = TableNamesDataTableReader.GetValue(2)

                    TheComboBox.Items.Add(ItemTitle)
                End While

                TableNamesDataTableReader.Close()
            Catch ex As Exception

            End Try
        End Sub

        Public Shared Sub FillListWithColumnNames _
            (ByVal TheListBox As ListBox, ByVal TheTable As DataTable)
            Try
                TheListBox.Items.Clear()
                TheListBox.Items.Add("*")
                Dim TheReader As DataTableReader = TheTable.CreateDataReader()
                For i As Integer = 0 To TheReader.FieldCount - 1
                    TheListBox.Items.Add(TheReader.GetName(i))
                Next
                TheReader.Close()
            Catch ex As Exception

            End Try
        End Sub

        Public Shared Sub FillListWithColumnNames _
            (ByVal TheComboBox As ComboBox, ByVal TheTable As DataTable)
            Try
                TheComboBox.Items.Clear()
                TheComboBox.Items.Add("*")
                Dim TheReader As DataTableReader = TheTable.CreateDataReader()
                For i As Integer = 0 To TheReader.FieldCount - 1
                    TheComboBox.Items.Add(TheReader.GetName(i))
                Next
                TheReader.Close()
            Catch ex As Exception

            End Try
        End Sub

        Public Shared Sub FillTreeWithTableNames _
            (ByVal TheTreeView As TreeView, ByVal DatabaseConnection As OleDbConnection)
            Try
                TheTreeView.Nodes.Clear()

                Dim TableNamesSchemaTable As DataTable =
                        DatabaseConnection.GetOleDbSchemaTable _
                        (OleDbSchemaGuid.Tables, New Object() {Nothing, Nothing, Nothing, "TABLE"})
                Dim TableNamesDataTableReader As DataTableReader = TableNamesSchemaTable.CreateDataReader()
                Dim NodeTitle As String = ""
                Dim i As Integer

                While TableNamesDataTableReader.Read()
                    NodeTitle = TableNamesDataTableReader.GetValue(2) 'Table name

                    Dim TheNode As New TreeNode(NodeTitle)
                    TheNode.Tag = NodeTitle
                    Dim TheTable As DataTable = GetDataBySqlCommand("SELECT * FROM " & NodeTitle, DatabaseConnection)
                    Dim TheDataTableReader As DataTableReader = TheTable.CreateDataReader

                    For i = 0 To TheDataTableReader.FieldCount - 1
                        Dim TheChildNode As New TreeNode(TheDataTableReader.GetName(i) & " [" & TheDataTableReader.GetDataTypeName(i) & "]")
                        TheChildNode.Tag = TheDataTableReader.GetName(i)
                        TheNode.Nodes.Add(TheChildNode)
                    Next
                    TheDataTableReader.Close()
                    TheTreeView.Nodes.Add(TheNode)
                End While

                TableNamesDataTableReader.Close()

            Catch ex As Exception

            End Try

        End Sub

        Public Shared Sub FillGridBySqlCommand _
            (ByVal TheDataGridView As DataGridView, ByVal SqlCommandString As String,
             ByVal DatabaseConnection As OleDbConnection, Optional ByVal ByEmptyTable As Boolean = False)
            Try
                Dim TheBindingSource As New BindingSource()
                TheBindingSource.DataSource = GetDataBySqlCommand(SqlCommandString, DatabaseConnection, ByEmptyTable)
                TheDataGridView.DataSource = TheBindingSource
            Catch ex As Exception
                System.Threading.Thread.CurrentThread.Abort()
            End Try

        End Sub

        Public Shared Sub FillGridByTable _
            (ByVal TheDataGridView As DataGridView, ByVal TheTable As DataTable)
            Try
                Dim TheBindingSource As New BindingSource()
                TheBindingSource.DataSource = TheTable
                TheDataGridView.DataSource = TheBindingSource
            Catch ex As Exception
                System.Threading.Thread.CurrentThread.Abort()
            End Try

        End Sub

        Public Shared Sub FillGridByTableSchema _
            (ByVal TheDataGridView As DataGridView, ByVal TheTable As DataTable)
            Try
                Dim TheBindingSource As New BindingSource()
                Dim TheReader As DataTableReader = TheTable.CreateDataReader()
                TheBindingSource.DataSource = TheReader.GetSchemaTable()
                TheDataGridView.DataSource = TheBindingSource
            Catch ex As Exception
                System.Threading.Thread.CurrentThread.Abort()
            End Try
        End Sub

        Public Shared Function GetDataBySqlCommand _
            (ByVal SqlCommandString As String, ByVal DatabaseConnection As OleDbConnection,
             Optional ByVal ByEmptyTable As Boolean = False) As DataTable

            Dim TheTable As New DataTable

            Try
                Dim TheCommand As New OleDbCommand(SqlCommandString, DatabaseConnection)
                Dim TheAdapter As OleDbDataAdapter = New OleDbDataAdapter
                TheAdapter.SelectCommand = TheCommand

                TheTable.Locale = System.Globalization.CultureInfo.InvariantCulture
                TheAdapter.Fill(TheTable)

                If ByEmptyTable Then
                    Return TheTable.Clone
                Else
                    Return TheTable
                End If

            Catch ex As Exception
                Return Nothing
            End Try

        End Function

        Public Shared Function GetExcelSheetData _
            (ByVal FileFullPath As String, ByVal SheetName As String,
             Optional ByVal WithHeadRow As Boolean = True) As DataTable

            Dim strConn As String
            If WithHeadRow Then
                strConn = ("Provider=Microsoft.Ace.OleDb.12.0;" & "data source=") + FileFullPath &
                    ";Extended Properties='Excel 12.0; HDR=YES; IMEX=1'"
            Else
                strConn = ("Provider=Microsoft.Ace.OleDb.12.0;" & "data source=") + FileFullPath &
                    ";Extended Properties='Excel 12.0; HDR=NO; IMEX=1'"
            End If
            Dim conn As New OleDbConnection(strConn)
            conn.Open()
            Dim ds As New DataSet()
            Dim odda As New OleDbDataAdapter(String.Format("SELECT * FROM [{0}]", SheetName), conn)
            odda.Fill(ds, SheetName)
            conn.Close()
            Return ds.Tables(0)
        End Function

        Public Shared Function GetExcelSheetData _
            (ByVal FileFullPath As String, Optional ByVal SheetIndex As Integer = 1,
             Optional ByVal WithHeadRow As Boolean = True) As DataTable

            Dim app As New Excel.Application
            Dim workbook As Excel.Workbook = app.Workbooks.Open(FileFullPath)
            Dim sheet As Excel.Worksheet = workbook.Sheets.Item(SheetIndex)
            Dim sheetname As String = sheet.Name
            workbook.Close()

            Dim strConn As String
            If WithHeadRow Then
                strConn = ("Provider=Microsoft.Ace.OleDb.12.0;" & "data source=") + FileFullPath &
                    ";Extended Properties='Excel 12.0; HDR=YES; IMEX=1'"
            Else
                strConn = ("Provider=Microsoft.Ace.OleDb.12.0;" & "data source=") + FileFullPath &
                    ";Extended Properties='Excel 12.0; HDR=NO; IMEX=1'"
            End If
            Dim conn As New OleDbConnection(strConn)
            conn.Open()
            Dim ds As New DataSet()
            Dim odda As New OleDbDataAdapter(String.Format("SELECT * FROM [{0}]", sheetname & "$"), conn)
            odda.Fill(ds, sheetname & "$")
            conn.Close()
            Return ds.Tables(0)
        End Function

    End Class
End Namespace