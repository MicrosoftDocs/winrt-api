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
Indicates whether applicable Bluetooth API methods should operate on values cached in the system, or whether they should retrieve those values from the Bluetooth device. See **Remarks** in the member topic.

## -enum-fields

### -field Cached:0
Use values cached in the system.

### -field Uncached:1
Retrieve values from the Bluetooth device.

## -remarks
The cache in question is a local, system-wide cache (maintained by the operating system, or OS) of GATT attributes for a particular remote device. System-wide; not per-process. Entries in the cache become invalidated whenever the remote device indicates a service change, or when the device becomes unpaired.

## -examples

## -see-also
[GattCharacteristic.ReadValueAsync](/uwp/api/windows.devices.bluetooth.genericattributeprofile.gattcharacteristic.readvalueasync), [RfcommDeviceService.GetSdpRawAttributesAsync](/uwp/api/windows.devices.bluetooth.rfcomm.rfcommdeviceservice.getsdprawattributesasync)

## -capabilities
bluetooth