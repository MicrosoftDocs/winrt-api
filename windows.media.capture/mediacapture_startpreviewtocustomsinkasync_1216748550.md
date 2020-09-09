---
-api-id: M:Windows.Media.Capture.MediaCapture.StartPreviewToCustomSinkAsync(Windows.Media.MediaProperties.MediaEncodingProfile,Windows.Media.IMediaExtension)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncAction StartPreviewToCustomSinkAsync(Windows.Media.MediaProperties.MediaEncodingProfile encodingProfile, Windows.Media.IMediaExtension customMediaSink)
-->

# Windows.Media.Capture.MediaCapture.StartPreviewToCustomSinkAsync

## -description
Starts sending a preview stream to a custom media sink using the specified encoding profile.

## -parameters
### -param encodingProfile
The encoding profile to use for the recording.

### -param customMediaSink
The media extension for the custom media sink.

## -returns
An object that is used to control the asynchronous operation.

## -remarks
When you call **StartPreviewToCustomSinkAsync**, the system will call the custom sink’s [IMFMediaTypeHandler.IsMediaTypeSupported](/windows/desktop/api/mfidl/nf-mfidl-imfmediatypehandler-ismediatypesupported) method, passing in the native media type of the capture device. This check is performed in an effort to avoid unnecessary video conversion. If the custom sink returns S_OK from **IsMediaTypeSupported** when this check is made, then the preview stream will use the native media type instead of the type specified by the *encodingProfile* parameter.

## -examples

## -see-also
[StartPreviewToCustomSinkAsync(MediaEncodingProfile, String, IPropertySet)](mediacapture_startpreviewtocustomsinkasync_319661254.md)
## -capabilities
backgroundMediaRecording
