using System.Diagnostics;
//using Windows.Storage;
//using Windows.Storage.BulkAccess;
//using Windows.Storage.FileProperties;
//using Windows.Storage.Search;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace CurrentChangingExample
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
        //<snippetCode>
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            var library = Windows.Storage.KnownFolders.PicturesLibrary;
            var queryOptions = new Windows.Storage.Search.QueryOptions();
            queryOptions.FolderDepth = Windows.Storage.Search.FolderDepth.Deep;
            queryOptions.IndexerOption = 
                Windows.Storage.Search.IndexerOption.UseIndexerWhenAvailable;

            var fileQuery = library.CreateFileQueryWithOptions(queryOptions);

            var fif = new Windows.Storage.BulkAccess.FileInformationFactory(
                fileQuery, 
                Windows.Storage.FileProperties.ThumbnailMode.PicturesView, 190, 
                Windows.Storage.FileProperties.ThumbnailOptions.UseCurrentScale, 
                false);

            var dataSource = fif.GetVirtualizedFilesVector();
            cvs.Source = dataSource;
            cvs.View.CurrentChanging += View_CurrentChanging;
        }

        private void View_CurrentChanging(object sender, CurrentChangingEventArgs e)
        {
            Debug.WriteLine("Cancel = " + e.Cancel);
            Debug.WriteLine("IsCancelable = " + e.IsCancelable);
            if (e.IsCancelable == true)
            {
                // Cancel the change. The previously selected item remains selected.
                e.Cancel = true;
            }
        }
        //</snippetCode>
    }
}
