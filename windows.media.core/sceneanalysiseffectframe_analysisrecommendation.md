---
-api-id: P:Windows.Media.Core.SceneAnalysisEffectFrame.AnalysisRecommendation
-api-type: winrt property
---

<!-- Property syntax.
public SceneAnalysisRecommendation AnalysisRecommendation { get; }
-->

# Windows.Media.Core.SceneAnalysisEffectFrame.AnalysisRecommendation

## -description
Gets a value that specifies the recommended image processing to improve image quality and fidelity of captured images based on the current capture conditions.

## -property-value
A value from that specifies the recommended image processing.

## -remarks
If the effect recommends using HDR, you can do this in the following ways:

* Use the [AdvancedPhotoCapture](/uwp/api/Windows.Media.Capture.AdvancedPhotoCapture) class to capture photos using the Windows built-in HDR processing algorithm. For more information, see [High Dynamic Range (HDR) and low-light photo capture](/windows/uwp/audio-video-camera/high-dynamic-range-hdr-photo-capture).
* Use the [HdrVideoControl](/uwp/api/Windows.Media.Devices.HdrVideoControl) to capture video using the Windows built-in HDR processing algorithm. For more information, see [Capture device controls for video capture](/windows/uwp/audio-video-camera/capture-device-controls-for-video-capture).
* Use [VariablePhotoSequenceCapture](/uwp/api/Windows.Media.Capture.Core.VariablePhotoSequenceCapture) to capture a sequence of frames that you can then composite using a custom HDR implementation. For more information, see [Variable photo sequence](/windows/uwp/audio-video-camera/variable-photo-sequence).

If the effect recomends low-light processing, you can implement this in the following ways:

* Use the [AdvancedPhotoCapture](/uwp/api/Windows.Media.Capture.AdvancedPhotoCapture) class to capture photos using the Windows built-in low-light processing algorithm. For more information, see [High Dynamic Range (HDR) and low-light photo capture](/windows/uwp/audio-video-camera/high-dynamic-range-hdr-photo-capture).

* Use the [LowLightFusion](/uwp/api/windows.media.core.lowlightfusion) class to use the Windows built-in low-light processing algorithm on images that you capture without using **AdvancedPhotoCapture**.

## -see-also

## -examples

