---
-api-id: M:Windows.Media.Streaming.Adaptive.AdaptiveMediaSource.CreateFromUriAsync(Windows.Foundation.Uri)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperation<Windows.Media.Streaming.Adaptive.AdaptiveMediaSourceCreationResult> CreateFromUriAsync(Windows.Foundation.Uri uri)
-->

# Windows.Media.Streaming.Adaptive.AdaptiveMediaSource.CreateFromUriAsync

## -description
Asynchronously creates a [AdaptiveMediaSource](adaptivemediasource.md) object from the Uniform Resource Identifier (URI) of the source.

## -parameters
### -param uri
T he Uniform Resource Identifier (URI) of the source.

## -returns
Returns an [AdaptiveMediaSourceCreationResult](adaptivemediasourcecreationresult.md) upon successful completion.

## -remarks

> [!NOTE]
> When called from a desktop app that doesn't have package identity (see [Features that require package identity](/windows/apps/desktop/modernize/modernize-packaged-apps)), this API doesn't support the `ms-appx` and `ms-resource` URI formats.

## -examples

## -see-also
[CreateFromUriAsync(Uri, HttpClient)](adaptivemediasource_createfromuriasync_832683104.md)