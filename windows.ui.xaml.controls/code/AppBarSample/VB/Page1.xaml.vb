' <SnippetPage1Code>
Public NotInheritable Class Page1
    Inherits Page

    Dim rootPage As Page

    Protected Overrides Sub OnNavigatedTo(e As Navigation.NavigationEventArgs)
        rootPage = e.Parameter
    End Sub

End Class
' </SnippetPage1Code>