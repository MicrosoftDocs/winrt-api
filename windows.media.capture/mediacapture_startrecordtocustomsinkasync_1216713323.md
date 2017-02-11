---
-api-id: M:Windows.Media.Capture.MediaCapture.StartRecordToCustomSinkAsync(Windows.Media.MediaProperties.MediaEncodingProfile,Windows.Media.IMediaExtension)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncAction StartRecordToCustomSinkAsync(Windows.Media.MediaProperties.MediaEncodingProfile encodingProfile, Windows.Media.IMediaExtension customMediaSink)
-->

# Windows.Media.Capture.MediaCapture.StartRecordToCustomSinkAsync

## -description
Start recording to a custom media sink using the specified encoding profile.

## -parameters
### -param encodingProfile
The encoding profile to use for the recording.

### -param customMediaSink
The media extension for the custom media sink.

## -returns
An object that is used to control the asynchronous operation.

## -remarks
A [RecordLimitationExceeded](mediacapture_recordlimitationexceeded.md) event is raised if the record limit is exceeded. In the current release, record limit is three hours.

## -examples

## -see-also
[StartRecordToCustomSinkAsync(MediaEncodingProfile, String, IPropertySet)](mediacapture_startrecordtocustomsinkasync_319695531.md), [RecordLimitationExceeded](mediacapture_recordlimitationexceeded.md)