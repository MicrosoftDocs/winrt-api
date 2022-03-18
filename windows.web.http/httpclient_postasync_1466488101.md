---
-api-id: M:Windows.Web.Http.HttpClient.PostAsync(Windows.Foundation.Uri,Windows.Web.Http.IHttpContent)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperationWithProgress<Windows.Web.Http.HttpResponseMessage, Windows.Web.Http.HttpProgress> PostAsync(Windows.Foundation.Uri uri, Windows.Web.Http.IHttpContent content)
-->

# Windows.Web.Http.HttpClient.PostAsync

## -description

Send a POST request to the specified URI as an asynchronous operation. For programming guidance for the [HttpClient class](/uwp/api/windows.web.http.httpclient), and code examples, see the [HttpClient](/windows/uwp/networking/httpclient) conceptual topic.

## -parameters

### -param uri

The URI the request is sent to.

### -param content

The HTTP request content to send to the server.

## -returns

The object representing the asynchronous operation.

## -remarks

This operation will not block. The returned [IAsyncOperationWithProgress](../windows.foundation/iasyncoperationwithprogress_2.md) (of[HttpResponseMessage](/uwp/api/windows.web.http.httpresponsemessage) and [HttpProgress](/uwp/api/windows.web.http.httpprogress)) completes after the whole response (including content) is read.

The PostAsync and [PutAsync](httpclient_putasync_552115331.md) methods only allow setting a limited number of HTTP content headers. In contrast, the [SendRequestAsync](httpclient_sendrequestasync_234300504.md) method allows setting headers on the request message as well as on the HTTP content to be sent.

Below are the exceptions that this function throws.

### E_INVALIDARG

The *uri* parameter was a **null** reference (**Nothing** in Visual Basic).

### Exception Handling

You must write code to handle exceptions when you call this method. Exceptions can result from parameter validation errors, name resolutions failures, and network errors. Exceptions from network errors (loss of connectivity, connection failures, and HTTP server failures, for example) can happen at any time. These errors result in exceptions being thrown. If not handled by your app, an exception can cause your entire app to be terminated by the runtime. For more information on how to handle exceptions, see [Handling exceptions in network apps](/previous-versions/windows/apps/dn263211(v=win.10)).

## -examples

See [HttpClient](/windows/uwp/networking/httpclient) for examples of calling **HttpClient.PostAsync**.

## -see-also

[IHttpContent](ihttpcontent.md), [IAsyncOperationWithProgress](../windows.foundation/iasyncoperationwithprogress_2.md), [HttpResponseMessage](/uwp/api/windows.web.http.httpresponsemessage), [HttpProgress](/uwp/api/windows.web.http.httpprogress), [PutAsync](httpclient_putasync_552115331.md), [SendRequestAsync](httpclient_sendrequestasync_234300504.md), [Uri](../windows.foundation/uri.md), [HttpClient](/windows/uwp/networking/httpclient)