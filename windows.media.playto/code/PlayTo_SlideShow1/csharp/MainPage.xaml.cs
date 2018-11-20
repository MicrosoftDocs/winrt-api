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

namespace App1_CS
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

        // <SnippetInitialize_CS>
        private Windows.Media.PlayTo.PlayToManager ptm;
        private Windows.UI.Xaml.DispatcherTimer timer;
        private Windows.UI.Core.CoreDispatcher dispatcher = Window.Current.CoreWindow.Dispatcher;

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            ptm = Windows.Media.PlayTo.PlayToManager.GetForCurrentView();
            ptm.SourceRequested += SourceRequested;
            ptm.SourceSelected += SourceSelected;

            StartSlideShow();
        }
        // </SnippetInitialize_CS>

        // <SnippetSlideShow_CS>
        IReadOnlyList<Windows.Storage.StorageFile> imageList;   // contains the list of images to show
        bool streaming = false;      // true when streaming using Play To; otherwise false
        int timeLapse = 5;           // time between images (5 seconds)
        int imageSize = 600;         // size of current displayed image
        int thumbnailSize = 200;     // size of "thumbnail" of next image
        int currentImage = 0;        // index of the current image from imageList

        // Get the list of images from the Pictures folder and start the slide show.
        async private void StartSlideShow()
        {
            var resultsLibrary = await
                Windows.Storage.KnownFolders.PicturesLibrary.GetFilesAsync();
            imageList = resultsLibrary;
            if (imageList.Count > 0)
            {
                var image = QueueImage(0, true);
            }
            else
            {
                MessageBlock.Text = "There are no images in the Pictures library.";
            }
        }

        // PlayNextImage
        // Called when a new image is displayed due to a timeout.
        // Removes the current image object and queues a new next image.
        // Sets the next image index as the new current image, and increases the size 
        // of the new current image. Then sets the timeout to display the next image.

        private async void PlayNextImage(int num)
        {
            // Stop the timer to avoid repeating.
            if (timer != null) { timer.Stop(); }

            await dispatcher.RunAsync(Windows.UI.Core.CoreDispatcherPriority.Normal,
                async () =>
                {
                    SlideShowPanel.Children.Remove((UIElement)(SlideShowPanel.FindName("image" + num)));
                    var i = await QueueImage(num + 2, false);

                    currentImage = num + 1;
                    ((Image)SlideShowPanel.FindName("image" + currentImage)).Width = imageSize;
                });

            timer = new Windows.UI.Xaml.DispatcherTimer();
            timer.Interval = new TimeSpan(0, 0, timeLapse);
            timer.Tick += delegate(object sender, object e)
            {
                PlayNextImage(num + 1);
            };
            timer.Start();
        }

        // QueueImage
        // Called to create an image object for the displayed images.

        private async System.Threading.Tasks.Task<Image> QueueImage(int num, bool isFirstImage)
        {
            // Create the image element for the specified image index and add to the
            // slide show div.

            Image image = new Image();
            image.Width = isFirstImage ? imageSize : thumbnailSize;
            image.Name = "image" + num;
            image.VerticalAlignment = VerticalAlignment.Bottom;
            var fileContents = await imageList[num % imageList.Count].OpenReadAsync();
            var imageBitmap = new Windows.UI.Xaml.Media.Imaging.BitmapImage();
            imageBitmap.SetSource(fileContents);
            image.Source = imageBitmap;

            await dispatcher.RunAsync(Windows.UI.Core.CoreDispatcherPriority.Normal,
                () =>
                {
                    SlideShowPanel.Children.Add(image);
                });

            // If this is the first image of the slide show, queue the next image. Do
            // not queue if streaming as images are already queued before
            // streaming using Play To.

            if (isFirstImage && !streaming)
            {
                var i = await QueueImage(num + 1, false);

                timer = new Windows.UI.Xaml.DispatcherTimer();
                timer.Interval = new TimeSpan(0, 0, timeLapse);
                timer.Tick += delegate(object sender, object e)
                {
                    PlayNextImage(num);
                };
                timer.Start();
            }

            // Use the transferred event of the Play To connection for the current image object
            // to "move" to the next image in the slide show. The transferred event occurs
            // when the PlayToSource.playNext() method is called, or when the Play To
            // Receiver selects the next image.

            image.PlayToSource.Connection.Transferred += 
                async delegate(Windows.Media.PlayTo.PlayToConnection sender, 
                         Windows.Media.PlayTo.PlayToConnectionTransferredEventArgs e)
                   { 
                       currentImage = num + 1;

                       await dispatcher.RunAsync(Windows.UI.Core.CoreDispatcherPriority.Normal,
                           () =>
                           {
                               ((Image)SlideShowPanel.FindName("image" + currentImage)).Width = imageSize;
                           });
                   };


        // Use the statechanged event to determine which action to take or to respond
        // if the Play To Receiver is disconnected.
        image.PlayToSource.Connection.StateChanged += 
            async delegate(Windows.Media.PlayTo.PlayToConnection sender,
                     Windows.Media.PlayTo.PlayToConnectionStateChangedEventArgs e)
            {
                switch (e.CurrentState) {
                    case Windows.Media.PlayTo.PlayToConnectionState.Disconnected:

                        // If the state is disconnected and the current image index equals the 
                        // num value passed to queueImage, then the image element is not connected 
                        // to the Play To Receiver any more. Restart the slide show.
                        // Otherwise, the current image has been discarded and the slide show
                        // has moved to the next image. Clear the current image object and
                        // remove it from the slide show div.

                        if (currentImage == num)
                        {
                            await dispatcher.RunAsync(Windows.UI.Core.CoreDispatcherPriority.Normal, 
                                async () =>
                                {
                                    MessageBlock.Text = "Slideshow disconnected";

                                    // Cancel any existing timeout
                                    if (timer != null) { timer.Stop(); }

                                    // Clear all image objects from the slide show div
                                    SlideShowPanel.Children.Clear();

                                    // Reset the slide show objects and values to their beginning state
                                    streaming = false;
                                    DisconnectButton.Visibility = Visibility.Collapsed;
                                    InstructionsBlock.Visibility = Visibility.Visible;
                                    DisconnectButton.Click -= DisconnectButtonClick;

                                    // Restart the slide show from the current image index
                                    var i = await QueueImage(currentImage, true);
                                });
                        } 
                        else 
                        { 
                            await dispatcher.RunAsync(Windows.UI.Core.CoreDispatcherPriority.Normal,
                                    () =>
                                    {
                                        image.PlayToSource.Next = null;

                                        if (streaming)
                                        {
                                            SlideShowPanel.Children.Remove(image);
                                        }   
                                    });
                        }

                        break;
                    
                    case Windows.Media.PlayTo.PlayToConnectionState.Connected:

                        // If the state is connected and the previous state is disconnected, 
                        // then the image element is newly connected. Queue up the next image so 
                        // that it is loaded while the current image is being displayed.
                        // If the previous state is rendering, then the user has paused the slideshow 
                        // on the Play To Receiver. Clear the current timeout until the user restarts
                        // the slide show.
                        await dispatcher.RunAsync(Windows.UI.Core.CoreDispatcherPriority.Normal,
                            async () =>
                            {
                                if (e.PreviousState ==  Windows.Media.PlayTo.PlayToConnectionState.Disconnected)
                                {
                                    var imageNext = await QueueImage(num + 1, false);
                                    image.PlayToSource.Next = imageNext.PlayToSource;
                                } 
                                else if (e.PreviousState == Windows.Media.PlayTo.PlayToConnectionState.Rendering) 
                                {
                                    if (timer != null) { timer.Stop(); }
                                }

                                if (currentImage == num) 
                                {
                                    MessageBlock.Text = "Slideshow connected";
                                }
                            });
                        break;

                    case  Windows.Media.PlayTo.PlayToConnectionState.Rendering:

                        // If the state is rendering and the previous state is
                        // connected, then the Play To Receiver has restarted
                        // the slide show.
                            await dispatcher.RunAsync(Windows.UI.Core.CoreDispatcherPriority.Normal,
                                () =>
                                {
                                    if (e.PreviousState == Windows.Media.PlayTo.PlayToConnectionState.Connected)
                                    {
                                        // Clear any existing timeout.
                                        if (timer != null) { timer.Stop(); }

                                        // Restart the slide show.
                                        timer = new Windows.UI.Xaml.DispatcherTimer();
                                        timer.Interval = new TimeSpan(0, 0, timeLapse);
                                        timer.Tick += delegate(object s, object args)
                                        {
                                            image.PlayToSource.PlayNext();
                                        };
                                        timer.Start();
                                    }

                                    if (currentImage == num)
                                    {
                                        MessageBlock.Text = "Slideshow rendering";
                                    }
                               }); 
                        break;
                    }
                };

            return image;
        }
        // </SnippetSlideShow_CS>


        // <SnippetPlayToContract_CS>
        // Set up the Play To contract.

        // Used to pass an image to Play To that will not be removed/destroyed
        // by the slide show logic. For example, if the user opens the Devices
        // charm and the sourcerequested event fires, but the image display timeout
        // completes before the user selects a target device, then the image that
        // was being displayed is removed and destroyed. initialImage is never 
        // destroyed so Play To will always have a valid source to stream.
        Image initialImage = null;

        private async void SourceRequested(Windows.Media.PlayTo.PlayToManager sender, 
                                     Windows.Media.PlayTo.PlayToSourceRequestedEventArgs e)
        {
            var deferral = e.SourceRequest.GetDeferral();

            await dispatcher.RunAsync(Windows.UI.Core.CoreDispatcherPriority.Normal,
            () =>
            {
                initialImage = new Image();

                // Use the statechanged event of the image passed to Play To to determine when
                // the image is finally connected to the Play To Receiver.
                initialImage.PlayToSource.Connection.StateChanged += InitialImageConnectionStateChanged;

                // Provide Play To with the first image to stream.
                e.SourceRequest.SetSource(initialImage.PlayToSource);

                deferral.Complete();
            });
        }

        private async void InitialImageConnectionStateChanged(Windows.Media.PlayTo.PlayToConnection sender,
                                                              Windows.Media.PlayTo.PlayToConnectionStateChangedEventArgs e)
        {
                if (e.CurrentState == Windows.Media.PlayTo.PlayToConnectionState.Connected) {

                    await dispatcher.RunAsync(Windows.UI.Core.CoreDispatcherPriority.Normal, 
                        async () =>
                        {
                            // Clear any existing timeout.
                            if (timer != null) { timer.Stop(); }

                            // Clear the slide show panel.
                            SlideShowPanel.Children.Clear();

                            // Set the slide show objects and values to show that we are streaming.
                            streaming = true;
                            DisconnectButton.Visibility = Visibility.Visible;
                            InstructionsBlock.Visibility = Visibility.Collapsed;

                            // Queue and display the next image.
                            var image = await QueueImage(currentImage, true);
                            initialImage.PlayToSource.Next = image.PlayToSource;
                            initialImage.PlayToSource.PlayNext();
                        });
                };
        }

        // Update the once the user has selected a device to stream to.

        private async void SourceSelected(Windows.Media.PlayTo.PlayToManager sender, 
                                    Windows.Media.PlayTo.PlayToSourceSelectedEventArgs e)
        {
            await dispatcher.RunAsync(Windows.UI.Core.CoreDispatcherPriority.Normal,
                () =>
                {
                    DisconnectButton.Click += DisconnectButtonClick;
                    MessageBlock.Text = "Streaming to " + e.FriendlyName + "...";
                    DeviceBlock.Text = e.FriendlyName + ".\nClick here to disconnect.";
                    var imageBitmap = new Windows.UI.Xaml.Media.Imaging.BitmapImage();
                    imageBitmap.SetSource(e.Icon);
                    IconImage.Source = imageBitmap;
                });
        }

        private void DisconnectButtonClick(object sender, RoutedEventArgs e)
        {
            Windows.Media.PlayTo.PlayToManager.ShowPlayToUI();
        }
        // </SnippetPlayToContract_CS>

    }
}
