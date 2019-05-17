---
-api-id: T:Windows.Web.Http.HttpCookieManager
-api-type: winrt class
ms.custom: 19H1
---

<!-- Class syntax.
public class HttpCookieManager : Windows.Web.Http.IHttpCookieManager
-->

# Windows.Web.Http.HttpCookieManager

## -description
Add or delete an [HttpCookie](httpcookie.md) or view the cookies associated with an app.

## -remarks
The HttpCookieManager object is used to add or delete an [HttpCookie](httpcookie.md) or view the cookies associated with an app.

The [CookieManager](../windows.web.http.filters/httpbaseprotocolfilter_cookiemanager.md) property on [HttpBaseProtocolFilter](../windows.web.http.filters/httpbaseprotocolfilter.md) returns an HttpCookieManager object. To construct an HttpCookieManager, an [HttpBaseProtocolFilter](../windows.web.http.filters/httpbaseprotocolfilter.md) object is first created and then the [CookieManager](../windows.web.http.filters/httpbaseprotocolfilter_cookiemanager.md) property on [HttpBaseProtocolFilter](../windows.web.http.filters/httpbaseprotocolfilter.md) returns the HttpCookieManager object.

## -examples

## -see-also
[CookieManager](../windows.web.http.filters/httpbaseprotocolfilter_cookiemanager.md), [HttpBaseProtocolFilter](../windows.web.http.filters/httpbaseprotocolfilter.md)
