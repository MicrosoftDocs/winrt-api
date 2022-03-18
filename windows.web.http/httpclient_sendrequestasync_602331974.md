---
-api-id: M:Windows.Web.Http.HttpClient.SendRequestAsync(Windows.Web.Http.HttpRequestMessage)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperationWithProgress<Windows.Web.Http.HttpResponseMessage, Windows.Web.Http.HttpProgress> SendRequestAsync(Windows.Web.Http.HttpRequestMessage request)
-->

# Windows.Web.Http.HttpClient.SendRequestAsync

## -description
Send an HTTP request as an asynchronous operation. For programming guidance for the [HttpClient class](/uwp/api/windows.web.http.httpclient), and code examples, see the [HttpClient](/windows/uwp/networking/httpclient) conceptual topic.

## -parameters
### -param request
The HTTP request message to send.

## -returns
The object representing the asynchronous operation.

## -remarks
This operation will not block. The returned [IAsyncOperationWithProgress](../windows.foundation/iasyncoperationwithprogress_2.md) (of [HttpResponseMessage](/uwp/api/windows.web.http.httpresponsemessage) and [HttpProgress](/uwp/api/windows.web.http.httpprogress)) completes after the whole response (including content) is read.

The [HttpRequestMessage](httprequestmessage.md) passed in the *request* parameter allows the SendRequestAsync method to set headers on the request message as well as on the HTTP content to be sent. In contrast, the [PostAsync](httpclient_postasync_1466488101.md) and [PutAsync](httpclient_putasync_552115331.md) methods only allow setting a more limited set of HTTP content headers.

Below are the exceptions that this function throws.

### E_ILLEGAL_METHOD_CALL

The request message was already sent by the [HttpClient](httpclient.md) instance.

### Exception handling

You must write code to handle exceptions when you call this method. Exceptions can result from parameter validation errors, name resolutions failures, and network errors. Exceptions from network errors (loss of connectivity, connection failures, and HTTP server failures, for example) can happen at any time. These errors result in exceptions being thrown. If not handled by your app, an exception can cause your entire app to be terminated by the runtime. For more information on how to handle exceptions, see [Handling exceptions in network apps](/previous-versions/windows/apps/dn263211(v=win.10)) and [How to: Map HRESULTs and Exceptions](/dotnet/framework/interop/how-to-map-hresults-and-exceptions).

## -examples

## -see-also
[HttpRequestMessage](httprequestmessage.md), [PostAsync](httpclient_postasync_1466488101.md), [PutAsync](httpclient_putasync_552115331.md), [SendRequestAsync(HttpRequestMessage, HttpCompletionOption)](httpclient_sendrequestasync_234300504.md), [HttpClient](/windows/uwp/networking/httpclient)
