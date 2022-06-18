---
-api-id: T:Windows.Devices.Bluetooth.GenericAttributeProfile.GattServiceProvider
-api-type: winrt class
---

<!-- Class syntax.
public class GattServiceProvider 
-->

# Windows.Devices.Bluetooth.GenericAttributeProfile.GattServiceProvider

## -description
This class is used to advertise a GATT service.

## -remarks

After you've set up, and called [GattServiceProvider.StartAdvertising](/uwp/api/windows.devices.bluetooth.genericattributeprofile.gattserviceprovider.startadvertising), devices can initiate connections. But there is no explicit functionality associated with this API to disconnect such a device. That's because as a platform there might be other GATT services active and using the device. If the device is in the Central role, then the device will disconnect when there are no longer any active GATT services being used on the connection. If the device is in the Peripheral role, then the device itself is in control of when to disconnect.

## -see-also

## -examples

## -capabilities
bluetooth
