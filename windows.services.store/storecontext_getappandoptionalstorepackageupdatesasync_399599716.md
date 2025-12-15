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

## Update availability

The time before this method detects a newly published update can vary. Most updates appear within a few hours, but some publishing and distribution steps may take longer to finish in certain cases. Because of this variability, the maximum detection time can reach up to a day.

After you certify and publish an app update in Partner Center, the update goes through a short propagation period before this method can recognize it. During this period, the update may not appear immediately.

### Detection frequency

This API limits how often it checks for new updates. When an app calls the method more frequently than the allowed rate, the method returns the last known status instead of performing a new check.

The current limits are:

- No more than one check every 30 minutes.
- No more than ten checks within any 24-hour period.

If an app exceeds these limits, the method continues returning the previous status until the applicable time window passes.

## -examples

## -see-also
[Download and install package updates for your app](/windows/uwp/packaging/self-install-package-updates),[Optional packages and related set authoring](/windows/uwp/packaging/optional-packages)
