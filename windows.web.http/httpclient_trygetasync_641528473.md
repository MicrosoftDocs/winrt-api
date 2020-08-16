---
-api-id: M:Windows.Web.Http.HttpClient.TryGetAsync(Windows.Foundation.Uri,Windows.Web.Http.HttpCompletionOption)
-api-type: winrt method
ms.custom: 19H1
---

<!-- Method syntax.
public IAsyncOperationWithProgress<HttpProgress> HttpClient.TryGetAsync(Uri uri, HttpCompletionOption completionOption)
-->

# Windows.Web.Http.HttpClient.TryGetAsync

## -description
Sends a GET request to the specified [Uri](../windows.foundation/uri.md) as an asynchronous operation. For programming guidance for the [HttpClient class](/uwp/api/windows.web.http.httpclient), and code examples, see the [HttpClient](/windows/uwp/networking/httpclient) conceptual topic.

## -parameters
### -param uri
The Uri the request is sent to.

### -param completionOption
An HTTP completion option value that indicates when the operation should be considered completed.

## -returns
The object representing the asynchronous operation.

## -remarks
This operation will not throw an exception on network errors. Instead you should examine the [HttpRequestResult](httprequestresult.md) to learn about the original HTTP request, the resulting HTTP response (if any) and error (if any). This operation will throw when the operation is canceled.

This operation will not block. The returned [IAsyncOperationWithProgress](../windows.foundation/iasyncoperationwithprogress_2.md) (of [HttpRequestResult](/uwp/api/windows.web.http.httprequestresult) and [HttpProgress](/uwp/api/windows.web.http.httpprogress)) completes based on the *completionOption* parameter after part or all of the response (including content) is read.

## -see-also
[HttpRequestResult](httprequestresult.md), [HttpCompletionOption](httpcompletionoption.md), [HttpProgress](httpprogress.md), [HttpResponseMessage](httpresponsemessage.md), [HttpClient](/windows/uwp/networking/httpclient)

## -examples

