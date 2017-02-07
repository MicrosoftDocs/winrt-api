//<SnippetHowToShareImageDeferral_CS>
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

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace ShareMainBetaCS
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class ShareImage : Page
    {
        private StorageFile imageFile = null;
        private RandomAccessStreamReference imageStreamRef = null;
        private RandomAccessStreamReference dataPackageThumbnail = null;

        public ShareImage()
        {
            this.InitializeComponent();
            pickImageButton.Click += new RoutedEventHandler(pickImageButton_Click);
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

            this.imageFile = await imagePicker.PickSingleFileAsync();

            if (this.imageFile != null)
            {
                this.imageStreamRef = RandomAccessStreamReference.CreateFromFile(this.imageFile);
                this.dataPackageThumbnail = this.imageStreamRef;
            }

        }

        public void ShareSourceLoad()
        {
            DataTransferManager datatransferManager;
            datatransferManager = DataTransferManager.GetForCurrentView();
            datatransferManager.DataRequested += new TypedEventHandler<DataTransferManager, DataRequestedEventArgs>(this.DataRequested);
        }
        //<SnippetHowToShareImage_CS>
        //<SnippetHowToShareImage>
        void DataRequested(DataTransferManager sender, DataRequestedEventArgs e)
        {
            //<SnippetDataRequestDeferral_CS>
            //<SnippetDataRequestDeferral>
            DataRequestDeferral deferral = e.Request.GetDeferral();
            //</SnippetDataRequestDeferral>
            //</SnippetDataRequestDeferral_CS>
            e.Request.Data.Properties.Title = "Hello World!";
            e.Request.Data.Properties.Description = "This example shows how to share files and images.";
            //<SnippetAddThumbnailForImage_CS>
            if (this.dataPackageThumbnail != null)
            {
                e.Request.Data.Properties.Thumbnail = this.dataPackageThumbnail;
            }
            //</SnippetAddThumbnailForImage_CS>
            //<SnippetSetBitmap_CS>
            //<SnippetSetBitmap>
            e.Request.Data.SetBitmap(imageStreamRef);
            //</SnippetSetBitmap>
            //</SnippetSetBitmap_CS>
            //<SnippetDeferralComplete_CS>
            //<SnippetDeferralComplete>
            deferral.Complete();
            //</SnippetDeferralComplete_CS>
            //</SnippetDeferralComplete>
        }
        //</SnippetHowToShareImage>
        //</SnippetHowToShareImage_CS>
    }
}
//</SnippetHowToShareImageDeferral_CS>
