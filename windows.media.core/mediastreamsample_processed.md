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
When this event has been raised, it is safe to reuse the [IBuffer](http://msdn.microsoft.com/library/6c3bde9b-d354-48f8-b7f6-517df14202c0) from this [MediaStreamSample](mediastreamsample.md) in a new [MediaStreamSample](mediastreamsample.md). This allows an application to have a pool of buffers which are reused across multiple [MediaStreamSample](mediastreamsample.md) objects, rather than allocating a new buffer for each new [MediaStreamSample](mediastreamsample.md).

The event is informational. Applications are not required to have a handler for this event.

## -examples

## -see-also
