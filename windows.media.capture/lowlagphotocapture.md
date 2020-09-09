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
Use [MediaCapture.PrepareLowLagPhotoCaptureAsync](mediacapture_preparelowlagphotocaptureasync_1426375994.md) to initialize the capture. This is an asynchronous calls which returns a LowLagPhotoCapture object when it is finished. This must be called before [CaptureAsync](lowlagphotocapture_captureasync_2078018041.md).

[FinishAsync](lowlagphotosequencecapture_finishasync_1182664592.md) stops the photo capture operation and releases the LowLagPhotoCapture object and resources used by the capture photo operation. After starting a low lag photo capture, you must stop the photo capture by calling [FinishAsync](lowlagmediarecording_finishasync_1182664592.md) before your app attempts to record video with the [MediaCapture](mediacapture.md) object.

If the media type is changed or an effect is added, you must call [MediaCapture.PrepareLowLagPhotoCaptureAsync](mediacapture_preparelowlagphotocaptureasync_1426375994.md) to create a new LowLagPhotoCapture object.

For how-to guidance for using **LowLagPhotoCapture** to capture photos, see [Basic photo, video, and audio capture with MediaCapture](/windows/uwp/audio-video-camera/basic-photo-video-and-audio-capture-with-mediacapture).



## -examples

## -see-also
[Basic photo, video, and audio capture with MediaCapture](/windows/uwp/audio-video-camera/basic-photo-video-and-audio-capture-with-mediacapture), [MediaCapture.PrepareLowLagPhotoCapture](mediacapture_preparelowlagphotocaptureasync_1426375994.md), [CapturedPhoto](capturedphoto.md), [LowLagPhotoControl](../windows.media.devices/lowlagphotocontrol.md), [MediaControl.VideoDeviceController](mediacapture_videodevicecontroller.md), [LowLagPhotoSequenceCapture](lowlagphotosequencecapture.md)
