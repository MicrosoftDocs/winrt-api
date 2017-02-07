---
-api-id: T:Windows.Services.Store.StorePackageUpdateState
-api-type: winrt enum
---

<!-- Enumeration syntax
public enum Windows.Services.Store.StorePackageUpdateState : int
-->

# StorePackageUpdateState

## -description
Defines values that represent the state of a package download or installation request.

## -enum-fields
### -field Pending:0
The download of the package updates has not started.

### -field Downloading:1
The package updates are being downloaded.

### -field Deploying:2
The package updates are being deployed to the device.

### -field Completed:3
The package updates have finished downloading or installing.

### -field Canceled:4
The download or installation of the package updates was canceled.

### -field OtherError:5
An unknown error occurred.

### -field ErrorLowBattery:6
The download or installation of the package updates did not succeed because the device does not have enough battery power.

### -field ErrorWiFiRecommended:7
The download did not succeed because a Wi-Fi connection is recommended to download the package updates.

### -field ErrorWiFiRequired:8
The download did not succeed because a Wi-Fi connection is required to download the package updates.


## -remarks
To request the download or install of a package, use the [RequestDownloadAndInstallStorePackagesAsync](storecontext_requestdownloadandinstallstorepackagesasync.md), [RequestDownloadAndInstallStorePackageUpdatesAsync](storecontext_requestdownloadandinstallstorepackageupdatesasync.md), or [RequestDownloadStorePackageUpdatesAsync](storecontext_requestdownloadstorepackageupdatesasync.md) methods of the [StoreContext](storecontext.md) class.

## -examples

## -see-also