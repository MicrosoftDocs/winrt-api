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
The behavior of **Cached** depends on the API.

For the following APIs, **Cached** means *only* use values cached in the system cached (if not cached then *don't* fall back to querying the device).

* [**BluetoothDevice.GetRfcommServicesAsync**](/uwp/api/windows.devices.bluetooth.bluetoothdevice.getrfcommservicesasync)
* [**BluetoothDevice.GetRfcommServicesForIdAsync**](/uwp/api/windows.devices.bluetooth.bluetoothdevice.getrfcommservicesforidasync)
* [**GattDeviceService.GetDeviceSelectorForBluetoothDeviceId**](/uwp/api/windows.devices.bluetooth.genericattributeprofile.gattdeviceservice.getdeviceselectorforbluetoothdeviceid)
* [**GattDeviceService.GetDeviceSelectorForBluetoothDeviceIdAndUuid**](/uwp/api/windows.devices.bluetooth.genericattributeprofile.gattdeviceservice.getdeviceselectorforbluetoothdeviceidanduuid)
* [**RfcommDeviceService.GetDeviceSelectorForBluetoothDevice**](/uwp/api/windows.devices.bluetooth.rfcomm.rfcommdeviceservice.getdeviceselectorforbluetoothdevice)
* [**RfcommDeviceService.GetDeviceSelectorForBluetoothDeviceAndServiceId**](/uwp/api/windows.devices.bluetooth.rfcomm.rfcommdeviceservice.getdeviceselectorforbluetoothdeviceandserviceid)
* [**RfcommDeviceService.GetSdpRawAttributesAsync**](/uwp/api/windows.devices.bluetooth.rfcomm.rfcommdeviceservice.getsdprawattributesasync)
 
For the following APIs, **Cached** means try looking in the cache first and, if not there, then retrieve from the device.

* [**BluetoothLEDevice.GetGattServicesAsync**](/uwp/api/windows.devices.bluetooth.bluetoothledevice.getgattservicesasync)
* [**BluetoothLEDevice.GetGattServicesForUuidAsync**](/uwp/api/windows.devices.bluetooth.bluetoothledevice.getgattservicesforuuidasync)
* [**GattCharacteristic.GetDescriptorsAsync**](/uwp/api/windows.devices.bluetooth.genericattributeprofile.gattcharacteristic.getdescriptorsasync)
* [**GattCharacteristic.GetDescriptorsForUuidAsync**](/uwp/api/windows.devices.bluetooth.genericattributeprofile.gattcharacteristic.getdescriptorsforuuidasync)
* [**GattCharacteristic.ReadValueAsync**](/uwp/api/windows.devices.bluetooth.genericattributeprofile.gattcharacteristic.readvalueasync)
* [**GattDescriptor.ReadValueAsync**](/uwp/api/windows.devices.bluetooth.genericattributeprofile.gattdescriptor.readvalueasync)
* [**GattDeviceService.GetCharacteristicsAsync**](/uwp/api/windows.devices.bluetooth.genericattributeprofile.gattdeviceservice.getcharacteristicsasync)
* [**GattDeviceService.GetCharacteristicsForUuidAsync**](/uwp/api/windows.devices.bluetooth.genericattributeprofile.gattdeviceservice.getcharacteristicsforuuidasync)
* [**GattDeviceService.GetIncludedServicesAsync**](/uwp/api/windows.devices.bluetooth.genericattributeprofile.gattdeviceservice.getincludedservicesasync)
* [**GattDeviceService.GetIncludedServicesForUuidAsync**](/uwp/api/windows.devices.bluetooth.genericattributeprofile.gattdeviceservice.getincludedservicesforuuidasync)

### -field Uncached:1
The behavior of **Uncached** is to retrieve values from the Bluetooth device.

## -remarks
The cache in question is a local, system-wide cache (maintained by the operating system, or OS) of GATT attributes for a particular remote device. System-wide; not per-process. Entries in the cache become invalidated whenever the remote device indicates a service change, or when the device becomes unpaired.

## -examples

## -see-also
[GattCharacteristic.ReadValueAsync](/uwp/api/windows.devices.bluetooth.genericattributeprofile.gattcharacteristic.readvalueasync), [RfcommDeviceService.GetSdpRawAttributesAsync](/uwp/api/windows.devices.bluetooth.rfcomm.rfcommdeviceservice.getsdprawattributesasync)

## -capabilities
bluetooth
