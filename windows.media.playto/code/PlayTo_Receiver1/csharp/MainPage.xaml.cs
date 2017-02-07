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

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace App1
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

        // <SnippetStartAndStop>
        Windows.Media.PlayTo.PlayToReceiver receiver;
        Windows.System.Display.DisplayRequest display;
        Windows.UI.Core.CoreDispatcher dispatcher;
        bool seeking = false;

        private async void StartReceiverButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                dispatcher = Window.Current.CoreWindow.Dispatcher;

                if (receiver == null)
                {
                    receiver = new Windows.Media.PlayTo.PlayToReceiver();
                }

                // Add Play To Receiver events and properties
                receiver.CurrentTimeChangeRequested += receiver_CurrentTimeChangeRequested;
                receiver.MuteChangeRequested += receiver_MuteChangeRequested;
                receiver.PauseRequested += receiver_PauseRequested;
                receiver.PlaybackRateChangeRequested += receiver_PlaybackRateChangeRequested;
                receiver.PlayRequested += receiver_PlayRequested;
                receiver.SourceChangeRequested += receiver_SourceChangeRequested;
                receiver.StopRequested += receiver_StopRequested;
                receiver.TimeUpdateRequested += receiver_TimeUpdateRequested;
                receiver.VolumeChangeRequested += receiver_VolumeChangeRequested;

		// <SnippetProperties>
                receiver.FriendlyName = "Sample Play To Receiver";
                receiver.SupportsAudio = false;
                receiver.SupportsVideo = true;
                receiver.SupportsImage = false;
		// </SnippetProperties>

                // Add MediaElement events
                VideoPlayer.CurrentStateChanged += VideoPlayer_CurrentStateChanged;
                VideoPlayer.MediaEnded += VideoPlayer_MediaEnded;
                VideoPlayer.MediaFailed += VideoPlayer_MediaFailed;
                VideoPlayer.MediaOpened += VideoPlayer_MediaOpened;
                VideoPlayer.RateChanged += VideoPlayer_RateChanged;
                VideoPlayer.SeekCompleted += VideoPlayer_SeekCompleted;
                VideoPlayer.VolumeChanged += VideoPlayer_VolumeChanged;

		// <SnippetStartAsync>
                // Advertise the receiver on the local network and start receiving commands
                await receiver.StartAsync();

                // Prevent the screen from locking
                if (display == null)
                    display = new Windows.System.Display.DisplayRequest();
                display.RequestActive();

                StatusTextBlock.Text = "'" + receiver.FriendlyName + "' started.";
		// </SnippetStartAsync>
            }
            catch
            {
                receiver = null;
                StatusTextBlock.Text = "Failed to start receiver.";
            }
        }

        private async void StopReceiverButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                // <SnippetStopAsync>
                if (receiver != null)
                {
                    await receiver.StopAsync();

                    if (display != null)
                        display.RequestRelease();

                    // Remove Play To Receiver events
                    receiver.CurrentTimeChangeRequested -= receiver_CurrentTimeChangeRequested;
                    receiver.MuteChangeRequested -= receiver_MuteChangeRequested;
                    receiver.PauseRequested -= receiver_PauseRequested;
                    receiver.PlaybackRateChangeRequested -= receiver_PlaybackRateChangeRequested;
                    receiver.PlayRequested -= receiver_PlayRequested;
                    receiver.SourceChangeRequested -= receiver_SourceChangeRequested;
                    receiver.StopRequested -= receiver_StopRequested;
                    receiver.TimeUpdateRequested -= receiver_TimeUpdateRequested;
                    receiver.VolumeChangeRequested -= receiver_VolumeChangeRequested;

                    //  Remove MediaElement events
                    VideoPlayer.Pause();

                    VideoPlayer.CurrentStateChanged -= VideoPlayer_CurrentStateChanged;
                    VideoPlayer.MediaEnded -= VideoPlayer_MediaEnded;
                    VideoPlayer.MediaFailed -= VideoPlayer_MediaFailed;
                    VideoPlayer.MediaOpened -= VideoPlayer_MediaOpened;
                    VideoPlayer.RateChanged -= VideoPlayer_RateChanged;
                    VideoPlayer.SeekCompleted -= VideoPlayer_SeekCompleted;
                    VideoPlayer.VolumeChanged -= VideoPlayer_VolumeChanged;

                    StatusTextBlock.Text = "Stopped '" + receiver.FriendlyName + "'.";
                }
                // </SnippetStopAsync>
            }
            catch
            {
                StatusTextBlock.Text = "Failed to stop '" + receiver.FriendlyName + "'.";
            }
        }
        // </SnippetStartAndStop>

        // <SnippetReceiverEvents>
        // <SnippetCurrentTimeChangeRequested>
        async void receiver_CurrentTimeChangeRequested(
            Windows.Media.PlayTo.PlayToReceiver sender,
            Windows.Media.PlayTo.CurrentTimeChangeRequestedEventArgs args)
        {
            await dispatcher.RunAsync(
                Windows.UI.Core.CoreDispatcherPriority.Normal, () =>
                {
                    VideoPlayer.Position = args.Time;
                    receiver.NotifySeeking();
                    seeking = true;
                });
        }
        // </SnippetCurrentTimeChangeRequested>

        // <SnippetMuteChangeRequested>
        async void receiver_MuteChangeRequested(
            Windows.Media.PlayTo.PlayToReceiver sender,
            Windows.Media.PlayTo.MuteChangeRequestedEventArgs args)
        {
            await dispatcher.RunAsync(
                Windows.UI.Core.CoreDispatcherPriority.Normal, () =>
                {
                    VideoPlayer.IsMuted = args.Mute;
                });
        }
        // </SnippetMuteChangeRequested>

        // <SnippetPauseRequested>
        async void receiver_PauseRequested(
            Windows.Media.PlayTo.PlayToReceiver sender,
            object args)
        {
            await dispatcher.RunAsync(
                Windows.UI.Core.CoreDispatcherPriority.Normal, () =>
                {
                    VideoPlayer.Pause();
                });
        }
        // </SnippetPauseRequested>

        // <SnippetPlaybackRateChangeRequested>
        async void receiver_PlaybackRateChangeRequested(
            Windows.Media.PlayTo.PlayToReceiver sender,
            Windows.Media.PlayTo.PlaybackRateChangeRequestedEventArgs args)
        {
            await dispatcher.RunAsync(
                Windows.UI.Core.CoreDispatcherPriority.Normal, () =>
                {
                    VideoPlayer.PlaybackRate = args.Rate;
                });
        }
        // </SnippetPlaybackRateChangeRequested>

        // <SnippetPlayRequested>
        async void receiver_PlayRequested(
            Windows.Media.PlayTo.PlayToReceiver sender,
            object args)
        {
            await dispatcher.RunAsync(
                Windows.UI.Core.CoreDispatcherPriority.Normal, () =>
                {
                    VideoPlayer.Play();
                });
        }
        // </SnippetPlayRequested>

        // <SnippetSourceChangeRequested>
        async void receiver_SourceChangeRequested(
            Windows.Media.PlayTo.PlayToReceiver sender,
            Windows.Media.PlayTo.SourceChangeRequestedEventArgs args)
        {
            if (args.Stream != null)
                await dispatcher.RunAsync(
                    Windows.UI.Core.CoreDispatcherPriority.Normal, () =>
                    {
                        var stream = args.Stream as Windows.Storage.Streams.IRandomAccessStream;
                        VideoPlayer.SetSource(stream, args.Stream.ContentType);
                    });
        }
        // </SnippetSourceChangeRequested>

        // <SnippetStopRequested>
        async void receiver_StopRequested(
            Windows.Media.PlayTo.PlayToReceiver sender,
            object args)
        {
            await dispatcher.RunAsync(
                Windows.UI.Core.CoreDispatcherPriority.Normal, () =>
                {
                    VideoPlayer.Stop();
                });
        }
        // </SnippetStopRequested>

        // <SnippetTimeUpdateRequested>
        async void receiver_TimeUpdateRequested(
            Windows.Media.PlayTo.PlayToReceiver sender,
            object args)
        {
            await dispatcher.RunAsync(
                Windows.UI.Core.CoreDispatcherPriority.Normal, () =>
                {
                    if (VideoPlayer.Position != null)
                        receiver.NotifyTimeUpdate(VideoPlayer.Position);
                });
        }
        // </SnippetTimeUpdateRequested>

        // <SnippetVolumeChangeRequested>
        async void receiver_VolumeChangeRequested(
            Windows.Media.PlayTo.PlayToReceiver sender,
            Windows.Media.PlayTo.VolumeChangeRequestedEventArgs args)
        {
            await dispatcher.RunAsync(
                Windows.UI.Core.CoreDispatcherPriority.Normal, () =>
                {
                    VideoPlayer.Volume = args.Volume;
                });
        }
        // </SnippetVolumeChangeRequested>
        // </SnippetReceiverEvents>

        // <SnippetPlayerEvents>
        // <SnippetNotifyPlayPauseStopError>
        void VideoPlayer_CurrentStateChanged(object sender, RoutedEventArgs e)
        {
            if (receiver != null)
            {
                switch (VideoPlayer.CurrentState)
                {
                    case MediaElementState.Playing:
                        receiver.NotifyPlaying();
                        break;
                    case MediaElementState.Paused:
                        receiver.NotifyPaused();
                        break;
                    case MediaElementState.Stopped:
                        receiver.NotifyStopped();
                        break;
                }
            }
        }

        void VideoPlayer_MediaFailed(object sender, ExceptionRoutedEventArgs e)
        {
            if (receiver != null) { receiver.NotifyError(); }
        }
        // </SnippetNotifyPlayPauseStopError>

        // <SnippetNotifyEnded>
        void VideoPlayer_MediaEnded(object sender, RoutedEventArgs e)
        {
            if (receiver != null)
            {
                receiver.NotifyEnded();
                VideoPlayer.Stop();
            }
        }
        // </SnippetNotifyEnded>

        // <SnippetNotifyDurationChange>
        void VideoPlayer_MediaOpened(object sender, RoutedEventArgs e)
        {
            if (receiver != null)
            {
                receiver.NotifyDurationChange(VideoPlayer.NaturalDuration.TimeSpan);
                receiver.NotifyLoadedMetadata();
            }
        }
        // </SnippetNotifyDurationChange>

        // <SnippetNotifyRateChange>
        void VideoPlayer_RateChanged(object sender, RateChangedRoutedEventArgs e)
        {
            if (receiver != null)
                receiver.NotifyRateChange(VideoPlayer.PlaybackRate);
        }
        // </SnippetNotifyRateChange>

        // <SnippetNotifySeek>
        void VideoPlayer_SeekCompleted(object sender, RoutedEventArgs e)
        {
            if (receiver != null)
            {
                if (!seeking)
                    receiver.NotifySeeking();
                receiver.NotifySeeked();
                seeking = false;
            }
        }
        // </SnippetNotifySeek>

        // <SnippetNotifyVolumeChanged>
        void VideoPlayer_VolumeChanged(object sender, RoutedEventArgs e)
        {
            if (receiver != null)
                receiver.NotifyVolumeChange(VideoPlayer.Volume, VideoPlayer.IsMuted);
        }
        // </SnippetNotifyVolumeChanged>
        // </SnippetPlayerEvents>
    }
}
