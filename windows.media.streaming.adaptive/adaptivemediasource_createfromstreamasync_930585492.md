---
-api-id: M:Windows.Media.Streaming.Adaptive.AdaptiveMediaSource.CreateFromStreamAsync(Windows.Storage.Streams.IInputStream,Windows.Foundation.Uri,System.String)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperation<Windows.Media.Streaming.Adaptive.AdaptiveMediaSourceCreationResult> CreateFromStreamAsync(Windows.Storage.Streams.IInputStream stream, Windows.Foundation.Uri uri, System.String contentType)
-->

# Windows.Media.Streaming.Adaptive.AdaptiveMediaSource.CreateFromStreamAsync

## -description
Asynchronously creates a [AdaptiveMediaSource](adaptivemediasource.md) object from the provided input stream.

## -parameters
### -param stream
The input stream from which the [AdaptiveMediaSource](adaptivemediasource.md) is created.

### -param uri
The Uniform Resource Identifier (URI) of the source. This is used by the [AdaptiveMediaSource](adaptivemediasource.md) to resolve relative URIs.

### -param contentType
A string that identifies the MIME content type of the source. This can be an Http Live Streaming (HLS) or a Dynamic Adaptive Streaming over HTTP (DASH) content type.

## -returns
Returns an [AdaptiveMediaSourceCreationResult](adaptivemediasourcecreationresult.md) upon successful completion.

## -remarks

## -examples

## -see-also
[CreateFromStreamAsync(IInputStream, Uri, String, HttpClient)](adaptivemediasource_createfromstreamasync_337009516.md)