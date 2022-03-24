---
-api-id: P:Windows.Media.Devices.VideoDeviceController.HdrVideoControl
-api-type: winrt property
---

<!-- Property syntax
public Windows.Media.Devices.HdrVideoControl HdrVideoControl { get; }
-->

# Windows.Media.Devices.VideoDeviceController.HdrVideoControl

## -description
Gets the [HdrVideoControl](hdrvideocontrol.md) associated with the [VideoDeviceController](videodevicecontroller.md). This allows you to enable and disable High Dynamic Range (HDR) video capture mode on devices that support it.

## -property-value
This control requires that the stream is at a stopped state before the value is set, see [KSPROPERTY_CAMERACONTROL_EXTENDED_VIDEOHDR](/windows-hardware/drivers/stream/ksproperty-cameracontrol-extended-videohdr). The [HdrVideoControl](hdrvideocontrol.md) associated with the [VideoDeviceController](videodevicecontroller.md).

## -remarks
For how-to guidance and sample code for using HDR video capture, see [Manual camera controls for video capture](/windows/uwp/audio-video-camera/capture-device-controls-for-video-capture).

## -examples

## -see-also
