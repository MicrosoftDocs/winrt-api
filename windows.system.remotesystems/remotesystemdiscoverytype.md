---
-api-id: T:Windows.System.RemoteSystems.RemoteSystemDiscoveryType
-api-type: winrt enum
---

<!-- Enumeration syntax
public enum Windows.System.RemoteSystems.RemoteSystemDiscoveryType : int
-->

# RemoteSystemDiscoveryType

## -description
Contains the values that describe how a remote system is able to be discovered.

## -enum-fields
### -field Any:0
The remote system is discoverable both through a proximal connection and through cloud connection.

### -field Proximal:1
The remote system is only discoverable through a proximal connection, such as a local network or Bluetooth connection.

### -field Cloud:2
The remote system is only discoverable through cloud connection.

### -field SpatiallyProximal:3
The remote system is discoverable through a proximal connection and is expected to be spatially near to the client device.


## -remarks

## -examples

## -see-also
[Connected apps and devices (Project Rome)](https://msdn.microsoft.com/en-us/windows/uwp/launch-resume/connected-apps-and-devices)

## -capabilities
remoteSystem
