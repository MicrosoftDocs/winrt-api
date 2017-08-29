---
-api-id: P:Windows.Graphics.Holographic.HolographicCamera.QuadLayers
-api-type: winrt property
---

<!-- Property syntax.
public IVector<HolographicQuadLayer> QuadLayers { get; }
-->

# Windows.Graphics.Holographic.HolographicCamera.QuadLayers

## -description
Gets the mutable list of quad layers to display on top of this camera's primary back buffer.

## -property-value
The quad layer list.

## -remarks
Quad layers are rendered in the specified order using the painter’s algorithm, entirely on top of the primary layer.  No depth-testing is done while rendering.  An app that moves one quad in front of another may reorder the quads in this list without having to refill the texture buffers.  An app that only wishes to render quad layers, for example during loading scenes, can disable the primary layer entirely by setting [IsPrimaryLayerEnabled](holographiccamera_isprimarylayerenabled.md) to false.

If an app no longer needs a quad layer, it may disable that layer by removing it from the camera, which allows the system to reclaim the content buffers allocated for it.  If the app knows it is permanently done with a layer, it may close it entirely.

## -see-also

## -examples

