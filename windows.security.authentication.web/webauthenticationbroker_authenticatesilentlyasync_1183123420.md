---
-api-id: M:Windows.Security.Authentication.Web.WebAuthenticationBroker.AuthenticateSilentlyAsync(Windows.Foundation.Uri,Windows.Security.Authentication.Web.WebAuthenticationOptions)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperation<Windows.Security.Authentication.Web.WebAuthenticationResult> AuthenticateSilentlyAsync(Windows.Foundation.Uri requestUri, Windows.Security.Authentication.Web.WebAuthenticationOptions options)
-->

# Windows.Security.Authentication.Web.WebAuthenticationBroker.AuthenticateSilentlyAsync

## -description
Starts the asynchronous authentication operation silently (no UI will be shown) with two inputs. You can call this method multiple times in a single application or across multiple applications at the same time.

## -parameters
### -param requestUri
The starting URI of the web service. This URI must be a secure address of https://.

### -param options
The options for the authentication operation.

## -returns
The way to query the status and get the results of the authentication operation. If you are getting an invalid parameter error, the most common cause is that you are not using HTTPS for the requestUri parameter.

## -remarks

## -examples

## -see-also
[AuthenticateSilentlyAsync(Uri)](webauthenticationbroker_authenticatesilentlyasync_444210422.md)