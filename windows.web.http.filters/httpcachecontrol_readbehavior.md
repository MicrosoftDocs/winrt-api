---
-api-id: P:Windows.Web.Http.Filters.HttpCacheControl.ReadBehavior
-api-type: winrt property
---

<!-- Property syntax
public Windows.Web.Http.Filters.HttpCacheReadBehavior ReadBehavior { get;  set; }
-->

# Windows.Web.Http.Filters.HttpCacheControl.ReadBehavior

## -description
Get or set the read behavior to use for cache control on the [HttpCacheControl](httpcachecontrol.md) object.

## -property-value
The read behavior to use for cache control.

## -remarks
The [ReadBehavior](httpcachecontrol_readbehavior.md) property on the [HttpCacheControl](httpcachecontrol.md) object allows an app to get or set the read cache behavior to use on the [HttpBaseProtocolFilter](httpbaseprotocolfilter.md) object. HTTP read requests can use the local HTTP cache for the responses. Content returned by HTTP requests can be written to the local HTTP cache.

## -examples

## -see-also
[CacheControl](httpbaseprotocolfilter_cachecontrol.md), [HttpBaseProtocolFilter](httpbaseprotocolfilter.md), [HttpCacheReadBehavior](httpcachereadbehavior.md), [WriteBehavior](httpcachecontrol_writebehavior.md)