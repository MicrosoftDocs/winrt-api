---
-api-id: T:Windows.Media.Capture.Frames.MediaFrameSourceGetPropertyStatus
-api-type: winrt enum
---

<!-- Enumeration syntax
public enum Windows.Media.Capture.Frames.MediaFrameSourceGetPropertyStatus : int
-->

# MediaFrameSourceGetPropertyStatus

## -description
Specifies the result of a [MediaFrameSourceController.GetPropertyAsync](mediaframesourcecontroller_getpropertyasync_1561087689.md) or [MediaFrameSourceController.GetPropertyByExtendedIdAsync](mediaframesourcecontroller_getpropertybyextendedidasync_2013722339.md) operation.

## -enum-fields
### -field Success:0
The operation was successful.

### -field UnknownFailure:1
The operation failed for an unknown reason.

### -field NotSupported:2
The operation failed because specified property is not supported by the media frame source.

### -field DeviceNotAvailable:3
The operation failed because the media frame source device is unavailable.

### -field MaxPropertyValueSizeTooSmall:4
The *maxPropertyValueSize* provided in the call to [MediaFrameSourceController.GetPropertyByExtendedIdAsync](mediaframesourcecontroller_getpropertybyextendedidasync_2013722339.md) is too small for the property value.

### -field MaxPropertyValueSizeRequired:5
The *maxPropertyValueSize* parameter to [MediaFrameSourceController.GetPropertyByExtendedIdAsync](mediaframesourcecontroller_getpropertybyextendedidasync_2013722339.md) is required.

## -remarks

### Version history

| Windows version | SDK version | Value added |
| -- | -- | -- |
| 1703 | 15063 | MaxPropertyValueSizeRequired |
| 1703 | 15063 | MaxPropertyValueSizeTooSmall |

## -examples

## -see-also







