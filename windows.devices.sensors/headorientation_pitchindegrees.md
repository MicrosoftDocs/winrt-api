---
-api-id: P:Windows.Devices.Sensors.HeadOrientation.PitchInDegrees
-api-type: winrt property
---

# Windows.Devices.Sensors.HeadOrientation.PitchInDegrees

<!--
public System.Nullable<double> PitchInDegrees { get; }
-->

## -description

Gets the counterclockwise rotation of the user's head around the X'-axis (or lateral axis), in degrees.

## -property-value

The counterclockwise rotation of the user's head around the X'-axis (or lateral axis), in degrees.

This value has a range of [-180, 180) degrees.

## -remarks

Similar to tilting the nose of an aeroplane up or down.

In the zero position, the X'-axis is parallel to the device's X-axis and points from the center of the person's face towards the right, from the device perspective.

:::image type="content" source="images/human-presence-roll-pitch-yaw.png" alt-text="Diagram depicting how roll, pitch, and yaw are described by the human presence APIs.":::

## -see-also

[YawInDegrees](headorientation_yawindegrees.md), [RollInDegrees](headorientation_rollindegrees.md)

## -examples
