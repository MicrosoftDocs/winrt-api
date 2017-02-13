---
-api-id: M:Windows.Graphics.Imaging.BitmapEncoder.CreateForInPlacePropertyEncodingAsync(Windows.Graphics.Imaging.BitmapDecoder)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperation<Windows.Graphics.Imaging.BitmapEncoder> CreateForInPlacePropertyEncodingAsync(Windows.Graphics.Imaging.BitmapDecoder bitmapDecoder)
-->

# Windows.Graphics.Imaging.BitmapEncoder.CreateForInPlacePropertyEncodingAsync

## -description
Asynchronously creates a new [BitmapEncoder](bitmapencoder.md) for in-place property and metadata editing. The new encoder can only edit bitmap properties in-place and will fail for any other uses.

## -parameters
### -param bitmapDecoder
A [BitmapDecoder](bitmapdecoder.md) containing the image data to be edited. This parameter must be created on a stream with an access mode of [ReadWrite](../windows.storage/fileaccessmode.md).

> [!NOTE]
> The encoder writes to the stream that the original [BitmapDecoder](bitmapdecoder.md) was created on. You can't specify an output stream.

## -returns
An object that manages the asynchronous initialization of a new [BitmapEncoder](bitmapencoder.md) using data from an existing [BitmapDecoder](bitmapdecoder.md).

## -remarks
Use this method to retrieve an encoder when you are only going to use it to edit or write a limited amount of properties to the image. An encoder retrieved this way can provide a performance advantage over an encoder returned by [CreateForTranscodingAsync](bitmapencoder_createfortranscodingasync.md) because it writes the new properties to empty padding space instead of encoding the entire image again.

Here are several limitations to an encoder retrieved this way:


+ You can only use these methods on the encoder:
   + [BitmapEncoder::BitmapProperties::GetPropertiesAsync](bitmapproperties_getpropertiesasync.md)
   + [BitmapEncoder::BitmapProperties::SetPropertiesAsync](bitmapproperties_setpropertiesasync.md)
   + [BitmapEncoder::FlushAsync](bitmapencoder_flushasync.md)
 Any other methods will fail if you call them.
+ The input [BitmapDecoder](bitmapdecoder.md) must be an encoder created on a stream with [ReadWrite](../windows.storage/fileaccessmode.md) access.
+ Not all metadata formats support fast metadata encoding. The native metadata handlers that support metadata are IFD, Exif, XMP, and GPS.
+ The metadata block must have enough padding to store the properties that you are trying to edit.
If an encoding operation fails for any reason, you will have to use [CreateForTranscodingAsync](bitmapencoder_createfortranscodingasync.md) to edit the metadata and re-encode the image. When you re-encode, you can also add new or additional padding to enable in-place property encoding in the future. To do this, create a new [BitmapTypedValue](bitmaptypedvalue.md) with Type set to UInt32 and Value set to the number of bytes of padding you wish to add. A typical value is 4096 bytes. Set this metadata item on one or more of the metadata query locations in this table. <table>
   <tr><th>Metadata format</th><th>JPEG metadata query</th><th>TIFF, JPEG-XR metadata query</th></tr>
   <tr><td>IFD</td><td>/app1/ifd/PaddingSchema:Padding</td><td>/ifd/PaddingSchema:Padding</td></tr>
   <tr><td>EXIF</td><td>/app1/ifd/exif/PaddingSchema:Padding</td><td>/ifd/exif/PaddingSchema:Padding</td></tr>
   <tr><td>XMP</td><td>/xmp/PaddingSchema:Padding</td><td>/ifd/xmp/PaddingSchema:Padding</td></tr>
   <tr><td>GPS</td><td>/app1/ifd/gps/PaddingSchema:Padding</td><td>/ifd/gps/PaddingSchema:Padding</td></tr>
</table>

## -examples

## -see-also
