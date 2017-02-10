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
using Windows.Media;
using Windows.Media.Capture;
using Windows.Media.Transcoding;
using Windows.Graphics.Display;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace MediaXamlSnippets
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
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
        }

        private void btnStart_Click_1(object sender, RoutedEventArgs e)
        {
            media.Play();
        }

        private void btnStop_Click_1(object sender, RoutedEventArgs e)
        {
            media.Stop();
        }

        private void ChangeAudio(object sender, RoutedEventArgs e)
        {
            SetAudioLanguage("ja", media);
        }

        // <SnippetPlaybackAudioTracks>
        /// <summary>
        /// Attemps to set the audio track of a video to a specific language
        /// </summary>
        /// <param name="lcid">The id of the language. For example, "en" or "ja"</param>
        /// <returns>true if the track was set; otherwise, false.</returns>
        private bool SetAudioLanguage(string lcid, MediaElement media)
        {
            bool wasLanguageSet = false;

            for (int index = 0; index < media.AudioStreamCount; index++)
            {
                if (media.GetAudioStreamLanguage(index) == lcid)
                {
                    media.AudioStreamIndex = index;
                    wasLanguageSet = true;
                }
            }

            return wasLanguageSet;
        }
        // </SnippetPlaybackAudioTracks>

        private void btnRealTime_Click_1(object sender, RoutedEventArgs e)
        {
            // <SnippetPlaybackRealTime>
            MediaElement media = new MediaElement();
            media.RealTimePlayback = true;
            // </SnippetPlaybackRealTime>
        }

        Windows.Media.Capture.MediaCapture captureMgr;

        async void InitCapture()
        {
            captureMgr = new Windows.Media.Capture.MediaCapture();

            await captureMgr.InitializeAsync();

            capturePreview.Source = captureMgr;

            await captureMgr.StartPreviewAsync();

        }

        private void btCapture_Click_1(object sender, RoutedEventArgs e)
        {
            InitCapture();
        }


        private void btnCaptureRotate_Click(object sender, RoutedEventArgs e)
        {
            CaptureAndRotate(captureMgr);
        }

        async void CaptureAndRotate(MediaCapture captureMgrReal)
        {
            // <SnippetCaptureRotateAll>
            // <SnippetCaptureRotateInit>
            MediaCapture captureMgr = new MediaCapture();

            // Set the MediaCapture to a variable in App.xaml.cs to handle suspension.
            (App.Current as App).MediaCapture = captureMgr;

            await captureMgr.InitializeAsync();
            // </SnippetCaptureRotateInit>

            // <SnippetCaptureRotateSetRotate>
            captureMgr.SetPreviewRotation(VideoRotation.Clockwise90Degrees);
            // </SnippetCaptureRotateSetRotate>

            // <SnippetCaptureRotateGetRotate>
            VideoRotation previewRotation = captureMgr.GetPreviewRotation();
            // </SnippetCaptureRotateGetRotate>

            // Start capture preview.
            // capturePreview is a CaptureElement defined in XAML.
            capturePreview.Source = captureMgr;

            // Set the CaptureElement to a variable in App.xaml.cs to handle suspension.
            (App.Current as App).PreviewElement = capturePreview;

            // Lock the orientation of the display while previewing.
            DisplayInformation.AutoRotationPreferences = DisplayOrientations.Landscape;

            await captureMgr.StartPreviewAsync();

            // Set a tracking variable for preview state in App.xaml.cs
            (App.Current as App).IsPreviewing = true;
            // </SnippetCaptureRotateAll>    
        }

        async void RecordAndRotate(MediaCapture captureMgr)
        {
            captureMgr = new MediaCapture();
            await captureMgr.InitializeAsync();

            // <SnippetCaptureRotateSetRecordRotate>
            //captureMgr.SetRecordRotation(VideoRotation.Clockwise90Degrees);
            // </SnippetCaptureRotateSetRecordRotate>

            capturePreview.Source = captureMgr;
            await captureMgr.StartPreviewAsync();
        }
        //<SnippetStartRecordWithRotation>
        public async void StartRecordWithRotation(Windows.Storage.StorageFile videoFile)
        {

            var mediaEncodingProps = Windows.Media.MediaProperties.MediaEncodingProfile.CreateMp4(
                Windows.Media.MediaProperties.VideoEncodingQuality.Auto);

            System.Guid MFVideoRotationGuid =
            new System.Guid("C380465D-2271-428C-9B83-ECEA3B4A85C1"); // MF_MT_VIDEO_ROTATION in Mfapi.h

            int MFVideoRotation = ConvertVideoRotationToMFRotation(VideoRotation.Clockwise90Degrees);

            mediaEncodingProps.Video.Properties.Add(MFVideoRotationGuid, PropertyValue.CreateInt32(MFVideoRotation));

            await captureMgr.StartRecordToStorageFileAsync(mediaEncodingProps, videoFile);
        }
 
        int ConvertVideoRotationToMFRotation(VideoRotation rotation)
        {
            int MFVideoRotation = 0; // MFVideoRotationFormat::MFVideoRotationFormat_0 in Mfapi.h
            switch(rotation)
            {
            case VideoRotation.Clockwise90Degrees:
                MFVideoRotation = 90; // MFVideoRotationFormat::MFVideoRotationFormat_90;
                break;
            case VideoRotation.Clockwise180Degrees:
                MFVideoRotation = 180; // MFVideoRotationFormat::MFVideoRotationFormat_180;
                break;
            case VideoRotation.Clockwise270Degrees:
                MFVideoRotation = 270; // MFVideoRotationFormat::MFVideoRotationFormat_270;
                break;
            }
 
            return MFVideoRotation;
        }
        //</SnippetStartRecordWithRotation>


        async void AddEffectCapture(MediaCapture captureMgrReal)
        {
            // <SnippetCaptureAddEffect>
            MediaCapture captureMgr = new MediaCapture();
            await captureMgr.InitializeAsync();

            await captureMgr.AddEffectAsync(
                MediaStreamType.VideoRecord,
                Windows.Media.VideoEffects.VideoStabilization,
                null);
            // </SnippetCaptureAddEffect>

            // For Testing snippet.  Don't include in snippet.
            captureMgrReal = captureMgr;
            capturePreview.Source = captureMgrReal;
            await captureMgr.StartPreviewAsync();

            // <SnippetCaptureRemoveEffect>
            // captureMgr is of type MediaCapture.
            await captureMgr.ClearEffectsAsync(MediaStreamType.VideoRecord);
            // </SnippetCaptureRemoveEffect>
        }

        private void AddTranscoderEffect()
        {
            // <SnippetTranscodingAddEffect>
            MediaTranscoder transcoder = new MediaTranscoder();

            transcoder.AddVideoEffect(
                "Windows.Media.VideoEffects.VideoStabilization");
            // </SnippetTranscodingAddEffect>

            // <SnippetTranscodingRemoveEffect>
            transcoder.ClearEffects();
            // </SnippetTranscodingRemoveEffect>

        }

        async void ClearEffectsCapture(MediaCapture captureMgr)
        {
            await captureMgr.ClearEffectsAsync(MediaStreamType.VideoRecord);
        }

        private void btnRotate_Click_1(object sender, RoutedEventArgs e)
        {
            if (captureMgr != null)
            {
                if (captureMgr.GetPreviewRotation() == VideoRotation.None)
                {
                    captureMgr.SetPreviewRotation(VideoRotation.Clockwise90Degrees);
                }
                else if (captureMgr.GetPreviewRotation() == VideoRotation.Clockwise90Degrees)
                {
                    captureMgr.SetPreviewRotation(VideoRotation.Clockwise180Degrees);
                }
                else if (captureMgr.GetPreviewRotation() == VideoRotation.Clockwise180Degrees)
                {
                    captureMgr.SetPreviewRotation(VideoRotation.Clockwise270Degrees);
                }
                else if (captureMgr.GetPreviewRotation() == VideoRotation.Clockwise270Degrees)
                {
                    captureMgr.SetPreviewRotation(VideoRotation.None);
                }
            }
        }

        private void btnAddEffect_Click_1(object sender, RoutedEventArgs e)
        {
            AddEffectCapture(captureMgr);
        }

        private void btnRemoveEffect_Click_1(object sender, RoutedEventArgs e)
        {
            ClearEffectsCapture(captureMgr);
        }

        async void CaptureVideo()
        {
            // <SnippetCaptureVideoAll>
            // <SnippetCaptureVideoInit> 
            MediaCapture captureMgr = new MediaCapture();
            await captureMgr.InitializeAsync();
            // </SnippetCaptureVideoInit> 

            // <SnippetCaptureVideoStart>
            // Start capture preview.
            // capturePreview is a CaptureElement defined in XAML.
            capturePreview.Source = captureMgr;

            // Lock the display rotation before starting the preview.
            DisplayInformation.AutoRotationPreferences = DisplayOrientations.Landscape;

            await captureMgr.StartPreviewAsync();
            // </SnippetCaptureVideoStart>
            // </SnippetCaptureVideoAll> 
        }

        private void btnCapturePreview_Click_1(object sender, RoutedEventArgs e)
        {
            CaptureVideo();
        }

        // <SnippetPlaybackLocalFileAll>
        async private void SetLocalMedia()
        {
            // <SnippetPlaybackLocalFileFilePicker>
            var openPicker = new Windows.Storage.Pickers.FileOpenPicker();

            openPicker.FileTypeFilter.Add(".wmv");
            openPicker.FileTypeFilter.Add(".mp4");
            openPicker.FileTypeFilter.Add(".wma");
            openPicker.FileTypeFilter.Add(".mp3");

            var file = await openPicker.PickSingleFileAsync();
            // </SnippetPlaybackLocalFileFilePicker>

            // <SnippetPlaybackLocalFileSetSource>
            // mediaControl is a MediaElement defined in XAML
            if (null != file)
            {
                var stream = await file.OpenAsync(Windows.Storage.FileAccessMode.Read);
                mediaControl.SetSource(stream, file.ContentType);
                mediaControl.Play();
            }
            // </SnippetPlaybackLocalFileSetSource>
        }
        // </SnippetPlaybackLocalFileAll>


        private void btnPlayBackFilePicker_Click_1(object sender, RoutedEventArgs e)
        {
            SetLocalMedia();
        }

        // <SnippetMediaOpenedLiveStream>
        private void media_MediaOpened(object sender, RoutedEventArgs e)
        {
            bool isLive = IsLiveStream(sender as MediaElement);
        }

        private bool IsLiveStream(MediaElement media)
        {
            bool isLive = false;

            if (media.NaturalDuration.TimeSpan.Ticks == Int64.MaxValue)
            {
               isLive = true;
            }

            return isLive;
        }
        // </SnippetMediaOpenedLiveStream>



        //private void btnFoo_Click_1(object sender, RoutedEventArgs e)
        //{
        //    foreach (UIElement x in StackFoo.Children)
        //    {
        //        if (x is Button)
        //        {
        //            txtDisplay.Text += ((Button)x).Name + "  ";
        //        }
        //    }
        //}

        // <SnippetTimelineMarker>
        private void Media_MarkerReached(object sender, TimelineMarkerRoutedEventArgs e)
        {
            txOutput.Text =
                string.Format("{0},{1},{2}", e.Marker.Time, e.Marker.Text, e.Marker.Type);
        }
        // </SnippetTimelineMarker>
    }
}
