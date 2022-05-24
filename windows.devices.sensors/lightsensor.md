---
-api-id: T:Windows.Devices.Sensors.LightSensor
-api-type: winrt class
---

<!-- Class syntax.
public class LightSensor : Windows.Devices.Sensors.ILightSensor, Windows.Devices.Sensors.ILightSensorDeviceId
-->

# Windows.Devices.Sensors.LightSensor

## -description

Represents an ambient-light sensor that provides the ambient-light reading as a LUX value.

## -remarks

The following example demonstrates how a UWP app built with XAML and C# uses the [GetDefault](lightsensor_getdefault_846721868.md) method to establish a connection to a light sensor. If no integrated light sensor is found, the method will return a null value.

[!code-csharp[GetDefaultCS](../windows.devices.sensors/code/lightsensor/csharp/Scenario1.xaml.cs#SnippetGetDefaultCS)]

The following example demonstrates how a UWP app built with XAML registers a [ReadingChanged](lightsensor_readingchanged.md) event handler.

[!code-csharp[EnableReadingChangedCS](../windows.devices.sensors/code/lightsensor/csharp/Scenario1.xaml.cs#SnippetEnableReadingChangedCS)]

The following example shows the [ReadingChanged](lightsensor_readingchanged.md) event handler.

[!code-csharp[ReadingChangedCS](../windows.devices.sensors/code/lightsensor/csharp/Scenario1.xaml.cs#SnippetReadingChangedCS)]

### Version history

| Windows version | SDK version | Value added |
| -- | -- | -- |
| 1709 | 16299 | FromIdAsync |
| 1709 | 16299 | GetDeviceSelector |
| 1709 | 16299 | MaxBatchSize |
| 1709 | 16299 | ReportLatency |
| 2004 | 19041 | ReportThreshold |

## -examples

For an example implementation, see the [light sensor sample](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/LightSensor).

## -see-also

[LightSensor Sample](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/LightSensor), [Light sensor sample (Windows 10)](https://go.microsoft.com/fwlink/p/?LinkId=620561)
