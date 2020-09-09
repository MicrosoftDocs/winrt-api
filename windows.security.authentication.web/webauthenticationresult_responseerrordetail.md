---
-api-id: P:Windows.Security.Authentication.Web.WebAuthenticationResult.ResponseErrorDetail
-api-type: winrt property
---

<!-- Property syntax
public uint ResponseErrorDetail { get; }
-->

# Windows.Security.Authentication.Web.WebAuthenticationResult.ResponseErrorDetail

## -description
Returns the HTTP error code when [ResponseStatus](webauthenticationresult_responsestatus.md) is equal to [WebAuthenticationStatus.ErrorHttp](webauthenticationstatus.md). This is only available if there is an error.

## -property-value
The specific HTTP error, for example 400.

## -remarks

## -examples

## -see-also
[Authentication and user identity (JavaScript)](/previous-versions/windows/apps/dn448918(v=win.10)), [Authentication and user identity](/windows/uwp/security/authentication-and-user-identity), [Quickstart: Connecting to an online identity provider (JavaScript)](/previous-versions/windows/apps/jj856915(v=win.10)), [Web authentication broker](/windows/uwp/security/web-authentication-broker), [Windows authentication broker sample](https://github.com/microsoft/Windows-universal-samples/tree/master/Samples/WebAuthenticationBroker)
