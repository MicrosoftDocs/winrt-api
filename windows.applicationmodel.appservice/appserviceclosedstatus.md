---
-api-id: T:Windows.ApplicationModel.AppService.AppServiceClosedStatus
-api-type: winrt enum
---

<!-- Enumeration syntax
public enum Windows.ApplicationModel.AppService.AppServiceClosedStatus : int
-->

# AppServiceClosedStatus

## -description
Describes the status that was set when the endpoint for the app service was closed. App service providers enable app-to-app communication by providing services that other Universal Windows app can consume.

## -enum-fields
### -field Completed:0
The endpoint for the app service closed gracefully.

### -field Canceled:1
The endpoint for the app service was closed by the client or the system

### -field ResourceLimitsExceeded:2
The endpoint for the app service was closed because the endpoint ran out of resources.

### -field Unknown:3
An unknown error occurred.


## -remarks

## -examples

## -see-also
[AppServiceClosedEventArgs.Status](appserviceclosedeventargs_status.md)