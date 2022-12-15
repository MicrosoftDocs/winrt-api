---
-api-id: M:Windows.Graphics.Printing3D.Printing3DModel.TryPartialRepairAsync(Windows.Foundation.TimeSpan)
-api-type: winrt method
-api-device-family-note: xbox
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperation<bool> TryPartialRepairAsync(Windows.Foundation.TimeSpan maxWaitTime)
-->

# Windows.Graphics.Printing3D.Printing3DModel.TryPartialRepairAsync

## -description
Begins the 3D model repair algorithm, but exits if the time limit is reached.

## -parameters
### -param maxWaitTime
Defines the amount of time (in seconds) that the algorithm can run for. A value of 0 will cause the algorithm to run until another end condition is met.

## -returns
**true** if the asynchronous operation succeeded; otherwise, **false**.

## -remarks
Until April 2022 Microsoft offered an online 3D Model Repair service. Please find information on alternative tools, such as 3D Builder, at this [address](https://3mf.io/blog/2022/04/microsoft-is-sunsetting-the-3mf-service/).

## -examples

## -see-also
[TryPartialRepairAsync](printing3dmodel_trypartialrepairasync_334555296.md)