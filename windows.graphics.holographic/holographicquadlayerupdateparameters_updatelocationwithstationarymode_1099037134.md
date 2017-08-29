---
-api-id: M:Windows.Graphics.Holographic.HolographicQuadLayerUpdateParameters.UpdateLocationWithStationaryMode(Windows.Perception.Spatial.SpatialCoordinateSystem,Windows.Foundation.Numerics.Vector3,Windows.Foundation.Numerics.Quaternion)
-api-type: winrt method
---

<!-- Method syntax.
public void HolographicQuadLayerUpdateParameters.UpdateLocationWithStationaryMode(SpatialCoordinateSystem coordinateSystem, Vector3 position, Quaternion orientation)
-->

# Windows.Graphics.Holographic.HolographicQuadLayerUpdateParameters.UpdateLocationWithStationaryMode

## -description
Updates the center location of this quad layer in the world, setting it to remain at that world location in future frames.

## -parameters
### -param coordinateSystem
The reference SpatialCoordinateSystem object.

### -param position
A point for the center of the quad plane, specified relative to the origin of the reference coordinate system.

### -param orientation
A rotation for the normal of the quad plane, specified relative to the neutral orientation of the reference coordinate system.

## -remarks
For a stationary quad, the app calls UpdateLocationWithStationaryMode to specify the spatial position and orientation in the world at which a quad layer should appear.

Stationary quads will continue to be rendered in the same place if their position is not changed, as if placed in a stationary frame of reference.  To keep a quad more strongly anchored, for example to a spatial anchor or stage, the app must also update its location whenever that coordinate system adjusts.  For apps with anchored content, it will likely be most straightforward to just update each quad’s location each frame.

You must also call [UpdateExtents](holographicquadlayerupdateparameters_updateextents_1256384983.md) to specify the width and height of the quad layer, centered around this point.

## -see-also

## -examples

