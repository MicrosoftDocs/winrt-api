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

End Class


Class exclude0
    Inherits Page

    Private MessageBlock As TextBlock
    Private SendMessageButton As Button
    Private StartFindingPeersButton As Button
    Private SendMessageTextBlock As TextBlock

    ' <SnippetArriveDepart>
    Dim proximityDevice As Windows.Networking.Proximity.ProximityDevice

    Private Sub InitializeProximityDevice()

        proximityDevice = Windows.Networking.Proximity.ProximityDevice.GetDefault()

        If proximityDevice IsNot Nothing Then
            AddHandler proximityDevice.DeviceArrived, AddressOf ProximityDeviceArrived
            AddHandler proximityDevice.DeviceDeparted, AddressOf ProximityDeviceDeparted

            WriteMessageText("Proximity device initialized." & vbTab)
        Else
            WriteMessageText("Failed to initialized proximity device." & vbTab)
        End If
    End Sub

    Private Sub ProximityDeviceArrived(device As Windows.Networking.Proximity.ProximityDevice)
        WriteMessageText("Proximate device arrived. id = " & device.DeviceId & vbTab)
    End Sub

    Private Sub ProximityDeviceDeparted(device As Windows.Networking.Proximity.ProximityDevice)
        WriteMessageText("Proximate device departed. id = " & device.DeviceId & vbTab)
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
    ' </SnippetArriveDepart>
End Class

Class exclude3
    Inherits Page

    Private MessageBlock As TextBlock
    Private SendMessageButton As Button
    Private StartFindingPeersButton As Button
    Private SendMessageTextBlock As TextBlock

    ' <SnippetConnect>
    ' Click event for "Start" button.

    Private Sub StartFindingPeersButton_Click(sender As Object, e As RoutedEventArgs)

        If ((Windows.Networking.Proximity.PeerFinder.SupportedDiscoveryTypes &
             Windows.Networking.Proximity.PeerDiscoveryTypes.Triggered) =
             Windows.Networking.Proximity.PeerDiscoveryTypes.Triggered) Then

            Windows.Networking.Proximity.PeerFinder.Start()

            AddHandler Windows.Networking.Proximity.PeerFinder.TriggeredConnectionStateChanged,
                AddressOf TriggeredConnectionStateChanged

            WriteMessageText("Waiting for peers. Enter proximity to connect. " &
                "Call PeerFinder.start() on the peer to send and receive messages." & vbTab)
        Else
            WriteMessageText("Peer discovery using tapping is not supported." & vbTab)
        End If
    End Sub

    Private Sub TriggeredConnectionStateChanged(sender As Object,
        e As Windows.Networking.Proximity.TriggeredConnectionStateChangedEventArgs)

        If e.State = Windows.Networking.Proximity.TriggeredConnectState.Completed Then
            WriteMessageText("Connected. You may now send a message." & vbTab)
            SendMessage(e.Socket)
        End If
    End Sub

    Private proximitySocket As Windows.Networking.Sockets.StreamSocket
    Private dataWriter As Windows.Storage.Streams.DataWriter

    ' Reference socket streams for writing and reading messages.
    Private Sub SendMessage(socket As Windows.Networking.Sockets.StreamSocket)
        ' Get the network socket from the proximity connection.
        proximitySocket = socket

        ' Create DataWriter for writing messages to peers.
        dataWriter = New Windows.Storage.Streams.DataWriter(proximitySocket.OutputStream)

        ' Listen for messages from peers.
        Dim dataReader = New Windows.Storage.Streams.DataReader(proximitySocket.InputStream)
        StartReader(proximitySocket, dataReader)
    End Sub

    ' Send a message to the socket.
    Private Async Sub SendMessageText()
        Dim msg = SendMessageTextBlock.Text

        If msg.Length > 0 Then
            Dim msgLength = dataWriter.MeasureString(msg)
            dataWriter.WriteInt32(msg.Length)
            dataWriter.WriteString(msg)
            Try
                Await dataWriter.StoreAsync()
                WriteMessageText("Message sent: " & msg & vbTab)
            Catch e As Exception
                WriteMessageText("Send error: " & e.Message & vbTab)
            End Try
        End If
    End Sub

    ' Read out and print the message received from the socket.
    Private Async Sub StartReader(
        socket As Windows.Networking.Sockets.StreamSocket,
        reader As Windows.Storage.Streams.DataReader)

        Dim initialLength As UInteger = 4

        Try
            Await reader.LoadAsync(initialLength)
            Dim msgLength = CType(reader.ReadInt32(), UInteger)

            Try
                Await reader.LoadAsync(msgLength)
                Dim message = reader.ReadString(msgLength)
                WriteMessageText("Received message: " & message & vbTab)

                ' After receiving a message, listen for the next message.
                StartReader(socket, reader)
            Catch e As Exception
                WriteMessageText("Error: " & e.Message & vbTab)
                socket.Dispose()
            End Try
        Catch e As Exception
            WriteMessageText("Error: " & e.Message & vbTab)
            socket.Dispose()
        End Try
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
    ' </SnippetConnect>
End Class

Class exclude1
    Inherits Page

    Private PublishMessageButton As Button
    Private SubscribeForMessageButton As Button
    Private StopSubscribingForMessageButton As Button
    Private StopPublishingMessageButton As Button
    Private MessageBlock As TextBlock
    Private MessageTextBlock As TextBlock

    ' <SnippetPublishSubscribe>
    Private proximityDevice As Windows.Networking.Proximity.ProximityDevice
    Private publishedMessageId As Long = -1
    Private subscribedMessageId As Long = -1

    Private Sub initializeProximityDevice()
        proximityDevice = Windows.Networking.Proximity.ProximityDevice.GetDefault()

        If proximityDevice IsNot Nothing Then
            AddHandler PublishMessageButton.Click, AddressOf PublishMessage
            AddHandler SubscribeForMessageButton.Click, AddressOf SubscribeForMessage
            AddHandler StopSubscribingForMessageButton.Click, AddressOf StopSubscribingForMessage
            AddHandler StopPublishingMessageButton.Click, AddressOf StopPublishingMessage
        Else
            WriteMessageText("Failed to initialized proximity device." & vbTab)
        End If
    End Sub

    Private Sub PublishMessage(sender As Object, e As RoutedEventArgs)
        ' Stop publishing the current message.
        If publishedMessageId <> -1 Then
            proximityDevice.StopPublishingMessage(publishedMessageId)
        End If

        publishedMessageId =
            proximityDevice.PublishMessage("Windows.SampleMessage", MessageTextBlock.Text)
    End Sub

    Private Sub SubscribeForMessage(sender As Object, e As RoutedEventArgs)
        ' Only subscribe for the message one time.
        If subscribedMessageId = -1 Then
            subscribedMessageId =
            proximityDevice.SubscribeForMessage("Windows.SampleMessage", AddressOf messageReceived)
        End If
    End Sub

    Private Sub messageReceived(
        device As Windows.Networking.Proximity.ProximityDevice,
        message As Windows.Networking.Proximity.ProximityMessage)

        MessageBlock.Text &= "Message received: " & message.DataAsString & vbTab
    End Sub

    Private Sub StopSubscribingForMessage(sender As Object, e As RoutedEventArgs)
        proximityDevice.StopSubscribingForMessage(subscribedMessageId)
        subscribedMessageId = -1
    End Sub

    Private Sub StopPublishingMessage(sender As Object, e As RoutedEventArgs)
        proximityDevice.StopPublishingMessage(publishedMessageId)
        publishedMessageId = -1
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
    ' </SnippetPublishSubscribe>
End Class

Class exclude5
    Inherits Page

    Private PublishMessageButton As Button
    Private SubscribeForMessageButton As Button
    Private StopSubscribingForMessageButton As Button
    Private StopPublishingMessageButton As Button
    Private MessageBlock As TextBlock
    Private MessageTextBlock As TextBlock

    ' <SnippetPublishSubscribe2>
    Private proximityDevice As Windows.Networking.Proximity.ProximityDevice
    Private publishedMessageId As Long = -1
    Private subscribedMessageId As Long = -1

    Private Sub initializeProximityDevice()
        proximityDevice = Windows.Networking.Proximity.ProximityDevice.GetDefault()

        If proximityDevice IsNot Nothing Then
            AddHandler PublishMessageButton.Click, AddressOf PublishMessage
            AddHandler SubscribeForMessageButton.Click, AddressOf SubscribeForMessage
            AddHandler StopSubscribingForMessageButton.Click, AddressOf StopSubscribingForMessage
            AddHandler StopPublishingMessageButton.Click, AddressOf StopPublishingMessage
        Else
            WriteMessageText("Failed to initialized proximity device." & vbTab)
        End If
    End Sub

    Private Sub PublishMessage(sender As Object, e As RoutedEventArgs)
        ' Stop publishing the current message.
        If publishedMessageId <> -1 Then
            proximityDevice.StopPublishingMessage(publishedMessageId)
        End If

        publishedMessageId =
            proximityDevice.PublishMessage("Windows.SampleMessage", MessageTextBlock.Text,
                                           AddressOf MessagePublished)
    End Sub

    Private Sub MessagePublished(
	sender As Windows.Networking.Proximity.ProximityDevice,
        messageId As Long)

	' The message has been successfully published.
    End Sub

    Private Sub SubscribeForMessage(sender As Object, e As RoutedEventArgs)
        ' Only subscribe for the message one time.
        If subscribedMessageId = -1 Then
            subscribedMessageId =
            proximityDevice.SubscribeForMessage("Windows.SampleMessage", AddressOf messageReceived)
        End If
    End Sub

    Private Sub messageReceived(
        device As Windows.Networking.Proximity.ProximityDevice,
        message As Windows.Networking.Proximity.ProximityMessage)

        MessageBlock.Text &= "Message received: " & message.DataAsString & vbTab
    End Sub

    Private Sub StopSubscribingForMessage(sender As Object, e As RoutedEventArgs)
        proximityDevice.StopSubscribingForMessage(subscribedMessageId)
        subscribedMessageId = -1
    End Sub

    Private Sub StopPublishingMessage(sender As Object, e As RoutedEventArgs)
        proximityDevice.StopPublishingMessage(publishedMessageId)
        publishedMessageId = -1
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
    ' </SnippetPublishSubscribe2>
End Class
