---
-api-id: M:Windows.Devices.Bluetooth.BluetoothLEDevice.GetDeviceSelectorFromConnectionStatus(Windows.Devices.Bluetooth.BluetoothConnectionStatus)
-api-type: winrt method
-api-device-family-note: xbox
---

<!-- Method syntax
public string GetDeviceSelectorFromConnectionStatus(Windows.Devices.Bluetooth.BluetoothConnectionStatus connectionStatus)
-->

# Windows.Devices.Bluetooth.BluetoothLEDevice.GetDeviceSelectorFromConnectionStatus

## -description
Creates an Advanced Query Syntax (AQS) filter string that contains a query for Bluetooth LE devices with the indicated [BluetoothConnectionStatus](bluetoothconnectionstatus.md). The AQS string is passed into the [CreateWatcher](../windows.devices.enumeration/deviceinformation_createwatcher_4958831.md) method to return a collection of [DeviceInformation](../windows.devices.enumeration/deviceinformation.md) objects with the indicated Bluetooth connection status.

## -parameters
### -param connectionStatus
The connection status used for constructing the AQS string.

## -returns
An AQS string that can be passed as a parameter to the [CreateWatcher](../windows.devices.enumeration/deviceinformation_createwatcher_4958831.md) method.

## -remarks

## -examples

## -see-also

## -capabilities
bluetooth
