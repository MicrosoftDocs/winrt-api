---
-api-id: M:Windows.Media.Capture.MediaCapture.SetEncoderProperty(Windows.Media.Capture.MediaStreamType,System.Guid,System.Object)
-api-type: winrt method
---

<!-- Method syntax
public void SetEncoderProperty(Windows.Media.Capture.MediaStreamType mediaStreamType, System.Guid propertyId, System.Object propertyValue)
-->

# Windows.Media.Capture.MediaCapture.SetEncoderProperty

## -description
Sets an encoding property.

## -parameters
### -param mediaStreamType
The type of media data the stream represents, such as video or audio.

### -param propertyId
The encoding property to set.

### -param propertyValue
The new value of the encoding property.

## -remarks
You can only call SetEncoderProperty with *mediaStreamType* equal to [MediaStreamType.Audio](mediastreamtype.md), if the encoder property is applied to only the audio encoder in the record sink. The preview sink does not allow you to set an encoding profile with compressed audio.

For non-H.264 cameras, when you call SetEncoderProperty before recording or previewing has started, the property is stored locally. When you start recording, the property is applied to the encoder at the time of encoder initialization. To configure static encoding properties, you must call SetEncoderProperty before recording or previewing starts. Before recording or previewing starts, [GetEncoderProperty](mediacapture_getencoderproperty_769455038.md) will return the value of the property stored locally.

If the camera is a H.264 camera and the stream that SetEncoderProperty is called on is of type [MediaStreamType.VideoRecord](mediastreamtype.md), then the property is applied directly to the camera. This is true both before and after recording has started.

For non-H.264 cameras, when you call SetEncoderProperty after you get the record or preview started completion callback, the property is set directly on the encoder and is therefore used to configure dynamic encoding properties.

If you call SetEncoderProperty after you issue a call to start recording or previewing and before you get the record or preview started completion callback, you will receive an **MF_E_INVALIDREQUEST** error since the property cannot be applied to static nor dynamic settings.

To rotate the preview stream, use the **GUID** defined as [MF_MT_VIDEO_ROTATION](/windows/desktop/medfound/mf-mt-video-rotation). For how-to guidance on handling orientation when using the camera, see [Handle device orientation with MediaCapture](/windows/uwp/audio-video-camera/handle-device-orientation-with-mediacapture).

## -examples

## -see-also


## -capabilities
backgroundMediaRecording
microphone, webcam
