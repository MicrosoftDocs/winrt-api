---
-api-id: T:Windows.Media.Core.SceneAnalysisRecommendation
-api-type: winrt enum
---

<!-- Enumeration syntax.
public enum SceneAnalysisRecommendation : int 
-->

# Windows.Media.Core.SceneAnalysisRecommendation

## -description
Specifies the recommended image processing to improve image quality and fidelity of captured images based on the current capture conditions, as determined by the [SceneAnalysisEffect](/uwp/api/windows.media.core.sceneanalysiseffect).

## -enum-fields
### -field Standard:0
No image processing is recommended.

### -field LowLight:2
Low-light processing is recommended.

### -field Hdr:1
High Dynamic Range (HDR) processing is recommended.

## -remarks
Get a value from this enumeration by implementing the **SceneAnalysisEffect**, registering a handler for the [SceneAnalyzed](/uwp/api/windows.media.core.sceneanalysiseffect.SceneAnalyzed) event, and then checking the [AnalysisRecommendation](/uwp/api/windows.media.core.sceneanalysiseffectframe.AnalysisRecommendation) property of the [SceneAnalysisEffectFrame](/uwp/api/windows.media.core.sceneanalysiseffectframe) passed in the event args. For more information on using the **SceneAnalysisEffect**, see [Scene anlysis for MediaCapture](/windows/uwp/audio-video-camera/scene-analysis-for-media-capture).

If the effect recommends using HDR, you can do this in the following ways:

* Use the [AdvancedPhotoCapture](/uwp/api/Windows.Media.Capture.AdvancedPhotoCapture) class to capture photos using the Windows built-in HDR processing algorithm. For more information, see [High Dynamic Range (HDR) and low-light photo capture](/windows/uwp/audio-video-camera/high-dynamic-range-hdr-photo-capture).
* Use the [HdrVideoControl](/uwp/api/Windows.Media.Devices.HdrVideoControl) to capture video using the Windows built-in HDR processing algorithm. For more information, see [Capture device controls for video capture](/windows/uwp/audio-video-camera/capture-device-controls-for-video-capture).
* Use [VariablePhotoSequenceCapture](/uwp/api/Windows.Media.Capture.Core.VariablePhotoSequenceCapture) to capture a sequence of frames that you can then composite using a custom HDR implementation. For more information, see [Variable photo sequence](/windows/uwp/audio-video-camera/variable-photo-sequence).

If the effect recomends low-light processing, you can implement this in the following ways:

* Use the [AdvancedPhotoCapture](/uwp/api/Windows.Media.Capture.AdvancedPhotoCapture) class to capture photos using the Windows built-in low-light processing algorithm. For more information, see [High Dynamic Range (HDR) and low-light photo capture](/windows/uwp/audio-video-camera/high-dynamic-range-hdr-photo-capture).

* Use the [LowLightFusion](/uwp/api/windows.media.core.lowlightfusion) class to use the Windows built-in low-light processing algorithm on images that you capture without using **AdvancedPhotoCapture**.

## -see-also

## -examples

