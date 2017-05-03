---
-api-id: M:Windows.Graphics.Printing3D.Printing3DModel.TryReduceFacesAsync(Windows.Graphics.Printing3D.Printing3DFaceReductionOptions)
-api-type: winrt method
-api-device-family-note: xbox
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperationWithProgress<bool, double> TryReduceFacesAsync(Windows.Graphics.Printing3D.Printing3DFaceReductionOptions printing3DFaceReductionOptions)
-->

# Windows.Graphics.Printing3D.Printing3DModel.TryReduceFacesAsync

## -description
Runs an algorithm that reduces the number of triangle faces in all of the meshes within the [Printing3DModel](printing3dmodel.md) by merging nearby vertices. Stops according to the specified options.

## -parameters
### -param printing3DFaceReductionOptions
Defines the conditions which will trigger the end of the operation.

## -returns
A **Boolean** value indicating whether the asynchronous operation succeeded, and a **Double** value reporting the progress as a decimal number between zero and one.

## -remarks

## -examples

## -see-also
[TryReduceFacesAsync](printing3dmodel_tryreducefacesasync_2097932692.md), [TryReduceFacesAsync(Printing3DFaceReductionOptions, TimeSpan)](printing3dmodel_tryreducefacesasync_1526716101.md)