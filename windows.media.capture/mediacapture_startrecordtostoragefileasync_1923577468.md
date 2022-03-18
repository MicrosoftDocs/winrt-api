---
-api-id: M:Windows.Media.Capture.MediaCapture.StartRecordToStorageFileAsync(Windows.Media.MediaProperties.MediaEncodingProfile,Windows.Storage.IStorageFile)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncAction StartRecordToStorageFileAsync(Windows.Media.MediaProperties.MediaEncodingProfile encodingProfile, Windows.Storage.IStorageFile file)
-->

# Windows.Media.Capture.MediaCapture.StartRecordToStorageFileAsync

## -description
Starts recording asynchronously to a storage file.

## -parameters
### -param encodingProfile
The encoding profile for the recording.

### -param file
The storage file where the image is saved.

## -returns
Returns a [IAsyncAction](../windows.foundation/iasyncaction.md) object that is used to control the asynchronous operation.

## -remarks
For how-to guidance on recording to a file, see [Basic photo, video, and audio capture with MediaCapture](/windows/uwp/audio-video-camera/basic-photo-video-and-audio-capture-with-mediacapture).

## -examples

## -see-also
[Basic photo, video, and audio capture with MediaCapture](/windows/uwp/audio-video-camera/basic-photo-video-and-audio-capture-with-mediacapture)

## -capabilities
backgroundMediaRecording
microphone, webcam
