---
-api-id: M:Windows.Web.IUriToStreamResolver.UriToStreamAsync(Windows.Foundation.Uri)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperation<Windows.Storage.Streams.IInputStream> UriToStreamAsync(Windows.Foundation.Uri uri)
-->

# Windows.Web.IUriToStreamResolver.UriToStreamAsync

## -description
Translates a URI to a content stream for use by the [WebView.NavigateToLocalStreamUri](../windows.ui.xaml.controls/webview_navigatetolocalstreamuri.md) method.

## -parameters
### -param uri
The URI to translate.

## -returns
When this method returns, the content stream.

## -remarks
If you need to perform a seek operation on the content stream, be sure to return an [IRandomAccessStream](../windows.storage.streams/irandomaccessstream.md). For example, suppose the stream represents a page with embedded media, and you return the result of a [GetInputStreamAt](../windows.storage.streams/irandomaccessstream_getinputstreamat.md) call, which is an [IInputStream](../windows.storage.streams/iinputstream.md), but not an [IRandomAccessStream](../windows.storage.streams/irandomaccessstream.md). In this case, the media will play, but the user will not be able to change the playback position.

## -examples

## -see-also
[WebView.NavigateToLocalStreamUri](../windows.ui.xaml.controls/webview_navigatetolocalstreamuri.md)