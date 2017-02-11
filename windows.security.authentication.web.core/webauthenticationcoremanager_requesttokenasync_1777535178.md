---
-api-id: M:Windows.Security.Authentication.Web.Core.WebAuthenticationCoreManager.RequestTokenAsync(Windows.Security.Authentication.Web.Core.WebTokenRequest)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperation<Windows.Security.Authentication.Web.Core.WebTokenRequestResult> RequestTokenAsync(Windows.Security.Authentication.Web.Core.WebTokenRequest request)
-->

# Windows.Security.Authentication.Web.Core.WebAuthenticationCoreManager.RequestTokenAsync

## -description
Requests a token from a web account provider asynchronously. If needed, the user may be prompted to enter their credentials.

## -parameters
### -param request
The web token request.

## -returns
When this method completes successfully, it returns the results of the web token request.

## -remarks
This method cannot be called from background threads.

## -examples

## -see-also
[Web account management code sample](http://go.microsoft.com/fwlink/p/?LinkId=620621), [RequestTokenAsync(WebTokenRequest, WebAccount)](webauthenticationcoremanager_requesttokenasync_695504446.md)