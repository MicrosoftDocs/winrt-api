---
-api-id: M:Windows.Media.Capture.MediaCapture.PrepareLowLagPhotoCaptureAsync(Windows.Media.MediaProperties.ImageEncodingProperties)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperation<Windows.Media.Capture.LowLagPhotoCapture> PrepareLowLagPhotoCaptureAsync(Windows.Media.MediaProperties.ImageEncodingProperties type)
-->

# Windows.Media.Capture.MediaCapture.PrepareLowLagPhotoCaptureAsync

## -description
Initializes the low shutter lag photo capture and provides the [LowLagPhotoCapture](lowlagphotocapture.md) object used to manage the recording.

## -parameters
### -param type
The encoding profile used for the image.

## -returns
When this method completes, a [LowLagPhotoCapture](lowlagphotocapture.md) object is returned which can be used to start the photo capture.

## -remarks
Use PrepareLowLagPhotoCaptureAsync to initialize the capture. This is an asynchronous calls which returns a [LowLagPhotoCapture](lowlagphotocapture.md) object when it is finished, which is used to start the actual photo capture by calling [LowLagPhotoCapture.CaptureAsync](lowlagphotocapture_captureasync_2078018041.md).

PrepareLowLagPhotoCaptureAsync must be called before [LowLagPhotoCapture.CaptureAsync](lowlagphotocapture_captureasync_2078018041.md).

For how-to guidance on using [LowLagPhotoCapture](lowlagphotocapture.md) to capture a photo, see [Basic photo, video, and audio capture with MediaCapture](/windows/uwp/audio-video-camera/basic-photo-video-and-audio-capture-with-mediacapture).

## -examples

## -see-also
[Basic photo, video, and audio capture with MediaCapture](/windows/uwp/audio-video-camera/basic-photo-video-and-audio-capture-with-mediacapture), [LowLagPhotoCapture](lowlagphotocapture.md)
## -capabilities
backgroundMediaRecording
