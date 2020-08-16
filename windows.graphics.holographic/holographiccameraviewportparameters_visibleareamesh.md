---
-api-id: P:Windows.Graphics.Holographic.HolographicCameraViewportParameters.VisibleAreaMesh
-api-type: winrt property
---

<!-- Property syntax.
public Vector2[] VisibleAreaMesh { get; }
-->

# Windows.Graphics.Holographic.HolographicCameraViewportParameters.VisibleAreaMesh

## -description
Gets vertices in NDC space that define the viewport area the user can see, given the headset's lens geometry.

## -property-value
The visible area mesh vertices.

## -remarks
An app can improve performance by only rendering to the pixels covered by the visible area mesh.

If it is more convenient to reason about the hidden area rather than the visible area, inspect the [HiddenAreaMesh](holographiccameraviewportparameters_hiddenareamesh.md) property instead.

## -see-also

## -examples

