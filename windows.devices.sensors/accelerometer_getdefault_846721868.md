---
-api-id: M:Windows.Devices.Sensors.Accelerometer.GetDefault
-api-type: winrt method
---

<!-- Method syntax
public Windows.Devices.Sensors.Accelerometer GetDefault()
-->

# Windows.Devices.Sensors.Accelerometer.GetDefault

## -description
Returns the default accelerometer.

## -returns
The default accelerometer or null if no integrated accelerometers are found.

## -remarks
This method only returns values for an accelerometer that has been integrated into the computer by the manufacturer. A null value will be returned if the specified sensor is not available in the system.

When a system is in Connected Standby, a call to the [GetDefault](accelerometer_getdefault_702418228.md) method will return immediately with a null result.

## -examples

The following example demonstrates how a UWP app built with XAML and C# used this method to establish a connection to the default accelerometer.

[!code-csharp[GetDefaultCS](../windows.devices.sensors/code/Accelerometer/cs/Scenario1.xaml.cs#SnippetGetDefaultCS)]

## -see-also
[GetDefault(AccelerometerReadingType)](accelerometer_getdefault_702418228.md)
