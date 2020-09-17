---
-api-id: M:Windows.Graphics.Holographic.HolographicCameraRenderingParameters.SetFocusPoint(Windows.Perception.Spatial.SpatialCoordinateSystem,Windows.Foundation.Numerics.Vector3)
-api-type: winrt method
-api-device-family-note: xbox
---

<!-- Method syntax
public void SetFocusPoint(Windows.Perception.Spatial.SpatialCoordinateSystem coordinateSystem, Windows.Foundation.Numerics.Vector3 position)
-->

# Windows.Graphics.Holographic.HolographicCameraRenderingParameters.SetFocusPoint

## -description
Sets the stationary point in the holographic space that the user will likely focus on for the current frame.

## -parameters
### -param coordinateSystem
The coordinate system of the position vector.

### -param position
The location of the focus point in the specified coordinate system.

## -remarks
There are two types of LSR your app can use - Planar LSR and Depth LSR. Planar LSR is used by HoloLens and Windows Mixed Reality devices. Depth LSR is available on HoloLens 2.

Planar LSR is the default mode where the platform stabilizes a single plane in the scene. This function allows you to specify that plane. If you set a manual focus point, you must set it again each frame, or it will reset to its default.  Otherwise, the default focus point will be 2 meters away from the headset, with a normal facing the headset.

Depth LSR is obtained by calling [CommitDirect3D11DepthBuffer](holographiccamerarenderingparameters_commitdirect3d11depthbuffer_1424767526.md). Your app will generally achieve optimal visual quality by calling CommitDirect3D11DepthBuffer to commit an accurate depth buffer whose pixels can be mapped back to meters using your specified near and far planes.

LSR will use head velocity and stabilize things to the world, but if the application knows that something is moving through the scene and that the user is following it, then the FocusPoint velocity can be used to stabilize things to that moving object. 

If your app is using Depth LSR, SetFocusPoint is still important if you wish to stabilize to a moving object in the scene. 

## -examples

## -see-also

[CommitDirect3D11DepthBuffer](holographiccamerarenderingparameters_commitdirect3d11depthbuffer_1424767526.md)