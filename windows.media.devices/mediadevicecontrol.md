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


> [!NOTE]
> : This class is not agile, which means that you need to consider its threading model and marshaling behavior. For more info, see [Threading and Marshaling (C++/CX)](https://go.microsoft.com/fwlink/p/?linkid=258275) and [Using Windows Runtime objects in a multithreaded environment (.NET)](https://go.microsoft.com/fwlink/p/?linkid=258277).

## -examples
The following example shows how to get the [Brightness](videodevicecontroller_brightness.md) on a [VideoDeviceController](videodevicecontroller.md). Note that [Brightness](videodevicecontroller_brightness.md) is a [MediaDeviceController](imediadevicecontroller.md).



[!code-js[VideoDeviceController_Brightness](../windows.media.devices/code/VideoDeviceController/javascript/default.js#SnippetVideoDeviceController_Brightness)]

## -see-also
