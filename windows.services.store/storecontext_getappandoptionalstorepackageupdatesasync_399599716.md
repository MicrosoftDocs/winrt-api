---
-api-id: M:Windows.Services.Store.StoreContext.GetAppAndOptionalStorePackageUpdatesAsync
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperation<Windows.Foundation.Collections.IVectorView<Windows.Services.Store.StorePackageUpdate>> GetAppAndOptionalStorePackageUpdatesAsync()
-->

# Windows.Services.Store.StoreContext.GetAppAndOptionalStorePackageUpdatesAsync

## -description
Gets the collection of packages for the current app that have updates available for download from the Microsoft Store, including optional packages for the app.

## -returns
An asynchronous operation that, on successful completion, returns a collection of [StorePackageUpdate](storepackageupdate.md) objects that represent the packages that have updates available.

## -remarks
For more information about using this method, including a code example, see [Download and install package updates for your app](/windows/uwp/packaging/self-install-package-updates).

There is a latency of up to a day between the time when a package passes the certification process and when the GetAppAndOptionalStorePackageUpdatesAsync method recognizes that the package update is available to the app.

After you call GetAppAndOptionalStorePackageUpdatesAsync to determine which packages have updates available, you can call [RequestDownloadStorePackageUpdatesAsync](storecontext_requestdownloadstorepackageupdatesasync_889669938.md) to download the updated packages or you can call [RequestDownloadAndInstallStorePackageUpdatesAsync](storecontext_requestdownloadandinstallstorepackageupdatesasync_1750789617.md) to download and install the updated packages.

> [!IMPORTANT]
> Optional packages and downloadable content (DLC) packages are not available to all developer accounts.

## -examples

## -see-also
[Download and install package updates for your app](/windows/uwp/packaging/self-install-package-updates),[Optional packages and related set authoring](/windows/uwp/packaging/optional-packages)
