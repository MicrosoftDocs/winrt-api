---
-api-id: N:Windows.Devices.Sensors.Custom
-api-type: winrt namespace
---

# Windows.Devices.Sensors.Custom

## -description

Provides access to a custom sensor and its related data.

## -remarks

Supports the ability for hardware manufactures to expose sensors that don’t have first class representations.

The [CustomSensor](customsensor.md), [CustomSensorReadingChangedEventArgs](customsensorreadingchangedeventargs.md), and [CustomSensorReading](customsensorreading.md) classes are modeled on the Windows.Devices.Sensors classes ([Accelerometer](../windows.devices.sensors/accelerometer.md), [Gyrometer](../windows.devices.sensors/gyrometer.md), [Magnetometer](../windows.devices.sensors/magnetometer.md), and so on).

This namespace adds a list property of key/value pairs to each one of the native sensor "reading" classes. The list property is mapped on the [CustomSensorReading](customsensorreading.md) class.

## -examples

## -see-also

[Custom sensors sample](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/CustomSensors)
