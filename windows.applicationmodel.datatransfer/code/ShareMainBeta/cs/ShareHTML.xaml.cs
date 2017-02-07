using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Windows.ApplicationModel.DataTransfer;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Storage;
using Windows.Storage.Streams;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace ShareMainBetaCS
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class ShareHTML : Page
    {
        public ShareHTML()
        {
            this.InitializeComponent();
            this.ShareSourceLoad();
        }

        // <SnippetHowToShareHtml_CS>
        public void ShareSourceLoad()
        {
            DataTransferManager dataTransferManager = DataTransferManager.GetForCurrentView();
            dataTransferManager.DataRequested += new TypedEventHandler<DataTransferManager, DataRequestedEventArgs>(this.DataRequested);
        }

        async void DataRequested(DataTransferManager sender, DataRequestedEventArgs e)
        {
            string htmlExample = "<p>Here is our store logo: <img src='assets/logo.png'>.</p>";
            string fileExample = "assets\\logo.png";
            // <SnippetGetFileForMap_CS>
            RandomAccessStreamReference streamRef = null;
            Windows.Storage.StorageFile file = await Windows.ApplicationModel.Package.Current.InstalledLocation.GetFileAsync(fileExample);
            try
            {
                streamRef = Windows.Storage.Streams.RandomAccessStreamReference.CreateFromFile(file);
            }
            catch (Exception ex)
            {
                // TODO: Handle the exception.
            }
            // </SnippetGetFileForMap_CS>
            // <SnippetFormatHtml_CS>
            string htmlFormat = Windows.ApplicationModel.DataTransfer.HtmlFormatHelper.CreateHtmlFormat(htmlExample);
            // </SnippetFormatHtml_CS>
            DataRequest request = e.Request;
            request.Data.Properties.Title = "Share HTML Example";
            request.Data.Properties.Description = "An example of how to share HTML.";
            // <SnippetSetHtmlFormat_CS>
            request.Data.SetHtmlFormat(htmlFormat);
            // </SnippetSetHtmlFormat_CS>
            // <SnippetSetResourceMap_CS>
            request.Data.ResourceMap[fileExample] = streamRef;
            // </SnippetSetResourceMap_CS>
        }
        // </SnippetHowToShareHtml_CS>

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
