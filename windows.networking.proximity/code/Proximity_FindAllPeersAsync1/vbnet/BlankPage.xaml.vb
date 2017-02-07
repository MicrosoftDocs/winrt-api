' The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

''' <summary>
''' An empty page that can be used on its own or navigated to within a Frame.
''' </summary>
Public NotInheritable Class MainPage
    Inherits Page

    ' <SnippetConnect_CS>
    ' <SnippetActivate_CS>
    Protected Overrides Sub OnNavigatedTo(e As Navigation.NavigationEventArgs)
        DisplayNameTextBox.Text = Windows.Networking.Proximity.PeerFinder.DisplayName
        AddHandler Windows.Networking.Proximity.PeerFinder.ConnectionRequested, AddressOf ConnectionRequested

        ' If activated from launch or from the background, create a peer connection.
        Dim args = TryCast(e.Parameter, Windows.ApplicationModel.Activation.LaunchActivatedEventArgs)
        If args IsNot Nothing AndAlso args.Kind = Windows.ApplicationModel.Activation.ActivationKind.Launch Then

            If args.Arguments = "Windows.Networking.Proximity.PeerFinder:StreamSocket" Then
                AdvertiseForPeersButton_Click()
            End If
        End If
    End Sub
    ' </SnippetActivate_CS>

    Protected Overrides Sub OnNavigatingFrom(e As Navigation.NavigatingCancelEventArgs)
        If _started Then
            ' Detach the callback handler (there can only be one PeerConnectProgress handler).
            RemoveHandler Windows.Networking.Proximity.PeerFinder.TriggeredConnectionStateChanged, AddressOf TriggeredConnectionStateChanged
            ' Detach the incoming connection request event handler.
            RemoveHandler Windows.Networking.Proximity.PeerFinder.ConnectionRequested, AddressOf ConnectionRequested
            Windows.Networking.Proximity.PeerFinder.Stop()
            CloseSocket()
            _started = False
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

    Private _started As Boolean = False

    ' Click event handler for "Advertise" button.
    Private Sub AdvertiseForPeersButton_Click()

        If _started Then
            WriteMessageText("You are already advertising for a connection." & vbCrLf)
            Return
        End If

        Windows.Networking.Proximity.PeerFinder.DisplayName = DisplayNameTextBox.Text

        If ((Windows.Networking.Proximity.PeerFinder.SupportedDiscoveryTypes And
             Windows.Networking.Proximity.PeerDiscoveryTypes.Triggered) =
             Windows.Networking.Proximity.PeerDiscoveryTypes.Triggered) Then

            AddHandler Windows.Networking.Proximity.PeerFinder.TriggeredConnectionStateChanged,
                AddressOf TriggeredConnectionStateChanged

            WriteMessageText("You can tap to connect a peer device that is " &
                             "also advertising for a connection." & vbCrLf)
        Else
            WriteMessageText("Tap to connect is not supported." & vbCrLf)
        End If

        If (Windows.Networking.Proximity.PeerFinder.SupportedDiscoveryTypes And
            Windows.Networking.Proximity.PeerDiscoveryTypes.Browse) <>
            Windows.Networking.Proximity.PeerDiscoveryTypes.Browse Then

            WriteMessageText("Peer discovery using Wifi-Direct is not supported." & vbCrLf)
        End If

        Windows.Networking.Proximity.PeerFinder.Start()
        _started = True
    End Sub

    Private Sub TriggeredConnectionStateChanged(
        sender As Object,
        e As Windows.Networking.Proximity.TriggeredConnectionStateChangedEventArgs)

        If e.State = Windows.Networking.Proximity.TriggeredConnectState.PeerFound Then

            WriteMessageText("Peer found. You may now pull your devices out of proximity." & vbCrLf)
        End If

        If e.State = Windows.Networking.Proximity.TriggeredConnectState.Completed Then
            WriteMessageText("Connected. You may now send a message." & vbCrLf)
            SendMessage(e.Socket)
        End If
    End Sub

    ' Click event handler for "Browse" button.
    Private Async Sub FindPeersButton_Click()
        If (Windows.Networking.Proximity.PeerFinder.SupportedDiscoveryTypes And
            Windows.Networking.Proximity.PeerDiscoveryTypes.Browse) <>
            Windows.Networking.Proximity.PeerDiscoveryTypes.Browse Then

            WriteMessageText("Peer discovery using Wifi-Direct is not supported." & vbCrLf)
            Return
        End If

        Try
            Dim peerInfoCollection = Await Windows.Networking.Proximity.PeerFinder.FindAllPeersAsync()
            If peerInfoCollection.Count > 0 Then
                ' Connect to first peer found - example only.
                ' In your app, provide the user with a list of available peers.
                ConnectToPeer(peerInfoCollection(0))
            End If
        Catch err As Exception
            WriteMessageText("Error finding peers: " & err.Message & vbCrLf)
        End Try
    End Sub

    Private Async Sub ConnectToPeer(peerInfo As Windows.Networking.Proximity.PeerInformation)

        WriteMessageText("Peer found. Connecting to " & peerInfo.DisplayName & vbCrLf)
        Try
            Dim socket = Await Windows.Networking.Proximity.PeerFinder.ConnectAsync(peerInfo)

            WriteMessageText("Connection successful. You may now send messages." & vbCrLf)
            SendMessage(socket)
        Catch err As Exception
            WriteMessageText("Connection failed: " & err.Message & vbCrLf)
        End Try

        requestingPeer = Nothing
    End Sub

    ' Click event handler for "Stop" button.
    Private Sub StopFindingPeersButton_Click()

        _started = False
        Windows.Networking.Proximity.PeerFinder.Stop()
        If proximitySocket IsNot Nothing Then CloseSocket()
    End Sub

    ' Handle external connection requests.
    Private requestingPeer As Windows.Networking.Proximity.PeerInformation

    Private Sub ConnectionRequested(sender As Object,
        e As Windows.Networking.Proximity.ConnectionRequestedEventArgs)

        requestingPeer = e.PeerInformation

        WriteMessageText("Connection requested by " & requestingPeer.DisplayName & ". " &
            "Click 'Accept Connection' to connect.")
    End Sub

    Private Sub AcceptConnectionButton_Click()
        If requestingPeer Is Nothing Then
            WriteMessageText("No peer connection has been requested.")
            Return
        End If

        ConnectToPeer(requestingPeer)
    End Sub
    ' </SnippetConnect_CS>

    ' <SnippetSendMessage_CS>
    Private Sub SendMessageButton_Click()

        If proximitySocket IsNot Nothing Then
            SendMessageText()
        Else
            WriteMessageText("You must enter proximity to send a message." & vbCrLf)
        End If
    End Sub

    Private proximitySocket As Windows.Networking.Sockets.StreamSocket
    Private dataWriter As Windows.Storage.Streams.DataWriter

    ' Reference socket streams for writing and reading messages.
    Private Sub SendMessage(socket As Windows.Networking.Sockets.StreamSocket)

        ' PeerFinder has not been started.
        If Not _started Then
            CloseSocket()
            Return
        End If

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
        Dim msg = SendMessageTextBox.Text

        If msg.Length > 0 Then
            Dim msgLength = dataWriter.MeasureString(msg)
            dataWriter.WriteInt32(msg.Length)
            dataWriter.WriteString(msg)
            Try
                Await dataWriter.StoreAsync()
                WriteMessageText("Message sent: " & msg & vbCrLf)
            Catch e As Exception
                WriteMessageText("Send error: " & e.Message & vbCrLf)
                CloseSocket()
            End Try
        End If
    End Sub

    ' Read out and print the message received from the socket.
    Private Async Sub StartReader(socket As Windows.Networking.Sockets.StreamSocket,
       reader As Windows.Storage.Streams.DataReader)

        Try
            Dim bytesRead As UInteger = Await reader.LoadAsync(4)
            If bytesRead > 0 Then
                Dim strLength = CType(reader.ReadUInt32(), UInteger)
                bytesRead = Await reader.LoadAsync(strLength)
                If (bytesRead > 0) Then
                    Dim message = reader.ReadString(strLength)
                    WriteMessageText("Received message: " & message & vbCrLf)
                    StartReader(socket, reader) ' Start another reader
                Else
                    WriteMessageText("The peer app closed the socket" & vbCrLf)
                    reader.Dispose()
                    CloseSocket()
                End If
            Else
                WriteMessageText("The peer app closed the socket" & vbCrLf)
                reader.Dispose()
                CloseSocket()
            End If
        Catch
            WriteMessageText("The peer app closed the socket" & vbCrLf)
            reader.Dispose()
            CloseSocket()
        End Try
    End Sub

    Private Sub CloseSocket()
        If proximitySocket IsNot Nothing Then
            proximitySocket.Dispose()
            proximitySocket = Nothing
        End If

        If dataWriter IsNot Nothing Then
            dataWriter.Dispose()
            dataWriter = Nothing
        End If
    End Sub

    Public Sub Dispose()
        CloseSocket()
    End Sub
    ' </SnippetSendMessage_CS>

End Class
