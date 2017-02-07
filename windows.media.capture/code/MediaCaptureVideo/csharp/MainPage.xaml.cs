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
using System.Threading.Tasks;
using System.Threading;
using Windows.UI.Core;
using Windows.ApplicationModel.Core;
using Windows.UI.Xaml.Media.Imaging;

using Windows.Media.Capture;
using Windows.Media.Devices;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=391641

namespace MediaCaptureVideo
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        MainPage rootPage = null;

        

        public MainPage()
        {
            this.InitializeComponent();

            rootPage = this;

            this.NavigationCacheMode = NavigationCacheMode.Required;
        }

        /// <summary>
        /// Invoked when this page is about to be displayed in a Frame.
        /// </summary>
        /// <param name="e">Event data that describes how this page was reached.
        /// This parameter is typically used to configure the page.</param>
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            // TODO: Prepare page for display here.
        }
        //<SnippetMediaCaptureVideo_CompleteCS>

        MediaCaptureInitializationSettings _captureInitSettings;
        List<Windows.Devices.Enumeration.DeviceInformation> _deviceList;
        Windows.Media.MediaProperties.MediaEncodingProfile _profile;
        Windows.Media.Capture.MediaCapture _mediaCapture;
        bool _recording = false;
        bool _previewing = false;

        private async void EnumerateCameras()
        {
            var devices = await Windows.Devices.Enumeration.DeviceInformation.FindAllAsync(
                Windows.Devices.Enumeration.DeviceClass.VideoCapture);

            _deviceList = new List<Windows.Devices.Enumeration.DeviceInformation>();

            // Add the devices to deviceList
            if (devices.Count > 0)
            {

                for (var i = 0; i < devices.Count; i++)
                {
                    _deviceList.Add(devices[i]);
                }

                InitCaptureSettings();
                InitMediaCapture();
                rootPage.NotifyUser("Initialization complete.", NotifyType.StatusMessage);

            }
            else
            {
                rootPage.NotifyUser("No camera device is found ", NotifyType.ErrorMessage);
            }
        }

        // Begin initialization.
        private void Initialization()
        {
            rootPage.NotifyUser("Initialization started.", NotifyType.StatusMessage);
            EnumerateCameras();
        }


        // <SnippetMediaCaptureVideo_InitSettingsCS>
        private void InitCaptureSettings()
        {
            _captureInitSettings = null;
            _captureInitSettings = new Windows.Media.Capture.MediaCaptureInitializationSettings();
            _captureInitSettings.AudioDeviceId = "";
            _captureInitSettings.VideoDeviceId = "";
            _captureInitSettings.StreamingCaptureMode = Windows.Media.Capture.StreamingCaptureMode.AudioAndVideo;
            _captureInitSettings.PhotoCaptureSource = Windows.Media.Capture.PhotoCaptureSource.VideoPreview;
            
            if (_deviceList.Count > 0)
                _captureInitSettings.VideoDeviceId = _deviceList[0].Id;
        }
        // </SnippetMediaCaptureVideo_InitSettingsCS>

        // <SnippetMediaCaptureVideo_CreateProfileCS>
        // Create a profile.
        private void CreateProfile()
        {
            _profile = Windows.Media.MediaProperties.MediaEncodingProfile.CreateMp4(
            Windows.Media.MediaProperties.VideoEncodingQuality.Qvga);
        }
        // </SnippetMediaCaptureVideo_CreateProfileCS>

        // <SnippetMediaCaptureVideo_InitMCobjectCS>
        // Create and initialze the MediaCapture object.
        public async void InitMediaCapture()
        {
            _mediaCapture = null;
            // <SnippetMediaCaptureVideo_CreateMCobjectCS>
            _mediaCapture = new Windows.Media.Capture.MediaCapture();

            // Set the MediaCapture to a variable in App.xaml.cs to handle suspension.
            (App.Current as App).MediaCapture = _mediaCapture;
            // </SnippetMediaCaptureVideo_CreateMCobjectCS>

            await _mediaCapture.InitializeAsync(_captureInitSettings);

            CreateProfile();
        }
        // </SnippetMediaCaptureVideo_InitMCobjectCS>

        // <SnippetMediaCaptureVideo_StartRecordCS>
        // Start the video capture.
        private async void StartMediaCaptureSession()
        {
            var storageFile = await Windows.Storage.KnownFolders.VideosLibrary.CreateFileAsync(
                "cameraCapture.mp4", Windows.Storage.CreationCollisionOption.GenerateUniqueName);

            await _mediaCapture.StartRecordToStorageFileAsync(_profile, storageFile);
            _recording = true;
        }
        // </SnippetMediaCaptureVideo_StartRecordCS>

        // <SnippetMediaCaptureVideo_StopRecordCS>
        // Stop the video capture.
        private async void StopMediaCaptureSession()
        {
            await _mediaCapture.StopRecordAsync();
            _recording = false;
            (App.Current as App).IsRecording = false;
        }
        // </SnippetMediaCaptureVideo_StopRecordCS>
        // </SnippetMediaCaptureVideo_CompleteCS>


        public async Task CleanupCaptureResources()
        {
            if (_recording && _mediaCapture != null)
            {
                await _mediaCapture.StopRecordAsync();
                _recording = false;
            }
            if (_previewing && _mediaCapture != null)
            {
                await _mediaCapture.StopPreviewAsync();
                _previewing = false;
            }

            if (_mediaCapture != null)
            {
                if (previewElement != null)
                {
                    previewElement.Source = null;
                }
                _mediaCapture.Dispose();
            }
        }

        //protected async override void OnNavigatedFrom(NavigationEventArgs e)
        protected async override void OnNavigatingFrom(NavigatingCancelEventArgs e)
        {
            if (e.SourcePageType == typeof(MainPage))
            {
                await CleanupCaptureResources();
            }
            else
            {
                Task.Run(async () => await CleanupCaptureResources()).GetAwaiter().GetResult();
            }

        }


        public async void DevController()
        {

            // <SnippetMediaCaptureVideo_GetDeviceControllerCS>
            // Create the media capture object.
            var mediaCapture = new Windows.Media.Capture.MediaCapture();
            await mediaCapture.InitializeAsync();

            // Retrieve a video device controller.
            var videoDeviceController = mediaCapture.VideoDeviceController;

            // Retrieve an audio device controller.
            var audioDeviceController = mediaCapture.AudioDeviceController;
            // </SnippetMediaCaptureVideo_GetDeviceControllerCS>

            // <SnippetMediaCaptureVideo_SetVideoDeviceControllerPropertiesCS>
            // Retrieve the brightness capabilites of the video camera
            var brightnessCapabilities = videoDeviceController.Brightness.Capabilities;

            //
            // Determine if the video camera supports adjustment of the brightness setting.
            //
            if (brightnessCapabilities.Supported)
            {
                double brightness = 0;

                //
                // Retrieve the current brightness value.
                //

                if (videoDeviceController.Brightness.TryGetValue(out brightness))
                {
                    //
                    // Get the minimum, maximum and step size for the brightness value. 
                    // 
                    double min = brightnessCapabilities.Min;
                    double max = brightnessCapabilities.Max;
                    double step = brightnessCapabilities.Step;

                    //
                    // Increase the brightness value by one step as long as the new value is less than or equal to the maximum.
                    //

                    if ((brightness + step) <= max)
                    {
                        if (videoDeviceController.Brightness.TrySetValue(brightness + step))
                        {
                            // The brightness was successfully increased by one step.
                        }
                        else
                        {
                            // The brightness value couldn't be increased.
                        }
                    }
                    else
                    {
                        // The brightness value is greater than the maximum.
                    }
                }
                else
                {
                    // The brightness value couldn't be retrieved.
                }
            }
            else
            {
                // Setting the brightness value is not supported on this camera.
            }

            // </SnippetMediaCaptureVideo_SetVideoDeviceControllerProperties>
            // <SnippetMediaCaptureVideo_SetAudioDeviceControllerProperties>
            // Mute the microphone.
            audioDeviceController.Muted = true;

            // Un-mute the microphone.
            audioDeviceController.Muted = false;

            // Get the current volume setting.
            var currentVolume = audioDeviceController.VolumePercent;

            // Increase the volume by 10 percent, if possible.
            if (currentVolume <= 90)
            {
                audioDeviceController.VolumePercent = (currentVolume + 10);
            }
            // </SnippetMediaCaptureVideo_SetAudioDeviceControllerPropertiesCS>
        }


        // <SnippetMediaCaptureVideo_MirroringCompleteCS>
        public void TurnMirroringOn()
        {
            // <SnippetMediaCaptureVideo_PreviewMirroringCS>
            if( !_mediaCapture.GetPreviewMirroring() )
                _mediaCapture.SetPreviewMirroring(true);
            // </SnippetMediaCaptureVideo_PreviewMirroringCS>
        }

        public async void StopPreview()
        {
            // <SnippetMediaCaptureVideo_StopPreviewCS>   
            await _mediaCapture.StopPreviewAsync();
            // </SnippetMediaCaptureVideo_StopPreviewCS>
        }



        public async void startPreview()
        {

            _mediaCapture = new Windows.Media.Capture.MediaCapture();
            (App.Current as App).MediaCapture = _mediaCapture;
            
            await _mediaCapture.InitializeAsync();
            CreateProfile();

            TurnMirroringOn();

            // <SnippetMediaCaptureVideo_StartPreview>
            // Start Previewing
            await _mediaCapture.StartPreviewAsync();
            (App.Current as App).IsPreviewing = true;
            // </SnippetMediaCaptureVideo_StartPreview>

        }
        // </SnippetMediaCaptureVideo_MirroringComplete>

        //<SnippetAddSlowMotionEffectCS>
        public async void AddSlowMotionEffect()
        {

            Windows.Media.Effects.SlowMotionEffectDefinition slowMotionEffectDefinition = 
                new Windows.Media.Effects.SlowMotionEffectDefinition();

            // Setter and Getter for TimeStretchRate.
            slowMotionEffectDefinition.TimeStretchRate = 2;


            // Add the effect using the AddEffectAsync overloaded method
            await _mediaCapture.AddEffectAsync(
                MediaStreamType.VideoRecord,
                slowMotionEffectDefinition.ActivatableClassId,
                slowMotionEffectDefinition.Properties);

        }
        //</SnippetAddSlowMotionEffectCS>

        public void NotifyUser(string strMessage, NotifyType type)
        {
            if (StatusBlock != null)
            {
                switch (type)
                {
                    case NotifyType.StatusMessage:
                        StatusBorder.Background = new SolidColorBrush(Windows.UI.Colors.Green);
                        break;
                    case NotifyType.ErrorMessage:
                        StatusBorder.Background = new SolidColorBrush(Windows.UI.Colors.Red);
                        break;
                }
                StatusBlock.Text = strMessage;

                // Collapse the StatusBlock if it has no text to conserve real estate.
                if (StatusBlock.Text != String.Empty)
                {
                    StatusBorder.Visibility = Windows.UI.Xaml.Visibility.Visible;
                }
                else
                {
                    StatusBorder.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
                }
            }
            
        }
        //<SnippetEnablePhotoConfirmation>
        private void EnablePhotoConfirmation()
        {
            _mediaCapture.VideoDeviceController.PhotoConfirmationControl.Enabled = true;
            _mediaCapture.PhotoConfirmationCaptured += PhotoConfirmationCaptured;
        }
        //</SnippetEnablePhotoConfirmation>

        //<SnippetPhotoConfirmationCaptured>
        void PhotoConfirmationCaptured(MediaCapture sender, PhotoConfirmationCapturedEventArgs args)
        {
            using (ManualResetEventSlim evt = new ManualResetEventSlim(false))
            {
                CoreApplication.MainView.CoreWindow.Dispatcher.RunAsync(CoreDispatcherPriority.Normal, async () =>
                {
                    try
                    {
                        WriteableBitmap bmp = new WriteableBitmap(unchecked((int)args.Frame.Width), unchecked((int)args.Frame.Height));
                        using (var istream = args.Frame.AsStream())
                        using (var ostream = bmp.PixelBuffer.AsStream())
                        {
                            await istream.CopyStreamToAsync(ostream);
                        }
                    }
                    finally
                    {
                        evt.Set();
                    }

                });

                evt.Wait();
            }

        }
        //</SnippetPhotoConfirmationCaptured>
    }


    public enum NotifyType
    {
        StatusMessage,
        ErrorMessage
    };


    //<SnippetStreamExtenstions>

    public static class StreamEx
    {
        public static void CopyStreamTo(this Stream inputStream, Stream outputStream)
        {
            inputStream.CopyStreamTo(outputStream, 4096);
        }

        public static void CopyStreamTo(this Stream inputStream, Stream outputStream, int bufferSize)
        {
            if (inputStream == null)
            {
                throw new ArgumentNullException("inputStream");
            }

            if (!inputStream.CanSeek)
            {
                throw new ArgumentException("Cannot seek in the input stream.", "inputStream");
            }

            if (!inputStream.CanRead)
            {
                throw new ArgumentException("Input stream is not readable.", "inputStream");
            }

            if (outputStream == null)
            {
                throw new ArgumentNullException("outputStream");
            }

            if (!outputStream.CanSeek)
            {
                throw new ArgumentException("Cannot seek in the output stream.", "outputStream");
            }

            if (!outputStream.CanWrite)
            {
                throw new ArgumentException("Output stream is not writeable.", "outputStream");
            }

            if (bufferSize <= 0)
            {
                throw new ArgumentOutOfRangeException("bufferSize", "Buffer size is equal to zero or negative.");
            }

            inputStream.Seek(0, SeekOrigin.Begin);
            outputStream.Seek(0, SeekOrigin.Begin);

            byte[] buffer = new byte[bufferSize];
            while (inputStream.Position < inputStream.Length)
            {
                int bytesRead = inputStream.Read(buffer, 0, buffer.Length);
                outputStream.Write(buffer, 0, bytesRead);
            }
        }

        public static Task CopyStreamToAsync(this Stream inputStream, Stream outputStream)
        {
            return Task.Run(() => CopyStreamTo(inputStream, outputStream));
        }

        public static Task CopyStreamToAsync(this Stream inputStream, Stream outputStream, int bufferSize)
        {
            return Task.Run(() => CopyStreamTo(inputStream, outputStream, bufferSize));
        }
    }
    //</SnippetStreamExtenstions>

}
