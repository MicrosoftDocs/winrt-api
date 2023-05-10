---
-api-id: T:Windows.Networking.XboxLive.XboxLiveQualityOfServiceMeasurementStatus
-api-type: winrt enum
---

<!-- Enumeration syntax
public enum Windows.Networking.XboxLive.XboxLiveQualityOfServiceMeasurementStatus : int
-->

# XboxLiveQualityOfServiceMeasurementStatus

## -description

Defines constants that specify the status of a Quality of Service (QoS) measurement.

> [!IMPORTANT]
> This API is not available to all apps. Unless your developer account is specially provisioned by Microsoft, calls to these APIs will fail at runtime.

## -enum-fields

### -field NotStarted:0

The measurement has not been started.

### -field InProgress:1

The measurement is in progress.

### -field InProgressWithProvisionalResults:2

The measurement is in progress, and provisional results are available.

### -field Succeeded:3

The measurement has completed successfully.

### -field NoLocalNetworks:4

The measurement failed because the local device has no network connections.

### -field NoCompatibleNetworkPaths:5

The measurement failed because there are no compatible network paths to the target device.

### -field LocalSystemNotAuthorized:6

Creation failed because the local system's authorization was deemed unacceptable by the remote system.

### -field Canceled:7

The measurement was canceled.

### -field TimedOut:8

The measurement timed out.

### -field RemoteSystemNotAuthorized:9

Creation failed because the remote system's authorization was deemed unacceptable by the local system or by your app.

### -field RefusedDueToConfiguration:10

Creation failed because the remote system has a different, incompatible configuration, and has actively refused the connection.

### -field UnexpectedInternalError:11

The measurement failed due to an internal system error.

## -remarks

## -examples

## -see-also
