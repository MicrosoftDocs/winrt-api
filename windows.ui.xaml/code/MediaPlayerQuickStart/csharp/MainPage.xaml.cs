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
using System.ComponentModel;
using System.Runtime.CompilerServices;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace MediaPlayerQuickStart
{
    // <SnippetMediaPlayer_AllCsharpCode>
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

        // <SnippetMediaPlayer_Fullscreen>
        // You should use the MediaElement.IsFullWindow property instead
        // to enable and disable full window rendering.
        private bool _isFullscreenToggle = false;
        public bool IsFullscreen
        {
            get { return _isFullscreenToggle; }
            set { _isFullscreenToggle = value; }
        }

        private Size _previousVideoContainerSize = new Size();

        private void FullscreenToggle()
        {
            this.IsFullscreen = !this.IsFullscreen;

            if (this.IsFullscreen)
            {    
                TransportControlsPanel.Visibility = Visibility.Collapsed;

                _previousVideoContainerSize.Width = videoContainer.ActualWidth;
                _previousVideoContainerSize.Height = videoContainer.ActualHeight;

                videoContainer.Width = Window.Current.Bounds.Width;
                videoContainer.Height = Window.Current.Bounds.Height;
                videoMediaElement.Width = Window.Current.Bounds.Width;
                videoMediaElement.Height = Window.Current.Bounds.Height;
            }
            else
            {
                TransportControlsPanel.Visibility = Visibility.Visible;

                videoContainer.Width = _previousVideoContainerSize.Width;
                videoContainer.Height = _previousVideoContainerSize.Height;
                videoMediaElement.Width = _previousVideoContainerSize.Width;
                videoMediaElement.Height = _previousVideoContainerSize.Height;
            }
        }

        private void btnFullScreenToggle_Click(object sender, RoutedEventArgs e)
        {
            FullscreenToggle();
        }

        private void VideoContainer_KeyUp(object sender, KeyRoutedEventArgs e)
        {
            if (IsFullscreen && e.Key == Windows.System.VirtualKey.Escape)
            {
                FullscreenToggle();
            }

            e.Handled = true;
        }
        // </SnippetMediaPlayer_Fullscreen>

        // <SnippetMediaPlayer_TransportHandlers>
        private void btnPlay_Click(object sender, RoutedEventArgs e)
        {
            if (videoMediaElement.DefaultPlaybackRate != 1)
            {
                videoMediaElement.DefaultPlaybackRate = 1.0;
            }

            videoMediaElement.Play();
        }

        private void btnPause_Click(object sender, RoutedEventArgs e)
        {
                videoMediaElement.Pause();
        }

        private void btnStop_Click(object sender, RoutedEventArgs e)
        {
            videoMediaElement.Stop();
        }

        private void btnForward_Click(object sender, RoutedEventArgs e)
        {
            videoMediaElement.DefaultPlaybackRate = 2.0;
            videoMediaElement.Play();
        }

        private void btnReverse_Click(object sender, RoutedEventArgs e)
        {
            videoMediaElement.DefaultPlaybackRate = -2;
            videoMediaElement.Play();;
        }

        private void btnVolumeDown_Click(object sender, RoutedEventArgs e)
        {
            if (videoMediaElement.IsMuted)
            {
                videoMediaElement.IsMuted = false;
            }

            if (videoMediaElement.Volume < 1)
            {
                videoMediaElement.Volume += .1;
            }
        }

        private void btnMute_Click(object sender, RoutedEventArgs e)
        {
            videoMediaElement.IsMuted = !videoMediaElement.IsMuted;
        }

        private void btnVolumeUp_Click(object sender, RoutedEventArgs e)
        {
            if (videoMediaElement.IsMuted)
            {
                videoMediaElement.IsMuted = false;
            }

            if (videoMediaElement.Volume > 0)
            {
                videoMediaElement.Volume -= .1;
            }
        }
        // </SnippetMediaPlayer_TransportHandlers>

        // <SnippetMediaPlayer_AudioPopulateTracks>
        private void cbAudioTracks_SelectionChanged(
            object sender, SelectionChangedEventArgs e)
        {
            videoMediaElement.AudioStreamIndex = cbAudioTracks.SelectedIndex;
        }
        
        private void PopulateAudioTracks(
            MediaElement media, ComboBox audioSelection)
        {
            if (media.AudioStreamCount > 0)
            {
                for (int index = 0; index < media.AudioStreamCount; index++)
                {
                    ComboBoxItem track = new ComboBoxItem();
                    track.Content = media.GetAudioStreamLanguage(index);
                    audioSelection.Items.Add(track);
                }
            }
        }
        // </SnippetMediaPlayer_AudioPopulateTracks>

        // <SnippetMediaPlayer_SliderTimerCode>
        // <SnippetMediaPlayer_MainPageLoaded>
        private void MainPage_Loaded(object sender, RoutedEventArgs e)
        {
            timelineSlider.ValueChanged += timelineSlider_ValueChanged;

            PointerEventHandler pointerpressedhandler = new PointerEventHandler(slider_PointerEntered);
            timelineSlider.AddHandler(Control.PointerPressedEvent, pointerpressedhandler, true);

            PointerEventHandler pointerreleasedhandler = new PointerEventHandler(slider_PointerCaptureLost);
            timelineSlider.AddHandler(Control.PointerCaptureLostEvent, pointerreleasedhandler, true);
        }

        void videoElement_MediaOpened(object sender, RoutedEventArgs e)
        {
            double absvalue = (int)Math.Round(
                videoMediaElement.NaturalDuration.TimeSpan.TotalSeconds,
                MidpointRounding.AwayFromZero);

            timelineSlider.Maximum = absvalue;

            timelineSlider.StepFrequency =
                SliderFrequency(videoMediaElement.NaturalDuration.TimeSpan);

            SetupTimer();

            // Helper method to populate the combobox with audio tracks.
            PopulateAudioTracks(videoMediaElement, cbAudioTracks);
        }
        // </SnippetMediaPlayer_MainPageLoaded>

        // <SnippetMediaPlayer_SliderPosition>
        private bool _sliderpressed = false;

        void slider_PointerEntered(object sender, PointerRoutedEventArgs e)
        {
            _sliderpressed = true;
        }

        void slider_PointerCaptureLost(object sender, PointerRoutedEventArgs e)
        {
            videoMediaElement.Position = TimeSpan.FromSeconds(timelineSlider.Value);
            _sliderpressed = false;
        }

        void timelineSlider_ValueChanged(object sender, Windows.UI.Xaml.Controls.Primitives.RangeBaseValueChangedEventArgs e)
        {
            if (!_sliderpressed)
            {
                videoMediaElement.Position = TimeSpan.FromSeconds(e.NewValue);
            }
        }

        void videoMediaElement_CurrentStateChanged(object sender, RoutedEventArgs e)
        {
            if (videoMediaElement.CurrentState == MediaElementState.Playing)
            {
                if (_sliderpressed)
                {
                    _timer.Stop();
                }
                else
                {
                    _timer.Start();
                }
            }

            if (videoMediaElement.CurrentState == MediaElementState.Paused)
            {
                _timer.Stop();
            }

            if (videoMediaElement.CurrentState == MediaElementState.Stopped)
            {
                _timer.Stop();
                timelineSlider.Value = 0;
            }
        }

        void videoMediaElement_MediaEnded(object sender, RoutedEventArgs e)
        {
            StopTimer();
            timelineSlider.Value = 0.0;
        }

        // <SnippetMediaPlayer_MediaFailedHandlers>
        private void videoMediaElement_MediaFailed(object sender, ExceptionRoutedEventArgs e)
        {
            // get HRESULT from event args 
            string hr = GetHresultFromErrorMessage(e);

            // Handle media failed event appropriately 
        }

        private string GetHresultFromErrorMessage(ExceptionRoutedEventArgs e)
        {
            String hr = String.Empty;
            String token = "HRESULT - ";
            const int hrLength = 10;     // eg "0xFFFFFFFF"

            int tokenPos = e.ErrorMessage.IndexOf(token, StringComparison.Ordinal);
            if (tokenPos != -1)
            {
                hr = e.ErrorMessage.Substring(tokenPos + token.Length, hrLength);
            }

            return hr;
        }
        // </SnippetMediaPlayer_MediaFailedHandlers>
        // </SnippetMediaPlayer_SliderPosition>

        // <SnippetMediaPlayer_TimerCode>
        private DispatcherTimer _timer;

        private void SetupTimer()
        {
            _timer = new DispatcherTimer();
            _timer.Interval = TimeSpan.FromSeconds(timelineSlider.StepFrequency);
            StartTimer();
        }

        private void _timer_Tick(object sender, object e)
        {
            if (!_sliderpressed)
            {
                timelineSlider.Value = videoMediaElement.Position.TotalSeconds;
            }
        }

        private void StartTimer()
        {
            _timer.Tick += _timer_Tick;
            _timer.Start();
        }

        private void StopTimer()
        {
            _timer.Stop();
            _timer.Tick -= _timer_Tick;
        }
        // </SnippetMediaPlayer_TimerCode>

        // <SnippetMediaPlayer_SliderFrequency>
        private double SliderFrequency(TimeSpan timevalue)
        {
            double stepfrequency = -1;

            double absvalue = (int)Math.Round(
                timevalue.TotalSeconds, MidpointRounding.AwayFromZero);

            stepfrequency = (int)(Math.Round(absvalue / 100));

            if (timevalue.TotalMinutes >= 10 && timevalue.TotalMinutes < 30)
            {
                stepfrequency = 10;
            }
            else if (timevalue.TotalMinutes >= 30 && timevalue.TotalMinutes < 60)
            {
                stepfrequency = 30;
            }
            else if (timevalue.TotalHours >= 1)
            {
                stepfrequency = 60;
            }

            if (stepfrequency == 0) stepfrequency += 1;

            if (stepfrequency == 1)
            {
                stepfrequency = absvalue / 100;
            }

            return stepfrequency;
        }
        // </SnippetMediaPlayer_SliderFrequency>
        // <SnippetMediaPlayer_SliderTimerCode>
    }
    // </SnippetMediaPlayer_AllCsharpCode>
}
