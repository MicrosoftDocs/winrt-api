---
-api-id: T:Windows.Media.Capture.Frames.MultiSourceMediaFrameReaderStartStatus
-api-type: winrt enumeration
---

<!-- Enumeration syntax.
public enum MultiSourceMediaFrameReaderStartStatus : int {
	DeviceNotAvailable = 3
	InsufficientResources = 2
	NotSupported = 1
	Success = 0
	UnknownFailure = 4
}
-->

# Windows.Media.Capture.Frames.MultiSourceMediaFrameReaderStartStatus

## -description
Specifies the status of a [MultiSourceMediaFrameReader](multisourcemediaframereader.md) start operation. A value from this enumeration is returned by the [MultiSourceMediaFrameReader.StartAsync](multisourcemediaframereader_startasync_1931900819.md) method.

## -enum-fields

.

## -field Success:0
The frame reader was started successfully.

## -field NotSupported:1
[MultiSourceMediaFrameReader](multisourcemediaframereader.md) is not supported for the current device.

## -field InsufficientResources:2
The reader could not be started due to insufficient system resources.

## -field DeviceNotAvailable:3
The reader could not be started because the capture device is unavailable.

## -field UnknownFailure:4
There was an unknown failure

## -remarks

## -see-also

## -examples

