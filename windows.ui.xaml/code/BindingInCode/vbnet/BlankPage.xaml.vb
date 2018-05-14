NotInheritable Public Class BlankPage
    Inherits Page

    Protected Overrides Sub OnNavigatedTo(e As Navigation.NavigationEventArgs)
        '<SnippetBindingObject> 
        'Create the source string 
        Dim s As String = "Hello"

        'Create the binding description 
        Dim b As New Binding()
        b.Mode = BindingMode.OneTime
        b.Source = s

        'Attach the binding to the target 
        Dim MyText As New TextBlock()
        MyText.SetBinding(TextBlock.TextProperty, b)
        '</SnippetBindingObject> 
    End Sub

End Class
