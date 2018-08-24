---
-api-id: P:Windows.Graphics.Printing3D.Printing3DFaceReductionOptions.MaxEdgeLength
-api-type: winrt property
-api-device-family-note: xbox
---

<!-- Property syntax
public double MaxEdgeLength { get;  set; }
-->

# Windows.Graphics.Printing3D.Printing3DFaceReductionOptions.MaxEdgeLength

## -description
Sets the maximum length of an edge for which the triangles that share said edge can be merged via the [TryReduceFacesAsync](printing3dmodel_tryreducefacesasync_1526716101.md) method. If set to zero, a built-in default value is used.

## -property-value
Maximum length of an edge for which the triangles that share said edge can be merged.

## -remarks
The units of length are derived from the [Unit](printing3dmodel_unit.md) property in the [Printing3DModel](printing3dmodel.md) object from which [TryReduceFacesAsync](/uwp/api/windows.graphics.printing3d.printing3dmodel.tryreducefacesasync) is called.

## -examples

## -see-also
