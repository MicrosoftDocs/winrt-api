---
-api-id: P:Windows.Web.Http.HttpCookie.Domain
-api-type: winrt property
---

<!-- Property syntax
public string Domain { get; }
-->

# Windows.Web.Http.HttpCookie.Domain

## -description
Get the domain for which the [HttpCookie](httpcookie.md) is valid.

## -property-value
The domain for which the [HttpCookie](httpcookie.md) is valid.

## -remarks
The Domain property specifies those hosts to which the cookie will be sent.

A cookie with a Domain property of `.contoso.com` will be sent to the `contoso.com` domain and all subdomains (`www.contoso.com` and `info.contoso.com`, for example).

A cookie with a Domain property of `info.contoso.com` will not be sent to `contoso.com` or `www.contoso.com`, but will be sent to `info.contoso.com` and all subdomains (`uk.info.contoso.com` and `us.info.contoso.com`, for example).

The default value for the Domain property is the host name that this cookie was received from.

## -examples

## -see-also
