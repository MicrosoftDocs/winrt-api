---
-api-id: T:Windows.Media.Devices.MediaDeviceControl
-api-type: winrt class
---

<!-- Class syntax.
public class MediaDeviceControl : Windows.Media.Devices.IMediaDeviceControl
-->

# Windows.Media.Devices.MediaDeviceControl

## -description
Gets or sets a device setting on a camera.

## -remarks
Various properties on the [VideoDeviceController](videodevicecontroller.md) object returns instances of the MediaDeviceControl object. Each [VideoDeviceController](videodevicecontroller.md) property represents a particular setting on the camera, such as brightness or focus. Use the MediaDeviceControl object to: 
+ Get or set the camera setting.
+ Enable automatic adjustment of the setting.
+ Get the range of values that the camera supports for the setting.

<!-- confirmed -->
> [!NOTE]
> This class is not agile, which means that you need to consider its threading model and marshaling behavior. For more info, see [Threading and Marshaling (C++/CX)](/cpp/cppcx/threading-and-marshaling-c-cx) and [Using Windows Runtime objects in a multithreaded environment (.NET)](/windows/uwp/threading-async/using-windows-runtime-objects-in-a-multithreaded-environment).

## -examples

For examples of setting media device controllers, see [Manual camera controls for photo and video capture](/windows/uwp/audio-video-camera/capture-device-controls-for-photo-and-video-capture)

## -see-also