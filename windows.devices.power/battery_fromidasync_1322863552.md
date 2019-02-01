---
-api-id: M:Windows.Devices.Power.Battery.FromIdAsync(System.String)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperation<Windows.Devices.Power.Battery> FromIdAsync(System.String deviceId)
-->

# Windows.Devices.Power.Battery.FromIdAsync

## -description
Gets a [Battery](battery.md) object that represents an individual battery controller connected to the device.

## -parameters
### -param deviceId
The device ID of the battery controller ([DeviceId](battery_deviceid.md)).

## -returns
A [Battery](battery.md) object that corresponds to the specified battery controller.

## -remarks
[FromIdAsync](battery_fromidasync_1322863552.md) will return null if the battery controller does not exist and the *deviceId* value is well-formed. If the *deviceId* value is not well-formed, such as "`AggregateBattery`," then the method will fail with `STATUS_OBJECT_NAME_INVALID`.

You can use a [DeviceInformation](../windows.devices.enumeration/deviceinformation.md) object for a battery controller to use that object's [Id](../windows.devices.enumeration/deviceinformation_id.md) property value as the *deviceId* parameter in [FromIdAsync](battery_fromidasync_1322863552.md) to create a [Battery](battery.md) object

## -examples

## -see-also
[Get battery information](https://msdn.microsoft.com/library/a9fb0f39-8827-420a-922d-dcee6fb9c9d2)
