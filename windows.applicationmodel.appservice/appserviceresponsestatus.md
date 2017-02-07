---
-api-id: T:Windows.ApplicationModel.AppService.AppServiceResponseStatus
-api-type: winrt enum
---

<!-- Enumeration syntax
public enum Windows.ApplicationModel.AppService.AppServiceResponseStatus : int
-->

# AppServiceResponseStatus

## -description
Describes the status when an app tries to send a message to an app service by calling the [AppServiceConnection.SendMessageAsync](appserviceconnection_sendmessageasync.md) method. App service providers enable app-to-app communication by providing services that other Universal Windows app can consume.

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


## -remarks
> [!NOTE]
> **RemoteSystemUnavailable** and **MessageSizeTooLarge** were introduced in Windows 10, version 1607

## -examples

## -see-also
[AppServiceConnection.SendMessageAsync](appserviceconnection_sendmessageasync.md), [AppServiceResponse.Status](appserviceresponse_status.md)