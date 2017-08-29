---
-api-id: M:Windows.Graphics.Holographic.HolographicQuadLayerUpdateParameters.UpdateLocationWithDisplayRelativeMode(Windows.Foundation.Numerics.Vector3,Windows.Foundation.Numerics.Quaternion)
-api-type: winrt method
---

<!-- Method syntax.
public void HolographicQuadLayerUpdateParameters.UpdateLocationWithDisplayRelativeMode(Vector3 position, Quaternion orientation)
-->

# Windows.Graphics.Holographic.HolographicQuadLayerUpdateParameters.UpdateLocationWithDisplayRelativeMode

## -description
Updates the center location of this quad layer relative to the center of the displays, setting it to remain at that display-relative location in future frames.

## -parameters
### -param position
A point for the center of the quad plane, specified relative to the center of the displays.

### -param orientation
A rotation for the normal of the quad plane, specified relative to a normal facing the displays.

## -remarks
For a display-relative quad, the app calls UpdateLocationWithDisplayRelativeMode to specify the spatial position and orientation in world coordinates relative to the center of the displays.

You must also call [UpdateExtents](holographicquadlayerupdateparameters_updateextents_1256384983.md) to specify the width and height of the quad layer, centered around this point.

## -see-also

## -examples

