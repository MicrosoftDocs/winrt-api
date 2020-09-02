---
-api-id: M:Windows.Security.Authentication.Web.WebAuthenticationBroker.GetCurrentApplicationCallbackUri
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.Uri GetCurrentApplicationCallbackUri()
-->

# Windows.Security.Authentication.Web.WebAuthenticationBroker.GetCurrentApplicationCallbackUri

## -description
Gets the current application callback URI.

## -returns
The URI of the current application.

## -remarks
The current application callback URI is used as an implicit value of the *callbackUri* parameter of the [AuthenticateAsync](webauthenticationbroker_authenticateasync_1561991399.md) method. However, applications need the URI value to add it to the request URI as required by the online provider.

## -examples

## -see-also
[AuthenticateAsync](webauthenticationbroker_authenticateasync_1561991399.md), [Authentication and user identity (JavaScript)](/previous-versions/windows/apps/dn448918(v=win.10)), [Authentication and user identity](/windows/uwp/security/authentication-and-user-identity), [Quickstart: Connecting to an online identity provider (JavaScript)](/previous-versions/windows/apps/jj856915(v=win.10)), [Web authentication broker](/windows/uwp/security/web-authentication-broker), [Windows authentication broker sample](https://github.com/microsoft/Windows-universal-samples/tree/master/Samples/WebAuthenticationBroker)
