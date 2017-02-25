---
-api-id: T:Windows.Perception.Spatial.SpatialStageFrameOfReference
-api-type: winrt class
---

<!-- Class syntax.
public class SpatialStageFrameOfReference 
-->

# Windows.Perception.Spatial.SpatialStageFrameOfReference

## -description
Represents a spatial stage, defined by the user to establish the physical space in which they intend to use a Mixed Reality headset.

## -remarks
A spatial stage consists minimally of a floor-level coordinate system whose origin is chosen by the user, representing the logical center of the area in which they intend to use their Mixed Reality headset.  This floor-level coordinate system enables apps to present standing-scale experiences.

Optionally, the user may also define a movement boundary, representing the open area in which they intend to walk while using the headset.  This movement boundary enables apps to present room-scale experiences.

If the user has not defined a spatial stage, an app may call the [RequestNewStageAsync](spatialstageframeofreference_requestnewstageasync_1196621824.md) method to guide the user through system UI that will allow them to define one.

On HoloLens, an app may also build standing-scale or room-scale experiences using spatial mapping.  Spatial mapping enables the developer to analyze the user's surroundings and determine the locations of the user's walls and floors using the [SpatialSurfaceObserver](../windows.perception.spatial.surfaces/spatialsurfaceobserver.md) type, even if the user has not defined a stage manually.  Inspect the [SpatialSurfaceObserver.IsSupported](../windows.perception.spatial.surfaces/spatialsurfaceobserver_issupported_930300905.md) property to determine if the current device supports spatial mapping.

Coordinate systems returned by the stage are right-handed, with +y up, +x to the right, and -z forward.

## -see-also

## -examples

