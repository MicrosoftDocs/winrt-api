---
-api-id: P:Windows.Media.Core.MediaStreamSourceSampleRequest.StreamDescriptor
-api-type: winrt property
---

<!-- Property syntax
public Windows.Media.Core.IMediaStreamDescriptor StreamDescriptor { get; }
-->

# Windows.Media.Core.MediaStreamSourceSampleRequest.StreamDescriptor

## -description
Gets the [IMediaStreamDescriptor](imediastreamdescriptor.md) interface of the stream for which a [MediaStreamSample](mediastreamsample.md) is being requested.

## -property-value
The stream for which the [MediaStreamSample](mediastreamsample.md) is being requested.

## -remarks
The [Sample](mediastreamsourcesamplerequest_sample.md) property of the [MediaStreamSourceSampleRequest](mediastreamsourcesamplerequest.md) object should be assigned a [MediaStreamSample](mediastreamsample.md) belonging to the stream identified by the StreamDescriptor property.

## -examples

## -see-also
