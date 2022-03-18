---
-api-id: P:Windows.Media.Capture.MediaCaptureVideoProfile.FrameSourceInfos
-api-type: winrt property
---

<!-- Property syntax.
public IVectorView<MediaFrameSourceInfo> FrameSourceInfos { get; }
-->

# Windows.Media.Capture.MediaCaptureVideoProfile.FrameSourceInfos

## -description
Gets a read-only list of [MediaFrameSourceInfo](../windows.media.capture.frames/mediaframesourceinfo.md) objects which provide details about the capabilities of a [MediaFrameSource](../windows.media.capture.frames/mediaframesource.md).

## -property-value
A read-only list of [MediaFrameSourceInfo](../windows.media.capture.frames/mediaframesourceinfo.md) objects.

## -remarks
When you use [MediaCapture](mediacapture.md) to capture from a [MediaFrameSourceGroup](../windows.media.capture.frames/mediaframesourcegroup.md), each individual frame source within the group is described by a [MediaFrameSourceInfo](../windows.media.capture.frames/mediaframesourceinfo.md). This property allows you to retrieve the **MediaFrameSourceInfo** objects that are associated with the [MediaCaptureVideoProfile](mediacapturevideoprofile.md).

## -see-also
[Discover and select camera capabilities with camera profiles](/windows/uwp/audio-video-camera/camera-profiles),
[Process media frames with MediaFrameReader](/windows/uwp/audio-video-camera/process-media-frames-with-mediaframereader)

## -examples

