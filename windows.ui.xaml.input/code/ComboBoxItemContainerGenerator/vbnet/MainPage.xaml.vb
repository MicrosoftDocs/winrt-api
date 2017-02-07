
Partial Public Class MainPage
    Inherits UserControl
    '<snippetCodeBehind>
    Public Sub New()
        InitializeComponent()
        Dim fonts As New System.Collections.ObjectModel.ObservableCollection(Of FontFamily)(
            {New FontFamily("Arial"), New FontFamily("Times New Roman"), New FontFamily("Courier New")})
        CB.DataContext = fonts
    End Sub

    Private Sub Button_Click(ByVal sender As Object, ByVal e As RoutedEventArgs)
        Dim selectedItemContainer As ComboBoxItem =
            DirectCast(CB.ItemContainerGenerator.ContainerFromItem(CB.SelectedItem), ComboBoxItem)
        If selectedItemContainer IsNot Nothing Then
            selectedItemContainer.FontFamily = DirectCast(CB.SelectedItem, FontFamily)
        End If
    End Sub
    '</snippetCodeBehind>
End Class
