---
-api-id: M:Windows.Web.Http.HttpClient.TryPutAsync(Windows.Foundation.Uri,Windows.Web.Http.IHttpContent)
-api-type: winrt method
ms.custom: 19H1
---

<!-- Method syntax.
public IAsyncOperationWithProgress<HttpProgress> HttpClient.TryPutAsync(Uri uri, IHttpContent content)
-->

# Windows.Web.Http.HttpClient.TryPutAsync

## -description
Sends a PUT request to the specified [Uri](../windows.foundation/uri.md) as an asynchronous operation. For programming guidance for the [HttpClient class](/uwp/api/windows.web.http.httpclient), and code examples, see the [HttpClient](/windows/uwp/networking/httpclient) conceptual topic.

## -parameters
### -param uri
The Uri the request is sent to.

### -param content
The HTTP request content to send to the server.

## -returns
The object representing the asynchronous operation.

## -remarks
This operation will not throw an exception on network errors. Instead you should examine the [HttpRequestResult](httprequestresult.md) to learn about the original HTTP request, the resulting HTTP response (if any) and error (if any). This operation will throw when the operation is canceled.

This operation will not block. The returned [IAsyncOperationWithProgress(HttpRequestResult,HttpProgress)](../windows.foundation/iasyncoperationwithprogress_2.md) object will complete after the whole response (including content) is read.

## -see-also
[HttpRequestResult](httprequestresult.md), [IHttpContent](ihttpcontent.md), [HttpProgress](httpprogress.md), [HttpResponseMessage](httpresponsemessage.md), [HttpClient](/windows/uwp/networking/httpclient)

## -examples

