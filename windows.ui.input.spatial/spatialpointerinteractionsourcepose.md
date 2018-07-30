---
-api-id: T:Windows.UI.Input.Spatial.SpatialPointerInteractionSourcePose
-api-type: winrt class
---

<!-- Class syntax.
public class SpatialPointerInteractionSourcePose 
-->

# Windows.UI.Input.Spatial.SpatialPointerInteractionSourcePose

## -description

Represents a motion controller's pointer pose in relation to its surroundings.

## -remarks

Windows Mixed Reality supports motion controllers in a variety of form factors, with each controller's design differing in its relationship between the user's hand position and the natural "forward" direction that apps should use for pointing when rendering the controller.

To better represent these controllers, there are two kinds of poses you can investigate for each interaction source.

The grip pose represents the location of either the palm of a hand detected by a HoloLens, or the palm holding a motion controller.  On immersive headsets, this pose is best used to render the user's hand or an object held in the user's hand, such as a sword or gun.  The grip pose is represented by the position, orientation and velocity properties directly within this type.

The pointer pose represents the tip of a motion controller pointing forward.  This pose is best used to raycast when pointing at UI when you are rendering the controller model itself.  The pointer pose can be accessed through the SourcePointerPose property.

## -see-also

[Spatial interaction source sample](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/SpatialInteractionSource)

## -examples
