---
-api-id: M:Windows.Media.Devices.CameraOcclusionInfo.IsOcclusionKindSupported(Windows.Media.Devices.CameraOcclusionKind)
-api-type: winrt method
---

# Windows.Media.Devices.CameraOcclusionInfo.IsOcclusionKindSupported(Windows.Media.Devices.CameraOcclusionKind)

<!--
public bool IsOcclusionKindSupported (Windows.Media.Devices.CameraOcclusionKind occlusionKind);
-->


## -description

Gets a boolean value indicating whether the specified occlusion kind is supported by the camera device.

## -parameters

### -param occlusionKind

A member of the [CameraOcclusionKind](cameraocclusionkind.md) enumeration specifying the occlusion kind for which support is being queried.

## -returns

True if the specified occlusion kind is supported by the capture devices; otherwise, false.

## -remarks

A device may not support any or all occlusion types. If an occlusion type is unsupported, [CameraOcclusionState.IsOcclusionKind](cameraocclusionstate_isocclusionkind_495098314.md) will never return true for that occlusion type.

## -see-also

[CameraOcclusionKind](cameraocclusionkind.md), [CameraOcclusionState.IsOcclusionKind](cameraocclusionstate_isocclusionkind_495098314.md)

## -examples


