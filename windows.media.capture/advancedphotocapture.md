---
-api-id: T:Windows.Media.Capture.AdvancedPhotoCapture
-api-type: winrt class
---

<!-- Class syntax.
public class AdvancedPhotoCapture : Windows.Media.Capture.IAdvancedPhotoCapture
-->

# Windows.Media.Capture.AdvancedPhotoCapture

## -description
Provides methods for capturing photos using system-provided computational photography techniques.

## -remarks
Get an instance of this class by calling [MediaCapture.PrepareAdvancedPhotoCaptureAsync](mediacapture_prepareadvancedphotocaptureasync_1274714827.md).

For how-to guidance for using **AdvancedPhotoCapture**, see [High dynamic range (HDR) and low-light photo capture](/windows/uwp/audio-video-camera/high-dynamic-range-hdr-photo-capture).

> [!NOTE] 
> Starting with Windows 10, version 1709, recording video and using AdvancedPhotoCapture concurrently is supported.  This is not supported in previous versions. This change means that you can have a prepared **[LowLagMediaRecording](/uwp/api/windows.media.capture.lowlagmediarecording)** and **[AdvancedPhotoCapture](/uwp/api/windows.media.capture.advancedphotocapture)** at the same time. You can start or stop video recording between calls to **[MediaCapture.PrepareAdvancedPhotoCaptureAsync](/uwp/api/windows.media.capture.mediacapture#Windows_Media_Capture_MediaCapture_PrepareAdvancedPhotoCaptureAsync_Windows_Media_MediaProperties_ImageEncodingProperties_)** and **[AdvancedPhotoCapture.FinishAsync](/uwp/api/windows.media.capture.advancedphotocapture.FinishAsync)**. You can also call **[AdvancedPhotoCapture.CaptureAsync](/uwp/api/windows.media.capture.advancedphotocapture.CaptureAsync)** while video is recording. However, some **AdvancedPhotoCapture** scenarios, like capturing an HDR photo while recording video would cause some video frames to be altered by the HDR capture, resulting in a negative user experience. For this reason, the list of modes returned by the **[AdvancedPhotoControl.SupportedModes](/uwp/api/windows.media.devices.advancedphotocontrol.SupportedModes)** will be different while video is recording. You should check this value immediately after starting or stopping video recording to ensure that the desired mode is supported in the current video recording state.

## -examples

## -see-also
[High dynamic range (HDR) and low-light photo capture](/windows/uwp/audio-video-camera/high-dynamic-range-hdr-photo-capture), [MediaCapture.PrepareAdvancedPhotoCaptureAsync](mediacapture_prepareadvancedphotocaptureasync_1274714827.md)