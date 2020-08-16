---
-api-id: M:Windows.Web.Http.HttpClient.PutAsync(Windows.Foundation.Uri,Windows.Web.Http.IHttpContent)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperationWithProgress<Windows.Web.Http.HttpResponseMessage, Windows.Web.Http.HttpProgress> PutAsync(Windows.Foundation.Uri uri, Windows.Web.Http.IHttpContent content)
-->

# Windows.Web.Http.HttpClient.PutAsync

## -description
Send a PUT request to the specified Uri as an asynchronous operation. For programming guidance for the [HttpClient class](/uwp/api/windows.web.http.httpclient), and code examples, see the [HttpClient](/windows/uwp/networking/httpclient) conceptual topic.

## -parameters
### -param uri
The Uri the request is sent to.

### -param content
The HTTP request content to send to the server.

## -returns
The object representing the asynchronous operation.

## -remarks
This operation will not block. The returned [IAsyncOperationWithProgress](../windows.foundation/iasyncoperationwithprogress_2.md) (of [HttpResponseMessage](/uwp/api/windows.web.http.httpresponsemessage) and [HttpProgress](/uwp/api/windows.web.http.httpprogress)) completes after the whole response (including content) is read.

The PutAsync and [PostAsync](httpclient_postasync_1466488101.md) methods only allow setting a limited number of HTTP content headers. In contrast, the [SendRequestAsync](/uwp/api/windows.web.http.httpclient.sendrequestasync) method allows setting headers on the request message as well as on the HTTP content to be sent.

Below are the exceptions that this function throws.

### E_INVALIDARG

The *uri* parameter was a **null** reference (**Nothing** in Visual Basic).

## -examples

## -see-also
[PostAsync](httpclient_postasync_1466488101.md), [SendRequestAsync](/uwp/api/windows.web.http.httpclient.sendrequestasync), [HttpClient](/windows/uwp/networking/httpclient)