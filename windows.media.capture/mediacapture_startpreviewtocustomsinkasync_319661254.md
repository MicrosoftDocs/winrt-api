---
-api-id: M:Windows.Media.Capture.MediaCapture.StartPreviewToCustomSinkAsync(Windows.Media.MediaProperties.MediaEncodingProfile,System.String,Windows.Foundation.Collections.IPropertySet)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncAction StartPreviewToCustomSinkAsync(Windows.Media.MediaProperties.MediaEncodingProfile encodingProfile, System.String customSinkActivationId, Windows.Foundation.Collections.IPropertySet customSinkSettings)
-->

# Windows.Media.Capture.MediaCapture.StartPreviewToCustomSinkAsync

## -description
Starts sending a preview stream to a custom media sink using the specified encoding profile and sink settings.

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
When you call **StartPreviewToCustomSinkAsync**, the system will call the custom sink’s [IMFMediaTypeHandler.IsMediaTypeSupported](/windows/desktop/api/mfidl/nf-mfidl-imfmediatypehandler-ismediatypesupported) method, passing in the native media type of the capture device. This check is performed in an effort to avoid unnecessary video conversion. If the custom sink returns S_OK from **IsMediaTypeSupported** when this check is made, then the preview stream will use the native media type instead of the type specified by the *encodingProfile* parameter.

## -examples

## -see-also
[StartPreviewToCustomSinkAsync(MediaEncodingProfile, IMediaExtension)](mediacapture_startpreviewtocustomsinkasync_1216748550.md)
## -capabilities
backgroundMediaRecording
