---
-api-id: M:Windows.Graphics.Imaging.BitmapEncoder.CreateAsync(System.Guid,Windows.Storage.Streams.IRandomAccessStream,Windows.Foundation.Collections.IIterable{Windows.Foundation.Collections.IKeyValuePair{System.String,Windows.Graphics.Imaging.BitmapTypedValue}})
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperation<Windows.Graphics.Imaging.BitmapEncoder> CreateAsync(System.Guid encoderId, Windows.Storage.Streams.IRandomAccessStream stream, Windows.Foundation.Collections.IIterable<Windows.Foundation.Collections.IKeyValuePair<System.String, Windows.Graphics.Imaging.BitmapTypedValue>> encodingOptions)
-->

# Windows.Graphics.Imaging.BitmapEncoder.CreateAsync

## -description
Asynchronously creates a new [BitmapEncoder](bitmapencoder.md) for the specified codec with the specified encoding options and initializes it on a stream.

## -parameters
### -param encoderId
The unique identifier of the specified encoder.

### -param stream
A stream representing where the image file is to be written.

### -param encodingOptions
A collection of key-value pairs containing one or more codec-specific encoding options and the desired values.

## -returns
An object that manages the asynchronous creation of a new [BitmapEncoder](bitmapencoder.md).

## -remarks

## -examples

## -see-also
[BitmapPropertySet](bitmappropertyset.md), [BitmapTypedValue](bitmaptypedvalue.md), [Imaging](/windows/uwp/audio-video-camera/imaging), [CreateAsync(Guid, IRandomAccessStream)](bitmapencoder_createasync_1315566040.md)
