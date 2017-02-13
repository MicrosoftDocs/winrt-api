---
-api-id: P:Windows.Web.Http.Filters.HttpBaseProtocolFilter.UseProxy
-api-type: winrt property
---

<!-- Property syntax
public bool UseProxy { get;  set; }
-->

# Windows.Web.Http.Filters.HttpBaseProtocolFilter.UseProxy

## -description
Get or set a value that indicates whether the [HttpBaseProtocolFilter](httpbaseprotocolfilter.md) can use a proxy for sending HTTP requests.

## -property-value
A value that indicates whether [HttpBaseProtocolFilter](httpbaseprotocolfilter.md) can use a proxy to send HTTP requests.

This value is **true** if [HttpBaseProtocolFilter](httpbaseprotocolfilter.md) can use a proxy to send requests; otherwise **false**. The default value is **true** to allow proxies to be used.

## -remarks
It is possible for this property to be **true** and a proxy exists, but [HttpBaseProtocolFilter](httpbaseprotocolfilter.md) still doesn't use the proxy. This can occur depending on WPAD settings and whether the target URI is to an internal versus an external web server.

Many companies require the use of proxies to communicate with HTTP from a local intranet to the Internet.

## -examples

## -see-also
