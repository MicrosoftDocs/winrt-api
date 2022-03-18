---
-api-id: T:Windows.Security.Authentication.Web.Provider.WebAccountManager
-api-type: winrt class
---

<!-- Class syntax.
public class WebAccountManager 
-->

# Windows.Security.Authentication.Web.Provider.WebAccountManager

## -description
Provides methods for managing web accounts.

## -remarks

### Version history

| Windows version | SDK version | Value added |
| -- | -- | -- |
| 1511 | 10586 | PullCookiesAsync |
| 1607 | 14393 | AddWebAccountAsync(String,String,IReadOnlyDictionary<String,String>,WebAccountScope,String) |
| 1607 | 14393 | ClearPerUserFromPerAppAccountAsync |
| 1607 | 14393 | GetPerUserFromPerAppAccountAsync |
| 1607 | 14393 | SetPerAppToPerUserAccountAsync |
| 1703 | 15063 | AddWebAccountForUserAsync(User,String,String,IReadOnlyDictionary<String,String>) |
| 1703 | 15063 | AddWebAccountForUserAsync(User,String,String,IReadOnlyDictionary<String,String>,WebAccountScope) |
| 1703 | 15063 | AddWebAccountForUserAsync(User,String,String,IReadOnlyDictionary<String,String>,WebAccountScope,String) |
| 1703 | 15063 | FindAllProviderWebAccountsForUserAsync |
| 1709 | 16299 | InvalidateAppCacheForAccountAsync |
| 1709 | 16299 | InvalidateAppCacheForAllAccountsAsync |

## -examples

## -see-also
[Web account management sample](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/WebAccountManagement)
