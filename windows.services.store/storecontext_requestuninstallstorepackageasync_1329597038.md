---
-api-id: M:Windows.Services.Store.StoreContext.RequestUninstallStorePackageAsync(Windows.ApplicationModel.Package)
-api-type: winrt method
---

<!-- Method syntax.
public IAsyncOperation<StoreUninstallStorePackageResult> StoreContext.RequestUninstallStorePackageAsync(Package package)
-->

# Windows.Services.Store.StoreContext.RequestUninstallStorePackageAsync

## -description
Attempts to uninstall the specified optional package for the current app. This method also displays a UI dialog that requests permission for the operation.

## -parameters
### -param package
The optional package to uninstall for the current app.

## -returns
An asynchronous operation that, on successful completion, returns a [StoreUninstallStorePackageResult](storeuninstallstorepackageresult.md) object that provides info about the uninstall operation.

## -remarks
You can use this method to free up disk space by uninstalling optional packages that are no longer needed. For example, a game that offers both a single player campaign and a multiplayer campaign might use this method to uninstall the single player campaign at the user's request, after the user has completed that campaign.

When you call this method, the OS displays a dialog that asks the user's permission to uninstall the app package. To silently uninstall an app package without displaying a notification dialog, use [UninstallStorePackageAsync](storecontext_uninstallstorepackageasync_597217492.md) or [UninstallStorePackageByStoreIdAsync](storecontext_uninstallstorepackagebystoreidasync_262618884.md) (these methods require access to a restricted capability).

> [!NOTE]
> Optional packages and DLC packages are not available to all developer accounts.

## -see-also
[RequestUninstallStorePackageByStoreIdAsync](storecontext_requestuninstallstorepackagebystoreidasync_1267943069.md),[UninstallStorePackageAsync](storecontext_uninstallstorepackageasync_597217492.md),[UninstallStorePackageByStoreIdAsync](storecontext_uninstallstorepackagebystoreidasync_262618884.md),[Optional packages and related set authoring](/windows/uwp/packaging/optional-packages)

## -examples
