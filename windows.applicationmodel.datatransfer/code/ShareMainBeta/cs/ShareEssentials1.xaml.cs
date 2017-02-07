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
//<SnippetDataTransferUsingStatement>
using Windows.ApplicationModel.DataTransfer;
//</SnippetDataTransferUsingStatement>

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace ShareMainBetaCS
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class ShareEssentials1 : Page
    {
        public ShareEssentials1()
        {
            this.InitializeComponent();
            shareEssentials();
        }

        public void shareEssentials()
        {
            //<SnippetGetDataTransferManagerEssentials_CS>
            //<SnippetGetDataTransferManagerEssentials>
            DataTransferManager dataTransferManager = DataTransferManager.GetForCurrentView();
            //</SnippetGetDataTransferManagerEssentials>
            //</SnippetGetDataTransferManagerEssentials_CS>
            //<SnippetShareEmptyDataRequestedEvent_CS>
            //<SnippetShareEmptyDataRequestedEvent>
            dataTransferManager.DataRequested += new TypedEventHandler<DataTransferManager, DataRequestedEventArgs>(this.DataRequested);
            //</SnippetShareEmptyDataRequestedEvent>
            //</SnippetShareEmptyDataRequestedEvent_CS>
        }

        //<SnippetEmptyDataRequestedEventHandler_CS>
        void DataRequestEvent(DataTransferManager sender, DataRequestedEventArgs e)
        {
            DataRequest request = e.Request;
            
            // Now add the data you want to share.
        }
        //</SnippetEmptyDataRequestedEventHandler_CS>

        void DataRequested(DataTransferManager sender, DataRequestedEventArgs e)
        {
            //<SnippetGetDataRequestObject_CS>
            //<SnippetGetDataRequestObject>
            DataRequest request = e.Request;
            //</SnippetGetDataRequestObject>
            //</SnippetGetDataRequestObject_CS>
            request.Data.Properties.Title = "Share Text Example";
            request.Data.Properties.Description = "An example of how to share text.";
            request.Data.SetText("Hello World!");
        }

        // <SnippetShareFileFunction_CS>
        async void OnDeferredImageRequestedHandler(DataProviderRequest request)
        {
            // Provide updated bitmap data using delayed rendering.
            if (this.imageStream != null)
            {
                DataProviderDeferral deferral = request.GetDeferral();
                InMemoryRandomAccessStream inMemoryStream = new InMemoryRandomAccessStream();

                // Decode the image.
                BitmapDecoder imageDecoder = await BitmapDecoder.CreateAsync(this.imageStream);

                // Re-encode the image at 50% width and height.
                BitmapEncoder imageEncoder = await BitmapEncoder.CreateForTranscodingAsync(inMemoryStream, imageDecoder);
                imageEncoder.BitmapTransform.ScaledWidth = (uint)(imageDecoder.OrientedPixelHeight * 0.5);
                imageEncoder.BitmapTransform.ScaledHeight = (uint)(imageDecoder.OrientedPixelHeight * 0.5);
                await imageEncoder.FlushAsync();

                request.SetData(RandomAccessStreamReference.CreateFromStream(inMemoryStream));
                deferral.Complete();
            }
        }
        // </SnippetShareFileFunction_CS>

        /// <summary>
        /// Invoked when this page is about to be displayed in a Frame.
        /// </summary>
        /// <param name="e">Event data that describes how this page was reached.  The Parameter
        /// property is typically used to configure the page.</param>
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
        }
    }
}
