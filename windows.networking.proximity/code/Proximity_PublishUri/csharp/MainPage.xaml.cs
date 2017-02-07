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

namespace Proximity_PublishUri_CS
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        /// <summary>
        /// Invoked when this page is about to be displayed in a Frame.
        /// </summary>
        /// <param name="e">Event data that describes how this page was reached.  The Parameter
        /// property is typically used to configure the page.</param>
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
        }
                
	// <SnippetInitialize>
        private Windows.Networking.Proximity.ProximityDevice proximityDevice;
            
        public MainPage()
        {
            this.InitializeComponent();

            initializeProximitySample();
        }

        private void initializeProximitySample() 
        {
            proximityDevice = Windows.Networking.Proximity.ProximityDevice.GetDefault();

            if (proximityDevice == null)
                WriteMessageText("Failed to initialized proximity device.\n" +
                                 "Your device may not have proximity hardware.");
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
	// </SnippetInitialize>

        // <SnippetPublishSubscribeUri>
        long publishedUriId = -1;

        private void PublishUriButton_Click(object sender, RoutedEventArgs e)
        {
            // Stop publishing the current message.
            if (publishedUriId != -1)
                proximityDevice.StopPublishingMessage(publishedUriId);

            publishedUriId =
                proximityDevice.PublishUriMessage(new Uri("http://www.microsoft.com"));
        }

        private void StopPublishingUriButton_Click(object sender, RoutedEventArgs e)
        {
            proximityDevice.StopPublishingMessage(publishedUriId);
        }
        // </SnippetPublishSubscribeUri>
    }

    class exclude {
        // <SnippetPublishSubscribeUri2>
        long publishedUriId = -1;

        private void PublishUriButton_Click(object sender, RoutedEventArgs e)
        {
            // Stop publishing the current message.
            if (publishedUriId != -1)
                proximityDevice.StopPublishingMessage(publishedUriId);

            publishedUriId =
                proximityDevice.PublishUriMessage(new Uri("http://www.microsoft.com"),
                                                  UriTransmitted);
        }

	private void UriTransmitted(
	    Windows.Networking.Proximity.ProximityDevice sender,
            long messageId)
        {
	    // The Uri has been successfully transmitted.
        }

        private void StopPublishingUriButton_Click(object sender, RoutedEventArgs e)
        {
            proximityDevice.StopPublishingMessage(publishedUriId);
        }
        // </SnippetPublishSubscribeUri2>
    }
}


