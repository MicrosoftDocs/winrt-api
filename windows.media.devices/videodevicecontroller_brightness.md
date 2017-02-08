---
-api-id: P:Windows.Media.Devices.VideoDeviceController.Brightness
-api-type: winrt property
---

<!-- Property syntax
public Windows.Media.Devices.MediaDeviceControl Brightness { get; }
-->

# Windows.Media.Devices.VideoDeviceController.Brightness

## -description
Gets a [MediaDeviceControl](mediadevicecontrol.md) object that can be used to get or set the brightness level on the camera.

## -property-value
A [MediaDeviceControl](mediadevicecontrol.md) object that provides methods to get and set the brightness.

## -remarks
For NTSC sources, brightness is expressed in IRE units multiplied by 100. For non-NTSC sources, the units are arbitrary, with 0 representing blanking and 10000 representing pure white.

For more information on getting or setting this value, see [MediaDeviceControl](mediadevicecontrol.md).

## -examples

## -see-also
[MediaDeviceControl](mediadevicecontrol.md)