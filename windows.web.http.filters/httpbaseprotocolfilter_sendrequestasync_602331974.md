---
-api-id: M:Windows.Web.Http.Filters.HttpBaseProtocolFilter.SendRequestAsync(Windows.Web.Http.HttpRequestMessage)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperationWithProgress<Windows.Web.Http.HttpResponseMessage, Windows.Web.Http.HttpProgress> SendRequestAsync(Windows.Web.Http.HttpRequestMessage request)
-->

# Windows.Web.Http.Filters.HttpBaseProtocolFilter.SendRequestAsync

## -description
Send an HTTP request using the [HttpBaseProtocolFilter](httpbaseprotocolfilter.md) as an asynchronous operation.

## -parameters
### -param request
The HTTP request message to send.

## -returns
The object representing the asynchronous operation.

## -remarks
This operation will not block. The returned [IAsyncOperationWithProgress(HttpResponseMessage, HttpProgress)](../windows.foundation/iasyncoperationwithprogress_2.md) object will complete once the entire HTTP response message is received.

Below are exceptions that this function throws.

### E_INVALIDARG
The *request* parameter was a **null** reference (**Nothing** in Visual Basic).

### E_ILLEGAL_METHOD_CALL
The request message was already sent by the [HttpBaseProtocolFilter](httpbaseprotocolfilter.md) instance.

## -examples

## -see-also
