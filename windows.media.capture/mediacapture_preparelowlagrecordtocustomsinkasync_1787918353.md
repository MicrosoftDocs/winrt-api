---
-api-id: M:Windows.Media.Capture.MediaCapture.PrepareLowLagRecordToCustomSinkAsync(Windows.Media.MediaProperties.MediaEncodingProfile,Windows.Media.IMediaExtension)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperation<Windows.Media.Capture.LowLagMediaRecording> PrepareLowLagRecordToCustomSinkAsync(Windows.Media.MediaProperties.MediaEncodingProfile encodingProfile, Windows.Media.IMediaExtension customMediaSink)
-->

# Windows.Media.Capture.MediaCapture.PrepareLowLagRecordToCustomSinkAsync

## -description
Initializes the low lag recording using the specified custom sink to store the recording. This method provides the [LowLagMediaRecording](lowlagmediarecording.md) object used to managed the capture.

## -parameters
### -param encodingProfile
The encoding profile to use for the recording.

### -param customMediaSink
The media extension for the custom media sink.

## -returns
When this method completes, a [LowLagMediaRecording](lowlagmediarecording.md) object is returned which can be used to start the photo capture.

## -remarks

## -examples

## -see-also
[PrepareLowLagRecordToCustomSinkAsync(MediaEncodingProfile, String, IPropertySet)](mediacapture_preparelowlagrecordtocustomsinkasync_823836881.md)