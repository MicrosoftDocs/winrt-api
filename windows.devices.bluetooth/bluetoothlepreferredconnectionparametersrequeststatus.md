---
-api-id: T:Windows.Devices.Bluetooth.BluetoothLEPreferredConnectionParametersRequestStatus
-api-type: winrt enum
---

# Windows.Devices.Bluetooth.BluetoothLEPreferredConnectionParametersRequestStatus

<!--
public enum BluetoothLEPreferredConnectionParametersRequestStatus
-->

## -description

Defines constants that specify the status of a Bluetooth LE preferred connection parameters request.

For more information on connection parameters and PHY, please reference the [Bluetooth Core Specification](https://www.bluetooth.com/specifications/specs/core-specification-5-3/).

## -enum-fields

### -field Unspecified: 0

Specifies that the status is unspecified.

### -field Success: 1

Specifies that the request was accepted by the system. When the parameters are negotiated, the [BluetoothLEDevice.ConnectionParametersChanged](bluetoothledevice_connectionparameterschanged.md) event is raised.

### -field DeviceNotAvailable: 2

Specifies that a Bluetooth radio was not available on the system, or that the device was not previously discovered.

### -field AccessDenied: 3

Specifies that access to the device was blocked by the user or by system policy.

## -remarks

## -see-also

## -examples

## -capabilities
bluetooth
