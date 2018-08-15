---
-api-id: M:Windows.Devices.Power.Battery.GetDeviceSelector
-api-type: winrt method
---

<!-- Method syntax
public string GetDeviceSelector()
-->

# Windows.Devices.Power.Battery.GetDeviceSelector

## -description
Gets an Advanced Query Syntax (AQS) string that can be used to find all battery controllers that are connected to the device.

## -returns
An AQS string that can be used to find all battery controllers connected to the device.

## -remarks
Use the AQS string returned by [GetDeviceSelector](battery_getdeviceselector_838466080.md) with the [DeviceInformation](../windows.devices.enumeration/deviceinformation.md) APIs to find all battery controllers that are connected to the device. See [FromIdAsync](battery_fromidasync_1322863552.md) for information on how to create a [Battery](battery.md) object.

## -examples

## -see-also
[Get battery information](http://msdn.microsoft.com/library/a9fb0f39-8827-420a-922d-dcee6fb9c9d2)