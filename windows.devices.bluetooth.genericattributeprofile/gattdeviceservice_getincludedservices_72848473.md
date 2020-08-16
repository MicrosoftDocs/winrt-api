---
-api-id: M:Windows.Devices.Bluetooth.GenericAttributeProfile.GattDeviceService.GetIncludedServices(System.Guid)
-api-type: winrt method
-api-device-family-note: xbox
---

<!-- Method syntax
public Windows.Foundation.Collections.IVectorView<Windows.Devices.Bluetooth.GenericAttributeProfile.GattDeviceService> GetIncludedServices(System.Guid serviceUuid)
-->

# Windows.Devices.Bluetooth.GenericAttributeProfile.GattDeviceService.GetIncludedServices

## -description
Returns a vector of included services, that are identified by the specified UUID and belong to this GattDeviceService instance.

> [!IMPORTANT]
> The **GetIncludedServices** API is deprecated, and it may not be available in future versions of Windows. Instead, use [GetIncludedServicesForUuidAsync](/uwp/api/windows.devices.bluetooth.genericattributeprofile.gattdeviceservice.getincludedservicesforuuidasync).

## -parameters
### -param serviceUuid
The UUID for the included services to be retrieved.

## -returns
A vector of included services whose UUIDs match serviceUuid.

## -remarks

## -examples

## -see-also

## -capabilities
bluetooth
