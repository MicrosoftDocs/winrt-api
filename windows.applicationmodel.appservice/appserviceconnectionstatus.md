---
-api-id: T:Windows.ApplicationModel.AppService.AppServiceConnectionStatus
-api-type: winrt enum
---

<!-- Enumeration syntax
public enum Windows.ApplicationModel.AppService.AppServiceConnectionStatus : int
-->

# AppServiceConnectionStatus

## -description
Describes the status for the attempt that an app makes to open a connection to an app service by calling the [AppServiceConnection.OpenAsync](appserviceconnection_openasync_171309613.md) method. App service providers enable app-to-app communication by providing services that other Universal Windows app can consume.

## -enum-fields
### -field Success:0
The connection to the app service was opened successfully.

### -field AppNotInstalled:1
The package for the app service to which a connection was attempted is not installed on the device. Check that the package is installed before trying to open a connection to the app service.

### -field AppUnavailable:2
The package for the app service to which a connection was attempted is temporarily unavailable. Try to connect again later.

### -field AppServiceUnavailable:3
The app with the specified package family name is installed and available, but the app does not declare support for the specified app service. Check that the name of the app service and the version of the app are correct.

### -field Unknown:4
An unknown error occurred.

### -field RemoteSystemUnavailable:5
The device to which a connection was attempted is not available.

### -field RemoteSystemNotSupportedByApp:6
The app on the remote device does not support remote connections. It needs to specify SupportsRemoteSystems="true" on the appService extension in its AppXManifest to accept remote connections.

### -field NotAuthorized:7
The user for your app is not authorized to connect to the service.

### -field AuthenticationError:8
The operation failed due to unsuccessful account authentication. The user must re-validate the account to continue.

### -field DisabledByPolicy:10
The operation failed, as the app service needed service or capabilities disabled by some policies on the local or remote device.

### -field NetworkNotAvailable:9
The operation failed due to lack of an internet connection.


### -field WebServiceUnavailable:11
The operation failed because one or more necessary cloud services were temporarily unavailable.


## -remarks

### Version history

| Windows version | SDK version | Value added |
| -- | -- | -- |
| 1607 | 14393 | NotAuthorized |
| 1607 | 14393 | RemoteSystemNotSupportedByApp |
| 1607 | 14393 | RemoteSystemUnavailable |
| 2004 | 19041 | AuthenticationError |
| 2004 | 19041 | DisabledByPolicy |
| 2004 | 19041 | NetworkNotAvailable |
| 2004 | 19041 | WebServiceUnavailable |

## -examples

## -see-also
[AppServiceConnection.OpenAsync](appserviceconnection_openasync_171309613.md)
