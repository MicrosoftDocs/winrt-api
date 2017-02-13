---
-api-id: P:Windows.Media.Core.MediaStreamSource.BufferTime
-api-type: winrt property
---

<!-- Property syntax
public Windows.Foundation.TimeSpan BufferTime { get;  set; }
-->

# Windows.Media.Core.MediaStreamSource.BufferTime

## -description
Gets or sets the amount of data that is buffered by the [MediaStreamSource](mediastreamsource.md).

## -property-value
The duration of the buffer which corresponds to the number of [MediaStreamSamples](mediastreamsample.md) the [MediaStreamSource](mediastreamsource.md) requests. The default value is 3 seconds.

## -remarks
The [MediaStreamSource](mediastreamsource.md) will request a number of [MediaStreamSamples](mediastreamsample.md) in advance. The amount is controlled by the [BufferTime](mediastreamsource_buffertime.md) property. The default value is 3 seconds.

Requesting [MediaStreamSamples](mediastreamsample.md) in advance helps prevent glitches that would otherwise occur if the application does not deliver [MediaStreamSamples](mediastreamsample.md) on time.

## -examples

## -see-also
