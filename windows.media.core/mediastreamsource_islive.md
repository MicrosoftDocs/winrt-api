---
-api-id: P:Windows.Media.Core.MediaStreamSource.IsLive
-api-type: winrt property
---

<!-- Property syntax.
public bool IsLive { get;  set; }
-->

# Windows.Media.Core.MediaStreamSource.IsLive

## -description
Gets or sets a value indicating whether the media content being processed is live.

## -property-value
True if the media content is live; otherwise false.

## -remarks
Setting this value to true notifies the media pipeline that the content is live, which allows the system to enable some optimizations that are only valid for live sources, such as turning off some quality management that isn't applicable to live sources and modifying the way that timestamps are handled.

## -see-also

## -examples

