---
-api-id: E:Windows.Media.Core.MediaStreamSource.Starting
-api-type: winrt event
---

<!-- Event syntax
public event Windows.Foundation.TypedEventHandler Starting<Windows.Media.Core.MediaStreamSource,  Windows.Media.Core.MediaStreamSourceStartingEventArgs>
-->

# Windows.Media.Core.MediaStreamSource.Starting

## -description
Occurs when the [MediaStreamSource](mediastreamsource.md) is ready to start requesting [MediaStreamSample](mediastreamsample.md) objects. The event can specify a position in the media time-line from which the first [MediaStreamSample](mediastreamsample.md) should be delivered.

## -remarks
The [MediaStreamSource](mediastreamsource.md) raises this event before it starts requesting [MediaStreamSamples](mediastreamsample.md) for the first time. It also raises the event when it resumes requesting [MediaStreamSamples](mediastreamsample.md) after a [Paused](mediastreamsource_paused.md) event has occurred.

Upon receiving this event, the application must invoke the [SetActualStartPosition](mediastreamsourcestartingrequest_setactualstartposition.md) method on the [MediaStreamSourceStartingRequest](mediastreamsourcestartingrequest.md) object to specify the actual position in the time-line from which [MediaStreamSample](mediastreamsample.md) objects will be retrieved.

This event cancels any [SampleRequested](mediastreamsource_samplerequested.md) events the application has not delivered the requested [MediaStreamSample](mediastreamsample.md) for. However, application must still invoke the [Complete](mediastreamsourcesamplerequestdeferral_complete.md) method on the [MediaStreamSourceSampleRequestDeferral](mediastreamsourcesamplerequestdeferral.md) object for any previous [SampleRequested](mediastreamsource_samplerequested.md) events.

Applications are only required to have a handler for the [Starting](mediastreamsource_starting.md) event if [MediaStreamSource.CanSeek](mediastreamsource_canseek.md) is set to **true** and they support seeking.

## -examples

## -see-also
[MediaStreamSourceStartingEventArgs](mediastreamsourcestartingeventargs.md)