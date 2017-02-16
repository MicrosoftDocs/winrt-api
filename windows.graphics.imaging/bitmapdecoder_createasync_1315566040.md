---
-api-id: M:Windows.Graphics.Imaging.BitmapDecoder.CreateAsync(System.Guid,Windows.Storage.Streams.IRandomAccessStream)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperation<Windows.Graphics.Imaging.BitmapDecoder> CreateAsync(System.Guid decoderId, Windows.Storage.Streams.IRandomAccessStream stream)
-->

# Windows.Graphics.Imaging.BitmapDecoder.CreateAsync

## -description
Asynchronously creates a new [BitmapDecoder](bitmapdecoder.md) using a specific bitmap codec and initializes it using a stream.

## -parameters
### -param decoderId
The unique identifier of the specified bitmap codec.

### -param stream
The stream containing the image file to be decoded.

## -returns
An object that manages the asynchronous creation of a new [BitmapDecoder](bitmapdecoder.md).

## -remarks
This method allows the application to explicitly select the bitmap decoder to be used and bypass any automatic codec arbitration. The unique identifiers of the built-in decoders are available as properties on [BitmapDecoder](bitmapdecoder.md). In addition, the unique identifier of any installed decoder can be obtained using the [GetDecoderInformationEnumerator](bitmapdecoder_getdecoderinformationenumerator.md) method.

## -examples

## -see-also
[CreateAsync(IRandomAccessStream)](bitmapdecoder_createasync_989183434.md)