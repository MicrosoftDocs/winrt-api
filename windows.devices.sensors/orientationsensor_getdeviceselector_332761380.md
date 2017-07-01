---
-api-id: M:Windows.Devices.Sensors.OrientationSensor.GetDeviceSelector(Windows.Devices.Sensors.SensorReadingType,Windows.Devices.Sensors.SensorOptimizationGoal)
-api-type: winrt method
---

<!-- Method syntax.
public string OrientationSensor.GetDeviceSelector(SensorReadingType readingType, SensorOptimizationGoal optimizationGoal)
-->

# Windows.Devices.Sensors.OrientationSensor.GetDeviceSelector

## -description
Gets the device selector.

## -parameters
### -param readingType
The type of sensor to retrieve. An Absolute SensorReadingType returns an OrientationSensor using an accelerometer, a gyromoter, and magnetometer to determine the orientation with respect to magnetic North. A Relative SensorReadingType returns an OrientationSensor using an accelerometer and gyrometer only (no magnetometer), measuring relative to where the sensor was first instantiated.

### -param optimizationGoal
Indicates the preferences of optimization for the sensor. This field is only used if an Absolute SensorReadingType is specified. An optimizationGoal of Precision will return an OrientationSensor using an accelereometer, a gyrometer, and a magnetometer to determine orientation with respect to magnetic North. This has the potential to use a lot of power due to it’s use of a gyrometer. In contrast, specifying an optimizationGoal of PowerEfficiency will return an OrientationSensor using an accelerometer and magnetometer only (no gyrometer) to save power at the a cost of some accuracy (readings will still be relatively accurate in most circumstances).

## -returns
Returns the device selector, if it exists; otherwise, null.

## -remarks

## -see-also

## -examples

