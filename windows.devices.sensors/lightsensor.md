---
-api-id: T:Windows.Devices.Sensors.LightSensor
-api-type: winrt class
---

<!-- Class syntax.
public class LightSensor : Windows.Devices.Sensors.ILightSensor, Windows.Devices.Sensors.ILightSensorDeviceId
-->

# Windows.Devices.Sensors.LightSensor

## -description
Represents an ambient-light sensor.

This sensor returns the ambient-light reading as a LUX value.

## -remarks
The following example demonstrates how a Windows Store app built with XAML and C# uses the [GetDefault](lightsensor_getdefault.md) method to establish a connection to a light sensor. If no integrated light sensor is found, the method will return a null value.



[!code-csharp[GetDefaultCS](../windows.devices.sensors/code/lightsensor/csharp/Scenario1.xaml.cs#SnippetGetDefaultCS)]

The following example demonstrates how a Windows Store app built with XAML registers a [ReadingChanged](lightsensor_readingchanged.md) event handler.



[!code-csharp[EnableReadingChangedCS](../windows.devices.sensors/code/lightsensor/csharp/Scenario1.xaml.cs#SnippetEnableReadingChangedCS)]

The following example shows the [ReadingChanged](lightsensor_readingchanged.md) event handler.



[!code-csharp[ReadingChangedCS](../windows.devices.sensors/code/lightsensor/csharp/Scenario1.xaml.cs#SnippetReadingChangedCS)]

## -examples

## -see-also
[LightSensor Sample](http://go.microsoft.com/fwlink/p/?linkid=241381), [Light sensor sample (Windows 10)](http://go.microsoft.com/fwlink/p/?LinkId=620561)
