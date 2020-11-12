---
-api-id: M:Windows.Devices.Sensors.Inclinometer.GetDefault
-api-type: winrt method
---

<!-- Method syntax
public Windows.Devices.Sensors.Inclinometer GetDefault()
-->

# Windows.Devices.Sensors.Inclinometer.GetDefault

## -description
Returns the default inclinometer for [absolute readings](/uwp/api/windows.devices.sensors.sensorreadingtype).

## -returns
The default inclinometer or null if no inclinometers are found.

## -remarks
This method returns the same result as GetDefault(SensorReadingType.Absolute)

This method only returns values for hardware that has been integrated into the computer by the manufacturer. (The inclinometer readings are derived from multiple sensors.) A null value will be returned if the specified sensor is not available in the system.

When a system is in Connected Standby, a call to the [GetDefault](inclinometer_getdefault_2064571144.md) method will return immediately with a null result.

## -examples

The following example demonstrates how a UWP app built with XAML and C# used this method to establish a connection to the default inclinometer.

[!code-csharp[GetDefaultCS](../windows.devices.sensors/code/inclinometer/csharp/Scenario1.xaml.cs#SnippetGetDefaultCS)]

## -see-also
[GetDefault(SensorReadingType)](inclinometer_getdefault_2064571144.md)
