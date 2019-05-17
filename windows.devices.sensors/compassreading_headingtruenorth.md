---
-api-id: P:Windows.Devices.Sensors.CompassReading.HeadingTrueNorth
-api-type: winrt property
---

<!-- Property syntax
public Windows.Foundation.IReference<double> HeadingTrueNorth { get; }
-->

# Windows.Devices.Sensors.CompassReading.HeadingTrueNorth

## -description
Gets the heading in degrees relative to geographic true-north.

## -property-value
The true-north heading.

## -remarks
Before retrieving this property, your code should first check to verify that the value is not null. (If the value is null and you attempt to retrieve it, Windows will generate an exception.)

In order to retrieve the declination, your app needs to have access to the device's current location. If the location is not available, the declination defaults to 0 degrees. In this scenario, HeadingTrueNorth equals [HeadingMagneticNorth](compassreading_headingmagneticnorth.md).

## -examples

## -see-also
