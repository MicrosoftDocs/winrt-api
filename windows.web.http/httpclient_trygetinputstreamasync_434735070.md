---
-api-id: M:Windows.Web.Http.HttpClient.TryGetInputStreamAsync(Windows.Foundation.Uri)
-api-type: winrt method
ms.custom: 19H1
---

<!-- Method syntax.
public IAsyncOperationWithProgress<HttpProgress> HttpClient.TryGetInputStreamAsync(Uri uri)
-->

# Windows.Web.Http.HttpClient.TryGetInputStreamAsync

## -description
Send a GET request to the specified [Uri](../windows.foundation/uri.md) and return the response body as a stream in an asynchronous operation.

## -parameters
### -param uri
The Uri the request is sent to.

## -returns
The object representing the asynchronous operation.

## -remarks
This operation will not block. The returned [IAsyncOperationWithProgress(HttpGetInputStreamResult, HttpProgress)](../windows.foundation/iasyncoperationwithprogress_2.md) object will complete after the whole response body is read. This method does not buffer the stream, so this method can support long streams of arbitrary length.

## -see-also
[HttpGetInputStreamResult](httpgetinputstreamresult.md), [HttpProgress](httpprogress.md), [IInputStream](../windows.storage.streams/iinputstream.md)

## -examples

