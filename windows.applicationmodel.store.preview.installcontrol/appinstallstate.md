---
-api-id: T:Windows.ApplicationModel.Store.Preview.InstallControl.AppInstallState
-api-type: winrt enum
---

<!-- Enumeration syntax
public enum Windows.ApplicationModel.Store.Preview.InstallControl.AppInstallState : int
-->

# AppInstallState

## -description
Defines the app install states that are returned by the [InstallState](appinstallstate.md) property of the [AppInstallStatus](appinstallstatus.md) class.

## -enum-fields
### -field Pending:0
The app install is pending.

### -field Starting:1
The app install is starting.

### -field AcquiringLicense:2
The license is being acquired for the app.

### -field Downloading:3
The app is being downloaded.

### -field RestoringData:4
The app data is being restored.

### -field Installing:5
The app is in the process of being installed.

### -field Completed:6
The app install is complete.

### -field Canceled:7
The app install is canceled.

### -field Paused:8
The app install was paused.

### -field Error:9
The app install encountered an error.

### -field PausedLowBattery:10
The app install was paused because the battery is low.

### -field PausedWiFiRecommended:11
The app install was paused because the app package was large enough to trigger a prompt for the user to download the app over Wi-Fi.

### -field PausedWiFiRequired:12
The app install was paused because the app package was large enough to require the user to download the app over Wi-Fi.

### -field ReadyToDownload:13
The app is ready to download.


## -remarks

## -examples

## -see-also
## -capabilities
runFullTrust
