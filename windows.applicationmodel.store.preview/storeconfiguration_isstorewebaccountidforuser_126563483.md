---
-api-id: M:Windows.ApplicationModel.Store.Preview.StoreConfiguration.IsStoreWebAccountIdForUser(Windows.System.User,System.String)
-api-type: winrt method
---

<!-- Method syntax
public bool IsStoreWebAccountIdForUser(Windows.System.User user, System.String webAccountId)
-->

# Windows.ApplicationModel.Store.Preview.StoreConfiguration.IsStoreWebAccountIdForUser

## -description
Determines whether the specified user and user ID is also being used to sign in to the Windows Store on the device.

## -parameters
### -param user
An object that identifies the user for which to query.

### -param webAccountId
The user ID (typically obtained from the [WebAccount.Id](../windows.security.credentials/webaccount_id.md) property) to check.

## -returns
True if the user account specified by *webAccountId* is the same account that is signed in to the Windows Store; otherwise false.

## -remarks

## -examples

## -see-also
