---
-api-id: M:Windows.Media.Capture.MediaCapture.PrepareAdvancedPhotoCaptureAsync(Windows.Media.MediaProperties.ImageEncodingProperties)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperation<Windows.Media.Capture.AdvancedPhotoCapture> PrepareAdvancedPhotoCaptureAsync(Windows.Media.MediaProperties.ImageEncodingProperties encodingProperties)
-->

# Windows.Media.Capture.MediaCapture.PrepareAdvancedPhotoCaptureAsync

## -description
Initializes the advanced photo capture and provides the [AdvancedPhotoCapture](advancedphotocapture.md) object used to manage the recording.

## -parameters
### -param encodingProperties
The encoding properties used for the resulting image.

## -returns
An asynchronous operation that returns an [AdvancedPhotoCapture](advancedphotocapture.md) object on successful completion.

## -remarks

> [!NOTE] 
> Starting with Windows 10, version 1709, recording video and using AdvancedPhotoCapture concurrently is supported.  This is not supported in previous versions. This change means that you can have a prepared **[LowLagMediaRecording](/uwp/api/windows.media.capture.lowlagmediarecording)** and **[AdvancedPhotoCapture](/uwp/api/windows.media.capture.advancedphotocapture)** at the same time. You can start or stop video recording between calls to **[MediaCapture.PrepareAdvancedPhotoCaptureAsync](/uwp/api/windows.media.capture.mediacapture#Windows_Media_Capture_MediaCapture_PrepareAdvancedPhotoCaptureAsync_Windows_Media_MediaProperties_ImageEncodingProperties_)** and **[AdvancedPhotoCapture.FinishAsync](/uwp/api/windows.media.capture.advancedphotocapture.FinishAsync)**. You can also call **[AdvancedPhotoCapture.CaptureAsync](/uwp/api/windows.media.capture.advancedphotocapture.CaptureAsync)** while video is recording. However, some **AdvancedPhotoCapture** scenarios, like capturing an HDR photo while recording video would cause some video frames to be altered by the HDR capture, resulting in a negative user experience. For this reason, the list of modes returned by the **[AdvancedPhotoControl.SupportedModes](/uwp/api/windows.media.devices.advancedphotocontrol.SupportedModes)** will be different while video is recording. You should check this value immediately after starting or stopping video recording to ensure that the desired mode is supported in the current video recording state.

## -examples

## -see-also

## -capabilities
backgroundMediaRecording
