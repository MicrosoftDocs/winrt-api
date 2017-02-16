---
-api-id: M:Windows.Devices.Sensors.OrientationSensor.GetDefault(Windows.Devices.Sensors.SensorReadingType)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Devices.Sensors.OrientationSensor GetDefault(Windows.Devices.Sensors.SensorReadingType sensorReadingtype)
-->

# Windows.Devices.Sensors.OrientationSensor.GetDefault

## -description
Gets the default orientation sensor, taking into account accuracy preferences.

## -parameters
### -param sensorReadingtype
The type of sensor to retrieve. An Absolute SensorReadingType returns an OrientationSensor using an accelerometer, a gyromoter, and magnetometer to determine the orientation with respect to magnetic North. A Relative SensorReadingType returns an OrientationSensor using an accelerometer and gyrometer only (no magnetometer), measuring relative to where the sensor was first instantiated.”

## -returns
The default orientation sensor or **null** if no orientation sensors are found.

## -remarks
This method only returns values for hardware that has been integrated into the computer by the manufacturer. (The orientation-sensor readings are derived from multiple sensors.) A **null** value will be returned if the specified sensor is not available in the system.

When a system is in Connected Standby, a call to the [GetDefault](orientationsensor_getdefault.md) method will return immediately with a **null** result.

## -examples

## -see-also
[GetDefault(SensorReadingType, SensorOptimizationGoal)](orientationsensor_getdefault_274432112.md), [GetDefault](orientationsensor_getdefault_846721868.md)