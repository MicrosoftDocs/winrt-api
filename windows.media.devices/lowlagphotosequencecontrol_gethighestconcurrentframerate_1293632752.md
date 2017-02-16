---
-api-id: M:Windows.Media.Devices.LowLagPhotoSequenceControl.GetHighestConcurrentFrameRate(Windows.Media.MediaProperties.IMediaEncodingProperties)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Media.MediaProperties.MediaRatio GetHighestConcurrentFrameRate(Windows.Media.MediaProperties.IMediaEncodingProperties captureProperties)
-->

# Windows.Media.Devices.LowLagPhotoSequenceControl.GetHighestConcurrentFrameRate

## -description
Gets the highest frame rate supported when video and photos sequences are being captured concurrently.

## -parameters
### -param captureProperties
The media encoding properties.

## -returns
The highest concurrent frames per second.

## -remarks
The [ConcurrentRecordAndPhotoSequenceSupported](../windows.media.capture/mediacapturesettings_concurrentrecordandphotosequencesupported.md) property on the [MediaCapture](../windows.media.capture/mediacapture.md) class specifies if the capture device supports capturing videos and photo sequences at the same time.

## -examples

## -see-also
