---
-api-id: T:Windows.Perception.Spatial.SpatialStationaryFrameOfReference
-api-type: winrt class
-api-device-family-note: xbox
---

<!-- Class syntax.
public class SpatialStationaryFrameOfReference : Windows.Perception.Spatial.ISpatialStationaryFrameOfReference
-->

# Windows.Perception.Spatial.SpatialStationaryFrameOfReference

## -description
Represents a frame of reference that remains stationary relative to the user's surroundings at a point in time.

## -remarks
The SpatialStationaryFrameOfReference class represents a frame of reference that remains stationary relative to the user's surroundings as the user moves around. This frame of reference prioritizes keeping coordinates stable near the device. One key use of a SpatialStationaryFrameOfReference is to act as the underlying world coordinate system within a rendering engine when rendering seated-scale or world-scale experiences.

Holograms rendered at a coordinate in this frame stay generally in place as the user moves the device around. However, as the user walks around a large area and the device adjusts its understanding of their surroundings, these holograms may drift relative to the world. To avoid this drift and strongly anchor content to a point in the user's surroundings, create a [SpatialAnchor](spatialanchor.md). The system will then adjust the position of that SpatialAnchor relative to this and other frames of reference as required to keep that anchor precisely in place in the world.

To get a SpatialStationaryFrameOfReference, use the SpatialLocator class and call CreateStationaryFrameOfReferenceAtCurrentLocation.

To build a standing-scale or room-scale experience based on the floor plane or movement boundary defined by the user, an app can use the [SpatialStageFrameOfReference](spatialstageframeofreference.md) class instead.

## -examples

## -see-also
