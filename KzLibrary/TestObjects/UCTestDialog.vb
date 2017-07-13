Public Class UCTestDialog
    Private Sub UCTestDialog_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim c As New KzColorSticker(Color.AliceBlue)
        c.Location = New Point(10, 10)
        c.Size = New Size(196, 56)
        c.ShowRAGB = True
        c.InnerMargin = New Padding(4)
        c.Dock = DockStyle.Top
        LeftSpliter.Panel1.Controls.Add(c)

        'Dim colors As Array = [Enum].GetValues(GetType(KnownColor))


        Dim colorsArray As System.Array = [Enum].GetValues(GetType(KnownColor))
        'Dim allColors(colorsArray.Length) As KnownColor

        'Array.Copy(colorsArray, allColors, colorsArray.Length)
        For i As Integer = 0 To colorsArray.GetUpperBound(0) ' allColors.GetUpperBound(0)
            SampleBox.Text &= i & ". " & colorsArray(i).ToString & vbCrLf
        Next
    End Sub
End Class