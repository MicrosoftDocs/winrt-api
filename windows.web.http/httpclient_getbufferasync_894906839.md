---
-api-id: M:Windows.Web.Http.HttpClient.GetBufferAsync(Windows.Foundation.Uri)
-api-type: winrt method
ms.custom: 19H1
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperationWithProgress<Windows.Storage.Streams.IBuffer, Windows.Web.Http.HttpProgress> GetBufferAsync(Windows.Foundation.Uri uri)
-->

# Windows.Web.Http.HttpClient.GetBufferAsync

## -description
Send a GET request to the specified Uri and return the response body as a buffer in an asynchronous operation. For programming guidance for the [HttpClient class](/uwp/api/windows.web.http.httpclient), and code examples, see the [HttpClient](/windows/uwp/networking/httpclient) conceptual topic.

## -parameters
### -param uri
The Uri the request is sent to.

## -returns
The object representing the asynchronous operation.

## -remarks
This method is commonly called when downloading binary content such as small images and compressed files. Very large binary content should be downloaded as a stream with [HttpClient.GetInputStreamAsync](httpclient_getinputstreamasync_1910746187.md) to prevent unneeded buffering.

This operation will not block. The returned [IAsyncOperationWithProgress](../windows.foundation/iasyncoperationwithprogress_2.md) (of [IBuffer](/uwp/api/windows.storage.streams.ibuffer) and [HttpProgress](/uwp/api/windows.web.http.httpprogress)) completes after the whole response body is read.

The [HttpClient](httpclient.md) class is often used by an app to download and then parse text. It is possible that the character encoding specified in the **Content-Type** header by an HTTP server does not match the character encoding of the HTTP response body (the XML encoding in an XML document, for example). One way to use [HttpClient](httpclient.md) with text is to call the [GetStringAsync](httpclient_getstringasync_149346728.md) method and pass the returned string to the text parser. However, this can result in errors if the **Content-Type** is not a type expressible as a string. A reliable way to use [HttpClient](httpclient.md) with an XML parser is to call the GetBufferAsync method and parse the buffer for the "&lt;?xml&gt;" element. Then use the character encoding specified ("&lt;xmlversion="1.0" encoding="UTF-8"?&gt;", for example) to parse the HTTP response body. For other text formats, similar methods can be used where the app scans the initial part of the HTTP response body to determine the character encoding used.

Below are the exceptions that this function throws.

### E_INVALIDARG

The *uri* parameter was a **null** reference (**Nothing** in Visual Basic).

## -examples

## -see-also
[IAsyncOperationWithProgress](../windows.foundation/iasyncoperationwithprogress_2.md), [IBuffer](/uwp/api/windows.storage.streams.ibuffer), [HttpProgress](/uwp/api/windows.web.http.httpprogress), [Uri](../windows.foundation/uri.md), [HttpClient](/windows/uwp/networking/httpclient)