Public Class EndForm

    Dim zoomStep As Integer = 10

    Private Sub EndForm_Load(sender As Object, e As EventArgs) Handles Me.Load
        LogoBox.Image = My.Resources.ODTCLogoHollow
        InfoLabel.Text = Application.ProductName & " " &
            Application.ProductVersion & " by " & Application.CompanyName

        SetBoxBounds(250)
        ZoomTimer.Interval = 100
        ZoomTimer.Enabled = True
        ZoomTimer.Start()
    End Sub

    Private Sub SetBoxBounds(boxSide As Integer)
        LogoBox.Bounds = New Rectangle(
            x:=(Me.ClientRectangle.Width - boxSide) / 2,
            y:=(Me.ClientRectangle.Height - boxSide) / 2,
            width:=boxSide, height:=boxSide)
    End Sub

    Private Sub ZoomTimer_Tick(sender As Object, e As EventArgs) Handles ZoomTimer.Tick
        SetBoxBounds(LogoBox.Width - zoomStep)
        If LogoBox.Width <= 50 Then
            ZoomTimer.Stop()
            ZoomTimer.Enabled = False

            Application.Exit()
        End If
    End Sub
End Class