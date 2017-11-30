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
Occurs when the list of GATT services supported by the device has changed.

## -remarks
This event fires when the remote device changes its services, or an unpaired device is disconnecting. All services are cleared because unpaired device services can’t be cached between connections.

The object parameter in this event is null for every event that is fired.

To get the services available, your app should call GetGattServicesAsync with the Cached option from the BluetoothLEDevice that is provided in the event handler. This can be used to refresh the list of services and re-initialize the services on the device if they are gone.

## -examples

## -see-also


## -capabilities
bluetooth
