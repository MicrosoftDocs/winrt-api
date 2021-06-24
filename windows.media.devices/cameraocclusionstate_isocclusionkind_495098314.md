---
-api-id: M:Windows.Media.Devices.CameraOcclusionState.IsOcclusionKind(Windows.Media.Devices.CameraOcclusionKind)
-api-type: winrt method
---

# Windows.Media.Devices.CameraOcclusionState.IsOcclusionKind(Windows.Media.Devices.CameraOcclusionKind)

<!--
public bool IsOcclusionKind (Windows.Media.Devices.CameraOcclusionKind occlusionKind);
-->


## -description

Gets a value than indicates whether the current occlusion state is of the specified kind.

## -parameters

### -param occlusionKind

A member of the [CameraOcclusionKind](cameraocclusionkind.md) enumeration specifying the kind of occlusion being queried.

## -returns

True if the current occlusion is of the specified kind; otherwise, false.

## -remarks

A device may not support any or all occlusion types. If an occlusion type is unsupported, **IsOcclusionKind** will never return true for that occlusion type. Determine if an occlusion kind is supported by the camera device by calling [IsOcclusionKindSupported](cameraocclusioninfo_isocclusionkindsupported_1486521484.md).

## -see-also

[IsOcclusionKindSupported](cameraocclusioninfo_isocclusionkindsupported_1486521484.md), [CameraOcclusionKind](cameraocclusionkind.md) 

## -examples


