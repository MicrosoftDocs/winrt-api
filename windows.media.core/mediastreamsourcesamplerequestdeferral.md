---
-api-id: T:Windows.Media.Core.MediaStreamSourceSampleRequestDeferral
-api-type: winrt class
---

<!-- Class syntax.
public class MediaStreamSourceSampleRequestDeferral : Windows.Media.Core.IMediaStreamSourceSampleRequestDeferral
-->

# Windows.Media.Core.MediaStreamSourceSampleRequestDeferral

## -description
Provides a way for the application to asynchronously report that it has completed retrieving the [MediaStreamSample](mediastreamsample.md).

## -remarks
You can use a deferral to retrieve the [MediaStreamSample](mediastreamsample.md) asynchronously. The [MediaStreamSource](mediastreamsource.md) will wait until you mark the deferral as complete.

To create a deferral, call [MediaStreamSourceSampleRequest.GetDeferral](mediastreamsourcesamplerequest_getdeferral.md). This will instruct the [MediaStreamSource](mediastreamsource.md) to wait for the [MediaStreamSample](mediastreamsample.md). After you have assigned the [MediaStreamSample](mediastreamsample.md) to the [MediaStreamSourceSampleRequest.Sample](mediastreamsourcesamplerequest_sample.md) property, call the [Complete](mediastreamsourcesamplerequestdeferral_complete.md) method to end the deferral.

See the [MediaStreamSource Sample](http://go.microsoft.com/fwlink/p/?LinkID=309021) for an example of using Media Stream Source in a Windows Store app.

## -examples

## -see-also
[MediaStreamSource Sample](http://go.microsoft.com/fwlink/p/?LinkID=309021)