---
-api-id: T:Windows.Networking.XboxLive.XboxLiveEndpointPairCreationStatus
-api-type: winrt enum
---

<!-- Enumeration syntax
public enum Windows.Networking.XboxLive.XboxLiveEndpointPairCreationStatus : int
-->

# XboxLiveEndpointPairCreationStatus

## -description

Defines constants that specify the status of an **XboxLiveEndpointPair** creation operation. 

> [!IMPORTANT]
> This API is not available to all apps. Unless your developer account is specially provisioned by Microsoft, calls to these APIs will fail at runtime.

## -enum-fields

### -field Succeeded:0

Creating succeeded.

### -field NoLocalNetworks:1

Creation failed because the local device is not connected to a network.

### -field NoCompatibleNetworkPaths:2

Creation failed because there are no compatible network paths.

### -field LocalSystemNotAuthorized:3

Creation failed because the local system's authorization was deemed unacceptable by the remote system.

### -field Canceled:4

Creation failed because the user chose to cancel it.

### -field TimedOut:5

Creation failed because it did not complete within the timeout period.

### -field RemoteSystemNotAuthorized:6

Creation failed because the remote system's authorization was deemed unacceptable by the local system or by your app.

### -field RefusedDueToConfiguration:7

Creation failed because the remote system has a different, incompatible configuration (mismatched template definitions), and has actively refused the connection.

### -field UnexpectedInternalError:8

Creation failed due to an internal error.

## -remarks

## -examples

## -see-also
