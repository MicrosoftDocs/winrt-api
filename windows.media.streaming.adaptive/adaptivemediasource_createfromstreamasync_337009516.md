---
-api-id: M:Windows.Media.Streaming.Adaptive.AdaptiveMediaSource.CreateFromStreamAsync(Windows.Storage.Streams.IInputStream,Windows.Foundation.Uri,System.String,Windows.Web.Http.HttpClient)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperation<Windows.Media.Streaming.Adaptive.AdaptiveMediaSourceCreationResult> CreateFromStreamAsync(Windows.Storage.Streams.IInputStream stream, Windows.Foundation.Uri uri, System.String contentType, Windows.Web.Http.HttpClient httpClient)
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

### -param httpClient
The [HttpClient](../windows.web.http/httpclient.md) instance that the [AdaptiveMediaSource](adaptivemediasource.md) should use for downloading resources. This allows you to specify custom HTTP headers for the requests.

## -returns
Returns an [AdaptiveMediaSourceCreationResult](adaptivemediasourcecreationresult.md) upon successful completion.

## -remarks

## -examples

## -see-also
[CreateFromStreamAsync(IInputStream, Uri, String)](adaptivemediasource_createfromstreamasync_930585492.md)