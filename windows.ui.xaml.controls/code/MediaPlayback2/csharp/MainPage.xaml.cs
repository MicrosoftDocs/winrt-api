using MediaPlayback2.Common;
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
using Windows.Media;
using Windows.Storage;
using Windows.Storage.Streams;
using Windows.Storage.Pickers;
using Windows.UI.Popups;


// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace MediaPlayback2
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        // <SnippetSystemMediaTransportControlsAll>
        // <SnippetSystemMediaTransportControlsBackgroundAll>
        // <SnippetSystemMediaTransportControlsSetup>
        SystemMediaTransportControls systemControls;

        public MainPage()
        {
            this.InitializeComponent();

            // Hook up app to system transport controls.
            systemControls = SystemMediaTransportControls.GetForCurrentView();
            systemControls.ButtonPressed += SystemControls_ButtonPressed;

            // Register to handle the following system transpot control buttons.
            systemControls.IsPlayEnabled = true;
            systemControls.IsPauseEnabled = true;
        }
        // </SnippetSystemMediaTransportControlsSetup>

        // <SnippetSystemMediaTransportControlsStateChange>
        void MusicPlayer_CurrentStateChanged(object sender, RoutedEventArgs e)
        {
            switch (musicPlayer.CurrentState)
            {
                case MediaElementState.Playing:
                    systemControls.PlaybackStatus = MediaPlaybackStatus.Playing;
                    break;
                case MediaElementState.Paused:
                    systemControls.PlaybackStatus = MediaPlaybackStatus.Paused;
                    break;
                case MediaElementState.Stopped:
                    systemControls.PlaybackStatus = MediaPlaybackStatus.Stopped;
                    break;
                case MediaElementState.Closed:
                    systemControls.PlaybackStatus = MediaPlaybackStatus.Closed;
                    break;
                default:
                    break;
            }
        }
        // </SnippetSystemMediaTransportControlsStateChange>

        // <SnippetSystemMediaTransportControlsButtonPressed>
        void SystemControls_ButtonPressed(SystemMediaTransportControls sender, 
            SystemMediaTransportControlsButtonPressedEventArgs args)
        {
            switch (args.Button)
            {
                case SystemMediaTransportControlsButton.Play:
                    PlayMedia();
                    break;
                case SystemMediaTransportControlsButton.Pause:
                    PauseMedia();
                    break;
                default:
                    break;
            }
        }

        async void PlayMedia()
        {
            await Dispatcher.RunAsync(Windows.UI.Core.CoreDispatcherPriority.Normal, () =>
            {
                musicPlayer.Play();
            });
        }

        async void PauseMedia()
        {
            await Dispatcher.RunAsync(Windows.UI.Core.CoreDispatcherPriority.Normal, () =>
            {
                musicPlayer.Pause();
            });
        }
        // </SnippetSystemMediaTransportControlsButtonPressed>
        // </SnippetSystemMediaTransportControlsBackgroundAll>

        // <SnippetSystemMediaTransportControlsUpdater>
        async private void UpdateSongInfo()
        {
            // Get the updater.
            SystemMediaTransportControlsDisplayUpdater updater = systemControls.DisplayUpdater;

            // Get the music file and pass it to CopyFromFileAsync to extract the metadata
            // and thumbnail. StorageFile is defined in Windows.Storage
            StorageFile musicFile =
                await StorageFile.GetFileFromApplicationUriAsync(new Uri("ms-appx:///Music/music1.mp3"));
            
            await updater.CopyFromFileAsync(MediaPlaybackType.Music, musicFile);

            // Update the system media transport controls
            updater.Update();
        }

        void MusicPlayer_MediaOpened(object sender, RoutedEventArgs e)
        {
            UpdateSongInfo();
        }
        // </SnippetSystemMediaTransportControlsUpdater>
        // <SnippetSystemMediaTransportControlsUpdaterManual>
        /// <summary>
        /// Shows how to update the media metadata and thumbnail manually.
        /// Normally you would probably retreive this info from a source such as a database
        /// but for this simple sample we'll just set the metadata with strings.
        /// </summary>
        void UpdateSongInfoManually()
        {
            // Get the updater.
            SystemMediaTransportControlsDisplayUpdater updater = systemControls.DisplayUpdater;

            // Music metadata.
            updater.MusicProperties.AlbumArtist = "artist";
            updater.MusicProperties.AlbumArtist = "album artist";
            updater.MusicProperties.Title = "song title";

            // Set the album art thumbnail.
            // RandomAccessStreamReference is defined in Windows.Storage.Streams
            updater.Thumbnail =
               RandomAccessStreamReference.CreateFromUri(new Uri("ms-appx:///Music/music1_AlbumArt.jpg"));

            // Update the system media transport controls.
            updater.Update();
        }
        // </SnippetSystemMediaTransportControlsUpdaterManual>
        // </SnippetSystemMediaTransportControlsAll>


        // <SnippetMediaElementEventHandlers>
        void Play_Click(object sender, RoutedEventArgs e)
        {
            media.Play();
        }

        void Pause_Click(object sender, RoutedEventArgs e)
        {
            if (media.CanPause)
            {
                media.Pause();
            }
        }

        void Stop_Click(object sender, RoutedEventArgs e)
        {
            media.Stop();
        }

        void Media_MediaFailed(object sender, ExceptionRoutedEventArgs e)
        {
            // Handle failed media event
        }

        void Media_MediaOpened(object sender, RoutedEventArgs e)
        {
            // Handle open media event
        }

        void Media_MediaEnded(object sender, RoutedEventArgs e)
        {
            // Handle media ended event
        }
        // </SnippetMediaElementEventHandlers>

        /// <summary>
        /// Invoked when this page is about to be displayed in a Frame.
        /// </summary>
        /// <param name="e">Event data that describes how this page was reached.  The Parameter
        /// property is typically used to configure the page.</param>
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
        }

        // <SnippetFullWindowEventHandler>
        private void FullWindow_Click(object sender, object e)
        {
            mediaPlayer.IsFullWindow = !media.IsFullWindow;
        }
        // </SnippetFullWindowEventHandler>

        // <SnippetLoadFileAll>
        // <SnippetLoadFileTextBoxHanlder>
        private void TxtFilePath_KeyUp(object sender, KeyRoutedEventArgs e)
        {
            if (e.Key == Windows.System.VirtualKey.Enter)
            {
                TextBox tbPath = sender as TextBox;

                if (tbPath != null)
                {
                    LoadMediaFromString(tbPath.Text);
                }
            }
        }
        // </SnippetLoadFileTextBoxHanlder>

        // <SnippetLoadFileFromUri>
        private void LoadMediaFromString(string path)
        {
            try
            {
                Uri pathUri = new Uri(path);
                mediaPlayer.Source = pathUri;
            }
            catch (Exception ex)
            {
                if (ex is FormatException)
                {
                    // handle exception. 
                    // For example: Log error or notify user problem with file
                }
            }
        }
        // </SnippetLoadFileFromUri>
        // </SnippetLoadFileAll>


        void EmbeddedFile_Click(object sender, RoutedEventArgs e)
        {
            LoadEmbeddedAppFile();
        }

        // <SnippetLoadEmbeddedAppFile>
        private void LoadEmbeddedAppFile()
        {
            try
            {
                Uri pathUri = new Uri("ms-appx:///Videos/video1.mp4");
                mediaPlayer.Source = pathUri;
            }
            catch (Exception ex)
            {
                if (ex is FormatException)
                {
                    // handle exception. 
                    // For example: Log error or notify user problem with file
                }
            }
        }
        // </SnippetLoadEmbeddedAppFile>

        // <SnippetMediaElementStretch>
        private void PictureSize_Click(object sender, RoutedEventArgs e)
        {
            switch (media.Stretch)
            {
                case Stretch.Fill:
                    mediaPlayer.Stretch = Stretch.None;
                    break;
                case Stretch.None:
                    mediaPlayer.Stretch = Stretch.Uniform;
                    break;
                case Stretch.Uniform:
                    mediaPlayer.Stretch = Stretch.UniformToFill;
                    break;
                case Stretch.UniformToFill:
                    mediaPlayer.Stretch = Stretch.Fill;
                    break;
                default:
                    break;
            }
        }
        // </SnippetMediaElementStretch>


        private void Foo()
        {
            AppBarButton b = new AppBarButton();
      //      b.Icon = new IconElement();

        }

        private void btnNextPage_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(BackgroundAudio));
 
        }
    }
}
