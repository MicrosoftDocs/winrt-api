---
-api-id: P:Windows.Media.Core.MediaStreamSourceStartingRequest.StartPosition
-api-type: winrt property
---

<!-- Property syntax
public Windows.Foundation.IReference<Windows.Foundation.TimeSpan> StartPosition { get; }
-->

# Windows.Media.Core.MediaStreamSourceStartingRequest.StartPosition

## -description
Specifies a reference to a [TimeSpan](https://msdn.microsoft.com/library/fbc6ecc2-6372-4b15-9532-3cd68a72e7b4) object which represents a time position in the media time-line from which the application should return [MediaStreamSample](mediastreamsample.md) objects.

## -property-value
A reference that points to a [TimeSpan](https://msdn.microsoft.com/library/fbc6ecc2-6372-4b15-9532-3cd68a72e7b4) which specifies the position in the media time-line to start sending [MediaStreamSample](mediastreamsample.md) objects. If the reference is **null**, the application should continue to return [MediaStreamSample](mediastreamsample.md) objects from the current position.

## -remarks
If *StartPosition* is not **null**, then the [TimeSpan](https://msdn.microsoft.com/library/fbc6ecc2-6372-4b15-9532-3cd68a72e7b4) specifies the position in the media time-line from which the application should deliver [MediaStreamSamples](mediastreamsample.md). If the reference is **null**, the application is not supposed to change its position and it should then continue to return [MediaStreamSamples](mediastreamsample.md) from the current position.

## -examples

## -see-also
