---
-api-id: M:Windows.Graphics.Printing3D.Printing3DModel.TryReduceFacesAsync(Windows.Graphics.Printing3D.Printing3DFaceReductionOptions,Windows.Foundation.TimeSpan)
-api-type: winrt method
-api-device-family-note: xbox
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperationWithProgress<bool, double> TryReduceFacesAsync(Windows.Graphics.Printing3D.Printing3DFaceReductionOptions printing3DFaceReductionOptions, Windows.Foundation.TimeSpan maxWait)
-->

# Windows.Graphics.Printing3D.Printing3DModel.TryReduceFacesAsync

## -description
Runs an algorithm that reduces the number of triangle faces in all of the meshes within the [Printing3DModel](printing3dmodel.md) by merging nearby vertices. Stops according to the specified options or when the *maxWait* time is reached.

## -parameters
### -param printing3DFaceReductionOptions
Defines the conditions which will trigger the end of the operation.

### -param maxWait
Defines the amount of time (in seconds) that the algorithm can run for. A value of 0 will cause the algorithm to run until another end condition is met.

## -returns
A **Boolean** value indicating whether the asynchronous operation succeeded, and a **Double** value reporting the progress as a decimal number between zero and one.

## -remarks

## -examples

## -see-also
[TryReduceFacesAsync](printing3dmodel_tryreducefacesasync_2097932692.md), [TryReduceFacesAsync(Printing3DFaceReductionOptions)](printing3dmodel_tryreducefacesasync_811294173.md)