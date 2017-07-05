Public Class KzInputListPanel

    Public Sub New()

        ' 此调用是设计器所必需的。
        InitializeComponent()

        ' 在 InitializeComponent() 调用之后添加任何初始化。


    End Sub

    Public Property InputItems As List(Of KzInputItem)

    Public Sub ShowItems()
        If InputItems.Count = 0 Then Exit Sub

        With InputPanel
            .RowStyles.Clear()
            For i As Integer = 0 To InputItems.Count - 1
                .RowStyles.Add(New RowStyle(SizeType.Absolute, 28))

                Dim lbl As New Label With {
                    .Text = InputItems.Item(i).Label,
                    .AutoSize = False,
                    .Dock = DockStyle.Fill,
                    .TextAlign = ContentAlignment.MiddleRight}
                .Controls.Add(lbl, 0, i)

                Dim txt As New TextBox With {
                    .Text = InputItems.Item(i).PresetText,
                    .Dock = DockStyle.Fill}
                .Controls.Add(txt, 1, i)

                Dim btnGo As New Button With {
                    .Text = ">", .Dock = DockStyle.Fill}
                .Controls.Add(btnGo, 2, i)

                Dim btnClear As New Button With {
                    .Text = "c", .Dock = DockStyle.Fill}
                .Controls.Add(btnClear, 3, i)
            Next
        End With

    End Sub
End Class
