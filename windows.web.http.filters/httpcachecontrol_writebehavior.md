---
-api-id: P:Windows.Web.Http.Filters.HttpCacheControl.WriteBehavior
-api-type: winrt property
---

<!-- Property syntax
public Windows.Web.Http.Filters.HttpCacheWriteBehavior WriteBehavior { get;  set; }
-->

# Windows.Web.Http.Filters.HttpCacheControl.WriteBehavior

## -description
Get or set the write behavior to use for cache control on the [HttpCacheControl](httpcachecontrol.md) object.

## -property-value
The read behavior to use for cache control.

## -remarks
The WriteBehavior property on the [HttpCacheControl](httpcachecontrol.md) object allows an app to get or set the write cache behavior to use on the [HttpBaseProtocolFilter](httpbaseprotocolfilter.md) object. Content returned by HTTP requests can be written to the local HTTP cache.

## -examples

## -see-also
[CacheControl](httpbaseprotocolfilter_cachecontrol.md), [HttpBaseProtocolFilter](httpbaseprotocolfilter.md), [HttpCacheWriteBehavior](httpcachewritebehavior.md), [ReadBehavior](httpcachecontrol_readbehavior.md)
