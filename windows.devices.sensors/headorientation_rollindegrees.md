---
-api-id: P:Windows.Devices.Sensors.HeadOrientation.RollInDegrees
-api-type: winrt property
---

# Windows.Devices.Sensors.HeadOrientation.RollInDegrees

<!--
public System.Nullable<double> RollInDegrees { get; }
-->

## -description

Gets the counterclockwise rotation of the user's head around the Z'-axis (or longitudinal axis), in degrees.

## -property-value

The counterclockwise rotation of the user's head around the Z'-axis (or longitudinal axis), in degrees.

This value has a range of [0, 360) degrees.

## -remarks

Similar to tilting the motion of a wheel on a car or bike.

In the zero position, the Z'-axis is parallel to the device's Z-axis and points from the center of the person's face towards the device.

:::image type="content" source="images/human-presence-roll-pitch-yaw.png" alt-text="Diagram depicting how roll, pitch, and yaw are described by the human presence APIs.":::

## -see-also

[YawInDegrees](headorientation_yawindegrees.md), [PitchInDegrees](headorientation_pitchindegrees.md)

## -examples
