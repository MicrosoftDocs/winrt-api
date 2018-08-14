---
-api-id: M:Windows.Graphics.Imaging.BitmapEncoder.CreateAsync(System.Guid,Windows.Storage.Streams.IRandomAccessStream)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperation<Windows.Graphics.Imaging.BitmapEncoder> CreateAsync(System.Guid encoderId, Windows.Storage.Streams.IRandomAccessStream stream)
-->

# Windows.Graphics.Imaging.BitmapEncoder.CreateAsync

## -description
Asynchronously creates a new [BitmapEncoder](bitmapencoder.md).

## -parameters
### -param encoderId
The unique identifier of the specified encoder.

### -param stream
The output stream.

## -returns
An object that manages the asynchronous creation of a new [BitmapEncoder](bitmapencoder.md).

## -remarks
An application must always specify the *encoderId* in order to create a [BitmapEncoder](bitmapencoder.md). The unique identifiers of the built-in encoders are available as properties on [BitmapEncoder](bitmapencoder.md). In addition, the unique identifier of any installed encoder can be obtained by using the [GetEncoderInformationEnumerator](bitmapencoder_getencoderinformationenumerator_1011982973.md) method.

[BitmapEncoder](bitmapencoder.md) expects that the output stream is empty. You can ensure that the stream is empty by setting its [Size](../windows.storage.streams/irandomaccessstream_size.md) property to 0.

## -examples

## -see-also
[CreateAsync(Guid, IRandomAccessStream,IIterable(IKeyValuePair))](bitmapencoder_createasync_415643468.md)