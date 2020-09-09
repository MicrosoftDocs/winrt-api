---
-api-id: M:Windows.Security.Authentication.Web.WebAuthenticationBroker.AuthenticateAsync(Windows.Security.Authentication.Web.WebAuthenticationOptions,Windows.Foundation.Uri)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperation<Windows.Security.Authentication.Web.WebAuthenticationResult> AuthenticateAsync(Windows.Security.Authentication.Web.WebAuthenticationOptions options, Windows.Foundation.Uri requestUri)
-->

# Windows.Security.Authentication.Web.WebAuthenticationBroker.AuthenticateAsync

## -description
Starts the asynchronous authentication operation with two inputs. You can call this method multiple times in a single application or across multiple applications at the same time.

## -parameters
### -param options
The options for the authentication operation.

### -param requestUri
The starting URI of the web service. This URI must be a secure address of https://.

## -returns
The way to query the status and get the results of the authentication operation. If you are getting an invalid parameter error, the most common cause is that you are not using HTTPS for the *requestUri* parameter.

## -remarks
There is no explicit *callbackUri* parameter in this method. The application's default URI is used internally as the terminator. For more information, see [GetCurrentApplicationCallbackUri](webauthenticationbroker_getcurrentapplicationcallbackuri_1466144424.md).

## -examples

## -see-also
[GetCurrentApplicationCallbackUri](webauthenticationbroker_getcurrentapplicationcallbackuri_1466144424.md), [AuthenticateAsync(WebAuthenticationOptions, Uri, Uri)](webauthenticationbroker_authenticateasync_1220733327.md), [Authentication and user identity (JavaScript)](/previous-versions/windows/apps/dn448918(v=win.10)), [Authentication and user identity](/windows/uwp/security/authentication-and-user-identity), [Quickstart: Connecting to an online identity provider (JavaScript)](/previous-versions/windows/apps/jj856915(v=win.10)), [Web authentication broker](/windows/uwp/security/web-authentication-broker), [Windows authentication broker sample](https://github.com/microsoft/Windows-universal-samples/tree/master/Samples/WebAuthenticationBroker)
