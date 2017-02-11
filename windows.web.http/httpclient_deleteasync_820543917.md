---
-api-id: M:Windows.Web.Http.HttpClient.DeleteAsync(Windows.Foundation.Uri)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperationWithProgress<Windows.Web.Http.HttpResponseMessage, Windows.Web.Http.HttpProgress> DeleteAsync(Windows.Foundation.Uri uri)
-->

# Windows.Web.Http.HttpClient.DeleteAsync

## -description
Send a DELETE request to the specified [Uri](../windows.foundation/uri.md) as an asynchronous operation.

## -parameters
### -param uri
The Uri the request is sent to.

## -returns
The object representing the asynchronous operation.

## -exceptions
### E_INVALIDARG

The *uri* parameter was **null** reference (**Nothing** in Visual Basic).

## -remarks
This operation will not block. The returned [IAsyncOperationWithProgress(HttpResponseMessage, HttpProgress)](../windows.foundation/iasyncoperationwithprogress_2.md) object will complete after the whole response (including content) is read.

### Exception Handling

You must write code to handle exceptions when you call this method. Exceptions can result from parameter validation errors, name resolutions failures, and network errors. Exceptions from network errors (loss of connectivity, connection failures, and HTTP server failures, for example) can happen at any time. These errors result in exceptions being thrown. If not handled by your app, an exception can cause your entire app to be terminated by the runtime. For more information on how to handle exceptions, see [Handling exceptions in network apps](http://msdn.microsoft.com/library/76fafcc9-c674-4cf8-baa0-2400638fae35).

## -examples

## -see-also
[IAsyncOperationWithProgress(HttpResponseMessage, HttpProgress)](../windows.foundation/iasyncoperationwithprogress_2.md), [Uri](../windows.foundation/uri.md)