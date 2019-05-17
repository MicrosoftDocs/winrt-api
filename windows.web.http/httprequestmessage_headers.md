---
-api-id: P:Windows.Web.Http.HttpRequestMessage.Headers
-api-type: winrt property
---

<!-- Property syntax
public Windows.Web.Http.Headers.HttpRequestHeaderCollection Headers { get; }
-->

# Windows.Web.Http.HttpRequestMessage.Headers

## -description
Gets the collection of the HTTP request headers associated with the [HttpRequestMessage](httprequestmessage.md).

## -property-value
The collection of HTTP request headers associated with the [HttpRequestMessage](httprequestmessage.md).

## -remarks
The Headers property returns an [HttpRequestHeaderCollection](../windows.web.http.headers/httprequestheadercollection.md) object that can be used to get or set the specific headers on the HTTP request.

The Headers property represents the headers that an app developer can set, not all of the headers that may eventually be sent with the request. The [HttpBaseProtocolFilter](../windows.web.http.filters/httpbaseprotocolfilter.md) will add some additional headers.

## -examples

## -see-also
[HttpRequestHeaderCollection](../windows.web.http.headers/httprequestheadercollection.md)
