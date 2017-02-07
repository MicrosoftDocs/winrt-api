using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using Windows.Media.Capture;
using Windows.Media;
using Windows.Media.MediaProperties;
using Windows.UI.Xaml.Media.Imaging;
using Windows.Storage;
using Windows.Storage.Streams;
using Windows.Storage;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace MediaCaptureSnippets
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

        Windows.Storage.StorageFile captureFile;

        // <SnippetMediaCapturePreviewCode>
        Windows.Media.Capture.MediaCapture captureManager;

        async private void InitCamera_Click(object sender, RoutedEventArgs e)
        {
            captureManager = new MediaCapture();
            await captureManager.InitializeAsync();
        }

        async private void StartCapturePreview_Click(object sender, RoutedEventArgs e)
        {
            capturePreview.Source = captureManager;
            await captureManager.StartPreviewAsync();
        }

        async private void StopCapturePreview_Click(object sender, RoutedEventArgs e)
        {
            await captureManager.StopPreviewAsync();
        }

        async private void CapturePhoto_Click(object sender, RoutedEventArgs e)
        {
            ImageEncodingProperties imgFormat = ImageEncodingProperties.CreateJpeg();

            // create storage file in local app storage
            StorageFile file = await ApplicationData.Current.LocalFolder.CreateFileAsync(
                "TestPhoto.jpg",
                CreationCollisionOption.GenerateUniqueName);

            // take photo
            await captureManager.CapturePhotoToStorageFileAsync(imgFormat, file);

            // Get photo as a BitmapImage
            BitmapImage bmpImage = new BitmapImage(new Uri(file.Path));

            // imagePreview is a <Image> object defined in XAML
            imagePreview.Source = bmpImage;
        }
        // </SnippetMediaCapturePreviewCode>

        // <SnippetMediaCaptureLowLagPhotoCaptureCode>
        LowLagPhotoCapture lowLagCaptureMgr = null;
        MediaCapture mediaCaptureManager;

        async private void InitMediaCapture_Click(object sender, RoutedEventArgs e)
        {
            mediaCaptureManager = new MediaCapture();
            await mediaCaptureManager.InitializeAsync();
        }

        async private void InitLowLagPhotoCapture_Click(object sender, RoutedEventArgs e)
        {
            // Enable thumbnail images
            mediaCaptureManager.VideoDeviceController.LowLagPhoto.ThumbnailEnabled = true;
            mediaCaptureManager.VideoDeviceController.LowLagPhoto.ThumbnailFormat = MediaThumbnailFormat.Bmp;
            mediaCaptureManager.VideoDeviceController.LowLagPhoto.DesiredThumbnailSize = 25;

            // Image properties
            ImageEncodingProperties imgFormat = ImageEncodingProperties.CreateJpeg();

            // Create LowLagPhotoCapture object
            lowLagCaptureMgr = await mediaCaptureManager.PrepareLowLagPhotoCaptureAsync(imgFormat);
        }

        async private void CaptureLagPhotoCapture_Click(object sender, RoutedEventArgs e)
        {
            // Take photo
            CapturedPhoto photo = await lowLagCaptureMgr.CaptureAsync();

            // Get photo as a BitmapImage
            BitmapImage bitmap = new BitmapImage();
            await bitmap.SetSourceAsync(photo.Frame);

            // Get thumbnail as a BitmapImage
            BitmapImage bitmapThumbnail = new BitmapImage();    
            await bitmapThumbnail.SetSourceAsync(photo.Thumbnail);

            // imageLowLagPhoto is a <Image> object defined in XAML
            imageLowLagPhoto.Source = bitmap;

            // imageLowLagThumbnail is a <Image> object defined in XAML
            imageLowLagThumbnail.Source = bitmapThumbnail;
        }

        async private void CloseLagPhotoCapture_Click(object sender, RoutedEventArgs e)
        {
            // Release the LowLagPhotoCapture object and resources
            await lowLagCaptureMgr.FinishAsync();
        }
        // </SnippetMediaCaptureLowLagPhotoCaptureCode>
        

        async private void InitalizeCamera(MediaCapture captureManager)
        {
            captureManager = new MediaCapture();
            await captureManager.InitializeAsync();
        }

        async private void RecordVideo_Click(object sender, RoutedEventArgs e)
        {
            captureFile = await KnownFolders.VideosLibrary.CreateFileAsync(
                "video",
                Windows.Storage.CreationCollisionOption.GenerateUniqueName);

            MediaEncodingProfile recordProfile = null;
            recordProfile = MediaEncodingProfile.CreateMp4(Windows.Media.MediaProperties.VideoEncodingQuality.Auto);

            await captureManager.StartRecordToStorageFileAsync(recordProfile, captureFile);
        }

        async private void StopRecord_Click(object sender, RoutedEventArgs e)
        {
            await captureManager.StopRecordAsync();
        }

        async private void PlayVideo_Click(object sender, RoutedEventArgs e)
        {
            var stream = await captureFile.OpenAsync(Windows.Storage.FileAccessMode.Read);

            mediaPreivew.SetSource(stream, captureFile.FileType);
        }


        // Capture Frame
        private void GetDevices()
        {
             var videoDevices = MediaCaptureInitializationSettings.GetVideoDevices();
            
            foreach (var d in videoDevices)
            {
                txtDisplay.Text += string.Format("{0}{1}",d.Name, Environment.NewLine);
            }
        }

        async private void CaptureHandler1(
            LowLagPhotoSequenceCapture senders, PhotoCapturedEventArgs args)
        {
            CapturedFrame frame = args.Frame;

            // var is bool
            var result = await frame.FlushAsync();
        }
       
        private void CaptureHandler2(
            LowLagPhotoSequenceCapture senders, PhotoCapturedEventArgs args)
        {
            CapturedFrame frame = args.Frame;

            // var is IAsyncOperation<TResult>
            var result = frame.FlushAsync();

           
        }

        async private void GetDevices_Click(object sender, RoutedEventArgs e)
        {
            GetDevices();

            MediaCapture mc = new MediaCapture();

            await mc.InitializeAsync();
            capturePreview.Source = mc;
            await mc.StartPreviewAsync();

            var horLenght = mc.MediaCaptureSettings.Horizontal35mmEquivalentFocalLength;
            var vertLength = mc.MediaCaptureSettings.Vertical35mmEquivalentFocalLength;

            txtDisplay.Text += horLenght;
            txtDisplay.Text += vertLength;

            // var aov = 2 * (Math.Atan(
        }



        // <SnippetCameraCaptureUI>
        async private void CameraCaptureUI_Click(object sender, RoutedEventArgs e)
        {
            CameraCaptureUI cameraUI = new CameraCaptureUI();
            
            Windows.Storage.StorageFile capturedMedia = 
                await cameraUI.CaptureFileAsync(CameraCaptureUIMode.Video);

            if (capturedMedia != null)
            {
                var stream = await capturedMedia.OpenAsync(FileAccessMode.Read);

                mediaPreivew.SetSource(stream, capturedMedia.ContentType);
                mediaPreivew.Play();
            }
        }
        // </SnippetCameraCaptureUI>
    }
}
