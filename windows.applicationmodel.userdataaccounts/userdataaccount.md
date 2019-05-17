---
-api-id: T:Windows.ApplicationModel.UserDataAccounts.UserDataAccount
-api-type: winrt class
---

<!-- Class syntax.
public class UserDataAccount : Windows.ApplicationModel.UserDataAccounts.IUserDataAccount, Windows.ApplicationModel.UserDataAccounts.IUserDataAccount2, Windows.ApplicationModel.UserDataAccounts.IUserDataAccount3, Windows.ApplicationModel.UserDataAccounts.IUserDataAccount4
-->

# Windows.ApplicationModel.UserDataAccounts.UserDataAccount

## -description
Represents a user data account used to access email, contacts, calendars, and so on.

## -remarks
Call [UserDataAccountStore.GetAccountAsync](userdataaccountstore_getaccountasync_446150997.md) to get an instance of this class.

### Version history

| Windows version | SDK version | Value added |
| -- | -- | -- |
| 1511 | 10586 | EnterpriseId |
| 1511 | 10586 | IsProtectedUnderLock |
| 1607 | 14393 | DisplayName |
| 1607 | 14393 | ExplictReadAccessPackageFamilyNames |
| 1703 | 15063 | CanShowCreateContactGroup |
| 1703 | 15063 | FindContactGroupsAsync |
| 1703 | 15063 | FindUserDataTaskListsAsync |
| 1703 | 15063 | ProviderProperties |
| 1703 | 15063 | TryShowCreateContactGroupAsync |

## -examples

## -see-also
