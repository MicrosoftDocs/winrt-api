---
-api-id: M:Windows.Devices.Sensors.SimpleOrientationSensor.GetDefault
-api-type: winrt method
---

<!-- Method syntax
public Windows.Devices.Sensors.SimpleOrientationSensor GetDefault()
-->

# Windows.Devices.Sensors.SimpleOrientationSensor.GetDefault

## -description
Gets the default simple orientation sensor.

## -returns
The default simple orientation sensor or null if no simple orientation sensors are found.

## -remarks
This method only returns values for hardware that has been integrated into the computer by the manufacturer. (The simple orientation-sensor readings are derived from an accelerometer.) A null value will be returned if the specified sensor is not available in the system.

When a system is in Connected Standby, a call to the [GetDefault](/uwp/api/windows.devices.sensors.orientationsensor.getdefault) method will return immediately with a null result.

## -examples

The following example demonstrates how a UWP app built with XAML and C# used this method to establish a connection to the simple orientation sensor.

[!code-csharp[GetDefaultCS](../windows.devices.sensors/code/simpleorientation/csharp/Scenario1.xaml.cs#SnippetGetDefaultCS)]

## -see-also
