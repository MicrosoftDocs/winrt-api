---
-api-id: M:Windows.Devices.Bluetooth.BluetoothLEDevice.GetConnectionParameters
-api-type: winrt method
---

# Windows.Devices.Bluetooth.BluetoothLEDevice.GetConnectionParameters

<!--
public Windows.Devices.Bluetooth.BluetoothLEConnectionParameters GetConnectionParameters ();
-->

## -description

Retrieves connection parameters for the remote device. If multiple apps or other system scenarios also request these parameters, then the system automatically combines the parameters, where compatible, based on system priority.

> [!NOTE]
> When the device is not connected, the connection parameters are invalid (all zero).

## -returns

A [BluetoothLEConnectionParameters](bluetoothleconnectionparameters.md) object representing connection parameters for the remote device.

## -remarks

## -see-also

## -examples

## -capabilities
bluetooth
