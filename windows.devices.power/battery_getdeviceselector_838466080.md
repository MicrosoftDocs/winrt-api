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
Use the AQS string returned by GetDeviceSelector with the [DeviceInformation](../windows.devices.enumeration/deviceinformation.md) APIs to find all battery controllers that are connected to the device. See [FromIdAsync](battery_fromidasync_1322863552.md) for information on how to create a [Battery](battery.md) object.

## -examples

## -see-also
[Get battery information](/previous-versions/windows/apps/dn895210(v=win.10))
