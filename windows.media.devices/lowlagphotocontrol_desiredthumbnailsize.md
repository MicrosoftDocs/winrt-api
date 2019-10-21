---
-api-id: P:Windows.Media.Devices.LowLagPhotoControl.DesiredThumbnailSize
-api-type: winrt property
---

<!-- Property syntax
public uint DesiredThumbnailSize { get;  set; }
-->

# Windows.Media.Devices.LowLagPhotoControl.DesiredThumbnailSize

## -description
Gets or sets the desired size for thumbnails, which is the largest length of the image, either width or height.

## -property-value
The desired thumbnail size.

## -remarks
The actual dimension of the thumbnail is not guaranteed to be the value specified by DesiredThumbnailSize, but the system will attempt to create thumbnails as close as possible to this value.

## -examples

## -see-also
[ThumbnailEnabled](lowlagphotocontrol_thumbnailenabled.md), [ThumbnailFormat](lowlagphotocontrol_thumbnailformat.md), [HardwareAcceleratedThumbnailSupported](lowlagphotocontrol_hardwareacceleratedthumbnailsupported.md)
