---
-api-id: T:Windows.Web.Http.Filters.HttpCacheControl
-api-type: winrt class
---

<!-- Class syntax.
public class HttpCacheControl : Windows.Web.Http.Filters.IHttpCacheControl
-->

# Windows.Web.Http.Filters.HttpCacheControl

## -description
Provides control of the local HTTP cache for responses to HTTP requests by methods in the [Windows.Web.Http](../windows.web.http/windows_web_http.md) and [Windows.Web.Http.Filters](windows_web_http_filters.md) namespaces.

## -remarks
The HttpCacheControl object provides properties to get or set the read and write cache control behavior to be used on the [HttpBaseProtocolFilter](httpbaseprotocolfilter.md) object. HTTP read requests can use the local HTTP cache for the responses. Content returned by HTTP requests can be written to the local HTTP cache.

The HttpCacheControl object allows a developer to set simple read and write cache control behavior on the [HttpBaseProtocolFilter](httpbaseprotocolfilter.md) object. To use this feature, an app creates an [HttpClient](../windows.web.http/httpclient.md) object with a new [HttpBaseProtocolFilter](httpbaseprotocolfilter.md) object. The [CacheControl](httpbaseprotocolfilter_cachecontrol.md) property on the [HttpBaseProtocolFilter](httpbaseprotocolfilter.md) object returns an HttpCacheControl object used to set read and write cache behavior for the [HttpBaseProtocolFilter](httpbaseprotocolfilter.md) and the associated [HttpClient](../windows.web.http/httpclient.md) object. This determines the read and write cache behavior on responses to [HttpClient](../windows.web.http/httpclient.md) requests.

Developers can still use the HTTP **Cache-Control** header for more complete control over caching. The [HttpCacheDirectiveHeaderValueCollection](../windows.web.http.headers/httpcachedirectiveheadervaluecollection.md) provides a collection container for instances of the cache directives in **Cache-Control** HTTP header on HTTP content associated with an HTTP request or response.

## -examples

## -see-also
[CacheControl](httpbaseprotocolfilter_cachecontrol.md), [HttpCacheDirectiveHeaderValueCollection](../windows.web.http.headers/httpcachedirectiveheadervaluecollection.md), [HttpBaseProtocolFilter](httpbaseprotocolfilter.md), [HttpClient](../windows.web.http/httpclient.md)
