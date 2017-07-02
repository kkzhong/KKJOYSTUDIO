Public Class CompTest
    Private Sub CompTest_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        StringCollection()
    End Sub

    Private Sub ColorTest()
        Dim c As New KzLibrary.KzColorSticker(Color.Orange)
        c.Dock = DockStyle.Top
        TheSpliter.Panel1.Controls.Add(c)
    End Sub

    Private Sub StringCollection()
        Dim sc As System.Collections.Specialized.StringCollection = My.Settings.EditorFileHistory
        sc.Add("text")
        sc.Add("station")
        sc.Add("Bee")
        sc.Add("Corn")

        Dim lb As New Label
        lb.Text = ""
        lb.AutoSize = False
        lb.Dock = DockStyle.Fill
        For i As Integer = 0 To sc.Count - 1
            lb.Text &= i & ": " & sc.Item(i) & vbCrLf
        Next
        TheSpliter.Panel1.Controls.Add(lb)
    End Sub
End Class