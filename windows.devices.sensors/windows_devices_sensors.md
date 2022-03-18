---
-api-id: N:Windows.Devices.Sensors
-api-type: winrt namespace
---

# Windows.Devices.Sensors

## -description

Provides access to the supported types of sensors and related motion data.

## -remarks

This namespace provides access to the sensor types listed in the table below. The driver for a sensor must indicate that the hardware is integrated with the PC chassis for it to be accessible via this namespace. Sensors not marked as PC-integrated, even if they are of a supported type, will not be accessible. Driver developers can refer to [SensorConnectionType](/windows-hardware/drivers/ddi/content/sensorsclassextension/ne-sensorsclassextension-__midl___midl_itf_windowssensorclassextension_0000_0000_0002) enumeration for more details.

<table>
   <tr><th>Sensor</th><th>Description</th></tr>
   <tr><td>Accelerometer</td><td>Detects acceleration along three axes (x, y, and z).</td></tr>
   <tr><td>Inclinometer</td><td>Detects angle of incline along three axes (pitch, roll, and yaw).</td></tr>
   <tr><td>Gyrometer</td><td>Detects angular velocity along three axes.</td></tr>
   <tr><td>Compass</td><td>Detects heading in degrees relative to magnetic north (and due north when integrated with onboard GPS).</td></tr>
   <tr><td>Light</td><td>Detects ambient lighting level in lumens.</td></tr>
   <tr><td>Orientation</td><td>Combines the data from the accelerometer, compass, and gyrometer sensors to provide smoother and more sensitive rotation data than can be obtained from any of the sensors alone. See the [Quaternion](sensorquaternion.md) and [SensorRotationMatrix](sensorrotationmatrix.md) definitions. This combined sensor data is also known as “Sensor Fusion.”</td></tr>
   <tr><td>Simple Orientation</td><td>Uses the accelerometer to obtain device orientation as a rotation into one of four quadrants, or face-up, or face-down.</td></tr>
</table>

In addition, this namespace provides access to the following motion (or movement) data.

<table>
   <tr><th>Data</th><th>Description</th></tr>
   <tr><td>Quaternion</td><td>A Quaternion is a rotation of a point [x,y,z] around an arbitrary axis.</td></tr>
   <tr><td>Rotation Matrix</td><td>A Rotation Matrix represents a rotation around 3 axes (x, y, and z).</td></tr>
</table>

Sensor data is provided relative to the device's fixed sensor coordinate system, and is independent of display orientation. For applications that rely on sensor data for input control or to manipulate elements on the screen, the developer must take current display orientation into account and compensate the data appropriately. For more info about the sensor coordinate system, see [Sensor data and display orientation](/previous-versions/windows/apps/dn440593(v=win.10)).

For some samples that demonstrate using various sensors, see [Windows Sensor Samples](https://github.com/Microsoft/Windows-driver-samples/tree/master/sensors).

## -examples

## -see-also

[Sensor data and display orientation](/previous-versions/windows/apps/dn440593(v=win.10)), [Windows Sensor Samples](https://github.com/Microsoft/Windows-driver-samples/tree/master/sensors), [Background sensors sample (Windows 10)](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/BackgroundSensors), [Compass sample (Windows 10)](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/Compass), [Inclinometer sample (Windows 10)](https://go.microsoft.com/fwlink/p/?LinkId=620552), [Gyrometer sample (Windows 10)](https://go.microsoft.com/fwlink/p/?LinkId=620548), [Light sensor sample (Windows 10)](https://go.microsoft.com/fwlink/p/?LinkId=620561), [Orientation sensor sample (Windows 10)](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/OrientationSensor), [Accelerometer sample (Windows 10)](https://go.microsoft.com/fwlink/p/?LinkId=620477), [Video stabilization sample](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/CameraVideoStabilization), [Activity detection sensor sample](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/ActivitySensor), [Altimeter sample](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/Altimeter), [Barometer sample](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/Barometer), [Magnetometer sample](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/Magnetometer), [Pedometer sample](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/Pedometer), [Proximity sensor sample](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/ProximitySensor), [Relative inclinometer sample](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/RelativeInclinometer), [Simple orientation sensor sample](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/SimpleOrientationSensor), [Version adaptive code sample](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/VersionAdaptiveCode)
