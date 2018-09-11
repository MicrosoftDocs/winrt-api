---
-api-id: P:Windows.Graphics.Printing3D.Printing3DFaceReductionOptions.TargetTriangleCount
-api-type: winrt property
-api-device-family-note: xbox
---

<!-- Property syntax
public uint TargetTriangleCount { get;  set; }
-->

# Windows.Graphics.Printing3D.Printing3DFaceReductionOptions.TargetTriangleCount

## -description
Sets the desired number of triangles on a mesh. The [TryReduceFacesAsync](/uwp/api/windows.graphics.printing3d.printing3dmodel.tryreducefacesasync) method will stop merging faces if the triangle count is less than or equal to this number. If set to zero, the algorithm will run until the number of triangles is reduced by half.

## -property-value
Desired number of triangles on a mesh.

## -remarks

## -examples

## -see-also
