---
-api-id: P:Windows.Media.Capture.Frames.MediaFrameSourceInfo.VideoProfileMediaDescription
-api-type: winrt property
---

<!-- Property syntax.
public IVectorView<MediaCaptureVideoProfileMediaDescription> VideoProfileMediaDescription { get; }
-->

# Windows.Media.Capture.Frames.MediaFrameSourceInfo.VideoProfileMediaDescription

## -description
Gets a read-only list of [MediaCaptureVideoProfileMediaDescription](../windows.media.capture/mediacapturevideoprofilemediadescription.md) objects which specify a group of capture settings that are supported by a video profile.

## -property-value
A read-only list of [MediaCaptureVideoProfileMediaDescription](../windows.media.capture/mediacapturevideoprofilemediadescription.md) objects.

## -remarks
A [MediaCaptureVideoProfileMediaDescription](../windows.media.capture/mediacapturevideoprofilemediadescription.md) specifies a set of capabilities supported by a given sensor. This includes supported frame rates, resolutions, and whether the sensor can be used simulatneously with other capture devices. Use this property to identify a [MediaFrameSource](mediaframesource.md) that supports one or more desired capabilities. Use the [ProfileId](mediaframesourceinfo_profileid.md) property to get the unique identifier for the [MediaCaptureVideoProfile](../windows.media.capture/mediacapturevideoprofile.md) associated with a particular [MediaFrameSourceInfo](mediaframesourceinfo.md).

## -see-also

## -examples

