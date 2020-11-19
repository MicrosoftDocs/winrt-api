---
-api-id: M:Windows.Devices.Sensors.LightSensor.GetDefault
-api-type: winrt method
---

<!-- Method syntax
public Windows.Devices.Sensors.LightSensor GetDefault()
-->

# Windows.Devices.Sensors.LightSensor.GetDefault

## -description
Returns the default ambient-light sensor.

## -returns
The default ambient-light sensor or null if no integrated light sensors are found.

## -remarks
This method only returns values for a light sensor that has been integrated into the computer by the manufacturer. A null value will be returned if the specified sensor is not available in the system.

When a system is in Connected Standby, a call to the GetDefault method will return immediately with a null result.

## -examples

The following example demonstrates how a UWP app built with XAML and C# used this method to establish a connection to the default light sensor.

[!code-csharp[GetDefaultCS](../windows.devices.sensors/code/lightsensor/csharp/Scenario1.xaml.cs#SnippetGetDefaultCS)]

## -see-also
