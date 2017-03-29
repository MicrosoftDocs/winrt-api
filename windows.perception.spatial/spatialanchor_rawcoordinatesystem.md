---
-api-id: P:Windows.Perception.Spatial.SpatialAnchor.RawCoordinateSystem
-api-type: winrt property
-api-device-family-note: xbox
---

<!-- Property syntax
public Windows.Perception.Spatial.SpatialCoordinateSystem RawCoordinateSystem { get; }
-->

# Windows.Perception.Spatial.SpatialAnchor.RawCoordinateSystem

## -description
Gets the coordinate system of the anchor, without easing applied.

## -property-value
The raw coordinate system.

## -remarks
This coordinate system lets you precisely place holograms near the anchor, with immediate updates when the device adjusts the anchor's precise location.

Use the corresponding [RawCoordinateSystemAdjusted](spatialanchor_rawcoordinatesystemadjusted.md) event to react when anchor adjustments occur.

## -examples

## -see-also
