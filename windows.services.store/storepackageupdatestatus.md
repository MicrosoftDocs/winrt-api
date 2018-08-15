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
The download (or download and install) progress of the current package, represented by a value from 0.0 to 1.0. When you use [RequestDownloadStorePackageUpdatesAsync](storecontext_requestdownloadstorepackageupdatesasync_889669938.md) to download packages, this value increases from 0.0 to 1.0 during the download of each package. When you use [RequestDownloadAndInstallStorePackageUpdatesAsync](storecontext_requestdownloadandinstallstorepackageupdatesasync_1750789617.md) to download *and* install packages in a single operation, this value increases from 0.0 to 0.8 during the download of each package, and then it increases from 0.8 to 1.0 during the install phase.


### -field TotalDownloadProgress
The current progress of all package downloads in the request, represented by a value from 0.0 to 1.0.


### -field PackageUpdateState
A [StorePackageUpdateState](storepackageupdatestate.md) value that indicates the state of the package that is being downloaded or installed.


## -remarks
To request the download or install of a package, use the [RequestDownloadAndInstallStorePackagesAsync](storecontext_requestdownloadandinstallstorepackagesasync_1733414901.md), [RequestDownloadAndInstallStorePackageUpdatesAsync](storecontext_requestdownloadandinstallstorepackageupdatesasync_1750789617.md), or [RequestDownloadStorePackageUpdatesAsync](storecontext_requestdownloadstorepackageupdatesasync_889669938.md) methods of the [StoreContext](storecontext.md) class. The method that you assign to handle [Progress](../windows.foundation/iasyncoperationwithprogress_2_progress.md) notifications for the request receives a **StorePackageUpdateStatus** object.

## -examples

## -see-also
