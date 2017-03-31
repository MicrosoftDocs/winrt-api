---
-api-id: M:Windows.Devices.PointOfService.PosPrinter.FromIdAsync(System.String)
-api-type: winrt method
-api-device-family-note: xbox
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperation<Windows.Devices.PointOfService.PosPrinter> FromIdAsync(System.String deviceId)
-->

# Windows.Devices.PointOfService.PosPrinter.FromIdAsync

## -description
Creates a [PosPrinter](posprinter.md) object for point-of-service printer with the specified [DeviceInformation.Id](../windows.devices.enumeration/deviceinformation_id.md).

## -parameters
### -param deviceId
The [DeviceInformation.Id](../windows.devices.enumeration/deviceinformation_id.md) that identifies a specific point-of-service printer.

## -returns
The point-of-service printer that the unique device identifier identifies. Returns a null object in the following cases:
+ The specific printer is not found.
+ Access is denied to the existing printer. The user can deny access to a device, which is not treated as an exception.


## -remarks
The app package manifest must include the PointofService device capability. If the manifest omits this capability, this method returns null and no exception is generated.

## -examples

## -see-also
[DeviceInformation.Id](../windows.devices.enumeration/deviceinformation_id.md), [IAsyncOperation](../windows.foundation/iasyncoperation_1.md)