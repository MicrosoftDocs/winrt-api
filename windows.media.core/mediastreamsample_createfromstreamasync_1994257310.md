---
-api-id: M:Windows.Media.Core.MediaStreamSample.CreateFromStreamAsync(Windows.Storage.Streams.IInputStream,System.UInt32,Windows.Foundation.TimeSpan)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperation<Windows.Media.Core.MediaStreamSample> CreateFromStreamAsync(Windows.Storage.Streams.IInputStream stream, System.UInt32 count, Windows.Foundation.TimeSpan timestamp)
-->

# Windows.Media.Core.MediaStreamSample.CreateFromStreamAsync

## -description
Asynchronously creates a [MediaStreamSample](mediastreamsample.md) from an [IInputStream](/previous-versions/hh438387(v=vs.85)).

## -parameters
### -param stream
The stream that contains the media data used to create the [MediaStreamSample](mediastreamsample.md).

### -param count
The length of the data in the sample. This is the number of bytes that will be read from *stream*.

### -param timestamp
The presentation time of this [MediaStreamSample](mediastreamsample.md).

## -returns
When this method completes, it returns the new file as a [MediaStreamSample](mediastreamsample.md).

## -remarks
For certain formats, the decode time and the presentation time of a [MediaStreamSample](mediastreamsample.md) are different. The decode time can be accessed through the [DecodeTimestamp](mediastreamsample_decodetimestamp.md) property.

## -examples

## -see-also
