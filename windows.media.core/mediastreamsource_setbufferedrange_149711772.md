---
-api-id: M:Windows.Media.Core.MediaStreamSource.SetBufferedRange(Windows.Foundation.TimeSpan,Windows.Foundation.TimeSpan)
-api-type: winrt method
---

<!-- Method syntax
public void SetBufferedRange(Windows.Foundation.TimeSpan startOffset, Windows.Foundation.TimeSpan endOffset)
-->

# Windows.Media.Core.MediaStreamSource.SetBufferedRange

## -description
Sets the range of data that the application is currently buffering.

## -parameters
### -param startOffset
The smallest time stamp of a [MediaStreamSample](mediastreamsample.md) buffered by the application.

### -param endOffset
The largest time stamp of a [MediaStreamSample](mediastreamsample.md) buffered by the application.

## -remarks
Applications that use the network to stream or download the data for [MediaStreamSamples](mediastreamsample.md) should invoke SetBufferedRange to specify what portion of the time-line is currently buffered. If the buffered range extends from 0 to the value of [Duration](mediastreamsource_duration.md), and [Duration](mediastreamsource_duration.md) is non-zero, the operating system may allow the network hardware to enter a power saving mode.

By default, the buffered range is assumed to be empty when the [CanSeek](mediastreamsource_canseek.md) property is **false** or when the [Duration](mediastreamsource_duration.md) property is 0. If [CanSeek](mediastreamsource_canseek.md) is **true**, the buffered range default is 0 to [Duration](mediastreamsource_duration.md)

## -examples

## -see-also
