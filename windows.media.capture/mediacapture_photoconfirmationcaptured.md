---
-api-id: E:Windows.Media.Capture.MediaCapture.PhotoConfirmationCaptured
-api-type: winrt event
---

<!-- Event syntax
public event Windows.Foundation.TypedEventHandler PhotoConfirmationCaptured<Windows.Media.Capture.MediaCapture,  Windows.Media.Capture.PhotoConfirmationCapturedEventArgs>
-->

# Windows.Media.Capture.MediaCapture.PhotoConfirmationCaptured

## -description
Occurs when a photo confirmation frame is captured.

## -remarks
The [CapturedFrame](capturedframe.md) object passed to this event contains raw pixel data and therefore must be manually copied into the pixel buffer of a bitmap. For information on how to do this, see the Remarks section of the [Frame](photoconfirmationcapturedeventargs_frame.md) property.

## -examples

## -see-also

## -capabilities
backgroundMediaRecording
