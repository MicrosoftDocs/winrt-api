---
-api-id: M:Windows.Devices.Bluetooth.GenericAttributeProfile.GattDeviceService.Close
-api-type: winrt method
-api-device-family-note: xbox
---

<!-- Method syntax
public void Close()
-->

# Windows.Devices.Bluetooth.GenericAttributeProfile.GattDeviceService.Close

## -description

Releases the resources associated with the **GattDeviceService** class. This allows other apps to access the resources of the **GattDeviceService** in question. Don't use a **GattDeviceService** object after you've invoked **Close** on it; instead, instantiate a new **GattDeviceService** object by using the [FromIdAsync](./gattdeviceservice_fromidasync_116749634.md) method.

For C++, call **Close**. For .NET languages, this **Close** method is projected into [Dispose](/uwp/api/windows.devices.bluetooth.genericattributeprofile.gattdeviceservice.dispose).

## -remarks

## -examples

## -see-also

## -capabilities
bluetooth
