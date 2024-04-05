---
-api-id: P:Windows.Devices.Sensors.HeadOrientation.YawInDegrees
-api-type: winrt property
---

# Windows.Devices.Sensors.HeadOrientation.YawInDegrees

<!--
public System.Nullable<double> YawInDegrees { get; }
-->

## -description

Gets the counterclockwise rotation of the user's head around the Y'-axis (or vertical axis), in degrees.

## -property-value

The counterclockwise rotation of the user's head around the Y'-axis (or vertical axis), in degrees.

This value has a range of [-90, 90) degrees.

## -remarks

Similar to turning your head left or right.

In the zero position, the Y'-axis is parallel to the device's Y-axis and points from the center of the person's face upwards.

:::image type="content" source="images/human-presence-roll-pitch-yaw.png" alt-text="Diagram depicting how roll, pitch, and yaw are described by the human presence APIs.":::

## -see-also

[RollInDegrees](headorientation_rollindegrees.md), [PitchInDegrees](headorientation_pitchindegrees.md)

## -examples
