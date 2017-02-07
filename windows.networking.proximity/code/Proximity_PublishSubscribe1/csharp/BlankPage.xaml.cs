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

namespace Proximity_PublishSubscribe_CS
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class BlankPage : Page
    {

        // <SnippetInitialize_CS>
        private Windows.Networking.Proximity.ProximityDevice proximityDevice;
            
        public BlankPage()
        {
            this.InitializeComponent();

            initializeProximitySample();
        }

        /// <summary>
        /// Invoked when this page is about to be displayed in a Frame.
        /// </summary>
        /// <param name="e">Event data that describes how this page was reached.  The Parameter
        /// property is typically used to configure the page.</param>
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
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

        private void initializeProximitySample() 
        {
            proximityDevice = Windows.Networking.Proximity.ProximityDevice.GetDefault();

            if (proximityDevice == null)
                WriteMessageText("Failed to initialized proximity device.\n" +
                                 "Your device may not have proximity hardware.");
        }
        // </SnippetInitialize_CS>

        // <SnippetPublishSubscribe_CS>
        long publishedMessageId = -1;
        long subscribedMessageId = -1;

        private void PublishMessageButton_Click(object sender, RoutedEventArgs e)
        {
            // Stop publishing the current message.
            if (publishedMessageId != -1)
                proximityDevice.StopPublishingMessage(publishedMessageId);

            publishedMessageId =
                proximityDevice.PublishMessage("Windows.SampleMessage", MessageTextBox.Text);
        }

        private void SubscribeForMessageButton_Click(object sender, RoutedEventArgs e)
        {
            // Only subscribe for the message one time.
            if (subscribedMessageId == -1)
            {
                subscribedMessageId =
			proximityDevice.SubscribeForMessage("Windows.SampleMessage", messageReceived);
            }
        }

        private void messageReceived(Windows.Networking.Proximity.ProximityDevice device,
                                     Windows.Networking.Proximity.ProximityMessage message)
        {
            WriteMessageText("Message received: " + message.DataAsString + "\n");
        }

        private void StopPublishingMessageButton_Click(object sender, RoutedEventArgs e)
        {
	    proximityDevice.StopPublishingMessage(publishedMessageId);
        }

        private void StopSubscribingForMessageButton_Click(object sender, RoutedEventArgs e)
        {
            proximityDevice.StopSubscribingForMessage(subscribedMessageId);            
        }
        // </SnippetPublishSubscribe_CS>
    }


}
