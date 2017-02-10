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
[AuthenticateAsync](webauthenticationbroker_authenticateasync_1561991399.md), [Authentication and user identity (JavaScript)](http://msdn.microsoft.com/library/1733481d-fe1f-46b1-8c75-086a89e41b46), [Authentication and user identity](http://msdn.microsoft.com/library/53e36ddc-200a-4850-aaf0-07eca3662bb9), [Quickstart: Connecting to an online identity provider (JavaScript)](http://msdn.microsoft.com/library/5c18bb8d-1c23-4fee-81b2-44ee02affcb6), [Web authentication broker](http://msdn.microsoft.com/library/05f06961-1768-44a7-b185-bcdb74488f85), [Windows authentication broker sample](http://code.msdn.microsoft.com/windowsapps/Web-Authentication-d0485122)