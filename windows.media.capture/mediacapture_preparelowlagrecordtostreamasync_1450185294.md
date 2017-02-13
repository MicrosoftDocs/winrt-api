---
-api-id: M:Windows.Media.Capture.MediaCapture.PrepareLowLagRecordToStreamAsync(Windows.Media.MediaProperties.MediaEncodingProfile,Windows.Storage.Streams.IRandomAccessStream)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperation<Windows.Media.Capture.LowLagMediaRecording> PrepareLowLagRecordToStreamAsync(Windows.Media.MediaProperties.MediaEncodingProfile encodingProfile, Windows.Storage.Streams.IRandomAccessStream stream)
-->

# Windows.Media.Capture.MediaCapture.PrepareLowLagRecordToStreamAsync

## -description
Initializes the low lag recording using the specified random-access stream to store the recording. This method provides the [LowLagMediaRecording](lowlagmediarecording.md) object used to managed the recording.

## -parameters
### -param encodingProfile
The encoding profile for the recording.

### -param stream
The stream where the image data is written.

## -returns
When this method completes, a [LowLagMediaRecording](lowlagmediarecording.md) object is returned which can be used to start the photo capture.

## -remarks

## -examples

## -see-also
