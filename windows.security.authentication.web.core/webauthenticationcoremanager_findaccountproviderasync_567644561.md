---
-api-id: M:Windows.Security.Authentication.Web.Core.WebAuthenticationCoreManager.FindAccountProviderAsync(System.String,System.String)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperation<Windows.Security.Credentials.WebAccountProvider> FindAccountProviderAsync(System.String webAccountProviderId, System.String authority)
-->

# Windows.Security.Authentication.Web.Core.WebAuthenticationCoreManager.FindAccountProviderAsync

## -description
Asynchronously attempts to find a web account provider.

## -parameters
### -param webAccountProviderId
The Id of the web account provider to find.

### -param authority
The authority of the web account provider to find.

> [!IMPORTANT]
> When using `"https://login.windows.local"` as the *webAccountProviderId* value, you should not specify an *authority* value. Use the [single-parameter overload](webauthenticationcoremanager_findaccountproviderasync_1831443503.md) of this method instead.

## -returns
An asynchronous find operation. On successful completion, contains a [WebAccountProvider](../windows.security.credentials/webaccountprovider.md) object representing the found web account provider.

## -remarks

## -examples

## -see-also
[Web account management code sample](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/WebAccountManagement), [FindAccountProviderAsync(String)](webauthenticationcoremanager_findaccountproviderasync_1831443503.md)
