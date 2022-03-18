---
-api-id: M:Windows.Graphics.Imaging.BitmapDecoder.GetPreviewAsync
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperation<Windows.Graphics.Imaging.ImageStream> GetPreviewAsync()
-->

# Windows.Graphics.Imaging.BitmapDecoder.GetPreviewAsync

## -description
Asynchronously returns a stream containing the preview image.

## -returns
Object that manages the asynchronous retrieval of the bitmap preview data.

The preview data is returned in the form of an image stream. You can display it using an image control, or read and edit it using [BitmapDecoder](bitmapdecoder.md) and [BitmapEncoder](bitmapencoder.md).

## -remarks
Some image formats, like JPEG-XR and camera RAW formats, contain an image preview. The preview is generally higher resolution than a thumbnail. This is an advantage because decoding the preview can be faster than decoding the full RAW image, but provides comparable fidelity when displaying images

If the image does not contain a preview, this operation fails with HRESULT [WINCODEC_ERR_UNSUPPORTEDOPERATION](/windows/desktop/wic/-wic-codec-error-codes).

## -examples

## -see-also
