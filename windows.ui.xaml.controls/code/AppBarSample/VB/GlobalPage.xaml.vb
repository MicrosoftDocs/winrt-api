' <SnippetGlobalPageCode>
Public NotInheritable Class GlobalPage
    Inherits Page

    ' <SnippetNavCommands>
    Dim rootPage As Page
    Protected Overrides Sub OnNavigatedTo(e As Navigation.NavigationEventArgs)
        rootPage = e.Parameter
        frame1.Navigate(GetType(Page1), Me)
    End Sub

    Private Sub Back_Click(sender As Object, e As RoutedEventArgs)
        If frame1.CanGoBack() = True Then
            frame1.GoBack()
        ElseIf rootPage IsNot Nothing AndAlso rootPage.Frame.CanGoBack() = True Then
            rootPage.Frame.GoBack()
        End If
    End Sub

    Private Sub Page1Button_Click(sender As Object, e As RoutedEventArgs)
        frame1.Navigate(GetType(Page1), Me)
    End Sub

    Private Sub Page2Button_Click(sender As Object, e As RoutedEventArgs)
        frame1.Navigate(GetType(Page2), Me)
    End Sub
    ' </SnippetNavCommands>
End Class
' </SnippetGlobalPageCode>