---
-api-id: M:Windows.Web.Http.HttpClient.DeleteAsync(Windows.Foundation.Uri)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperationWithProgress<Windows.Web.Http.HttpResponseMessage, Windows.Web.Http.HttpProgress> DeleteAsync(Windows.Foundation.Uri uri)
-->

# Windows.Web.Http.HttpClient.DeleteAsync

## -description
Send a DELETE request to the specified [Uri](../windows.foundation/uri.md) as an asynchronous operation. For programming guidance for the [HttpClient class](/uwp/api/windows.web.http.httpclient), and code examples, see the [HttpClient](/windows/uwp/networking/httpclient) conceptual topic.

## -parameters
### -param uri
The Uri the request is sent to.

## -returns
The object representing the asynchronous operation.

## -remarks
This operation will not block. The returned [IAsyncOperationWithProgress](../windows.foundation/iasyncoperationwithprogress_2.md) (of [HttpResponseMessage](/uwp/api/windows.web.http.httpresponsemessage) and [HttpProgress](/uwp/api/windows.web.http.httpprogress)) completes after the whole response (including content) is read.

### Exception Handling

You must write code to handle exceptions when you call this method. Exceptions can result from parameter validation errors, name resolutions failures, and network errors. Exceptions from network errors (loss of connectivity, connection failures, and HTTP server failures, for example) can happen at any time. These errors result in exceptions being thrown. If not handled by your app, an exception can cause your entire app to be terminated by the runtime. For more information on how to handle exceptions, see [Handling exceptions in network apps](/previous-versions/windows/apps/dn263211(v=win.10)).

Below are the exceptions that this function throws.
### E_INVALIDARG

The *uri* parameter was **null** reference (**Nothing** in Visual Basic).

## -examples

## -see-also
[IAsyncOperationWithProgress](../windows.foundation/iasyncoperationwithprogress_2.md), [Uri](../windows.foundation/uri.md), [HttpClient](/windows/uwp/networking/httpclient), [HttpResponseMessage](/uwp/api/windows.web.http.httpresponsemessage), [HttpProgress](/uwp/api/windows.web.http.httpprogress)