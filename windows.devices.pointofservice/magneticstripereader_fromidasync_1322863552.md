---
-api-id: M:Windows.Devices.PointOfService.MagneticStripeReader.FromIdAsync(System.String)
-api-type: winrt method
-api-device-family-note: xbox
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperation<Windows.Devices.PointOfService.MagneticStripeReader> FromIdAsync(System.String deviceId)
-->

# Windows.Devices.PointOfService.MagneticStripeReader.FromIdAsync

## -description
Creates a [MagneticStripeReader](magneticstripereader.md) object from [DeviceInformation.Id](../windows.devices.enumeration/deviceinformation_id.md).

## -parameters
### -param deviceId
The [DeviceInformation.Id](../windows.devices.enumeration/deviceinformation_id.md) that identifies a specific magnetic stripe reader, which can be retrieved from the [DeviceId](magneticstripereader_deviceid.md) property.

## -returns
The magnetic stripe reader specified by the unique device identifier. Returns a null object in the following cases:
+ The specific device is not found.
+ Access denied to the existing device. The user can deny access to a device, which is not treated as an exception.


## -remarks

## -examples

## -see-also
[DeviceInformation.Id](../windows.devices.enumeration/deviceinformation_id.md)