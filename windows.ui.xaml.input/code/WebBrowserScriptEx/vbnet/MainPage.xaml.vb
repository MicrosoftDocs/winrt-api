'<snippetCodeBehind>
Partial Public Class MainPage
    Inherits UserControl
    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub WB1_ScriptNotify(ByVal sender As Object, ByVal e As NotifyEventArgs)
        Button1.Content = e.Value

        Button1.IsEnabled = False
    End Sub

    Private Sub Button1_Click(ByVal sender As Object, ByVal e As RoutedEventArgs)
        Dim results As Object = WB1.InvokeScript("LoadSearch", New String() {"Silverlight"})
    End Sub
End Class
'</snippetCodeBehind>
