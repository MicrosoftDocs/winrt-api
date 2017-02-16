---
-api-id: M:Windows.ApplicationModel.UserDataAccounts.SystemAccess.UserDataAccountSystemAccessManager.SuppressLocalAccountWithAccountAsync(System.String)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncAction SuppressLocalAccountWithAccountAsync(System.String userDataAccountId)
-->

# Windows.ApplicationModel.UserDataAccounts.SystemAccess.UserDataAccountSystemAccessManager.SuppressLocalAccountWithAccountAsync

## -description
Asynchronously, and temporarily, replaces the default local account by using the specified account.

## -parameters
### -param userDataAccountId
The user ID of the account used to temporarily replace the default local account.

## -returns
Returns an async action indicating that the operation has completed.

## -remarks
The default local account is suppressed while the new account, referenced by *userDataAccountId*, is present on the device. When that new account is deleted, the local account pops back into the system.

## -examples

## -see-also


## -capabilities
userDataAccountsProvider