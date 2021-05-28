---
-api-id: M:Windows.Media.Playback.MediaPlayer.CopyFrameToVideoSurface(Windows.Graphics.DirectX.Direct3D11.IDirect3DSurface,Windows.Foundation.Rect)
-api-type: winrt method
---

<!-- Method syntax.
public void MediaPlayer.CopyFrameToVideoSurface(IDirect3DSurface destination, Rect targetRectangle)
-->

# Windows.Media.Playback.MediaPlayer.CopyFrameToVideoSurface

## -description
Copies the current video frame from the **MediaPlayer** to the specified target rectangle within the provided **IDirect3DSurface**.

## -parameters

### -param destination
The **IDirect3DSurface** to which the video frame is copied.

### -param targetRectangle
The target rectangle within the **IDirect3DSurface** to which the video frame is copied.

## -remarks

For information on using **CopyFrameToVideoSurface** to apply GPU effects to video frames, see the [Use MediaPlayer in frame server mode](/windows/uwp/audio-video-camera/play-audio-and-video-with-mediaplayer#use-mediaplayer-in-frame-server-mode) section of [Play audio and video with MediaPlayer](/windows/uwp/audio-video-camera/play-audio-and-video-with-mediaplayer).

## -see-also

[Play audio and video with MediaPlayer](/windows/uwp/audio-video-camera/play-audio-and-video-with-mediaplayer)

## -examples

