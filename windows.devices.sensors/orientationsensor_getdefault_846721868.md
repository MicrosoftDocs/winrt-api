---
-api-id: M:Windows.Devices.Sensors.OrientationSensor.GetDefault
-api-type: winrt method
---

<!-- Method syntax
public Windows.Devices.Sensors.OrientationSensor GetDefault()
-->

# Windows.Devices.Sensors.OrientationSensor.GetDefault

## -description
Returns the default orientation sensor for [absolute readings](/uwp/api/windows.devices.sensors.sensorreadingtype).

## -returns
The default orientation sensor or **null** if no orientation sensors are found.

## -remarks
This method returns the same result as GetDefault(SensorReadingType.Absolute)

This method only returns values for hardware that has been integrated into the computer by the manufacturer. (The orientation-sensor readings are derived from multiple sensors.) A null value will be returned if the specified sensor is not available in the system.

When a system is in Connected Standby, a call to the [GetDefault](orientationsensor_getdefault_2064571144.md) method will return immediately with a null result.

## -examples

The following example demonstrates how a UWP app built with XAML and C# used this method to establish a connection to the orientation sensor.

[!code-csharp[GetDefaultCS](../windows.devices.sensors/code/orientation/csharp/Scenario1.xaml.cs#SnippetGetDefaultCS)]

## -see-also
[GetDefault(SensorReadingType)](orientationsensor_getdefault_2064571144.md), [GetDefault(SensorReadingType, SensorOptimizationGoal)](orientationsensor_getdefault_274432112.md)
