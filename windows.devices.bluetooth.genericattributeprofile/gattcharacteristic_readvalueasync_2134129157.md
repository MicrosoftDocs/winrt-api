---
-api-id: M:Windows.Devices.Bluetooth.GenericAttributeProfile.GattCharacteristic.ReadValueAsync(Windows.Devices.Bluetooth.BluetoothCacheMode)
-api-type: winrt method
-api-device-family-note: xbox
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperation<Windows.Devices.Bluetooth.GenericAttributeProfile.GattReadResult> ReadValueAsync(Windows.Devices.Bluetooth.BluetoothCacheMode cacheMode)
-->

# Windows.Devices.Bluetooth.GenericAttributeProfile.GattCharacteristic.ReadValueAsync

## -description
Performs a Characteristic Value read either from the value cache maintained by Windows, or directly from the device.

## -parameters
### -param cacheMode
Specifies whether to read the value directly from the device or from a value cache maintained by Windows.

## -returns
The object required to manage the asynchronous operation, which, upon completion, returns a GattReadResult object, which in turn contains the completion status of the asynchronous operation and, if successful, the data read from the device.

## -remarks

## -examples

## -see-also
[ReadValueAsync](gattcharacteristic_readvalueasync_873593826.md)
## -capabilities
bluetooth
