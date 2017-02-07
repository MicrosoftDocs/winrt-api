---
-api-id: T:Windows.System.RemoteLaunchUriStatus
-api-type: winrt enum
---

<!-- Enumeration syntax
public enum Windows.System.RemoteLaunchUriStatus : int
-->

# RemoteLaunchUriStatus

## -description
Specifies the result of activating an application for a URI on a remote device.

## -enum-fields
### -field Unknown:0
The URI could not be successfully launched on the remote system.

### -field Success:1
The URI was successfully launched on the remote system.

### -field AppUnavailable:2
The app is not installed on the remote system.

### -field ProtocolUnavailable:3
The application you are trying to activate on the remote system does not support this URI.

### -field RemoteSystemUnavailable:4
The remote system could not be reached.

### -field ValueSetTooLarge:5
The amount of data you tried to send to the remote system exceeded the limit.

### -field DeniedByLocalSystem:6
The user is not authorized to launch an app on the remote system.

### -field DeniedByRemoteSystem:7
The user is not signed in on the target device or may be blocked by group policy.


## -remarks

## -examples

## -see-also