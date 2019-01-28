---
-api-id: P:Windows.Web.Http.Filters.HttpBaseProtocolFilter.MaxConnectionsPerServer
-api-type: winrt property
---

<!-- Property syntax
public uint MaxConnectionsPerServer { get;  set; }
-->

# Windows.Web.Http.Filters.HttpBaseProtocolFilter.MaxConnectionsPerServer

## -description
Get or set the maximum number of TCP connections allowed per HTTP server by the [HttpBaseProtocolFilter](httpbaseprotocolfilter.md) object.

## -property-value
The maximum number of connections allowed per HTTP server.

## -remarks

The **MaxConnectionsPerServer** property determines the maximum number of TCP connections to an HTTP server allowed on the [HttpBaseProtocolFilter](httpbaseprotocolfilter.md) object. The best value for your application to set this property to depends on your usage pattern, and on the server, and it also depends on whether you're optimizing for performance for a single query or performance for all queries.

The default value for this property is currently 6. But the default value is a function of the version of the [HttpBaseProtocolFilter](httpbaseprotocolfilter.md), and it is not guaranteed to be unchanged from one release to another.

## -examples

## -see-also
