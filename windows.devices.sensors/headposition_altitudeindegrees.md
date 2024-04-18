---
-api-id: P:Windows.Devices.Sensors.HeadPosition.AltitudeInDegrees
-api-type: winrt property
---

# Windows.Devices.Sensors.HeadPosition.AltitudeInDegrees

<!--
public System.Nullable<double> AltitudeInDegrees { get; }
-->

## -description

Gets the elevation of the user's head relative to the horizontal plane of the human presence sensor, in degrees.

## -property-value

The elevation of the user's head relative to the horizontal plane of the human presence sensor, in degrees.

This value has a range of -90 degrees to 90 degrees and is positive in the direction of the Y-axis.

## -remarks

The angle between Z-axis and XZ-projection of the vector pointing from the sensor device to the center of the user's head and its XZ-projection. Range is constrained by the maximum and minimum altitude sensor properties.

The following image shows how azimuth and altitude are described by the human presence APIs.

:::image type="content" source="images/human-presence-azimuth-altitude.png" alt-text="t":::

## -see-also

[AzimuthInDegrees](headposition_azimuthindegrees.md)

## -examples
