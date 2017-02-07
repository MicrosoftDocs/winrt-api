' The Group Detail Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234229

''' <summary>
''' A page that displays an overview of a single group, including a preview of the items
''' within the group.
''' </summary>
Public NotInheritable Class GroupDetailPage
    Inherits Common.LayoutAwarePage

    ''' <summary>
    ''' Populates the page with content passed during navigation.  Any saved state is also
    ''' provided when recreating a page from a prior session.
    ''' </summary>
    ''' <param name="navigationParameter">The parameter value passed to
    ''' <see cref="Frame.Navigate"/> when this page was initially requested.
    ''' </param>
    ''' <param name="pageState">A dictionary of state preserved by this page during an earlier
    ''' session.  This will be null the first time a page is visited.</param>
    Protected Overrides Sub LoadState(navigationParameter As Object, pageState As Dictionary(Of String, Object))

        ' TODO: Create an appropriate data model for your problem domain to replace the sample data
        Dim group = Data.SampleDataSource.GetGroup(DirectCast(navigationParameter, String))
        Me.DefaultViewModel("Group") = group
        Me.DefaultViewModel("Items") = group.Items
    End Sub

    ''' <summary>
    ''' Invoked when an item is clicked.
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
