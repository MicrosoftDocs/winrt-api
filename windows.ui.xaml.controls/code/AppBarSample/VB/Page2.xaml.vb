' <SnippetPage2Code>
Public NotInheritable Class Page2
    Inherits Page

    Dim rootPage As Page

    Protected Overrides Sub OnNavigatedTo(e As Navigation.NavigationEventArgs)
        rootPage = e.Parameter
    End Sub

    ' This is the handler for the AppBar button that is only available on this page.
    Private Async Sub StarButton_Click(sender As Object, e As RoutedEventArgs)
        Dim dialog As New Windows.UI.Popups.MessageDialog("You're a Superstar!")
        Await dialog.ShowAsync()
    End Sub
End Class
' </SnippetPage2Code>