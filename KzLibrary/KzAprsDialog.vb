Public Class KzAprsDialog
    Private Sub KzAprsDialog_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim tp As KzAppearancesTab
        For i As Integer = 0 To 3
            tp = New KzAppearancesTab

            Select Case i
                Case 0 : tp.TitleLabel.Text = "Normal"
                Case 1 : tp.TitleLabel.Text = "Hover"
                Case 2 : tp.TitleLabel.Text = "Pressed"
                Case 3 : tp.TitleLabel.Text = "Checked"
            End Select

            AprTabs.AddTab(KzItemPosition.LastItem, tp)
            AprTabs.SelectedIndex = 0
        Next
    End Sub

End Class