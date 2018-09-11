---
-api-id: E:Windows.Media.Capture.AdvancedPhotoCapture.AllPhotosCaptured
-api-type: winrt event
---

<!-- Event syntax
public event Windows.Foundation.TypedEventHandler AllPhotosCaptured<Windows.Media.Capture.AdvancedPhotoCapture,  object>
-->

# Windows.Media.Capture.AdvancedPhotoCapture.AllPhotosCaptured

## -description
Occurs when all of the frames required for the advanced photo capture have been captured.

## -remarks
An advanced photo capture operation may require that multiple frames be captured and processed to produce the resulting image. This event notifies you when the source frames have been captured, which allows you to initiate another advanced photo capture as soon as the capture device is available, instead of waiting for the call to [CaptureAsync](/uwp/api/windows.media.capture.advancedphotocapture.captureasync) to complete, which is raised only after the image processing of the captured frames is finished.

## -examples

## -see-also
