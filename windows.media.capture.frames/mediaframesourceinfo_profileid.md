---
-api-id: P:Windows.Media.Capture.Frames.MediaFrameSourceInfo.ProfileId
-api-type: winrt property
---

<!-- Property syntax.
public string ProfileId { get; }
-->

# Windows.Media.Capture.Frames.MediaFrameSourceInfo.ProfileId

## -description
Gets the unique identifier of the [MediaCaptureVideoProfile](../windows.media.capture/mediacapturevideoprofile.md) associated with the [MediaFrameSourceInfo](mediaframesourceinfo.md).

## -property-value
The unique identifier of the **MediaCaptureVideoProfile** associated with the [MediaFrameSourceInfo](mediaframesourceinfo.md).

## -remarks
A [MediaCaptureVideoProfile](../windows.media.capture/mediacapturevideoprofile.md) represents a set of capture settings supported by a given sensor. This includes supported frame rates, resolutions, and whether the sensor can be used simultaneously with other capture devices. Use the [VideoProfileMediaDescription](../windows.media.capture/mediacapturevideoprofilemediadescription.md) property to discover the detailed capabilities of a [MediaFrameSource](mediaframesource.md). After selecting a frame source with your desired capabilities, you can use this property to get the identifier of the **MediaCaptureVideoProfile** object to use when initializing the [MediaCapture](../windows.media.capture/mediacapture.md) object in order to enable the desired capabilities.

## -see-also
[MediaCaptureVideoProfile](../windows.media.capture/mediacapturevideoprofile.md),[Discover and select camera capabilities with camera profiles](/windows/uwp/audio-video-camera/camera-profiles)



## -examples

