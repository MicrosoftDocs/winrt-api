---
-api-id: T:Windows.Graphics.Imaging.PixelDataProvider
-api-type: winrt class
---

<!-- Class syntax.
public class PixelDataProvider : Windows.Graphics.Imaging.IPixelDataProvider
-->

# Windows.Graphics.Imaging.PixelDataProvider

## -description
Provides access to the pixel data from a bitmap frame.

## -remarks
An application asynchronously receives a [PixelDataProvider](pixeldataprovider.md) from the [GetPixelDataAsync](bitmapframe_getpixeldataasync.md) methods of [BitmapFrame](bitmapframe.md) or [BitmapDecoder](bitmapdecoder.md). The application can then synchronously request the pixel data using [DetachPixelData](pixeldataprovider_detachpixeldata.md) to get access to the raw pixels of the bitmap.

## -examples

## -see-also