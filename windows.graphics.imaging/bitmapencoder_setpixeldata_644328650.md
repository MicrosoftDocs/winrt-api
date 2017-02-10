---
-api-id: M:Windows.Graphics.Imaging.BitmapEncoder.SetPixelData(Windows.Graphics.Imaging.BitmapPixelFormat,Windows.Graphics.Imaging.BitmapAlphaMode,System.UInt32,System.UInt32,System.Double,System.Double,System.Byte[])
-api-type: winrt method
---

<!-- Method syntax
public void SetPixelData(Windows.Graphics.Imaging.BitmapPixelFormat pixelFormat, Windows.Graphics.Imaging.BitmapAlphaMode alphaMode, System.UInt32 width, System.UInt32 height, System.Double dpiX, System.Double dpiY, System.Byte[] pixels)
-->

# Windows.Graphics.Imaging.BitmapEncoder.SetPixelData

## -description
Sets pixel data on the frame.

## -parameters
### -param pixelFormat
The pixel format of the pixel data.

### -param alphaMode
The alpha mode of the pixel data.

### -param width
The width, in pixels, of the pixel data.

### -param height
The height, in pixels, of the pixel data.

### -param dpiX
The horizontal resolution, in dots per inch, of the pixel data.

### -param dpiY
The vertical resolution, in dots per inch, of the pixel data.

### -param pixels
The pixel data.

## -remarks
This method is synchronous because data is not committed until [FlushAsync](bitmapencoder_flushasync.md), [GoToNextFrameAsync](bitmapencoder_gotonextframeasync_718000702.md) or [GoToNextFrameAsync(IIterable(IKeyValuePair))](bitmapencoder_gotonextframeasync_1063265177.md) is called.

Setting a pixel format of **Unknown** will result in failure.

This method treats all pixel data as being in the sRGB color space. When you call this method it automatically clears any existing color space information from the frame, including embedded color profiles.

When you are encoding a new image, before you call [FlushAsync](bitmapencoder_flushasync.md) at the minimum you must set pixel data using this method.

## -examples

## -see-also
