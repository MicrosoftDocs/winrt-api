---
-api-id: T:Windows.UI.Xaml.Controls.MediaPlayerElement
-api-type: winrt class
---

<!-- Class syntax.
public class MediaPlayerElement : Windows.UI.Xaml.Controls.Control, Windows.UI.Xaml.Controls.IMediaPlayerElement
-->

# Windows.UI.Xaml.Controls.MediaPlayerElement

## -description

Represents an object that uses a [MediaPlayer](../windows.media.playback/mediaplayer.md) to render audio and video to the display.


## -xaml-syntax

```xaml
<MediaPlayerElement .../>
```

## -remarks

> [!TIP]
> For more info, design guidance, and code examples, see [Media playback](/windows/uwp/design/controls-and-patterns/media-playback).

For info about the media formats that MediaPlayerElement supports, see [Supported codecs](/windows/uwp/audio-video-camera/supported-codecs).

### Architectural overview

MediaPlayerElement is a lightweight XAML control that serves as a rendering surface for the robust [MediaPlayer](../windows.media.playback/mediaplayer.md) class, which is part of the [Windows.Media.Playback](../windows.media.playback/windows_media_playback.md) namespace. The majority of the media functionality is located on the underlying [MediaPlayer](../windows.media.playback/mediaplayer.md) class, which you can access through the [MediaPlayerElement.MediaPlayer](mediaplayerelement_mediaplayer.md) property.

For more information about the [MediaPlayer](../windows.media.playback/mediaplayer.md) class, including guidelines on how to transition from [MediaElement](mediaelement.md) to MediaPlayerElement, see the [Media playback](/windows/uwp/audio-video-camera/media-playback) page.

### Set the media source

Set the [Source](mediaplayerelement_source.md) property of the MediaPlayerElement to point to an audio or video file. You can set it to a [MediaSource](../windows.media.core/mediasource.md), [MediaPlaybackItem](../windows.media.playback/mediaplaybackitem.md), or [MediaPlaybackList](../windows.media.playback/mediaplaybacklist.md). The media files can be included with the app package or be on a network.

By default, the media that is defined by the [Source](mediaplayerelement_source.md) property does not immediately play after the MediaPlayerElement object has loaded. To start media playback automatically, set the [AutoPlay](mediaelement_autoplay.md) property to **true**.

Here's how to create a MediaPlayerElement in XAML with the [Source](mediaplayerelement_source.md) set to the path of a video file that is included in the app and the [AutoPlay](mediaelement_autoplay.md) property explicitly set to **true**.

```xaml
<MediaPlayerElement Source="ms-appx:///Media/video1.mp4" AutoPlay="True"/>
```

Here’s how to create the MediaPlayerElement in code.

```csharp
MediaPlayerElement mediaPlayerElement1 = new MediaPlayerElement();
mediaPlayerElement1.Source = MediaSource.CreateFromUri(new Uri("ms-appx:///Media/video1.mp4"));
mediaPlayerElement1.AutoPlay = true;
```

### Set the underlying media player

When the [Source](mediaplayerelement_source.md) property or [AutoPlay](mediaelement_autoplay.md) property is set on MediaPlayerElement, it will automatically create an underlying [MediaPlayer](../windows.media.playback/mediaplayer.md) if one doesn't already exist. Alternatively, you can create your own [MediaPlayer](../windows.media.playback/mediaplayer.md) and set it on MediaPlayerElement using the [SetMediaPlayer](mediaplayerelement_setmediaplayer_932380017.md) method. Here's an example of how to set the underlying [MediaPlayer](../windows.media.playback/mediaplayer.md) in code.


```xaml
<MediaPlayerElement x:Name="mpe"/>
```

```csharp
MediaPlayer mediaPlayer = new MediaPlayer();
mpe.SetMediaPlayer(mediaPlayer);
mpe.Source = MediaSource.CreateFromUri(new Uri("ms-appx:///Media/video1.mp4"));
mpe.AutoPlay = true;
```
> [!NOTE]
> Setting MediaPlayerElement properties will set the corresponding properties on its underlying [MediaPlayer](../windows.media.playback/mediaplayer.md). You have the option to use the underlying [MediaPlayer](../windows.media.playback/mediaplayer.md) directly instead of using MediaPlayerElement properties. Be aware that using [MediaPlayer](../windows.media.playback/mediaplayer.md) directly where an equivalent MediaPlayerElement property could otherwise be used can cause unexpected behavior. This is because the MediaPlayerElement is not aware of everything happening to its underlying [MediaPlayer](../windows.media.playback/mediaplayer.md). For example, if you set the source directly on [MediaPlayer](../windows.media.playback/mediaplayer.md), then MediaPlayerElement's [Source](mediaplayerelement_source.md) property will not reflect the change. For this reason, you must be consistent in using MediaPlayerElement properties or directly using the underlying [MediaPlayer](../windows.media.playback/mediaplayer.md). This documentation will use MediaPlayerElement properties whenever possible.

### Detach the underlying media player

The [MediaPlayer](../windows.media.playback/mediaplayer.md) is detached from MediaPlayerElement when the MediaPlayerElement is destroyed or when a new [MediaPlayer](../windows.media.playback/mediaplayer.md) is set using [SetMediaPlayer](mediaplayerelement_setmediaplayer_932380017.md). When detached, MediaPlayerElement treats the underlying [MediaPlayer](../windows.media.playback/mediaplayer.md) differently depending on whether it was created by MediaPlayerElement or set using [SetMediaPlayer](mediaplayerelement_setmediaplayer_932380017.md).

If the [MediaPlayer](../windows.media.playback/mediaplayer.md) was created by MediaPlayerElement, it will properly [Close](../windows.media.playback/mediaplayer_close_811482585.md) the [MediaPlayer](../windows.media.playback/mediaplayer.md) for you.

If the [MediaPlayer](../windows.media.playback/mediaplayer.md) was set on MediaPlayerElement using [SetMediaPlayer](mediaplayerelement_setmediaplayer_932380017.md), you are responsible for ensuring the [MediaPlayer](../windows.media.playback/mediaplayer.md) is properly closed. Failing to do so may result in fatal playback errors in [MediaPlayer](../windows.media.playback/mediaplayer.md). Here's how to properly detach and [Close](../windows.media.playback/mediaplayer_close_811482585.md) [MediaPlayer](../windows.media.playback/mediaplayer.md) in code.

```xaml
<MediaPlayerElement x:Name="mpe"/>
```

```csharp
MediaPlayer mediaPlayer = mpe.MediaPlayer;
IMediaPlaybackSource source = mpe.Source;

// 1. Pause playback if able.
if (mediaPlayer.PlaybackSession.CanPause)
{
    mediaPlayer.Pause();
}

// 2. Disconnect the MediaPlayer from its source. This can be done by setting 
//    the MediaPlayerElement Source property to null or by directly setting the
//    source to null on the underlying MediaPlayer.
mpe.Source = null;

// 3. Disconnect the MediaPlayer from MediaPlayerElement.
mpe.SetMediaPlayer(null);

// 4. Dispose of the MediaPlayer or Source if they're no longer needed.
if (source is MediaSource mediaSource)
{
    mediaSource.Dispose();
}
mediaPlayer.Dispose();
```

### Handle media events

You can respond to common media events located on the underlying [MediaPlayer](../windows.media.playback/mediaplayer.md) such as [MediaOpened](../windows.media.playback/mediaplayer_mediaopened.md), [MediaEnded](../windows.media.playback/mediaplayer_mediaended.md), and [MediaFailed](../windows.media.playback/mediaplayer_mediafailed.md). If you have set the source to a [MediaPlaybackItem](../windows.media.playback/mediaplaybackitem.md) or [MediaPlaybackList](../windows.media.playback/mediaplaybacklist.md), you should respond to the media events on those classes instead as they provide more information.

### Transport controls

Set the [AreTransportControlsEnabled](mediaplayerelement_aretransportcontrolsenabled.md) property to programmatically enable and disable the built in transport controls for the MediaPlayerElement. The built in transport controls provide UI for playing, stopping, pausing, and seeking the media as well as UI for volume, mute, full window, track selection, closed captions and remaining time.

You can create your own media transport controls by setting [AreTransportControlsEnabled](mediaplayerelement_aretransportcontrolsenabled.md) to **false**, and using the [Play](../windows.media.playback/mediaplayer_play_848564459.md) and [Pause](../windows.media.playback/mediaplayer_pause_1953642114.md) methods on [MediaPlayer](../windows.media.playback/mediaplayer.md). You can also control a rich set of properties by using the underlying [MediaPlayer](../windows.media.playback/mediaplayer.md) such as [Position](../windows.media.playback/mediaplayer_position.md), [Volume](../windows.media.playback/mediaplayer_volume.md), [IsMuted](../windows.media.playback/mediaplayer_ismuted.md), [IsLoopingEnabled](../windows.media.playback/mediaplayer_isloopingenabled.md), and [PlaybackRate](../windows.media.playback/mediaplayer_playbackrate.md).

> [!TIP]
> For better performance, avoid data binding to the [Position](../windows.media.playback/mediaplayer_position.md) property to reflect frequent position updates (for example with a progress bar). Instead, use the [DispatcherTimer](../windows.ui.xaml/dispatchertimer.md) to query the [Position](../windows.media.playback/mediaplayer_position.md) property.

For more info and examples, see [Create custom transport controls](/windows/uwp/controls-and-patterns/custom-transport-controls).

### Full window playback

Use the [IsFullWindow](mediaplayerelement_isfullwindow.md) property to enable and disable full window rendering. When in full-window mode the display is automatically prevented from being deactivated when user action is no longer detected.

> [!NOTE]
> We recommend that you not use MediaPlayerElement in a [Popup](../windows.ui.xaml.controls.primitives/popup.md) control. If a MediaPlayerElement hosted in a [Popup](../windows.ui.xaml.controls.primitives/popup.md) is switched to full-window mode, the [Popup](../windows.ui.xaml.controls.primitives/popup.md) is rendered on top of the MediaPlayerElement. If you must use a MediaPlayerElement in a [Popup](../windows.ui.xaml.controls.primitives/popup.md), you should collapse the [Popup](../windows.ui.xaml.controls.primitives/popup.md) when the MediaPlayerElement enters full-window mode, and restore the [Popup](../windows.ui.xaml.controls.primitives/popup.md) when the MediaPlayerElement exits full-window mode. Use [DependencyProperty.RegisterPropertyChangedCallback](../windows.ui.xaml/dependencyobject_registerpropertychangedcallback_1557279748.md) to be notified when the [MediaPlayerElement.IsFullWindow](mediaplayerelement_isfullwindow.md) property changes. For an example, see the Examples section.

### Keep media playing

To prevent the display from being deactivated when MediaPlayerElement is not in full-window mode, you can call [DisplayRequest.RequestActive](../windows.system.display/displayrequest_requestactive_1312599685.md). To conserve power and battery life, you should call [DisplayRequest.RequestRelease](../windows.system.display/displayrequest_requestrelease_966711579.md) to release the display request as soon as it is no longer required.

Here are some situations when you should release the display request:

+ Video playback is paused, for example by user action, buffering, or adjustment due to limited bandwidth.
+ Playback stops. For example, the video is done playing or the presentation is over.
+ A playback error has occurred. For example, network connectivity issues or a corrupted file.

Here, you use the [PlaybackStateChanged](../windows.media.playback/mediaplaybacksession_playbackstatechanged.md) event to detect these situations. Then, use the [NaturalVideoHeight](../windows.media.playback/mediaplaybacksession_naturalvideoheight.md) property of the [MediaPlayer.PlaybackSession](../windows.media.playback/mediaplayer_playbacksession.md) to determine whether an audio or video file is playing, and keep the screen active only if video is playing.

```xaml
<MediaPlayerElement x:Name="mpe" Source="ms-appx:///Media/video1.mp4"/>
```

```csharp
// Create this variable at a global scope. Set it to null.
private DisplayRequest appDisplayRequest = null;

protected override void OnNavigatedTo(NavigationEventArgs e)
{
    mpe.MediaPlayer.PlaybackSession.PlaybackStateChanged += MediaPlayerElement_CurrentStateChanged;
    base.OnNavigatedTo(e);
}

private void MediaPlayerElement_CurrentStateChanged(MediaPlaybackSession sender, object args)
{
    MediaPlaybackSession playbackSession = sender as MediaPlaybackSession;
    if (playbackSession != null && playbackSession.NaturalVideoHeight != 0)
    {
        if(playbackSession.PlaybackState == MediaPlaybackState.Playing)
        {
            if(appDisplayRequest == null)
            {
                // This call creates an instance of the DisplayRequest object
                appDisplayRequest = new DisplayRequest();
                appDisplayRequest.RequestActive();
            }
        }
        else // PlaybackState is Buffering, None, Opening, or Paused.
        {
            if(appDisplayRequest != null)
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

You can use the [PosterSource](mediaplayerelement_postersource.md) property to provide your MediaPlayerElement with a visual representation before the media is loaded or while audio-only media is playing. . A [PosterSource](mediaplayerelement_postersource.md) is an image, such as a screen shot, movie poster, or album cover, that is displayed in place of the media. The [PosterSource](mediaplayerelement_postersource.md) is displayed in the following situations:

+ When a valid source is not set. For example, [Source](mediaplayerelement_source.md) is not set, [Source](mediaplayerelement_source.md) was set to **Null**, or the source is invalid (as is the case when a [MediaFailed](../windows.media.playback/mediaplayer_mediafailed.md) event fires).
+ While media is loading. For example, a valid source is set, but the [MediaOpened](../windows.media.playback/mediaplayer_mediaopened.md) event has not fired yet.
+ When media is streaming to another device.
+ When the media is audio only.

## -examples

> [!TIP]
> For more info, design guidance, and code examples, see [Media playback](/windows/uwp/design/controls-and-patterns/media-playback).
>
> If you have the **WinUI 2 Gallery** app installed, click here to [open the app and see the MediaPlayerElement in action](winui2gallery:/item/MediaPlayerElement).
> + [Get the WinUI 2 Gallery app (Microsoft Store)](https://www.microsoft.com/store/productId/9MSVH128X2ZT)
> + [Get the source code (GitHub)](https://github.com/Microsoft/WinUI-Gallery)

This code creates a MediaPlayerElement with the [AutoPlay](mediaplayerelement_autoplay.md) property explicitly set to **true** and the [Source](mediaplayerelement_source.md) set to the path of a video file that is included in the app.

```xaml
<MediaPlayerElement Source="ms-appx:///Media/video1.mp4" AutoPlay="True" />
```

This example creates a MediaPlayerElement with the transport controls enabled.

```xaml
<MediaPlayerElement x:Name="mediaPlayer"
              Source="ms-appx:///Media/video1.mp4"
              AreTransportControlsEnabled="True" />
```

This example shows how to use a MediaPlayerElement in a Popup.

```xaml
<Grid>
    <Button Content="Show Popup" Click="ShowPopupClicked"/>
    <Popup x:Name="mediaPlayerPopup">
        <StackPanel Height="1400" Width="1400" Background="Blue">
            <MediaPlayerElement x:Name="mediaPlayer"
                  AreTransportControlsEnabled="True"
                  Source="ms-appx:///Media/Intro.wmv"/>
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
    token = mediaPlayer.RegisterPropertyChangedCallback(MediaPlayerElement.IsFullWindowProperty, OnMPEFullWindowChanged);
    base.OnNavigatedTo(e);
}

protected override void OnNavigatedFrom(NavigationEventArgs e)
{
    mediaPlayer.UnregisterPropertyChangedCallback(MediaPlayerElement.IsFullWindowProperty, token);
}

private void OnMPEFullWindowChanged(DependencyObject sender, DependencyProperty dp)
{
    MediaPlayerElement mpe = (MediaPlayerElement)sender;

    if (mpe != null && dp == MediaPlayerElement.IsFullWindowProperty)
    {
        if (mpe.IsFullWindow == true)
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

[Control](control.md), [Media playback overview](/windows/uwp/design/controls-and-patterns/media-playback), [Audio categories sample](https://github.com/Microsoft/Windows-universal-samples/tree/dev/Samples/AudioCategory), [Media transport controls sample](https://github.com/Microsoft/Windows-universal-samples/tree/dev/Samples/XamlCustomMediaTransportControls), [Version adaptive code sample](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/VersionAdaptiveCode)
