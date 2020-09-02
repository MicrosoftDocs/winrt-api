---
-api-id: T:Windows.Media.Capture.Frames.MediaFrameSourceGroup
-api-type: winrt class
---

<!-- Class syntax.
public class MediaFrameSourceGroup : Windows.Media.Capture.Frames.IMediaFrameSourceGroup
-->

# Windows.Media.Capture.Frames.MediaFrameSourceGroup

## -description
Represents a group of media frame sources that can be used simultaneously by a [MediaCapture](../windows.media.capture/mediacapture.md).

## -remarks
Get an instance of this class by calling [FindAllAsync](mediaframesourcegroup_findallasync_326280522.md) and selecting an instance from the returned list. If you know the unique identifier of a media frame source group, you can get an instance of this class by calling [FromIdAsync](mediaframesourcegroup_fromidasync_1322863552.md).

Initialize a [MediaCapture](../windows.media.capture/mediacapture.md) object to use the selected **MediaFrameSourceGroup** by assigning the group to the [SourceGroup](../windows.media.capture/mediacaptureinitializationsettings_sourcegroup.md) property of a [MediaCaptureInitializationSettings](../windows.media.capture/mediacaptureinitializationsettings.md) object, and then passing that settings object into [InitializeAsync](../windows.media.capture/mediacapture_initializeasync_315323248.md).

For how-to guidance on using [MediaFrameSource](mediaframesource.md) to capture frames, see [Process media frames with MediaFrameReader](/windows/uwp/audio-video-camera/process-media-frames-with-mediaframereader).

## -examples

## -see-also
[Process media frames with MediaFrameReader](/windows/uwp/audio-video-camera/process-media-frames-with-mediaframereader)