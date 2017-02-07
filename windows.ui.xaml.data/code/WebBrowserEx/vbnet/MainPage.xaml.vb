Partial Public Class MainPage
    Inherits UserControl

    Public Sub New()
        InitializeComponent()
    End Sub
    '<snippet10>
    Private Sub Button1_Click(ByVal sender As System.Object, _
        ByVal e As System.Windows.RoutedEventArgs)
        WB1.Navigate(New Uri("http://localhost/HTMLPage2.htm"))
        '</snippet10>
    End Sub
End Class