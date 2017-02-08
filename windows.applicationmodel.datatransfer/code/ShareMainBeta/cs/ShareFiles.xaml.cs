//<SnippetHowToShareFiles_CS>
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
using Windows.Storage;
using Windows.Storage.Pickers;
using Windows.Storage.Streams;
using Windows.UI.Xaml.Media.Imaging;
using Windows.ApplicationModel.DataTransfer;
using Windows.Graphics.Imaging;

namespace ShareMainBetaCS
{
    public sealed partial class ShareFiles : Page
    {
        private StorageFile imageFile = null;
        private RandomAccessStreamReference imageStreamRef = null;
        private RandomAccessStreamReference dataPackageThumbnail = null;
        private IRandomAccessStream imageStream = null;

        public ShareFiles()
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
                this.imageStream = await this.imageFile.OpenAsync(FileAccessMode.Read);
            }

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
            e.Request.Data.Properties.Description = "This example shows how to use delayed sharing.";
            if (this.dataPackageThumbnail != null)
            {
                e.Request.Data.Properties.Thumbnail = this.dataPackageThumbnail;
            }
            //<SnippetSetDataProvider_CS>
            //<SnippetSetDataProvider>
            e.Request.Data.SetDataProvider(StandardDataFormats.Bitmap, 
                    new DataProviderHandler(this.OnDeferredImageRequestedHandler));
            //</SnippetSetDataProvider>
            //</SnippetSetDataProvider_CS>

        }
        //<SnippetShareFileFunction_CS>
        //<SnippetShareFileFunction>
        async void OnDeferredImageRequestedHandler(DataProviderRequest request)
        {
            // Here we provide updated Bitmap data using delayed rendering
            if (this.imageStream != null)
            {
                //<SnippetGetDefferal_CS>
                //<SnippetGetDefferal>
                DataProviderDeferral deferral = request.GetDeferral();
                //</SnippetGetDefferal>
                //</SnippetGetDefferal_CS>

                try
                {
                    InMemoryRandomAccessStream inMemoryStream = new InMemoryRandomAccessStream();

                    // Decode the image
                    BitmapDecoder imageDecoder = await BitmapDecoder.CreateAsync(this.imageStream);

                    // Re-encode the image at 50% width and height
                    BitmapEncoder imageEncoder = await BitmapEncoder.CreateForTranscodingAsync(inMemoryStream, imageDecoder);
                    imageEncoder.BitmapTransform.ScaledWidth = (uint)(imageDecoder.OrientedPixelHeight * 0.5);
                    imageEncoder.BitmapTransform.ScaledHeight = (uint)(imageDecoder.OrientedPixelHeight * 0.5);
                    await imageEncoder.FlushAsync();

                    request.SetData(RandomAccessStreamReference.CreateFromStream(inMemoryStream));
                }

                catch (Exception ex)
                {
                    // Handle the exception
                }

                finally
                {
                    deferral.Complete();
                }
            }
        }
        //</SnippetShareFileFunction>
        //</SnippetShareFileFunction_CS>
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
        }
    }
}
//</SnippetHowToShareFiles_CS>
