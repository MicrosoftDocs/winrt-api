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
Send a GET request to the specified [Uri](../windows.foundation/uri.md) and return the response body as a stream in an asynchronous operation. For programming guidance for the [HttpClient class](/uwp/api/windows.web.http.httpclient), and code examples, see the [HttpClient](/windows/uwp/networking/httpclient) conceptual topic.

## -parameters
### -param uri
The Uri the request is sent to.

## -returns
The object representing the asynchronous operation.

## -remarks
This operation will not block. The returned [IAsyncOperationWithProgress](../windows.foundation/iasyncoperationwithprogress_2.md) (of [HttpGetInputStreamResult](/uwp/api/windows.web.http.httpgetinputstreamresult) and [HttpProgress](/uwp/api/windows.web.http.httpprogress)) completes after the whole response body is read. This method does not buffer the stream, so this method can support long streams of arbitrary length.

## -see-also
[HttpGetInputStreamResult](httpgetinputstreamresult.md), [HttpProgress](httpprogress.md), [IInputStream](../windows.storage.streams/iinputstream.md), [HttpClient](/windows/uwp/networking/httpclient)

## -examples

