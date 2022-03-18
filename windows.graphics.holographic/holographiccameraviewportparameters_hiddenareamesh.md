---
-api-id: P:Windows.Graphics.Holographic.HolographicCameraViewportParameters.HiddenAreaMesh
-api-type: winrt property
---

<!-- Property syntax.
public Vector2[] HiddenAreaMesh { get; }
-->

# Windows.Graphics.Holographic.HolographicCameraViewportParameters.HiddenAreaMesh

## -description
Gets vertices in NDC space that define the viewport area the user cannot see, given the headset's lens geometry.

## -property-value
The hidden area mesh vertices.

## -remarks
An app can improve performance by not rendering to the pixels covered by the hidden area mesh.

If it is more convenient to reason about the visible area rather than the hidden area, inspect the [VisibleAreaMesh](holographiccameraviewportparameters_visibleareamesh.md) property instead.

## -see-also

## -examples

