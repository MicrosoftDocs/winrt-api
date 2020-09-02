---
-api-id: P:Windows.Media.Capture.CapturedFrame.BitmapProperties
-api-type: winrt property
---

<!-- Property syntax.
public BitmapPropertySet BitmapProperties { get; }
-->

# Windows.Media.Capture.CapturedFrame.BitmapProperties

## -description
Gets an object containing bitmap properties for the [CapturedFrame](capturedframe.md). These properties convey image metadata such as EXIF data.

## -property-value
An object containing bitmap properties for the [CapturedFrame](capturedframe.md).

## -remarks
This property is useful for apps that want to capture frames in an uncompressed format. When capturing to a compressed format, the bitmap properties such as EXIF data are automatically encoded into the image file. When capturing to a raw format, you can get the bitmap properties using this API and then, for example, set the [BitmapProperties](../windows.graphics.imaging/bitmapencoder_bitmapproperties.md) property of a [BitmapEncoder](../windows.graphics.imaging/bitmapencoder.md) to include the associated metadata in the encoded file. 

For more information on encoding bitmaps, see [Create, edit, and save bitmap images](/windows/uwp/audio-video-camera/imaging).

## -see-also
[Create, edit, and save bitmap images](/windows/uwp/audio-video-camera/imaging)

## -examples

