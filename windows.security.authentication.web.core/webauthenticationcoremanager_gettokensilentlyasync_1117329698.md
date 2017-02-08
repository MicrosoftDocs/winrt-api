---
-api-id: M:Windows.Security.Authentication.Web.Core.WebAuthenticationCoreManager.GetTokenSilentlyAsync(Windows.Security.Authentication.Web.Core.WebTokenRequest)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperation<Windows.Security.Authentication.Web.Core.WebTokenRequestResult> GetTokenSilentlyAsync(Windows.Security.Authentication.Web.Core.WebTokenRequest request)
-->

# Windows.Security.Authentication.Web.Core.WebAuthenticationCoreManager.GetTokenSilentlyAsync

## -description
Attempts to get a token without showing any UI using one input. The user will never be prompted to enter their credentials.

## -parameters
### -param request
The web token request.

## -returns
When this method completes successfully, it returns the result of the web token request.

## -remarks
Unlike [RequestTokenAsync](webauthenticationcoremanager_requesttokenasync.md), you may call this method from background threads.

## -examples

## -see-also
[Web account management code sample](http://go.microsoft.com/fwlink/p/?LinkId=620621), [GetTokenSilentlyAsync(WebTokenRequest, WebAccount)](webauthenticationcoremanager_gettokensilentlyasync_35561430.md)