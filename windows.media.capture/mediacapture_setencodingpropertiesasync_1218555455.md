---
-api-id: M:Windows.Media.Capture.MediaCapture.SetEncodingPropertiesAsync(Windows.Media.Capture.MediaStreamType,Windows.Media.MediaProperties.IMediaEncodingProperties,Windows.Media.MediaProperties.MediaPropertySet)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncAction SetEncodingPropertiesAsync(Windows.Media.Capture.MediaStreamType mediaStreamType, Windows.Media.MediaProperties.IMediaEncodingProperties mediaEncodingProperties, Windows.Media.MediaProperties.MediaPropertySet encoderProperties)
-->

# Windows.Media.Capture.MediaCapture.SetEncodingPropertiesAsync

## -description
Asynchronously sets the media encoding properties.

## -parameters
### -param mediaStreamType
The type of media data the stream represents, such as video or audio.

### -param mediaEncodingProperties
The properties for the media encoding.

### -param encoderProperties
The properties for the encoder.

## -returns
Object that is used to control the asynchronous operation.

## -remarks
This method sets the encoding properties of the encoder that processes the data before it’s passed on to a [CaptureElement](../windows.ui.xaml.controls/captureelement.md) to be displayed, written out to a [IRandomAccessStream](../windows.storage.streams/irandomaccessstream.md) or [StorageFile](../windows.storage/storagefile.md), or delivered to a custom media sink. This method does not change the configuration of the source of the data, which is the camera device. It is possible to set the encoding properties to a resolution that is not natively supported by the camera. In this case, the **MediaCapture** pipeline will use an encoder to perform the conversion to the requested format. Note that this conversion does consume system resources and can result in poor performance or even errors, especially on devices that with limited or no graphics acceleration. For typical scenarios, it is recommended that you choose a resolution supported by the camera that is closest to your desired resolution. You can get a list of a capture device's supported resolutions by calling [VideoDeviceController.GetAvailableMediaStreamProperties](../windows.media.devices/videodevicecontroller_getavailablemediastreamproperties_946867392.md). For more information, see [Set format, resolution, and frame rate for MediaCapture](/windows/uwp/audio-video-camera/set-media-encoding-properties) and the [Camera Resolution Sample](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/CameraResolution).

> [!NOTE]
> **SetEncodingPropertiesAsync** will only succeed when the default preview stream is in a streaming state, i.e. after [StartPreviewAsync](mediacapture_startpreviewasync_2139900609.md) has been called successfully. If **SetEncodingPropertiesAsync** is called while the **MediaCapture** object is streaming video from a [MediaFrameSource](/uwp/api/windows.media.capture.frames.mediaframesource) via a [MediaPlayerElement](/uwp/api/windows.ui.xaml.controls.mediaplayerelement) or [MediaFrameReader](/uwp/api/windows.media.capture.frames.mediaframereader), this call will fail.

To rotate the record or preview stream, use the **GUID** defined by [MF_MT_VIDEO_ROTATION](/windows/desktop/medfound/mf-mt-video-rotation) to add metadata to the stream. Note that this rotation is performed by the consumer of the stream, such as the **CaptureElement** or a video player app, while the actual pixels in the stream still retain their original orientation. For how-to guidance on handling orientation when using the camera, see [Handle device orientation with MediaCapture](/windows/uwp/audio-video-camera/handle-device-orientation-with-mediacapture).

To modify the properties of the capture device, use [VideoDeviceController.SetMediaStreamPropertiesAsync](../windows.media.devices/videodevicecontroller_setmediastreampropertiesasync_835261048.md).

## -examples

## -see-also
[GetAvailableMediaStreamProperties](../windows.media.devices/videodevicecontroller_getavailablemediastreamproperties_946867392.md), [SetMediaStreamPropertiesAsync](../windows.media.devices/videodevicecontroller_setmediastreampropertiesasync_835261048.md), [Set format, resolution, and frame rate for MediaCapture](/windows/uwp/audio-video-camera/set-media-encoding-properties), [Handle device orientation with MediaCapture](/windows/uwp/audio-video-camera/handle-device-orientation-with-mediacapture), [Camera Resolution Sample](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/CameraResolution)
## -capabilities
backgroundMediaRecording
