---
-api-id: T:Windows.Media.Core.IMediaSource
-api-type: winrt interface
---

<!-- Interface syntax.
public interface IMediaSource : 
-->

# Windows.Media.Core.IMediaSource

## -description
Represents a media source that delivers media samples to a media pipeline.

## -remarks
The [IMediaSource](imediasource.md) interface is implemented by the [MediaStreamSource](mediastreamsource.md) runtime class and can also be implemented by other runtime classes.

Runtime classes that implement this interface must also implement the [IMFGetService](https://msdn.microsoft.com/library/windows/desktop/ms694261.aspx) interface and must support returning an [IMFMediaSource](https://msdn.microsoft.com/library/windows/desktop/ms700189.aspx) or an [IMFMediaSourceExtension](https://msdn.microsoft.com/library/windows/desktop/dn280726.aspx) interface when [IMFGetService.GetService](https://msdn.microsoft.com/library/windows/desktop/ms696978.aspx) method is invoked for the MF_MEDIASOURCE_SERVICE service.

## -examples

## -see-also