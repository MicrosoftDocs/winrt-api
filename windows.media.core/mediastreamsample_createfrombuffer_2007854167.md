---
-api-id: M:Windows.Media.Core.MediaStreamSample.CreateFromBuffer(Windows.Storage.Streams.IBuffer,Windows.Foundation.TimeSpan)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Media.Core.MediaStreamSample CreateFromBuffer(Windows.Storage.Streams.IBuffer buffer, Windows.Foundation.TimeSpan timestamp)
-->

# Windows.Media.Core.MediaStreamSample.CreateFromBuffer

## -description
Creates a [MediaStreamSample](mediastreamsample.md) from an [IBuffer](/previous-versions/hh438362(v=vs.85)).

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
