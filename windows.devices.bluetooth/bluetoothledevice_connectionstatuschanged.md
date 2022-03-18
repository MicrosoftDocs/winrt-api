---
-api-id: E:Windows.Devices.Bluetooth.BluetoothLEDevice.ConnectionStatusChanged
-api-type: winrt event
-api-device-family-note: xbox
---

<!-- Event syntax
public event Windows.Foundation.TypedEventHandler ConnectionStatusChanged<Windows.Devices.Bluetooth.BluetoothLEDevice,  object>
-->

# Windows.Devices.Bluetooth.BluetoothLEDevice.ConnectionStatusChanged

## -description
Occurs when the connection status for the device has changed.

## -remarks

In your handler for this event, to get the connection status query the [BluetoothLEDevice.ConnectionStatus](/uwp/api/windows.devices.bluetooth.bluetoothledevice.connectionstatus) property on the [BluetoothLEDevice](/uwp/api/windows.devices.bluetooth.bluetoothledevice) that's passed to your handler.

## -examples

## -see-also

## -capabilities
bluetooth
