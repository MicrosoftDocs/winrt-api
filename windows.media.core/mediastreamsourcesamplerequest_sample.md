---
-api-id: P:Windows.Media.Core.MediaStreamSourceSampleRequest.Sample
-api-type: winrt property
---

<!-- Property syntax
public Windows.Media.Core.MediaStreamSample Sample { get;  set; }
-->

# Windows.Media.Core.MediaStreamSourceSampleRequest.Sample

## -description
Sets the [MediaStreamSample](mediastreamsample.md) requested by the [MediaStreamSource](mediastreamsource.md). Applications deliver a [MediaStreamSample](mediastreamsample.md) to the [MediaStreamSource](mediastreamsource.md) by assigning a value to this property.

## -property-value
The sample which is delivered to the [MediaStreamSource](mediastreamsource.md) when this property is set. The default value is **null**.

## -remarks
The initial value of this property is **null**.

The application should allocate a [MediaStreamSample](mediastreamsample.md) and deliver it to the [MediaStreamSource](mediastreamsource.md) by assigning the [MediaStreamSample](mediastreamsample.md) to this property.

If there are no more [MediaStreamSamples](mediastreamsample.md) to deliver to the stream identified by the [StreamDescriptor](mediastreamsourcesamplerequest_streamdescriptor.md) property because the end of the stream has been reached, then the application should set the Sample property to **null**.

If the application needs to perform an asynchronous operation to retrieve the [MediaStreamSample](mediastreamsample.md), it should invoke the [GetDeferral](mediastreamsourcesamplerequest_getdeferral_254836512.md) method to indicate that the assignment of the Sample property has been deferred.

If a [MediaStreamSample](mediastreamsample.md) is not currently available, for example, because it has not yet been downloaded from a server, the application should call [GetDeferral](mediastreamsourcesamplerequest_getdeferral_254836512.md) and also call [ReportSampleProgress](mediastreamsourcesamplerequest_reportsampleprogress_2045860101.md) on as the necessary data is being downloaded.

The recommended interval between each invocation of [ReportSampleProgress](mediastreamsourcesamplerequest_reportsampleprogress_2045860101.md) is 500 milliseconds.

## -examples

## -see-also
