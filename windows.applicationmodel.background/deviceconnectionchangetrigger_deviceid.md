---
-api-id: P:Windows.ApplicationModel.Background.DeviceConnectionChangeTrigger.DeviceId
-api-type: winrt property
---

<!-- Property syntax
public string DeviceId { get; }
-->

# Windows.ApplicationModel.Background.DeviceConnectionChangeTrigger.DeviceId

## -description
Gets the device Id associated with the device.

## -property-value
The device Id associated with the device.

## -remarks
When monitoring Bluetooth LE devices, the DeviceId must reference an interface on the Bluetooth LE device object. The device Id in this case can be the values returned by the [GetDeviceSelector](../windows.devices.bluetooth/bluetoothledevice_getdeviceselector.md). Alternatively, the DeviceId can reference an interface on a [GattDeviceService](../windows.devices.bluetooth.genericattributeprofile/gattdeviceservice.md) object and valid values for the device Id is any value returned by [GetDeviceSelectorFromShortId](../windows.devices.bluetooth.genericattributeprofile/gattdeviceservice_getdeviceselectorfromshortid.md) or [GetDeviceSelectorFromUuid](../windows.devices.bluetooth.genericattributeprofile/gattdeviceservice_getdeviceselectorfromuuid.md).

When monitoring other Bluetooth devices, the device Id can be any value returned by the GetDeviceSelector on RfCommDeviceService or BluetoothDevice.

## -examples

## -see-also
