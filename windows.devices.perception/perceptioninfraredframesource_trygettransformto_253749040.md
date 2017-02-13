---
-api-id: M:Windows.Devices.Perception.PerceptionInfraredFrameSource.TryGetTransformTo(System.String,Windows.Foundation.Numerics.Matrix4x4@)
-api-type: winrt method
---

<!-- Method syntax
public bool TryGetTransformTo(System.String targetId, Windows.Foundation.Numerics.Matrix4x4 result)
-->

# Windows.Devices.Perception.PerceptionInfraredFrameSource.TryGetTransformTo

## -description
Gets the transform from the infrared frame source to the target entity and sets hasResult to true, if a correlation exists. If a correlation does not exist, hasResult is set to false and result is not modified.

## -parameters
### -param targetId
The unique ID of the target entity.

### -param result
If a correlation exists, this will be set to a 4x4 transform matrix that changes basis from the infrared frame source coordinate system to the target entity coordinate system.

## -returns
True if a correlation exists, otherwise false.

## -remarks

## -examples

## -see-also
