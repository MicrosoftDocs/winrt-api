---
-api-id: T:Windows.System.RemoteSystems.RemoteSystemAccessStatus
-api-type: winrt enum
---

<!-- Enumeration syntax
public enum Windows.System.RemoteSystems.RemoteSystemAccessStatus : int
-->

# RemoteSystemAccessStatus

## -description
Contains the values that describe an app's access to use the **Remote Systems** feature.

## -enum-fields
### -field Unspecified:0
Access is denied for an unknown reason.

### -field Allowed:1
Access is allowed

### -field DeniedByUser:2
Access has been denied to this particular app by this particular user.

### -field DeniedBySystem:3
Access is denied to this app by the System; the app hasn't requested the proper capability.


## -remarks

## -examples

## -see-also
[Connected apps and devices (Project Rome)](/windows/uwp/launch-resume/connected-apps-and-devices)

## -capabilities
remoteSystem
