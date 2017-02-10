---
-api-id: P:Windows.Web.Http.HttpCookie.Secure
-api-type: winrt property
---

<!-- Property syntax
public bool Secure { get;  set; }
-->

# Windows.Web.Http.HttpCookie.Secure

## -description
Get or set the security level for the [HttpCookie](httpcookie.md).

## -property-value
The security level for the [HttpCookie](httpcookie.md).

**true** if the client is only to return the cookie in subsequent requests if those requests use HTTPS; otherwise, **false**. The default is **false**.

## -remarks
When this property is **true**, this HTTP cookie may be sent only with **https://** requests. This provides additional security since this prevents network sniffing the value of the cookie.

## -examples

## -see-also
