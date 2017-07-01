---
-api-id: M:Windows.Security.Authentication.Web.Provider.WebAccountManager.InvalidateAppCacheForAccountAsync(Windows.Security.Credentials.WebAccount)
-api-type: winrt method
---

<!-- Method syntax.
public IAsyncAction WebAccountManager.InvalidateAppCacheForAccountAsync(WebAccount webAccount)
-->

# Windows.Security.Authentication.Web.Provider.WebAccountManager.InvalidateAppCacheForAccountAsync

## -description
Clears the web account manager's token cache for a specific web account.

## -parameters
### -param webAccount
The web account for which tokens will be cleared.

## -returns
This method does not return a value.

## -remarks
This method should be called whenever a web account provider app detects that a token cached by the web account manager for a specific account is invalid.

## -see-also

## -examples

