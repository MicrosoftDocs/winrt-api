---
-api-id: T:Windows.Media.Devices.VideoDeviceControllerSetDevicePropertyStatus
-api-type: winrt enumeration
---

<!-- Enumeration syntax.
public enum VideoDeviceControllerSetDevicePropertyStatus : int {
	DeviceNotAvailable = 4
	InvalidValue = 3
	NotInControl = 5
	NotSupported = 2
	Success = 0
	UnknownFailure = 1
}
-->

# Windows.Media.Devices.VideoDeviceControllerSetDevicePropertyStatus

## -description
Specifies the status of an operation to set the value of a video device controller driver property.


## -enum-fields

## -field UnknownFailure:1
The operation failed due to an unknown failure.

## -field Success:0
The operation completed successfully.

## -field NotSupported:2
The operation failed because the specified property is not supported by the device.

## -field NotInControl:5
The operation failed because the app does not have exclusive control of the video capture device and is therefore not currently permitted to change the device settings. For more information, see [MediaCaptureInitializationSettings.SharingMode](../windows.media.capture/mediacaptureinitializationsettings_sharingmode.md).

## -field InvalidValue:3
The operation failed because the specified property value is invalid.

## -field DeviceNotAvailable:4
The operation failed because the device is not available.

## -remarks

## -see-also

## -examples

