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

To create a deferral, call [MediaStreamSourceSampleRequest.GetDeferral](mediastreamsourcesamplerequest_getdeferral_254836512.md). This will instruct the [MediaStreamSource](mediastreamsource.md) to wait for the [MediaStreamSample](mediastreamsample.md). After you have assigned the [MediaStreamSample](mediastreamsample.md) to the [MediaStreamSourceSampleRequest.Sample](mediastreamsourcesamplerequest_sample.md) property, call the [Complete](mediastreamsourcesamplerequestdeferral_complete_1807836922.md) method to end the deferral.

See the [MediaStreamSource Sample](https://github.com/microsoftarchive/msdn-code-gallery-microsoft/tree/master/Official%20Windows%20Platform%20Sample/MediaStreamSource%20streaming%20sample) for an example of using Media Stream Source in a UWP app.

## -examples

## -see-also
[MediaStreamSource Sample](https://github.com/microsoftarchive/msdn-code-gallery-microsoft/tree/master/Official%20Windows%20Platform%20Sample/MediaStreamSource%20streaming%20sample)
