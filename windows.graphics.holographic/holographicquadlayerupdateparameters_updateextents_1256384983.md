---
-api-id: M:Windows.Graphics.Holographic.HolographicQuadLayerUpdateParameters.UpdateExtents(Windows.Foundation.Numerics.Vector2)
-api-type: winrt method
---

<!-- Method syntax.
public void HolographicQuadLayerUpdateParameters.UpdateExtents(Vector2 value)
-->

# Windows.Graphics.Holographic.HolographicQuadLayerUpdateParameters.UpdateExtents

## -description
Updates the extents of this quad layer in world coordinates.

## -parameters
### -param value
The full width and height of the quad layer in meters.

## -remarks
You must also call [UpdateLocationWithDisplayRelativeMode](holographicquadlayerupdateparameters_updatelocationwithdisplayrelativemode_881203171.md) or [UpdateLocationWithStationaryMode](holographicquadlayerupdateparameters_updatelocationwithstationarymode_1099037134.md) to specify the center point for the quad layer.  The quad will be displayed centered around that location, with its full width and height specified by these extents.

Note that these extents are distinct from the HolographicQuadLayer's [Size](holographicquadlayer_size.md) property, which defines the pixel size of the texture that backs the quad.

## -see-also

## -examples

