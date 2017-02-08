---
-api-id: P:Windows.Web.Http.HttpCookie.Expires
-api-type: winrt property
---

<!-- Property syntax
public Windows.Foundation.IReference<Windows.Foundation.DateTime> Expires { get;  set; }
-->

# Windows.Web.Http.HttpCookie.Expires

## -description
Get or set the expiration date and time for the [HttpCookie](httpcookie.md).

## -property-value
The expiration date and time for the [HttpCookie](httpcookie.md).

## -remarks
Setting the [Expires](httpcookie_expires.md) property to **null** makes this a Cookie that is only good for the current HTTP session and will not be persisted. Setting the [Expires](httpcookie_expires.md) property to a date in the past deletes the Cookie.

The default value for the [Expires](httpcookie_expires.md) property is **null**.

Javascript and .NET languages do not use [DateTime](../windows.foundation/datetime.md) directly. In Javascript a [DateTime](../windows.foundation/datetime.md) is projected as a **Date** object, and in .NET it is projected as a [System.DateTimeOffset](https://msdn.microsoft.com/library/system.datetimeoffset.aspx) structure. In C++, the **DateTime.UniversalTime** member has the same granularity as a  and supports the date ranges required by Javascript and .NET.

## -examples

## -see-also
[DateTime](../windows.foundation/datetime.md)