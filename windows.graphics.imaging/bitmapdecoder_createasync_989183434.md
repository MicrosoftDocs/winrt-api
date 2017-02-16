---
-api-id: M:Windows.Graphics.Imaging.BitmapDecoder.CreateAsync(Windows.Storage.Streams.IRandomAccessStream)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperation<Windows.Graphics.Imaging.BitmapDecoder> CreateAsync(Windows.Storage.Streams.IRandomAccessStream stream)
-->

# Windows.Graphics.Imaging.BitmapDecoder.CreateAsync

## -description
Asynchronously creates a new [BitmapDecoder](bitmapdecoder.md) and initializes it using a stream.

## -parameters
### -param stream
The stream containing the image file to be decoded.

## -returns
An object that manages the asynchronous creation of a new [BitmapDecoder](bitmapdecoder.md).

## -remarks
[Windows.Graphics.Imaging](windows_graphics_imaging.md) automatically determines the correct bitmap decoder to decode the stream.

## -examples

## -see-also
[CreateAsync(Guid, IRandomAccessStream)](bitmapdecoder_createasync_1315566040.md), [Imaging](http://msdn.microsoft.com/library/3fd2aa71-ef67-47b2-9332-3ffa5d3703ea)