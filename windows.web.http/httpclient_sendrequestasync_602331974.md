---
-api-id: M:Windows.Web.Http.HttpClient.SendRequestAsync(Windows.Web.Http.HttpRequestMessage)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperationWithProgress<Windows.Web.Http.HttpResponseMessage, Windows.Web.Http.HttpProgress> SendRequestAsync(Windows.Web.Http.HttpRequestMessage request)
-->

# Windows.Web.Http.HttpClient.SendRequestAsync

## -description
Send an HTTP request as an asynchronous operation.

## -parameters
### -param request
The HTTP request message to send.

## -returns
The object representing the asynchronous operation.

## -remarks
This operation will not block. The returned [IAsyncOperationWithProgress(HttpResponseMessage, HttpProgress)](../windows.foundation/iasyncoperationwithprogress_2.md) object will complete after the whole response (including content) is read.

The [HttpRequestMessage](httprequestmessage.md) passed in the *request* parameter allows the [SendRequestAsync](httpclient_sendrequestasync_602331974.md) method to set headers on the request message as well as on the HTTP content to be sent. In contrast, the [PostAsync](httpclient_postasync_1466488101.md) and [PutAsync](httpclient_putasync_552115331.md) methods only allow setting a more limited set of HTTP content headers.

Below are the exceptions that this function throws.
### E_INVALIDARG

The *request* parameter was a **null** reference (**Nothing** in Visual Basic).

### E_ILLEGAL_METHOD_CALL

The request message was already sent by the [HttpClient](httpclient.md) instance.

## -examples

## -see-also
[HttpRequestMessage](httprequestmessage.md), [PostAsync](httpclient_postasync_1466488101.md), [PutAsync](httpclient_putasync_552115331.md), [SendRequestAsync(HttpRequestMessage, HttpCompletionOption)](httpclient_sendrequestasync_234300504.md)