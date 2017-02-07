' The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

''' <summary>
''' An empty page that can be used on its own or navigated to within a Frame.
''' </summary>
Public NotInheritable Class WebViewPage
    Inherits Page

    ''' <summary>
    ''' Invoked when this page is about to be displayed in a Frame.
    ''' </summary>
    ''' <param name="e">Event data that describes how this page was reached.  The Parameter
    ''' property is typically used to configure the page.</param>
    Protected Overrides Sub OnNavigatedTo(e As Navigation.NavigationEventArgs)

    End Sub

    ' <SnippetAppBarOpenClose>
    Private Sub AppBar_Opened(sender As Object, e As Object) Handles BottomAppBar.Opened
        Dim wvb As New WebViewBrush()
        wvb.SourceName = "contentView"
        wvb.Redraw()
        contentViewRect.Fill = wvb
        contentView.Visibility = Windows.UI.Xaml.Visibility.Collapsed
    End Sub

    Private Sub AppBar_Closed(sender As Object, e As Object) Handles BottomAppBar.Closed
        contentView.Visibility = Windows.UI.Xaml.Visibility.Visible
        contentViewRect.Fill = New SolidColorBrush(Windows.UI.Colors.Transparent)
    End Sub

    Private Sub Refresh_Click(sender As Object, e As RoutedEventArgs)
        contentView.Navigate(New Uri("http://www.contoso.com"))
        bottomAppBar.IsOpen = False
    End Sub
    ' </SnippetAppBarOpenClose>

End Class
