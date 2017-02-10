---
-api-id: P:Windows.Media.Devices.VideoDeviceController.Exposure
-api-type: winrt property
---

<!-- Property syntax
public Windows.Media.Devices.MediaDeviceControl Exposure { get; }
-->

# Windows.Media.Devices.VideoDeviceController.Exposure

## -description
Gets a [MediaDeviceControl](mediadevicecontrol.md) object that can be used to get or set the camera's exposure time.

## -property-value
A [MediaDeviceControl](mediadevicecontrol.md) object that provides methods to get and set the exposure time.

## -remarks
Exposure is specified in log base 2 seconds. For values less than zero, the exposure time is 1/(2<sup>n</sup>) seconds. For values of zero and above, the exposure time is 2<sup>n</sup> seconds.

For more information on getting or setting this value, see [MediaDeviceControl](mediadevicecontrol.md).

## -examples

## -see-also
[MediaDeviceControl](mediadevicecontrol.md)