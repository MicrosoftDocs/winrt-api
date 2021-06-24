---
-api-id: T:Windows.Media.Devices.CameraOcclusionKind
-api-type: winrt enum
---

# Windows.Media.Devices.CameraOcclusionKind

<!--
public enum CameraOcclusionKind
-->


## -description

Specifies the kind of occlusion that is blocking a camera.

## -enum-fields

### -field Lid: 0

The camera is occluded by the lid of the device.

### -field CameraHardware: 1

The camera is occluded by camera hardware.

## -remarks

A device may not support any or all occlusion types. If an occlusion type is unsupported, [CameraOcclusionState.IsOcclusionKind](cameraocclusionstate_isocclusionkind_495098314.md) will never return true for that occlusion type. Determine if an occlusion kind is supported by the camera device by calling [IsOcclusionKindSupported](cameraocclusioninfo_isocclusionkindsupported_1486521484.md).

## -see-also

## -examples


