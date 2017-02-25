---
-api-id: T:Windows.Media.Capture.MediaCaptureDeviceExclusiveControlStatus
-api-type: winrt enumeration
---

<!-- Enumeration syntax.
public enum MediaCaptureDeviceExclusiveControlStatus : int {
	ExclusiveControlAvailable = 0
	SharedReadOnlyAvailable = 1
}
-->

# Windows.Media.Capture.MediaCaptureDeviceExclusiveControlStatus

## -description
Specifies the exclusive control status of the media capture device. Exclusive control is required to modify the settings of the capture device, but is not required to obtain media frames from the device.

## -enum-fields

## -field SharedReadOnlyAvailable:1
Another app has exclusive control of the capture device, so the current app can't obtain exclusive control.

## -field ExclusiveControlAvailable:0
The current app can initialize the capture device with exclusive control.

## -remarks

## -see-also

## -examples

