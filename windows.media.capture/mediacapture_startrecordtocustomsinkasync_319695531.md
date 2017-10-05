---
-api-id: M:Windows.Media.Capture.MediaCapture.StartRecordToCustomSinkAsync(Windows.Media.MediaProperties.MediaEncodingProfile,System.String,Windows.Foundation.Collections.IPropertySet)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncAction StartRecordToCustomSinkAsync(Windows.Media.MediaProperties.MediaEncodingProfile encodingProfile, System.String customSinkActivationId, Windows.Foundation.Collections.IPropertySet customSinkSettings)
-->

# Windows.Media.Capture.MediaCapture.StartRecordToCustomSinkAsync

## -description
Start recording to a custom media sink using the specified encoding profile and sink settings.

## -parameters
### -param encodingProfile
The encoding profile to use for the recording.

### -param customSinkActivationId
The activatable class ID of the media extension for the custom media sink.

### -param customSinkSettings
Contains properties of the media extension.

## -returns
An object that is used to control the asynchronous operation.

## -remarks
A [RecordLimitationExceeded](mediacapture_recordlimitationexceeded.md) event is raised if the record limit is exceeded. In the current release, the record limit is three hours.

## -examples

## -see-also
[StartRecordToCustomSinkAsync(MediaEncodingProfile, IMediaExtension)](mediacapture_startrecordtocustomsinkasync_1216713323.md), [RecordLimitationExceeded](mediacapture_recordlimitationexceeded.md)
## -capabilities
backgroundMediaRecording
