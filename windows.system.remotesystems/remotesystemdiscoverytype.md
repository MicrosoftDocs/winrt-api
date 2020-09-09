---
-api-id: T:Windows.System.RemoteSystems.RemoteSystemDiscoveryType
-api-type: winrt enum
---

<!-- Enumeration syntax
public enum Windows.System.RemoteSystems.RemoteSystemDiscoveryType : int
-->

# RemoteSystemDiscoveryType

## -description
Contains the values that describe how remote systems are able to be discovered.

## -enum-fields
### -field Any:0
Remote systems are discoverable both through a proximal connection and through cloud connection.

### -field Proximal:1
Remote systems are only discoverable through a proximal connection, such as a local network or Bluetooth connection.

### -field Cloud:2
Remote systems are only discoverable through cloud connection.

### -field SpatiallyProximal:3
Remote systems are discoverable through a proximal connection and are expected to be spatially near to the client device.


## -remarks

### Version history

| Windows version | SDK version | Value added |
| -- | -- | -- |
| 1703 | 15063 | SpatiallyProximal |

## -examples

## -see-also
[Connected apps and devices (Project Rome)](/windows/uwp/launch-resume/connected-apps-and-devices)

## -capabilities
remoteSystem
