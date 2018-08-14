---
-api-id: M:Windows.Web.Http.HttpCookieManager.SetCookie(Windows.Web.Http.HttpCookie)
-api-type: winrt method
---

<!-- Method syntax
public bool SetCookie(Windows.Web.Http.HttpCookie cookie)
-->

# Windows.Web.Http.HttpCookieManager.SetCookie

## -description
Add or change an [HttpCookie](httpcookie.md) in the cookies associated with an app that is sent on future requests.

## -parameters
### -param cookie
The [HttpCookie](httpcookie.md) to change or add.

## -returns
**true** if the [HttpCookie](httpcookie.md) replaced an existing cookie; otherwise **false**.

## -remarks
If the [HttpCookie](httpcookie.md) already exists, then the values and parameters associated the [HttpCookie](httpcookie.md) are updated.

If the [HttpCookie](httpcookie.md) does not exist, then the [HttpCookie](httpcookie.md) is added.

The added or changed [HttpCookie](httpcookie.md) will be sent on subsequent HTTP requests.

Setting an [HttpCookie](httpcookie.md) doesn't update the [HttpCookieCollection](httpcookiecollection.md) previously returned by the [GetCookies](httpcookiemanager_getcookies_1465382103.md) method.

## -examples

## -see-also
[SetCookie(HttpCookie, Boolean)](httpcookiemanager_setcookie_1318494933.md)