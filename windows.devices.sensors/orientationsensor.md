---
-api-id: T:Windows.Devices.Sensors.OrientationSensor
-api-type: winrt class
---

<!-- Class syntax.
public class OrientationSensor : Windows.Devices.Sensors.IOrientationSensor, Windows.Devices.Sensors.IOrientationSensor2, Windows.Devices.Sensors.IOrientationSensorDeviceId
-->

# Windows.Devices.Sensors.OrientationSensor

## -description

Represents an orientation sensor.

This sensor returns a rotation matrix and a Quaternion that can be used to adjust the user's perspective in a game application.

For an example implementation, see the [orientation sensor sample](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/OrientationSensor).

## -remarks

Sensor data is provided relative to the device's fixed sensor coordinate system, and is independent of display orientation. For applications that rely on sensor data for input control or to manipulate elements on the screen, the developer must take current display orientation into account and compensate the data appropriately. For more info about the sensor coordinate system, see [Sensor data and display orientation](/previous-versions/windows/apps/dn440593(v=win.10)).

The following example demonstrates how a UWP app built with XAML and C# uses the [GetDefault](orientationsensor_getdefault_2064571144.md) method to establish a connection to an orientation sensor. If no orientation sensor is found, the method will return a null value.

[!code-csharp[GetDefaultCS](../windows.devices.sensors/code/orientation/csharp/Scenario1.xaml.cs#SnippetGetDefaultCS)]

The following example demonstrates how a UWP app built with XAML registers a [ReadingChanged](orientationsensor_readingchanged.md) event handler.

[!code-csharp[EnableReadingChangedCS](../windows.devices.sensors/code/orientation/csharp/Scenario1.xaml.cs#SnippetEnableReadingChangedCS)]

The following example shows the [ReadingChanged](orientationsensor_readingchanged.md) event handler.

[!code-csharp[ReadingChangedCS](../windows.devices.sensors/code/orientation/csharp/Scenario1.xaml.cs#SnippetReadingChangedCS)]

### Version history

| Windows version | SDK version | Value added |
| -- | -- | -- |
| 1607 | 14393 | GetDefault(SensorReadingType) |
| 1607 | 14393 | GetDefault(SensorReadingType,SensorOptimizationGoal) |
| 1709 | 16299 | FromIdAsync |
| 1709 | 16299 | GetDeviceSelector(SensorReadingType) |
| 1709 | 16299 | GetDeviceSelector(SensorReadingType,SensorOptimizationGoal) |
| 1709 | 16299 | MaxBatchSize |
| 1709 | 16299 | ReportLatency |

## -examples

## -see-also

[OrientationSensor Sample](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/OrientationSensor), [Sensor data and display orientation](/previous-versions/windows/apps/dn440593(v=win.10)), [Orientation sensor sample (Windows 10)](https://go.microsoft.com/fwlink/p/?LinkId=620580), [Version adaptive code sample](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/VersionAdaptiveCode)
