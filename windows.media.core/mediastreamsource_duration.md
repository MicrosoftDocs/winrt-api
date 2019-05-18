---
-api-id: P:Windows.Media.Core.MediaStreamSource.Duration
-api-type: winrt property
---

<!-- Property syntax
public Windows.Foundation.TimeSpan Duration { get;  set; }
-->

# Windows.Media.Core.MediaStreamSource.Duration

## -description
Gets or sets the duration of the media time-line.

## -property-value
The duration of the media time-line. The default value is 0.

## -remarks
Applications that support seeking and set [CanSeek](mediastreamsource_canseek.md) to **true** must also assign a value to the Duration property.

The default value is 0, which means that the duration is unspecified. Live media or media that is being generated in real-time might have a Duration value of 0, since the actual duration is unknown.

Applications are allowed to change the value of this property at any time. For example, after a live broadcast has ended, the Duration value can be updated from 0 to the actual length of the live broadcast.

## -examples

## -see-also
