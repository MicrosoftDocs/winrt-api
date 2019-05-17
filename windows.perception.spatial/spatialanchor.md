---
-api-id: T:Windows.Perception.Spatial.SpatialAnchor
-api-type: winrt class
-api-device-family-note: xbox
---

<!-- Class syntax.
public class SpatialAnchor : Windows.Perception.Spatial.ISpatialAnchor, Windows.Perception.Spatial.ISpatialAnchor2
-->

# Windows.Perception.Spatial.SpatialAnchor

## -description
Represents a coordinate system that is strongly anchored to a point in the user's surroundings.

## -remarks
You can create a SpatialAnchor at any position and orientation within the [SpatialCoordinateSystem](spatialcoordinatesystem.md) of your choosing. The device must be able to locate that coordinate system at the moment, and the system must not have reached its limit of spatial anchors.

Once defined, the coordinate system of a SpatialAnchor adjusts continually to retain the precise position and orientation of its initial location. You can then use this SpatialAnchor to render holograms that will appear fixed in the user's surroundings at that exact location.

The effects of the adjustments that keep the anchor in place are magnified as distance from the anchor increases. You should avoid rendering content relative to an anchor that is more than 3 meters from that anchor's origin.

You can persist a SpatialAnchor using the [SpatialAnchorStore](spatialanchorstore.md) class and then get it back in a future app session.

The [CoordinateSystem](spatialanchor_coordinatesystem.md) property gets a coordinate system that lets you place content relative to the anchor, with easing applied when the device adjusts the anchor's precise location.

Use the [RawCoordinateSystem](spatialanchor_rawcoordinatesystem.md) property and the corresponding [RawCoordinateSystemAdjusted](spatialanchor_rawcoordinatesystemadjusted.md) event to manage these adjustments yourself.

The coordinate system is right-handed, with +y up, +x to the right, and -z forward.

### Version history

| Windows version | SDK version | Value added |
| -- | -- | -- |
| 1607 | 14393 | RemovedByUser |

## -examples

## -see-also
