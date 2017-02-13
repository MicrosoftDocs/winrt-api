---
-api-id: M:Windows.ApplicationModel.Store.Preview.InstallControl.AppInstallManager.UpdateAppByPackageFamilyNameForUserAsync(Windows.System.User,System.String,System.String)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperation<Windows.ApplicationModel.Store.Preview.InstallControl.AppInstallItem> UpdateAppByPackageFamilyNameForUserAsync(Windows.System.User user, System.String packageFamilyName, System.String correlationVector)
-->

# Windows.ApplicationModel.Store.Preview.InstallControl.AppInstallManager.UpdateAppByPackageFamilyNameForUserAsync

## -description
Starts the update of an app for a given user specified by the package family name, with the option to generate telemetry data.

## -parameters
### -param user
An object that identifies the user to specify for this operation.

### -param packageFamilyName
The package family name of the app to update.

### -param correlationVector
A correlation vector string that can be used to generate telemetry data.

## -returns
An asynchronous operation that, on successful completion, returns an [AppInstallItem](appinstallitem.md) that represents the app update that was added to the installation queue.

## -remarks

## -examples

## -see-also
