---
-api-id: M:Windows.ApplicationModel.Store.Preview.InstallControl.AppInstallManager.GetIsAppAllowedToInstallAsync(System.String,System.String,System.String,System.String)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperation<bool> GetIsAppAllowedToInstallAsync(System.String productId, System.String skuId, System.String catalogId, System.String correlationVector)
-->

# Windows.ApplicationModel.Store.Preview.InstallControl.AppInstallManager.GetIsAppAllowedToInstallAsync

## -description
Determines whether the specified app has permission to install on the current computer or device, with the option to generate telemetry data.

## -parameters
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
[GetIsAppAllowedToInstallAsync(String)](appinstallmanager_getisappallowedtoinstallasync_714292356.md)