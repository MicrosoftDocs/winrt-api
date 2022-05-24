---
-api-id: P:Windows.Devices.Bluetooth.GenericAttributeProfile.GattServiceProviderAdvertisingParameters.ServiceData
-api-type: winrt property
ms.custom: 19H1
---

<!-- Property syntax.
public IBuffer ServiceData { get;  set; }
-->

# Windows.Devices.Bluetooth.GenericAttributeProfile.GattServiceProviderAdvertisingParameters.ServiceData

## -description
For [Bluetooth Low Energy](/windows/uwp/devices-sensors/bluetooth-low-energy-overview), this parameter adds an additional **ServiceData** section to the advertisement payload for the service's [service UUID](/uwp/api/windows.devices.bluetooth.genericattributeprofile.gattserviceuuids) if space is available. If the service data is added to the advertisement, then the service UUID will also be included in the same section in the advertisement.

## -property-value
The service data included in a Bluetooth Low Energy advertising payload.

## -remarks
The maximum size of the **ServiceData** section depends on the availability on the platform. But if the platform supports extended advertisement, and that's what's being requested, then the maximum theoretical size will be much larger. The actual value might be less than the theoretical value, depending on what's being shared on the system. The [GattServiceProviderAdvertisementStatus.StartedWithoutAllAdvertisementData](/uwp/api/windows.devices.bluetooth.genericattributeprofile.gattserviceprovideradvertisementstatus) status indicates that the system was successfully able to issue the advertisement request, but not all of the requested data could be included in the advertisement.

## -see-also

## -examples

