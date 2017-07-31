---
-api-id: M:Windows.Web.Http.HttpClient.GetAsync(Windows.Foundation.Uri)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperationWithProgress<Windows.Web.Http.HttpResponseMessage, Windows.Web.Http.HttpProgress> GetAsync(Windows.Foundation.Uri uri)
-->

# Windows.Web.Http.HttpClient.GetAsync

## -description
Send a GET request to the specified Uri as an asynchronous operation.

## -parameters
### -param uri
The [Uri](../windows.foundation/uri.md) to which the request is to be sent.

## -returns
The object representing the asynchronous operation.

## -remarks
This operation will not block. The returned [IAsyncOperationWithProgress(HttpResponseMessage, HttpProgress)](../windows.foundation/iasyncoperationwithprogress_2.md) object will complete after the whole response (including content) is read.

For sample code in C#/VB/C++ and XAML that shows how to use [HttpClient](httpclient.md) and [GetAsync(Uri)](httpclient_getasync_1878488818.md) to connect to an HTTP server and send a GET request, see [HttpClient](http://msdn.microsoft.com/library/ec9820d3-3a46-474f-8a01-ae1c27442750).

For sample code in JavaScript and HTML that shows how to use [HttpClient](httpclient.md) and [GetAsync(Uri)](httpclient_getasync_1878488818.md) to connect to an HTTP server and send a GET request, see [Connecting to an HTTP server using Windows.Web.Http](http://msdn.microsoft.com/library/dfc2a92c-e84a-4def-9203-e348e64befe5).

Below are the exceptions that this function throws.

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
[Connecting to an HTTP server using Windows.Web.Http](http://msdn.microsoft.com/library/dfc2a92c-e84a-4def-9203-e348e64befe5), [Handling exceptions in network apps](http://msdn.microsoft.com/library/76fafcc9-c674-4cf8-baa0-2400638fae35), [GetAsync(Uri, HttpCompletionOption)](httpclient_getasync_1105627628.md), [IAsyncOperationWithProgress(HttpResponseMessage, HttpProgress)](../windows.foundation/iasyncoperationwithprogress_2.md), [System.Uri](https://msdn.microsoft.com/library/system.uri.aspx), [Windows.Foundation.Uri](../windows.foundation/uri.md), [Windows.Web.Http](windows_web_http.md)