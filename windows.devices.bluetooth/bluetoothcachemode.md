---
-api-id: T:Windows.Devices.Bluetooth.BluetoothCacheMode
-api-type: winrt enum
-api-device-family-note: xbox
---

<!-- Enumeration syntax
public enum Windows.Devices.Bluetooth.BluetoothCacheMode : int
-->

# BluetoothCacheMode

## -description
Indicates whether certain Bluetooth API methods should operate on values cached in the system or retrieve those values from the Bluetooth device.

## -enum-fields
### -field Cached:0
Use system-cached values.

### -field Uncached:1
Retrieve values from the Bluetooth device.


## -remarks

## -examples

## -see-also
[GattCharacteristic.ReadValueAsync](/uwp/api/windows.devices.bluetooth.genericattributeprofile.gattcharacteristic.readvalueasync), [RfcommDeviceService.GetSdpRawAttributesAsync](/uwp/api/windows.devices.bluetooth.rfcomm.rfcommdeviceservice.getsdprawattributesasync)

## -capabilities
bluetooth
