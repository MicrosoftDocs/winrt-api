---
-api-id: T:Windows.Perception.Spatial.SpatialBoundingFrustum
-api-type: winrt struct
-api-device-family-note: xbox
---

<!-- Structure syntax.
public struct SpatialBoundingFrustum 
-->

# SpatialBoundingFrustum

## -description
A bounding frustum in the user's surroundings defined as a set of 6 planes, with coordinates expressed in meters.

## -struct-fields

### -field Near
The near Plane defines the boundary for the closest content within the frustum.
    

### -field Far
The far Plane defines the boundary for the farthest content within the frustum.
    

### -field Right
The right Plane defines the boundary for the rightmost content within the frustum.
    

### -field Left
The left Plane defines the boundary for the leftmost content within the frustum.
    

### -field Top
The top Plane defines the boundary for the topmost content within the frustum.
    

### -field Bottom
The bottom Plane defines the boundary for the bottommost content within the frustum.
    

## -remarks
A frustum is a rectangular pyramid clipped by a near plane and a far plane. When used as a view frustum, the volume within the frustum represents the view of a camera.

The normals for the 6 planes each face out from the frustum, defining its volume. Its coordinates are expressed in meters, and are meaningful in a specific coordinate system usually specified alongside the frustum.

## -examples

## -see-also