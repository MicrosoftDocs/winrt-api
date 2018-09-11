---
-api-id: P:Windows.Graphics.Imaging.BitmapCodecInformation.CodecId
-api-type: winrt property
---

<!-- Property syntax
public System.Guid CodecId { get; }
-->

# Windows.Graphics.Imaging.BitmapCodecInformation.CodecId

## -description
The unique identifier of the decoder or encoder. Methods like [BitmapDecoder.CreateAsync](/uwp/api/windows.graphics.imaging.bitmapdecoder.createasync) and [BitmapEncoder.CreateAsync](/uwp/api/windows.graphics.imaging.bitmapencoder.createasync) use the codec identifier to determine which codec to create.

## -property-value
The codec unique identifier.

## -remarks
The encoder and decoder of an image format are separate, and their codec IDs are distinct.

## -examples

## -see-also
[BitmapDecoder.CreateAsync](/uwp/api/windows.graphics.imaging.bitmapdecoder.createasync), [BitmapEncoder.CreateAsync](/uwp/api/windows.graphics.imaging.bitmapencoder.createasync)
