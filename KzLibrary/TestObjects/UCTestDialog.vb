Public Class UCTestDialog
    Private WithEvents cp As New TestColorPicker With {.Dock = DockStyle.Fill}

    Private Sub UCTestDialog_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Controls.Add(cp)

    End Sub
End Class