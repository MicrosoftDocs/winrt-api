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
using Windows.ApplicationModel.DataTransfer;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace ShareMainBetaCS
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class ShareLink : Page
    {
        public ShareLink()
        {
            this.InitializeComponent();
            this.ShareSourceLoad();
        }

        /// <summary>
        /// Invoked when this page is about to be displayed in a Frame.
        /// </summary>
        /// <param name="e">Event data that describes how this page was reached.  The Parameter
        /// property is typically used to configure the page.</param>
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
        }

        //<SnippetHowToShareLink_CS>
        public void ShareSourceLoad()
        {
            // <SnippetDataTransferManager_CS>           
            DataTransferManager dataTransferManager = DataTransferManager.GetForCurrentView();
            // </SnippetDataTransferManager_CS>
            // <SnippetDataRequestedEvent_CS>
            dataTransferManager.DataRequested += new TypedEventHandler<DataTransferManager, DataRequestedEventArgs>(this.DataRequested);
            // </SnippetDataRequestedEvent_CS>
        }

        void DataRequested(DataTransferManager sender, DataRequestedEventArgs e)
        {
            DataRequest request = e.Request;
            request.Data.Properties.Title = "Share Link Example";
            request.Data.Properties.Description = "An example of how to share a link.";
            //<SnippetSetUri_CS>
            var link = new Uri("http://www.fabrikam.com");
            request.Data.SetUri(link);
            //</SnippetSetUri_CS>
        }
        //</SnippetHowToShareLink_CS>
    }
}
