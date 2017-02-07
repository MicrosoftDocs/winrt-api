using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.ApplicationModel.Activation;
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

namespace Proximity_PeerWatcher
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class PeerRole : Page
    {
        public PeerRole()
        {
            this.InitializeComponent();
        }

        TextBox DisplayNameTextBox = new TextBox();
        TextBlock MessageBlock = new TextBlock();

        private void TriggeredConnectionStateChanged(
            object sender,
            Windows.Networking.Proximity.TriggeredConnectionStateChangedEventArgs e)
        {
            if (e.State == Windows.Networking.Proximity.TriggeredConnectState.PeerFound)
            {

            }
            if (e.State == Windows.Networking.Proximity.TriggeredConnectState.Completed)
            {

            }
        }

        private string GetDiscoveryDataFromUser()
        {
            return "";
        }

        private string GetRoleFromUser()
        {
            return "Peer";
        }

        // <SnippetPeerRole_CS>
        // Default to the peer role.
        Windows.Networking.Proximity.PeerRole appRole = Windows.Networking.Proximity.PeerRole.Peer;
        bool launchedByTap = false;

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            LaunchActivatedEventArgs launchArgs = e.Parameter as LaunchActivatedEventArgs;

            if (launchArgs.Arguments.Contains("Windows.Networking.Proximity.PeerFinder:StreamSocket"))
            {
                launchedByTap = true;

                if (launchArgs.Arguments.Contains("Role=Host"))
                {
                    appRole = Windows.Networking.Proximity.PeerRole.Host;
                }
                else if (launchArgs.Arguments.Contains("Role=Client"))
                {
                    appRole = Windows.Networking.Proximity.PeerRole.Client;
                }
                else
                {
                    appRole = Windows.Networking.Proximity.PeerRole.Peer;
                }
            }
        }

        bool started = false;

        // Click event for "Advertise" button.
        void AdvertiseForPeers(object sender, RoutedEventArgs e)
        {
            if (!started)
            {
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

                // Set the peer role selected by the user.  
                if (launchedByTap)
                {
                    Windows.Networking.Proximity.PeerFinder.Role = appRole;
                }
                else
                {
                    switch (GetRoleFromUser())
                    {
                        case "Peer":
                            Windows.Networking.Proximity.PeerFinder.Role =
                                Windows.Networking.Proximity.PeerRole.Peer;
                            break;
                        case "Host":
                            Windows.Networking.Proximity.PeerFinder.Role =
                                Windows.Networking.Proximity.PeerRole.Host;
                            break;
                        case "Client":
                            Windows.Networking.Proximity.PeerFinder.Role =
                                Windows.Networking.Proximity.PeerRole.Client;
                            break;
                    }
                }

                // Set discoveryData property with user supplied text. 
                var discData = GetDiscoveryDataFromUser();
                var writer = new Windows.Storage.Streams.DataWriter(
                    new Windows.Storage.Streams.InMemoryRandomAccessStream());
                writer.WriteString(discData);
                Windows.Networking.Proximity.PeerFinder.DiscoveryData =
                    writer.DetachBuffer();

                Windows.Networking.Proximity.PeerFinder.Start();
                started = true;
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
        // </SnippetPeerRole_CS>

    }
}
