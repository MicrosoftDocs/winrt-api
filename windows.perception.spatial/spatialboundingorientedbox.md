---
-api-id: T:Windows.Perception.Spatial.SpatialBoundingOrientedBox
-api-type: winrt struct
-api-device-family-note: xbox
---

<!-- Structure syntax.
public struct SpatialBoundingOrientedBox 
-->

# SpatialBoundingOrientedBox

## -description
An oriented bounding box in the user's surroundings, with coordinates expressed in meters.

## -struct-fields

### -field Center
The position of the center of the bounding box.
    

### -field Extents
The size of the bounding box along each axis, prior to rotation.
    

### -field Orientation
The rotation of the bounding box, relative to the coordinate system's axes.
    

## -remarks
The SpatialBoundingOrientedBox is defined by its center and extents, plus an orientation relative to the coordinate system's axes. Its coordinates are expressed in meters, and are meaningful in a specific coordinate system usually specified alongside the box.

## -examples

## -see-also