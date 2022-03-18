---
-api-id: P:Windows.Security.Authentication.Web.WebAuthenticationResult.ResponseData
-api-type: winrt property
---

<!-- Property syntax
public string ResponseData { get; }
-->

# Windows.Security.Authentication.Web.WebAuthenticationResult.ResponseData

## -description
Contains the protocol data when the operation successfully completes.

## -property-value
The returned data.

## -remarks
When the [WebAuthenticationOptions.UseTitle](webauthenticationoptions.md) option is used, this property contains the value of the webpage title. The ResponseData for HTTP GET and HTTP redirects includes the entire URL. For POST, the data is the entity body.

## -examples

## -see-also
[Authentication and user identity (JavaScript)](/previous-versions/windows/apps/dn448918(v=win.10)), [Authentication and user identity](/windows/uwp/security/authentication-and-user-identity), [Quickstart: Connecting to an online identity provider (JavaScript)](/previous-versions/windows/apps/jj856915(v=win.10)), [Web authentication broker](/windows/uwp/security/web-authentication-broker), [Windows authentication broker sample](https://github.com/microsoft/Windows-universal-samples/tree/master/Samples/WebAuthenticationBroker)
