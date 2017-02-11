---
-api-id: M:Windows.Devices.Sensors.OrientationSensor.GetDefault
-api-type: winrt method
---

<!-- Method syntax
public Windows.Devices.Sensors.OrientationSensor GetDefault()
-->

# Windows.Devices.Sensors.OrientationSensor.GetDefault

## -description
Gets the default orientation sensor.

## -returns
The default orientation sensor or **null** if no orientation sensors are found.

## -remarks
This method only returns values for hardware that has been integrated into the computer by the manufacturer. (The orientation-sensor readings are derived from multiple sensors.) A null value will be returned if the specified sensor is not available in the system.

When a system is in Connected Standby, a call to the [GetDefault](orientationsensor_getdefault.md) method will return immediately with a null result.

The following example demonstrates how a Windows Store app built with XAML and C# used this method to establish a connection to the orientation sensor.



[!code-csharp[GetDefaultCS](../windows.devices.sensors/code/orientation/csharp/Scenario1.xaml.cs#SnippetGetDefaultCS)]

The following example demonstrates how a Windows Store app built for Windows using JavaScript used this method to establish a connection to the orientation sensor.



[!code-js[GetDefaultJS](../windows.devices.sensors/code/orientation/javascript/scenario1.js#SnippetGetDefaultJS)]

## -examples

## -see-also
[GetDefault(SensorReadingType)](orientationsensor_getdefault_2064571144.md), [GetDefault(SensorReadingType, SensorOptimizationGoal)](orientationsensor_getdefault_274432112.md)
