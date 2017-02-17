---
-api-id: E:Windows.Media.Playback.MediaPlayer.VideoFrameAvailable
-api-type: winrt event
---

<!-- Event syntax.
public event TypedEventHandler VideoFrameAvailable<MediaPlayer,  object>
-->

# Windows.Media.Playback.MediaPlayer.VideoFrameAvailable

## -description
Occurs when [IsVideoFrameServerEnabled](mediaplayer_isvideoframeserverenabled.md) is set to true and a new video frame is available for processing.

## -remarks
In the handler for this event, call [CopyFrameToVideoSurface](mediaplayer_copyframetovideosurface_313890589.md) to get the video frame data.

## -see-also

## -examples

