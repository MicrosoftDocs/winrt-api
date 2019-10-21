---
-api-id: P:Windows.Web.Http.HttpResponseMessage.RequestMessage
-api-type: winrt property
ms.custom: 19H1
---

<!-- Property syntax
public Windows.Web.Http.HttpRequestMessage RequestMessage { get;  set; }
-->

# Windows.Web.Http.HttpResponseMessage.RequestMessage

## -description
Gets or sets the request message that led to this response message.

## -property-value
The request message that led to this response message.

## -remarks
This property is the request message that led to this response message. For a request sent using [HttpClient](httpclient.md), this property will point to the actual request message leading to the final response. Note that this may not be the same message the user provided when sending the request. This is typically the case if the request needs to be resent due to redirects or authentication. This property can be used to determine what URI actually created the response (useful in case of redirects).

## -examples

## -see-also
