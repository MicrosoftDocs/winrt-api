---
-api-id: N:Windows.Devices.Sensors.Custom
-api-type: winrt namespace
---

# Windows.Devices.Sensors.Custom

## -description

Provides access to a custom sensor and its related data.


## -remarks

This namespace enables hardware manufactures to expose sensors that don’t have first class representations like [Accelerometer](../windows.devices.sensors/accelerometer.md). This namespace provides access to the [CustomSensor](customsensor.md) class to represent sensors without a first class representation. Additionally, this namespace will extend the first class representation with a value collection to expose custom values.

### Custom sensors

This namespace includes the new [CustomSensor](customsensor.md), [CustomSensorReadingChangedEventArgs](customsensorreadingchangedeventargs.md), and [CustomSensorReading](customsensorreading.md) classes that are modeled on the [Windows.Devices.Sensors](windows_devices_sensors_custom.md) classes ([Accelerometer](../windows.devices.sensors/accelerometer.md), [Gyrometer](../windows.devices.sensors/gyrometer.md), [Magnetometer](../windows.devices.sensors/magnetometer.md), and so on).

### Native sensors extensibility

This namespace adds a list property of key/value pairs to each one of the native sensor "reading" classes. The list property is mapped on the [CustomSensorReading](customsensorreading.md) class.

## -examples

## -see-also

[Custom sensors sample](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/CustomSensors)

