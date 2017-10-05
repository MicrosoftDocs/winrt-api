---
-api-id: M:Windows.Media.Capture.MediaCapture.PrepareLowLagRecordToCustomSinkAsync(Windows.Media.MediaProperties.MediaEncodingProfile,System.String,Windows.Foundation.Collections.IPropertySet)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperation<Windows.Media.Capture.LowLagMediaRecording> PrepareLowLagRecordToCustomSinkAsync(Windows.Media.MediaProperties.MediaEncodingProfile encodingProfile, System.String customSinkActivationId, Windows.Foundation.Collections.IPropertySet customSinkSettings)
-->

# Windows.Media.Capture.MediaCapture.PrepareLowLagRecordToCustomSinkAsync

## -description
Initializes the low lag recording using the specified custom sink to store the recording. This method provides the [LowLagMediaRecording](lowlagmediarecording.md) object used to managed the recording.

## -parameters
### -param encodingProfile
The encoding profile to use for the recording.

### -param customSinkActivationId
The activatable class ID of the media extension for the custom media sink.

### -param customSinkSettings
Contains properties of the media extension.

## -returns
When this method completes, a [LowLagMediaRecording](lowlagmediarecording.md) object is returned which can be used to start the photo capture.

## -remarks

## -examples

## -see-also
[PrepareLowLagRecordToCustomSinkAsync(MediaEncodingProfile, IMediaExtension)](mediacapture_preparelowlagrecordtocustomsinkasync_1787918353.md)
## -capabilities
backgroundMediaRecording
