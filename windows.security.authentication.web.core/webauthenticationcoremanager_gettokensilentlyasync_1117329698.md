---
-api-id: M:Windows.Security.Authentication.Web.Core.WebAuthenticationCoreManager.GetTokenSilentlyAsync(Windows.Security.Authentication.Web.Core.WebTokenRequest)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperation<Windows.Security.Authentication.Web.Core.WebTokenRequestResult> GetTokenSilentlyAsync(Windows.Security.Authentication.Web.Core.WebTokenRequest request)
-->

# Windows.Security.Authentication.Web.Core.WebAuthenticationCoreManager.GetTokenSilentlyAsync

## -description
Asynchronously attempts to get a token without showing any UI. The user will never be prompted to enter their credentials.

## -parameters
### -param request
The web token request.

## -returns
An asynchronous request operation. On successful completion, contains a [WebTokenRequestResult](webtokenrequestresult.md) object representing the result of the web token request.

## -remarks
Unlike [RequestTokenAsync](webauthenticationcoremanager_requesttokenasync_1777535178.md), you may call this method from background threads.

## -examples

## -see-also
[Web account management code sample](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/WebAccountManagement), [GetTokenSilentlyAsync(WebTokenRequest, WebAccount)](webauthenticationcoremanager_gettokensilentlyasync_35561430.md)
