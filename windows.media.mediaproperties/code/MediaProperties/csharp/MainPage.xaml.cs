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
using Windows.System.Threading;
using Windows.Storage;
using Windows.Media;
using Windows.Media.MediaProperties;


// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace SimpleCaptureTest2
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        Windows.Media.Capture.MediaCapture captureManager;
        DispatcherTimer _timer;
        StorageFile recordFile;

        public MainPage()
        {
            this.InitializeComponent();
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            LogMessage(string.Format("{0}", MediaEncodingSubtypes.Aac));
            LogMessage(string.Format("{0}", MediaEncodingSubtypes.AacAdts));
            LogMessage(string.Format("{0}", MediaEncodingSubtypes.AacAdts));
            LogMessage(string.Format("{0}", MediaEncodingSubtypes.AmrNb));
            LogMessage(string.Format("{0}", MediaEncodingSubtypes.AmrWb));
            LogMessage(string.Format("{0}", MediaEncodingSubtypes.Argb32));
            LogMessage(string.Format("{0}", MediaEncodingSubtypes.Asf));
            LogMessage(string.Format("{0}", MediaEncodingSubtypes.Avi));
            LogMessage(string.Format("{0}", MediaEncodingSubtypes.Bgra8));
            LogMessage(string.Format("{0}", MediaEncodingSubtypes.Bmp));
            LogMessage(string.Format("{0}", MediaEncodingSubtypes.Eac3));
            LogMessage(string.Format("{0}", MediaEncodingSubtypes.Float));
            LogMessage(string.Format("{0}", MediaEncodingSubtypes.Gif));
            LogMessage(string.Format("{0}", MediaEncodingSubtypes.H263));
            LogMessage(string.Format("{0}", MediaEncodingSubtypes.H264));
            LogMessage(string.Format("{0}", MediaEncodingSubtypes.H264Es));
            LogMessage(string.Format("{0}", MediaEncodingSubtypes.Hevc));
            LogMessage(string.Format("{0}", MediaEncodingSubtypes.HevcEs));
            LogMessage(string.Format("{0}", MediaEncodingSubtypes.Iyuv));
            LogMessage(string.Format("{0}", MediaEncodingSubtypes.Jpeg));
            LogMessage(string.Format("{0}", MediaEncodingSubtypes.JpegXr));
            LogMessage(string.Format("{0}", MediaEncodingSubtypes.Mjpg));
            LogMessage(string.Format("{0}", MediaEncodingSubtypes.Mp3));
            LogMessage(string.Format("{0}", MediaEncodingSubtypes.Mpeg));
            LogMessage(string.Format("{0}", MediaEncodingSubtypes.Mpeg1));
            LogMessage(string.Format("{0}", MediaEncodingSubtypes.Mpeg2));
            LogMessage(string.Format("{0}", MediaEncodingSubtypes.Mpeg4));
            LogMessage(string.Format("{0}", MediaEncodingSubtypes.Nv12));
            LogMessage(string.Format("{0}", MediaEncodingSubtypes.Pcm));
            LogMessage(string.Format("{0}", MediaEncodingSubtypes.Png));
            LogMessage(string.Format("{0}", MediaEncodingSubtypes.Rgb24));

            VideoEncoding();
            VideoSubType();
        }

        void LogMessage(string msg)
        {
            txtDisplay.Text += string.Format("{0}{1}", msg, Environment.NewLine); ;
        }

        void VideoEncoding()
        {
            // <SnippetVideoPropertiesH264ProfileID>
            VideoEncodingProperties videoProps = 
                Windows.Media.MediaProperties.VideoEncodingProperties.CreateH264();

            videoProps.ProfileId = H264ProfileIds.High;
            // </SnippetVideoPropertiesH264ProfileID>
        }

        void VideoSubType()
        {
            // <SnippetVideoPropertiesSubType>
            VideoEncodingProperties videoProps = 
                VideoEncodingProperties.CreateUncompressed(MediaEncodingSubtypes.Bgra8, 720, 480);
            // </SnippetVideoPropertiesSubType>
        }

    }
}
