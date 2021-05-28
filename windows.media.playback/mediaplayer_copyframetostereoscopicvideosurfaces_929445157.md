---
-api-id: M:Windows.Media.Playback.MediaPlayer.CopyFrameToStereoscopicVideoSurfaces(Windows.Graphics.DirectX.Direct3D11.IDirect3DSurface,Windows.Graphics.DirectX.Direct3D11.IDirect3DSurface)
-api-type: winrt method
---

<!-- Method syntax.
public void MediaPlayer.CopyFrameToStereoscopicVideoSurfaces(IDirect3DSurface destinationLeftEye, IDirect3DSurface destinationRightEye)
-->

# Windows.Media.Playback.MediaPlayer.CopyFrameToStereoscopicVideoSurfaces

## -description
Copies the video frame currently displayed by the **MediaPlayer** to the two provided **IDirect3DSurface** objects which represent the left eye and right eye content of a stereoscopic video frame.

## -parameters

### -param destinationLeftEye
The surface to which the left eye content is copied.

### -param destinationRightEye
The surface to which the right eye content is copied.

## -remarks

For information on using **CopyFrameToVideoSurface** to apply GPU effects to video frames, see the [Use MediaPlayer in frame server mode](/windows/uwp/audio-video-camera/play-audio-and-video-with-mediaplayer#use-mediaplayer-in-frame-server-mode) section of [Play audio and video with MediaPlayer](/windows/uwp/audio-video-camera/play-audio-and-video-with-mediaplayer).

## -see-also

[Play audio and video with MediaPlayer](/windows/uwp/audio-video-camera/play-audio-and-video-with-mediaplayer)

## -examples

