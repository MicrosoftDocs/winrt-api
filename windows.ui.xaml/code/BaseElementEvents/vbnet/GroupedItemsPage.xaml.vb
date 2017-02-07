' The Grouped Items Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234231

''' <summary>
''' A page that displays a grouped collection of items.
''' </summary>
Public NotInheritable Class GroupedItemsPage
    Inherits Common.LayoutAwarePage

    ''' <summary>
    ''' Populates the page with content passed during navigation.  Any saved state is also
    ''' provided when recreating a page from a prior session.
    ''' </summary>
    ''' <param name="navigationParameter">The parameter value passed to <see cref="Frame.Navigate"/>
    ''' when this page was initially requested.
    ''' </param>
    ''' <param name="pageState">A dictionary of state preserved by this page during an earlier
    ''' session.  This will be null the first time a page is visited.</param>
    Protected Overrides Sub LoadState(navigationParameter As Object, pageState As Dictionary(Of String, Object))

        ' TODO: Create an appropriate data model for your problem domain to replace the sample data
        Dim sampleDataGroups = Data.SampleDataSource.GetGroups(DirectCast(navigationParameter, String))
        Me.DefaultViewModel("Groups") = sampleDataGroups
    End Sub

    ''' <summary>
    ''' Invoked when a group header is clicked.
    ''' </summary>
    ''' <param name="sender">The Button used as a group header for the selected group.</param>
    ''' <param name="e">Event data that describes how the click was initiated.</param>
    Private Sub Header_Click(sender As Object, e As RoutedEventArgs)

        ' Determine what group the Button instance represents
        Dim group = DirectCast(sender, FrameworkElement).DataContext

        ' Navigate to the appropriate destination page, configuring the new page
        ' by passing required information as a navigation parameter
        Me.Frame.Navigate(GetType(GroupDetailPage), DirectCast(group, Data.SampleDataGroup).UniqueId)
    End Sub

    ''' <summary>
    ''' Invoked when an item within a group is clicked.
    ''' </summary>
    ''' <param name="sender">The GridView (or ListView when the application is snapped)
    ''' displaying the item clicked.</param>
    ''' <param name="e">Event data that describes the item clicked.</param>
    Private Sub ItemView_ItemClick(sender As Object, e As ItemClickEventArgs)

        ' Navigate to the appropriate destination page, configuring the new page
        ' by passing required information as a navigation parameter
        Dim itemId = DirectCast(e.ClickedItem, Data.SampleDataItem).UniqueId
        Me.Frame.Navigate(GetType(ItemDetailPage), itemId)
    End Sub

End Class
