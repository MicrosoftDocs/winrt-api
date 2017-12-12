---
-api-id: M:Windows.Devices.Bluetooth.BluetoothAdapter.FromIdAsync(System.String)
-api-type: winrt method
---

<!-- Method syntax.
public IAsyncOperation<BluetoothAdapter> BluetoothAdapter.FromIdAsync(String deviceId)
-->

# Windows.Devices.Bluetooth.BluetoothAdapter.FromIdAsync

## -description
Gets a [BluetoothAdapter](bluetoothadapter.md) object identified by the given [DeviceId](bluetoothadapter_deviceid.md).

## -parameters

### -param deviceId
The DeviceId value that identifies the BluetoothAdapter instance. This is a composite string combining registry information that includes the MatchingDeviceId, the MAC address, and a GUID representing a device class. This is different than Windows.Devices.Enumeration.DeviceInformation.Id. However, both contain the MAC address of the Bluetooth radio device embedded within the identifier string.

## -returns
After the asynchronous operation completes, returns the [BluetoothAdapter](bluetoothadapter.md) object identified by the given [DeviceId](bluetoothadapter_deviceid.md). 

## -remarks

## -examples

## -see-also

## -capabilities
bluetooth
