---
-api-id: T:Windows.Devices.Sensors.MagnetometerAccuracy
-api-type: winrt enum
---

<!-- Enumeration syntax
public enum Windows.Devices.Sensors.MagnetometerAccuracy : int
-->

# MagnetometerAccuracy

## -description

The sensor's accuracy.

See [One Dev Minute - Sensor calibration](https://learn.microsoft.com/shows/one-dev-minute/sensor-calibration) for a short video overview on how to calibrate the magnetometer.

## -enum-fields

### -field Unknown:0

The accuracy is currently not available, typically because the driver can't report it.

You should determine, based on your app's needs, whether your app will want to ask users to calibrate the device whenever this value is returned.

### -field Unreliable:1
The actual and reported values have a high degree of inaccuracy.

Apps should always ask the user to calibrate the device whenever this value is returned.

### -field Approximate:2
The actual and reported values differ but may be accurate enough for some application.

Apps that only need a relative value, like a virtual reality app, can continue without additional calibration.

### -field High:3
The actual and reported values are accurate.

No additional calibration is needed.


## -remarks
Apps that need calibration should periodically ask the user to calibrate the device. We suggest doing this no more than every 10 minutes.

## -examples

## -see-also