---
-api-id: T:Windows.Devices.Sensors.Accelerometer
-api-type: winrt class
---

<!-- Class syntax.
public class Accelerometer : Windows.Devices.Sensors.IAccelerometer, Windows.Devices.Sensors.IAccelerometer2, Windows.Devices.Sensors.IAccelerometer3, Windows.Devices.Sensors.IAccelerometer4, Windows.Devices.Sensors.IAccelerometerDeviceId
-->

# Windows.Devices.Sensors.Accelerometer

## -description

Represents an accelerometer sensor.

This sensor returns G-force values with respect to the x, y, and z axes.

For an example implementation, see the [accelerometer sample](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/Accelerometer).

## -remarks

Applications use the methods in this class to determine whether the sensor reading has changed or the device has been shaken.

Applications use the properties in this class to retrieve and adjust the sensor report interval.

Sensor data is provided relative to the device's fixed sensor coordinate system, and is independent of display orientation. For applications that rely on sensor data for input control or to manipulate elements on the screen, the developer must take current display orientation into account and compensate the data appropriately. For more info about the sensor coordinate system, see [Sensor data and display orientation](/previous-versions/windows/apps/dn440593(v=win.10)).

The following example demonstrates how a UWP app built with XAML and C# uses the [GetDefault](accelerometer_getdefault_702418228.md) method to establish a connection to an accelerometer. If no integrated accelerometer is found, the method will return a null value.

[!code-csharp[GetDefaultCS](../windows.devices.sensors/code/Accelerometer/cs/Scenario1.xaml.cs#SnippetGetDefaultCS)]

The following example demonstrates how a UWP app built with XAML registers a **ReadingChanged** event handler.

[!code-csharp[EnableReadingChangedCS](../windows.devices.sensors/code/Accelerometer/cs/Scenario1.xaml.cs#SnippetEnableReadingChangedCS)]

The following example shows the [ReadingChanged](accelerometer_readingchanged.md) event handler.

[!code-csharp[ReadingChangedCS](../windows.devices.sensors/code/Accelerometer/cs/Scenario1.xaml.cs#SnippetReadingChangedCS)]

### Version history

| Windows version | SDK version | Value added |
| -- | -- | -- |
| 1607 | 14393 | GetDefault(AccelerometerReadingType) |
| 1607 | 14393 | ReadingType |
| 1709 | 16299 | FromIdAsync |
| 1709 | 16299 | GetDeviceSelector |
| 2004 | 19041 | ReportThreshold |

## -examples

## -see-also

[Accelerometer sample](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/Accelerometer), [Sensor data and display orientation](/previous-versions/windows/apps/dn440593(v=win.10)), [Accelerometer sample (Windows 10)](https://go.microsoft.com/fwlink/p/?LinkId=620477), [Background sensors sample (Windows 10)](https://go.microsoft.com/fwlink/p/?LinkId=620509)
