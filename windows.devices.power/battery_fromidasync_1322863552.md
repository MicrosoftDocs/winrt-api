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
FromIdAsync will return null if the battery controller does not exist and the *deviceId* value is well-formed. If the *deviceId* value is not well-formed, such as "`AggregateBattery`," then the method will fail with `STATUS_OBJECT_NAME_INVALID`.

You can use a [DeviceInformation](../windows.devices.enumeration/deviceinformation.md) object for a battery controller to use that object's [Id](../windows.devices.enumeration/deviceinformation_id.md) property value as the *deviceId* parameter in FromIdAsync to create a [Battery](battery.md) object

## -examples

## -see-also
[Get battery information](/previous-versions/windows/apps/dn895210(v=win.10))
