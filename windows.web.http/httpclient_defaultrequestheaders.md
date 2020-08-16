---
-api-id: P:Windows.Web.Http.HttpClient.DefaultRequestHeaders
-api-type: winrt property
---

<!-- Property syntax
public Windows.Web.Http.Headers.HttpRequestHeaderCollection DefaultRequestHeaders { get; }
-->

# Windows.Web.Http.HttpClient.DefaultRequestHeaders

## -description

Gets a collection of headers that should be sent with each request. For programming guidance for the [HttpClient class](/uwp/api/windows.web.http.httpclient), and code examples, see the [HttpClient](/windows/uwp/networking/httpclient) conceptual topic.

## -property-value

The headers that should be sent with each request.

## -remarks

The DefaultRequestHeaders property returns an [HttpRequestHeaderCollection](../windows.web.http.headers/httprequestheadercollection.md) object that can be used to get or set the specific headers on the [HttpClient](httpclient.md) instance. HTTP headers set on this property will be sent on all request messages sent on this [HttpClient](httpclient.md) instance and don't need to be set on each [HttpRequestMessage](httprequestmessage.md) instance.

The [Headers](httprequestmessage_headers.md) property on the [HttpRequestMessage](httprequestmessage.md) object returns an [HttpRequestHeaderCollection](../windows.web.http.headers/httprequestheadercollection.md) object that can be used to get or set the specific headers on a specific HTTP request.

The DefaultRequestHeaders property represents the headers that an app developer can set, not all of the headers that may eventually be sent with the request. The [HttpBaseProtocolFilter](../windows.web.http.filters/httpbaseprotocolfilter.md) will add some additional headers.

> [!WARNING]
> In versions before Windows 10, setting certain headers to NULL caused an empty header value to be set, which caused an unexpected failure in subsequent calls to [GetAsync](/uwp/api/windows.web.http.httpclient.getasync). Starting in Windows 10, setting any of the following headers to NULL causes them to be removed from the request entirely, so that the remaining headers are valid.

+ Authorization
+ Date
+ From
+ Host
+ If-Modified-Since
+ If-Unmodified-Since
+ Max-Forwards
+ Proxy-Authorization
+ Referer

If you are writing for versions before Windows 10, do not set these header values to NULL.

## -examples

## -see-also

[HttpClient](/windows/uwp/networking/httpclient)
