---
-api-id: M:Windows.Devices.PointOfService.LineDisplay.FromIdAsync(System.String)
-api-type: winrt method
---

<!-- Method syntax.
public IAsyncOperation<LineDisplay> LineDisplay.FromIdAsync(String deviceId)
-->

# Windows.Devices.PointOfService.LineDisplay.FromIdAsync

## -description
Creates a [LineDisplay](linedisplay.md) object from the [DeviceInformation.Id](../windows.devices.enumeration/deviceinformation_id.md).

## -parameters

### -param deviceId
The [DeviceInformation.Id](../windows.devices.enumeration/deviceinformation_id.md) that identifies a specific line display, which can be retrieved from the [DeviceId](barcodescanner_deviceid.md) property.

## -returns
The line display specified by the unique device identifier. Returns a null object in the following cases:
+ The specific device is not found.
+ Access denied to the existing device. The user can deny access to a device, which is not treated as an exception.

## -remarks

## -see-also

## -examples
