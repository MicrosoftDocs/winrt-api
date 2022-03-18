---
-api-id: M:Windows.Media.Devices.VideoDeviceController.SetMediaStreamPropertiesAsync(Windows.Media.Capture.MediaStreamType,Windows.Media.MediaProperties.IMediaEncodingProperties)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncAction SetMediaStreamPropertiesAsync(Windows.Media.Capture.MediaStreamType mediaStreamType, Windows.Media.MediaProperties.IMediaEncodingProperties mediaEncodingProperties)
-->

# Windows.Media.Devices.VideoDeviceController.SetMediaStreamPropertiesAsync

## -description
Sets the encoding properties asynchronously for the specified media stream type for the video device.

## -parameters
### -param mediaStreamType
The type of media stream for which to set the properties.

### -param mediaEncodingProperties
The encoding properties to set.

## -returns
An [IAsyncAction](../windows.foundation/iasyncaction.md) object that is used to control the asynchronous operation.

## -remarks
This method sets the properties on the media source, which is the video capture device. This is unlike [MediaCapture.SetEncodingPropertiesAsync](../windows.media.capture/mediacapture_setencodingpropertiesasync_1218555455.md), which changes the properties of the media encoding. For this reason, with **SetMediaStreamPropertiesAsync** you can only set properties and values that are supported natively by the capture device. Get a list of a capture device's supported resolutions, frame rates, and other properties by calling [GetAvailableMediaStreamProperties](videodevicecontroller_getavailablemediastreamproperties_946867392.md). The benefit of setting the capture device properties instead of the media encoding is that the device only needs to generate enough data for the specified resolution, which can provide better performance than capturing at a high resolution and then downscaling at another point in the media capture pipeline. For more information, see [Set format, resolution, and frame rate for MediaCapture](/windows/uwp/audio-video-camera/set-media-encoding-properties) and the [Camera Resolution Sample](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/CameraResolution).

## -examples

## -see-also
[Set format, resolution, and frame rate for MediaCapture](/windows/uwp/audio-video-camera/set-media-encoding-properties), [Camera Resolution Sample](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/CameraResolution)
