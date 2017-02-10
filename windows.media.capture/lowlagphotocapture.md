---
-api-id: T:Windows.Media.Capture.LowLagPhotoCapture
-api-type: winrt class
---

<!-- Class syntax.
public class LowLagPhotoCapture : Windows.Media.Capture.ILowLagPhotoCapture
-->

# Windows.Media.Capture.LowLagPhotoCapture

## -description
Provides methods for taking a low shutter lag photo.

## -remarks
Use [MediaCapture.PrepareLowLagPhotoCaptureAsync](mediacapture_preparelowlagphotocaptureasync.md) to initialize the capture. This is an asynchronous calls which returns a [LowLagPhotoCapture](lowlagphotocapture.md) object when it is finished. This must be called before [CaptureAsync](lowlagphotocapture_captureasync.md).

[FinishAsync](lowlagphotosequencecapture_finishasync.md) stops the photo capture operation and releases the [LowLagPhotoCapture](lowlagphotocapture.md) object and resources used by the capture photo operation. After starting a low lag photo capture, you must stop the photo capture by calling [FinishAsync](lowlagmediarecording_finishasync.md) before your app attempts to record video with the [MediaCapture](mediacapture.md) object.

If the media type is changed or an effect is added, you must call [MediaCapture.PrepareLowLagPhotoCaptureAsync](mediacapture_preparelowlagphotocaptureasync.md) to create a new [LowLagPhotoCapture](lowlagphotocapture.md) object.

For how-to guidance for using **LowLagPhotoCapture** to capture photos, see [Basic photo, video, and audio capture with MediaCapture](https://msdn.microsoft.com/windows/uwp/audio-video-camera/basic-photo-video-and-audio-capture-with-mediacapture).



## -examples

## -see-also
[Basic photo, video, and audio capture with MediaCapture](https://msdn.microsoft.com/windows/uwp/audio-video-camera/basic-photo-video-and-audio-capture-with-mediacapture), [MediaCapture.PrepareLowLagPhotoCapture](mediacapture_preparelowlagphotocaptureasync.md), [CapturedPhoto](capturedphoto.md), [LowLagPhotoControl](../windows.media.devices/lowlagphotocontrol.md), [MediaControl.VideoDeviceController](mediacapture_videodevicecontroller.md), [LowLagPhotoSequenceCapture](lowlagphotosequencecapture.md)