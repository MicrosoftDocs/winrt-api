---
-api-id: M:Windows.Graphics.Printing3D.Printing3DModel.TryReduceFacesAsync
-api-type: winrt method
-api-device-family-note: xbox
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperationWithProgress<bool, double> TryReduceFacesAsync()
-->

# Windows.Graphics.Printing3D.Printing3DModel.TryReduceFacesAsync

## -description
Runs an algorithm that reduces the number of triangle faces in all of the meshes within the [Printing3DModel](printing3dmodel.md) by merging nearby vertices. Stops when the total number of triangles is reduced by half.

## -returns
A **Boolean** value indicating whether the asynchronous operation succeeded, and a **Double** value reporting the progress as a decimal number between zero and one.

## -remarks

## -examples

## -see-also
[TryReduceFacesAsync(Printing3DFaceReductionOptions)](printing3dmodel_tryreducefacesasync_811294173.md), [TryReduceFacesAsync(Printing3DFaceReductionOptions, TimeSpan)](printing3dmodel_tryreducefacesasync_1526716101.md)