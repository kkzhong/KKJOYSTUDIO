Imports System.IO
Imports System.Text

Public Class ReplacementForm
    Private Sub ReplacementForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox1.AllowDrop = True
    End Sub

    Private Sub TextBox1_DragDrop(sender As Object, e As DragEventArgs) Handles TextBox1.DragDrop
        If e.Data.GetDataPresent(DataFormats.FileDrop) Then
            Dim DroppedFiles() As String = e.Data.GetData(DataFormats.FileDrop)
            TextBox1.Text = File.ReadAllText(DroppedFiles(0), Encoding.Default)
            KzReplacer1.EffectedBox = TextBox1

            TextBox1.BackColor = SystemColors.Window
            TextBox1.BorderStyle = BorderStyle.None
        End If
    End Sub

    Private Sub TextBox1_DragEnter(sender As Object, e As DragEventArgs) Handles TextBox1.DragEnter
        If e.Data.GetDataPresent(DataFormats.FileDrop) Then
            e.Effect = DragDropEffects.All
        End If

        TextBox1.BackColor = Color.SkyBlue
        TextBox1.BorderStyle = BorderStyle.FixedSingle
    End Sub
End Class