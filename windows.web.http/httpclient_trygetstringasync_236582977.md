---
-api-id: M:Windows.Web.Http.HttpClient.TryGetStringAsync(Windows.Foundation.Uri)
-api-type: winrt method
ms.custom: 19H1
---

<!-- Method syntax.
public IAsyncOperationWithProgress<HttpProgress> HttpClient.TryGetStringAsync(Uri uri)
-->

# Windows.Web.Http.HttpClient.TryGetStringAsync

## -description
Send a GET request to the specified Uri and return the response body as a string in an asynchronous operation. For programming guidance for the [HttpClient class](/uwp/api/windows.web.http.httpclient), and code examples, see the [HttpClient](/windows/uwp/networking/httpclient) conceptual topic.

## -parameters
### -param uri
The Uri the request is sent to.

## -returns
The object representing the asynchronous operation.

## -remarks
This operation will not block. The returned [IAsyncOperationWithProgress](../windows.foundation/iasyncoperationwithprogress_2.md) (of [HttpGetStringResult](/uwp/api/windows.web.http.httpgetstringresult) and [HttpProgress](/uwp/api/windows.web.http.httpprogress)) completes after the whole response body is read.

The [HttpClient](httpclient.md) class is often used by an app to download and then parse text. It is possible that the character encoding specified in the **Content-Type** header by an HTTP server does not match the character encoding of the HTTP response body (the XML encoding in an XML document, for example). One way to use [HttpClient](httpclient.md) with text is to call the TryGetStringAsync method and pass the returned string to the text parser. However, this can result in errors if the **Content-Type** is not a type expressible as a string. A reliable way to use [HttpClient](httpclient.md) with an XML parser is to call the [TryGetBufferAsync](httpclient_trygetbufferasync_1418039801.md) method and parse the buffer for the "&lt;?xml&gt;" element. Then use the character encoding specified ("&lt;xmlversion="1.0" encoding="UTF-8"?&gt;", for example) to parse the HTTP response body. For other text formats, similar methods can be used where the app scans the initial part of the HTTP response body to determine the character encoding used.

## -see-also
[HttpGetStringResult](httpgetstringresult.md), [HttpProgress](httpprogress.md), [HttpClient](/windows/uwp/networking/httpclient)

## -examples

