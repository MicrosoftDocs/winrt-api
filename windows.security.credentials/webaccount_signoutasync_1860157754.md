---
-api-id: M:Windows.Security.Credentials.WebAccount.SignOutAsync(System.String)
-api-type: winrt method
-api-device-family-note: xbox
---

<!-- Method syntax
public Windows.Foundation.IAsyncAction SignOutAsync(System.String clientId)
-->

# Windows.Security.Credentials.WebAccount.SignOutAsync

## -description
Signs the web account out asynchronously. This clears all cached tokens associated with the account, and tells the provider to invalidate any tokens associated with the account for this app.

## -parameters
### -param clientId
The Id of the client.

## -returns
This method does not return a value.

## -remarks
This method is app-specific and applies only to a single device. It will not remove the account from Windows or sign out the account on other devices.

## -examples

## -see-also
[SignOutAsync](webaccount_signoutasync_928921626.md)