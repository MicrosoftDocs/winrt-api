---
-api-id: T:Windows.Media.Core.LowLightFusion
-api-type: winrt class
---

<!-- Class syntax.
public class LowLightFusion 
-->

# Windows.Media.Core.LowLightFusion

## -description
This class allows you to submit a set of image frames, captured in low-light settings and in close temporal proximity, and receieve a single image that has been processed to improve image lighting and fidelity.

## -remarks
This class implements the same computational photography algorithms as the [AdvancedPhotoCapture](/uwp/api/windows.media.capture.advancedphotocapture) class when used in low-light mode. The difference between this feature and **AdvancedPhotoCapture** is that because this feature is decoupled from the capture pipeline, you can use it on images that were captured at any time and in any manner, as long as the image format is supported. Supported formats can be determined by checking the [SupportedBitmapPixelFormats](/uwp/api/windows.media.core.lowlightfusion.SupportedBitmapPixelFormats) property.


## -see-also
[AdvancedPhotoCapture](/uwp/api/windows.media.capture.advancedphotocapture),
[High dynamic range (HDR) and low-light photo capture](/windows/uwp/audio-video-camera/high-dynamic-range-hdr-photo-capture#low-light-photo-capture)

## -examples

