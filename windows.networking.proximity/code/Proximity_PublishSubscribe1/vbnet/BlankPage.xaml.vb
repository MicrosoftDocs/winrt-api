' The Blank Page item template is documented at http:'go.microsoft.com/fwlink/?LinkId=234238

''' <summary>
''' An empty page that can be used on its own or navigated to within a Frame.
''' </summary>
Public NotInheritable Class BlankPage
    Inherits Page

    ' <SnippetInitialize_CS>
    Private proximityDevice As Windows.Networking.Proximity.ProximityDevice

    Public Sub New()
        Me.InitializeComponent()

        InitializeProximitySample()
    End Sub

    ''' <summary>
    ''' Invoked when this page is about to be displayed in a Frame.
    ''' </summary>
    ''' <param name="e">Event data that describes how this page was reached.  The Parameter
    ''' property is typically used to configure the page.</param>
    Protected Overrides Sub OnNavigatedTo(e As Navigation.NavigationEventArgs)

    End Sub

    ' Write a message to MessageBlock on the UI thread.
    Private Async Sub WriteMessageText(message As String, Optional overwrite As Boolean = False)
        Await Dispatcher.RunAsync(Windows.UI.Core.CoreDispatcherPriority.Normal,
            Sub()
                If (overwrite) Then
                    MessageBlock.Text = message
                Else
                    MessageBlock.Text &= message
                End If
            End Sub)
    End Sub

    Private Sub InitializeProximitySample()
        proximityDevice = Windows.Networking.Proximity.ProximityDevice.GetDefault()

        If proximityDevice Is Nothing Then
            WriteMessageText("Failed to initialized proximity device." & vbCrLf &
                             "Your device may not have proximity hardware.")
        End If
    End Sub
    ' </SnippetInitialize_CS>

    ' <SnippetPublishSubscribe_CS>
    Dim publishedMessageId As Long = -1
    Dim subscribedMessageId As Long = -1

    Private Sub PublishMessageButton_Click()
        ' Stop publishing the current message.
        If publishedMessageId <> -1 Then
            proximityDevice.StopPublishingMessage(publishedMessageId)
        End If

        publishedMessageId =
            proximityDevice.PublishMessage("Windows.SampleMessage", MessageTextBox.Text)
    End Sub

    Private Sub SubscribeForMessageButton_Click()
        ' Only subscribe for the message one time.
        If subscribedMessageId = -1 Then
            subscribedMessageId =
                proximityDevice.SubscribeForMessage("Windows.SampleMessage", AddressOf messageReceived)
        End If
    End Sub

    Private Sub messageReceived(device As Windows.Networking.Proximity.ProximityDevice,
                                message As Windows.Networking.Proximity.ProximityMessage)

        WriteMessageText("Message received: " & message.DataAsString & vbCrLf)
    End Sub

    Private Sub StopPublishingMessageButton_Click()
        proximityDevice.StopPublishingMessage(publishedMessageId)
    End Sub

    Private Sub StopSubscribingForMessageButton_Click()
        proximityDevice.StopSubscribingForMessage(subscribedMessageId)
    End Sub
    ' </SnippetPublishSubscribe_CS>

End Class
