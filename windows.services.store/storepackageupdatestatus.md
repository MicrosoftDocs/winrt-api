---
-api-id: T:Windows.Services.Store.StorePackageUpdateStatus
-api-type: winrt struct
---

<!-- Structure syntax.
public struct StorePackageUpdateStatus
-->

# StorePackageUpdateStatus

## -description
Provides status info for a package that is associated with a download or installation request.

## -struct-fields

### -field PackageFamilyName
The family name of the package that is being downloaded or installed.


### -field PackageDownloadSizeInBytes
The size of the package that is being downloaded, in bytes. This is an estimate, and it might change during the download process.


### -field PackageBytesDownloaded
The number of bytes that have been downloaded.


### -field PackageDownloadProgress
The current progress of the package download, represented by a value from 0.0 to 1.0.


### -field TotalDownloadProgress
The current progress of all package downloads in the current request, represented by a value from 0.0 to 1.0.


### -field PackageUpdateState
A [StorePackageUpdateState](storepackageupdatestate.md) value that indicates the state of the package that is being downloaded or installed.


## -remarks
To request the download or install of a package, use the [RequestDownloadAndInstallStorePackagesAsync](storecontext_requestdownloadandinstallstorepackagesasync.md), [RequestDownloadAndInstallStorePackageUpdatesAsync](storecontext_requestdownloadandinstallstorepackageupdatesasync.md), or [RequestDownloadStorePackageUpdatesAsync](storecontext_requestdownloadstorepackageupdatesasync.md) methods of the [StoreContext](storecontext.md) class. An object of this type is passed to the method that you assign to handle [Progress](../windows.foundation/iasyncoperationwithprogress_2_progress.md) notifications for the request.

## -examples

## -see-also
