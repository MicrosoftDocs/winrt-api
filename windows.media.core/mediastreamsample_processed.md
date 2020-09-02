---
-api-id: E:Windows.Media.Core.MediaStreamSample.Processed
-api-type: winrt event
---

<!-- Event syntax
public event Windows.Foundation.TypedEventHandler Processed<Windows.Media.Core.MediaStreamSample,  object>
-->

# Windows.Media.Core.MediaStreamSample.Processed

## -description
Occurs when the MediaStreamSample has been processed by the media pipeline.

## -remarks
When this event has been raised, it is safe to reuse the [IBuffer](/previous-versions/hh438362(v=vs.85)) from this [MediaStreamSample](mediastreamsample.md) in a new [MediaStreamSample](mediastreamsample.md). This allows an application to have a pool of buffers which are reused across multiple [MediaStreamSample](mediastreamsample.md) objects, rather than allocating a new buffer for each new [MediaStreamSample](mediastreamsample.md).

The event is informational. Applications are not required to have a handler for this event.

## -examples

## -see-also
