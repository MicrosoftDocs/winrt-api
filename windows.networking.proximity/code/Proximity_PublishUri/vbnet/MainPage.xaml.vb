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
    Protected Overrides Sub OnNavigatedTo(e As Navigation.NavigationEventArgs)

    End Sub


    ' <SnippetInitialize>
    Private proximityDevice As Windows.Networking.Proximity.ProximityDevice

    Public Sub New()
        Me.InitializeComponent()

        initializeProximitySample()
    End Sub

    Private Sub initializeProximitySample()
        proximityDevice = Windows.Networking.Proximity.ProximityDevice.GetDefault()

        If proximityDevice Is Nothing Then
            WriteMessageText("Failed to initialized proximity device." & vbCrLf &
                             "Your device may not have proximity hardware.")
        End If
    End Sub

    ' Write a message to MessageBlock on the UI thread.
    Private Async Sub WriteMessageText(message As String, Optional overwrite As Boolean = False)
        Await Dispatcher.RunAsync(Windows.UI.Core.CoreDispatcherPriority.Normal,
                Sub()
                    If overwrite Then
                        MessageBlock.Text = message
                    Else
                        MessageBlock.Text &= message
                    End If
                End Sub)
    End Sub
    ' </SnippetInitialize>

    ' <SnippetPublishSubscribeUri>
    Private publishedUriId As Long = -1

    Private Sub PublishUriButton_Click(sender As Object, e As RoutedEventArgs)
        ' Stop publishing the current message.
        If publishedUriId <> -1 Then
            proximityDevice.StopPublishingMessage(publishedUriId)
        End If

        publishedUriId =
            proximityDevice.PublishUriMessage(New Uri("http:'www.microsoft.com"))
    End Sub

    Private Sub StopPublishingUriButton_Click()
        proximityDevice.StopPublishingMessage(publishedUriId)
    End Sub
    ' </SnippetPublishSubscribeUri>

End Class

Class Exclude
    ' <SnippetPublishSubscribeUri2>
    Private publishedUriId As Long = -1

    Private Sub PublishUriButton_Click(sender As Object, e As RoutedEventArgs)
        ' Stop publishing the current message.
        If publishedUriId <> -1 Then
            proximityDevice.StopPublishingMessage(publishedUriId)
        End If

        publishedUriId =
            proximityDevice.PublishUriMessage(New Uri("http:'www.microsoft.com"),
                                              AddressOf UriTransmitted)
    End Sub

    Private Sub UriTransmitted(
	sender As Windows.Networking.Proximity.ProximityDevice,
        messageId As Long)

	' The Uri has been successfully transmitted
    End Sub

    Private Sub StopPublishingUriButton_Click()
        proximityDevice.StopPublishingMessage(publishedUriId)
    End Sub
    ' </SnippetPublishSubscribeUri2>
End Class
