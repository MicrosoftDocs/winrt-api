---
-api-id: M:Windows.Media.Core.MediaStreamSourceStartingRequest.GetDeferral
-api-type: winrt method
---

<!-- Method syntax
public Windows.Media.Core.MediaStreamSourceStartingRequestDeferral GetDeferral()
-->

# Windows.Media.Core.MediaStreamSourceStartingRequest.GetDeferral

## -description
Defers completing the [MediaStreamSource.Starting](mediastreamsource_starting.md) event.

## -returns
The deferral.

## -remarks
You can use a deferral when you want to make an asynchronous call in response to the [Starting](mediastreamsource_starting.md) event. For example, if you need to establish a HTTP connection or open a file for reading. The [MediaStreamSource](mediastreamsource.md) will then wait for you to mark the deferral as complete before it begins raising the [SampleRequested](mediastreamsource_samplerequested.md) event.

To create a deferral, call the [GetDeferral](mediastreamsourcestartingrequest_getdeferral_254836512.md) method to instruct the [MediaStreamSource](mediastreamsource.md) to wait for your asynchronous call to complete. When you are ready to start receiving [SampleRequested](mediastreamsource_samplerequested.md) events, call the [Complete](mediastreamsourcestartingrequestdeferral_complete_1807836922.md) method to end the deferral.

## -examples

## -see-also
