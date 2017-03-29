---
-api-id: M:Windows.Devices.Bluetooth.BluetoothDevice.GetDeviceSelectorFromPairingState(System.Boolean)
-api-type: winrt method
-api-device-family-note: xbox
---

<!-- Method syntax
public string GetDeviceSelectorFromPairingState(System.Boolean pairingState)
-->

# Windows.Devices.Bluetooth.BluetoothDevice.GetDeviceSelectorFromPairingState

## -description
Creates an Advanced Query Syntax (AQS) filter string that contains a query for Bluetooth devices that are either paired or unpaired. The AQS string is passed into the [CreateWatcher](../windows.devices.enumeration/deviceinformation_createwatcher_4958831.md) method to return a collection of [DeviceInformation](../windows.devices.enumeration/deviceinformation.md) objects.

## -parameters
### -param pairingState
The current pairing state for Bluetooth devices used for constructing the AQS string. Bluetooth devices can be either paired (true) or unpaired (false). The AQS Filter string will request scanning to be performed when the pairingState is false.

## -returns
An AQS string that can be passed as a parameter to the [CreateWatcher](../windows.devices.enumeration/deviceinformation_createwatcher_4958831.md) method.

## -remarks

## -examples

## -see-also
