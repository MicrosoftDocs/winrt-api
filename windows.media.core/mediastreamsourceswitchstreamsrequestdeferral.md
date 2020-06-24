---
-api-id: T:Windows.Media.Core.MediaStreamSourceSwitchStreamsRequestDeferral
-api-type: winrt class
---

<!-- Class syntax.
public class MediaStreamSourceSwitchStreamsRequestDeferral : Windows.Media.Core.IMediaStreamSourceSwitchStreamsRequestDeferral
-->

# Windows.Media.Core.MediaStreamSourceSwitchStreamsRequestDeferral

## -description
Provides a way for the application to asynchronously report that it has completed the [MediaStreamSource.SwitchStreamsRequested](mediastreamsource_switchstreamsrequested.md) event.

## -remarks
You can use a deferral when you want to make an asynchronous call in response to the [MediaStreamSource.SwitchStreamsRequested](mediastreamsource_switchstreamsrequested.md) event. For example, if you need to establish a HTTP connection or open a file for reading. The [MediaStreamSource](mediastreamsource.md) will then wait for you to mark the deferral as complete before it begins raising the [SampleRequested](mediastreamsource_samplerequested.md) event.

To create a deferral, call the [GetDeferral](mediastreamsourceswitchstreamsrequest_getdeferral_254836512.md) method on the MediaStreamSourceSwitchStreamsRequest object to instruct the [MediaStreamSource](mediastreamsource.md) to wait for your asynchronous call to complete. When you are ready to start receiving [SampleRequested](mediastreamsource_samplerequested.md) events, call the [Complete](mediastreamsourceswitchstreamsrequestdeferral_complete_1807836922.md) method to end the deferral.

See the [MediaStreamSource Sample](https://github.com/microsoftarchive/msdn-code-gallery-microsoft/tree/master/Official%20Windows%20Platform%20Sample/MediaStreamSource%20streaming%20sample) for an example of using Media Stream Source in a UWP app.

## -examples

## -see-also
[MediaStreamSource Sample](https://github.com/microsoftarchive/msdn-code-gallery-microsoft/tree/master/Official%20Windows%20Platform%20Sample/MediaStreamSource%20streaming%20sample)
