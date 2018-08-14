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

Sensor data is provided relative to the device's fixed sensor coordinate system, and is independent of display orientation. For applications that rely on sensor data for input control or to manipulate elements on the screen, the developer must take current display orientation into account and compensate the data appropriately. For more info about the sensor coordinate system, see [Sensor data and display orientation](http://msdn.microsoft.com/library/f90937f1-edaf-469c-b360-2ed67cb4fad0).

The following example demonstrates how a UWP app built with XAML and C# uses the [GetDefault](accelerometer_getdefault_702418228.md) method to establish a connection to an accelerometer. If no integrated accelerometer is found, the method will return a null value.

[!code-csharp[GetDefaultCS](../windows.devices.sensors/code/Accelerometer/cs/Scenario1.xaml.cs#SnippetGetDefaultCS)]

The following example demonstrates how a UWP app built with XAML registers a **ReadingChanged** event handler.

[!code-csharp[EnableReadingChangedCS](../windows.devices.sensors/code/Accelerometer/cs/Scenario1.xaml.cs#SnippetEnableReadingChangedCS)]

The following example shows the [ReadingChanged](accelerometer_readingchanged.md) event handler.

[!code-csharp[ReadingChangedCS](../windows.devices.sensors/code/Accelerometer/cs/Scenario1.xaml.cs#SnippetReadingChangedCS)]

## -examples

## -see-also

[Accelerometer Sample](http://go.microsoft.com/fwlink/p/?linkid=241377), [Sensor data and display orientation](http://msdn.microsoft.com/library/f90937f1-edaf-469c-b360-2ed67cb4fad0), [Accelerometer sample (Windows 10)](http://go.microsoft.com/fwlink/p/?LinkId=620477), [Background sensors sample (Windows 10)](http://go.microsoft.com/fwlink/p/?LinkId=620509)
