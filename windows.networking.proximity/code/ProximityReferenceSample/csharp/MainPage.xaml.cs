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

namespace ProximityReferenceSample
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

        /// <summary>
        /// Invoked when this page is about to be displayed in a Frame.
        /// </summary>
        /// <param name="e">Event data that describes how this page was reached.  The Parameter
        /// property is typically used to configure the page.</param>
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
        }

        private void StartFindingPeersButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void StopFindingPeersButton_Click(object sender, RoutedEventArgs e)
        {

        }
    }

    class exclude0
    {
        private TextBlock MessageBlock;
        private Button SendMessageButton;
        private Button StartFindingPeersButton;
        private TextBlock SendMessageTextBlock;

        // <SnippetArriveDepart>
        Windows.Networking.Proximity.ProximityDevice proximityDevice;

        private void InitializeProximityDevice()
        {
            proximityDevice = Windows.Networking.Proximity.ProximityDevice.GetDefault();

            if (proximityDevice != null) {
                proximityDevice.DeviceArrived += ProximityDeviceArrived;
                proximityDevice.DeviceDeparted += ProximityDeviceDeparted;

                WriteMessageText("Proximity device initialized.\n");
            }
            else
            {
                WriteMessageText("Failed to initialized proximity device.\n");
            }
        }

        private void ProximityDeviceArrived(Windows.Networking.Proximity.ProximityDevice device)
        {
            WriteMessageText("Proximate device arrived. id = " + device.DeviceId + "\n");
        }

        private void ProximityDeviceDeparted(Windows.Networking.Proximity.ProximityDevice device)
        {
            WriteMessageText("Proximate device departed. id = " + device.DeviceId + "\n");
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
        // </SnippetArriveDepart>
    }

    class exclude3
    {        
        private TextBlock MessageBlock;
        private Button SendMessageButton;
        private Button StartFindingPeersButton;
        private TextBlock SendMessageTextBlock;

        // <SnippetConnect>
        // Click event for "Start" button.

        private void StartFindingPeersButton_Click(object sender, RoutedEventArgs e)
        {
            if ((Windows.Networking.Proximity.PeerFinder.SupportedDiscoveryTypes &
                 Windows.Networking.Proximity.PeerDiscoveryTypes.Triggered) ==
                 Windows.Networking.Proximity.PeerDiscoveryTypes.Triggered)
            {
                Windows.Networking.Proximity.PeerFinder.Start();

                Windows.Networking.Proximity.PeerFinder.TriggeredConnectionStateChanged += 
                    TriggeredConnectionStateChanged;

                WriteMessageText("Waiting for peers. Enter proximity to connect. " +
		            "Call PeerFinder.start() on the peer to send and receive messages.\n");
            }
            else {
                WriteMessageText("Peer discovery using tapping is not supported.\n");
            }
        }

        private void TriggeredConnectionStateChanged(object sender,
            Windows.Networking.Proximity.TriggeredConnectionStateChangedEventArgs e)
        {
            if (e.State == Windows.Networking.Proximity.TriggeredConnectState.Completed)
            {
                WriteMessageText("Connected. You may now send a message.\n");
                SendMessage(e.Socket);
            }
        }

        Windows.Networking.Sockets.StreamSocket proximitySocket;
        Windows.Storage.Streams.DataWriter dataWriter;

        // Reference socket streams for writing and reading messages.
        private void SendMessage(Windows.Networking.Sockets.StreamSocket socket) {
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
            string msg = SendMessageTextBlock.Text;

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
        private async void StartReader(
            Windows.Networking.Sockets.StreamSocket socket, 
            Windows.Storage.Streams.DataReader reader)
        {
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
    // </SnippetConnect>
    }

    class exclude1
    {
        private Button PublishMessageButton;
        private Button SubscribeForMessageButton;
        private Button StopSubscribingForMessageButton;
        private Button StopPublishingMessageButton;
        private TextBlock MessageBlock;
        private TextBlock MessageTextBlock;

        // <SnippetPublishSubscribe>
        Windows.Networking.Proximity.ProximityDevice proximityDevice;
        long publishedMessageId = -1;
        long subscribedMessageId = -1;

        private void initializeProximityDevice()
        {
            proximityDevice = Windows.Networking.Proximity.ProximityDevice.GetDefault();

            if (proximityDevice != null)
            {
                PublishMessageButton.Click += PublishMessage;
                SubscribeForMessageButton.Click += SubscribeForMessage;
		        StopSubscribingForMessageButton.Click += StopSubscribingForMessage;
		        StopPublishingMessageButton.Click += StopPublishingMessage;
            }
            else
            {
                WriteMessageText("Failed to initialized proximity device.\n");
            }
        }

        private void PublishMessage(object sender, RoutedEventArgs e)
        {
            // Stop publishing the current message.
            if (publishedMessageId != -1)
            {
                proximityDevice.StopPublishingMessage(publishedMessageId);
            }

            publishedMessageId = 
		        proximityDevice.PublishMessage("Windows.SampleMessage", MessageTextBlock.Text);
        }

        private void SubscribeForMessage(object sender, RoutedEventArgs e)
        {
            // Only subscribe for the message one time.
            if (subscribedMessageId == -1)
            {
                subscribedMessageId = 
		        proximityDevice.SubscribeForMessage("Windows.SampleMessage", messageReceived);
            }
        }

        private void messageReceived(
            Windows.Networking.Proximity.ProximityDevice device, 
            Windows.Networking.Proximity.ProximityMessage message)
        {
            MessageBlock.Text += "Message received: " + message.DataAsString + "\n";
        }

	    private void StopSubscribingForMessage(object sender, RoutedEventArgs e)
        {
	        proximityDevice.StopSubscribingForMessage(subscribedMessageId);
            subscribedMessageId = -1;
	    }

	    private void StopPublishingMessage(object sender, RoutedEventArgs e)
        {
	        proximityDevice.StopPublishingMessage(publishedMessageId);
            publishedMessageId = -1;
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
        // </SnippetPublishSubscribe>
    }

    class exclude5
    {
        private Button PublishMessageButton;
        private Button SubscribeForMessageButton;
        private Button StopSubscribingForMessageButton;
        private Button StopPublishingMessageButton;
        private TextBlock MessageBlock;
        private TextBlock MessageTextBlock;

        // <SnippetPublishSubscribe2>
        Windows.Networking.Proximity.ProximityDevice proximityDevice;
        long publishedMessageId = -1;
        long subscribedMessageId = -1;

        private void initializeProximityDevice()
        {
            proximityDevice = Windows.Networking.Proximity.ProximityDevice.GetDefault();

            if (proximityDevice != null)
            {
                PublishMessageButton.Click += PublishMessage;
                SubscribeForMessageButton.Click += SubscribeForMessage;
		        StopSubscribingForMessageButton.Click += StopSubscribingForMessage;
		        StopPublishingMessageButton.Click += StopPublishingMessage;
            }
            else
            {
                WriteMessageText("Failed to initialized proximity device.\n");
            }
        }

        private void PublishMessage(object sender, RoutedEventArgs e)
        {
            // Stop publishing the current message.
            if (publishedMessageId != -1)
            {
                proximityDevice.StopPublishingMessage(publishedMessageId);
            }

            publishedMessageId = 
		        proximityDevice.PublishMessage("Windows.SampleMessage", MessageTextBlock.Text,
                                                       MessagePublished);
        }

	private void MessagePublished(
	    Windows.Networking.Proximity.ProximityDevice sender,
            long messageId)
        {
	    // The message has been successfully published.
        }

        private void SubscribeForMessage(object sender, RoutedEventArgs e)
        {
            // Only subscribe for the message one time.
            if (subscribedMessageId == -1)
            {
                subscribedMessageId = 
		        proximityDevice.SubscribeForMessage("Windows.SampleMessage", messageReceived);
            }
        }

        private void messageReceived(
            Windows.Networking.Proximity.ProximityDevice device, 
            Windows.Networking.Proximity.ProximityMessage message)
        {
            MessageBlock.Text += "Message received: " + message.DataAsString + "\n";
        }

	    private void StopSubscribingForMessage(object sender, RoutedEventArgs e)
        {
	        proximityDevice.StopSubscribingForMessage(subscribedMessageId);
            subscribedMessageId = -1;
	    }

	    private void StopPublishingMessage(object sender, RoutedEventArgs e)
        {
	        proximityDevice.StopPublishingMessage(publishedMessageId);
            publishedMessageId = -1;
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
        // </SnippetPublishSubscribe2>
    }


    }

