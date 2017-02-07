using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace ProximityQuickstartCS
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        // <SnippetConnect_CS>
        // <SnippetActivate_CS>
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            DisplayNameTextBox.Text = Windows.Networking.Proximity.PeerFinder.DisplayName;
            Windows.Networking.Proximity.PeerFinder.ConnectionRequested += ConnectionRequested;

            // If activated from launch or from the background, create a peer connection.
            var args = e.Parameter as Windows.ApplicationModel.Activation.LaunchActivatedEventArgs;
            if (args != null && args.Kind == Windows.ApplicationModel.Activation.ActivationKind.Launch)
            {
                if (args.Arguments == "Windows.Networking.Proximity.PeerFinder:StreamSocket")
                {
                    AdvertiseForPeersButton_Click(null, null);
                }
            }
        }
        // </SnippetActivate_CS>

        protected override void OnNavigatingFrom(NavigatingCancelEventArgs e)
        {
            if (_started)
            {
                // Detach the callback handler (there can only be one PeerConnectProgress handler).
                Windows.Networking.Proximity.PeerFinder.TriggeredConnectionStateChanged -= TriggeredConnectionStateChanged;
                // Detach the incoming connection request event handler.
                Windows.Networking.Proximity.PeerFinder.ConnectionRequested -= ConnectionRequested;
                Windows.Networking.Proximity.PeerFinder.Stop();
                CloseSocket();
                _started = false;
            }
        }

        // Write a message to MessageBlock on the UI thread.
        private Windows.UI.Core.CoreDispatcher messageDispatcher = Window.Current.CoreWindow.Dispatcher;

        async private void WriteMessageText(string message, bool overwrite = false)
        {
            await messageDispatcher.RunAsync(Windows.UI.Core.CoreDispatcherPriority.Normal,
                () =>
                {
                    if (overwrite)
                        MessageBlock.Text = message;
                    else
                        MessageBlock.Text += message;
                });
        }

        bool _started = false;

        // Click event handler for "Advertise" button.
        private void AdvertiseForPeersButton_Click(object sender, RoutedEventArgs e)
        {
            if (_started) 
            {
                WriteMessageText("You are already advertising for a connection.\n");
                return; 
            }

            Windows.Networking.Proximity.PeerFinder.DisplayName = DisplayNameTextBox.Text;

            if ((Windows.Networking.Proximity.PeerFinder.SupportedDiscoveryTypes &
                 Windows.Networking.Proximity.PeerDiscoveryTypes.Triggered) ==
                 Windows.Networking.Proximity.PeerDiscoveryTypes.Triggered)
            {
                Windows.Networking.Proximity.PeerFinder.TriggeredConnectionStateChanged +=
                    TriggeredConnectionStateChanged;

                WriteMessageText("You can tap to connect a peer device that is " +
                                 "also advertising for a connection.\n");
            }
            else
            {
                WriteMessageText("Tap to connect is not supported.\n");
            }

            if ((Windows.Networking.Proximity.PeerFinder.SupportedDiscoveryTypes &
                 Windows.Networking.Proximity.PeerDiscoveryTypes.Browse) !=
                 Windows.Networking.Proximity.PeerDiscoveryTypes.Browse)
            {
                WriteMessageText("Peer discovery using Wi-Fi Direct is not supported.\n");
            }

           Windows.Networking.Proximity.PeerFinder.Start();
           _started = true;
        }

        private void TriggeredConnectionStateChanged(
            object sender,
            Windows.Networking.Proximity.TriggeredConnectionStateChangedEventArgs e)
        {
            if (e.State == Windows.Networking.Proximity.TriggeredConnectState.PeerFound)
            {
                WriteMessageText("Peer found. You may now pull your devices out of proximity.\n");
            }
            if (e.State == Windows.Networking.Proximity.TriggeredConnectState.Completed)
            {
                WriteMessageText("Connected. You may now send a message.\n");
                SendMessage(e.Socket);
            }
        }

        // Click event handler for "Browse" button.
        async private void FindPeersButton_Click(object sender, RoutedEventArgs e)
        {
            if ((Windows.Networking.Proximity.PeerFinder.SupportedDiscoveryTypes &
                 Windows.Networking.Proximity.PeerDiscoveryTypes.Browse) !=
                 Windows.Networking.Proximity.PeerDiscoveryTypes.Browse)
            {
                WriteMessageText("Peer discovery using Wi-Fi Direct is not supported.\n");
                return;
            }

            try
            {
                var peerInfoCollection = await Windows.Networking.Proximity.PeerFinder.FindAllPeersAsync();
                if (peerInfoCollection.Count > 0)
                {
                    // Connect to first peer found - example only.
                    // In your app, provide the user with a list of available peers.
                    ConnectToPeer(peerInfoCollection[0]);
                }
            }
            catch (Exception err)
            {
                WriteMessageText("Error finding peers: " + err.Message + "\n");
            }
        }

        async private void ConnectToPeer(Windows.Networking.Proximity.PeerInformation peerInfo)
        {
            WriteMessageText("Peer found. Connecting to " + peerInfo.DisplayName + "\n");
            try
            {
                Windows.Networking.Sockets.StreamSocket socket =
                    await Windows.Networking.Proximity.PeerFinder.ConnectAsync(peerInfo);

                WriteMessageText("Connection successful. You may now send messages.\n");
                SendMessage(socket);
            }
            catch (Exception err)
            {
                WriteMessageText("Connection failed: " + err.Message + "\n");
            }

            requestingPeer = null;
        }

        // Click event handler for "Stop" button.
        private void StopFindingPeersButton_Click(object sender, RoutedEventArgs e)
        {
            _started = false;
            Windows.Networking.Proximity.PeerFinder.Stop();
            if (proximitySocket != null) { CloseSocket(); }
        }

        // Handle external connection requests.
        Windows.Networking.Proximity.PeerInformation requestingPeer;

        private void ConnectionRequested(object sender,
            Windows.Networking.Proximity.ConnectionRequestedEventArgs e)
        {
            requestingPeer = e.PeerInformation;
            WriteMessageText("Connection requested by " + requestingPeer.DisplayName + ". " +
                "Click 'Accept Connection' to connect.");
        }

        private void AcceptConnectionButton_Click(object sender, RoutedEventArgs e)
        {
            if (requestingPeer == null)
            {
                WriteMessageText("No peer connection has been requested.");
                return;
            }

            ConnectToPeer(requestingPeer);
        }
        // </SnippetConnect_CS>

        // <SnippetSendMessage_CS>
        private void SendMessageButton_Click(object sender, RoutedEventArgs e)
        {
             if (proximitySocket != null)
            {
                SendMessageText();
            }
            else
            {
                WriteMessageText("You must enter proximity to send a message.\n");
            }
        }

        Windows.Networking.Sockets.StreamSocket proximitySocket;
        Windows.Storage.Streams.DataWriter dataWriter;

        // Reference socket streams for writing and reading messages.
        private void SendMessage(Windows.Networking.Sockets.StreamSocket socket)
        {
            // PeerFinder has not been started.
            if (!_started)
            {
                CloseSocket();
                return;
            }

            // Get the network socket from the proximity connection.
            proximitySocket = socket;

            // Create DataWriter for writing messages to peers.
            dataWriter = new Windows.Storage.Streams.DataWriter(proximitySocket.OutputStream);

            // Listen for messages from peers.
            Windows.Storage.Streams.DataReader dataReader =
                    new Windows.Storage.Streams.DataReader(proximitySocket.InputStream);
            StartReader(proximitySocket, dataReader);
        }


        // Send a message to the socket.
        private async void SendMessageText()
        {
            string msg = SendMessageTextBox.Text;

            if (msg.Length > 0)
            {
                var msgLength = dataWriter.MeasureString(msg);
                dataWriter.WriteInt32(msg.Length);
                dataWriter.WriteString(msg);
                try
                {
                    await dataWriter.StoreAsync();
                    WriteMessageText("Message sent: " + msg + "\n");
                }
                catch (Exception e)
                {
                    WriteMessageText("Send error: " + e.Message + "\n");
                    CloseSocket();
                }
            }
        }

        // Read out and print the message received from the socket.
        private async void StartReader(Windows.Networking.Sockets.StreamSocket socket,
           Windows.Storage.Streams.DataReader reader)
        {
            try
            {
                uint bytesRead = await reader.LoadAsync(sizeof(uint));
                if (bytesRead > 0)
                {
                    uint strLength = (uint)reader.ReadUInt32();
                    bytesRead = await reader.LoadAsync(strLength);
                    if (bytesRead > 0)
                    {
                        String message = reader.ReadString(strLength);
                        WriteMessageText("Received message: " + message + "\n");
                        StartReader(socket, reader); // Start another reader
                    }
                    else
                    {
                        WriteMessageText("The peer app closed the socket\n");
                        reader.Dispose();
                        CloseSocket();
                    }
                }
                else
                {
                    WriteMessageText("The peer app closed the socket\n");
                    reader.Dispose();
                    CloseSocket();
                }
            }
            catch 
            {
                WriteMessageText("The peer app closed the socket\n");
                reader.Dispose();
                CloseSocket();
            }
        }

        private void CloseSocket()
        {
            if (proximitySocket != null)
            {
                proximitySocket.Dispose();
                proximitySocket = null;
            }

            if (dataWriter != null)
            {
                dataWriter.Dispose();
                dataWriter = null;
            }
        }

        public void Dispose()
        {
            CloseSocket();
        }
        // </SnippetSendMessage_CS>
    }
}
