---
-api-id: T:Windows.Media.Capture.Frames.MediaFrameSource
-api-type: winrt class
---

<!-- Class syntax.
public class MediaFrameSource : Windows.Media.Capture.Frames.IMediaFrameSource
-->

# Windows.Media.Capture.Frames.MediaFrameSource

## -description
Represents a source of media frames, such as a color or infrared camera.

## -remarks
To get an instance of **MediaFrameSource**, you must first initialize the [MediaCapture](../windows.media.capture/mediacapture.md) object with a [MediaFrameSourceGroup](mediaframesourcegroup.md) that includes your desired media frame source. You do this by setting the [SourceGroup](../windows.media.capture/mediacaptureinitializationsettings_sourcegroup.md) of the [MediaCaptureInitializationSettings](../windows.media.capture/mediacaptureinitializationsettings.md) object you pass into [MediaCapture.InitializeAsync](../windows.media.capture/mediacapture_initializeasync_315323248.md). Next, use the [MediaFrameSourceInfo.Id](mediaframesourceinfo_id.md) property associated with the desired frame source as the key in the **MediaCapture** object's [FrameSources](../windows.media.capture/mediacapture_framesources.md) dictionary to get an instance of the **MediaFrameSource** object.

For how-to guidance on using MediaFrameSource to capture frames, see [Process media frames with MediaFrameReader](/windows/uwp/audio-video-camera/process-media-frames-with-mediaframereader).

## -examples

## -see-also
[Process media frames with MediaFrameReader](/windows/uwp/audio-video-camera/process-media-frames-with-mediaframereader)
