---
-api-id: T:Windows.Media.Capture.Frames.MediaFrameSourceSetPropertyStatus
-api-type: winrt enum
---

<!-- Enumeration syntax
public enum Windows.Media.Capture.Frames.MediaFrameSourceSetPropertyStatus : int
-->

# MediaFrameSourceSetPropertyStatus

## -description
Specifies the result of a [MediaFrameSourceController.SetPropertyAsync](mediaframesourcecontroller_setpropertyasync.md) operation.

## -enum-fields
### -field Success:0
The operation was successful.

### -field UnknownFailure:1
The operation failed for an unknown reason.

### -field NotSupported:2
The operation failed because specified property is not supported by the media frame source.

### -field InvalidValue:3
The operation failed because the supplied value is not valid for the specified property.

### -field DeviceNotAvailable:4
The operation failed because the media frame source device is unavailable.

### -field NotInControl:5
The operation failed because the media frame source was not opened with [SharingMode](../windows.media.capture/mediacaptureinitializationsettings_sharingmode.md) set to [ExclusiveControl](../windows.media.capture/mediacapturesharingmode.md).


## -remarks

## -examples

## -see-also