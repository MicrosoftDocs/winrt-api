---
-api-id: M:Windows.Graphics.Holographic.HolographicCameraRenderingParameters.SetFocusPoint(Windows.Perception.Spatial.SpatialCoordinateSystem,Windows.Foundation.Numerics.Vector3,Windows.Foundation.Numerics.Vector3,Windows.Foundation.Numerics.Vector3)
-api-type: winrt method
-api-device-family-note: xbox
---

<!-- Method syntax
public void SetFocusPoint(Windows.Perception.Spatial.SpatialCoordinateSystem coordinateSystem, Windows.Foundation.Numerics.Vector3 position, Windows.Foundation.Numerics.Vector3 normal, Windows.Foundation.Numerics.Vector3 linearVelocity)
-->

# Windows.Graphics.Holographic.HolographicCameraRenderingParameters.SetFocusPoint

## -description
Sets the moving point in the holographic space that the user will focus on, as well as the normal for a focus plane through that point.

## -parameters
### -param coordinateSystem
The coordinate system of the position, normal and velocity vectors.

### -param position
The location of the focus point in the specified coordinate system.

### -param normal
The normal of the focus point in the specified coordinate system, if known. If there is no obvious normal, have it face the user.

### -param linearVelocity
The velocity vector of the focus point in the specified coordinate system.

## -remarks
Your app will generally achieve optimal visual quality by calling [CommitDirect3D11DepthBuffer](holographiccamerarenderingparameters_commitdirect3d11depthbuffer_1424767526.md) to commit an accurate depth buffer whose pixels can be mapped back to meters using your specified near and far planes and then not calling SetFocusPoint.

If you set a manual focus point, you must set it again each frame, or it will reset to its default.  Otherwise, the default focus point will be 2 meters away from the headset, with a normal facing the headset.

## -examples

## -see-also
* [CommitDirect3D11DepthBuffer](holographiccamerarenderingparameters_commitdirect3d11depthbuffer_1424767526.md)