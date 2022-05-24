---
-api-id: M:Windows.Devices.Sensors.HumanPresenceSensor.GetDeviceSelector
-api-type: winrt method
---

# Windows.Devices.Sensors.HumanPresenceSensor.GetDeviceSelector

<!--
public static string GetDeviceSelector ();
-->

## -description

Retrieves an Advanced Query Syntax (AQS) string used to enumerate the available human presence sensors.

## -returns

An AQS string used to enumerate the available human presence sensors.

## -remarks

The app can pass the AQS string to [DeviceInformation.FindAllAsync](../windows.devices.enumeration/deviceinformation_findallasync_1257462890.md) to find all human presence sensors on the system.

## -see-also

[HumanPresenceSensor.FromIdAsync(System.String)](humanpresencesensor_fromidasync_1322863552.md)

## -examples
