' The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

''' <summary>
''' An empty page that can be used on its own or navigated to within a Frame.
''' </summary>
Public NotInheritable Class SnippetsPage
    Inherits Page

    ''' <summary>
    ''' Invoked when this page is about to be displayed in a Frame.
    ''' </summary>
    ''' <param name="e">Event data that describes how this page was reached.  The Parameter
    ''' property is typically used to configure the page.</param>
    ''' 
    ' <SnippetAddButtonCode>
    Dim addButton As Button = Nothing
    Protected Overrides Sub OnNavigatedTo(e As Navigation.NavigationEventArgs)

        If rightPanel IsNot Nothing Then
            ' Create the button to add
            addButton = New Button()

            ' Apply the button style so that it looks like an AppBar button
            addButton.Style = App.Current.Resources("AddAppBarButtonStyle")

            ' Add the Click handler for the new button
            AddHandler addButton.Click, AddressOf Button_Click

            ' Add the button to the AppBar
            rightPanel.Children.Add(addButton)
        End If
    End Sub

    Private Sub Button_Click(sender As Object, e As RoutedEventArgs)
        ' Perform action here.
    End Sub
    ' </SnippetAddButtonCode>

    ' <SnippetRemoveButtonCode>
    Protected Overrides Sub OnNavigatingFrom(e As Navigation.NavigatingCancelEventArgs)
        If rightPanel IsNot Nothing Then

            ' Unhook the Click event handler for the button
            RemoveHandler addButton.Click, AddressOf Button_Click

            ' Remove the button from the AppBar
            rightPanel.Children.Remove(addButton)

        End If
    End Sub
    ' </SnippetRemoveButtonCode>

    ' <SnippetAppBarMenuCode>
    Private Sub SortMenuButton_Click(sender As Object, e As RoutedEventArgs)
        ' <SnippetAppBarMenu1>
        Dim popUp = New Popup()
        ' </SnippetAppBarMenu1>
        ' <SnippetAppBarMenu2>
        popUp.IsLightDismissEnabled = True
        ' </SnippetAppBarMenu2>

        ' <SnippetAppBarMenu3>
        Dim Panel = New StackPanel()
        Panel.Background = BottomAppBar.Background
        Panel.Height = 140
        Panel.Width = 180
        ' </SnippetAppBarMenu3>

        ' <SnippetAppBarMenu4>
        Panel.Transitions = New Windows.UI.Xaml.Media.Animation.TransitionCollection()
        Panel.Transitions.Add(New Windows.UI.Xaml.Media.Animation.PopupThemeTransition())
        ' </SnippetAppBarMenu4>

        ' <SnippetAppBarMenu5>
        Dim byRatingButton = New Button()
        byRatingButton.Content = "By rating"
        byRatingButton.Style = DirectCast(App.Current.Resources("TextButtonStyle"), Style)
        byRatingButton.Margin = New Thickness(20, 5, 20, 5)
        AddHandler byRatingButton.Click, AddressOf SortButton_Click
        Panel.Children.Add(byRatingButton)
        ' </SnippetAppBarMenu5>

        Dim byMatchButton = New Button()
        byMatchButton.Content = "By match"
        byMatchButton.Style = DirectCast(App.Current.Resources("TextButtonStyle"), Style)
        byMatchButton.Margin = New Thickness(20, 5, 20, 5)
        AddHandler byMatchButton.Click, AddressOf SortButton_Click
        Panel.Children.Add(byMatchButton)

        Dim byDistanceButton = New Button()
        byDistanceButton.Content = "By distance"
        byDistanceButton.Style = DirectCast(App.Current.Resources("TextButtonStyle"), Style)
        byDistanceButton.Margin = New Thickness(20, 5, 20, 5)
        AddHandler byDistanceButton.Click, AddressOf SortButton_Click
        Panel.Children.Add(byDistanceButton)

        ' <SnippetAppBarMenu6>
        popUp.Child = Panel
        ' </SnippetAppBarMenu6>
        ' <SnippetAppBarMenu7>
        popUp.HorizontalOffset = Window.Current.CoreWindow.Bounds.Right - Panel.Width - 4
        popUp.VerticalOffset = Window.Current.CoreWindow.Bounds.Bottom - BottomAppBar.ActualHeight - Panel.Height - 4
        ' </SnippetAppBarMenu7>

        ' <SnippetAppBarMenu8>
        popUp.IsOpen = True
        ' </SnippetAppBarMenu8>
    End Sub

    Private Sub SortButton_Click(sender As Object, e As RoutedEventArgs)
        ' Sort
    End Sub
    ' </SnippetAppBarMenuCode>

    ' <SnippetHideAppBarCommandsCode>
    Private Sub ToggleSwitch_Toggled(sender As Object, e As RoutedEventArgs)
        Dim toggle = DirectCast(sender, ToggleSwitch)

        If toggle.IsOn = True Then
            pinCommands.Visibility = Windows.UI.Xaml.Visibility.Visible
        Else
            pinCommands.Visibility = Windows.UI.Xaml.Visibility.Collapsed
        End If
    End Sub
    ' </SnippetHideAppBarCommandsCode>
End Class
