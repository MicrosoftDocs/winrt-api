---
-api-id: M:Windows.Media.Core.MediaStreamSample.CreateFromBuffer(Windows.Storage.Streams.IBuffer,Windows.Foundation.TimeSpan)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Media.Core.MediaStreamSample CreateFromBuffer(Windows.Storage.Streams.IBuffer buffer, Windows.Foundation.TimeSpan timestamp)
-->

# Windows.Media.Core.MediaStreamSample.CreateFromBuffer

## -description
Creates a [MediaStreamSample](mediastreamsample.md) from an [IBuffer](https://msdn.microsoft.com/library/6c3bde9b-d354-48f8-b7f6-517df14202c0).

## -parameters
### -param buffer
The buffer that contains the media data used to create the [MediaStreamSample](mediastreamsample.md).

### -param timestamp
The presentation time of this sample.

## -returns
The sample created from the data in *buffer*.

## -remarks
For certain formats, the decode time and the presentation time of a [MediaStreamSample](mediastreamsample.md) are different. The decode time can be accessed through the [DecodeTimestamp](mediastreamsample_decodetimestamp.md) property.

## -examples

## -see-also
