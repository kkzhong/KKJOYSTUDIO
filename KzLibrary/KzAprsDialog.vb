Public Class KzAprsDialog

    Public Property TabDesignSet As KzTabDesignSet

    Private Sub KzAprsDialog_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim i As Integer
        Dim tp As KzAprsTab

        For i = 0 To 3
            tp = New KzAprsTab(False)
            tp.AObject = New KzAppearances
            tp.AutoScroll = True
            Select Case i
                Case 0 : tp.TitleLabel.Text = "NormalTab"
                Case 1 : tp.TitleLabel.Text = "SelectedTab"
                Case 2 : tp.TitleLabel.Text = "NormalButton"
                Case 3 : tp.TitleLabel.Text = "SelectedButton"
            End Select
            AprsTabs.TabPages.Add(tp)
        Next

        For i = 0 To 3
            tp = New KzAprsTab(True)
            tp.AObject = New KzAppearance
            tp.AutoScroll = True
            Select Case i
                Case 0 : tp.TitleLabel.Text = "NormalStatus"
                Case 1 : tp.TitleLabel.Text = "HoverStatus"
                Case 2 : tp.TitleLabel.Text = "PressedStatus"
                Case 3 : tp.TitleLabel.Text = "CheckedStatus"
            End Select
            AprTabs.TabPages.Add(tp)
        Next

        ShowDesignSetOnUI()
    End Sub

    Private Sub ShowDesignSetOnUI()
        If TabDesignSet Is Nothing Then
            TabDesignSet = New KzTabDesignSet
        End If
        With TabDesignSet
            RootBackColorBox.Text = .RootBackColor.Name
            AutoTabWidthCheck.Checked = .AutoTabWidth
            TabsUnderlineSizeUD.Value = .TabsUnderlineSize
            OpenUnderlineCheck.Checked = .OpenSelectedTabUnderline
            ShowCloseCheck.Checked = .ShowCloseButtonOnTab
            ShowUnselectedCheck.Checked = .ShowCloseOnUnselectedTabs
            ShowAddCheck.Checked = .ShowAddOnSelectedTab
            IgnoreTabCheck.Checked = .IgnorePrivateTabSetting
        End With
    End Sub
End Class