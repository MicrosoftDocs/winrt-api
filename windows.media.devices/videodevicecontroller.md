---
-api-id: T:Windows.Media.Devices.VideoDeviceController
-api-type: winrt class
---

<!-- Class syntax.
public class VideoDeviceController : Windows.Media.Devices.IAdvancedVideoCaptureDeviceController, Windows.Media.Devices.IAdvancedVideoCaptureDeviceController2, Windows.Media.Devices.IAdvancedVideoCaptureDeviceController3, Windows.Media.Devices.IAdvancedVideoCaptureDeviceController4, Windows.Media.Devices.IMediaDeviceController, Windows.Media.Devices.IVideoDeviceController
-->

# Windows.Media.Devices.VideoDeviceController

## -description
Controls device settings on the camera.
<!--Note: In the method descriptions, I took the units from the documentation for PROPSETID_VIDCAP_VIDEOPROCAMP and PROPSETID_VIDCAP_CAMERACONTROL. As far as I can tell, the WinRT layer does no conversion of the values.-->

## -remarks
To get an instance of this object, retrieve the [MediaCapture.VideoDeviceController](../windows.media.capture/mediacapture_videodevicecontroller.md) property.

Some drivers may require that the camera device preview to be in a running state before it can determine which controls are supported by the [VideoDeviceController](../windows.media.capture/mediacapture_videodevicecontroller.md). If you check whether a certain control is supported by the [VideoDeviceController](../windows.media.capture/mediacapture_videodevicecontroller.md) before the preview stream is running, the control may be described as unsupported even though it is supported by the video device.

> [!NOTE]
> : This class is not agile, which means that you need to consider its threading model and marshaling behavior. For more info, see [Threading and Marshaling (C++/CX)](http://go.microsoft.com/fwlink/p/?linkid=258275) and [Using Windows Runtime objects in a multithreaded environment (.NET)](http://go.microsoft.com/fwlink/p/?linkid=258277).

## -examples

## -see-also