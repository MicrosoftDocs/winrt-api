---
-api-id: T:Windows.Web.Http.Filters.HttpBaseProtocolFilter
-api-type: winrt class
---

<!-- Class syntax.
public class HttpBaseProtocolFilter : Windows.Foundation.IClosable, Windows.Web.Http.Filters.IHttpBaseProtocolFilter, Windows.Web.Http.Filters.IHttpBaseProtocolFilter2, Windows.Web.Http.Filters.IHttpBaseProtocolFilter3, Windows.Web.Http.Filters.IHttpBaseProtocolFilter4, Windows.Web.Http.Filters.IHttpFilter
-->

# Windows.Web.Http.Filters.HttpBaseProtocolFilter

## -description
The base protocol filter for an [HttpClient](../windows.web.http/httpclient.md) instance.

## -remarks
The [HttpBaseProtocolFilter](httpbaseprotocolfilter.md) class provides the base filter or handler that is used by an [HttpClient](../windows.web.http/httpclient.md) instance. If no additional filters are added to the [HttpClient](../windows.web.http/httpclient.md) instance, then the [HttpBaseProtocolFilter](httpbaseprotocolfilter.md) object will be the only filter.

The [HttpBaseProtocolFilter](httpbaseprotocolfilter.md) class provides a set of properties for toggling various low-level HTTP stack behaviors.

Additional filters based on the [IHttpFilter](ihttpfilter.md) interface can be added to the filter chain applied to an [HttpClient](../windows.web.http/httpclient.md) instance that can further handle or process the results from the [HttpBaseProtocolFilter](httpbaseprotocolfilter.md) object.

The [HttpBaseProtocolFilter](httpbaseprotocolfilter.md) object throws exceptions when sending HTTP requests or receiving response and network failures occur (loss of connectivity in airplane mode, for example). Developers using [HttpClient](../windows.web.http/httpclient.md) in apps may prefer to add a filter to catch these exceptions and convert them to HTTP response codes instead.

## -examples

## -see-also
[IClosable](../windows.foundation/iclosable.md), [IHttpFilter](ihttpfilter.md)