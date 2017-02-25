---
-api-id: T:Windows.Media.Devices.VideoDeviceControllerGetDevicePropertyStatus
-api-type: winrt enumeration
---

<!-- Enumeration syntax.
public enum VideoDeviceControllerGetDevicePropertyStatus : int {
	BufferTooSmall = 2
	DeviceNotAvailable = 4
	MaxPropertyValueSizeRequired = 6
	MaxPropertyValueSizeTooSmall = 5
	NotSupported = 3
	Success = 0
	UnknownFailure = 1
}
-->

# Windows.Media.Devices.VideoDeviceControllerGetDevicePropertyStatus

## -description
Specifies the status of an operation to get the value of a video device controller driver property.

## -enum-fields

## -field UnknownFailure:1
The operation failed due to an unknown failure.

## -field Success:0
The operation completed successfully.

## -field NotSupported:3
The operation failed because the specified property is not supported by the device.

## -field MaxPropertyValueSizeTooSmall:5
The operation failed because the specified maximum property value size is too small for the property value. You can retry the operation with a larger maximum property value size.

## -field MaxPropertyValueSizeRequired:6
The operation failed because a maximum property value size is required for the specified property.

## -field DeviceNotAvailable:4
The operation failed because the device is not available.

## -field BufferTooSmall:2
The operation failed because the buffer containing the extended ID data for the property was smaller than expected by the device driver.

## -remarks

## -see-also

## -examples

