---
-api-id: E:Windows.Media.Capture.LowLagPhotoSequenceCapture.PhotoCaptured
-api-type: winrt event
---

<!-- Event syntax
public event Windows.Foundation.TypedEventHandler PhotoCaptured<Windows.Media.Capture.LowLagPhotoSequenceCapture,  Windows.Media.Capture.PhotoCapturedEventArgs>
-->

# Windows.Media.Capture.LowLagPhotoSequenceCapture.PhotoCaptured

## -description
Occurs when a photo has been captured.

## -remarks
Add an handler to the [PhotoCaptured](lowlagphotosequencecapture_photocaptured.md) event in order to get the captured photos in the sequence. [PhotoCapturedEventArgs](photocapturedeventargs.md) provides the data for the captured frames. [PhotoCapturedEventArgs.Frame](photocapturedeventargs_frame.md) contains the captured photo and [PhotoCapturedEventArgs.Thumbnail](photocapturedeventargs_thumbnail.md) contains the thumbnail.

## -examples

## -see-also
