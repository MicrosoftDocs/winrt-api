---
-api-id: M:Windows.Media.Capture.MediaCapture.PrepareLowLagPhotoSequenceCaptureAsync(Windows.Media.MediaProperties.ImageEncodingProperties)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperation<Windows.Media.Capture.LowLagPhotoSequenceCapture> PrepareLowLagPhotoSequenceCaptureAsync(Windows.Media.MediaProperties.ImageEncodingProperties type)
-->

# Windows.Media.Capture.MediaCapture.PrepareLowLagPhotoSequenceCaptureAsync

## -description
Initializes the low shutter lag photo sequence capture and provides the [LowLagPhotoSequenceCapture](lowlagphotosequencecapture.md) object used to manage the recording.

## -parameters
### -param type
The encoding profile used for the image.

## -returns
When this method completes, a [LowLagPhotoSequenceCapture](lowlagphotosequencecapture.md) object is returned which can be used to start the photo sequence capture.

## -remarks
Use [MediaCapture.PrepareLowLagPhotoSequenceCaptureAsync](mediacapture_preparelowlagphotosequencecaptureasync_2130225421.md) to initialize the photo sequence capture. This is an asynchronous call which returns a [LowLagPhotoSequenceCapture](lowlagphotosequencecapture.md) object when it is finished, which is used start the photo sequence capture by calling [LowLagPhotoSequenceCapture.StartAsync](lowlagphotosequencecapture_startasync_1931900819.md).

[PrepareLowLagPhotoSequenceCaptureAsync](mediacapture_preparelowlagphotosequencecaptureasync_2130225421.md) must be called before [LowLagPhotoSequenceCapture.StartAsync](lowlagphotosequencecapture_startasync_1931900819.md).

## -examples

## -see-also

## -capabilities
backgroundMediaRecording
