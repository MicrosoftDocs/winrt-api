---
-api-id: P:Windows.UI.Input.Spatial.SpatialInteractionSource.Handedness
-api-type: winrt property
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

For controllers that may be held equivalently in either hand, the system may use a heuristic to determine which controller is which, returning Unspecified until this is determined.  If such a controller changes its Handedness, the source will be lost and then detected again with the alternate handedness.

For hand and voice sources on HoloLens, this will always return Unspecified.

## -see-also

## -examples

