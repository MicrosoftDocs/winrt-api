---
-api-id: P:Windows.Graphics.Printing3D.Printing3DFaceReductionOptions.MaxReductionArea
-api-type: winrt property
-api-device-family-note: xbox
---

<!-- Property syntax
public double MaxReductionArea { get;  set; }
-->

# Windows.Graphics.Printing3D.Printing3DFaceReductionOptions.MaxReductionArea

## -description
Sets the area of a triangle above which said triangle cannot be merged via the [TryReduceFacesAsync](printing3dmodel_tryreducefacesasync_1526716101.md) method. If set to zero, a built-in default value is used.

## -property-value
Maximum area at which a triangle can be merged.

## -remarks
The units of area are derived from the [Unit](printing3dmodel_unit.md) property in the [Printing3DModel](printing3dmodel.md) object from which [TryReduceFacesAsync](printing3dmodel_tryreducefacesasync_2097932692.md) is called.

## -examples

## -see-also
