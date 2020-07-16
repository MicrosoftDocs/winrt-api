---
-api-id: T:Windows.ApplicationModel.AppService.AppServiceResponseStatus
-api-type: winrt enum
---

<!-- Enumeration syntax
public enum Windows.ApplicationModel.AppService.AppServiceResponseStatus : int
-->

# AppServiceResponseStatus

## -description
Describes the status when an app tries to send a message to an app service by calling the [AppServiceConnection.SendMessageAsync](appserviceconnection_sendmessageasync_1777128850.md) method. App service providers enable app-to-app communication by providing services that other Universal Windows app can consume.

## -enum-fields
### -field Success:0
The app service successfully received and processed the message.

### -field Failure:1
The app service failed to receive and process the message.

### -field ResourceLimitsExceeded:2
The app service exited because not enough resources were available.

### -field Unknown:3
An unknown error occurred.

### -field RemoteSystemUnavailable:4
The device to which the message was sent is not available.

### -field MessageSizeTooLarge:5
The app service failed to process the message because it is too large.

### -field AppUnavailable:6
The operation failed due to the app failing to start.

### -field AuthenticationError:7
The operation failed due to unsuccessful account authentication. The user must re-validate the account to continue.

### -field DisabledByPolicy:9
The operation failed, as the app service needed service or capabilities disabled by some policies on the local or remote device.

### -field NetworkNotAvailable:8
The operation failed due to lack of an internet connection.

### -field WebServiceUnavailable:10
The operation failed because one or more necessary cloud services were temporarily unavailable.

## -remarks

### Version history

| Windows version | SDK version | Value added |
| -- | -- | -- |
| 1607 | 14393 | MessageSizeTooLarge |
| 1607 | 14393 | RemoteSystemUnavailable |
| 2004 | 19041 | AppUnavailable |
| 2004 | 19041 | AuthenticationError |
| 2004 | 19041 | DisabledByPolicy |
| 2004 | 19041 | NetworkNotAvailable |
| 2004 | 19041 | WebServiceUnavailable |

## -examples

## -see-also
[AppServiceConnection.SendMessageAsync](appserviceconnection_sendmessageasync_1777128850.md), [AppServiceResponse.Status](appserviceresponse_status.md)
