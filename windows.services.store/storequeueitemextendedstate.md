---
-api-id: T:Windows.Services.Store.StoreQueueItemExtendedState
-api-type: winrt enum
---

<!-- Enumeration syntax.
public enum StoreQueueItemExtendedState : int
-->

# Windows.Services.Store.StoreQueueItemExtendedState

## -description
Defines values that represent extended state info for a new or updated package that is in the download and installation queue for the current app.

## -enum-fields
### -field PausedWiFiRequired:13
The download of the package was paused because it requires a Wi-Fi connection.

### -field PausedWiFiRecommended:12
The download of the package was paused because a Wi-Fi connection is recommended.

### -field PausedReadyToInstall:14
The package is paused but ready to install.

### -field PausedPackagesInUse:10
The installation of the package was paused because the app is already using the related packages.

### -field PausedLowBattery:11
The download or install of the package was paused because of insufficient battery power.

### -field Paused:8
The download or install of the package was paused.

### -field Error:9
The download or install of the package encountered an error.

### -field Completed:6
The download and install of the package completed.

### -field Canceled:7
The download or install of the package was canceled.

### -field ActiveStarting:1
The download and install of the package is starting.

### -field ActiveRestoringData:4
The package is restoring data.

### -field ActivePending:0
The download and install of the package is pending.

### -field ActiveInstalling:5
The package is being installed.

### -field ActiveDownloading:3
The package is being downloaded.

### -field ActiveAcquiringLicense:2
The package is acquiring a license.

## -remarks

## -see-also
[StoreQueueItemState](storequeueitemstate.md)

## -examples
