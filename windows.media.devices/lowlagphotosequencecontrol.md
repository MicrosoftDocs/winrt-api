---
-api-id: T:Windows.Media.Devices.LowLagPhotoSequenceControl
-api-type: winrt class
---

<!-- Class syntax.
public class LowLagPhotoSequenceControl : Windows.Media.Devices.ILowLagPhotoSequenceControl
-->

# Windows.Media.Devices.LowLagPhotoSequenceControl

## -description
Provides functionality for managing the low shutter lag photo sequence mode on the capture device.

## -remarks
Photo sequence mode takes a rapid sequence of photos. A key scenario for photo sequence is getting photos in the past, that is prior to when the user takes a photo.

You can access the LowLagPhotoSequenceControl for the capture device through [MediaCapture.VideoDeviceController](../windows.media.capture/mediacapture_videodevicecontroller.md).

You can find out if the device supports photo sequence mode by checking [LowLagPhotoSequenceControl.Supported](lowlagphotosequencecontrol_supported.md).

To initiate photo sequence mode, call [MediaCapture.PrepareLowLagPhotoSequenceCaptureAsync](../windows.media.capture/mediacapture_preparelowlagphotosequencecaptureasync_2130225421.md). To start capturing photos, call [StartAsync](../windows.media.capture/lowlagphotosequencecapture_startasync_1931900819.md). To stop capturing photos, call [StopAsync](../windows.media.capture/lowlagphotosequencecapture_stopasync_1648475005.md). The app will continue to receive photos from the device until the operation is stopped.

[GetCurrentFrameRate](lowlagphotosequencecontrol_getcurrentframerate_279282429.md) specifies the frame rate at which the photos are taken.

[PhotoCapturedEventArgs.CaptureTimeOffset](../windows.media.capture/photocapturedeventargs_capturetimeoffset.md) can be used to tell whether a frame was in the future, greater than 0, or in the past, less than 0.

If the app wants to limit how many frames it gets per second, it can use [LowLagPhotoSequence.PhotosPerSecondLimit](lowlagphotosequencecontrol_photospersecondlimit.md). This can be useful in situations where the sensor on the device can handle 30fps, but the app only needs 4fps.

Thumbnails are supported for a low shutter lag single photos and photo sequences.

To enable thumbnails, set [ThumbnailEnabled](lowlagphotosequencecontrol_thumbnailenabled.md) to **true**.

You can set the desired thumbnail size through [DesiredThumbnailSize](lowlagphotosequencecontrol_desiredthumbnailsize.md) and set the thumbnail format through [ThumbnailFormat](lowlagphotosequencecontrol_thumbnailformat.md).

The number of past photos cannot be more than [MaxPastPhotos](lowlagphotosequencecontrol_maxpastphotos.md), which is the maximum number of past photos that is supported by the driver. The number of past photos returned will be the smaller of the following values: [PastPhotoLimit](lowlagphotosequencecontrol_pastphotolimit.md), [MaxPastPhotos](lowlagphotosequencecontrol_maxpastphotos.md), or the current number of available past photos.

## -examples

## -see-also
[LowLagPhotoSequenceCapture](../windows.media.capture/lowlagphotosequencecapture.md)
