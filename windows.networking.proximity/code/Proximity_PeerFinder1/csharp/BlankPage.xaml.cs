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

namespace WifiDirectSampleCS
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class BlankPage : Page
    {
        public BlankPage()
        {
            this.InitializeComponent();
        }

        /// <summary>
        /// Invoked when this page is about to be displayed in a Frame.
        /// </summary>
        /// <param name="e">Event data that describes how this page was reached.  The Parameter
        /// property is typically used to configure the page.</param>
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
        }

        // <SnippetConnect_CS>
        // Write a message to MessageBlock on the UI thread.
        private Windows.UI.Core.CoreDispatcher messageDispatcher = Window.Current.CoreWindow.Dispatcher;

        private void WriteMessageText(string message, bool overwrite = false)
        {
            messageDispatcher.InvokeAsync(Windows.UI.Core.CoreDispatcherPriority.Normal,
                (s, a) =>
                    {
                        if (overwrite)
                            MessageBlock.Text = message;
                        else
                            MessageBlock.Text += message;
                        }, this, null);
        }

        // Click event handler for "Tap" button.
        private void TapToConnectButton_Click(object sender, RoutedEventArgs e)
        {
            if (Windows.Networking.Proximity.PeerFinder.SupportedDiscoveryTypes ==
                Windows.Networking.Proximity.PeerDiscoveryTypes.Triggered)
            {
                Windows.Networking.Proximity.PeerFinder.Start();
                Windows.Networking.Proximity.PeerFinder.TriggeredConnectionStateChanged += 
                    TriggeredConnectionStateChanged;

                WriteMessageText("Click 'Click Here to Tap to Connect' on the peer device " +
                                 "and enter proximity to connect.\n");
            }
            else
            {
                WriteMessageText("Tap to connect is not supported.\n");
            }
        }

        private void TriggeredConnectionStateChanged(
            object sender, 
            Windows.Networking.Proximity.TriggeredConnectionStateChangedEventArgs e) 
        {
            if (e.State == Windows.Networking.Proximity.TriggeredConnectState.PeerFound) {
                WriteMessageText("Peer found. You may now exit proximity.\n");
            }
            if (e.State == Windows.Networking.Proximity.TriggeredConnectState.Completed) {
                WriteMessageText("Connected. You may now send a message.\n");
                SendMessage(e.Socket);
            }
        }

        // Click event handler for "Start" button.
        private void StartFindingPeersButton_Click(object sender, RoutedEventArgs e)
        {
            if (Windows.Networking.Proximity.PeerFinder.SupportedDiscoveryTypes ==
                Windows.Networking.Proximity.PeerDiscoveryTypes.Triggered)
            {
                Windows.Networking.Proximity.PeerFinder.Start();

                StartFindingPeers();
            }
            else
            {
                WriteMessageText("Peer discovery using tapping is not supported.\n");
            }
        }

        // Click event handler for "Stop" button.
        private void StopFindingPeersButton_Click(object sender, RoutedEventArgs e)
        {
            Windows.Networking.Proximity.PeerFinder.Stop();
            if (proximitySocket != null) { proximitySocket.Dispose(); }
        }

        private void StartFindingPeers()
        {
            if (Windows.Networking.Proximity.PeerFinder.SupportedDiscoveryTypes ==
                Windows.Networking.Proximity.PeerDiscoveryTypes.Browse)
            {

                Windows.Networking.Proximity.PeerFinder.Start();
                FindPeers();
            }
            else
            {
                WriteMessageText("Peer discovery using Wifi-Direct is not supported.\n");
            }
        }

        async private void FindPeers()
        {
            try
            {
                var peerInfoCollection = await Windows.Networking.Proximity.PeerFinder.FindAllPeersAsync();
                if (peerInfoCollection.Count > 0)
                {
                    // Connect to first peer found.
                    ConnectToPeer(peerInfoCollection[0]);
                }
            }
            catch (Exception err)
            {
                WriteMessageText("Error finding peers: " + err + "\n");
            }
        }

        async private void ConnectToPeer(Windows.Networking.Proximity.PeerInformation peerInfo) 
        {
            WriteMessageText("Peer found. Connecting to " + peerInfo.DisplayName + "\n");
            try
            {
                Windows.Networking.Proximity.ProximityStreamSocket socket = 
                    await Windows.Networking.Proximity.PeerFinder.ConnectAsync(peerInfo);

                
                WriteMessageText("Connection successful. You may now send messages.\n");
                SendMessage(socket);
            }
            catch (Exception err)
            {
                WriteMessageText("Connection failed: " + err + "\n");
            }
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

        Windows.Networking.Proximity.ProximityStreamSocket proximitySocket;
        Windows.Storage.Streams.DataWriter dataWriter;

        // Reference socket streams for writing and reading messages.
        private void SendMessage(Windows.Networking.Proximity.ProximityStreamSocket socket) {
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
         private async void SendMessageText() {
            string msg = SendMessageTextBox.Text;

            if (msg.Length > 0) {
                var msgLength = dataWriter.MeasureString(msg);
                dataWriter.WriteInt32(msg.Length);
                dataWriter.WriteString(msg);
                try
                {
                   await dataWriter.StoreAsync();
                   WriteMessageText("Message sent: " + msg  + "\n");
                }
                catch (Exception e)
                {
                   WriteMessageText("Send error: " + e.Message + "\n");
                }
            }
        }

        // Read out and print the message received from the socket.
         private async void StartReader(Windows.Networking.Proximity.ProximityStreamSocket socket, 
            Windows.Storage.Streams.DataReader reader) {
            uint initialLength = 4;

            try
            {
                await reader.LoadAsync(initialLength);
                uint msgLength = (uint)reader.ReadInt32();

                try
                {
                    await reader.LoadAsync(msgLength);
                    string message = reader.ReadString(msgLength);
                    WriteMessageText("Received message: " + message + "\n");

                    // After receiving a message, listen for the next message.
                    StartReader(socket, reader);
                }
                catch (Exception e)
                {
                    WriteMessageText("Error: " + e.Message + "\n");
                    socket.Dispose();
                }
            }
            catch (Exception e)
            {
                WriteMessageText("Error: " + e.Message + "\n");
                socket.Dispose();
            }
        }
        // </SnippetSendMessage_CS>
    }
}
