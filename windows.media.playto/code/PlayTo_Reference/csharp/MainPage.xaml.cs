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

namespace PlayToReference_CS_RC
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

        Windows.UI.Xaml.Controls.MediaElement mediaElement;
        Windows.UI.Xaml.Controls.TextBlock messageBlock;

    // <SnippetSourceRequested>
    // Play To Contract

    private Windows.Media.PlayTo.PlayToManager ptm = 
            Windows.Media.PlayTo.PlayToManager.GetForCurrentView();

    protected override void OnNavigatedTo(NavigationEventArgs e)
    {
        ptm.SourceRequested += sourceRequestHandler;
    }

    private void sourceRequestHandler(
        Windows.Media.PlayTo.PlayToManager sender,
        Windows.Media.PlayTo.PlayToSourceRequestedEventArgs e)
    {
        try
        {
            e.SourceRequest.SetSource(mediaElement.PlayToSource);
        }
        catch (Exception ex)
        {
            messageBlock.Text += "Exception encountered: " + ex.Message + "\n";
        }
    }
    // </SnippetSourceRequested>
    }
    // exclude from the running application

    class exclude1 : Page
    {
        
        Windows.UI.Xaml.Controls.MediaElement mediaElement;
        Windows.UI.Xaml.Controls.TextBlock messageBlock;
        Windows.UI.Xaml.Controls.Image playToDeviceIconImage;
        Windows.UI.Xaml.Controls.TextBlock playToDeviceFriendlyNameBlock;

        // <SnippetPlayToEvents>
    private Windows.Media.PlayTo.PlayToManager ptm = 
            Windows.Media.PlayTo.PlayToManager.GetForCurrentView();

    protected override void OnNavigatedTo(NavigationEventArgs e)
    {
        ptm.SourceRequested += sourceRequestHandlerWithEvents;
        ptm.SourceSelected += sourceSelectedHandler;
    }

    private void sourceRequestHandlerWithEvents(
    Windows.Media.PlayTo.PlayToManager sender,
    Windows.Media.PlayTo.PlayToSourceRequestedEventArgs e)
    {
        try
        {
            var controller = mediaElement.PlayToSource;

            controller.Connection.Error += playToConnectionError;
            controller.Connection.StateChanged += playToConnectionStageChanged;
            controller.Connection.Transferred += playToConnectionTransferred;

            e.SourceRequest.SetSource(controller);
        }
        catch (Exception ex)
        {
            messageBlock.Text += "Exception encountered: " + ex.Message + "\n";
        }
    }

    // Called when the user selects a Play To device to stream to.

    private void sourceSelectedHandler(
        Windows.Media.PlayTo.PlayToManager sender,
        Windows.Media.PlayTo.PlayToSourceSelectedEventArgs e)
    {
        if (mediaElement.Name == "iplayer") {
            if (!e.SupportsImage) {
                messageBlock.Text += e.FriendlyName + " does not support streaming images. " +
                                     "Please select a different device.";
                return;
            }
        }

        if (mediaElement.Name == "vplayer") {
            if (!e.SupportsVideo) {
                messageBlock.Text += e.FriendlyName + " does not support streaming video. " +
                                     "Please select a different device.";
                return;
            }
        }

        if (mediaElement.Name == "aplayer") {
            if (!e.SupportsAudio) {
                messageBlock.Text += e.FriendlyName + " does not support streaming audio. " +
                                     "Please select a different device.";
                return;
            }
        }

        Windows.Storage.Streams.IRandomAccessStream iconStream = e.Icon;
        Windows.UI.Xaml.Media.Imaging.BitmapImage iconBitmap = 
                new Windows.UI.Xaml.Media.Imaging.BitmapImage();
        iconBitmap.SetSource(iconStream);
        playToDeviceIconImage.Source = iconBitmap;

        playToDeviceFriendlyNameBlock.Text = e.FriendlyName;
    }

    private void playToConnectionError(
        Windows.Media.PlayTo.PlayToConnection connection,
        Windows.Media.PlayTo.PlayToConnectionErrorEventArgs e)
    {
        if (e.Code == Windows.Media.PlayTo.PlayToConnectionError.DeviceError ||
            e.Code == Windows.Media.PlayTo.PlayToConnectionError.DeviceNotResponding) 
        {
            messageBlock.Text += "Error occurred. Disconnecting.\n";
        }

        messageBlock.Text += "Error: Message = " + e.Message.ToString() + "\n";
    }

   private void playToConnectionStageChanged(
       Windows.Media.PlayTo.PlayToConnection connection, 
       Windows.Media.PlayTo.PlayToConnectionStateChangedEventArgs e) 
    {
        messageBlock.Text += "StateChanged: PreviousState = " + e.PreviousState.ToString() + "\n";
        messageBlock.Text += "StateChanged: CurrentState = " + e.CurrentState.ToString() + "\n";
    }

   private void playToConnectionTransferred(
       Windows.Media.PlayTo.PlayToConnection connection, 
       Windows.Media.PlayTo.PlayToConnectionTransferredEventArgs e)
    {
        messageBlock.Text += "Transferred: PreviousSource = " + e.PreviousSource.ToString() + "\n";
        messageBlock.Text += "Transferred: CurrentSource = " + e.CurrentSource.ToString() + "\n";
    }
        // </SnippetPlayToEvents>
    }

    // exclude from the running application
    class exclude2 : Page
    {        
        Windows.UI.Xaml.Controls.MediaElement mediaElement;
        // <SnippetDeferral>
    private Windows.Media.PlayTo.PlayToManager ptm = 
            Windows.Media.PlayTo.PlayToManager.GetForCurrentView();

    protected override void OnNavigatedTo(NavigationEventArgs e)
    {
        ptm.SourceRequested += sourceRequestHandlerDeferred;
    }

    async private void sourceRequestHandlerDeferred(
        Windows.Media.PlayTo.PlayToManager sender,
        Windows.Media.PlayTo.PlayToSourceRequestedEventArgs e) 
    {
        var deferral = e.SourceRequest.GetDeferral();

        // Async call to get source media
        var element = await getMediaElementAsync();
        e.SourceRequest.SetSource(element.PlayToSource);

        deferral.Complete();
    }
    // </SnippetDeferral>

    System.Threading.Tasks.Task<Windows.UI.Xaml.Controls.MediaElement> getMediaElementAsync()
    {
        var result = new System.Threading.Tasks.Task<Windows.UI.Xaml.Controls.MediaElement>(() => mediaElement);
        return result;
    }
    }

    class exclude3
    {
    // <SnippetShowPlayToUI>
    private void showPlayTo() {
        Windows.Media.PlayTo.PlayToManager.ShowPlayToUI();
    }
    // </SnippetShowPlayToUI>
    }
}
