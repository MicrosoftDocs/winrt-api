---
-api-id: T:Windows.Media.Devices.MediaCapturePauseBehavior
-api-type: winrt enum
---

<!-- Enumeration syntax
public enum Windows.Media.Devices.MediaCapturePauseBehavior : int
-->

# MediaCapturePauseBehavior

## -description
Defines the behavior when media capture is paused with a call to [PauseAsync](../windows.media.capture/lowlagmediarecording_pauseasync_622665789.md) or [PauseRecordAsync](../windows.media.capture/mediacapture_pauserecordasync_1650376226.md).

## -enum-fields
### -field RetainHardwareResources:0
The calling app keeps control of the hardware resources, such as the camera, while capturing is paused.

### -field ReleaseHardwareResources:1
The hardware resources are released while capturing is paused.


## -remarks

## -examples

## -see-also