---
-api-id: M:Windows.Devices.Sensors.OrientationSensor.GetDefault(Windows.Devices.Sensors.SensorReadingType,Windows.Devices.Sensors.SensorOptimizationGoal)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Devices.Sensors.OrientationSensor GetDefault(Windows.Devices.Sensors.SensorReadingType sensorReadingType, Windows.Devices.Sensors.SensorOptimizationGoal optimizationGoal)
-->

# Windows.Devices.Sensors.OrientationSensor.GetDefault

## -description
Gets the default orientation sensor, taking into account power and accuracy preferences.

## -parameters
### -param sensorReadingType
The type of sensor to retrieve. An Absolute SensorReadingType returns an OrientationSensor using an accelerometer, a gyromoter, and magnetometer to determine the orientation with respect to magnetic North. A Relative SensorReadingType returns an OrientationSensor using an accelerometer and gyrometer only (no magnetometer), measuring relative to where the sensor was first instantiated.”

### -param optimizationGoal
Indicates the preferences of optimization for the sensor. This field is only used if an Absolute SensorReadingType is specified. An optimizationGoal of Precision will return an OrientationSensor using an accelereometer, a gyrometer, and a magnetometer to determine orientation with respect to magnetic North. This has the potential to use a lot of power due to it’s use of a gyrometer. In contrast, specifying an optimizationGoal of PowerEfficiency will return an OrientationSensor using an accelerometer and magnetometer only (no gyrometer) to save power at the a cost of some accuracy (readings will still be relatively accurate in most circumstances).

## -returns
The default orientation sensor or **null** if no orientation sensors are found.

## -remarks
This method only returns values for hardware that has been integrated into the computer by the manufacturer. (The orientation-sensor readings are derived from multiple sensors.) A **null** value will be returned if the specified sensor is not available in the system.

When a system is in Connected Standby, a call to the [GetDefault](orientationsensor_getdefault.md) method will return immediately with a **null** result.

The *optimizationGoal* parameter is dependent on the hardware available. It will attempt to choose the best sensor available based on your provided preference for optimization. It only has an effect if the *sensorReadingType* is **Absolute**.

## -examples

## -see-also
[GetDefault(SensorReadingType)](orientationsensor_getdefault_2064571144.md), [GetDefault](orientationsensor_getdefault_846721868.md)