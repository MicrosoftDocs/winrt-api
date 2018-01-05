---
-api-id: M:Windows.Services.Store.StoreContext.UninstallStorePackageByStoreIdAsync(System.String)
-api-type: winrt method
---

<!-- Method syntax.
public IAsyncOperation<StoreUninstallStorePackageResult> StoreContext.UninstallStorePackageByStoreIdAsync(String storeId)
-->

# Windows.Services.Store.StoreContext.UninstallStorePackageByStoreIdAsync

## -description
Uninstalls the specified package for the current app without displaying a notification UI dialog to the user.

## -parameters
### -param storeId
The Store ID of the add-on that corresponds to the package to uninstall for the current app.

## -returns
An asynchronous operation that, on successful completion, returns a [StoreUninstallStorePackageResult](storeuninstallstorepackageresult.md) object that provides info about the uninstall operation.

## -remarks
You can use this method to free up disk space by uninstalling app packages that are no longer needed. For example, a game that offers both a single player campaign and a multiplayer campaign might use this method to uninstall the single player campaign at the user's request, after the user has completed that campaign.

When you call this method, the OS silently uninstalls the app package without displaying a notification dialog. This method requires the restricted **storePackageManagement** capability to perform this operation. If you don't have access to this restricted capability, you can use the [RequestUninstallStorePackageAsync](storecontext_requestuninstallstorepackageasync_1329597038.md) or [RequestUninstallStorePackageByStoreIdAsync](storecontext_requestuninstallstorepackagebystoreidasync_1267943069.md) methods instead (these methods display a notification dialog that requests the user's permission to uninstall the package).

The Store ID for a an add-on is available in the Windows Dev Center dashboard, and it also is returned by the [StoreId](storeproduct_storeid.md) property of the [StoreProduct](storeproduct.md) that represents the add-on. For more information, see [Store IDs](https://docs.microsoft.com/windows/uwp/monetize/in-app-purchases-and-trials#store-ids).

## -see-also
[UninstallStorePackageAsync](storecontext_uninstallstorepackageasync_597217492.md),[RequestUninstallStorePackageAsync](storecontext_requestuninstallstorepackageasync_1329597038.md),[RequestUninstallStorePackageByStoreIdAsync](storecontext_requestuninstallstorepackagebystoreidasync_1267943069.md)

## -examples

## -capabilities
storePackageManagement
