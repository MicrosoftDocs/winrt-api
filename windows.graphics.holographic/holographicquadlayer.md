---
-api-id: T:Windows.Graphics.Holographic.HolographicQuadLayer
-api-type: winrt class
---

<!-- Class syntax.
public class HolographicQuadLayer : IClosable
-->

# Windows.Graphics.Holographic.HolographicQuadLayer

## -description
Represents a retained texture for the system to display at a specified location on top of the app's primary rendered content.

## -remarks
A quad layer is a texture that the system’s holographic compositor will render on behalf of the app at a specific location in the world.  This allows the compositor to directly sample from that quad texture when producing the final composited image, improving text quality and allowing for lower-resolution world content.  Unlike the primary layer's immediate-mode back buffer, which must be filled each frame, quad layers are retained.  Once added to a given HolographicCamera, each quad layer will continue to render at its specified location on top of that frame's primary layer back buffer until the quad layer is moved, updated or removed.

To display quad layers, an app creates the necessary HolographicQuadLayer instances and adds them to a HolographicCamera's mutable [QuadLayers](holographiccamera_quadlayers.md) list.  To synchronize a retained quad layer update with a given immediate-mode holographic frame, an app requests a [HolographicQuadLayerUpdateParameters](holographicquadlayerupdateparameters.md) instance from that frame by calling [HolographicFrame.GetQuadLayerUpdateParameters](holographicframe_getquadlayerupdateparameters_1786338093.md).  Any updates requested on that HolographicQuadLayerUpdateParameters instance will apply starting in that frame.

Apps may position quad layers in a stationary mode or display-relative mode, which affects how they are positioned in future frames if not moved explicitly:
* For a stationary quad, the app calls [UpdateLocationWithStationaryMode](holographicquadlayerupdateparameters_updatelocationwithstationarymode_1099037134.md) to specify the spatial position and orientation in the world at which a quad layer should appear.  This defines a plane, along with the 2D size of the quad in that plane centered around the specified position.
* For a display-relative quad, the app calls [UpdateLocationWithDisplayRelativeMode](holographicquadlayerupdateparameters_updatelocationwithdisplayrelativemode_881203171.md) to specify the spatial position and orientation in world coordinates relative to the display.

Quad layers are rendered in the specified order using the painter’s algorithm, entirely on top of the primary layer.  No depth-testing is done while rendering.  An app that moves one quad in front of another may reorder the quads in the layer list without having to refill the texture buffers.  An app that only wishes to render quad layers, for example during loading scenes, can disable the primary layer entirely by setting [IsPrimaryLayerEnabled](holographiccamera_isprimarylayerenabled.md) to false.

If an app no longer needs a quad layer, it may disable that layer by removing it from the camera, which allows the system to reclaim the content buffers allocated for it.  If the app knows it is permanently done with a layer, it may close it entirely.

Note that HolographicQuadLayer objects may use and retain device-based resources.  It is better to create a HolographicQuadLayer once and re-use it as much as possible, as opposed to creating and disposing of them - for example, every time a menu is brought up. HolographicQuadLayer objects should be disposed of and recreated in Direct3D device lost scenarios.

## -see-also

## -examples

