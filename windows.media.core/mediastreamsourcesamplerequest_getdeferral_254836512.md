---
-api-id: M:Windows.Media.Core.MediaStreamSourceSampleRequest.GetDeferral
-api-type: winrt method
---

<!-- Method syntax
public Windows.Media.Core.MediaStreamSourceSampleRequestDeferral GetDeferral()
-->

# Windows.Media.Core.MediaStreamSourceSampleRequest.GetDeferral

## -description
Defers assigning a [MediaStreamSample](mediastreamsample.md) to [MediaStreamSourceSampleRequest](mediastreamsourcesamplerequest.md) object.

## -returns
The deferral.

## -remarks
You can use a deferral when you want to make an asynchronous call to retrieve the [MediaStreamSample](mediastreamsample.md). The [MediaStreamSource](mediastreamsource.md) will then wait for you to supply the [MediaStreamSample](mediastreamsample.md) until you mark the deferral as complete.

To create a deferral, call the GetDeferral method to instruct the [MediaStreamSource](mediastreamsource.md) to wait for the [MediaStreamSample](mediastreamsample.md). After you have assigned the [MediaStreamSample](mediastreamsample.md) to the [Sample](mediastreamsourcesamplerequest_sample.md) property of the [MediaStreamSourceSampleRequest](mediastreamsourcesamplerequest.md) object, call the [MediaStreamSourceSampleRequestDeferral.Complete](mediastreamsourcesamplerequestdeferral_complete_1807836922.md) method to end the deferral.

## -examples

## -see-also
