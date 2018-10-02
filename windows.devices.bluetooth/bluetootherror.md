---
-api-id: T:Windows.Devices.Bluetooth.BluetoothError
-api-type: winrt enum
-api-device-family-note: xbox
---

<!-- Enumeration syntax
public enum Windows.Devices.Bluetooth.BluetoothError : int
-->

# BluetoothError

## -description
Specifies common Bluetooth error cases.

## -enum-fields
### -field Success:0
The operation was successfully completed or serviced.

### -field RadioNotAvailable:1
The Bluetooth radio was not available. This error occurs when the Bluetooth radio has been turned off.

### -field ResourceInUse:2
The operation cannot be serviced because the necessary resources are currently in use.

### -field DeviceNotConnected:3
The operation cannot be completed because the remote device is not connected.

### -field OtherError:4
An unexpected error has occurred.

### -field DisabledByPolicy:5
The operation is disabled by policy.

### -field NotSupported:6
The operation is not supported on the current Bluetooth radio hardware.

### -field DisabledByUser:7
The operation is disabled by the user.

### -field ConsentRequired:8
The operation requires consent.

### -field TransportNotSupported:9
The transport is not supported.

## -remarks

### Version history

| Version | SDK version | Value added |
| -- | -- | -- |
| 1511 | 10586 | DisabledByUser |
| 1607 | 14393 | ConsentRequired |
| 1703 | 15063 | TransportNotSupported |

## -examples

## -see-also


## -capabilities
bluetooth
