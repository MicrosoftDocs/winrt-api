---
-api-id: P:Windows.Web.Http.Filters.HttpBaseProtocolFilter.CacheControl
-api-type: winrt property
---

<!-- Property syntax
public Windows.Web.Http.Filters.HttpCacheControl CacheControl { get; }
-->

# Windows.Web.Http.Filters.HttpBaseProtocolFilter.CacheControl

## -description
Get or set the read and write cache control behavior to be used on the [HttpBaseProtocolFilter](httpbaseprotocolfilter.md) object.

## -property-value
The cache control behavior to be used on the [HttpBaseProtocolFilter](httpbaseprotocolfilter.md) object.

## -remarks
The [CacheControl](httpbaseprotocolfilter_cachecontrol.md) property gets an [HttpCacheControl](httpcachecontrol.md) object that allows access to the read and write cache control behavior used by the [HttpBaseProtocolFilter](httpbaseprotocolfilter.md) object. HTTP read requests can use the local HTTP cache for the responses. Content returned by HTTP requests can be written to the local HTTP cache.

The [CacheControl](httpbaseprotocolfilter_cachecontrol.md) property allows a developer to set simple read and write cache control behavior on the [HttpBaseProtocolFilter](httpbaseprotocolfilter.md) object. To use this feature, an app creates an [HttpClient](../windows.web.http/httpclient.md) object with a new [HttpBaseProtocolFilter](httpbaseprotocolfilter.md) object . The [CacheControl](httpbaseprotocolfilter_cachecontrol.md) property on the [HttpBaseProtocolFilter](httpbaseprotocolfilter.md) returns an [HttpCacheControl](httpcachecontrol.md) object. Properties on the [HttpCacheControl](httpcachecontrol.md) object are used to set to the read and write cache control behavior for the [HttpBaseProtocolFilter](httpbaseprotocolfilter.md) and the associated [HttpClient](../windows.web.http/httpclient.md) object. This determines the read and write cache behavior on responses to [HttpClient](../windows.web.http/httpclient.md) requests.

Developers can still use the HTTP **Cache-Control** header for more complete control over caching. The [HttpCacheDirectiveHeaderValueCollection](../windows.web.http.headers/httpcachedirectiveheadervaluecollection.md) provides a collection container for instances of the cache directives in **Cache-Control** HTTP header on HTTP content associated with an HTTP request or response. The **Cache-Control** header lets an app control caching behavior used by a server on HTTP content.

## -examples

## -see-also
[HttpCacheControl](httpcachecontrol.md), [HttpCacheDirectiveHeaderValueCollection](../windows.web.http.headers/httpcachedirectiveheadervaluecollection.md), [HttpClient](../windows.web.http/httpclient.md)