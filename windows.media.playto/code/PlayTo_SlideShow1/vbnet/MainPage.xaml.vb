' The Blank Page item template is documented at http:'go.microsoft.com/fwlink/?LinkId=234238

''' <summary>
''' An empty page that can be used on its own or navigated to within a Frame.
''' </summary>
Public NotInheritable Class MainPage
    Inherits Page

    ' <SnippetInitialize_CS>
    Private ptm As Windows.Media.PlayTo.PlayToManager
    Private timer As Windows.UI.Xaml.DispatcherTimer

    Protected Overrides Sub OnNavigatedTo(e As Navigation.NavigationEventArgs)
        ptm = Windows.Media.PlayTo.PlayToManager.GetForCurrentView()
        AddHandler ptm.SourceRequested, AddressOf SourceRequested
        AddHandler ptm.SourceSelected, AddressOf SourceSelected

        StartSlideShow()
    End Sub
    ' </SnippetInitialize_CS>


    ' <SnippetSlideShow_CS>
    Private imageList As IReadOnlyList(Of Windows.Storage.StorageFile)    ' contains the list of images to show
    Private streaming As Boolean = False       ' true when streaming using Play To otherwise false
    Private timeLapse As Integer = 5           ' time between images (5 seconds)
    Private imageSize As Integer = 600         ' size of current displayed image
    Private thumbnailSize As Integer = 200     ' size of "thumbnail" of next image
    Private currentImage As Integer = 0        ' index of the current image from imageList

    ' Get the list of images from the Pictures folder and start the slide show.
    Private Async Sub StartSlideShow()
        Dim resultsLibrary =
            Await Windows.Storage.KnownFolders.PicturesLibrary.GetFilesAsync()
        imageList = resultsLibrary
        If (imageList.Count > 0) Then
            Dim image = QueueImage(0, True)
        Else
            MessageBlock.Text = "There are no images in the Pictures library."
        End If
    End Sub

    ' PlayNextImage
    ' Called when a new image is displayed due to a timeout.
    ' Removes the current image object and queues a new next image.
    ' Sets the next image index as the new current image, and increases the size 
    ' of the new current image. Then sets the timeout to display the next image.

    Private Async Sub PlayNextImage(num As Integer)
        ' Stop the timer to avoid repeating.
        If timer IsNot Nothing Then timer.Stop()

        Await Dispatcher.RunAsync(Windows.UI.Core.CoreDispatcherPriority.Normal,
            Async Sub()
                SlideShowPanel.Children.Remove(CType(SlideShowPanel.FindName("image" & num), UIElement))
                Dim i = Await QueueImage(num + 2, False)

                currentImage = num + 1
                CType(SlideShowPanel.FindName("image" & currentImage), Image).Width = imageSize
            End Sub)

        timer = New Windows.UI.Xaml.DispatcherTimer()
        timer.Interval = New TimeSpan(0, 0, timeLapse)
        AddHandler timer.Tick, Sub(sender As Object, e As Object)
                                   PlayNextImage(num + 1)
                               End Sub
        timer.Start()
    End Sub

    ' QueueImage
    ' Called to create an image object for the displayed images.

    Private Async Function QueueImage(num As Integer, isFirstImage As Boolean) As Task(Of Image)
        ' Create the image element for the specified image index and add to the
        ' slide show div.

        Dim image = New Image()
        image.Width = If(isFirstImage, imageSize, thumbnailSize)
        image.Name = "image" & num
        image.VerticalAlignment = VerticalAlignment.Bottom
        Dim fileContents = Await imageList(num Mod imageList.Count).OpenReadAsync()
        Dim imageBitmap = New BitmapImage()
        imageBitmap.SetSource(fileContents)
        image.Source = imageBitmap

        Await Dispatcher.RunAsync(Windows.UI.Core.CoreDispatcherPriority.Normal,
            Sub()
                SlideShowPanel.Children.Add(image)
            End Sub)

        ' If this is the first image of the slide show, queue the next image. Do
        ' not queue if streaming as images are already queued before
        ' streaming using Play To.

        If isFirstImage AndAlso Not streaming Then

            Dim i = Await QueueImage(num + 1, False)

            timer = New Windows.UI.Xaml.DispatcherTimer()
            timer.Interval = New TimeSpan(0, 0, timeLapse)
            AddHandler timer.Tick, Sub(sender As Object, e As Object)
                                       PlayNextImage(num)
                                   End Sub
            timer.Start()
        End If

    ' Use the transferred event of the Play To connection for the current image object
    ' to "move" to the next image in the slide show. The transferred event occurs
    ' when the PlayToSource.playNext() method is called, or when the Play To
    ' Receiver selects the next image.

        AddHandler image.PlayToSource.Connection.Transferred,
            Async Sub(sender As Windows.Media.PlayTo.PlayToConnection,
                      e As Windows.Media.PlayTo.PlayToConnectionTransferredEventArgs)

                currentImage = num + 1

                Await Dispatcher.RunAsync(Windows.UI.Core.CoreDispatcherPriority.Normal,
                    Sub()
                        CType(SlideShowPanel.FindName("image" & currentImage), Image).Width = imageSize
                    End Sub)
            End Sub


        ' Use the statechanged event to determine which action to take or to respond
        ' if the Play To Receiver is disconnected.
        AddHandler image.PlayToSource.Connection.StateChanged,
            Async Sub(sender As Windows.Media.PlayTo.PlayToConnection,
                      e As Windows.Media.PlayTo.PlayToConnectionStateChangedEventArgs)

                Select Case e.CurrentState
                    Case Windows.Media.PlayTo.PlayToConnectionState.Disconnected

                        ' If the state is disconnected and the current image index equals the 
                        ' num value passed to queueImage, then the image element is not connected 
                        ' to the Play To Receiver any more. Restart the slide show.
                        ' Otherwise, the current image has been discarded and the slide show
                        ' has moved to the next image. Clear the current image object and
                        ' remove it from the slide show div.

                        If currentImage = num Then
                            Await Dispatcher.RunAsync(Windows.UI.Core.CoreDispatcherPriority.Normal,
                                Async Sub()
                                    MessageBlock.Text = "Slideshow disconnected"

                                    ' Cancel any existing timeout
                                    If timer IsNot Nothing Then timer.Stop()

                                    ' Clear all image objects from the slide show div
                                    SlideShowPanel.Children.Clear()

                                    ' Reset the slide show objects and values to their beginning state
                                    streaming = False
                                    DisconnectButton.Visibility = Visibility.Collapsed
                                    InstructionsBlock.Visibility = Visibility.Visible
                                    AddHandler DisconnectButton.Click, AddressOf DisconnectButtonClick

                                    ' Restart the slide show from the current image index
                                    Dim i = Await QueueImage(currentImage, True)
                                End Sub)
                        Else 
                               Await Dispatcher.RunAsync(Windows.UI.Core.CoreDispatcherPriority.Normal,
                                    Sub()
                                        image.PlayToSource.Next = Nothing

                                        If streaming Then
                                            SlideShowPanel.Children.Remove(image)
                                        End If
                                    End Sub)
                        End If

                    Case Windows.Media.PlayTo.PlayToConnectionState.Connected

                    ' If the state is connected and the previous state is disconnected, 
                    ' then the image element is newly connected. Queue up the next image so 
                    ' that it is loaded while the current image is being displayed.
                    ' If the previous state is rendering, then the user has paused the slideshow 
                    ' on the Play To Receiver. Clear the current timeout until the user restarts
                    ' the slide show.
                    Await Dispatcher.RunAsync(Windows.UI.Core.CoreDispatcherPriority.Normal,
                        Async Sub()
                                If e.PreviousState = Windows.Media.PlayTo.PlayToConnectionState.Disconnected Then
                                    Dim imageNext = Await QueueImage(num + 1, False)
                                    image.PlayToSource.Next = imageNext.PlayToSource
                                ElseIf e.PreviousState = Windows.Media.PlayTo.PlayToConnectionState.Rendering Then
                                    If timer IsNot Nothing Then timer.Stop()
                                End If

                                If currentImage = num Then
                                    MessageBlock.Text = "Slideshow connected"

                                End If
                            End Sub)

                    Case Windows.Media.PlayTo.PlayToConnectionState.Rendering

                    ' If the state is rendering and the previous state is
                    ' connected, then the Play To Receiver has restarted
                    ' the slide show.
                    Await Dispatcher.RunAsync(Windows.UI.Core.CoreDispatcherPriority.Normal,
                       Sub()
                               If e.PreviousState = Windows.Media.PlayTo.PlayToConnectionState.Connected Then

                                   ' Clear any existing timeout.
                                   If timer IsNot Nothing Then timer.Stop()

                                   ' Restart the slide show.
                                   timer = New Windows.UI.Xaml.DispatcherTimer()
                                   timer.Interval = New TimeSpan(0, 0, timeLapse)
                                   AddHandler timer.Tick, Sub(s As Object, args As Object)
                                                              image.PlayToSource.PlayNext()
                                                          End Sub
                                   timer.Start()
                               End If

                               If currentImage = num Then
                                   MessageBlock.Text = "Slideshow rendering"
                               End If
                           End Sub)
                End Select
                End Function

        Return image
    End Function
    ' </SnippetSlideShow_CS>

    ' <SnippetPlayToContract_CS>
    ' Set up the Play To contract.

    ' Used to pass an image to Play To that will not be removed/destroyed
    ' by the slide show logic. For example, if the user opens the Devices
    ' charm and the sourcerequested event fires, but the image display timeout
    ' completes before the user selects a target device, then the image that
    ' was being displayed is removed and destroyed. initialImage is never 
    ' destroyed so Play To will always have a valid source to stream.
    Private initialImage As Image = Nothing

    Private Async Sub SourceRequested(sender As Windows.Media.PlayTo.PlayToManager,
                                 e As Windows.Media.PlayTo.PlayToSourceRequestedEventArgs)

        Dim deferral = e.SourceRequest.GetDeferral()

        Await Dispatcher.RunAsync(Windows.UI.Core.CoreDispatcherPriority.Normal,
        Sub()
            initialImage = New Image()

            ' Use the statechanged event of the image passed to Play To to determine when
            ' the image is finally connected to the Play To Receiver.
            AddHandler initialImage.PlayToSource.Connection.StateChanged, AddressOf InitialImageConnectionStateChanged

            ' Provide Play To with the first image to stream.
            e.SourceRequest.SetSource(initialImage.PlayToSource)

            deferral.Complete()
        End Sub)
    End Sub

    Private Async Sub InitialImageConnectionStateChanged(sender As Windows.Media.PlayTo.PlayToConnection,
                                                             e As Windows.Media.PlayTo.PlayToConnectionStateChangedEventArgs)

        If e.CurrentState = Windows.Media.PlayTo.PlayToConnectionState.Connected Then

            Await Dispatcher.RunAsync(Windows.UI.Core.CoreDispatcherPriority.Normal,
                Async Sub()
                    ' Clear any existing timeout.
                    If timer IsNot Nothing Then timer.Stop()

                    ' Clear the slide show panel.
                    SlideShowPanel.Children.Clear()

                    ' Set the slide show objects and values to show that we are streaming.
                    streaming = True
                    DisconnectButton.Visibility = Visibility.Visible
                    InstructionsBlock.Visibility = Visibility.Collapsed

                    ' Queue and display the next image.
                    Dim image = Await QueueImage(currentImage, True)
                    initialImage.PlayToSource.Next = image.PlayToSource
                    initialImage.PlayToSource.PlayNext()
                End Sub)
        End If
    End Sub

    ' Update the once the user has selected a device to stream to.

    Private Async Sub SourceSelected(sender As Windows.Media.PlayTo.PlayToManager,
                                     e As Windows.Media.PlayTo.PlayToSourceSelectedEventArgs)

        Await Dispatcher.RunAsync(Windows.UI.Core.CoreDispatcherPriority.Normal,
            Sub()
                AddHandler DisconnectButton.Click, AddressOf DisconnectButtonClick
                MessageBlock.Text = "Streaming to " & e.FriendlyName & "..."
                DeviceBlock.Text = e.FriendlyName & "." & vbCr & "Click here to disconnect."
                Dim imageBitmap = New Windows.UI.Xaml.Media.Imaging.BitmapImage()
                imageBitmap.SetSource(e.Icon)
                IconImage.Source = imageBitmap
            End Sub)
    End Sub

    Private Sub DisconnectButtonClick()
        Windows.Media.PlayTo.PlayToManager.ShowPlayToUI()
    End Sub
    ' </SnippetPlayToContract_CS>
End Class
