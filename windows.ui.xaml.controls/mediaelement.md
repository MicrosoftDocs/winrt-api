---
-api-id: T:Windows.UI.Xaml.Controls.MediaElement
-api-type: winrt class
---

<!-- Class syntax.
public class MediaElement : Windows.UI.Xaml.FrameworkElement, Windows.UI.Xaml.Controls.IMediaElement, Windows.UI.Xaml.Controls.IMediaElement2, Windows.UI.Xaml.Controls.IMediaElement3
-->

# Windows.UI.Xaml.Controls.MediaElement

## -description

Represents an object that renders audio and video to the display. See Remarks.


## -xaml-syntax

```xaml
<MediaElement .../>
```

## -remarks

> [!IMPORTANT] 
> In Windows 10, build 1607 and on we recommend that you use [MediaPlayerElement](mediaplayerelement.md) in place of MediaElement. **MediaPlayerElement** has the same functionality as **MediaElement**, while also enabling more advanced media playback scenarios. Additionally, all future improvements in media playback will happen in **MediaPlayerElement**.

> [!TIP]
> For more info, design guidance, and code examples, see [Media playback](/windows/uwp/design/controls-and-patterns/media-playback).

Use a MediaElement control to play audio and video files in your app. Built– in media transport controls let users interact with their media by providing a default playback experience comprised of various buttons including play, pause, closed captions, and others. See [MediaTransportControls](mediatransportcontrols.md) for more info.

For info about the media formats that MediaElement supports, see [Supported codecs](/windows/uwp/audio-video-camera/supported-codecs).

For info about performance related to MediaElement, see [Optimize animations and media](/windows/uwp/debug-test-perf/optimize-animations-and-media).

### Set the media source

Set the [Source](mediaelement_source.md) property of the MediaElement object to point to an audio or video file. The property can be set to the Uniform Resource Identifier (URI) of a file that is included with the app or the Uniform Resource Identifier (URI) of a file on the network. You can use the [SetSource](mediaelement_setsource_1817094346.md) method to set the source to a file retrieved from the local system by using a [FileOpenPicker](../windows.storage.pickers/fileopenpicker.md) object.

By default, the media that is defined by the [Source](mediaelement_source.md) property plays immediately after the MediaElement object has loaded. To suppress the media from starting automatically, set the [AutoPlay](mediaelement_autoplay.md) property to **false**.

Live media streams report a [NaturalDuration](mediaelement_naturalduration.md) of **Int64.MaxValue**.

Here's how to create a MediaElement in XAML with the Source set to the path of a video file that is included in the app and the AutoPlay property explicitly set to false.

```xaml
<MediaElement Source="Media/video1.mp4" AutoPlay="false"/>
```

Here's how to create the MediaElement in code.

```csharp
MediaElement mediaElement1 = new MediaElement();
mediaElement1.Source = new Uri("ms-appx:///Media/video1.mp4");
mediaElement1.AutoPlay = false;

// Add the MediaElement to the page.
rootGrid.Children.Add(mediaElement1);
```

### Handle media events

You can respond to common media events such as the [MediaOpened](mediaelement_mediaopened.md), [MediaEnded](mediaelement_mediaended.md), [MediaFailed](mediaelement_mediafailed.md), and [CurrentStateChanged](mediaelement_currentstatechanged.md) events. It is good practice to always handle the [MediaFailed](mediaelement_mediafailed.md) event.

### Transport controls

Set the [AreTransportControlsEnabled](mediaelement_aretransportcontrolsenabled.md) property to programmatically enable and disable the built in transport controls for the MediaElement. The built in transport controls provide UI for playing, stopping, pausing, and seeking the media, as well as UI for volume, mute, full window, track selection, and remaining time.

You can create your own media transport controls by setting [AreTransportControlsEnabled](mediaelement_aretransportcontrolsenabled.md) to **false**, and using the [Play](mediaelement_play_848564459.md), [Pause](mediaelement_pause_1953642114.md), and [Stop](mediaelement_stop_1201535524.md) methods. MediaElement also exposes a rich set of properties you can control like [Position](mediaelement_position.md), [Volume](mediaelement_volume.md), [IsMuted](mediaelement_ismuted.md), [IsLooping](mediaelement_islooping.md), [PlaybackRate](mediaelement_playbackrate.md), and [Balance](mediaelement_balance.md).

> [!TIP]
> For better performance, avoid data binding to the [Position](mediaelement_position.md) property to reflect frequent position updates (for example with a progress bar). Instead, use the [DispatcherTimer](../windows.ui.xaml/dispatchertimer.md) to query the [Position](mediaelement_position.md) property.

For more info and examples, see [Create custom transport controls](/windows/uwp/controls-and-patterns/custom-transport-controls).

### Open local media files

To open files on the local system or from Microsoft OneDrive, you can use the [FileOpenPicker](../windows.storage.pickers/fileopenpicker.md) to get the file and [SetSource](mediaelement_setsource_1817094346.md) to set the media source, or you can programmatically access the user media folders.

If your app needs access without user interaction to the **Music** or **Video** folders, for example if you are enumerating all the music or video files in the user's collection and displaying them in your app, then you need to declare the **Music Library** and **Video Library** capabilities. For more info, see [Files and folders in the Music, Pictures, and Videos libraries](/windows/uwp/files/quickstart-managing-folders-in-the-music-pictures-and-videos-libraries).

The [FileOpenPicker](../windows.storage.pickers/fileopenpicker.md) does not require special Capabilities to access files on the local file system, such as the user's **Music** or **Video** folders, since the user has complete control over which file is being accessed. From a security and privacy standpoint, it is best to minimize the number of capabilities your app uses.

### To open local media using FileOpenPicker

1. 1. Call [FileOpenPicker](../windows.storage.pickers/fileopenpicker.md) to let the user pick a media file.

Use the [FileOpenPicker](../windows.storage.pickers/fileopenpicker.md) class to select a media file. Set the [FileTypeFilter](../windows.storage.pickers/fileopenpicker_filetypefilter.md) to specify which file types the [FileOpenPicker](../windows.storage.pickers/fileopenpicker.md) will display. Call [PickSingleFileAsync](../windows.storage.pickers/fileopenpicker_picksinglefileasync_1320627792.md) to launch the file picker and get the file.
1. Call [SetSource](mediaelement_setsource_1817094346.md) to set the chosen media file as the [MediaElement.Source](mediaelement_source.md).

To set the [Source](mediaelement_source.md) of the MediaElement to the [StorageFile](../windows.storage/storagefile.md) returned from the [FileOpenPicker](../windows.storage.pickers/fileopenpicker.md), you need to open a stream. Call the [OpenAsync](../windows.storage/storagefile_openasync_1542217918.md) method on the [StorageFile](../windows.storage/storagefile.md) returns a stream that you can pass into the [MediaElement.SetSource](mediaelement_setsource_1817094346.md) method. Then call [Play](mediaelement_play_848564459.md) on the MediaElement to start the media.
This example shows how to use the [FileOpenPicker](../windows.storage.pickers/fileopenpicker.md) to choose a file and set the file as the [Source](mediaelement_source.md) of a MediaElement.

```xaml
<MediaElement x:Name="mediaPlayer"/>
...
<Button Content="Choose file" Click="Button_Click"/>

```

```csharp
private async void Button_Click(object sender, RoutedEventArgs e)
{
    await SetLocalMedia();
}

async private System.Threading.Tasks.Task SetLocalMedia()
{
    var openPicker = new Windows.Storage.Pickers.FileOpenPicker();

    openPicker.FileTypeFilter.Add(".wmv");
    openPicker.FileTypeFilter.Add(".mp4");
    openPicker.FileTypeFilter.Add(".wma");
    openPicker.FileTypeFilter.Add(".mp3");

    var file = await openPicker.PickSingleFileAsync();

    // mediaPlayer is a MediaElement defined in XAML
    if (file != null)
    {
        var stream = await file.OpenAsync(Windows.Storage.FileAccessMode.Read);
        mediaPlayer.SetSource(stream, file.ContentType);

        mediaPlayer.Play();
    }
}

```

### Select audio tracks in different languages

Use the [AudioStreamIndex](mediaelement_audiostreamindex.md) property and the [GetAudioStreamLanguage](mediaelement_getaudiostreamlanguage_366720426.md) method to change the audio to a different language track on a video. Videos can also contain multiple audio tracks in the same language, such as director commentaries on films. This example specifically shows how to switch between different languages, but you can modify this code to switch between any audio tracks.

### To select audio tracks in different languages

1. Get the audio tracks.

To search for a track in a specific language, start by iterating through each audio track on the video. Use [AudioStreamCount](mediaelement_audiostreamcount.md) as the max value for a **for** loop.
1. Get the language of the audio track.

Use the [GetAudioStreamLanguage](mediaelement_getaudiostreamlanguage_366720426.md) method to get the language of the track. The language of the track is identified by a [language code](/previous-versions/windows/internet-explorer/ie-developer/), such as **"en"** for English or **"ja"** for Japanese.
1. Set the active audio track.

When you find the track with the desired language, set the [AudioStreamIndex](mediaelement_audiostreamindex.md) to the index of the track. Setting [AudioStreamIndex](mediaelement_audiostreamindex.md) to **null** selects the default audio track which is defined by the content.
Here's some code that attempts to set the audio track to the specified language. It iterates through the audio tracks on a MediaElement object and uses [GetAudioStreamLanguage](mediaelement_getaudiostreamlanguage_366720426.md) to get the language of each track. If the desired language track exists, the [AudioStreamIndex](mediaelement_audiostreamindex.md) is set to the index of that track.

```csharp
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

```

### Full window playback

Use the [IsFullWindow](mediaelement_isfullwindow.md) property to enable and disable full window rendering. When in full-window mode, input events received on the MediaElement will still route through to the visual tree in the background. For example, if the MediaElement is in a [ListBox](listbox.md), turning the scroll wheel could cause the [ListBox](listbox.md) to scroll in the background. This can cause unexpected behavior. If input events should not be routed when in full-window mode, the MediaElement should handle the events.

> [!NOTE]
> We recommend that you not use MediaElement in a [Popup](../windows.ui.xaml.controls.primitives/popup.md) control. If a MediaElement hosted in a [Popup](../windows.ui.xaml.controls.primitives/popup.md) is switched to full-window mode, the [Popup](../windows.ui.xaml.controls.primitives/popup.md) is rendered on top of the MediaElement. If you must use a MediaElement in a [Popup](../windows.ui.xaml.controls.primitives/popup.md), you should collapse the [Popup](../windows.ui.xaml.controls.primitives/popup.md) when the MediaElement enters full-window mode, and restore the [Popup](../windows.ui.xaml.controls.primitives/popup.md) when the MediaElement exits full-window mode. Use [DependencyProperty.RegisterPropertyChangedCallback](../windows.ui.xaml/dependencyobject_registerpropertychangedcallback_1557279748.md) to be notified when the [MediaElement.IsFullWindow](mediaelement_isfullwindow.md) property changes. For an example, see the Examples section.

### Keep media playing

To prevent the display from being deactivated when user action is no longer detected, such as when an app is playing video, you can call [DisplayRequest.RequestActive](../windows.system.display/displayrequest_requestactive_1312599685.md). To conserve power and battery life, you should call [DisplayRequest.RequestRelease](../windows.system.display/displayrequest_requestrelease_966711579.md) to release the display request as soon as it is no longer required.

Here are some situations when you should release the display request:

+ Video playback is paused, for example by user action, buffering, or adjustment due to limited bandwidth.
+ Playback stops. For example, the video is done playing or the presentation is over.
+ A playback error has occurred. For example, network connectivity issues or a corrupted file.
Here, you use the [CurrentStateChanged](mediaelement_currentstatechanged.md) event to detect these situations. Then, use the [IsAudioOnly](mediaelement_isaudioonly.md) property to determine whether an audio or video file is playing, and keep the screen active only if video is playing.

```xaml
<MediaElement Source="Media/video1.mp4"
              CurrentStateChanged="MediaElement_CurrentStateChanged"/>
```

```csharp

// Create this variable at a global scope. Set it to null.
private DisplayRequest appDisplayRequest = null;

private void MediaElement_CurrentStateChanged(object sender, RoutedEventArgs e)
{
    MediaElement mediaElement = sender as MediaElement;
    if (mediaElement != null && mediaElement.IsAudioOnly == false)
    {
        if (mediaElement.CurrentState == Windows.UI.Xaml.Media.MediaElementState.Playing)
        {                
            if (appDisplayRequest == null)
            {
                // This call creates an instance of the DisplayRequest object. 
                appDisplayRequest = new DisplayRequest();
                appDisplayRequest.RequestActive();
            }
        }
        else // CurrentState is Buffering, Closed, Opening, Paused, or Stopped. 
        {
            if (appDisplayRequest != null)
            {
                // Deactivate the display request and set the var to null.
                appDisplayRequest.RequestRelease();
                appDisplayRequest = null;
            }
        }            
    }
}
```

### Poster source

You can use the [PosterSource](mediaelement_postersource.md) property to provide your MediaElement with a visual representation before the media is loaded. A [PosterSource](mediaelement_postersource.md) is an image, such as a screen shot or movie poster, that is displayed in place of the media. The [PosterSource](mediaelement_postersource.md) is displayed in the following situations:
+ When a valid source is not set. For example, [Source](mediaelement_source.md) is not set, [Source](mediaelement_source.md) was set to **Null**, or the source is invalid (as is the case when a [MediaFailed](mediaelement_mediafailed.md) event fires).
+ While media is loading. For example, a valid source is set, but the [MediaOpened](mediaelement_mediaopened.md) event has not fired yet.
+ When media is streaming to another device.
+ When the media is audio only.

### Notes for previous versions

### Windows 8.1

On Windows Phone, you can only have one MediaElement at a time.

To let audio continue to play when your app is in the background, set the [AudioCategory](mediaelement_audiocategory.md) property to **BackgroundCapableMedia**. This also requires declaring the "Audio" background task capability in the app manifest. These values are deprecated in Windows 10.

### Windows 8

Prior to Windows 8.1, the [IsFullWindow](mediaelement_isfullwindow.md) property in not available. To enable full window video playback you must set the [Width](../windows.ui.xaml/frameworkelement_width.md) and [Height](../windows.ui.xaml/frameworkelement_height.md) of the MediaElement to the [Window.Bounds](../windows.ui.xaml/window_bounds.md) of the current window. Specifically, use **Window.Current.Bounds.Width** and **Window.Current.Bounds.Height**. Full window playback will not take advantage of system optimizations if you set the dimensions of a parent element, such as a grid, or a containing element instead of the MediaElement.

Prior to Windows 8.1, the **Opacity** property is not supported on MediaElement.

Prior to Windows 8.1, the [AreTransportControlsEnabled](mediaelement_aretransportcontrolsenabled.md) property and built-in transport controls are not available. You must provide your own transport controls. For more info and examples, see [Create custom transport controls](/windows/uwp/controls-and-patterns/custom-transport-controls) and scenario 4 of the [XAML media playback sample](https://github.com/microsoftarchive/msdn-code-gallery-microsoft/tree/master/Official%20Windows%20Platform%20Sample/XAML%20media%20playback%20sample).

### Windows Phone 8

Windows Phone 8.x app must use [PickSingleFileAndContinue](../windows.storage.pickers/fileopenpicker_picksinglefileandcontinue_1567473542.md) to open local media files.

## -examples

This code creates a MediaElement with the [AutoPlay](mediaelement_autoplay.md) property explicitly set to **true** and the [Source](mediaelement_source.md) set to the path of a video file that is included in the app.

[!code-xaml[MediaPlayer_SimpleXamlMediaElement](../windows.ui.xaml/code/MediaPlayerQuickStart/csharp/BasicSnippets.xaml#SnippetMediaPlayer_SimpleXamlMediaElement)]

[!code-xaml[BasicMediaElementControls](../windows.ui.xaml.controls/code/MediaPlayback2/csharp/MainPage.xaml#SnippetBasicMediaElementControls)]

```xaml
<Grid>
    <Button Content="Show Popup" Click="ShowPopupClicked"/>
    <Popup x:Name="mediaPlayerPopup">
        <StackPanel Height="1400" Width="1400" Background="Blue">
            <MediaElement x:Name="mediaPlayer" 
                  AreTransportControlsEnabled="True" 
                  Source="Media/Intro.wmv"/>
            <TextBlock Text="Simple Popup"/>
            <Button Content="Close" Click="ClosePopupClicked"/>
        </StackPanel>
    </Popup>
</Grid>
```

```csharp

long token;

protected override void OnNavigatedTo(NavigationEventArgs e)
{
    token = mediaPlayer.RegisterPropertyChangedCallback(MediaElement.IsFullWindowProperty, OnMEFullWindowChanged);
    base.OnNavigatedTo(e);
}

protected override void OnNavigatedFrom(NavigationEventArgs e)
{
    mediaPlayer.UnregisterPropertyChangedCallback(MediaElement.IsFullWindowProperty, token);
}

private void OnMEFullWindowChanged(DependencyObject sender, DependencyProperty dp)
{
    MediaElement me = (MediaElement)sender;

    if (me != null && dp == MediaElement.IsFullWindowProperty)
    {
        if (me.IsFullWindow == true)
        {
            mediaPlayerPopup.Visibility = Visibility.Collapsed;
        }
        else
        {
            mediaPlayerPopup.Visibility = Visibility.Visible;
        }
    }  
}

private void ClosePopupClicked(object sender, RoutedEventArgs e)
{
    // If the Popup is open, then close it.
    if (mediaPlayerPopup.IsOpen) { mediaPlayerPopup.IsOpen = false; }
}

// Handles the Click event on the Button on the page and opens the Popup. 
private void ShowPopupClicked(object sender, RoutedEventArgs e)
{
    // Open the Popup if it isn't open already. 
    if (!mediaPlayerPopup.IsOpen) { mediaPlayerPopup.IsOpen = true; }
}
```

## -see-also

[Control](control.md), [MediaElement control guide](/windows/uwp/design/controls-and-patterns/media-playback), [Create custom transport controls](/windows/uwp/controls-and-patterns/custom-transport-controls), [Media transport controls sample](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/XamlCustomMediaTransportControls?amp;amp;clcid=0x409), [Video playback sample](https://go.microsoft.com/fwlink/p/?LinkId=620020&amp;amp;clcid=0x409), [Real-time communication sample (Windows 10)](https://go.microsoft.com/fwlink/p/?LinkId=620600), [Real-time communication sample (Windows 10)](https://go.microsoft.com/fwlink/p/?LinkId=620600), [Version adaptive code sample](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/VersionAdaptiveCode)
