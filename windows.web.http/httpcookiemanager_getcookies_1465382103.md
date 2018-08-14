---
-api-id: M:Windows.Web.Http.HttpCookieManager.GetCookies(Windows.Foundation.Uri)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Web.Http.HttpCookieCollection GetCookies(Windows.Foundation.Uri uri)
-->

# Windows.Web.Http.HttpCookieManager.GetCookies

## -description
Gets an [HttpCookieCollection](httpcookiecollection.md) that contains the [HttpCookie](httpcookie.md) instances that are associated with a specific URI.

## -parameters
### -param uri
The URI of the [HttpCookie](httpcookie.md) instances desired.

## -returns
The [HttpCookieCollection](httpcookiecollection.md) that contains the [HttpCookie](httpcookie.md) instances that are associated with a specific URI.

## -remarks
The [GetCookies](httpcookiemanager_getcookies_1465382103.md) method creates a new instance of a [HttpCookieCollection](httpcookiecollection.md). Then the [HttpCookie](httpcookie.md) instances in the internal collection that are associated with the specified URI are read out and added to the new [HttpCookieCollection](httpcookiecollection.md).

Below are the exceptions that this function throws.
### E_INVALIDARG

The *uri* parameter was a **null** reference (**Nothing** in Visual Basic).

## -examples

## -see-also
