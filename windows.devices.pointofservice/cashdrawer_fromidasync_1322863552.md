---
-api-id: M:Windows.Devices.PointOfService.CashDrawer.FromIdAsync(System.String)
-api-type: winrt method
-api-device-family-note: xbox
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperation<Windows.Devices.PointOfService.CashDrawer> FromIdAsync(System.String deviceId)
-->

# Windows.Devices.PointOfService.CashDrawer.FromIdAsync

## -description
Creates [CashDrawer](cashdrawer.md) object from the [DeviceInformation.Id](../windows.devices.enumeration/deviceinformation_id.md).

## -parameters
### -param deviceId
The [DeviceInformation.Id](../windows.devices.enumeration/deviceinformation_id.md) that identifies a specific cash drawer, which can be retrieved from the [DeviceId](barcodescanner_deviceid.md) property.

## -returns
The cash drawer specified by the unique device identifier. Returns a null object in the following cases:
+ The specific device is not found.
+ Access denied to the existing device. The user can deny access to a device, which is not treated as an exception.


## -remarks

## -examples

## -see-also
