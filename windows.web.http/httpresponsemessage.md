---
-api-id: T:Windows.Web.Http.HttpResponseMessage
-api-type: winrt class
---

<!-- Class syntax.
public class HttpResponseMessage : Windows.Foundation.IClosable, Windows.Foundation.IStringable, Windows.Web.Http.IHttpResponseMessage
-->

# Windows.Web.Http.HttpResponseMessage

## -description
Represents an HTTP response message including headers, the status code, and data.

## -remarks
A common way to get an [HttpResponseMessage](httpresponsemessage.md) is the from the return value for one of the [DeleteAsync](httpclient_deleteasync.md), [GetAsync](httpclient_getasync.md), [PostAsync](httpclient_postasync.md) , [PutAsync](httpclient_putasync.md), or [SendRequestAsync](httpclient_sendrequestasync.md) methods on the [HttpClient](httpclient.md) object.

## -examples

## -see-also
[HttpClient](httpclient.md), [IClosable](../windows.foundation/iclosable.md), [IStringable](../windows.foundation/istringable.md)