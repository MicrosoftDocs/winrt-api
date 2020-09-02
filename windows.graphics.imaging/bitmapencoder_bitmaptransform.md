---
-api-id: P:Windows.Graphics.Imaging.BitmapEncoder.BitmapTransform
-api-type: winrt property
---

<!-- Property syntax
public Windows.Graphics.Imaging.BitmapTransform BitmapTransform { get; }
-->

# Windows.Graphics.Imaging.BitmapEncoder.BitmapTransform

## -description
A [BitmapTransform](bitmaptransform.md) object that is used to specify how the frame bitmap is to be transformed.

## -property-value
A [BitmapTransform](bitmaptransform.md) object that is used to specify how the frame bitmap is to be transformed.

## -remarks
If you try scale an image stored in an indexed pixel format using the [BitmapTransform](bitmaptransform.md) member, [FlushAsync](bitmapencoder_flushasync_491532439.md) fails with HRESULT [WINCODEC_ERR_INVALIDPARAMETER](/windows/desktop/wic/-wic-codec-error-codes) . Instead, you must use [GetPixelDataAsync](/uwp/api/windows.graphics.imaging.bitmapdecoder.getpixeldataasync) to obtain the scaled pixel data and then use [SetPixelData](bitmapencoder_setpixeldata_644328650.md) to set it on the encoder.

## -examples

## -see-also
