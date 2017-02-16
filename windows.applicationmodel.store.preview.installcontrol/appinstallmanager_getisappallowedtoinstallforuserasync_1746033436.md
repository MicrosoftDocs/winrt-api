---
-api-id: M:Windows.ApplicationModel.Store.Preview.InstallControl.AppInstallManager.GetIsAppAllowedToInstallForUserAsync(Windows.System.User,System.String,System.String,System.String,System.String)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperation<bool> GetIsAppAllowedToInstallForUserAsync(Windows.System.User user, System.String productId, System.String skuId, System.String catalogId, System.String correlationVector)
-->

# Windows.ApplicationModel.Store.Preview.InstallControl.AppInstallManager.GetIsAppAllowedToInstallForUserAsync

## -description
Determines whether the specified app has permission to install on the current computer or device for the specified user, with the option to generate telemetry data.

## -parameters
### -param user
An object that identifies the user to specify for this operation.

### -param productId
The product ID of the app that this method will check to determine if it has permission to be installed.

### -param skuId
The SKU ID of the app that this method will check to determine if it has permission to be installed.

### -param catalogId
The catalog ID of the app that this method will check to determine if it has permission to be installed.

### -param correlationVector
A correlation vector string that can be used to generate telemetry data.

## -returns
An asynchronous operation that, on successful completion, returns true if the app has permission to be installed; otherwise false.

## -remarks

## -examples

## -see-also
