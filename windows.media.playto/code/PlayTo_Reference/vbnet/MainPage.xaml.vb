' The Blank Page item template is documented at http:'go.microsoft.com/fwlink/?LinkId=234238

''' <summary>
''' An empty page that can be used on its own or navigated to within a Frame.
''' </summary>
Public NotInheritable Class MainPage
    Inherits Page

    ''' <summary>
    ''' Invoked when this page is about to be displayed in a Frame.
    ''' </summary>
    ''' <param name="e">Event data that describes how this page was reached.  The Parameter
    ''' property is typically used to configure the page.</param>

    Private mediaElement As Windows.UI.Xaml.Controls.MediaElement
    Private messageBlock As Windows.UI.Xaml.Controls.TextBlock

    ' <SnippetSourceRequested>
    ' Play To Contract

    Private ptm As Windows.Media.PlayTo.PlayToManager =
            Windows.Media.PlayTo.PlayToManager.GetForCurrentView()

    Protected Overrides Sub OnNavigatedTo(e As Navigation.NavigationEventArgs)
        AddHandler ptm.SourceRequested, AddressOf sourceRequestHandler
    End Sub

    Private Sub sourceRequestHandler(
        sender As Windows.Media.PlayTo.PlayToManager,
        e As Windows.Media.PlayTo.PlayToSourceRequestedEventArgs)

        Try
            e.SourceRequest.SetSource(mediaElement.PlayToSource)
        Catch ex As Exception
            messageBlock.Text &= "Exception encountered: " & ex.Message & vbCrLf
        End Try
    End Sub
    ' </SnippetSourceRequested>
End Class
' exclude from the running application

Class exclude1
    Inherits Page

    Private mediaElement As Windows.UI.Xaml.Controls.MediaElement
    Private messageBlock As Windows.UI.Xaml.Controls.TextBlock
    Private playToDeviceIconImage As Windows.UI.Xaml.Controls.Image
    Private playToDeviceFriendlyNameBlock As Windows.UI.Xaml.Controls.TextBlock

' <SnippetPlayToEvents>
    Private ptm As Windows.Media.PlayTo.PlayToManager =
            Windows.Media.PlayTo.PlayToManager.GetForCurrentView()

    Protected Overrides Sub OnNavigatedTo(e As Navigation.NavigationEventArgs)
        AddHandler ptm.SourceRequested, AddressOf sourceRequestHandlerWithEvents
        AddHandler ptm.SourceSelected, AddressOf sourceSelectedHandler
    End Sub

    Private Sub sourceRequestHandlerWithEvents(
        sender As Windows.Media.PlayTo.PlayToManager,
        e As Windows.Media.PlayTo.PlayToSourceRequestedEventArgs)

        Try
            Dim controller = mediaElement.PlayToSource

            AddHandler controller.Connection.Error, AddressOf playToConnectionError
            AddHandler controller.Connection.StateChanged, AddressOf playToConnectionStageChanged
            AddHandler controller.Connection.Transferred, AddressOf playToConnectionTransferred

            e.SourceRequest.SetSource(controller)
        Catch ex As Exception
            messageBlock.Text &= "Exception encountered: " & ex.Message & vbCrLf
        End Try
    End Sub

    ' Called when the user selects a Play To device to stream to.

    Private Sub sourceSelectedHandler(
        sender As Windows.Media.PlayTo.PlayToManager,
        e As Windows.Media.PlayTo.PlayToSourceSelectedEventArgs)

        If mediaElement.Name = "iplayer" Then
            If Not e.SupportsImage Then
                messageBlock.Text &= e.FriendlyName & " does not support streaming images. " &
                                     "Please select a different device."
                Return
            End If
        End If

        If mediaElement.Name = "vplayer" Then
            If Not e.SupportsVideo Then
                messageBlock.Text &= e.FriendlyName & " does not support streaming video. " &
                                     "Please select a different device."
                Return
            End If
        End If

        If mediaElement.Name = "aplayer" Then
            If Not e.SupportsAudio Then
                messageBlock.Text &= e.FriendlyName & " does not support streaming audio. " &
                                     "Please select a different device."
                Return
            End If
        End If

        Dim iconStream = e.Icon
        Dim iconBitmap = New Windows.UI.Xaml.Media.Imaging.BitmapImage()
        iconBitmap.SetSource(iconStream)
        playToDeviceIconImage.Source = iconBitmap

        playToDeviceFriendlyNameBlock.Text = e.FriendlyName
    End Sub

    Private Sub playToConnectionError(
        connection As Windows.Media.PlayTo.PlayToConnection,
        e As Windows.Media.PlayTo.PlayToConnectionErrorEventArgs)

        If e.Code = Windows.Media.PlayTo.PlayToConnectionError.DeviceError OrElse
            e.Code = Windows.Media.PlayTo.PlayToConnectionError.DeviceNotResponding Then

            messageBlock.Text &= "Error occurred. Disconnecting." & vbCrLf
        End If

        messageBlock.Text &= "Error: Message = " & e.Message.ToString() & vbCrLf
    End Sub

    Private Sub playToConnectionStageChanged(
        connection As Windows.Media.PlayTo.PlayToConnection,
        e As Windows.Media.PlayTo.PlayToConnectionStateChangedEventArgs)

        messageBlock.Text &= "StateChanged: PreviousState = " & e.PreviousState.ToString() & vbCrLf
        messageBlock.Text &= "StateChanged: CurrentState = " & e.CurrentState.ToString() & vbCrLf
    End Sub

    Private Sub playToConnectionTransferred(
        connection As Windows.Media.PlayTo.PlayToConnection,
        e As Windows.Media.PlayTo.PlayToConnectionTransferredEventArgs)

        messageBlock.Text &= "Transferred: PreviousSource = " & e.PreviousSource.ToString() & vbCrLf
        messageBlock.Text &= "Transferred: CurrentSource = " & e.CurrentSource.ToString() & vbCrLf
    End Sub
    ' </SnippetPlayToEvents>
End Class

' exclude from the running application
Class exclude2
    Inherits Page

    Private mediaElement As Windows.UI.Xaml.Controls.MediaElement
    ' <SnippetDeferral>
    Private ptm As Windows.Media.PlayTo.PlayToManager =
        Windows.Media.PlayTo.PlayToManager.GetForCurrentView()

    Protected Overrides Sub OnNavigatedTo(e As Navigation.NavigationEventArgs)
        AddHandler ptm.SourceRequested, AddressOf sourceRequestHandlerDeferred
    End Sub

    Private Async Sub sourceRequestHandlerDeferred(
        sender As Windows.Media.PlayTo.PlayToManager,
        e As Windows.Media.PlayTo.PlayToSourceRequestedEventArgs)

        Dim deferral = e.SourceRequest.GetDeferral()

        ' Async call to get source media
        Dim element = Await getMediaElementAsync()
        e.SourceRequest.SetSource(element.PlayToSource)

        deferral.Complete()
    End Sub
    ' </SnippetDeferral>

    Function getMediaElementAsync() As System.Threading.Tasks.Task(Of Windows.UI.Xaml.Controls.MediaElement)
        Dim result = New System.Threading.Tasks.Task(Of Windows.UI.Xaml.Controls.MediaElement)(Function() mediaElement)
        Return result
    End Function
End Class

Class exclude3

    ' <SnippetShowPlayToUI>
    Private Sub showPlayTo()
        Windows.Media.PlayTo.PlayToManager.ShowPlayToUI()
    End Sub
    ' </SnippetShowPlayToUI>

End Class
