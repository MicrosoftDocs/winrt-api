---
-api-id: M:Windows.Security.Authentication.Web.Core.WebAuthenticationCoreManager.FindAccountProviderAsync(System.String,System.String)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperation<Windows.Security.Credentials.WebAccountProvider> FindAccountProviderAsync(System.String webAccountProviderId, System.String authority)
-->

# Windows.Security.Authentication.Web.Core.WebAuthenticationCoreManager.FindAccountProviderAsync

## -description
Finds a web account provider asynchronously with two inputs.

## -parameters
### -param webAccountProviderId
The Id of the web account provider to find.

### -param authority
The authority of the web account provider to find.

> [!IMPORTANT]
> When using `"https://login.windows.local"` as the *webAccountProviderId* value, you should not specify an *authority* value. Use the [single-parameter overload](webauthenticationcoremanager_findaccountproviderasync_1831443503.md) of this method instead.

## -returns
When this method completes successfully, it returns the found web account provider.

## -remarks

## -examples

## -see-also
[Web account management code sample](http://go.microsoft.com/fwlink/p/?LinkId=620621), [FindAccountProviderAsync(String)](webauthenticationcoremanager_findaccountproviderasync_1831443503.md)