---
-api-id: P:Windows.UI.Input.Spatial.SpatialNavigationCompletedEventArgs.NormalizedOffset
-api-type: winrt property
-api-device-family-note: xbox
---

<!-- Property syntax
public Windows.Foundation.Numerics.Vector3 NormalizedOffset { get; }
-->

# Windows.UI.Input.Spatial.SpatialNavigationCompletedEventArgs.NormalizedOffset

## -description
Gets the normalized offset of the hand or motion controller within the unit cube for all axes for this Navigation gesture.

## -property-value
The normalized offset.

## -remarks
For hand interactions, the unit cube is oriented relative to the user's head at the time of the finger press.

The NormalizedOffset is returned as a vector along three axes within the cube: Horizontal, Vertical, and Depth, respectively. For each axis, the value ranges from -1.0 to 1.0 as motion in that axis reaches its extent. A value of 0.0 means no motion in that axis. These are normalized values and do not represent any physical unit, such as meters. It's up to an app to assign meaning, such as scroll velocity, to motion of the hand or controller within the unit cube.

## -examples

## -see-also
