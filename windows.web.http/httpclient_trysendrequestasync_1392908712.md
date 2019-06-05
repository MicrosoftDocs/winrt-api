---
-api-id: M:Windows.Web.Http.HttpClient.TrySendRequestAsync(Windows.Web.Http.HttpRequestMessage,Windows.Web.Http.HttpCompletionOption)
-api-type: winrt method
ms.custom: 19H1
---

<!-- Method syntax.
public IAsyncOperationWithProgress<HttpProgress> HttpClient.TrySendRequestAsync(HttpRequestMessage request, HttpCompletionOption completionOption)
-->

# Windows.Web.Http.HttpClient.TrySendRequestAsync

## -description
Sends an HTTP request with a completion option to the specified [Uri](../windows.foundation/uri.md) as an asynchronous operation. For programming guidance for the [HttpClient class](/uwp/api/windows.web.http.httpclient), and code examples, see the [HttpClient](/windows/uwp/networking/httpclient) conceptual topic.

## -parameters
### -param request
The HTTP request message to send.

### -param completionOption
A value that indicates whether the [HttpClient](httpclient.md) operation is considered completed when all of the response is read, or when just the headers are read.

## -returns
The object representing the asynchronous operation.

## -remarks
This operation will not throw an exception on network errors. Instead you should examine the [HttpRequestResult](httprequestresult.md) to learn about the original HTTP request, the resulting HTTP response (if any) and error (if any). This operation will throw when the operation is canceled.

This operation will not block. The returned [IAsyncOperationWithProgress(HttpRequestResult,HttpProgress)](../windows.foundation/iasyncoperationwithprogress_2.md) object will complete based on the *completionOption* parameter after part or all of the response (including content) is read.

## -see-also
[HttpRequestMessage](httprequestmessage.md), [HttpRequestResult](httprequestresult.md), [HttpCompletionOption](httpcompletionoption.md), [HttpProgress](httpprogress.md), [HttpResponseMessage](httpresponsemessage.md), [HttpClient](/windows/uwp/networking/httpclient)

## -examples

