---
-api-id: M:Windows.Web.Http.HttpClient.GetInputStreamAsync(Windows.Foundation.Uri)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperationWithProgress<Windows.Storage.Streams.IInputStream, Windows.Web.Http.HttpProgress> GetInputStreamAsync(Windows.Foundation.Uri uri)
-->

# Windows.Web.Http.HttpClient.GetInputStreamAsync

## -description
Send a GET request to the specified [Uri](../windows.foundation/uri.md) and return the response body as a stream in an asynchronous operation. For programming guidance for the [HttpClient class](/uwp/api/windows.web.http.httpclient), and code examples, see the [HttpClient](/windows/uwp/networking/httpclient) conceptual topic.

## -parameters
### -param uri
The [Uri](../windows.foundation/uri.md) the request is sent to.

## -returns
The object representing the asynchronous operation.

## -remarks
This operation will not block. The returned [IAsyncOperationWithProgress(IInputStream, HttpProgress)](../windows.foundation/iasyncoperationwithprogress_2.md) object will complete after the whole response body is read. This method does not buffer the stream, so this method can support long streams of arbitrary length.

Below are the exceptions that this function throws.

### E_INVALIDARG

The *uri* parameter was a **null** reference (**Nothing** in Visual Basic).

## -examples

## -see-also
[Uri](../windows.foundation/uri.md), [HttpClient](/windows/uwp/networking/httpclient)