---
-api-id: M:Windows.Perception.Spatial.SpatialCoordinateSystem.TryGetTransformTo(Windows.Perception.Spatial.SpatialCoordinateSystem)
-api-type: winrt method
-api-device-family-note: xbox
---

<!-- Method syntax
public Windows.Foundation.IReference<Windows.Foundation.Numerics.Matrix4x4> TryGetTransformTo(Windows.Perception.Spatial.SpatialCoordinateSystem target)
-->

# Windows.Perception.Spatial.SpatialCoordinateSystem.TryGetTransformTo

## -description
Provides a transform matrix that you can use to convert geometry expressed in one coordinate system to another coordinate system.

## -parameters
### -param target
The target coordinate system that you want to transform geometry to.

## -returns
If the transformation is successful, this parameter returns the [Matrix4x4](/dotnet/api/system.numerics.matrix4x4?view=dotnet-uwp-10.0&preserve-view=true) structure that you can use to transform geometry from being represented in the source [SpatialCoordinateSystem](spatialcoordinatesystem.md) to the specified target coordinate system.

## -remarks
This method will return null if the target coordinate system cannot be located relative to this one at the moment.

## -examples

See [Camera stream coordinate mapper sample](/samples/microsoft/windows-universal-samples/camerastreamcoordinatemapper/), [Camera stream correlation sample](/samples/microsoft/windows-universal-samples/camerastreamcorrelation/), [Holographic face tracking sample](/samples/microsoft/windows-universal-samples/holographicfacetracking/), [Holographic spatial mapping sample](/samples/microsoft/windows-universal-samples/holographicspatialmapping/), [Holographic spatial stage sample](/samples/microsoft/windows-universal-samples/holographicspatialstage/), and [Tag-along hologram sample](/samples/microsoft/windows-universal-samples/holographictagalong/).

## -see-also

[Camera stream coordinate mapper sample](/samples/microsoft/windows-universal-samples/camerastreamcoordinatemapper/), [Camera stream correlation sample](/samples/microsoft/windows-universal-samples/camerastreamcorrelation/), [Holographic face tracking sample](/samples/microsoft/windows-universal-samples/holographicfacetracking/), [Holographic spatial mapping sample](/samples/microsoft/windows-universal-samples/holographicspatialmapping/), [Holographic spatial stage sample](/samples/microsoft/windows-universal-samples/holographicspatialstage/), [Tag-along hologram sample](/samples/microsoft/windows-universal-samples/holographictagalong/)
