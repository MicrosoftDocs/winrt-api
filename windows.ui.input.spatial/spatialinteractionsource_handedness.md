---
-api-id: P:Windows.UI.Input.Spatial.SpatialInteractionSource.Handedness
-api-type: winrt property
ms.custom: 19H1
---

<!-- Property syntax.
public SpatialInteractionSourceHandedness Handedness { get; }
-->

# Windows.UI.Input.Spatial.SpatialInteractionSource.Handedness

## -description

Gets whether the interaction source represents the user's left hand or right hand.

## -property-value

The handedness.

## -remarks

For controllers that have an inherent handedness, this will always return that handedness, regardless of which hand the controller is physically held in.

For controllers that do not support positional tracking and do not have an inherent handedness, such as the HoloLens clicker, this will always return Unspecified.

For controllers that can be held in either hand, the system might use a heuristic to determine the handedness, returning Unspecified until determined.  If such a controller changes handedness, the source is lost and  re-detected with the current handedness.

For hand and speech sources on HoloLens, this property always returns Unspecified.

## -see-also

## -examples
