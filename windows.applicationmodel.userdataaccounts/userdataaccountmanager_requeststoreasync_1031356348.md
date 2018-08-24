---
-api-id: M:Windows.ApplicationModel.UserDataAccounts.UserDataAccountManager.RequestStoreAsync(Windows.ApplicationModel.UserDataAccounts.UserDataAccountStoreAccessType)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperation<Windows.ApplicationModel.UserDataAccounts.UserDataAccountStore> RequestStoreAsync(Windows.ApplicationModel.UserDataAccounts.UserDataAccountStoreAccessType storeAccessType)
-->

# Windows.ApplicationModel.UserDataAccounts.UserDataAccountManager.RequestStoreAsync

## -description
Asynchronously returns the [UserDataAccountStore](userdataaccountstore.md) from the system.

## -parameters
### -param storeAccessType
Specifies the access type, such as read-only for all accounts or read/write for the calling app's accounts.

## -returns
Returns the [UserDataAccountStore](userdataaccountstore.md).

## -remarks
In order to gain access to the [UserDataAccountStore](userdataaccountstore.md), your app must declare at least one of the following capabilities:


+ contacts
+ appointments
+ email
If none of these capabilities are declared, [RequestStoreAsync](userdataaccountmanager_requeststoreasync_1031356348.md) will throw an **AccessDeniedException**.

If [RequestStoreAsync](userdataaccountmanager_requeststoreasync_1031356348.md) returns **null** it means that the user has turned off access in their privacy settings.

## -examples

## -see-also
