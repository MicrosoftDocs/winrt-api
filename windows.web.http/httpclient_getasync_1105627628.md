---
-api-id: M:Windows.Web.Http.HttpClient.GetAsync(Windows.Foundation.Uri,Windows.Web.Http.HttpCompletionOption)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperationWithProgress<Windows.Web.Http.HttpResponseMessage, Windows.Web.Http.HttpProgress> GetAsync(Windows.Foundation.Uri uri, Windows.Web.Http.HttpCompletionOption completionOption)
-->

# Windows.Web.Http.HttpClient.GetAsync

## -description
Send a GET request to the specified [Uri](../windows.foundation/uri.md) with an HTTP completion option as an asynchronous operation. For programming guidance for the [HttpClient class](/uwp/api/windows.web.http.httpclient), and code examples, see the [HttpClient](/windows/uwp/networking/httpclient) conceptual topic.

## -parameters
### -param uri
The [Uri](../windows.foundation/uri.md) the request is sent to.

### -param completionOption
An HTTP completion option value that indicates when the operation should be considered completed.

## -returns
The object representing the asynchronous operation.

## -remarks
This operation will not block. The returned [IAsyncOperationWithProgress](../windows.foundation/iasyncoperationwithprogress_2.md) (of [HttpResponseMessage](/uwp/api/windows.web.http.httpresponsemessage) and [HttpProgress](/uwp/api/windows.web.http.httpprogress)) completes based on the *completionOption* parameter after part or all of the response (including content) is read.

Below are the exceptions that this content throws.

### COMException

Thrown when a feature-specific **HRESULT** is returned from a method call.

This is the most common exception that is thrown by networking methods. An app should use the **HRESULT** from the exception to determine the cause of the error.

### AccessDeniedException

Thrown when access is denied to a resource or feature. This exception occurs when an app doesn't have the required network capabilities set in the app manifest for the network operation requested.

### InvalidArgumentException

Thrown when one of the arguments that are provided to a method is not valid.

If user-supplied input caused this exception, an app could inform the user and request new input.

### ObjectDisposedException

Thrown when an operation is performed on a disposed object.

### OutOfMemoryException

Thrown when insufficient memory is available to complete the operation.

## -examples

## -see-also
[Connecting to an HTTP server using Windows.Web.Http](/previous-versions/windows/apps/dn469430(v=win.10)), [Handling exceptions in network apps](/previous-versions/windows/apps/dn263211(v=win.10)), [GetAsync(Uri)](httpclient_getasync_1878488818.md), [HttpCompletionOption](httpcompletionoption.md), [IAsyncOperationWithProgress](../windows.foundation/iasyncoperationwithprogress_2.md), [HttpResponseMessage](/uwp/api/windows.web.http.httpresponsemessage), [HttpProgress](/uwp/api/windows.web.http.httpprogress), [System.Uri](/dotnet/api/system.uri?view=dotnet-uwp-10.0&preserve-view=true), [Windows.Foundation.Uri](../windows.foundation/uri.md), [Windows.Web.Http](windows_web_http.md), [HttpClient](/windows/uwp/networking/httpclient)