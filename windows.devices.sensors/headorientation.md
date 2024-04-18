---
-api-id: T:Windows.Devices.Sensors.HeadOrientation
-api-type: winrt class
---

# Windows.Devices.Sensors.HeadOrientation

<!--
public sealed class HeadOrientation
-->

## -description

Represents an object that describes the orientation a user's head is facing relative to the human presence sensor, in terms of [roll](headorientation_rollindegrees.md), [pitch](headorientation_pitchindegrees.md), and [yaw](headorientation_yawindegrees.md).

## -remarks

The X-axis is in the plane of the device screen. It is positive towards the right-hand side of the screen, from the perspective of a user facing the device. (For devices without a screen, the axes are defined relative to the front panel of the device.)

The Y-axis is in the plane of the screen. It is positive towards the top of the screen.

The Z-axis is perpendicular to the screen. It is positive towards the user facing the device.

The axes are fixed relative to the device and don't change with device rotation.

The following image shows how roll, pitch, and yaw are described by the human presence APIs.

:::image type="content" source="images/human-presence-roll-pitch-yaw.png" alt-text="Diagram depicting how roll, pitch, and yaw are described by the human presence APIs.":::

## -see-also

[HeadPosition](headposition.md)

## -examples
