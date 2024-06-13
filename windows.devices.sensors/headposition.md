---
-api-id: T:Windows.Devices.Sensors.HeadPosition
-api-type: winrt class
---

# Windows.Devices.Sensors.HeadPosition

<!--
public sealed class HeadPosition
-->

## -description

Represents an object that describes the location of a user's head relative to the human presence sensor, in terms of [azimuth](headposition_azimuthindegrees.md) and [altitude](headposition_altitudeindegrees.md).

## -remarks

The X-axis is in the plane of the device screen. It is positive towards the right-hand side of the screen, from the perspective of a user facing the device. (For devices without a screen, the axes are defined relative to the front panel of the device.)

The Y-axis is in the plane of the screen. It is positive towards the top of the screen.

The Z-axis is perpendicular to the screen. It is positive towards the user facing the device.

The axes are fixed relative to the device and don't change with device rotation.

The following image shows how azimuth and altitude are described by the human presence APIs.

:::image type="content" source="images/human-presence-azimuth-altitude.png" alt-text="t":::

## -see-also

[HeadOrientation](headorientation.md)

## -examples
