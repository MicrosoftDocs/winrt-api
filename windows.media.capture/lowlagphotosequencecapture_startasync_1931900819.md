---
-api-id: M:Windows.Media.Capture.LowLagPhotoSequenceCapture.StartAsync
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncAction StartAsync()
-->

# Windows.Media.Capture.LowLagPhotoSequenceCapture.StartAsync

## -description
Asynchronously starts capturing photos.

## -returns
Object that is used to control the asynchronous operation.

## -remarks
[MediaCapture.PrepareLowLagPhotoSequenceCaptureAsync](mediacapture_preparelowlagphotosequencecaptureasync.md) must be called before [StartAsync](lowlagphotosequencecapture_startasync.md).

Add a handler to the [PhotoCaptured](lowlagphotosequencecapture_photocaptured.md) event in order to get the captured photos in the sequence. [PhotoCapturedEventArgs](photocapturedeventargs.md) provides the data for the captured frames. [PhotoCapturedEventArgs.Frame](photocapturedeventargs_frame.md) contains the captured photo and [PhotoCapturedEventArgs.Thumbnail](photocapturedeventargs_thumbnail.md) contains the thumbnail.

## -examples

## -see-also
[PrepareLowLagPhotoSequenceCaptureAsync](mediacapture_preparelowlagphotosequencecaptureasync.md)