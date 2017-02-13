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
There is no explicit *callbackUri* parameter in this method. The application's default URI is used internally as the terminator. For more information, see [GetCurrentApplicationCallbackUri](webauthenticationbroker_getcurrentapplicationcallbackuri.md).

## -examples

## -see-also
[GetCurrentApplicationCallbackUri](webauthenticationbroker_getcurrentapplicationcallbackuri.md), [AuthenticateAsync(WebAuthenticationOptions, Uri, Uri)](webauthenticationbroker_authenticateasync_1220733327.md), [Authentication and user identity (JavaScript)](http://msdn.microsoft.com/library/1733481d-fe1f-46b1-8c75-086a89e41b46), [Authentication and user identity](http://msdn.microsoft.com/library/53e36ddc-200a-4850-aaf0-07eca3662bb9), [Quickstart: Connecting to an online identity provider (JavaScript)](http://msdn.microsoft.com/library/5c18bb8d-1c23-4fee-81b2-44ee02affcb6), [Web authentication broker](http://msdn.microsoft.com/library/05f06961-1768-44a7-b185-bcdb74488f85), [Windows authentication broker sample](http://code.msdn.microsoft.com/windowsapps/Web-Authentication-d0485122)