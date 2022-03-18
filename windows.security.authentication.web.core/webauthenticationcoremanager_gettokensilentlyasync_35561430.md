---
-api-id: M:Windows.Security.Authentication.Web.Core.WebAuthenticationCoreManager.GetTokenSilentlyAsync(Windows.Security.Authentication.Web.Core.WebTokenRequest,Windows.Security.Credentials.WebAccount)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperation<Windows.Security.Authentication.Web.Core.WebTokenRequestResult> GetTokenSilentlyAsync(Windows.Security.Authentication.Web.Core.WebTokenRequest request, Windows.Security.Credentials.WebAccount webAccount)
-->

# Windows.Security.Authentication.Web.Core.WebAuthenticationCoreManager.GetTokenSilentlyAsync

## -description
Asynchronously attempts to get a token without showing any UI. The user will never be prompted to enter their credentials.

## -parameters
### -param request
The web token request.

### -param webAccount
The web account.

## -returns
An asynchronous request operation. On successful completion, contains a [WebTokenRequestResult](webtokenrequestresult.md) object representing the result of the web token request.

## -remarks

## -examples

## -see-also
[Web account management code sample](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/WebAccountManagement), [GetTokenSilentlyAsync(WebTokenRequest)](webauthenticationcoremanager_gettokensilentlyasync_1117329698.md)
