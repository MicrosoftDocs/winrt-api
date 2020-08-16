---
-api-id: T:Windows.Media.Capture.Frames.MediaFrameReaderStartStatus
-api-type: winrt enum
---

<!-- Enumeration syntax
public enum Windows.Media.Capture.Frames.MediaFrameReaderStartStatus : int
-->

# MediaFrameReaderStartStatus

## -description
Specifies the result of a call to [StartAsync](mediaframereader_startasync_1931900819.md) to start the reading of media frames by a MediaFrameReader.

## -enum-fields
### -field Success:0
The operation was successful.

### -field UnknownFailure:1
The operation failed for an unknown reason.

### -field DeviceNotAvailable:2
The operation failed because the media frame source device is unavailable.

### -field OutputFormatNotSupported:3
The operation failed because the requested output format is not supported by the media frame source.

### -field ExclusiveControlNotAvailable:4
The operation failed because exclusive control of the media frame source device is unavailable.

## -remarks

### Version history

| Windows version | SDK version | Value added |
| -- | -- | -- |
| 1703 | 15063 | ExclusiveControlNotAvailable |

## -examples

## -see-also



