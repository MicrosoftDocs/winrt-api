---
-api-id: T:Windows.Devices.Sensors.Gyrometer
-api-type: winrt class
---

<!-- Class syntax.
public class Gyrometer : Windows.Devices.Sensors.IGyrometer, Windows.Devices.Sensors.IGyrometer2, Windows.Devices.Sensors.IGyrometerDeviceId
-->

# Windows.Devices.Sensors.Gyrometer

## -description

Represents a gyrometer sensor that provides angular velocity values with respect to the x, y, and z axes.

## -remarks

Sensor data is provided relative to the device's fixed sensor coordinate system, and is independent of display orientation. For applications that rely on sensor data for input control or to manipulate elements on the screen, the developer must take current display orientation into account and compensate the data appropriately. For more info about the sensor coordinate system, see [Sensor data and display orientation](/previous-versions/windows/apps/dn440593(v=win.10)).

The following example demonstrates how a UWP app built with XAML and C# uses the [GetDefault](gyrometer_getdefault_846721868.md) method to establish a connection to a gyrometer. If no integrated gyrometer is found, the method will return a null value.

[!code-csharp[GetDefaultCS](../windows.devices.sensors/code/gyrometer/csharp/Scenario1.xaml.cs#SnippetGetDefaultCS)]

The following example demonstrates how a UWP app built with XAML registers a [ReadingChanged](gyrometer_readingchanged.md) event handler.

[!code-csharp[EnableReadingChangedCS](../windows.devices.sensors/code/gyrometer/csharp/Scenario1.xaml.cs#SnippetEnableReadingChangedCS)]

The following example shows the [ReadingChanged](gyrometer_readingchanged.md) event handler.

[!code-csharp[ReadingChangedCS](../windows.devices.sensors/code/gyrometer/csharp/Scenario1.xaml.cs#SnippetReadingChangedCS)]

### Version history

| Windows version | SDK version | Value added |
| -- | -- | -- |
| 1709 | 16299 | FromIdAsync |
| 1709 | 16299 | GetDeviceSelector |
| 1709 | 16299 | MaxBatchSize |
| 1709 | 16299 | ReportLatency |
| 2004 | 19041 | ReportThreshold |

## -examples

For an example implementation, see the [gyrometer sample](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/Gyrometer).

## -see-also

[Gyrometer Sample](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/Gyrometer), [Sensor data and display orientation](/previous-versions/windows/apps/dn440593(v=win.10))
