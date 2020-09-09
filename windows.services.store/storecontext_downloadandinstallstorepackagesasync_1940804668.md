---
-api-id: M:Windows.Services.Store.StoreContext.DownloadAndInstallStorePackagesAsync(Windows.Foundation.Collections.IIterable{System.String})
-api-type: winrt method
---

<!-- Method syntax.
public IAsyncOperationWithProgress<StorePackageUpdateStatus> StoreContext.DownloadAndInstallStorePackagesAsync(IIterable<String> storeIds)
-->

# Windows.Services.Store.StoreContext.DownloadAndInstallStorePackagesAsync

## -description
Downloads and installs the specified downloadable content (DLC) packages for the current app from the Microsoft Store without displaying a notification UI dialog to the user.

## -parameters
### -param storeIds
The Store IDs of the add-ons that correspond to the DLC packages to install for the current app.

## -returns
An object that the caller can observe to track progress and completion for the operation. On successful completion, the result is a [StorePackageUpdateResult](storepackageupdateresult.md) object that provides info about the package updates.

## -remarks
Use this method to download and install new DLC packages for the current app. When you call this method, the OS silently downloads and installs the packages without displaying a notification dialog. This method requires the restricted **storePackageManagement** capability to perform this operation. If you don't have access to this restricted capability, you can use the [RequestDownloadAndInstallStorePackagesAsync](storecontext_requestdownloadandinstallstorepackagesasync_1733414901.md) methods instead (these methods display a notification dialog that requests the user's permission to install the package).

> [!NOTE]
> DLC packages are not available to all developer accounts.

> [!NOTE]
> The restricted **storePackageManagement** capability is only available to desktop applications and games that use the [Desktop Bridge](https://developer.microsoft.com/windows/bridges/desktop) and to Xbox games that use XVC packages and are developed as part of a managed partner program, such as the [ID@Xbox](https://www.xbox.com/developers/id) program. These applications and games have this capability by default.

The Store ID for an add-on is available in [Partner Center](https://partner.microsoft.com/dashboard), and it also is returned by the [StoreId](storeproduct_storeid.md) property of the [StoreProduct](storeproduct.md) that represents the DLC add-on. For more information, see [Store IDs](/windows/uwp/monetize/in-app-purchases-and-trials#store-ids).

This operation will not block. The [IAsyncOperationWithProgress](../windows.foundation/iasyncoperationwithprogress_2.md) object returned by this method will complete after the packages are downloaded and installed.

The method that you assign to handle [Progress](../windows.foundation/iasyncoperationwithprogress_2_progress.md) notifications is called one time for each step in the download and installation process for each package in this request. The [Progress](../windows.foundation/iasyncoperationwithprogress_2_progress.md) handler receives a [StorePackageUpdateStatus](storepackageupdatestatus.md) argument that provides info about the package that raised the progress notification.

## -see-also
[RequestDownloadAndInstallStorePackagesAsync](storecontext_requestdownloadandinstallstorepackagesasync_1733414901.md),[Optional packages and related set authoring](/windows/uwp/packaging/optional-packages)

## -examples

## -capabilities
storePackageManagement
