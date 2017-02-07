Partial Public Class MainPage
    Inherits UserControl
    '<snippet10> 
    Public Sub New()
        InitializeComponent()
        Dim myItems As String() = New String() {"Item 1", "Item 2", "Item 3", "Item 4", "Item 5"}
        myTreeView.DataContext = myItems
    End Sub
    Shared count As Integer = 1
    Private Sub Button_Click(ByVal sender As Object, ByVal e As RoutedEventArgs)
        Dim item As TreeViewItem = DirectCast(myTreeView.ItemContainerGenerator.ContainerFromIndex(3), TreeViewItem)
        item.IsExpanded = True
        If count < 5 Then
            item.Items.Add("Child " & count.ToString())
            count += 1
        End If
    End Sub
    '</snippet10> 
End Class
