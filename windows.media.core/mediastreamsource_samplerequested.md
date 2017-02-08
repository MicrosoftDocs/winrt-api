---
-api-id: E:Windows.Media.Core.MediaStreamSource.SampleRequested
-api-type: winrt event
---

<!-- Event syntax
public event Windows.Foundation.TypedEventHandler SampleRequested<Windows.Media.Core.MediaStreamSource,  Windows.Media.Core.MediaStreamSourceSampleRequestedEventArgs>
-->

# Windows.Media.Core.MediaStreamSource.SampleRequested

## -description
Occurs when the [MediaStreamSource](mediastreamsource.md) request a [MediaStreamSample](mediastreamsample.md) for a specified stream.

## -remarks
Upon receiving this event, the application should assign a [MediaStreamSample](mediastreamsample.md) for the requested stream to the [Sample](mediastreamsourcesamplerequest_sample.md) property of the [MediaStreamSourceSampleRequest](mediastreamsourcesamplerequest.md) object.

If the application is temporarily unable to deliver the [MediaStreamSample](mediastreamsample.md), it should obtain the [MediaStreamSourceSampleRequestDeferral](mediastreamsourcesamplerequestdeferral.md) object and invoke [ReportSampleProgress](mediastreamsourcesamplerequest_reportsampleprogress.md) on a regular basis until it assigns a [MediaStreamSample](mediastreamsample.md) to the [Sample](mediastreamsourcesamplerequest_sample.md) property and calls [Complete](mediastreamsourcesamplerequestdeferral_complete.md) on the [MediaStreamSourceSampleRequestDeferral](mediastreamsourcesamplerequestdeferral.md) object. The recommended interval between each invocation of [ReportSampleProgress](mediastreamsourcesamplerequest_reportsampleprogress.md) is 500 milliseconds.

If the specified stream does not have any more samples, the application should leave the [Sample](mediastreamsourcesamplerequest_sample.md) property unassigned or set it to **null**.

## -examples

## -see-also
[MediaStreamSourceSampleRequestedEventArgs](mediastreamsourcesamplerequestedeventargs.md)