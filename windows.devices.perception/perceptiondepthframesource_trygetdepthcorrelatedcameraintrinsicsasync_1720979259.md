---
-api-id: M:Windows.Devices.Perception.PerceptionDepthFrameSource.TryGetDepthCorrelatedCameraIntrinsicsAsync(Windows.Devices.Perception.PerceptionDepthFrameSource)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperation<Windows.Devices.Perception.PerceptionDepthCorrelatedCameraIntrinsics> TryGetDepthCorrelatedCameraIntrinsicsAsync(Windows.Devices.Perception.PerceptionDepthFrameSource target)
-->

# Windows.Devices.Perception.PerceptionDepthFrameSource.TryGetDepthCorrelatedCameraIntrinsicsAsync

## -description
Attempts to get the intrinsic properties of the depth camera that is correlated with this depth source.

## -parameters
### -param target
The depth frame source to try to get intrinsic properties of.

## -returns
If the attempt is successful, this returns a read-only collection of PerceptionDepthCorrelatedCameraIntrinsics objects specifying the intrinsic properties of the camera used by the correlated depth frame source. Otherwise, this returns null.

## -remarks

## -examples

## -see-also
