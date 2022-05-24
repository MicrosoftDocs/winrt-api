---
-api-id: T:Windows.Media.Capture.MediaCaptureDeviceExclusiveControlReleaseMode
-api-type: winrt enum
---

# Windows.Media.Capture.MediaCaptureDeviceExclusiveControlReleaseMode

<!--
public enum MediaCaptureDeviceExclusiveControlReleaseMode
-->


## -description

Specifies the condition under which exclusive access to the camera is released.

## -enum-fields

### -field OnDispose: 0

Exclusive control is released when the associated camera object is disposed.

### -field OnAllStreamsStopped: 1

Exclusive control is released when all streams from the associated camera are stopped.

## -remarks

Obtain exclusive access to a camera by calling [TryAcquireExclusiveControl](xref:Windows.Media.Devices.VideoDeviceController.TryAcquireExclusiveControl(System.String,Windows.Media.Capture.MediaCaptureDeviceExclusiveControlReleaseMode).

## -see-also

## -examples


