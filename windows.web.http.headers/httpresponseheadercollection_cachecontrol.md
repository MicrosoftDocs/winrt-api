---
-api-id: P:Windows.Web.Http.Headers.HttpResponseHeaderCollection.CacheControl
-api-type: winrt property
---

<!-- Property syntax
public Windows.Web.Http.Headers.HttpCacheDirectiveHeaderValueCollection CacheControl { get; }
-->

# Windows.Web.Http.Headers.HttpResponseHeaderCollection.CacheControl

## -description
Gets the [HttpCacheDirectiveHeaderValueCollection](httpcachedirectiveheadervaluecollection.md) of objects that represent the value of a **Cache-Control** HTTP header on an HTTP response.

## -property-value
The collection of objects that represent the value of a **Cache-Control** HTTP header on an HTTP response. An empty collection means that the header is absent.

## -remarks
The CacheControl property represents the value of a **Cache-Control** HTTP header on an HTTP response.

Some of the objects in the [HttpCacheDirectiveHeaderValueCollection](httpcachedirectiveheadervaluecollection.md) for the **Cache-Control** header use the [Windows.Foundation.TimeSpan](../windows.foundation/timespan.md) structure. When programming with .NET, this structure is hidden and developers should use the [System.TimeSpan](/dotnet/api/system.timespan?view=dotnet-uwp-10.0&preserve-view=true) structure. The value can be **null**, because it's typed as `TimeSpan?` (a nullable [TimeSpan](/dotnet/api/system.timespan?view=dotnet-uwp-10.0&preserve-view=true)).

In JavaScript, this structure is accessed as a value, not as an object. For example, use `var a = 10000`, not `var a = { duration: 10000 }`.

> [!NOTE]
> In JavaScript, this structure is treated as the number of millisecond intervals, not the number of 100-nanosecond intervals.

For more detailed information, see the [Windows.Foundation.TimeSpan](../windows.foundation/timespan.md) interface.

## -examples

## -see-also
[HttpCacheDirectiveHeaderValueCollection](httpcachedirectiveheadervaluecollection.md), [HttpResponseMessage](../windows.web.http/httpresponsemessage.md), [HttpResponseMessage.Headers](../windows.web.http/httpresponsemessage_headers.md), [Windows.Foundation.TimeSpan](../windows.foundation/timespan.md)
