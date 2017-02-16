---
-api-id: M:Windows.Media.Core.MediaStreamSourceSampleRequest.ReportSampleProgress(System.UInt32)
-api-type: winrt method
---

<!-- Method syntax
public void ReportSampleProgress(System.UInt32 progress)
-->

# Windows.Media.Core.MediaStreamSourceSampleRequest.ReportSampleProgress

## -description
Provides a status update to the [MediaStreamSource](mediastreamsource.md) while the application is temporarily unable to deliver a requested [MediaStreamSample](mediastreamsample.md).

## -parameters
### -param progress
A value between 0 to 100 that indicates the progress towards being able to deliver the requested [MediaStreamSample](mediastreamsample.md).

## -remarks
The application should invoke this method when it is unable to immediately to deliver the [MediaStreamSample](mediastreamsample.md), which is accomplished by assigning it to the [Sample](mediastreamsourcesamplerequest_sample.md) property. The application should continue to invoke [ReportSampleProgress](mediastreamsourcesamplerequest_reportsampleprogress.md) on a regular basis until it is able to deliver the requested [MediaStreamSample](mediastreamsample.md).

The recommended interval between each invocation of [ReportSampleProgress](mediastreamsourcesamplerequest_reportsampleprogress.md) is 500 milliseconds.

## -examples

## -see-also
