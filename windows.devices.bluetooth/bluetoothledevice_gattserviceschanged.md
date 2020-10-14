---
-api-id: E:Windows.Devices.Bluetooth.BluetoothLEDevice.GattServicesChanged
-api-type: winrt event
-api-device-family-note: xbox
---

<!-- Event syntax
public event Windows.Foundation.TypedEventHandler GattServicesChanged<Windows.Devices.Bluetooth.BluetoothLEDevice,  object>
-->

# Windows.Devices.Bluetooth.BluetoothLEDevice.GattServicesChanged

## -description
Raised when the list of GATT services supported by the device has changed.

## -remarks

This event is raised when the remote device changes its services, or an unpaired device is disconnecting. All services are cleared because unpaired device services can't be cached between connections.

The object parameter in this event is null for every event that is raised.

In your handler for this event, do the following in order to get the services available. Call [BluetoothLEDevice.GetGattServicesAsync](/uwp/api/windows.devices.bluetooth.bluetoothledevice.getgattservicesasync) on the [BluetoothLEDevice](/uwp/api/windows.devices.bluetooth.bluetoothledevice) that's passed to your handler. When calling **GetGattServicesAsync**, use the [Cached](/uwp/api/windows.devices.bluetooth.bluetoothcachemode) option. This can be used to refresh the list of services and re-initialize the services on the device if they are gone.

## -examples

## -see-also

## -capabilities
bluetooth
