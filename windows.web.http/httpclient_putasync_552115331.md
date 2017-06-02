---
-api-id: M:Windows.Web.Http.HttpClient.PutAsync(Windows.Foundation.Uri,Windows.Web.Http.IHttpContent)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperationWithProgress<Windows.Web.Http.HttpResponseMessage, Windows.Web.Http.HttpProgress> PutAsync(Windows.Foundation.Uri uri, Windows.Web.Http.IHttpContent content)
-->

# Windows.Web.Http.HttpClient.PutAsync

## -description
Send a PUT request to the specified Uri as an asynchronous operation.

## -parameters
### -param uri
The Uri the request is sent to.

### -param content
The HTTP request content to send to the server.

## -returns
The object representing the asynchronous operation.

## -remarks
This operation will not block. The returned [IAsyncOperationWithProgress(HttpResponseMessage, HttpProgress)](../windows.foundation/iasyncoperationwithprogress_2.md) object will complete after the whole response (including content) is read.

The [PutAsync](httpclient_putasync.md) and [PostAsync](httpclient_postasync.md) methods only allow setting a limited number of HTTP content headers. In contrast, the [SendRequestAsync](httpclient_sendrequestasync.md) method allows setting headers on the request message as well as on the HTTP content to be sent.

Below are the exceptions that this function throws.

### E_INVALIDARG

The *uri* parameter was a **null** reference (**Nothing** in Visual Basic).

## -examples

## -see-also
[PostAsync](httpclient_postasync.md), [SendRequestAsync](httpclient_sendrequestasync.md)