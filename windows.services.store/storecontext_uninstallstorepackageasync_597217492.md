---
-api-id: M:Windows.Services.Store.StoreContext.UninstallStorePackageAsync(Windows.ApplicationModel.Package)
-api-type: winrt method
---

<!-- Method syntax.
public IAsyncOperation<StoreUninstallStorePackageResult> StoreContext.UninstallStorePackageAsync(Package package)
-->

# Windows.Services.Store.StoreContext.UninstallStorePackageAsync

## -description
Uninstalls the specified optional package for the current app without displaying a notification UI dialog to the user.

## -parameters
### -param package
The optional package to uninstall for the current app.

## -returns
An asynchronous operation that, on successful completion, returns a [StoreUninstallStorePackageResult](storeuninstallstorepackageresult.md) object that provides info about the uninstall operation.

## -remarks
You can use this method to free up disk space by uninstalling DLC packages that are no longer needed. For example, a game that offers both a single player campaign and a multiplayer campaign might use this method to uninstall the single player campaign at the user's request, after the user has completed that campaign.

> [!NOTE]
> Optional packages and DLC packages are not available to all developer accounts.

When you call this method, the OS silently uninstalls the app package without displaying a notification dialog. This method requires the restricted **storeOptionalPackageInstallManagement** capability to perform this operation. 

> [!NOTE]
> If you don't have access to the **storeOptionalPackageInstallManagement** restricted capability, you can use the [RequestDownloadAndInstallStorePackagesAsync](storecontext_requestdownloadandinstallstorepackagesasync_1733414901.md) methods instead (these methods display a notification dialog that requests the user's permission to install the package).


## -see-also
[UninstallStorePackageByStoreIdAsync](storecontext_uninstallstorepackagebystoreidasync_262618884.md),[RequestUninstallStorePackageAsync](storecontext_requestuninstallstorepackageasync_1329597038.md),[RequestUninstallStorePackageByStoreIdAsync](storecontext_requestuninstallstorepackagebystoreidasync_1267943069.md), [Optional packages and related set authoring](/windows/uwp/packaging/optional-packages)

## -examples

## -capabilities
storeOptionalPackageInstallManagement
