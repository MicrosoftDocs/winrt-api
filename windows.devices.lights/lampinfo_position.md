---
-api-id: P:Windows.Devices.Lights.LampInfo.Position
-api-type: winrt property
ms.custom: RS5
---

<!-- Property syntax.
public Vector3 Position { get; }
-->

# Windows.Devices.Lights.LampInfo.Position

## -description
Gets the position of the lamp within the lamp array, expressed in meters relative to the front-top-left corner of the array's bounding box.

## -property-value
A [Vector3](/dotnet/api/system.numerics.vector3) representing the lamp's position in meters, where X is the horizontal offset (increasing to the right), Y is the vertical offset (increasing downward), and Z is the depth offset (increasing away from the user).

## -remarks
Position values are expressed in meters. The coordinate system is left-handed:
- **+X** extends to the right.
- **+Y** extends downward.
- **+Z** extends away from the user (into the device).

The origin (0, 0, 0) corresponds to the front-top-left corner of the device's bounding box (see [LampArray.BoundingBox](lamparray_boundingbox.md)).

Position values are derived from the device's HID LampArray descriptor, which reports positions in micrometers (µm). The WinRT API converts these values to meters (µm ÷ 1,000,000) before exposing them as a [Vector3](/dotnet/api/system.numerics.vector3).

## -see-also
[LampArray.BoundingBox](lamparray_boundingbox.md), [Lighting and Illumination (www.usb.org)](https://www.usb.org/sites/default/files/hutrr84_-_lighting_and_illumination_page.pdf), [Dynamic lighting](/windows/uwp/devices-sensors/lighting-dynamic-lamparray)

## -examples

