---
-api-id: M:Windows.Graphics.Imaging.BitmapDecoder.GetThumbnailAsync
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperation<Windows.Graphics.Imaging.ImageStream> GetThumbnailAsync()
-->

# Windows.Graphics.Imaging.BitmapDecoder.GetThumbnailAsync

## -description
Asynchronously returns a stream containing the thumbnail image.

## -returns
Object that manages the asynchronous retrieval of the thumbnail stream.

The thumbnail data is returned in the form of an image stream. You can display it using an image control, or read and edit it using [BitmapDecoder](bitmapdecoder.md) and [BitmapEncoder](bitmapencoder.md)

## -remarks
Many image formats, like JPEG and TIFF, allow a small sized thumbnail of the full image to be embedded within a frame. If the image does not contain a thumbnail, then this operation will fail with HRESULT [WINCODEC_ERR_CODECNOTHUMBNAIL](/windows/desktop/wic/-wic-codec-error-codes). If it exists, the EXIF orientation flag on the frame is automatically applied to the thumbnail before it is returned.

## -examples

## -see-also
