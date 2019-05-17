---
-api-id: P:Windows.Web.Http.Filters.HttpBaseProtocolFilter.AllowAutoRedirect
-api-type: winrt property
---

<!-- Property syntax
public bool AllowAutoRedirect { get;  set; }
-->

# Windows.Web.Http.Filters.HttpBaseProtocolFilter.AllowAutoRedirect

## -description
Get or set a value that indicates whether the [HttpBaseProtocolFilter](httpbaseprotocolfilter.md) should follow redirection responses.

## -property-value
A value that indicates whether the [HttpBaseProtocolFilter](httpbaseprotocolfilter.md) should follow redirection responses.

This value is **true** if the if [HttpBaseProtocolFilter](httpbaseprotocolfilter.md) should follow redirection responses; otherwise **false**. The default value is **true**.

## -remarks
Set AllowAutoRedirect to **true** if you want the [HttpBaseProtocolFilter](httpbaseprotocolfilter.md) to automatically follow HTTP redirection headers to the new location of the resource. The maximum number of redirections to follow is set internally by the system.

If AllowAutoRedirect is set to **false**, all HTTP responses with an HTTP status code from 300 to 399 are returned to whatever called the [HttpBaseProtocolFilter](httpbaseprotocolfilter.md), which might another filter that might then return them to the app.

The **Authorization** header is cleared on auto-redirects and the [HttpBaseProtocolFilter](httpbaseprotocolfilter.md) automatically tries to re-authenticate to the redirected location. In practice, this means that an app can't put custom authentication information into the **Authorization** header if it is possible to encounter redirection. Instead, the app must implement a custom authentication module using a filter.

## -examples

## -see-also
