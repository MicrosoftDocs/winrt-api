---
-api-id: M:Windows.ApplicationModel.Store.Preview.InstallControl.AppInstallManager.IsStoreBlockedByPolicyAsync(System.String,System.String)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperation<bool> IsStoreBlockedByPolicyAsync(System.String storeClientName, System.String storeClientPublisher)
-->

# Windows.ApplicationModel.Store.Preview.InstallControl.AppInstallManager.IsStoreBlockedByPolicyAsync

## -description
Determines whether the specified app is blocked by policy on the current computer or device.

## -parameters
### -param storeClientName
The name of the app that this method will check to determine if is blocked by policy.

### -param storeClientPublisher
The publisher name of the app that this method will check to determine if is blocked by policy.

## -returns
An asynchronous operation that, on successful completion, returns true if the app can be installed; otherwise false.

## -remarks

## -examples

## -see-also

## -capabilities
runFullTrust
