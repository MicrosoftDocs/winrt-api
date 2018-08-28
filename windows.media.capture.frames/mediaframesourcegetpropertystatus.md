---
-api-id: T:Windows.Media.Capture.Frames.MediaFrameSourceGetPropertyStatus
-api-type: winrt enum
---

<!-- Enumeration syntax
public enum Windows.Media.Capture.Frames.MediaFrameSourceGetPropertyStatus : int
-->

# MediaFrameSourceGetPropertyStatus

## -description
Specifies the result of a [MediaFrameSourceController.GetPropertyAsync](mediaframesourcecontroller_getpropertyasync_1561087689.md) operation.

## -enum-fields
### -field Success:0
The operation was successful.

### -field UnknownFailure:1
The operation failed for an unknown reason.

### -field NotSupported:2
The operation failed because specified property is not supported by the media frame source.

### -field DeviceNotAvailable:3
The operation failed because the media frame source device is unavailable.


## -remarks

### Version history

| Version | SDK version | Value added |
| -- | -- | -- |
| 1703 | 15063 | MaxPropertyValueSizeRequired |
| 1703 | 15063 | MaxPropertyValueSizeTooSmall |

## -examples

## -see-also

### -field MaxPropertyValueSizeRequired:5



### -field MaxPropertyValueSizeTooSmall:4

