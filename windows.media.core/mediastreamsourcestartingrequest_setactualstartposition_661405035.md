---
-api-id: M:Windows.Media.Core.MediaStreamSourceStartingRequest.SetActualStartPosition(Windows.Foundation.TimeSpan)
-api-type: winrt method
---

<!-- Method syntax
public void SetActualStartPosition(Windows.Foundation.TimeSpan position)
-->

# Windows.Media.Core.MediaStreamSourceStartingRequest.SetActualStartPosition

## -description
Specifies the starting position in the media time-line for subsequent [MediaStreamSamples](mediastreamsample.md) that will be delivered to the [MediaStreamSource](mediastreamsource.md).

## -parameters
### -param position
The actual starting point in the media time-line chosen by the application.

## -remarks
The application should choose the value of *position* such that the values of the [Timestamp](mediastreamsample_timestamp.md) property of the [MediaStreamSample](mediastreamsample.md) objects will be greater than or equal to position, for all currently selected streams.

## -examples

## -see-also
