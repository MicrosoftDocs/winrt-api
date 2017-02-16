---
-api-id: M:Windows.Security.Authentication.Web.WebAuthenticationBroker.AuthenticateSilentlyAsync(Windows.Foundation.Uri)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperation<Windows.Security.Authentication.Web.WebAuthenticationResult> AuthenticateSilentlyAsync(Windows.Foundation.Uri requestUri)
-->

# Windows.Security.Authentication.Web.WebAuthenticationBroker.AuthenticateSilentlyAsync

## -description
Starts the asynchronous authentication operation silently (no UI will be shown) with one input. You can call this method multiple times in a single application or across multiple applications at the same time.

## -parameters
### -param requestUri
The starting URI of the web service. This URI must be a secure address of https://.

## -returns
The way to query the status and get the results of the authentication operation. If you are getting an invalid parameter error, the most common cause is that you are not using HTTPS for the requestUri parameter.

## -remarks

## -examples

## -see-also
[AuthenticateSilentlyAsync(Uri, WebAuthenticationOptions)](webauthenticationbroker_authenticatesilentlyasync_1183123420.md)