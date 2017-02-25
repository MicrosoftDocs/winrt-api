---
-api-id: P:Windows.Media.Playback.MediaPlayer.IsVideoFrameServerEnabled
-api-type: winrt property
---

<!-- Property syntax.
public bool IsVideoFrameServerEnabled { get;  set; }
-->

# Windows.Media.Playback.MediaPlayer.IsVideoFrameServerEnabled

## -description
Gets a value indicating whether video frame server mode is enabled for the **MediaPlayer** instance. 
## -property-value
True if video frame server mode is enabled; otherwise, false.

## -remarks
When frame server mode is enabled, the media player does not render video content. Instead, your app should register for the [VideoFrameAvailable](mediaplayer_videoframeavailable.md) event and call [CopyFrameToVideoSurface](mediaplayer_copyframetovideosurface_313890589.md) when the event is raised to get the video frame data.


## -see-also

## -examples

