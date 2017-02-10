---
-api-id: M:Windows.Devices.Perception.PerceptionColorFrameSource.TryGetDepthCorrelatedCoordinateMapperAsync(System.String,Windows.Devices.Perception.PerceptionDepthFrameSource)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperation<Windows.Devices.Perception.PerceptionDepthCorrelatedCoordinateMapper> TryGetDepthCorrelatedCoordinateMapperAsync(System.String targetSourceId, Windows.Devices.Perception.PerceptionDepthFrameSource correlatedDepthFrameSource)
-->

# Windows.Devices.Perception.PerceptionColorFrameSource.TryGetDepthCorrelatedCoordinateMapperAsync

## -description
Attempts to get a coordinate mapper that maps from color frame image space to depth frame space.

## -parameters
### -param targetSourceId
The unique ID of the depth frame source to try to map to.

### -param correlatedDepthFrameSource
The depth frame source to try to map to. This should be in a correlation group with the color frame source.

## -returns
If the two sources are correlated, this method returns a PerceptionDepthCorrelatedCoordinateMapper. Otherwise, it returns null. This method returns asynchronously.

## -remarks

## -examples

## -see-also
