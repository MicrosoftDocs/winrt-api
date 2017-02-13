---
-api-id: T:Windows.Web.Http.HttpCookie
-api-type: winrt class
---

<!-- Class syntax.
public class HttpCookie : Windows.Foundation.IStringable, Windows.Web.Http.IHttpCookie
-->

# Windows.Web.Http.HttpCookie

## -description
Provides a set of properties and methods to manage an HTTP cookie.

## -remarks
Cookies are small chunks of data that are passed between HTTP servers and clients. Their primary use is by the web server developers to save session state. The web server developer uses the state to correlate earlier and later requests. For example, session state can include a unique visitor id which is then used to remember (on the server side) the visitor’s shopping cart.

The HTTP server sends cookies to the client with the **Set-Cookie** header. The client sends them back with the **Cookie** header. Cookies that are sent back don’t include cookie attributes. The correct cookie usage is that the server sets a cookie once and doesn’t re-set it on subsequent responses. This works because a cookie, once set, will be sent back until it expires or is deleted (as long as it matches the URI correctly). Cookies are persistent when they have a valid **Expires** header. Cookies that are not persistent are session cookies, and are not persisted from one session to another.

Although cookies are commonly used by web services developers, they are sometimes used by client-side developers.

## -examples

## -see-also
[HttpCookieCollection](httpcookiecollection.md), [HttpCookieManager](httpcookiemanager.md), [IStringable](../windows.foundation/istringable.md)