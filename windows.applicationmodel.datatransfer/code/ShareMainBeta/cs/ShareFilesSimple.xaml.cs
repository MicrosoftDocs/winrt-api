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
using Windows.Storage;
using Windows.Storage.Pickers;
using Windows.Storage.Streams;
using Windows.UI.Xaml.Media.Imaging;
using Windows.ApplicationModel.DataTransfer;
using Windows.Graphics.Imaging;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace ShareMainBetaCS
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class ShareFilesSimple : Page
    {
        private StorageFile imageFile = null;
        private RandomAccessStreamReference imageStreamRef = null;
        private RandomAccessStreamReference dataPackageThumbnail = null;
        private IRandomAccessStream imageStream = null;
        private IReadOnlyList<StorageFile> imageFiles;

        public ShareFilesSimple()
        {
            this.InitializeComponent();
            pickImagesButton.Click += new RoutedEventHandler(pickImageButton_Click);
            this.ShareSourceLoad();
        }

        async void pickImageButton_Click(object sender, RoutedEventArgs e)
        {
            FileOpenPicker imagePicker = new FileOpenPicker
            {
                ViewMode = PickerViewMode.Thumbnail,
                SuggestedStartLocation = PickerLocationId.PicturesLibrary,
                FileTypeFilter = { ".jpg", ".png", ".bmp", ".gif", ".tif" }
            };

            this.imageFiles = await imagePicker.PickMultipleFilesAsync();

        }

        public void ShareSourceLoad()
        {
            DataTransferManager datatransferManager;
            datatransferManager = DataTransferManager.GetForCurrentView();
            datatransferManager.DataRequested += new TypedEventHandler<DataTransferManager, DataRequestedEventArgs>(this.DataRequested);
        }

        void DataRequested(DataTransferManager sender, DataRequestedEventArgs e)
        {
            e.Request.Data.Properties.Title = "Hello World!";
            e.Request.Data.Properties.Description = "This example shows how to share files.";
            //<SnippetSetStorageItems_CS>
            //<SnippetSetStorageItems>
            e.Request.Data.SetStorageItems(imageFiles);
            //</SnippetSetStorageItems>
            //</SnippetSetStorageItems_CS>

        }
        

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
