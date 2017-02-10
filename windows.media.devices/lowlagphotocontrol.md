---
-api-id: T:Windows.Media.Devices.LowLagPhotoControl
-api-type: winrt class
---

<!-- Class syntax.
public class LowLagPhotoControl : Windows.Media.Devices.ILowLagPhotoControl
-->

# Windows.Media.Devices.LowLagPhotoControl

## -description
Provides functionality for managing the low shutter lag photo capture mode on the capture device.

## -remarks
You can access the [LowLagPhotoControl](lowlagphotocontrol.md) for the capture device through [MediaCapture.VideoDeviceController](../windows.media.capture/mediacapture_videodevicecontroller.md).

Thumbnails are supported for a low shutter lag single photos and photo sequences.

To enable thumbnails, set [ThumbnailEnabled](lowlagphotocontrol_thumbnailenabled.md) to **true**.

You can set the desired thumbnail size through [DesiredThumbnailSize](lowlagphotocontrol_desiredthumbnailsize.md) and set the thumbnail format through [ThumbnailFormat](lowlagphotocontrol_thumbnailformat.md).

## -examples

## -see-also
