---
-api-id: M:Windows.Devices.Perception.PerceptionDepthFrameSource.TryGetDepthCorrelatedCoordinateMapperAsync(System.String,Windows.Devices.Perception.PerceptionDepthFrameSource)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperation<Windows.Devices.Perception.PerceptionDepthCorrelatedCoordinateMapper> TryGetDepthCorrelatedCoordinateMapperAsync(System.String targetId, Windows.Devices.Perception.PerceptionDepthFrameSource depthFrameSourceToMapWith)
-->

# Windows.Devices.Perception.PerceptionDepthFrameSource.TryGetDepthCorrelatedCoordinateMapperAsync

## -description
Attempts to get a coordinate mapper that maps from depth frame image space to depth frame space.

## -parameters
### -param targetId
The unique ID of the depth frame source to try to map to.

### -param depthFrameSourceToMapWith
The depth frame source to try to map to. This should be in a correlation group with the depth frame source.

## -returns
If the two sources are correlated, this method returns a PerceptionDepthCorrelatedCoordinateMapper. Otherwise, it returns null. This method returns asynchronously.

## -remarks

## -examples

## -see-also
