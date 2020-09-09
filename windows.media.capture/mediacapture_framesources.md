---
-api-id: P:Windows.Media.Capture.MediaCapture.FrameSources
-api-type: winrt property
---

<!-- Property syntax
public Windows.Foundation.Collections.IMapView<string, Windows.Media.Capture.Frames.MediaFrameSource> FrameSources { get; }
-->

# Windows.Media.Capture.MediaCapture.FrameSources

## -description
Gets a read-only dictionary of [MediaFrameSource](../windows.media.capture.frames/mediaframesource.md) objects that can be used simultaneously to acquire media frames.

## -property-value
A read-only dictionary of [MediaFrameSource](../windows.media.capture.frames/mediaframesource.md) objects that can be used simultaneously to acquire media frames.

## -remarks
Initialize a [MediaCapture](mediacapturememorypreference.md) object to use media frame sources by setting the [SourceGroup](mediacaptureinitializationsettings_sourcegroup.md) property of the [MediaCaptureInitializationSettings](mediacaptureinitializationsettings.md) object to a [MediaFrameSourceGroup](../windows.media.capture.frames/mediaframesourcegroup.md) returned by [FindAllAsync](../windows.media.capture.frames/mediaframesourcegroup_findallasync_326280522.md) and then calling [MediaCapture.InitializeAsync](mediacapture_initializeasync_315323248.md). The key for each entry in the dictionary is the [Id](../windows.media.capture.frames/mediaframesourceinfo_id.md) property of the [MediaFrameSourceInfo](../windows.media.capture.frames/mediaframesourceinfo.md) associated with each frame source in the group.

For more information on using frame sources, see [Process media frames with MediaFrameReader](/windows/uwp/audio-video-camera/process-media-frames-with-mediaframereader).

## -examples

## -see-also

## -capabilities
backgroundMediaRecording
