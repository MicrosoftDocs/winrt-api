---
-api-id: T:Windows.Perception.Spatial.SpatialBoundingBox
-api-type: winrt struct
-api-device-family-note: xbox
---

<!-- Structure syntax.
public struct SpatialBoundingBox 
-->

# SpatialBoundingBox

## -description
An axis-aligned bounding box in the user's surroundings, with coordinates expressed in meters.

## -struct-fields

### -field Center
The position of the center of the bounding box.
    

### -field Extents
The distance from the center of the bounding box to its edges, along each axis.
    

## -remarks
The SpatialBoundingBox is defined by its center and extents, with its edges aligned to the X, Y, and Z axes. Its coordinates are expressed in meters, and are meaningful in a specific coordinate system usually specified alongside the box.

## -examples

## -see-also