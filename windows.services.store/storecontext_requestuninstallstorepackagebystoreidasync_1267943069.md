---
-api-id: M:Windows.Services.Store.StoreContext.RequestUninstallStorePackageByStoreIdAsync(System.String)
-api-type: winrt method
---

<!-- Method syntax.
public IAsyncOperation<StoreUninstallStorePackageResult> StoreContext.RequestUninstallStorePackageByStoreIdAsync(String storeId)
-->

# Windows.Services.Store.StoreContext.RequestUninstallStorePackageByStoreIdAsync

## -description
Attempts to uninstall the specified downloadable content (DLC) package for the current app. This method also displays a UI dialog that requests permission for the operation.

## -parameters
### -param storeId
The Store ID of the add-on that corresponds to the downloadable content (DLC) package to uninstall for the current app.

## -returns
An asynchronous operation that, on successful completion, returns a [StoreUninstallStorePackageResult](storeuninstallstorepackageresult.md) object that provides info about the uninstall operation.

## -remarks
You can use this method to free up disk space by uninstalling DLC packages that are no longer needed. For example, a game that offers both a single player campaign and a multiplayer campaign might use this method to uninstall the single player campaign at the user's request, after the user has completed that campaign.

When you call this method, the OS displays a dialog that asks the user's permission to uninstall the app package. To silently uninstall an app package without displaying a notification dialog, use [UninstallStorePackageAsync](storecontext_uninstallstorepackageasync_597217492.md) or [UninstallStorePackageByStoreIdAsync](storecontext_uninstallstorepackagebystoreidasync_262618884.md) (these methods require access to a restricted capability).

The Store ID for a an add-on is available in [Partner Center](https://partner.microsoft.com/dashboard), and it also is returned by the [StoreId](storeproduct_storeid.md) property of the [StoreProduct](storeproduct.md) that represents the add-on. For more information, see [Store IDs](/windows/uwp/monetize/in-app-purchases-and-trials#store-ids).

> [!NOTE]
> DLC packages are not available to all developer accounts.

## -see-also
[RequestUninstallStorePackageAsync](storecontext_requestuninstallstorepackageasync_1329597038.md),[UninstallStorePackageAsync](storecontext_uninstallstorepackageasync_597217492.md),[UninstallStorePackageByStoreIdAsync](storecontext_uninstallstorepackagebystoreidasync_262618884.md), [Optional packages and related set authoring](/windows/uwp/packaging/optional-packages)

## -examples
